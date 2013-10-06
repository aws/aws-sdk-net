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
using System.Collections.Generic;
using System.Text;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
    /// <summary>
    /// The available AWS access control policy actions for Amazon RDS.
    /// </summary>
    /// <see cref="Amazon.Auth.AccessControlPolicy.Statement.Actions"/>
    public class RDSActionIdentifiers
    {
        public static readonly ActionIdentifier AllRDSActions = new ActionIdentifier("rds:*");

        public static readonly ActionIdentifier AuthorizeDBSecurityGroupIngress = new ActionIdentifier("rds:AuthorizeDBSecurityGroupIngress");
        public static readonly ActionIdentifier CreateDBInstance = new ActionIdentifier("rds:CreateDBInstance");
        public static readonly ActionIdentifier CreateDBInstanceReadReplica = new ActionIdentifier("rds:CreateDBInstanceReadReplica");
        public static readonly ActionIdentifier CreateDBParameterGroup = new ActionIdentifier("rds:CreateDBParameterGroup");
        public static readonly ActionIdentifier CreateDBSecurityGroup = new ActionIdentifier("rds:CreateDBSecurityGroup");
        public static readonly ActionIdentifier CreateDBSnapshot = new ActionIdentifier("rds:CreateDBSnapshot");
        public static readonly ActionIdentifier DeleteDBInstance = new ActionIdentifier("rds:DeleteDBInstance");
        public static readonly ActionIdentifier DeleteDBParameterGroup = new ActionIdentifier("rds:DeleteDBParameterGroup");
        public static readonly ActionIdentifier DeleteDBSecurityGroup = new ActionIdentifier("rds:DeleteDBSecurityGroup");
        public static readonly ActionIdentifier DeleteDBSnapshot = new ActionIdentifier("rds:DeleteDBSnapshot");
        public static readonly ActionIdentifier DescribeDBEngineVersions = new ActionIdentifier("rds:DescribeDBEngineVersions");
        public static readonly ActionIdentifier DescribeDBInstances = new ActionIdentifier("rds:DescribeDBInstances");
        public static readonly ActionIdentifier DescribeDBParameterGroups = new ActionIdentifier("rds:DescribeDBParameterGroups");
        public static readonly ActionIdentifier DescribeDBParameters = new ActionIdentifier("rds:DescribeDBParameters");
        public static readonly ActionIdentifier DescribeDBSecurityGroups = new ActionIdentifier("rds:DescribeDBSecurityGroups");
        public static readonly ActionIdentifier DescribeDBSnapshots = new ActionIdentifier("rds:DescribeDBSnapshots");
        public static readonly ActionIdentifier DescribeEngineDefaultParameters = new ActionIdentifier("rds:DescribeEngineDefaultParameters");
        public static readonly ActionIdentifier DescribeEvents = new ActionIdentifier("rds:DescribeEvents");
        public static readonly ActionIdentifier DescribeReservedDBInstances = new ActionIdentifier("rds:DescribeReservedDBInstances");
        public static readonly ActionIdentifier DescribeReservedDBInstancesOfferings = new ActionIdentifier("rds:DescribeReservedDBInstancesOfferings");
        public static readonly ActionIdentifier ListTagsForResource = new ActionIdentifier("rds:ListTagsForResource");
        public static readonly ActionIdentifier ModifyDBInstance = new ActionIdentifier("rds:ModifyDBInstance");
        public static readonly ActionIdentifier ModifyDBParameterGroup = new ActionIdentifier("rds:ModifyDBParameterGroup");
        public static readonly ActionIdentifier PurchaseReservedDBInstancesOffering = new ActionIdentifier("rds:PurchaseReservedDBInstancesOffering");
        public static readonly ActionIdentifier RebootDBInstance = new ActionIdentifier("rds:RebootDBInstance");
        public static readonly ActionIdentifier ResetDBParameterGroup = new ActionIdentifier("rds:ResetDBParameterGroup");
        public static readonly ActionIdentifier RestoreDBInstanceFromDBSnapshot = new ActionIdentifier("rds:RestoreDBInstanceFromDBSnapshot");
        public static readonly ActionIdentifier RestoreDBInstanceToPointInTime = new ActionIdentifier("rds:RestoreDBInstanceToPointInTime");
        public static readonly ActionIdentifier RevokeDBSecurityGroupIngress = new ActionIdentifier("rds:RevokeDBSecurityGroupIngress");
    }
}
