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
using System.Collections.Generic;
using System.Text;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
    /// <summary>
    /// The available AWS access control policy actions for Auto Scaling.
    /// </summary>
    /// <see cref="Amazon.Auth.AccessControlPolicy.Statement.Actions"/>
    public class AutoScalingActionIdentifiers
    {
        public static readonly ActionIdentifier AllAutoScalingActions = new ActionIdentifier("autoscaling:*");

        public static readonly ActionIdentifier CreateAutoScalingGroup = new ActionIdentifier("autoscaling:CreateAutoScalingGroup");
        public static readonly ActionIdentifier CreateLaunchConfiguration = new ActionIdentifier("autoscaling:CreateLaunchConfiguration");
        public static readonly ActionIdentifier CreateOrUpdateScalingTrigger = new ActionIdentifier("autoscaling:CreateOrUpdateScalingTrigger");
        public static readonly ActionIdentifier DeleteAutoScalingGroup = new ActionIdentifier("autoscaling:DeleteAutoScalingGroup");
        public static readonly ActionIdentifier DeleteLaunchConfiguration = new ActionIdentifier("autoscaling:DeleteLaunchConfiguration");
        public static readonly ActionIdentifier DeleteTrigger = new ActionIdentifier("autoscaling:DeleteTrigger");
        public static readonly ActionIdentifier DescribeAutoScalingGroups = new ActionIdentifier("autoscaling:DescribeAutoScalingGroups");
        public static readonly ActionIdentifier DescribeLaunchConfigurations = new ActionIdentifier("autoscaling:DescribeLaunchConfigurations");
        public static readonly ActionIdentifier DescribeScalingActivities = new ActionIdentifier("autoscaling:DescribeScalingActivities");
        public static readonly ActionIdentifier DescribeTriggers = new ActionIdentifier("autoscaling:DescribeTriggers");
        public static readonly ActionIdentifier SetDesiredCapacity = new ActionIdentifier("autoscaling:SetDesiredCapacity");
        public static readonly ActionIdentifier TerminateInstanceInAutoScalingGroup = new ActionIdentifier("autoscaling:TerminateInstanceInAutoScalingGroup");
        public static readonly ActionIdentifier UpdateAutoScalingGroup = new ActionIdentifier("autoscaling:UpdateAutoScalingGroup");
    }
}
