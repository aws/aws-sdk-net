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
 *  API Version: 2010-01-01
 */

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Amazon.RDS.Model;

namespace Amazon.RDS
{
    /// <summary>
    /// Amazon Relational Database Service (Amazon RDS) is a web service that makes it easier to set up, operate, and scale a relational
    /// database in the cloud. It provides cost-efficient, resizable capacity for an industry-standard relational database and manages common
    /// database administration tasks, freeing up developers to focus on what makes their applications and businesses unique.
    /// Amazon RDS gives you access to the capabilities of a familiar MySQL database server. This means the code, applications, and tools you
    /// already use today with your existing MySQL databases work with Amazon RDS without modification. Amazon RDS automatically backs up your
    /// database and maintains the database software that powers your DB Instance. Amazon RDS is flexible: you can scale your database
    /// instance's compute resources and storage capacity to meet your application's demand. As with all Amazon Web Services, there are no
    /// up-front investments, and you pay only for the resources you use.
    /// </summary>
    public interface AmazonRDS : IDisposable
    {
        /// <summary>
        /// Describe DB Security Groups
        /// </summary>
        /// <param name="request">Describe DB Security Groups  request</param>
        /// <returns>Describe DB Security Groups  Response from the service</returns>
        /// <remarks>
        /// This API returns a list of DBSecurityGroup descriptions. If a DBSecurityGroupName is specified,
        /// the list will contain only the descriptions of the specified DBSecurityGroup.
        /// </remarks>
        DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest request);

        /// <summary>
        /// Restore DB Instance From DB Snapshot
        /// </summary>
        /// <param name="request">Restore DB Instance From DB Snapshot  request</param>
        /// <returns>Restore DB Instance From DB Snapshot  Response from the service</returns>
        /// <remarks>
        /// This API creates a new DB Instance to an arbitrary point-in-time. Users can restore to any point in
        /// time before the latestRestorableTime for up to backupRetentionPeriod days. The target database is created
        /// from the source database with the same configuration as the original database except that the DB instance
        /// is created with the default DB security group.
        /// </remarks>
        RestoreDBInstanceFromDBSnapshotResponse RestoreDBInstanceFromDBSnapshot(RestoreDBInstanceFromDBSnapshotRequest request);

        /// <summary>
        /// Modify DB Instance
        /// </summary>
        /// <param name="request">Modify DB Instance  request</param>
        /// <returns>Modify DB Instance  Response from the service</returns>
        /// <remarks>
        /// This API is used to change RDS Instance settings. Users call the ModifyDBInstance API to change one
        /// or more database configuration parameters by specifying these parameters and the new values in the
        /// request.
        /// </remarks>
        ModifyDBInstanceResponse ModifyDBInstance(ModifyDBInstanceRequest request);

        /// <summary>
        /// Create DB Parameter Group
        /// </summary>
        /// <param name="request">Create DB Parameter Group  request</param>
        /// <returns>Create DB Parameter Group  Response from the service</returns>
        /// <remarks>
        /// This API creates a new database parameter group.
        /// </remarks>
        CreateDBParameterGroupResponse CreateDBParameterGroup(CreateDBParameterGroupRequest request);

        /// <summary>
        /// Delete DB Security Group
        /// </summary>
        /// <param name="request">Delete DB Security Group  request</param>
        /// <returns>Delete DB Security Group  Response from the service</returns>
        /// <remarks>
        /// This API deletes a database security group. Database security group must not be associated with any
        /// RDS Instances.
        /// </remarks>
        DeleteDBSecurityGroupResponse DeleteDBSecurityGroup(DeleteDBSecurityGroupRequest request);

        /// <summary>
        /// Create DB Instance
        /// </summary>
        /// <param name="request">Create DB Instance  request</param>
        /// <returns>Create DB Instance  Response from the service</returns>
        /// <remarks>
        /// This API creates a new DB instance.
        /// </remarks>
        CreateDBInstanceResponse CreateDBInstance(CreateDBInstanceRequest request);

        /// <summary>
        /// Create DB Security Group
        /// </summary>
        /// <param name="request">Create DB Security Group  request</param>
        /// <returns>Create DB Security Group  Response from the service</returns>
        /// <remarks>
        /// This API creates a new database security group. Database Security groups control access to a database instance.
        /// </remarks>
        CreateDBSecurityGroupResponse CreateDBSecurityGroup(CreateDBSecurityGroupRequest request);

        /// <summary>
        /// Reboot DB Instance
        /// </summary>
        /// <param name="request">Reboot DB Instance  request</param>
        /// <returns>Reboot DB Instance  Response from the service</returns>
        /// <remarks>
        /// The RebootDBInstance API reboots a previously provisioned RDS instance. This API results in the
        /// application of modified DBParameterGroup parameters with ApplyStatus of pending-reboot to the
        /// RDS instance. This action is taken as soon as possible, and results in a momentary outage to the RDS
        /// instance during which the RDS instance status is set to rebooting. A DBInstance event is created
        /// when the reboot is completed.
        /// </remarks>
        RebootDBInstanceResponse RebootDBInstance(RebootDBInstanceRequest request);

        /// <summary>
        /// Authorize DB Security Group Ingress
        /// </summary>
        /// <param name="request">Authorize DB Security Group Ingress  request</param>
        /// <returns>Authorize DB Security Group Ingress  Response from the service</returns>
        /// <remarks>
        /// This API allows for ingress to a DBSecurityGroup using one of two forms of authorization. First,
        /// EC2 Security Groups can be added to the DBSecurityGroup if the application using the database
        /// is running on EC2 instances. Second, IP ranges are available if the application accessing your
        /// database is running on the Internet. Required parameters for this API are one of CIDR range or
        /// (EC2SecurityGroupName AND EC2SecurityGroupOwnerId).
        /// </remarks>
        AuthorizeDBSecurityGroupIngressResponse AuthorizeDBSecurityGroupIngress(AuthorizeDBSecurityGroupIngressRequest request);

        /// <summary>
        /// Delete DB Snapshot
        /// </summary>
        /// <param name="request">Delete DB Snapshot  request</param>
        /// <returns>Delete DB Snapshot  Response from the service</returns>
        /// <remarks>
        /// This API is used to delete a DBSnapshot. The DBSnapshot must be in the &quot;available&quot; state to be
        /// deleted.
        /// </remarks>
        DeleteDBSnapshotResponse DeleteDBSnapshot(DeleteDBSnapshotRequest request);

        /// <summary>
        /// Delete DB Parameter Group
        /// </summary>
        /// <param name="request">Delete DB Parameter Group  request</param>
        /// <returns>Delete DB Parameter Group  Response from the service</returns>
        /// <remarks>
        /// This API deletes a particular DBParameterGroup. The DBParameterGroup cannot be associated with
        /// any RDS instances to be deleted.
        /// </remarks>
        DeleteDBParameterGroupResponse DeleteDBParameterGroup(DeleteDBParameterGroupRequest request);

        /// <summary>
        /// Describe Events
        /// </summary>
        /// <param name="request">Describe Events  request</param>
        /// <returns>Describe Events  Response from the service</returns>
        /// <remarks>
        /// This API returns events related to DB Instances, DB Security Groups, DB Snapshots and DB Parameter
        /// Groups for the past 14 das. Events specific to a particular DB Instance, database security group,
        /// database snapshot or database parameter group can be obtained by providing the name as a parameter.
        /// By default, the past hour of events are returned.
        /// </remarks>
        DescribeEventsResponse DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Describe DB Instances
        /// </summary>
        /// <param name="request">Describe DB Instances  request</param>
        /// <returns>Describe DB Instances  Response from the service</returns>
        /// <remarks>
        /// This API is used to retrieve information about provisioned RDS instances. DescribeDBInstances
        /// supports pagination.
        /// </remarks>
        DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest request);

        /// <summary>
        /// Describe DB Parameter Groups
        /// </summary>
        /// <param name="request">Describe DB Parameter Groups  request</param>
        /// <returns>Describe DB Parameter Groups  Response from the service</returns>
        /// <remarks>
        /// This API returns a list of DBParameterGroup descriptions. If a DBParameterGroupName is specified,
        /// the list will contain only the descriptions of the specified DBParameterGroup.
        /// </remarks>
        DescribeDBParameterGroupsResponse DescribeDBParameterGroups(DescribeDBParameterGroupsRequest request);

        /// <summary>
        /// Describe Engine Default Parameters
        /// </summary>
        /// <param name="request">Describe Engine Default Parameters  request</param>
        /// <returns>Describe Engine Default Parameters  Response from the service</returns>
        /// <remarks>
        /// This API returns the default engine and system parameter information for the specified database engine.
        /// </remarks>
        DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request);

        /// <summary>
        /// Modify DB Parameter Group
        /// </summary>
        /// <param name="request">Modify DB Parameter Group  request</param>
        /// <returns>Modify DB Parameter Group  Response from the service</returns>
        /// <remarks>
        /// This API modifies the parameters of a DBParameterGroup. To modify more than one parameter
        /// submit a list of the following: ParameterName, ParameterValue, and ApplyMethod. A maximum of 20
        /// parameters can be modified in a single request.
        /// </remarks>
        ModifyDBParameterGroupResponse ModifyDBParameterGroup(ModifyDBParameterGroupRequest request);

        /// <summary>
        /// Describe DB Snapshots
        /// </summary>
        /// <param name="request">Describe DB Snapshots  request</param>
        /// <returns>Describe DB Snapshots  Response from the service</returns>
        /// <remarks>
        /// This API is used to retrieve information about DBSnapshots. This API supports pagination.
        /// </remarks>
        DescribeDBSnapshotsResponse DescribeDBSnapshots(DescribeDBSnapshotsRequest request);

        /// <summary>
        /// Reset DB Parameter Group
        /// </summary>
        /// <param name="request">Reset DB Parameter Group  request</param>
        /// <returns>Reset DB Parameter Group  Response from the service</returns>
        /// <remarks>
        /// This API modifies the parameters of a DBParameterGroup to the engine/system default value. To
        /// reset specific parameters submit a list of the following: ParameterName and ApplyMethod. To reset the
        /// entire DBParameterGroup specify the DBParameterGroup name and ResetAllParameters parameters.
        /// When resetting the entire group, dynamic parameters are updated immediately and static parameters
        /// are set to pending-reboot to take effect on the next MySQL reboot or RebootDBInstance request.
        /// </remarks>
        ResetDBParameterGroupResponse ResetDBParameterGroup(ResetDBParameterGroupRequest request);

        /// <summary>
        /// Describe DB Parameters
        /// </summary>
        /// <param name="request">Describe DB Parameters  request</param>
        /// <returns>Describe DB Parameters  Response from the service</returns>
        /// <remarks>
        /// This API returns the detailed parameter list for a particular DBParameterGroup.
        /// </remarks>
        DescribeDBParametersResponse DescribeDBParameters(DescribeDBParametersRequest request);

        /// <summary>
        /// Delete DB Instance
        /// </summary>
        /// <param name="request">Delete DB Instance  request</param>
        /// <returns>Delete DB Instance  Response from the service</returns>
        /// <remarks>
        /// The DeleteDBInstance API deletes a previously provisioned RDS instance. A successful response
        /// from the web service indicates the request was received correctly. If a final DBSnapshot is requested
        /// the status of the RDS instance will be &quot;deleting&quot; until the DBSnapshot is created. DescribeDBInstance
        /// is used to monitor the status of this operation. This cannot be canceled or reverted once submitted.
        /// </remarks>
        DeleteDBInstanceResponse DeleteDBInstance(DeleteDBInstanceRequest request);

        /// <summary>
        /// Restore DB Instance To Point In Time
        /// </summary>
        /// <param name="request">Restore DB Instance To Point In Time  request</param>
        /// <returns>Restore DB Instance To Point In Time  Response from the service</returns>
        /// <remarks>
        /// This API creates a new RDS instance from a point-in-time system snapshot. The target database is created
        /// from the source database restore point with the same configuration as the original source database,
        /// except that the new RDS instance is created with the default security group.
        /// </remarks>
        RestoreDBInstanceToPointInTimeResponse RestoreDBInstanceToPointInTime(RestoreDBInstanceToPointInTimeRequest request);

        /// <summary>
        /// Create DB Snapshot
        /// </summary>
        /// <param name="request">Create DB Snapshot  request</param>
        /// <returns>Create DB Snapshot  Response from the service</returns>
        /// <remarks>
        /// This API is used to create a DBSnapshot. The source DBInstance must be in &quot;available&quot; state.
        /// </remarks>
        CreateDBSnapshotResponse CreateDBSnapshot(CreateDBSnapshotRequest request);

        /// <summary>
        /// Revoke DB Security Group Ingress
        /// </summary>
        /// <param name="request">Revoke DB Security Group Ingress  request</param>
        /// <returns>Revoke DB Security Group Ingress  Response from the service</returns>
        /// <remarks>
        /// This API revokes ingress from a DBSecurityGroup for previously authorized IP ranges or EC2 Security
        /// Groups. Required parameters for this API are one of CIDRIP or (EC2SecurityGroupName AND
        /// EC2SecurityGroupOwnerId).
        /// </remarks>
        RevokeDBSecurityGroupIngressResponse RevokeDBSecurityGroupIngress(RevokeDBSecurityGroupIngressRequest request);

    }
}
