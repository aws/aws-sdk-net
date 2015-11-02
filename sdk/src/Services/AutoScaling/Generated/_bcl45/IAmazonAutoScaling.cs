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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.AutoScaling.Model;

namespace Amazon.AutoScaling
{
    /// <summary>
    /// Interface for accessing AutoScaling
    ///
    /// Auto Scaling 
    /// <para>
    /// Auto Scaling is designed to automatically launch or terminate EC2 instances based
    /// on user-defined policies, schedules, and health checks. Use this service in conjunction
    /// with the Amazon CloudWatch and Elastic Load Balancing services.
    /// </para>
    /// </summary>
    public partial interface IAmazonAutoScaling : IDisposable
    {

        
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
        AttachInstancesResponse AttachInstances(AttachInstancesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AttachInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AttachInstancesResponse> AttachInstancesAsync(AttachInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        AttachLoadBalancersResponse AttachLoadBalancers(AttachLoadBalancersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AttachLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AttachLoadBalancersResponse> AttachLoadBalancersAsync(AttachLoadBalancersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CompleteLifecycleActionResponse CompleteLifecycleAction(CompleteLifecycleActionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CompleteLifecycleAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteLifecycleAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CompleteLifecycleActionResponse> CompleteLifecycleActionAsync(CompleteLifecycleActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateAutoScalingGroupResponse CreateAutoScalingGroup(CreateAutoScalingGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAutoScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoScalingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateAutoScalingGroupResponse> CreateAutoScalingGroupAsync(CreateAutoScalingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateLaunchConfigurationResponse CreateLaunchConfiguration(CreateLaunchConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateLaunchConfigurationResponse> CreateLaunchConfigurationAsync(CreateLaunchConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateOrUpdateTagsResponse CreateOrUpdateTags(CreateOrUpdateTagsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateOrUpdateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOrUpdateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateOrUpdateTagsResponse> CreateOrUpdateTagsAsync(CreateOrUpdateTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteAutoScalingGroupResponse DeleteAutoScalingGroup(DeleteAutoScalingGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAutoScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoScalingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteAutoScalingGroupResponse> DeleteAutoScalingGroupAsync(DeleteAutoScalingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteLaunchConfigurationResponse DeleteLaunchConfiguration(DeleteLaunchConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteLaunchConfigurationResponse> DeleteLaunchConfigurationAsync(DeleteLaunchConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteLifecycleHookResponse DeleteLifecycleHook(DeleteLifecycleHookRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLifecycleHook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleHook operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteLifecycleHookResponse> DeleteLifecycleHookAsync(DeleteLifecycleHookRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteNotificationConfigurationResponse DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfigurationAsync(DeleteNotificationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeletePolicyResponse DeletePolicy(DeletePolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteScheduledActionResponse DeleteScheduledAction(DeleteScheduledActionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteScheduledActionResponse> DeleteScheduledActionAsync(DeleteScheduledActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteTagsResponse DeleteTags(DeleteTagsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeAccountLimitsResponse DescribeAccountLimits();


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
        DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request);


        /// <summary>
        /// Describes the current Auto Scaling resource limits for your AWS account.
        /// 
        ///  
        /// <para>
        /// For information about requesting an increase in these limits, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">AWS
        /// Service Limits</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(DescribeAccountLimitsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeAdjustmentTypesResponse DescribeAdjustmentTypes();


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
        DescribeAdjustmentTypesResponse DescribeAdjustmentTypes(DescribeAdjustmentTypesRequest request);


        /// <summary>
        /// Describes the policy adjustment types for use with <a>PutScalingPolicy</a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        Task<DescribeAdjustmentTypesResponse> DescribeAdjustmentTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAdjustmentTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAdjustmentTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAdjustmentTypesResponse> DescribeAdjustmentTypesAsync(DescribeAdjustmentTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups();


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
        DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest request);


        /// <summary>
        /// Describes one or more Auto Scaling groups. If a list of names is not provided, the
        /// call describes all Auto Scaling groups.
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
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        Task<DescribeAutoScalingGroupsResponse> DescribeAutoScalingGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAutoScalingGroupsResponse> DescribeAutoScalingGroupsAsync(DescribeAutoScalingGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances();


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
        DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest request);


        /// <summary>
        /// Describes one or more Auto Scaling instances. If a list is not provided, the call
        /// describes all instances.
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
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        Task<DescribeAutoScalingInstancesResponse> DescribeAutoScalingInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAutoScalingInstancesResponse> DescribeAutoScalingInstancesAsync(DescribeAutoScalingInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes();


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
        DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes(DescribeAutoScalingNotificationTypesRequest request);


        /// <summary>
        /// Describes the notification types that are supported by Auto Scaling.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        Task<DescribeAutoScalingNotificationTypesResponse> DescribeAutoScalingNotificationTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingNotificationTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingNotificationTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeAutoScalingNotificationTypesResponse> DescribeAutoScalingNotificationTypesAsync(DescribeAutoScalingNotificationTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations();


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
        DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest request);


        /// <summary>
        /// Describes one or more launch configurations. If you omit the list of names, then the
        /// call describes all launch configurations.
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
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        Task<DescribeLaunchConfigurationsResponse> DescribeLaunchConfigurationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLaunchConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeLaunchConfigurationsResponse> DescribeLaunchConfigurationsAsync(DescribeLaunchConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeLifecycleHooksResponse DescribeLifecycleHooks(DescribeLifecycleHooksRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLifecycleHooks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHooks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeLifecycleHooksResponse> DescribeLifecycleHooksAsync(DescribeLifecycleHooksRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeLifecycleHookTypesResponse DescribeLifecycleHookTypes(DescribeLifecycleHookTypesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLifecycleHookTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHookTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeLifecycleHookTypesResponse> DescribeLifecycleHookTypesAsync(DescribeLifecycleHookTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes();


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
        DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes(DescribeMetricCollectionTypesRequest request);


        /// <summary>
        /// Describes the available CloudWatch metrics for Auto Scaling.
        /// 
        ///  
        /// <para>
        /// Note that the <code>GroupStandbyInstances</code> metric is not returned by default.
        /// You must explicitly request this metric when calling <a>EnableMetricsCollection</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        Task<DescribeMetricCollectionTypesResponse> DescribeMetricCollectionTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMetricCollectionTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricCollectionTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeMetricCollectionTypesResponse> DescribeMetricCollectionTypesAsync(DescribeMetricCollectionTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations();


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
        DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest request);


        /// <summary>
        /// Describes the notification actions associated with the specified Auto Scaling group.
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
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotificationConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurationsAsync(DescribeNotificationConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribePoliciesResponse DescribePolicies();


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
        DescribePoliciesResponse DescribePolicies(DescribePoliciesRequest request);


        /// <summary>
        /// Describes the policies for the specified Auto Scaling group.
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
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        Task<DescribePoliciesResponse> DescribePoliciesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribePoliciesResponse> DescribePoliciesAsync(DescribePoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeScalingActivitiesResponse DescribeScalingActivities();


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
        DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest request);


        /// <summary>
        /// Describes one or more scaling activities for the specified Auto Scaling group. If
        /// you omit the <code>ActivityIds</code>, the call returns all activities from the past
        /// six weeks. Activities are sorted by the start time. Activities still in progress appear
        /// first on the list.
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
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingActivities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(DescribeScalingActivitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeScalingProcessTypesResponse DescribeScalingProcessTypes();


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
        DescribeScalingProcessTypesResponse DescribeScalingProcessTypes(DescribeScalingProcessTypesRequest request);


        /// <summary>
        /// Describes the scaling process types for use with <a>ResumeProcesses</a> and <a>SuspendProcesses</a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        Task<DescribeScalingProcessTypesResponse> DescribeScalingProcessTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingProcessTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingProcessTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeScalingProcessTypesResponse> DescribeScalingProcessTypesAsync(DescribeScalingProcessTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeScheduledActionsResponse DescribeScheduledActions();


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
        DescribeScheduledActionsResponse DescribeScheduledActions(DescribeScheduledActionsRequest request);


        /// <summary>
        /// Describes the actions scheduled for your Auto Scaling group that haven't run. To describe
        /// the actions that have already run, use <a>DescribeScalingActivities</a>.
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
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        Task<DescribeScheduledActionsResponse> DescribeScheduledActionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScheduledActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeScheduledActionsResponse> DescribeScheduledActionsAsync(DescribeScheduledActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeTagsResponse DescribeTags();


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
        DescribeTagsResponse DescribeTags(DescribeTagsRequest request);


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        Task<DescribeTagsResponse> DescribeTagsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes();


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
        DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes(DescribeTerminationPolicyTypesRequest request);


        /// <summary>
        /// Describes the termination policies supported by Auto Scaling.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        Task<DescribeTerminationPolicyTypesResponse> DescribeTerminationPolicyTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTerminationPolicyTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTerminationPolicyTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTerminationPolicyTypesResponse> DescribeTerminationPolicyTypesAsync(DescribeTerminationPolicyTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DetachInstancesResponse DetachInstances(DetachInstancesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DetachInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DetachInstancesResponse> DetachInstancesAsync(DetachInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DetachLoadBalancersResponse DetachLoadBalancers(DetachLoadBalancersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DetachLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DetachLoadBalancersResponse> DetachLoadBalancersAsync(DetachLoadBalancersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DisableMetricsCollectionResponse DisableMetricsCollection(DisableMetricsCollectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DisableMetricsCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableMetricsCollection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisableMetricsCollectionResponse> DisableMetricsCollectionAsync(DisableMetricsCollectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        EnableMetricsCollectionResponse EnableMetricsCollection(EnableMetricsCollectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the EnableMetricsCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableMetricsCollection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<EnableMetricsCollectionResponse> EnableMetricsCollectionAsync(EnableMetricsCollectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        EnterStandbyResponse EnterStandby(EnterStandbyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the EnterStandby operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnterStandby operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<EnterStandbyResponse> EnterStandbyAsync(EnterStandbyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ExecutePolicyResponse ExecutePolicy(ExecutePolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ExecutePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecutePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ExecutePolicyResponse> ExecutePolicyAsync(ExecutePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ExitStandbyResponse ExitStandby(ExitStandbyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ExitStandby operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExitStandby operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ExitStandbyResponse> ExitStandbyAsync(ExitStandbyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ///  
        /// <para>
        /// If you exceed your maximum limit of lifecycle hooks, which by default is 50 per region,
        /// the call fails. For information about updating this limit, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">AWS
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
        PutLifecycleHookResponse PutLifecycleHook(PutLifecycleHookRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutLifecycleHook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleHook operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutLifecycleHookResponse> PutLifecycleHookAsync(PutLifecycleHookRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        PutNotificationConfigurationResponse PutNotificationConfiguration(PutNotificationConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutNotificationConfigurationResponse> PutNotificationConfigurationAsync(PutNotificationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        PutScheduledUpdateGroupActionResponse PutScheduledUpdateGroupAction(PutScheduledUpdateGroupActionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutScheduledUpdateGroupAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutScheduledUpdateGroupActionResponse> PutScheduledUpdateGroupActionAsync(PutScheduledUpdateGroupActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        RecordLifecycleActionHeartbeatResponse RecordLifecycleActionHeartbeat(RecordLifecycleActionHeartbeatRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RecordLifecycleActionHeartbeat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecordLifecycleActionHeartbeat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RecordLifecycleActionHeartbeatResponse> RecordLifecycleActionHeartbeatAsync(RecordLifecycleActionHeartbeatRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ResumeProcessesResponse ResumeProcesses(ResumeProcessesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ResumeProcesses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResumeProcesses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ResumeProcessesResponse> ResumeProcessesAsync(ResumeProcessesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        SetDesiredCapacityResponse SetDesiredCapacity(SetDesiredCapacityRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SetDesiredCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDesiredCapacity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetDesiredCapacityResponse> SetDesiredCapacityAsync(SetDesiredCapacityRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        SetInstanceHealthResponse SetInstanceHealth(SetInstanceHealthRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SetInstanceHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceHealth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetInstanceHealthResponse> SetInstanceHealthAsync(SetInstanceHealthRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        SuspendProcessesResponse SuspendProcesses(SuspendProcessesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SuspendProcesses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SuspendProcesses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SuspendProcessesResponse> SuspendProcessesAsync(SuspendProcessesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The Auto Scaling group can't be deleted because there are scaling activities in progress.
        /// </exception>
        TerminateInstanceInAutoScalingGroupResponse TerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the TerminateInstanceInAutoScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstanceInAutoScalingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<TerminateInstanceInAutoScalingGroupResponse> TerminateInstanceInAutoScalingGroupAsync(TerminateInstanceInAutoScalingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateAutoScalingGroupResponse UpdateAutoScalingGroup(UpdateAutoScalingGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAutoScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoScalingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateAutoScalingGroupResponse> UpdateAutoScalingGroupAsync(UpdateAutoScalingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}