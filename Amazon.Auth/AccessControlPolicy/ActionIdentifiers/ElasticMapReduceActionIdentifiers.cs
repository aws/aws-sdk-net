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
    /// The available AWS access control policy actions for Amazon Elastic MapReduce.
    /// </summary>
    /// <see cref="Amazon.Auth.AccessControlPolicy.Statement.Actions"/>
    public class ElasticMapReduceActionIdentifiers
    {
        public static readonly ActionIdentifier AllElasticMapReduceActions = new ActionIdentifier("elasticmapreduce:*");

        public static readonly ActionIdentifier AddInstanceGroups = new ActionIdentifier("elasticmapreduce:AddInstanceGroups");
        public static readonly ActionIdentifier AddJobFlowSteps = new ActionIdentifier("elasticmapreduce:AddJobFlowSteps");
        public static readonly ActionIdentifier DescribeJobFlows = new ActionIdentifier("elasticmapreduce:DescribeJobFlows");
        public static readonly ActionIdentifier ModifyInstanceGroups = new ActionIdentifier("elasticmapreduce:ModifyInstanceGroups");
        public static readonly ActionIdentifier RunJobFlow = new ActionIdentifier("elasticmapreduce:RunJobFlow");
        public static readonly ActionIdentifier TerminateJobFlows = new ActionIdentifier("elasticmapreduce:TerminateJobFlows");
    }
}
