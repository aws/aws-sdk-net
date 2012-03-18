/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.AutoScaling;
using Amazon.AutoScaling.Model;

namespace Amazon.AutoScaling
{
    /// <summary>
    /// Interface for accessing AmazonAutoScaling.
    ///  
    ///  Auto Scaling <para> This is the <i>Auto Scaling API Reference</i> . This guide provides detailed information about Auto Scaling actions,
    /// data types, parameters, and errors. For detailed information about Auto Scaling features and their associated API calls, go to the Auto
    /// Scaling Developer Guide. </para> <para> Auto Scaling is a web service designed to automatically launch or terminate Amazon Elastic Compute
    /// Cloud (Amazon EC2) instances based on user-defined policies, schedules, and health checks. This service is used in conjunction with Amazon
    /// CloudWatch and Elastic Load Balancing services. </para> <para>This reference is based on the current WSDL, which is available at:</para>
    /// <para> http://autoscaling.amazonaws.com/doc/2011-01-01/AutoScaling.wsdl </para> <para> <b>Endpoints</b> </para> <para>For information about
    /// this product's regions and endpoints, go to Regions and Endpoints in the Amazon Web Services General Reference. </para>
    /// </summary>
    public interface AmazonAutoScaling : IDisposable
    {
        

         /// <summary>
         /// <para> Returns a full description of each Auto Scaling group in the given list. This includes all Amazon EC2 instances that are members of
         /// the group. If a list of names is not provided, the service returns the full details of all Auto Scaling groups. </para> <para> This action
         /// supports pagination by returning a token if there are more pages to retrieve. To get the next page, call this action again with the returned
         /// token as the <c>NextToken</c> parameter. </para>
         /// </summary>
         /// 
         /// <param name="describeAutoScalingGroupsRequest">Container for the necessary parameters to execute the DescribeAutoScalingGroups service
         ///           method on AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest describeAutoScalingGroupsRequest); 

         /// <summary>
         /// <para> Returns a full description of each Auto Scaling group in the given list. This includes all Amazon EC2 instances that are members of
         /// the group. If a list of names is not provided, the service returns the full details of all Auto Scaling groups. </para> <para> This action
         /// supports pagination by returning a token if there are more pages to retrieve. To get the next page, call this action again with the returned
         /// token as the <c>NextToken</c> parameter. </para>
         /// </summary>
         /// 
         /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups();

         /// <summary>
         /// <para> Enables monitoring of group metrics for the Auto Scaling group specified in <c>AutoScalingGroupName</c> .
         /// You can specify the list of enabled metrics with the <c>Metrics</c> parameter. </para> <para> Auto scaling metrics collection
         /// can be turned on only if the <c>InstanceMonitoring</c> flag, in the Auto Scaling group's launch configuration, is set to <c>True</c> .
         /// </para>
         /// </summary>
         /// 
         /// <param name="enableMetricsCollectionRequest">Container for the necessary parameters to execute the EnableMetricsCollection service method on
         ///           AmazonAutoScaling.</param>
         /// 
        EnableMetricsCollectionResponse EnableMetricsCollection(EnableMetricsCollectionRequest enableMetricsCollectionRequest); 

         /// <summary>
         /// <para> Resumes Auto Scaling processes for an Auto Scaling group. For more information, see SuspendProcesses and ProcessType. </para>
         /// </summary>
         /// 
         /// <param name="resumeProcessesRequest">Container for the necessary parameters to execute the ResumeProcesses service method on
         ///           AmazonAutoScaling.</param>
         /// 
        ResumeProcessesResponse ResumeProcesses(ResumeProcessesRequest resumeProcessesRequest); 

         /// <summary>
         /// <para> Deletes the specified LaunchConfiguration. </para> <para> The specified launch configuration must not be attached to an Auto Scaling
         /// group. When this call completes, the launch configuration is no longer available for use. </para>
         /// </summary>
         /// 
         /// <param name="deleteLaunchConfigurationRequest">Container for the necessary parameters to execute the DeleteLaunchConfiguration service
         ///           method on AmazonAutoScaling.</param>
         /// 
         /// <exception cref="ResourceInUseException"/>
        DeleteLaunchConfigurationResponse DeleteLaunchConfiguration(DeleteLaunchConfigurationRequest deleteLaunchConfigurationRequest); 

         /// <summary>
         /// <para> Returns descriptions of what each policy does. This action supports pagination. If the response includes a token, there are more
         /// records available. To get the additional records, repeat the request with the response token as the <c>NextToken</c> parameter. </para>
         /// </summary>
         /// 
         /// <param name="describePoliciesRequest">Container for the necessary parameters to execute the DescribePolicies service method on
         ///           AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribePolicies service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        DescribePoliciesResponse DescribePolicies(DescribePoliciesRequest describePoliciesRequest); 

         /// <summary>
         /// <para> Returns descriptions of what each policy does. This action supports pagination. If the response includes a token, there are more
         /// records available. To get the additional records, repeat the request with the response token as the <c>NextToken</c> parameter. </para>
         /// </summary>
         /// 
         /// <returns>The response from the DescribePolicies service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        DescribePoliciesResponse DescribePolicies();

         /// <summary>
         /// <para>Returns scaling process types for use in the ResumeProcesses and SuspendProcesses actions.</para>
         /// </summary>
         /// 
         /// <param name="describeScalingProcessTypesRequest">Container for the necessary parameters to execute the DescribeScalingProcessTypes service
         ///           method on AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AmazonAutoScaling.</returns>
         /// 
        DescribeScalingProcessTypesResponse DescribeScalingProcessTypes(DescribeScalingProcessTypesRequest describeScalingProcessTypesRequest); 

         /// <summary>
         /// <para>Returns scaling process types for use in the ResumeProcesses and SuspendProcesses actions.</para>
         /// </summary>
         /// 
         /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AmazonAutoScaling.</returns>
         /// 
        DescribeScalingProcessTypesResponse DescribeScalingProcessTypes();

         /// <summary>
         /// <para> Creates a new Auto Scaling group with the specified name and other attributes. When the creation request is completed, the Auto
         /// Scaling group is ready to be used in other calls. </para> <para><b>NOTE:</b> The Auto Scaling group name must be unique within the scope of
         /// your AWS account, and under the quota of Auto Scaling groups allowed for your account. </para>
         /// </summary>
         /// 
         /// <param name="createAutoScalingGroupRequest">Container for the necessary parameters to execute the CreateAutoScalingGroup service method on
         ///           AmazonAutoScaling.</param>
         /// 
         /// <exception cref="LimitExceededException"/>
         /// <exception cref="AlreadyExistsException"/>
        CreateAutoScalingGroupResponse CreateAutoScalingGroup(CreateAutoScalingGroupRequest createAutoScalingGroupRequest); 

         /// <summary>
         /// <para> Returns the scaling activities for the specified Auto Scaling group. </para> <para> If the specified <c>ActivityIds</c> list is
         /// empty, all the activities from the past six weeks are returned. Activities are sorted by completion time. Activities still in progress
         /// appear first on the list. </para> <para> This action supports pagination. If the response includes a token, there are more records
         /// available. To get the additional records, repeat the request with the response token as the <c>NextToken</c> parameter. </para>
         /// </summary>
         /// 
         /// <param name="describeScalingActivitiesRequest">Container for the necessary parameters to execute the DescribeScalingActivities service
         ///           method on AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribeScalingActivities service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest describeScalingActivitiesRequest); 

         /// <summary>
         /// <para> Returns the scaling activities for the specified Auto Scaling group. </para> <para> If the specified <c>ActivityIds</c> list is
         /// empty, all the activities from the past six weeks are returned. Activities are sorted by completion time. Activities still in progress
         /// appear first on the list. </para> <para> This action supports pagination. If the response includes a token, there are more records
         /// available. To get the additional records, repeat the request with the response token as the <c>NextToken</c> parameter. </para>
         /// </summary>
         /// 
         /// <returns>The response from the DescribeScalingActivities service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        DescribeScalingActivitiesResponse DescribeScalingActivities();

         /// <summary>
         /// <para> Returns a list of notification actions associated with Auto Scaling groups for specified events. </para>
         /// </summary>
         /// 
         /// <param name="describeNotificationConfigurationsRequest">Container for the necessary parameters to execute the
         ///           DescribeNotificationConfigurations service method on AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest describeNotificationConfigurationsRequest); 

         /// <summary>
         /// <para> Returns a list of notification actions associated with Auto Scaling groups for specified events. </para>
         /// </summary>
         /// 
         /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations();

         /// <summary>
         /// <para> Lists the Auto Scaling group tags. </para> <para> You can use filters to limit results when describing tags. For example, you can
         /// query for tags of a particular Auto Scaling group. You can specify multiple values for a filter. A tag must match at least one of the
         /// specified values for it to be included in the results. </para> <para> You can also specify multiple filters. The result includes information
         /// for a particular tag only if it matches all your filters. If there's no match, no special message is returned. </para>
         /// </summary>
         /// 
         /// <param name="describeTagsRequest">Container for the necessary parameters to execute the DescribeTags service method on
         ///           AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribeTags service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        DescribeTagsResponse DescribeTags(DescribeTagsRequest describeTagsRequest); 

         /// <summary>
         /// <para> Lists the Auto Scaling group tags. </para> <para> You can use filters to limit results when describing tags. For example, you can
         /// query for tags of a particular Auto Scaling group. You can specify multiple values for a filter. A tag must match at least one of the
         /// specified values for it to be included in the results. </para> <para> You can also specify multiple filters. The result includes information
         /// for a particular tag only if it matches all your filters. If there's no match, no special message is returned. </para>
         /// </summary>
         /// 
         /// <returns>The response from the DescribeTags service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        DescribeTagsResponse DescribeTags();

         /// <summary>
         /// <para>Runs the policy you create for your Auto Scaling group in PutScalingPolicy.</para>
         /// </summary>
         /// 
         /// <param name="executePolicyRequest">Container for the necessary parameters to execute the ExecutePolicy service method on
         ///           AmazonAutoScaling.</param>
         /// 
         /// <exception cref="ScalingActivityInProgressException"/>
        ExecutePolicyResponse ExecutePolicy(ExecutePolicyRequest executePolicyRequest); 

         /// <summary>
         /// <para>Removes the specified tags or a set of tags from a set of resources.</para>
         /// </summary>
         /// 
         /// <param name="deleteTagsRequest">Container for the necessary parameters to execute the DeleteTags service method on
         ///           AmazonAutoScaling.</param>
         /// 
        DeleteTagsResponse DeleteTags(DeleteTagsRequest deleteTagsRequest); 

         /// <summary>
         /// <para> Creates or updates a policy for an Auto Scaling group. To update an existing policy, use the existing policy name and set the
         /// parameter(s) you want to change. Any existing parameter not changed in an update to an existing policy is not changed in this update
         /// request. </para>
         /// </summary>
         /// 
         /// <param name="putScalingPolicyRequest">Container for the necessary parameters to execute the PutScalingPolicy service method on
         ///           AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the PutScalingPolicy service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="LimitExceededException"/>
        PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest putScalingPolicyRequest); 

         /// <summary>
         /// <para> Configures an Auto Scaling group to send notifications when specified events take place. Subscribers to this topic can have messages
         /// for events delivered to an endpoint such as a web server or email address. </para> <para> A new <c>PutNotificationConfiguration</c>
         /// overwrites an existing configuration.</para>
         /// </summary>
         /// 
         /// <param name="putNotificationConfigurationRequest">Container for the necessary parameters to execute the PutNotificationConfiguration service
         ///           method on AmazonAutoScaling.</param>
         /// 
         /// <exception cref="LimitExceededException"/>
        PutNotificationConfigurationResponse PutNotificationConfiguration(PutNotificationConfigurationRequest putNotificationConfigurationRequest); 

         /// <summary>
         /// <para>Deletes a policy created by PutScalingPolicy.</para>
         /// </summary>
         /// 
         /// <param name="deletePolicyRequest">Container for the necessary parameters to execute the DeletePolicy service method on
         ///           AmazonAutoScaling.</param>
         /// 
        DeletePolicyResponse DeletePolicy(DeletePolicyRequest deletePolicyRequest); 

         /// <summary>
         /// <para>Deletes notifications created by PutNotificationConfiguration.</para>
         /// </summary>
         /// 
         /// <param name="deleteNotificationConfigurationRequest">Container for the necessary parameters to execute the DeleteNotificationConfiguration
         ///           service method on AmazonAutoScaling.</param>
         /// 
        DeleteNotificationConfigurationResponse DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest deleteNotificationConfigurationRequest); 

         /// <summary>
         /// <para>Deletes a scheduled action previously created using the PutScheduledUpdateGroupAction.</para>
         /// </summary>
         /// 
         /// <param name="deleteScheduledActionRequest">Container for the necessary parameters to execute the DeleteScheduledAction service method on
         ///           AmazonAutoScaling.</param>
         /// 
        DeleteScheduledActionResponse DeleteScheduledAction(DeleteScheduledActionRequest deleteScheduledActionRequest); 

         /// <summary>
         /// <para> Sets the health status of an instance. </para>
         /// </summary>
         /// 
         /// <param name="setInstanceHealthRequest">Container for the necessary parameters to execute the SetInstanceHealth service method on
         ///           AmazonAutoScaling.</param>
         /// 
        SetInstanceHealthResponse SetInstanceHealth(SetInstanceHealthRequest setInstanceHealthRequest); 

         /// <summary>
         /// <para> Returns a list of all notification types that are supported by Auto Scaling. </para>
         /// </summary>
         /// 
         /// <param name="describeAutoScalingNotificationTypesRequest">Container for the necessary parameters to execute the
         ///           DescribeAutoScalingNotificationTypes service method on AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AmazonAutoScaling.</returns>
         /// 
        DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes(DescribeAutoScalingNotificationTypesRequest describeAutoScalingNotificationTypesRequest); 

         /// <summary>
         /// <para> Returns a list of all notification types that are supported by Auto Scaling. </para>
         /// </summary>
         /// 
         /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AmazonAutoScaling.</returns>
         /// 
        DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes();

         /// <summary>
         /// <para> Creates new tags or updates existing tags for an Auto Scaling group. </para> <para><b>NOTE:</b> A tag's definition is composed of a
         /// resource ID, resource type, key and value, and the propagate flag. Value and the propagate flag are optional parameters. See the Request
         /// Parameters for more information. </para>
         /// </summary>
         /// 
         /// <param name="createOrUpdateTagsRequest">Container for the necessary parameters to execute the CreateOrUpdateTags service method on
         ///           AmazonAutoScaling.</param>
         /// 
         /// <exception cref="LimitExceededException"/>
         /// <exception cref="AlreadyExistsException"/>
        CreateOrUpdateTagsResponse CreateOrUpdateTags(CreateOrUpdateTagsRequest createOrUpdateTagsRequest); 

         /// <summary>
         /// <para> Suspends Auto Scaling processes for an Auto Scaling group. To suspend specific process types, specify them by name with the
         /// <c>ScalingProcesses.member.N</c> parameter. To suspend all process types, omit the <c>ScalingProcesses.member.N</c> parameter. </para>
         /// <para><b>IMPORTANT:</b> Suspending either of the two primary process types, Launch or Terminate, can prevent other process types from
         /// functioning properly. For more information about processes and their dependencies, see ProcessType. </para> <para> To resume processes that
         /// have been suspended, use ResumeProcesses. </para>
         /// </summary>
         /// 
         /// <param name="suspendProcessesRequest">Container for the necessary parameters to execute the SuspendProcesses service method on
         ///           AmazonAutoScaling.</param>
         /// 
        SuspendProcessesResponse SuspendProcesses(SuspendProcessesRequest suspendProcessesRequest); 

         /// <summary>
         /// <para> Returns a description of each Auto Scaling instance in the <c>InstanceIds</c> list. If a list is not provided, the service returns
         /// the full details of all instances up to a maximum of 50. By default, the service returns a list of 20 items. </para> <para> This action
         /// supports pagination by returning a token if there are more pages to retrieve. To get the next page, call this action again with the returned
         /// token as the <c>NextToken</c> parameter. </para>
         /// </summary>
         /// 
         /// <param name="describeAutoScalingInstancesRequest">Container for the necessary parameters to execute the DescribeAutoScalingInstances service
         ///           method on AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest describeAutoScalingInstancesRequest); 

         /// <summary>
         /// <para> Returns a description of each Auto Scaling instance in the <c>InstanceIds</c> list. If a list is not provided, the service returns
         /// the full details of all instances up to a maximum of 50. By default, the service returns a list of 20 items. </para> <para> This action
         /// supports pagination by returning a token if there are more pages to retrieve. To get the next page, call this action again with the returned
         /// token as the <c>NextToken</c> parameter. </para>
         /// </summary>
         /// 
         /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances();

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
         ///           method on AmazonAutoScaling.</param>
         /// 
         /// <exception cref="LimitExceededException"/>
         /// <exception cref="AlreadyExistsException"/>
        CreateLaunchConfigurationResponse CreateLaunchConfiguration(CreateLaunchConfigurationRequest createLaunchConfigurationRequest); 

         /// <summary>
         /// <para> Deletes the specified Auto Scaling group if the group has no instances and no scaling activities in progress. </para>
         /// <para><b>NOTE:</b> To remove all instances before calling DeleteAutoScalingGroup, you can call UpdateAutoScalingGroup to set the minimum and
         /// maximum size of the AutoScalingGroup to zero. </para>
         /// </summary>
         /// 
         /// <param name="deleteAutoScalingGroupRequest">Container for the necessary parameters to execute the DeleteAutoScalingGroup service method on
         ///           AmazonAutoScaling.</param>
         /// 
         /// <exception cref="ResourceInUseException"/>
         /// <exception cref="ScalingActivityInProgressException"/>
        DeleteAutoScalingGroupResponse DeleteAutoScalingGroup(DeleteAutoScalingGroupRequest deleteAutoScalingGroupRequest); 

         /// <summary>
         /// <para> Disables monitoring of group metrics for the Auto Scaling group specified in <c>AutoScalingGroupName</c> .
         /// You can specify the list of affected metrics with the <c>Metrics</c> parameter. </para>
         /// </summary>
         /// 
         /// <param name="disableMetricsCollectionRequest">Container for the necessary parameters to execute the DisableMetricsCollection service method
         ///           on AmazonAutoScaling.</param>
         /// 
        DisableMetricsCollectionResponse DisableMetricsCollection(DisableMetricsCollectionRequest disableMetricsCollectionRequest); 

         /// <summary>
         /// <para> Updates the configuration for the specified AutoScalingGroup. </para> <para><b>NOTE:</b> To update an Auto Scaling group with a
         /// launch configuration that has the InstanceMonitoring flag set to False, you must first ensure that collection of group metrics is disabled.
         /// Otherwise, calls to UpdateAutoScalingGroup will fail. If you have previously enabled group metrics collection, you can disable collection of
         /// all group metrics by calling DisableMetricsCollection. </para> <para> The new settings are registered upon the completion of this call. Any
         /// launch configuration settings take effect on any triggers after this call returns. Triggers that are currently in progress aren't affected.
         /// </para> <para><b>NOTE:</b> If the new values are specified for the MinSize or MaxSize parameters, then there will be an implicit call to
         /// SetDesiredCapacity to set the group to the new MaxSize. All optional parameters are left unchanged if not passed in the request. </para>
         /// </summary>
         /// 
         /// <param name="updateAutoScalingGroupRequest">Container for the necessary parameters to execute the UpdateAutoScalingGroup service method on
         ///           AmazonAutoScaling.</param>
         /// 
         /// <exception cref="ScalingActivityInProgressException"/>
        UpdateAutoScalingGroupResponse UpdateAutoScalingGroup(UpdateAutoScalingGroupRequest updateAutoScalingGroupRequest); 

         /// <summary>
         /// <para> Returns a full description of the launch configurations, or the specified launch configurations, if they exist. </para> <para> If no
         /// name is specified, then the full details of all launch configurations are returned. </para>
         /// </summary>
         /// 
         /// <param name="describeLaunchConfigurationsRequest">Container for the necessary parameters to execute the DescribeLaunchConfigurations service
         ///           method on AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest describeLaunchConfigurationsRequest); 

         /// <summary>
         /// <para> Returns a full description of the launch configurations, or the specified launch configurations, if they exist. </para> <para> If no
         /// name is specified, then the full details of all launch configurations are returned. </para>
         /// </summary>
         /// 
         /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations();

         /// <summary>
         /// <para> Returns policy adjustment types for use in the PutScalingPolicy action. </para>
         /// </summary>
         /// 
         /// <param name="describeAdjustmentTypesRequest">Container for the necessary parameters to execute the DescribeAdjustmentTypes service method on
         ///           AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AmazonAutoScaling.</returns>
         /// 
        DescribeAdjustmentTypesResponse DescribeAdjustmentTypes(DescribeAdjustmentTypesRequest describeAdjustmentTypesRequest); 

         /// <summary>
         /// <para> Returns policy adjustment types for use in the PutScalingPolicy action. </para>
         /// </summary>
         /// 
         /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AmazonAutoScaling.</returns>
         /// 
        DescribeAdjustmentTypesResponse DescribeAdjustmentTypes();

         /// <summary>
         /// <para> Lists all the actions scheduled for your Auto Scaling group that haven't been executed. To see a list of actions already executed,
         /// see the activity record returned in DescribeScalingActivities. </para>
         /// </summary>
         /// 
         /// <param name="describeScheduledActionsRequest">Container for the necessary parameters to execute the DescribeScheduledActions service method
         ///           on AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribeScheduledActions service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        DescribeScheduledActionsResponse DescribeScheduledActions(DescribeScheduledActionsRequest describeScheduledActionsRequest); 

         /// <summary>
         /// <para> Lists all the actions scheduled for your Auto Scaling group that haven't been executed. To see a list of actions already executed,
         /// see the activity record returned in DescribeScalingActivities. </para>
         /// </summary>
         /// 
         /// <returns>The response from the DescribeScheduledActions service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="InvalidNextTokenException"/>
        DescribeScheduledActionsResponse DescribeScheduledActions();

         /// <summary>
         /// <para> Creates a scheduled scaling action for an Auto Scaling group. If you leave a parameter unspecified, the corresponding value remains
         /// unchanged in the affected Auto Scaling group. </para>
         /// </summary>
         /// 
         /// <param name="putScheduledUpdateGroupActionRequest">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction
         ///           service method on AmazonAutoScaling.</param>
         /// 
         /// <exception cref="LimitExceededException"/>
         /// <exception cref="AlreadyExistsException"/>
        PutScheduledUpdateGroupActionResponse PutScheduledUpdateGroupAction(PutScheduledUpdateGroupActionRequest putScheduledUpdateGroupActionRequest); 

         /// <summary>
         /// <para> Returns a list of metrics and a corresponding list of granularities for each metric. </para>
         /// </summary>
         /// 
         /// <param name="describeMetricCollectionTypesRequest">Container for the necessary parameters to execute the DescribeMetricCollectionTypes
         ///           service method on AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AmazonAutoScaling.</returns>
         /// 
        DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes(DescribeMetricCollectionTypesRequest describeMetricCollectionTypesRequest); 

         /// <summary>
         /// <para> Returns a list of metrics and a corresponding list of granularities for each metric. </para>
         /// </summary>
         /// 
         /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AmazonAutoScaling.</returns>
         /// 
        DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes();

         /// <summary>
         /// <para> Adjusts the desired size of the AutoScalingGroup by initiating scaling activities. When reducing the size of the group, it is not
         /// possible to define which Amazon EC2 instances will be terminated. This applies to any Auto Scaling decisions that might result in
         /// terminating instances. </para> <para> There are two common use cases for <c>SetDesiredCapacity</c> :
         /// one for users of the Auto Scaling triggering system, and another for developers who write their own triggering systems. Both use
         /// cases relate to the concept of cooldown. </para> <para> In the first case, if you use the Auto Scaling triggering system,
         /// <c>SetDesiredCapacity</c> changes the size of your Auto Scaling group without regard to the cooldown period. This could be useful, for
         /// example, if Auto Scaling did something unexpected for some reason. If your cooldown period is 10 minutes, Auto Scaling would normally reject
         /// requests to change the size of the group for that entire 10-minute period. The <c>SetDesiredCapacity</c> command allows you to circumvent
         /// this restriction and change the size of the group before the end of the cooldown period. </para> <para> In the second case, if you write
         /// your own triggering system, you can use <c>SetDesiredCapacity</c> to control the size of your Auto Scaling group. If you want the same
         /// cooldown functionality that Auto Scaling offers, you can configure <c>SetDesiredCapacity</c> to honor cooldown by setting the
         /// <c>HonorCooldown</c> parameter to <c>true</c> .
         /// </para>
         /// </summary>
         /// 
         /// <param name="setDesiredCapacityRequest">Container for the necessary parameters to execute the SetDesiredCapacity service method on
         ///           AmazonAutoScaling.</param>
         /// 
         /// <exception cref="ScalingActivityInProgressException"/>
        SetDesiredCapacityResponse SetDesiredCapacity(SetDesiredCapacityRequest setDesiredCapacityRequest); 

         /// <summary>
         /// <para> Terminates the specified instance. Optionally, the desired group size can be adjusted. </para> <para><b>NOTE:</b> This call simply
         /// registers a termination request. The termination of the instance cannot happen immediately. </para>
         /// </summary>
         /// 
         /// <param name="terminateInstanceInAutoScalingGroupRequest">Container for the necessary parameters to execute the
         ///           TerminateInstanceInAutoScalingGroup service method on AmazonAutoScaling.</param>
         /// 
         /// <returns>The response from the TerminateInstanceInAutoScalingGroup service method, as returned by AmazonAutoScaling.</returns>
         /// 
         /// <exception cref="ScalingActivityInProgressException"/>
        TerminateInstanceInAutoScalingGroupResponse TerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest terminateInstanceInAutoScalingGroupRequest); 
    }
}
    
