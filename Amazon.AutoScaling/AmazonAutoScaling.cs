/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-05-15
 */

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Amazon.AutoScaling.Model;

namespace Amazon.AutoScaling
{
    /// <summary>
    /// Auto Scaling allows you to automatically scale your Amazon EC2 capacity up or down
    /// according to conditions you define. With Auto Scaling, you can ensure that the number
    /// of Amazon EC2 instances you’re using scales up seamlessly during demand spikes
    /// to maintain performance, and scales down automatically during demand lulls to minimize costs.
    /// Auto Scaling is particularly well suited for applications that experience hourly, daily,
    /// or weekly variability in usage. Auto Scaling is enabled by Amazon CloudWatch and available
    /// at no additional charge beyond Amazon CloudWatch fees.
    /// </summary>
    public interface AmazonAutoScaling
    {
        /// <summary>
        /// Delete Launch Configuration
        /// </summary>
        /// <param name="request">Delete Launch Configuration  request</param>
        /// <returns>Delete Launch Configuration  Response from the service</returns>
        DeleteLaunchConfigurationResponse DeleteLaunchConfiguration(DeleteLaunchConfigurationRequest request);

        /// <summary>
        /// Describe Triggers
        /// </summary>
        /// <param name="request">Describe Triggers  request</param>
        /// <returns>Describe Triggers  Response from the service</returns>
        DescribeTriggersResponse DescribeTriggers(DescribeTriggersRequest request);

        /// <summary>
        /// Update Auto Scaling Group
        /// </summary>
        /// <param name="request">Update Auto Scaling Group  request</param>
        /// <returns>Update Auto Scaling Group  Response from the service</returns>
        UpdateAutoScalingGroupResponse UpdateAutoScalingGroup(UpdateAutoScalingGroupRequest request);

        /// <summary>
        /// Create Auto Scaling Group
        /// </summary>
        /// <param name="request">Create Auto Scaling Group  request</param>
        /// <returns>Create Auto Scaling Group  Response from the service</returns>
        CreateAutoScalingGroupResponse CreateAutoScalingGroup(CreateAutoScalingGroupRequest request);

        /// <summary>
        /// Delete Trigger
        /// </summary>
        /// <param name="request">Delete Trigger  request</param>
        /// <returns>Delete Trigger  Response from the service</returns>
        DeleteTriggerResponse DeleteTrigger(DeleteTriggerRequest request);

        /// <summary>
        /// Terminate Instance In Auto Scaling Group
        /// </summary>
        /// <param name="request">Terminate Instance In Auto Scaling Group  request</param>
        /// <returns>Terminate Instance In Auto Scaling Group  Response from the service</returns>
        TerminateInstanceInAutoScalingGroupResponse TerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest request);

        /// <summary>
        /// Create Or Update Scaling Trigger
        /// </summary>
        /// <param name="request">Create Or Update Scaling Trigger  request</param>
        /// <returns>Create Or Update Scaling Trigger  Response from the service</returns>
        CreateOrUpdateScalingTriggerResponse CreateOrUpdateScalingTrigger(CreateOrUpdateScalingTriggerRequest request);

        /// <summary>
        /// Describe Auto Scaling Groups
        /// </summary>
        /// <param name="request">Describe Auto Scaling Groups  request</param>
        /// <returns>Describe Auto Scaling Groups  Response from the service</returns>
        DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest request);

        /// <summary>
        /// Create Launch Configuration
        /// </summary>
        /// <param name="request">Create Launch Configuration  request</param>
        /// <returns>Create Launch Configuration  Response from the service</returns>
        CreateLaunchConfigurationResponse CreateLaunchConfiguration(CreateLaunchConfigurationRequest request);

        /// <summary>
        /// Describe Launch Configurations
        /// </summary>
        /// <param name="request">Describe Launch Configurations  request</param>
        /// <returns>Describe Launch Configurations  Response from the service</returns>
        DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest request);

        /// <summary>
        /// Describe Scaling Activities
        /// </summary>
        /// <param name="request">Describe Scaling Activities  request</param>
        /// <returns>Describe Scaling Activities  Response from the service</returns>
        DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest request);

        /// <summary>
        /// Set Desired Capacity
        /// </summary>
        /// <param name="request">Set Desired Capacity  request</param>
        /// <returns>Set Desired Capacity  Response from the service</returns>
        SetDesiredCapacityResponse SetDesiredCapacity(SetDesiredCapacityRequest request);

        /// <summary>
        /// Delete Auto Scaling Group
        /// </summary>
        /// <param name="request">Delete Auto Scaling Group  request</param>
        /// <returns>Delete Auto Scaling Group  Response from the service</returns>
        DeleteAutoScalingGroupResponse DeleteAutoScalingGroup(DeleteAutoScalingGroupRequest request);

    }
}
