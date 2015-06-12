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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    


        #endregion

        #region Dispose

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
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/attach-instance-asg.html">Attach
        /// EC2 Instances to Your Auto Scaling Group</a> in the <i>Auto Scaling Developer Guide</i>.
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
        /// <param name="request">Container for the necessary parameters to execute the AttachInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AttachInstancesResponse> AttachInstancesAsync(AttachInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachInstancesRequestMarshaller();
            var unmarshaller = AttachInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<AttachInstancesRequest,AttachInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachLoadBalancers

        /// <summary>
        /// Attaches one or more load balancers to the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// To describe the load balancers for an Auto Scaling group, use <a>DescribeLoadBalancers</a>.
        /// To detach the load balancer from the Auto Scaling group, use <a>DetachLoadBalancers</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/attach-load-balancer-asg.html">Attach
        /// a Load Balancer to Your Auto Scaling Group</a> in the <i>Auto Scaling Developer Guide</i>.
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
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AttachLoadBalancersResponse> AttachLoadBalancersAsync(AttachLoadBalancersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachLoadBalancersRequestMarshaller();
            var unmarshaller = AttachLoadBalancersResponseUnmarshaller.Instance;

            return InvokeAsync<AttachLoadBalancersRequest,AttachLoadBalancersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CompleteLifecycleAction

        /// <summary>
        /// Completes the lifecycle action for the associated token initiated under the given
        /// lifecycle hook with the specified result. 
        /// 
        ///  
        /// <para>
        /// This operation is a part of the basic sequence for adding a lifecycle hook to an Auto
        /// Scaling group:
        /// </para>
        ///  <ol> <li>Create a notification target. A target can be either an Amazon SQS queue
        /// or an Amazon SNS topic.</li> <li>Create an IAM role. This role allows Auto Scaling
        /// to publish lifecycle notifications to the designated SQS queue or SNS topic.</li>
        /// <li>Create the lifecycle hook. You can create a hook that acts when instances launch
        /// or when instances terminate.</li> <li>If necessary, record the lifecycle action heartbeat
        /// to keep the instance in a pending state.</li> <li> <b>Complete the lifecycle action</b>.</li>
        /// </ol> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingPendingState.html">Auto
        /// Scaling Pending State</a> and <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingTerminatingState.html">Auto
        /// Scaling Terminating State</a> in the <i>Auto Scaling Developer Guide</i>.
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
        /// <param name="request">Container for the necessary parameters to execute the CompleteLifecycleAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CompleteLifecycleActionResponse> CompleteLifecycleActionAsync(CompleteLifecycleActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CompleteLifecycleActionRequestMarshaller();
            var unmarshaller = CompleteLifecycleActionResponseUnmarshaller.Instance;

            return InvokeAsync<CompleteLifecycleActionRequest,CompleteLifecycleActionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAutoScalingGroup

        /// <summary>
        /// Creates an Auto Scaling group with the specified name and attributes.
        /// 
        ///  
        /// <para>
        /// If you exceed your maximum limit of Auto Scaling groups, which by default is 20 per
        /// region, the call fails. For information about viewing and updating these limits, see
        /// <a>DescribeAccountLimits</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingGroup.html">Auto
        /// Scaling Groups</a> in the <i>Auto Scaling Developer Guide</i>.
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
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoScalingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateAutoScalingGroupResponse> CreateAutoScalingGroupAsync(CreateAutoScalingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAutoScalingGroupRequestMarshaller();
            var unmarshaller = CreateAutoScalingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAutoScalingGroupRequest,CreateAutoScalingGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateLaunchConfiguration

        /// <summary>
        /// Creates a launch configuration.
        /// 
        ///  
        /// <para>
        /// If you exceed your maximum limit of launch configurations, which by default is 100
        /// per region, the call fails. For information about viewing and updating these limits,
        /// see <a>DescribeAccountLimits</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/LaunchConfiguration.html">Launch
        /// Configurations</a> in the <i>Auto Scaling Developer Guide</i>.
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
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateLaunchConfigurationResponse> CreateLaunchConfigurationAsync(CreateLaunchConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLaunchConfigurationRequestMarshaller();
            var unmarshaller = CreateLaunchConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLaunchConfigurationRequest,CreateLaunchConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateOrUpdateTags

        /// <summary>
        /// Creates or updates tags for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// A tag is defined by its resource ID, resource type, key, value, and propagate flag.
        /// The value and the propagate flag are optional parameters. The only supported resource
        /// type is <code>auto-scaling-group</code>, and the resource ID must be the name of the
        /// group. The <code>PropagateAtLaunch</code> flag determines whether the tag is added
        /// to instances launched in the group. Valid values are <code>true</code> or <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// When you specify a tag with a key that already exists, the operation overwrites the
        /// previous tag definition, and you do not get an error message.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/ASTagging.html">Tagging
        /// Auto Scaling Groups and Instances</a> in the <i>Auto Scaling Developer Guide</i>.
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
        /// <param name="request">Container for the necessary parameters to execute the CreateOrUpdateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateOrUpdateTagsResponse> CreateOrUpdateTagsAsync(CreateOrUpdateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateOrUpdateTagsRequestMarshaller();
            var unmarshaller = CreateOrUpdateTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOrUpdateTagsRequest,CreateOrUpdateTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAutoScalingGroup

        /// <summary>
        /// Deletes the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// The group must have no instances and no scaling activities in progress.
        /// </para>
        ///  
        /// <para>
        /// To remove all instances before calling <code>DeleteAutoScalingGroup</code>, call <a>UpdateAutoScalingGroup</a>
        /// to set the minimum and maximum size of the Auto Scaling group to zero.
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
        /// The Auto Scaling group or launch configuration can't be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// The Auto Scaling group can't be deleted because there are scaling activities in progress.
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoScalingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteAutoScalingGroupResponse> DeleteAutoScalingGroupAsync(DeleteAutoScalingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAutoScalingGroupRequestMarshaller();
            var unmarshaller = DeleteAutoScalingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAutoScalingGroupRequest,DeleteAutoScalingGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The Auto Scaling group or launch configuration can't be deleted because it is in use.
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteLaunchConfigurationResponse> DeleteLaunchConfigurationAsync(DeleteLaunchConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLaunchConfigurationRequestMarshaller();
            var unmarshaller = DeleteLaunchConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLaunchConfigurationRequest,DeleteLaunchConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleHook operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteLifecycleHookResponse> DeleteLifecycleHookAsync(DeleteLifecycleHookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLifecycleHookRequestMarshaller();
            var unmarshaller = DeleteLifecycleHookResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLifecycleHookRequest,DeleteLifecycleHookResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfigurationAsync(DeleteNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteNotificationConfigurationRequestMarshaller();
            var unmarshaller = DeleteNotificationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNotificationConfigurationRequest,DeleteNotificationConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeletePolicy

        /// <summary>
        /// Deletes the specified Auto Scaling policy.
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
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeletePolicyRequestMarshaller();
            var unmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePolicyRequest,DeletePolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteScheduledActionResponse> DeleteScheduledActionAsync(DeleteScheduledActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteScheduledActionRequestMarshaller();
            var unmarshaller = DeleteScheduledActionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScheduledActionRequest,DeleteScheduledActionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(DescribeAccountLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAccountLimitsRequestMarshaller();
            var unmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountLimitsRequest,DescribeAccountLimitsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAdjustmentTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeAdjustmentTypesResponse> DescribeAdjustmentTypesAsync(DescribeAdjustmentTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAdjustmentTypesRequestMarshaller();
            var unmarshaller = DescribeAdjustmentTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAdjustmentTypesRequest,DescribeAdjustmentTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAutoScalingGroups

        /// <summary>
        /// Describes one or more Auto Scaling groups. If a list of names is not provided, the
        /// call describes all Auto Scaling groups.
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
        /// Describes one or more Auto Scaling groups. If a list of names is not provided, the
        /// call describes all Auto Scaling groups.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeAutoScalingGroupsResponse> DescribeAutoScalingGroupsAsync(DescribeAutoScalingGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAutoScalingGroupsRequestMarshaller();
            var unmarshaller = DescribeAutoScalingGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAutoScalingGroupsRequest,DescribeAutoScalingGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAutoScalingInstances

        /// <summary>
        /// Describes one or more Auto Scaling instances. If a list is not provided, the call
        /// describes all instances.
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
        /// Describes one or more Auto Scaling instances. If a list is not provided, the call
        /// describes all instances.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeAutoScalingInstancesResponse> DescribeAutoScalingInstancesAsync(DescribeAutoScalingInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAutoScalingInstancesRequestMarshaller();
            var unmarshaller = DescribeAutoScalingInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAutoScalingInstancesRequest,DescribeAutoScalingInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingNotificationTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeAutoScalingNotificationTypesResponse> DescribeAutoScalingNotificationTypesAsync(DescribeAutoScalingNotificationTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAutoScalingNotificationTypesRequestMarshaller();
            var unmarshaller = DescribeAutoScalingNotificationTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAutoScalingNotificationTypesRequest,DescribeAutoScalingNotificationTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLaunchConfigurations

        /// <summary>
        /// Describes one or more launch configurations. If you omit the list of names, then the
        /// call describes all launch configurations.
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
        /// Describes one or more launch configurations. If you omit the list of names, then the
        /// call describes all launch configurations.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeLaunchConfigurationsResponse> DescribeLaunchConfigurationsAsync(DescribeLaunchConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLaunchConfigurationsRequestMarshaller();
            var unmarshaller = DescribeLaunchConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLaunchConfigurationsRequest,DescribeLaunchConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHooks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeLifecycleHooksResponse> DescribeLifecycleHooksAsync(DescribeLifecycleHooksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLifecycleHooksRequestMarshaller();
            var unmarshaller = DescribeLifecycleHooksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLifecycleHooksRequest,DescribeLifecycleHooksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHookTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeLifecycleHookTypesResponse> DescribeLifecycleHookTypesAsync(DescribeLifecycleHookTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLifecycleHookTypesRequestMarshaller();
            var unmarshaller = DescribeLifecycleHookTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLifecycleHookTypesRequest,DescribeLifecycleHookTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBalancers

        /// <summary>
        /// Describes the load balancers for the specified Auto Scaling group.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLoadBalancersRequestMarshaller();
            var unmarshaller = DescribeLoadBalancersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoadBalancersRequest,DescribeLoadBalancersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricCollectionTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeMetricCollectionTypesResponse> DescribeMetricCollectionTypesAsync(DescribeMetricCollectionTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeMetricCollectionTypesRequestMarshaller();
            var unmarshaller = DescribeMetricCollectionTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMetricCollectionTypesRequest,DescribeMetricCollectionTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurationsAsync(DescribeNotificationConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeNotificationConfigurationsRequestMarshaller();
            var unmarshaller = DescribeNotificationConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNotificationConfigurationsRequest,DescribeNotificationConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribePolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribePoliciesResponse> DescribePoliciesAsync(DescribePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribePoliciesRequestMarshaller();
            var unmarshaller = DescribePoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePoliciesRequest,DescribePoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalingActivities

        /// <summary>
        /// Describes one or more scaling activities for the specified Auto Scaling group. If
        /// you omit the <code>ActivityIds</code>, the call returns all activities from the past
        /// six weeks. Activities are sorted by the start time. Activities still in progress appear
        /// first on the list.
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
        /// Describes one or more scaling activities for the specified Auto Scaling group. If
        /// you omit the <code>ActivityIds</code>, the call returns all activities from the past
        /// six weeks. Activities are sorted by the start time. Activities still in progress appear
        /// first on the list.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(DescribeScalingActivitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeScalingActivitiesRequestMarshaller();
            var unmarshaller = DescribeScalingActivitiesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalingActivitiesRequest,DescribeScalingActivitiesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingProcessTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeScalingProcessTypesResponse> DescribeScalingProcessTypesAsync(DescribeScalingProcessTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeScalingProcessTypesRequestMarshaller();
            var unmarshaller = DescribeScalingProcessTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalingProcessTypesRequest,DescribeScalingProcessTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeScheduledActionsResponse> DescribeScheduledActionsAsync(DescribeScheduledActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeScheduledActionsRequestMarshaller();
            var unmarshaller = DescribeScheduledActionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScheduledActionsRequest,DescribeScheduledActionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeTerminationPolicyTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeTerminationPolicyTypesResponse> DescribeTerminationPolicyTypesAsync(DescribeTerminationPolicyTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTerminationPolicyTypesRequestMarshaller();
            var unmarshaller = DescribeTerminationPolicyTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTerminationPolicyTypesRequest,DescribeTerminationPolicyTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachInstances

        /// <summary>
        /// Removes one or more instances from the specified Auto Scaling group. After the instances
        /// are detached, you can manage them independently from the rest of the Auto Scaling
        /// group.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/detach-instance-asg.html">Detach
        /// EC2 Instances from Your Auto Scaling Group</a> in the <i>Auto Scaling Developer Guide</i>.
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
        /// <param name="request">Container for the necessary parameters to execute the DetachInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DetachInstancesResponse> DetachInstancesAsync(DetachInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachInstancesRequestMarshaller();
            var unmarshaller = DetachInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DetachInstancesRequest,DetachInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachLoadBalancers

        /// <summary>
        /// Removes one or more load balancers from the specified Auto Scaling group.
        /// 
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
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DetachLoadBalancersResponse> DetachLoadBalancersAsync(DetachLoadBalancersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachLoadBalancersRequestMarshaller();
            var unmarshaller = DetachLoadBalancersResponseUnmarshaller.Instance;

            return InvokeAsync<DetachLoadBalancersRequest,DetachLoadBalancersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableMetricsCollection

        /// <summary>
        /// Disables monitoring of the specified metrics for the specified Auto Scaling group.
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
        /// <param name="request">Container for the necessary parameters to execute the DisableMetricsCollection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DisableMetricsCollectionResponse> DisableMetricsCollectionAsync(DisableMetricsCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableMetricsCollectionRequestMarshaller();
            var unmarshaller = DisableMetricsCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<DisableMetricsCollectionRequest,DisableMetricsCollectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableMetricsCollection

        /// <summary>
        /// Enables monitoring of the specified metrics for the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// You can only enable metrics collection if <code>InstanceMonitoring</code> in the launch
        /// configuration for the group is set to <code>True</code>.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the EnableMetricsCollection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<EnableMetricsCollectionResponse> EnableMetricsCollectionAsync(EnableMetricsCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableMetricsCollectionRequestMarshaller();
            var unmarshaller = EnableMetricsCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<EnableMetricsCollectionRequest,EnableMetricsCollectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnterStandby

        /// <summary>
        /// Moves the specified instances into <code>Standby</code> mode.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingInServiceState.html">Auto
        /// Scaling InService State</a> in the <i>Auto Scaling Developer Guide</i>.
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
        /// <param name="request">Container for the necessary parameters to execute the EnterStandby operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<EnterStandbyResponse> EnterStandbyAsync(EnterStandbyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnterStandbyRequestMarshaller();
            var unmarshaller = EnterStandbyResponseUnmarshaller.Instance;

            return InvokeAsync<EnterStandbyRequest,EnterStandbyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The Auto Scaling group can't be deleted because there are scaling activities in progress.
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
        /// <param name="request">Container for the necessary parameters to execute the ExecutePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ExecutePolicyResponse> ExecutePolicyAsync(ExecutePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ExecutePolicyRequestMarshaller();
            var unmarshaller = ExecutePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<ExecutePolicyRequest,ExecutePolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ExitStandby

        /// <summary>
        /// Moves the specified instances out of <code>Standby</code> mode.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingInServiceState.html">Auto
        /// Scaling InService State</a> in the <i>Auto Scaling Developer Guide</i>.
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
        /// <param name="request">Container for the necessary parameters to execute the ExitStandby operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ExitStandbyResponse> ExitStandbyAsync(ExitStandbyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ExitStandbyRequestMarshaller();
            var unmarshaller = ExitStandbyResponseUnmarshaller.Instance;

            return InvokeAsync<ExitStandbyRequest,ExitStandbyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// This operation is a part of the basic sequence for adding a lifecycle hook to an Auto
        /// Scaling group:
        /// </para>
        ///  <ol> <li>Create a notification target. A target can be either an Amazon SQS queue
        /// or an Amazon SNS topic.</li> <li>Create an IAM role. This role allows Auto Scaling
        /// to publish lifecycle notifications to the designated SQS queue or SNS topic.</li>
        /// <li><b>Create the lifecycle hook. You can create a hook that acts when instances launch
        /// or when instances terminate.</b></li> <li>If necessary, record the lifecycle action
        /// heartbeat to keep the instance in a pending state.</li> <li>Complete the lifecycle
        /// action.</li> </ol> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingPendingState.html">Auto
        /// Scaling Pending State</a> and <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingTerminatingState.html">Auto
        /// Scaling Terminating State</a> in the <i>Auto Scaling Developer Guide</i>.
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
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleHook operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutLifecycleHookResponse> PutLifecycleHookAsync(PutLifecycleHookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutLifecycleHookRequestMarshaller();
            var unmarshaller = PutLifecycleHookResponseUnmarshaller.Instance;

            return InvokeAsync<PutLifecycleHookRequest,PutLifecycleHookResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutNotificationConfiguration

        /// <summary>
        /// Configures an Auto Scaling group to send notifications when specified events take
        /// place. Subscribers to this topic can have messages for events delivered to an endpoint
        /// such as a web server or email address. 
        /// 
        ///  
        /// <para>
        /// For more information see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/ASGettingNotifications.html">Getting
        /// Notifications When Your Auto Scaling Group Changes</a> in the <i>Auto Scaling Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This configuration overwrites an existing configuration.
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
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutNotificationConfigurationResponse> PutNotificationConfigurationAsync(PutNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutNotificationConfigurationRequestMarshaller();
            var unmarshaller = PutNotificationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutNotificationConfigurationRequest,PutNotificationConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutScalingPolicy

        /// <summary>
        /// Creates or updates a policy for an Auto Scaling group. To update an existing policy,
        /// use the existing policy name and set the parameters you want to change. Any existing
        /// parameter not changed in an update to an existing policy is not changed in this update
        /// request.
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
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutScalingPolicyRequestMarshaller();
            var unmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutScalingPolicyRequest,PutScalingPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// Scaling</a> in the <i>Auto Scaling Developer Guide</i>.
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
        /// <param name="request">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutScheduledUpdateGroupActionResponse> PutScheduledUpdateGroupActionAsync(PutScheduledUpdateGroupActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutScheduledUpdateGroupActionRequestMarshaller();
            var unmarshaller = PutScheduledUpdateGroupActionResponseUnmarshaller.Instance;

            return InvokeAsync<PutScheduledUpdateGroupActionRequest,PutScheduledUpdateGroupActionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RecordLifecycleActionHeartbeat

        /// <summary>
        /// Records a heartbeat for the lifecycle action associated with a specific token. This
        /// extends the timeout by the length of time defined by the <code>HeartbeatTimeout</code>
        /// parameter of <a>PutLifecycleHook</a>.
        /// 
        ///  
        /// <para>
        /// This operation is a part of the basic sequence for adding a lifecycle hook to an Auto
        /// Scaling group:
        /// </para>
        ///  <ol> <li>Create a notification target. A target can be either an Amazon SQS queue
        /// or an Amazon SNS topic.</li> <li>Create an IAM role. This role allows Auto Scaling
        /// to publish lifecycle notifications to the designated SQS queue or SNS topic.</li>
        /// <li>Create the lifecycle hook. You can create a hook that acts when instances launch
        /// or when instances terminate.</li> <li><b>If necessary, record the lifecycle action
        /// heartbeat to keep the instance in a pending state.</b></li> <li>Complete the lifecycle
        /// action.</li> </ol> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingPendingState.html">Auto
        /// Scaling Pending State</a> and <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingTerminatingState.html">Auto
        /// Scaling Terminating State</a> in the <i>Auto Scaling Developer Guide</i>.
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
        /// <param name="request">Container for the necessary parameters to execute the RecordLifecycleActionHeartbeat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RecordLifecycleActionHeartbeatResponse> RecordLifecycleActionHeartbeatAsync(RecordLifecycleActionHeartbeatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RecordLifecycleActionHeartbeatRequestMarshaller();
            var unmarshaller = RecordLifecycleActionHeartbeatResponseUnmarshaller.Instance;

            return InvokeAsync<RecordLifecycleActionHeartbeatRequest,RecordLifecycleActionHeartbeatResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResumeProcesses

        /// <summary>
        /// Resumes the specified suspended Auto Scaling processes for the specified Auto Scaling
        /// group. To resume specific processes, use the <code>ScalingProcesses</code> parameter.
        /// To resume all processes, omit the <code>ScalingProcesses</code> parameter. For more
        /// information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_SuspendResume.html">Suspend
        /// and Resume Auto Scaling Processes</a> in the <i>Auto Scaling Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeProcesses service method.</param>
        /// 
        /// <returns>The response from the ResumeProcesses service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceInUseException">
        /// The Auto Scaling group or launch configuration can't be deleted because it is in use.
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
        /// <param name="request">Container for the necessary parameters to execute the ResumeProcesses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ResumeProcessesResponse> ResumeProcessesAsync(ResumeProcessesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResumeProcessesRequestMarshaller();
            var unmarshaller = ResumeProcessesResponseUnmarshaller.Instance;

            return InvokeAsync<ResumeProcessesRequest,ResumeProcessesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetDesiredCapacity

        /// <summary>
        /// Sets the size of the specified Auto Scaling group.
        /// 
        ///  
        /// <para>
        /// For more information about desired capacity, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/WhatIsAutoScaling.html">What
        /// Is Auto Scaling?</a> in the <i>Auto Scaling Developer Guide</i>.
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
        /// The Auto Scaling group can't be deleted because there are scaling activities in progress.
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
        /// <param name="request">Container for the necessary parameters to execute the SetDesiredCapacity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetDesiredCapacityResponse> SetDesiredCapacityAsync(SetDesiredCapacityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetDesiredCapacityRequestMarshaller();
            var unmarshaller = SetDesiredCapacityResponseUnmarshaller.Instance;

            return InvokeAsync<SetDesiredCapacityRequest,SetDesiredCapacityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetInstanceHealth

        /// <summary>
        /// Sets the health status of the specified instance.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/healthcheck.html">Health
        /// Checks</a> in the <i>Auto Scaling Developer Guide</i>.
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
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceHealth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetInstanceHealthResponse> SetInstanceHealthAsync(SetInstanceHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetInstanceHealthRequestMarshaller();
            var unmarshaller = SetInstanceHealthResponseUnmarshaller.Instance;

            return InvokeAsync<SetInstanceHealthRequest,SetInstanceHealthResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SuspendProcesses

        /// <summary>
        /// Suspends the specified Auto Scaling processes for the specified Auto Scaling group.
        /// To suspend specific processes, use the <code>ScalingProcesses</code> parameter. To
        /// suspend all processes, omit the <code>ScalingProcesses</code> parameter.
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
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_SuspendResume.html">Suspend
        /// and Resume Auto Scaling Processes</a> in the <i>Auto Scaling Developer Guide</i>.
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
        /// The Auto Scaling group or launch configuration can't be deleted because it is in use.
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
        /// <param name="request">Container for the necessary parameters to execute the SuspendProcesses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SuspendProcessesResponse> SuspendProcessesAsync(SuspendProcessesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SuspendProcessesRequestMarshaller();
            var unmarshaller = SuspendProcessesResponseUnmarshaller.Instance;

            return InvokeAsync<SuspendProcessesRequest,SuspendProcessesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TerminateInstanceInAutoScalingGroup

        /// <summary>
        /// Terminates the specified instance and optionally adjusts the desired group size.
        /// 
        ///  
        /// <para>
        /// This call simply makes a termination request. The instances is not terminated immediately.
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
        /// The Auto Scaling group can't be deleted because there are scaling activities in progress.
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
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstanceInAutoScalingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<TerminateInstanceInAutoScalingGroupResponse> TerminateInstanceInAutoScalingGroupAsync(TerminateInstanceInAutoScalingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TerminateInstanceInAutoScalingGroupRequestMarshaller();
            var unmarshaller = TerminateInstanceInAutoScalingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateInstanceInAutoScalingGroupRequest,TerminateInstanceInAutoScalingGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// The Auto Scaling group can't be deleted because there are scaling activities in progress.
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoScalingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateAutoScalingGroupResponse> UpdateAutoScalingGroupAsync(UpdateAutoScalingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateAutoScalingGroupRequestMarshaller();
            var unmarshaller = UpdateAutoScalingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAutoScalingGroupRequest,UpdateAutoScalingGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}