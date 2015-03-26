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
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
    /// <summary>
    /// The available AWS access control policy actions for AWS CloudTrail.
    /// </summary>
    /// <see cref="Amazon.Auth.AccessControlPolicy.Statement.Actions"/>
    public static class CloudTrailActionIdentifiers
    {
        public static readonly ActionIdentifier AllCloudTrailActions = new ActionIdentifier("cloudtrail:*");

        public static readonly ActionIdentifier CreateTrail = new ActionIdentifier("cloudtrail:CreateTrail");
        public static readonly ActionIdentifier DeleteTrail = new ActionIdentifier("cloudtrail:DeleteTrail");
        public static readonly ActionIdentifier DescribeTrails = new ActionIdentifier("cloudtrail:DescribeTrails");
        public static readonly ActionIdentifier GetTrailStatus = new ActionIdentifier("cloudtrail:GetTrailStatus");
        public static readonly ActionIdentifier StartLogging = new ActionIdentifier("cloudtrail:StartLogging");
        public static readonly ActionIdentifier StopLogging = new ActionIdentifier("cloudtrail:StopLogging");
        public static readonly ActionIdentifier UpdateTrail = new ActionIdentifier("cloudtrail:UpdateTrail");
    }
}
