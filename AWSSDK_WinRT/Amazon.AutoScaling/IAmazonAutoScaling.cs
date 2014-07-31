/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Threading;
using System.Threading.Tasks;

using Amazon.AutoScaling.Model;

namespace Amazon.AutoScaling
{
    /// <summary>
    /// Implementation for accessing AutoScaling
    /// 
    /// Auto Scaling
    /// <para>
    /// Auto Scaling is a web service designed to automatically launch or terminate Amazon
    /// Elastic Compute Cloud (Amazon EC2) instances based on user-defined policies, schedules,
    /// and health checks. This service is used in conjunction with Amazon CloudWatch and
    /// Elastic Load Balancing services.
    /// </para>
    /// 
    /// <para>
    /// Auto Scaling provides APIs that you can call by submitting a Query Request. Query
    /// requests are HTTP or HTTPS requests that use the HTTP verbs GET or POST and a Query
    /// parameter named <i>Action</i> or <i>Operation</i> that specifies the API you are calling.
    /// Action is used throughout this documentation, although Operation is also supported
    /// for backward compatibility with other Amazon Web Services (AWS) Query APIs.
    /// </para>
    /// 
    /// <para>
    /// Calling the API using a Query request is the most direct way to access the web service,
    /// but requires that your application handle low-level details such as generating the
    /// hash to sign the request and error handling. The benefit of calling the service using
    /// a Query request is that you are assured of having access to the complete functionality
    /// of the API. For information about signing a a query request, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/api_requests.html">Use
    /// Query Requests to Call Auto Scaling APIs</a>
    /// </para>
    /// 
    /// <para>
    /// This guide provides detailed information about Auto Scaling actions, data types,
    /// parameters, and errors. For detailed information about Auto Scaling features and their
    /// associated API actions, go to the <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/">Auto
    /// Scaling Developer Guide</a>.
    /// </para>
    /// 
    /// <para>
    /// This reference is based on the current WSDL, which is available at:
    /// </para>
    /// 
    /// <para>
    /// <a href="http://autoscaling.amazonaws.com/doc/2011-01-01/AutoScaling.wsdl">http://autoscaling.amazonaws.com/doc/2011-01-01/AutoScaling.wsdl</a>
    /// 
    /// </para>
    /// 
    /// <para>
    /// <b>Endpoints</b>
    /// </para>
    /// 
    /// <para>
    /// The examples in this guide assume that your instances are launched in the US East
    /// (Northern Virginia) region and use us-east-1 as the endpoint.
    /// </para>
    /// 
    /// <para>
    /// You can set up your Auto Scaling infrastructure in other AWS regions. For information
    /// about this product's regions and endpoints, see <a href="http://docs.aws.amazon.com/general/latest/gr/index.html?rande.html">Regions
    /// and Endpoints</a> in the Amazon Web Services General Reference.
    /// </para>
    /// </summary>
	public partial interface IAmazonAutoScaling : IDisposable
    {
 
        /// <summary>
        /// Attaches one or more Amazon EC2 instances to an existing Auto Scaling group. After
        /// the instance(s) is attached, it becomes a part of the Auto Scaling group.
        /// 
        /// 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/attach-instance-asg.html">Attach
        /// Amazon EC2 Instances to Your Existing Auto Scaling Group</a> in the <i>Auto Scaling
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachInstances service method.</param>
        /// 
        /// <returns>The response from the AttachInstances service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<AttachInstancesResponse> AttachInstancesAsync(AttachInstancesRequest attachInstancesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Completes the lifecycle action for the associated token initiated under the given
        /// lifecycle hook with the specified result.
        /// 
        /// 
        /// <para>
        /// This operation is a part of the basic sequence for adding a lifecycle hook to an
        /// Auto Scaling group:
        /// </para>
        /// <ol> <li> Create a notification target. A target can be either an Amazon SQS queue
        /// or an Amazon SNS topic. </li> <li> Create an IAM role. This role allows Auto Scaling
        /// to publish lifecycle notifications to the designated SQS queue or SNS topic. </li>
        /// <li> Create the lifecycle hook. You can create a hook that acts when instances launch
        /// or when instances terminate. </li> <li> If necessary, record the lifecycle action
        /// heartbeat to keep the instance in a pending state. </li> <li> <b>Complete the lifecycle
        /// action.</b> </li> </ol>
        /// <para>
        /// To learn more, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingPendingState.html">Auto
        /// Scaling Pending State</a> and <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingTerminatingState.html">Auto
        /// Scaling Terminating State</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteLifecycleAction service method.</param>
        /// 
        /// <returns>The response from the CompleteLifecycleAction service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CompleteLifecycleActionResponse> CompleteLifecycleActionAsync(CompleteLifecycleActionRequest completeLifecycleActionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Creates a new Auto Scaling group with the specified name and other attributes. When
        /// the creation request is completed, the Auto Scaling group is ready to be used in other
        /// calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the CreateAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.AlreadyExistsException">
        /// The named Auto Scaling group or launch configuration already exists.
        /// </exception>
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException">
        /// The quota for capacity groups or launch configurations for this customer has already
        /// been reached.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateAutoScalingGroupResponse> CreateAutoScalingGroupAsync(CreateAutoScalingGroupRequest createAutoScalingGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Creates a new launch configuration. The launch configuration name must be unique
        /// within the scope of the client's AWS account. The maximum limit of launch configurations,
        /// which by default is 100, must not yet have been met; otherwise, the call will fail.
        /// When created, the new launch configuration is available for immediate use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateLaunchConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.AlreadyExistsException">
        /// The named Auto Scaling group or launch configuration already exists.
        /// </exception>
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException">
        /// The quota for capacity groups or launch configurations for this customer has already
        /// been reached.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateLaunchConfigurationResponse> CreateLaunchConfigurationAsync(CreateLaunchConfigurationRequest createLaunchConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Creates new tags or updates existing tags for an Auto Scaling group.
        /// 
        /// 
        /// <para>
        /// For information on creating tags for your Auto Scaling group, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/ASTagging.html">Tag
        /// Your Auto Scaling Groups and Amazon EC2 Instances</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOrUpdateTags service method.</param>
        /// 
        /// <returns>The response from the CreateOrUpdateTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.AlreadyExistsException">
        /// The named Auto Scaling group or launch configuration already exists.
        /// </exception>
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException">
        /// The quota for capacity groups or launch configurations for this customer has already
        /// been reached.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateOrUpdateTagsResponse> CreateOrUpdateTagsAsync(CreateOrUpdateTagsRequest createOrUpdateTagsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes the specified Auto Scaling group if the group has no instances and no scaling
        /// activities in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.ResourceInUseException">
        /// This is returned when you cannot delete a launch configuration or Auto Scaling group
        /// because it is being used.
        /// </exception>
        /// <exception cref="T:Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// You cannot delete an Auto Scaling group while there are scaling activities in progress
        /// for that group.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteAutoScalingGroupResponse> DeleteAutoScalingGroupAsync(DeleteAutoScalingGroupRequest deleteAutoScalingGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes the specified <a>LaunchConfiguration</a>.
        /// 
        /// 
        /// <para>
        /// The specified launch configuration must not be attached to an Auto Scaling group.
        /// When this call completes, the launch configuration is no longer available for use.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLaunchConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.ResourceInUseException">
        /// This is returned when you cannot delete a launch configuration or Auto Scaling group
        /// because it is being used.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteLaunchConfigurationResponse> DeleteLaunchConfigurationAsync(DeleteLaunchConfigurationRequest deleteLaunchConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes the specified lifecycle hook. If there are any outstanding lifecycle actions,
        /// they are completed first (ABANDON for launching instances, CONTINUE for terminating
        /// instances).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleHook service method.</param>
        /// 
        /// <returns>The response from the DeleteLifecycleHook service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteLifecycleHookResponse> DeleteLifecycleHookAsync(DeleteLifecycleHookRequest deleteLifecycleHookRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes notifications created by <a>PutNotificationConfiguration</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteNotificationConfiguration service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfigurationAsync(DeleteNotificationConfigurationRequest deleteNotificationConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes a policy created by <a>PutScalingPolicy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest deletePolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Deletes a scheduled action previously created using the <a>PutScheduledUpdateGroupAction</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction service method.</param>
        /// 
        /// <returns>The response from the DeleteScheduledAction service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteScheduledActionResponse> DeleteScheduledActionAsync(DeleteScheduledActionRequest deleteScheduledActionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Removes the specified tags or a set of tags from a set of resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest deleteTagsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns the limits for the Auto Scaling resources currently allowed for your AWS
        /// account.
        /// 
        /// 
        /// <para>
        /// Your AWS account comes with default limits on resources for Auto Scaling. There is
        /// a default limit of <code>20</code> Auto Scaling groups and <code>100</code> launch
        /// configurations per region.
        /// </para>
        /// 
        /// <para>
        /// If you reach the limits for the number of Auto Scaling groups or the launch configurations,
        /// you can go to the <a href="https://aws.amazon.com/support/">Support Center</a> and
        /// place a request to raise the limits.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(DescribeAccountLimitsRequest describeAccountLimitsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns policy adjustment types for use in the <a>PutScalingPolicy</a> action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAdjustmentTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeAdjustmentTypesResponse> DescribeAdjustmentTypesAsync(DescribeAdjustmentTypesRequest describeAdjustmentTypesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns a full description of each Auto Scaling group in the given list. This includes
        /// all Amazon EC2 instances that are members of the group. If a list of names is not
        /// provided, the service returns the full details of all Auto Scaling groups.
        /// 
        /// 
        /// <para>
        /// This action supports pagination by returning a token if there are more pages to retrieve.
        /// To get the next page, call this action again with the returned token as the <code>NextToken</code>
        /// parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeAutoScalingGroupsResponse> DescribeAutoScalingGroupsAsync(DescribeAutoScalingGroupsRequest describeAutoScalingGroupsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns a description of each Auto Scaling instance in the <code>InstanceIds</code>
        /// list. If a list is not provided, the service returns the full details of all instances
        /// up to a maximum of 50. By default, the service returns a list of 20 items.
        /// 
        /// 
        /// <para>
        /// This action supports pagination by returning a token if there are more pages to retrieve.
        /// To get the next page, call this action again with the returned token as the <code>NextToken</code>
        /// parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeAutoScalingInstancesResponse> DescribeAutoScalingInstancesAsync(DescribeAutoScalingInstancesRequest describeAutoScalingInstancesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns a list of all notification types that are supported by Auto Scaling.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingNotificationTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeAutoScalingNotificationTypesResponse> DescribeAutoScalingNotificationTypesAsync(DescribeAutoScalingNotificationTypesRequest describeAutoScalingNotificationTypesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns a full description of the launch configurations, or the specified launch
        /// configurations, if they exist.
        /// 
        /// 
        /// <para>
        /// If no name is specified, then the full details of all launch configurations are returned.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeLaunchConfigurationsResponse> DescribeLaunchConfigurationsAsync(DescribeLaunchConfigurationsRequest describeLaunchConfigurationsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Describes the lifecycle hooks that currently belong to the specified Auto Scaling
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHooks service method.</param>
        /// 
        /// <returns>The response from the DescribeLifecycleHooks service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeLifecycleHooksResponse> DescribeLifecycleHooksAsync(DescribeLifecycleHooksRequest describeLifecycleHooksRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Describes the available types of lifecycle hooks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHookTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeLifecycleHookTypes service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeLifecycleHookTypesResponse> DescribeLifecycleHookTypesAsync(DescribeLifecycleHookTypesRequest describeLifecycleHookTypesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns a list of metrics and a corresponding list of granularities for each metric.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricCollectionTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeMetricCollectionTypesResponse> DescribeMetricCollectionTypesAsync(DescribeMetricCollectionTypesRequest describeMetricCollectionTypesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns a list of notification actions associated with Auto Scaling groups for specified
        /// events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurationsAsync(DescribeNotificationConfigurationsRequest describeNotificationConfigurationsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns descriptions of what each policy does. This action supports pagination. If
        /// the response includes a token, there are more records available. To get the additional
        /// records, repeat the request with the response token as the <code>NextToken</code>
        /// parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePolicies service method.</param>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribePoliciesResponse> DescribePoliciesAsync(DescribePoliciesRequest describePoliciesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns the scaling activities for the specified Auto Scaling group.
        /// 
        /// 
        /// <para>
        /// If the specified <code>ActivityIds</code> list is empty, all the activities from
        /// the past six weeks are returned. Activities are sorted by the start time. Activities
        /// still in progress appear first on the list.
        /// </para>
        /// 
        /// <para>
        /// This action supports pagination. If the response includes a token, there are more
        /// records available. To get the additional records, repeat the request with the response
        /// token as the <code>NextToken</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities service method.</param>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(DescribeScalingActivitiesRequest describeScalingActivitiesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns scaling process types for use in the <a>ResumeProcesses</a> and <a>SuspendProcesses</a>
        /// actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingProcessTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeScalingProcessTypesResponse> DescribeScalingProcessTypesAsync(DescribeScalingProcessTypesRequest describeScalingProcessTypesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Lists all the actions scheduled for your Auto Scaling group that haven't been executed.
        /// To see a list of actions already executed, see the activity record returned in <a>DescribeScalingActivities</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions service method.</param>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeScheduledActionsResponse> DescribeScheduledActionsAsync(DescribeScheduledActionsRequest describeScheduledActionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Lists the Auto Scaling group tags.
        /// 
        /// 
        /// <para>
        /// You can use filters to limit results when describing tags. For example, you can query
        /// for tags of a particular Auto Scaling group. You can specify multiple values for a
        /// filter. A tag must match at least one of the specified values for it to be included
        /// in the results.
        /// </para>
        /// 
        /// <para>
        /// You can also specify multiple filters. The result includes information for a particular
        /// tag only if it matches all your filters. If there's no match, no special message is
        /// returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest describeTagsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns a list of all termination policies supported by Auto Scaling.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTerminationPolicyTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeTerminationPolicyTypesResponse> DescribeTerminationPolicyTypesAsync(DescribeTerminationPolicyTypesRequest describeTerminationPolicyTypesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Using <code>DetachInstances</code>, you can remove an instance from an Auto Scaling
        /// group. After the instances are detached, you can manage them independently from the
        /// rest of the Auto Scaling group.
        /// 
        /// 
        /// <para>
        /// To learn more about detaching instances, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/detach-instance-asg.html">Detach
        /// Amazon EC2 Instances From Your Auto Scaling Group</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachInstances service method.</param>
        /// 
        /// <returns>The response from the DetachInstances service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DetachInstancesResponse> DetachInstancesAsync(DetachInstancesRequest detachInstancesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Disables monitoring of group metrics for the Auto Scaling group specified in <code>AutoScalingGroupName</code>.
        /// You can specify the list of affected metrics with the <code>Metrics</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableMetricsCollection service method.</param>
        /// 
        /// <returns>The response from the DisableMetricsCollection service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DisableMetricsCollectionResponse> DisableMetricsCollectionAsync(DisableMetricsCollectionRequest disableMetricsCollectionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Enables monitoring of group metrics for the Auto Scaling group specified in <code>AutoScalingGroupName</code>.
        /// You can specify the list of enabled metrics with the <code>Metrics</code> parameter.
        /// 
        /// 
        /// 
        /// <para>
        /// Auto Scaling metrics collection can be turned on only if the <code>InstanceMonitoring</code>
        /// flag, in the Auto Scaling group's launch configuration, is set to <code>True</code>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMetricsCollection service method.</param>
        /// 
        /// <returns>The response from the EnableMetricsCollection service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<EnableMetricsCollectionResponse> EnableMetricsCollectionAsync(EnableMetricsCollectionRequest enableMetricsCollectionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Move instances in an Auto Scaling group into a Standby mode.
        /// 
        /// 
        /// <para>
        /// To learn more about how to put instances into a Standby mode, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingInServiceState.html">Auto
        /// Scaling InService State</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnterStandby service method.</param>
        /// 
        /// <returns>The response from the EnterStandby service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<EnterStandbyResponse> EnterStandbyAsync(EnterStandbyRequest enterStandbyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Executes the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecutePolicy service method.</param>
        /// 
        /// <returns>The response from the ExecutePolicy service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// You cannot delete an Auto Scaling group while there are scaling activities in progress
        /// for that group.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ExecutePolicyResponse> ExecutePolicyAsync(ExecutePolicyRequest executePolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Move an instance out of Standby mode.
        /// 
        /// 
        /// <para>
        /// To learn more about how to put instances that are in a Standby mode back into service,
        /// see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingInServiceState.html">Auto
        /// Scaling InService State</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExitStandby service method.</param>
        /// 
        /// <returns>The response from the ExitStandby service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ExitStandbyResponse> ExitStandbyAsync(ExitStandbyRequest exitStandbyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Creates or updates a lifecycle hook for an Auto Scaling Group.
        /// 
        /// 
        /// <para>
        /// A lifecycle hook tells Auto Scaling that you want to perform an action on an instance
        /// that is not actively in service; for example, either when the instance launches or
        /// before the instance terminates.
        /// </para>
        /// 
        /// <para>
        /// This operation is a part of the basic sequence for adding a lifecycle hook to an
        /// Auto Scaling group:
        /// </para>
        /// <ol> <li> Create a notification target. A target can be either an Amazon SQS queue
        /// or an Amazon SNS topic. </li> <li> Create an IAM role. This role allows Auto Scaling
        /// to publish lifecycle notifications to the designated SQS queue or SNS topic. </li>
        /// <li> <b>Create the lifecycle hook. You can create a hook that acts when instances
        /// launch or when instances terminate.</b> </li> <li> If necessary, record the lifecycle
        /// action heartbeat to keep the instance in a pending state. </li> <li> Complete the
        /// lifecycle action. </li> </ol>
        /// <para>
        /// To learn more, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingPendingState.html">Auto
        /// Scaling Pending State</a> and <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingTerminatingState.html">Auto
        /// Scaling Terminating State</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleHook service method.</param>
        /// 
        /// <returns>The response from the PutLifecycleHook service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException">
        /// The quota for capacity groups or launch configurations for this customer has already
        /// been reached.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutLifecycleHookResponse> PutLifecycleHookAsync(PutLifecycleHookRequest putLifecycleHookRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Configures an Auto Scaling group to send notifications when specified events take
        /// place. Subscribers to this topic can have messages for events delivered to an endpoint
        /// such as a web server or email address.
        /// 
        /// 
        /// <para>
        /// For more information see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/ASGettingNotifications.html">Get
        /// Email Notifications When Your Auto Scaling Group Changes</a>
        /// </para>
        /// 
        /// <para>
        /// A new <code>PutNotificationConfiguration</code> overwrites an existing configuration.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutNotificationConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException">
        /// The quota for capacity groups or launch configurations for this customer has already
        /// been reached.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutNotificationConfigurationResponse> PutNotificationConfigurationAsync(PutNotificationConfigurationRequest putNotificationConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Creates or updates a policy for an Auto Scaling group. To update an existing policy,
        /// use the existing policy name and set the parameter(s) you want to change. Any existing
        /// parameter not changed in an update to an existing policy is not changed in this update
        /// request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the PutScalingPolicy service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException">
        /// The quota for capacity groups or launch configurations for this customer has already
        /// been reached.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest putScalingPolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Creates or updates a scheduled scaling action for an Auto Scaling group. When updating
        /// a scheduled scaling action, if you leave a parameter unspecified, the corresponding
        /// value remains unchanged in the affected Auto Scaling group.
        /// 
        /// 
        /// <para>
        /// For information on creating or updating a scheduled action for your Auto Scaling group,
        /// see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/schedule_time.html">Scale
        /// Based on a Schedule</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction service method.</param>
        /// 
        /// <returns>The response from the PutScheduledUpdateGroupAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.AlreadyExistsException">
        /// The named Auto Scaling group or launch configuration already exists.
        /// </exception>
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException">
        /// The quota for capacity groups or launch configurations for this customer has already
        /// been reached.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutScheduledUpdateGroupActionResponse> PutScheduledUpdateGroupActionAsync(PutScheduledUpdateGroupActionRequest putScheduledUpdateGroupActionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Records a heartbeat for the lifecycle action associated with a specific token. This
        /// extends the timeout by the length of time defined by the <code>HeartbeatTimeout</code>
        /// parameter of the <a>PutLifecycleHook</a> operation.
        /// 
        /// 
        /// <para>
        /// This operation is a part of the basic sequence for adding a lifecycle hook to an
        /// Auto Scaling group:
        /// </para>
        /// <ol> <li> Create a notification target. A target can be either an Amazon SQS queue
        /// or an Amazon SNS topic. </li> <li> Create an IAM role. This role allows Auto Scaling
        /// to publish lifecycle notifications to the designated SQS queue or SNS topic. </li>
        /// <li> Create the lifecycle hook. You can create a hook that acts when instances launch
        /// or when instances terminate. </li> <li> <b>If necessary, record the lifecycle action
        /// heartbeat to keep the instance in a pending state.</b> </li> <li> Complete the lifecycle
        /// action. </li> </ol>
        /// <para>
        /// To learn more, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingPendingState.html">Auto
        /// Scaling Pending State</a> and <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingTerminatingState.html">Auto
        /// Scaling Terminating State</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecordLifecycleActionHeartbeat service method.</param>
        /// 
        /// <returns>The response from the RecordLifecycleActionHeartbeat service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RecordLifecycleActionHeartbeatResponse> RecordLifecycleActionHeartbeatAsync(RecordLifecycleActionHeartbeatRequest recordLifecycleActionHeartbeatRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Resumes all suspended Auto Scaling processes for an Auto Scaling group. For information
        /// on suspending and resuming Auto Scaling process, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_SuspendResume.html">Suspend
        /// and Resume Auto Scaling Process</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeProcesses service method.</param>
        /// 
        /// <returns>The response from the ResumeProcesses service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ResumeProcessesResponse> ResumeProcessesAsync(ResumeProcessesRequest resumeProcessesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Sets the desired size of the specified <a>AutoScalingGroup</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDesiredCapacity service method.</param>
        /// 
        /// <returns>The response from the SetDesiredCapacity service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// You cannot delete an Auto Scaling group while there are scaling activities in progress
        /// for that group.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SetDesiredCapacityResponse> SetDesiredCapacityAsync(SetDesiredCapacityRequest setDesiredCapacityRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Sets the health status of a specified instance that belongs to any of your Auto Scaling
        /// groups.
        /// 
        /// 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/as-configure-healthcheck.html">Configure
        /// Health Checks for Your Auto Scaling group</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceHealth service method.</param>
        /// 
        /// <returns>The response from the SetInstanceHealth service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SetInstanceHealthResponse> SetInstanceHealthAsync(SetInstanceHealthRequest setInstanceHealthRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Suspends Auto Scaling processes for an Auto Scaling group. To suspend specific process
        /// types, specify them by name with the <code>ScalingProcesses.member.N</code> parameter.
        /// To suspend all process types, omit the <code>ScalingProcesses.member.N</code> parameter.
        /// 
        /// 
        /// <important>
        /// <para>
        /// Suspending either of the two primary process types, <code>Launch</code> or <code>Terminate</code>,
        /// can prevent other process types from functioning properly.
        /// </para>
        /// </important>
        /// <para>
        /// To resume processes that have been suspended, use <a>ResumeProcesses</a> For more
        /// information on suspending and resuming Auto Scaling process, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_SuspendResume.html">Suspend
        /// and Resume Auto Scaling Process</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SuspendProcesses service method.</param>
        /// 
        /// <returns>The response from the SuspendProcesses service method, as returned by AutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SuspendProcessesResponse> SuspendProcessesAsync(SuspendProcessesRequest suspendProcessesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Terminates the specified instance. Optionally, the desired group size can be adjusted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstanceInAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the TerminateInstanceInAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// You cannot delete an Auto Scaling group while there are scaling activities in progress
        /// for that group.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<TerminateInstanceInAutoScalingGroupResponse> TerminateInstanceInAutoScalingGroupAsync(TerminateInstanceInAutoScalingGroupRequest terminateInstanceInAutoScalingGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Updates the configuration for the specified <a>AutoScalingGroup</a>.
        /// 
        /// 
        /// <para>
        /// The new settings are registered upon the completion of this call. Any launch configuration
        /// settings take effect on any triggers after this call returns. Scaling activities that
        /// are currently in progress aren't affected.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// You cannot delete an Auto Scaling group while there are scaling activities in progress
        /// for that group.
        /// </exception>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateAutoScalingGroupResponse> UpdateAutoScalingGroupAsync(UpdateAutoScalingGroupRequest updateAutoScalingGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}
