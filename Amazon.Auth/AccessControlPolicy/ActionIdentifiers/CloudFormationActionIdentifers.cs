/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// The available AWS access control policy actions for AWS CloudFormation.
    /// </summary>
    /// <see cref="Amazon.Auth.AccessControlPolicy.Statement.Actions"/>
    public class CloudFormationActionIdentifers
    {
        /// <summary>
        /// Represents any action being taken on AWS CloudFormation.
        /// </summary>
        public static readonly ActionIdentifier AllCloudFormationActions = new ActionIdentifier("cloudformation:*");

        /// <summary>
        /// Action for creating a stack as specified in the template.
        /// </summary>
        /// <see cref="Amazon.CloudFormation.Model.CreateStackRequest"/>
        public static readonly ActionIdentifier CreateStack = new ActionIdentifier("cloudformation:CreateStack");

        /// <summary>
        /// Action for deleting a stack.
        /// </summary>
        /// <see cref="Amazon.CloudFormation.Model.DeleteStackRequest"/>
        public static readonly ActionIdentifier DeleteStack = new ActionIdentifier("cloudformation:DeleteStack");

        /// <summary>
        /// Action for describing stacks.
        /// </summary>
        /// <see cref="Amazon.CloudFormation.Model.DescribeStacksRequest"/>
        public static readonly ActionIdentifier DescribeStacks = new ActionIdentifier("cloudformation:DescribeStacks");

        /// <summary>
        /// Action for describing stack events.
        /// </summary>
        /// <see cref="Amazon.CloudFormation.Model.DescribeStackEventsRequest"/>
        public static readonly ActionIdentifier DescribeStackEvents = new ActionIdentifier("cloudformation:DescribeStackEvents");

        /// <summary>
        /// Action for describing stack resources.
        /// </summary>
        /// <see cref="Amazon.CloudFormation.Model.DescribeStackResourcesRequest"/>
        public static readonly ActionIdentifier DescribeStackResources = new ActionIdentifier("cloudformation:DescribeStackResources");

        /// <summary>
        /// Action for getting the template body for a specified stack name.
        /// </summary>
        /// <see cref="Amazon.CloudFormation.Model.GetTemplateRequest"/>
        public static readonly ActionIdentifier GetTemplate = new ActionIdentifier("cloudformation:GetTemplate");

        /// <summary>
        /// Action for validating a specified template.
        /// </summary>
        /// <see cref="Amazon.CloudFormation.Model.ValidateTemplateRequest"/>
        public static readonly ActionIdentifier ValidateTemplate = new ActionIdentifier("cloudformation:ValidateTemplate");

    }
}
