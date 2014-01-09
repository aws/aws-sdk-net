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
    /// Interface for accessing AmazonAutoScaling.
    /// 
    /// Auto Scaling <para> Auto Scaling is a web service designed to automatically launch or terminate Amazon Elastic Compute Cloud (Amazon EC2)
    /// instances based on user-defined policies, schedules, and health checks. This service is used in conjunction with Amazon CloudWatch and
    /// Elastic Load Balancing services. </para> <para>Auto Scaling provides APIs that you can call by submitting a Query Request. Query requests
    /// are HTTP or HTTPS requests that use the HTTP verbs GET or POST and a Query parameter named <i>Action</i> or <i>Operation</i> that specifies
    /// the API you are calling. Action is used throughout this documentation, although Operation is also supported for backward compatibility with
    /// other Amazon Web Services (AWS) Query APIs. </para> <para>Calling the API using a Query request is the most direct way to access the web
    /// service, but requires that your application handle low-level details such as generating the hash to sign the request and error handling. The
    /// benefit of calling the service using a Query request is that you are assured of having access to the complete functionality of the API. For
    /// information about signing a a query request, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/api_requests.html">Use Query Requests to Call Auto Scaling APIs</a> </para> <para> This guide provides detailed information about Auto Scaling actions, data
    /// types, parameters, and errors. For detailed information about Auto Scaling features and their associated API actions, go to the <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/">Auto Scaling Developer Guide</a> .
    /// </para> <para>This reference is based on the current WSDL, which is available at:</para> <para> <a href="http://autoscaling.amazonaws.com/doc/2011-01-01/AutoScaling.wsdl">http://autoscaling.amazonaws.com/doc/2011-01-01/AutoScaling.wsdl</a> </para> <para> <b>Endpoints</b> </para> <para>The examples in this
    /// guide assume that your instances are launched in the US East (Northern Virginia) region and use us-east-1 as the endpoint.</para> <para>You
    /// can set up your Auto Scaling infrastructure in other AWS regions. For information about this product's regions and endpoints, see <a href="http://docs.aws.amazon.com/general/latest/gr/index.html?rande.html">Regions and Endpoints</a> in the Amazon Web Services General
    /// Reference. </para>
    /// </summary>
	public partial interface IAmazonAutoScaling : IDisposable
    {
 
        /// <summary>
        /// <para> Attaches one or more Amazon EC2 instances to an existing Auto Scaling group. </para>
        /// </summary>
        /// 
        /// <param name="attachInstancesRequest">Container for the necessary parameters to execute the AttachInstances service method on
        /// AmazonAutoScaling.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<AttachInstancesResponse> AttachInstancesAsync(AttachInstancesRequest attachInstancesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates a new Auto Scaling group with the specified name and other attributes. When the creation request is completed, the Auto
        /// Scaling group is ready to be used in other calls. </para> <para><b>NOTE:</b> The Auto Scaling group name must be unique within the scope of
        /// your AWS account. </para>
        /// </summary>
        /// 
        /// <param name="createAutoScalingGroupRequest">Container for the necessary parameters to execute the CreateAutoScalingGroup service method on
        /// AmazonAutoScaling.</param>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.AutoScaling.Model.AlreadyExistsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateAutoScalingGroupResponse> CreateAutoScalingGroupAsync(CreateAutoScalingGroupRequest createAutoScalingGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates a new launch configuration. The launch configuration name must be unique within the scope of the client's AWS account. The
        /// maximum limit of launch configurations, which by default is 100, must not yet have been met; otherwise, the call will fail. When created,
        /// the new launch configuration is available for immediate use. </para> <para>You can create a launch configuration with Amazon EC2 security
        /// groups or with Amazon VPC security groups. However, you can't use Amazon EC2 security groups together with Amazon VPC security groups, or
        /// vice versa.</para> <para><b>NOTE:</b> At this time, Auto Scaling launch configurations don't support compressed (e.g. zipped) user data
        /// files. </para>
        /// </summary>
        /// 
        /// <param name="createLaunchConfigurationRequest">Container for the necessary parameters to execute the CreateLaunchConfiguration service
        /// method on AmazonAutoScaling.</param>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.AutoScaling.Model.AlreadyExistsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateLaunchConfigurationResponse> CreateLaunchConfigurationAsync(CreateLaunchConfigurationRequest createLaunchConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates new tags or updates existing tags for an Auto Scaling group. </para> <para><b>NOTE:</b> A tag's definition is composed of a
        /// resource ID, resource type, key and value, and the propagate flag. Value and the propagate flag are optional parameters. See the Request
        /// Parameters for more information. </para> <para>For information on creating tags for your Auto Scaling group, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/ASTagging.html">Tag Your Auto Scaling Groups and Amazon EC2
        /// Instances</a> .</para>
        /// </summary>
        /// 
        /// <param name="createOrUpdateTagsRequest">Container for the necessary parameters to execute the CreateOrUpdateTags service method on
        /// AmazonAutoScaling.</param>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.AutoScaling.Model.AlreadyExistsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateOrUpdateTagsResponse> CreateOrUpdateTagsAsync(CreateOrUpdateTagsRequest createOrUpdateTagsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Deletes the specified Auto Scaling group if the group has no instances and no scaling activities in progress. </para>
        /// <para><b>NOTE:</b> To remove all instances before calling DeleteAutoScalingGroup, you can call UpdateAutoScalingGroup to set the minimum and
        /// maximum size of the AutoScalingGroup to zero. </para>
        /// </summary>
        /// 
        /// <param name="deleteAutoScalingGroupRequest">Container for the necessary parameters to execute the DeleteAutoScalingGroup service method on
        /// AmazonAutoScaling.</param>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.ResourceInUseException" />
        /// <exception cref="T:Amazon.AutoScaling.Model.ScalingActivityInProgressException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteAutoScalingGroupResponse> DeleteAutoScalingGroupAsync(DeleteAutoScalingGroupRequest deleteAutoScalingGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Deletes the specified LaunchConfiguration. </para> <para> The specified launch configuration must not be attached to an Auto Scaling
        /// group. When this call completes, the launch configuration is no longer available for use. </para>
        /// </summary>
        /// 
        /// <param name="deleteLaunchConfigurationRequest">Container for the necessary parameters to execute the DeleteLaunchConfiguration service
        /// method on AmazonAutoScaling.</param>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.ResourceInUseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteLaunchConfigurationResponse> DeleteLaunchConfigurationAsync(DeleteLaunchConfigurationRequest deleteLaunchConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Deletes notifications created by PutNotificationConfiguration.</para>
        /// </summary>
        /// 
        /// <param name="deleteNotificationConfigurationRequest">Container for the necessary parameters to execute the DeleteNotificationConfiguration
        /// service method on AmazonAutoScaling.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfigurationAsync(DeleteNotificationConfigurationRequest deleteNotificationConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Deletes a policy created by PutScalingPolicy.</para>
        /// </summary>
        /// 
        /// <param name="deletePolicyRequest">Container for the necessary parameters to execute the DeletePolicy service method on
        /// AmazonAutoScaling.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest deletePolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Deletes a scheduled action previously created using the PutScheduledUpdateGroupAction.</para>
        /// </summary>
        /// 
        /// <param name="deleteScheduledActionRequest">Container for the necessary parameters to execute the DeleteScheduledAction service method on
        /// AmazonAutoScaling.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteScheduledActionResponse> DeleteScheduledActionAsync(DeleteScheduledActionRequest deleteScheduledActionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Removes the specified tags or a set of tags from a set of resources.</para>
        /// </summary>
        /// 
        /// <param name="deleteTagsRequest">Container for the necessary parameters to execute the DeleteTags service method on
        /// AmazonAutoScaling.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest deleteTagsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns the limits for the Auto Scaling resources set for your AWS account. </para>
        /// </summary>
        /// 
        /// <param name="describeAccountLimitsRequest">Container for the necessary parameters to execute the DescribeAccountLimits service method on
        /// AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by AmazonAutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(DescribeAccountLimitsRequest describeAccountLimitsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns policy adjustment types for use in the PutScalingPolicy action. </para>
        /// </summary>
        /// 
        /// <param name="describeAdjustmentTypesRequest">Container for the necessary parameters to execute the DescribeAdjustmentTypes service method on
        /// AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AmazonAutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeAdjustmentTypesResponse> DescribeAdjustmentTypesAsync(DescribeAdjustmentTypesRequest describeAdjustmentTypesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a full description of each Auto Scaling group in the given list. This includes all Amazon EC2 instances that are members of
        /// the group. If a list of names is not provided, the service returns the full details of all Auto Scaling groups. </para> <para> This action
        /// supports pagination by returning a token if there are more pages to retrieve. To get the next page, call this action again with the returned
        /// token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <param name="describeAutoScalingGroupsRequest">Container for the necessary parameters to execute the DescribeAutoScalingGroups service
        /// method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeAutoScalingGroupsResponse> DescribeAutoScalingGroupsAsync(DescribeAutoScalingGroupsRequest describeAutoScalingGroupsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a description of each Auto Scaling instance in the <c>InstanceIds</c> list. If a list is not provided, the service returns
        /// the full details of all instances up to a maximum of 50. By default, the service returns a list of 20 items. </para> <para> This action
        /// supports pagination by returning a token if there are more pages to retrieve. To get the next page, call this action again with the returned
        /// token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <param name="describeAutoScalingInstancesRequest">Container for the necessary parameters to execute the DescribeAutoScalingInstances service
        /// method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeAutoScalingInstancesResponse> DescribeAutoScalingInstancesAsync(DescribeAutoScalingInstancesRequest describeAutoScalingInstancesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of all notification types that are supported by Auto Scaling. </para>
        /// </summary>
        /// 
        /// <param name="describeAutoScalingNotificationTypesRequest">Container for the necessary parameters to execute the
        /// DescribeAutoScalingNotificationTypes service method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AmazonAutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeAutoScalingNotificationTypesResponse> DescribeAutoScalingNotificationTypesAsync(DescribeAutoScalingNotificationTypesRequest describeAutoScalingNotificationTypesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a full description of the launch configurations, or the specified launch configurations, if they exist. </para> <para> If no
        /// name is specified, then the full details of all launch configurations are returned. </para>
        /// </summary>
        /// 
        /// <param name="describeLaunchConfigurationsRequest">Container for the necessary parameters to execute the DescribeLaunchConfigurations service
        /// method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeLaunchConfigurationsResponse> DescribeLaunchConfigurationsAsync(DescribeLaunchConfigurationsRequest describeLaunchConfigurationsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of metrics and a corresponding list of granularities for each metric. </para>
        /// </summary>
        /// 
        /// <param name="describeMetricCollectionTypesRequest">Container for the necessary parameters to execute the DescribeMetricCollectionTypes
        /// service method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AmazonAutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeMetricCollectionTypesResponse> DescribeMetricCollectionTypesAsync(DescribeMetricCollectionTypesRequest describeMetricCollectionTypesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of notification actions associated with Auto Scaling groups for specified events. </para>
        /// </summary>
        /// 
        /// <param name="describeNotificationConfigurationsRequest">Container for the necessary parameters to execute the
        /// DescribeNotificationConfigurations service method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurationsAsync(DescribeNotificationConfigurationsRequest describeNotificationConfigurationsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns descriptions of what each policy does. This action supports pagination. If the response includes a token, there are more
        /// records available. To get the additional records, repeat the request with the response token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <param name="describePoliciesRequest">Container for the necessary parameters to execute the DescribePolicies service method on
        /// AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribePoliciesResponse> DescribePoliciesAsync(DescribePoliciesRequest describePoliciesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns the scaling activities for the specified Auto Scaling group. </para> <para> If the specified <c>ActivityIds</c> list is
        /// empty, all the activities from the past six weeks are returned. Activities are sorted by completion time. Activities still in progress
        /// appear first on the list. </para> <para> This action supports pagination. If the response includes a token, there are more records
        /// available. To get the additional records, repeat the request with the response token as the <c>NextToken</c> parameter. </para>
        /// </summary>
        /// 
        /// <param name="describeScalingActivitiesRequest">Container for the necessary parameters to execute the DescribeScalingActivities service
        /// method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(DescribeScalingActivitiesRequest describeScalingActivitiesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns scaling process types for use in the ResumeProcesses and SuspendProcesses actions.</para>
        /// </summary>
        /// 
        /// <param name="describeScalingProcessTypesRequest">Container for the necessary parameters to execute the DescribeScalingProcessTypes service
        /// method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AmazonAutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeScalingProcessTypesResponse> DescribeScalingProcessTypesAsync(DescribeScalingProcessTypesRequest describeScalingProcessTypesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Lists all the actions scheduled for your Auto Scaling group that haven't been executed. To see a list of actions already executed,
        /// see the activity record returned in DescribeScalingActivities. </para>
        /// </summary>
        /// 
        /// <param name="describeScheduledActionsRequest">Container for the necessary parameters to execute the DescribeScheduledActions service method
        /// on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeScheduledActionsResponse> DescribeScheduledActionsAsync(DescribeScheduledActionsRequest describeScheduledActionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Lists the Auto Scaling group tags. </para> <para> You can use filters to limit results when describing tags. For example, you can
        /// query for tags of a particular Auto Scaling group. You can specify multiple values for a filter. A tag must match at least one of the
        /// specified values for it to be included in the results. </para> <para> You can also specify multiple filters. The result includes information
        /// for a particular tag only if it matches all your filters. If there's no match, no special message is returned. </para>
        /// </summary>
        /// 
        /// <param name="describeTagsRequest">Container for the necessary parameters to execute the DescribeTags service method on
        /// AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest describeTagsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns a list of all termination policies supported by Auto Scaling. </para>
        /// </summary>
        /// 
        /// <param name="describeTerminationPolicyTypesRequest">Container for the necessary parameters to execute the DescribeTerminationPolicyTypes
        /// service method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AmazonAutoScaling.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeTerminationPolicyTypesResponse> DescribeTerminationPolicyTypesAsync(DescribeTerminationPolicyTypesRequest describeTerminationPolicyTypesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Disables monitoring of group metrics for the Auto Scaling group specified in <c>AutoScalingGroupName</c> .
        /// You can specify the list of affected metrics with the <c>Metrics</c> parameter. </para>
        /// </summary>
        /// 
        /// <param name="disableMetricsCollectionRequest">Container for the necessary parameters to execute the DisableMetricsCollection service method
        /// on AmazonAutoScaling.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DisableMetricsCollectionResponse> DisableMetricsCollectionAsync(DisableMetricsCollectionRequest disableMetricsCollectionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Enables monitoring of group metrics for the Auto Scaling group specified in <c>AutoScalingGroupName</c> .
        /// You can specify the list of enabled metrics with the <c>Metrics</c> parameter. </para> <para> Auto Scaling metrics collection
        /// can be turned on only if the <c>InstanceMonitoring</c> flag, in the Auto Scaling group's launch configuration, is set to <c>True</c> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="enableMetricsCollectionRequest">Container for the necessary parameters to execute the EnableMetricsCollection service method on
        /// AmazonAutoScaling.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<EnableMetricsCollectionResponse> EnableMetricsCollectionAsync(EnableMetricsCollectionRequest enableMetricsCollectionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Executes the specified policy. </para>
        /// </summary>
        /// 
        /// <param name="executePolicyRequest">Container for the necessary parameters to execute the ExecutePolicy service method on
        /// AmazonAutoScaling.</param>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.ScalingActivityInProgressException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ExecutePolicyResponse> ExecutePolicyAsync(ExecutePolicyRequest executePolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Configures an Auto Scaling group to send notifications when specified events take place. Subscribers to this topic can have messages
        /// for events delivered to an endpoint such as a web server or email address. </para> <para>For more information see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/ASGettingNotifications.html">Get Email Notifications When Your Auto
        /// Scaling Group Changes</a> </para> <para>A new <c>PutNotificationConfiguration</c> overwrites an existing configuration. </para>
        /// </summary>
        /// 
        /// <param name="putNotificationConfigurationRequest">Container for the necessary parameters to execute the PutNotificationConfiguration service
        /// method on AmazonAutoScaling.</param>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutNotificationConfigurationResponse> PutNotificationConfigurationAsync(PutNotificationConfigurationRequest putNotificationConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates or updates a policy for an Auto Scaling group. To update an existing policy, use the existing policy name and set the
        /// parameter(s) you want to change. Any existing parameter not changed in an update to an existing policy is not changed in this update
        /// request. </para>
        /// </summary>
        /// 
        /// <param name="putScalingPolicyRequest">Container for the necessary parameters to execute the PutScalingPolicy service method on
        /// AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the PutScalingPolicy service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest putScalingPolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates or updates a scheduled scaling action for an Auto Scaling group. When updating a scheduled scaling action, if you leave a
        /// parameter unspecified, the corresponding value remains unchanged in the affected Auto Scaling group. </para> <para>For information on
        /// creating or updating a scheduled action for your Auto Scaling group, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/schedule_time.html">Scale Based on a Schedule</a> .</para>
        /// <para><b>NOTE:</b> Auto Scaling supports the date and time expressed in "YYYY-MM-DDThh:mm:ssZ" format in UTC/GMT only. </para>
        /// </summary>
        /// 
        /// <param name="putScheduledUpdateGroupActionRequest">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction
        /// service method on AmazonAutoScaling.</param>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.AutoScaling.Model.AlreadyExistsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutScheduledUpdateGroupActionResponse> PutScheduledUpdateGroupActionAsync(PutScheduledUpdateGroupActionRequest putScheduledUpdateGroupActionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Resumes all suspended Auto Scaling processes for an Auto Scaling group. For information on suspending and resuming Auto Scaling
        /// process, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_SuspendResume.html">Suspend and Resume Auto Scaling
        /// Process</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="resumeProcessesRequest">Container for the necessary parameters to execute the ResumeProcesses service method on
        /// AmazonAutoScaling.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ResumeProcessesResponse> ResumeProcessesAsync(ResumeProcessesRequest resumeProcessesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Sets the desired size of the specified AutoScalingGroup. </para>
        /// </summary>
        /// 
        /// <param name="setDesiredCapacityRequest">Container for the necessary parameters to execute the SetDesiredCapacity service method on
        /// AmazonAutoScaling.</param>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.ScalingActivityInProgressException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SetDesiredCapacityResponse> SetDesiredCapacityAsync(SetDesiredCapacityRequest setDesiredCapacityRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Sets the health status of a specified instance that belongs to any of your Auto Scaling groups. </para> <para>For more information,
        /// see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/as-configure-healthcheck.html">Configure Health Checks for Your
        /// Auto Scaling group</a> .</para>
        /// </summary>
        /// 
        /// <param name="setInstanceHealthRequest">Container for the necessary parameters to execute the SetInstanceHealth service method on
        /// AmazonAutoScaling.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SetInstanceHealthResponse> SetInstanceHealthAsync(SetInstanceHealthRequest setInstanceHealthRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Suspends Auto Scaling processes for an Auto Scaling group. To suspend specific process types, specify them by name with the
        /// <c>ScalingProcesses.member.N</c> parameter. To suspend all process types, omit the <c>ScalingProcesses.member.N</c> parameter. </para>
        /// <para><b>IMPORTANT:</b> Suspending either of the two primary process types, Launch or Terminate, can prevent other process types from
        /// functioning properly. </para> <para> To resume processes that have been suspended, use ResumeProcesses For more information on suspending
        /// and resuming Auto Scaling process, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_SuspendResume.html">Suspend
        /// and Resume Auto Scaling Process</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="suspendProcessesRequest">Container for the necessary parameters to execute the SuspendProcesses service method on
        /// AmazonAutoScaling.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SuspendProcessesResponse> SuspendProcessesAsync(SuspendProcessesRequest suspendProcessesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Terminates the specified instance. Optionally, the desired group size can be adjusted. </para> <para><b>NOTE:</b> This call simply
        /// registers a termination request. The termination of the instance cannot happen immediately. </para>
        /// </summary>
        /// 
        /// <param name="terminateInstanceInAutoScalingGroupRequest">Container for the necessary parameters to execute the
        /// TerminateInstanceInAutoScalingGroup service method on AmazonAutoScaling.</param>
        /// 
        /// <returns>The response from the TerminateInstanceInAutoScalingGroup service method, as returned by AmazonAutoScaling.</returns>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.ScalingActivityInProgressException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<TerminateInstanceInAutoScalingGroupResponse> TerminateInstanceInAutoScalingGroupAsync(TerminateInstanceInAutoScalingGroupRequest terminateInstanceInAutoScalingGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Updates the configuration for the specified AutoScalingGroup. </para> <para><b>NOTE:</b> To update an Auto Scaling group with a
        /// launch configuration that has the InstanceMonitoring flag set to False, you must first ensure that collection of group metrics is disabled.
        /// Otherwise, calls to UpdateAutoScalingGroup will fail. If you have previously enabled group metrics collection, you can disable collection of
        /// all group metrics by calling DisableMetricsCollection. </para> <para> The new settings are registered upon the completion of this call. Any
        /// launch configuration settings take effect on any triggers after this call returns. Scaling activities that are currently in progress aren't
        /// affected. </para> <para><b>NOTE:</b> If a new value is specified for MinSize without specifying the value for DesiredCapacity, and if the
        /// new MinSize is larger than the current size of the Auto Scaling Group, there will be an implicit call to SetDesiredCapacity to set the group
        /// to the new MinSize. If a new value is specified for MaxSize without specifying the value for DesiredCapacity, and the new MaxSize is smaller
        /// than the current size of the Auto Scaling Group, there will be an implicit call to SetDesiredCapacity to set the group to the new MaxSize.
        /// All other optional parameters are left unchanged if not passed in the request. </para>
        /// </summary>
        /// 
        /// <param name="updateAutoScalingGroupRequest">Container for the necessary parameters to execute the UpdateAutoScalingGroup service method on
        /// AmazonAutoScaling.</param>
        /// 
        /// <exception cref="T:Amazon.AutoScaling.Model.ScalingActivityInProgressException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateAutoScalingGroupResponse> UpdateAutoScalingGroupAsync(UpdateAutoScalingGroupRequest updateAutoScalingGroupRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}
