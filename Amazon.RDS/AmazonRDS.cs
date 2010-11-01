/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.RDS;
using Amazon.RDS.Model;

namespace Amazon.RDS
{
    /// <summary>
    /// Interface for accessing AmazonRDS.
    ///  
    ///  <para> Amazon Relational Database Service (Amazon RDS) is a web
    /// service that makes it easier to set up, operate, and scale a
    /// relational database in the cloud. It provides cost-efficient,
    /// resizable capacity for an industry-standard relational database and
    /// manages common database administration tasks, freeing up developers to
    /// focus on what makes their applications and businesses unique. </para>
    /// <para> Amazon RDS gives you access to the capabilities of a familiar
    /// MySQL database server. This means the code, applications, and tools
    /// you already use today with your existing MySQL databases work with
    /// Amazon RDS without modification. Amazon RDS automatically backs up
    /// your database and maintains the database software that powers your DB
    /// Instance. Amazon RDS is flexible: you can scale your database
    /// instance's compute resources and storage capacity to meet your
    /// application's demand. As with all Amazon Web Services, there are no
    /// up-front investments, and you pay only for the resources you use.
    /// </para>
    /// </summary>
    public interface AmazonRDS : IDisposable
    {
        

         /// <summary>
         /// <para> This API deletes a particular DBParameterGroup. The
         /// DBParameterGroup cannot be associated with any RDS instances to be
         /// deleted. </para>
         /// </summary>
         /// 
         /// <param name="deleteDBParameterGroupRequest">Container for the
         ///           necessary parameters to execute the DeleteDBParameterGroup service
         ///           method on AmazonRDS.</param>
         /// 
         /// <exception cref="DBParameterGroupNotFoundException"/>
         /// <exception cref="InvalidDBParameterGroupStateException"/>
        DeleteDBParameterGroupResponse DeleteDBParameterGroup(DeleteDBParameterGroupRequest deleteDBParameterGroupRequest); 

         /// <summary>
         /// <para> This API is used to delete a DBSnapshot. The DBSnapshot must be
         /// in the "available" state to be deleted. </para>
         /// </summary>
         /// 
         /// <param name="deleteDBSnapshotRequest">Container for the necessary
         ///           parameters to execute the DeleteDBSnapshot service method on
         ///           AmazonRDS.</param>
         /// 
         /// <returns>The response from the DeleteDBSnapshot service method, as
         ///         returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="InvalidDBSnapshotStateException"/>
         /// <exception cref="DBSnapshotNotFoundException"/>
        DeleteDBSnapshotResponse DeleteDBSnapshot(DeleteDBSnapshotRequest deleteDBSnapshotRequest); 

         /// <summary>
         /// <para> This API modifies the parameters of a DBParameterGroup. To
         /// modify more than one parameter submit a list of the following:
         /// ParameterName, ParameterValue, and ApplyMethod. A maximum of 20
         /// parameters can be modified in a single request. </para>
         /// </summary>
         /// 
         /// <param name="modifyDBParameterGroupRequest">Container for the
         ///           necessary parameters to execute the ModifyDBParameterGroup service
         ///           method on AmazonRDS.</param>
         /// 
         /// <returns>The response from the ModifyDBParameterGroup service method,
         ///         as returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="DBParameterGroupNotFoundException"/>
         /// <exception cref="InvalidDBParameterGroupStateException"/>
        ModifyDBParameterGroupResponse ModifyDBParameterGroup(ModifyDBParameterGroupRequest modifyDBParameterGroupRequest); 

         /// <summary>
         /// <para> This API revokes ingress from a DBSecurityGroup for previously
         /// authorized IP ranges or EC2 Security Groups. Required parameters for
         /// this API are one of CIDRIP or (EC2SecurityGroupName AND
         /// EC2SecurityGroupOwnerId). </para>
         /// </summary>
         /// 
         /// <param name="revokeDBSecurityGroupIngressRequest">Container for the
         ///           necessary parameters to execute the RevokeDBSecurityGroupIngress
         ///           service method on AmazonRDS.</param>
         /// 
         /// <returns>The response from the RevokeDBSecurityGroupIngress service
         ///         method, as returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="DBSecurityGroupNotFoundException"/>
         /// <exception cref="InvalidDBSecurityGroupStateException"/>
         /// <exception cref="AuthorizationNotFoundException"/>
        RevokeDBSecurityGroupIngressResponse RevokeDBSecurityGroupIngress(RevokeDBSecurityGroupIngressRequest revokeDBSecurityGroupIngressRequest); 

         /// <summary>
         /// <para> This API returns the detailed parameter list for a particular
         /// DBParameterGroup. </para>
         /// </summary>
         /// 
         /// <param name="describeDBParametersRequest">Container for the necessary
         ///           parameters to execute the DescribeDBParameters service method on
         ///           AmazonRDS.</param>
         /// 
         /// <returns>The response from the DescribeDBParameters service method, as
         ///         returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="DBParameterGroupNotFoundException"/>
        DescribeDBParametersResponse DescribeDBParameters(DescribeDBParametersRequest describeDBParametersRequest); 

         /// <summary>
         /// <para> This API returns events related to DB Instances, DB Security
         /// Groups, DB Snapshots and DB Parameter Groups for the past 14 das.
         /// Events specific to a particular DB Instance, database security group,
         /// database snapshot or database parameter group can be obtained by
         /// providing the name as a parameter. By default, the past hour of events
         /// are returned. </para>
         /// </summary>
         /// 
         /// <param name="describeEventsRequest">Container for the necessary
         ///           parameters to execute the DescribeEvents service method on
         ///           AmazonRDS.</param>
         /// 
         /// <returns>The response from the DescribeEvents service method, as
         ///         returned by AmazonRDS.</returns>
         /// 
        DescribeEventsResponse DescribeEvents(DescribeEventsRequest describeEventsRequest); 

         /// <summary>
         /// <para> This API creates a new database security group. Database
         /// Security groups control access to a database instance. </para>
         /// </summary>
         /// 
         /// <param name="createDBSecurityGroupRequest">Container for the necessary
         ///           parameters to execute the CreateDBSecurityGroup service method on
         ///           AmazonRDS.</param>
         /// 
         /// <returns>The response from the CreateDBSecurityGroup service method,
         ///         as returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="DBSecurityGroupQuotaExceededException"/>
         /// <exception cref="DBSecurityGroupAlreadyExistsException"/>
        CreateDBSecurityGroupResponse CreateDBSecurityGroup(CreateDBSecurityGroupRequest createDBSecurityGroupRequest); 

         /// <summary>
         /// <para> This API is used to retrieve information about provisioned RDS
         /// instances. DescribeDBInstances supports pagination. </para>
         /// </summary>
         /// 
         /// <param name="describeDBInstancesRequest">Container for the necessary
         ///           parameters to execute the DescribeDBInstances service method on
         ///           AmazonRDS.</param>
         /// 
         /// <returns>The response from the DescribeDBInstances service method, as
         ///         returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="DBInstanceNotFoundException"/>
        DescribeDBInstancesResponse DescribeDBInstances(DescribeDBInstancesRequest describeDBInstancesRequest); 

         /// <summary>
         /// <para> This API returns a list of DBParameterGroup descriptions. If a
         /// DBParameterGroupName is specified, the list will contain only the
         /// descriptions of the specified DBParameterGroup. </para>
         /// </summary>
         /// 
         /// <param name="describeDBParameterGroupsRequest">Container for the
         ///           necessary parameters to execute the DescribeDBParameterGroups service
         ///           method on AmazonRDS.</param>
         /// 
         /// <returns>The response from the DescribeDBParameterGroups service
         ///         method, as returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="DBParameterGroupNotFoundException"/>
        DescribeDBParameterGroupsResponse DescribeDBParameterGroups(DescribeDBParameterGroupsRequest describeDBParameterGroupsRequest); 

         /// <summary>
         /// <para> This API is used to create a DBSnapshot. The source DBInstance
         /// must be in "available" state. </para>
         /// </summary>
         /// 
         /// <param name="createDBSnapshotRequest">Container for the necessary
         ///           parameters to execute the CreateDBSnapshot service method on
         ///           AmazonRDS.</param>
         /// 
         /// <returns>The response from the CreateDBSnapshot service method, as
         ///         returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="DBInstanceNotFoundException"/>
         /// <exception cref="InvalidDBInstanceStateException"/>
         /// <exception cref="SnapshotQuotaExceededException"/>
         /// <exception cref="DBSnapshotAlreadyExistsException"/>
        CreateDBSnapshotResponse CreateDBSnapshot(CreateDBSnapshotRequest createDBSnapshotRequest); 

         /// <summary>
         /// </summary>
         /// 
         /// <param name="describeDBEngineVersionsRequest">Container for the
         ///           necessary parameters to execute the DescribeDBEngineVersions service
         ///           method on AmazonRDS.</param>
         /// 
         /// <returns>The response from the DescribeDBEngineVersions service
         ///         method, as returned by AmazonRDS.</returns>
         /// 
        DescribeDBEngineVersionsResponse DescribeDBEngineVersions(DescribeDBEngineVersionsRequest describeDBEngineVersionsRequest); 

         /// <summary>
         /// <para> The RebootDBInstance API reboots a previously provisioned RDS
         /// instance. This API results in the application of modified
         /// DBParameterGroup parameters with ApplyStatus of pending-reboot to the
         /// RDS instance. This action is taken as soon as possible, and results in
         /// a momentary outage to the RDS instance during which the RDS instance
         /// status is set to rebooting. A DBInstance event is created when the
         /// reboot is completed. </para>
         /// </summary>
         /// 
         /// <param name="rebootDBInstanceRequest">Container for the necessary
         ///           parameters to execute the RebootDBInstance service method on
         ///           AmazonRDS.</param>
         /// 
         /// <returns>The response from the RebootDBInstance service method, as
         ///         returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="DBInstanceNotFoundException"/>
         /// <exception cref="InvalidDBInstanceStateException"/>
        RebootDBInstanceResponse RebootDBInstance(RebootDBInstanceRequest rebootDBInstanceRequest); 

         /// <summary>
         /// <para> This API allows for ingress to a DBSecurityGroup using one of
         /// two forms of authorization. First, EC2 Security Groups can be added to
         /// the DBSecurityGroup if the application using the database is running
         /// on EC2 instances. Second, IP ranges are available if the application
         /// accessing your database is running on the Internet. Required
         /// parameters for this API are one of CIDR range or (EC2SecurityGroupName
         /// AND EC2SecurityGroupOwnerId). </para>
         /// </summary>
         /// 
         /// <param name="authorizeDBSecurityGroupIngressRequest">Container for the
         ///           necessary parameters to execute the AuthorizeDBSecurityGroupIngress
         ///           service method on AmazonRDS.</param>
         /// 
         /// <returns>The response from the AuthorizeDBSecurityGroupIngress service
         ///         method, as returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="DBSecurityGroupNotFoundException"/>
         /// <exception cref="InvalidDBSecurityGroupStateException"/>
         /// <exception cref="AuthorizationAlreadyExistsException"/>
        AuthorizeDBSecurityGroupIngressResponse AuthorizeDBSecurityGroupIngress(AuthorizeDBSecurityGroupIngressRequest authorizeDBSecurityGroupIngressRequest); 

         /// <summary>
         /// <para> This API creates a new RDS instance from a point-in-time system
         /// snapshot. The target database is created from the source database
         /// restore point with the same configuration as the original source
         /// database, except that the new RDS instance is created with the default
         /// security group. </para>
         /// </summary>
         /// 
         /// <param name="restoreDBInstanceToPointInTimeRequest">Container for the
         ///           necessary parameters to execute the RestoreDBInstanceToPointInTime
         ///           service method on AmazonRDS.</param>
         /// 
         /// <returns>The response from the RestoreDBInstanceToPointInTime service
         ///         method, as returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="PointInTimeRestoreNotEnabledException"/>
         /// <exception cref="InstanceQuotaExceededException"/>
         /// <exception cref="DBInstanceAlreadyExistsException"/>
         /// <exception cref="DBInstanceNotFoundException"/>
         /// <exception cref="StorageQuotaExceededException"/>
         /// <exception cref="InvalidDBInstanceStateException"/>
         /// <exception cref="InsufficientDBInstanceCapacityException"/>
        RestoreDBInstanceToPointInTimeResponse RestoreDBInstanceToPointInTime(RestoreDBInstanceToPointInTimeRequest restoreDBInstanceToPointInTimeRequest); 

         /// <summary>
         /// <para> This API is used to retrieve information about DBSnapshots.
         /// This API supports pagination. </para>
         /// </summary>
         /// 
         /// <param name="describeDBSnapshotsRequest">Container for the necessary
         ///           parameters to execute the DescribeDBSnapshots service method on
         ///           AmazonRDS.</param>
         /// 
         /// <returns>The response from the DescribeDBSnapshots service method, as
         ///         returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="DBSnapshotNotFoundException"/>
        DescribeDBSnapshotsResponse DescribeDBSnapshots(DescribeDBSnapshotsRequest describeDBSnapshotsRequest); 

         /// <summary>
         /// </summary>
         /// 
         /// <param name="describeReservedDBInstancesOfferingsRequest">Container
         ///           for the necessary parameters to execute the
         ///           DescribeReservedDBInstancesOfferings service method on
         ///           AmazonRDS.</param>
         /// 
         /// <returns>The response from the DescribeReservedDBInstancesOfferings
         ///         service method, as returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="ReservedDBInstancesOfferingNotFoundException"/>
        DescribeReservedDBInstancesOfferingsResponse DescribeReservedDBInstancesOfferings(DescribeReservedDBInstancesOfferingsRequest describeReservedDBInstancesOfferingsRequest); 

         /// <summary>
         /// <para> This API returns the default engine and system parameter
         /// information for the specified database engine. </para>
         /// </summary>
         /// 
         /// <param name="describeEngineDefaultParametersRequest">Container for the
         ///           necessary parameters to execute the DescribeEngineDefaultParameters
         ///           service method on AmazonRDS.</param>
         /// 
         /// <returns>The response from the DescribeEngineDefaultParameters service
         ///         method, as returned by AmazonRDS.</returns>
         /// 
        DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest describeEngineDefaultParametersRequest); 

         /// <summary>
         /// <para> The DeleteDBInstance API deletes a previously provisioned RDS
         /// instance. A successful response from the web service indicates the
         /// request was received correctly. If a final DBSnapshot is requested the
         /// status of the RDS instance will be "deleting" until the DBSnapshot is
         /// created. DescribeDBInstance is used to monitor the status of this
         /// operation. This cannot be canceled or reverted once submitted. </para>
         /// </summary>
         /// 
         /// <param name="deleteDBInstanceRequest">Container for the necessary
         ///           parameters to execute the DeleteDBInstance service method on
         ///           AmazonRDS.</param>
         /// 
         /// <returns>The response from the DeleteDBInstance service method, as
         ///         returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="DBInstanceNotFoundException"/>
         /// <exception cref="InvalidDBInstanceStateException"/>
         /// <exception cref="SnapshotQuotaExceededException"/>
         /// <exception cref="DBSnapshotAlreadyExistsException"/>
        DeleteDBInstanceResponse DeleteDBInstance(DeleteDBInstanceRequest deleteDBInstanceRequest); 

         /// <summary>
         /// <para> This API returns a list of DBSecurityGroup descriptions. If a
         /// DBSecurityGroupName is specified, the list will contain only the
         /// descriptions of the specified DBSecurityGroup. </para>
         /// </summary>
         /// 
         /// <param name="describeDBSecurityGroupsRequest">Container for the
         ///           necessary parameters to execute the DescribeDBSecurityGroups service
         ///           method on AmazonRDS.</param>
         /// 
         /// <returns>The response from the DescribeDBSecurityGroups service
         ///         method, as returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="DBSecurityGroupNotFoundException"/>
        DescribeDBSecurityGroupsResponse DescribeDBSecurityGroups(DescribeDBSecurityGroupsRequest describeDBSecurityGroupsRequest); 

         /// <summary>
         /// <para> This API creates a new DB instance. </para>
         /// </summary>
         /// 
         /// <param name="createDBInstanceRequest">Container for the necessary
         ///           parameters to execute the CreateDBInstance service method on
         ///           AmazonRDS.</param>
         /// 
         /// <returns>The response from the CreateDBInstance service method, as
         ///         returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="DBParameterGroupNotFoundException"/>
         /// <exception cref="InstanceQuotaExceededException"/>
         /// <exception cref="DBInstanceAlreadyExistsException"/>
         /// <exception cref="StorageQuotaExceededException"/>
         /// <exception cref="DBSecurityGroupNotFoundException"/>
         /// <exception cref="InsufficientDBInstanceCapacityException"/>
        CreateDBInstanceResponse CreateDBInstance(CreateDBInstanceRequest createDBInstanceRequest); 

         /// <summary>
         /// <para> This API modifies the parameters of a DBParameterGroup to the
         /// engine/system default value. To reset specific parameters submit a
         /// list of the following: ParameterName and ApplyMethod. To reset the
         /// entire DBParameterGroup specify the DBParameterGroup name and
         /// ResetAllParameters parameters. When resetting the entire group,
         /// dynamic parameters are updated immediately and static parameters are
         /// set to pending-reboot to take effect on the next MySQL reboot or
         /// RebootDBInstance request. </para>
         /// </summary>
         /// 
         /// <param name="resetDBParameterGroupRequest">Container for the necessary
         ///           parameters to execute the ResetDBParameterGroup service method on
         ///           AmazonRDS.</param>
         /// 
         /// <returns>The response from the ResetDBParameterGroup service method,
         ///         as returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="DBParameterGroupNotFoundException"/>
         /// <exception cref="InvalidDBParameterGroupStateException"/>
        ResetDBParameterGroupResponse ResetDBParameterGroup(ResetDBParameterGroupRequest resetDBParameterGroupRequest); 

         /// <summary>
         /// <para> This API is used to change RDS Instance settings. Users call
         /// the ModifyDBInstance API to change one or more database configuration
         /// parameters by specifying these parameters and the new values in the
         /// request. </para>
         /// </summary>
         /// 
         /// <param name="modifyDBInstanceRequest">Container for the necessary
         ///           parameters to execute the ModifyDBInstance service method on
         ///           AmazonRDS.</param>
         /// 
         /// <returns>The response from the ModifyDBInstance service method, as
         ///         returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="DBParameterGroupNotFoundException"/>
         /// <exception cref="DBInstanceNotFoundException"/>
         /// <exception cref="InvalidDBInstanceStateException"/>
         /// <exception cref="DBSecurityGroupNotFoundException"/>
         /// <exception cref="InvalidDBSecurityGroupStateException"/>
         /// <exception cref="InsufficientDBInstanceCapacityException"/>
        ModifyDBInstanceResponse ModifyDBInstance(ModifyDBInstanceRequest modifyDBInstanceRequest); 

         /// <summary>
         /// <para> This API creates a new DB Instance to an arbitrary
         /// point-in-time. Users can restore to any point in time before the
         /// latestRestorableTime for up to backupRetentionPeriod days. The target
         /// database is created from the source database with the same
         /// configuration as the original database except that the DB instance is
         /// created with the default DB security group. </para>
         /// </summary>
         /// 
         /// <param name="restoreDBInstanceFromDBSnapshotRequest">Container for the
         ///           necessary parameters to execute the RestoreDBInstanceFromDBSnapshot
         ///           service method on AmazonRDS.</param>
         /// 
         /// <returns>The response from the RestoreDBInstanceFromDBSnapshot service
         ///         method, as returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="InstanceQuotaExceededException"/>
         /// <exception cref="DBInstanceAlreadyExistsException"/>
         /// <exception cref="StorageQuotaExceededException"/>
         /// <exception cref="InvalidDBSnapshotStateException"/>
         /// <exception cref="InsufficientDBInstanceCapacityException"/>
         /// <exception cref="DBSnapshotNotFoundException"/>
        RestoreDBInstanceFromDBSnapshotResponse RestoreDBInstanceFromDBSnapshot(RestoreDBInstanceFromDBSnapshotRequest restoreDBInstanceFromDBSnapshotRequest); 

         /// <summary>
         /// </summary>
         /// 
         /// <param name="describeReservedDBInstancesRequest">Container for the
         ///           necessary parameters to execute the DescribeReservedDBInstances
         ///           service method on AmazonRDS.</param>
         /// 
         /// <returns>The response from the DescribeReservedDBInstances service
         ///         method, as returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="ReservedDBInstanceNotFoundException"/>
        DescribeReservedDBInstancesResponse DescribeReservedDBInstances(DescribeReservedDBInstancesRequest describeReservedDBInstancesRequest); 

         /// <summary>
         /// <para> This API creates a new database parameter group. </para>
         /// </summary>
         /// 
         /// <param name="createDBParameterGroupRequest">Container for the
         ///           necessary parameters to execute the CreateDBParameterGroup service
         ///           method on AmazonRDS.</param>
         /// 
         /// <returns>The response from the CreateDBParameterGroup service method,
         ///         as returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="DBParameterGroupQuotaExceededException"/>
         /// <exception cref="DBParameterGroupAlreadyExistsException"/>
        CreateDBParameterGroupResponse CreateDBParameterGroup(CreateDBParameterGroupRequest createDBParameterGroupRequest); 

         /// <summary>
         /// <para> This API deletes a database security group. Database security
         /// group must not be associated with any RDS Instances. </para>
         /// </summary>
         /// 
         /// <param name="deleteDBSecurityGroupRequest">Container for the necessary
         ///           parameters to execute the DeleteDBSecurityGroup service method on
         ///           AmazonRDS.</param>
         /// 
         /// <exception cref="DBSecurityGroupNotFoundException"/>
         /// <exception cref="InvalidDBSecurityGroupStateException"/>
        DeleteDBSecurityGroupResponse DeleteDBSecurityGroup(DeleteDBSecurityGroupRequest deleteDBSecurityGroupRequest); 

         /// <summary>
         /// </summary>
         /// 
         /// <param name="createDBInstanceReadReplicaRequest">Container for the
         ///           necessary parameters to execute the CreateDBInstanceReadReplica
         ///           service method on AmazonRDS.</param>
         /// 
         /// <returns>The response from the CreateDBInstanceReadReplica service
         ///         method, as returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="DBParameterGroupNotFoundException"/>
         /// <exception cref="InstanceQuotaExceededException"/>
         /// <exception cref="DBInstanceAlreadyExistsException"/>
         /// <exception cref="DBInstanceNotFoundException"/>
         /// <exception cref="StorageQuotaExceededException"/>
         /// <exception cref="InvalidDBInstanceStateException"/>
         /// <exception cref="DBSecurityGroupNotFoundException"/>
         /// <exception cref="InsufficientDBInstanceCapacityException"/>
        CreateDBInstanceReadReplicaResponse CreateDBInstanceReadReplica(CreateDBInstanceReadReplicaRequest createDBInstanceReadReplicaRequest); 

         /// <summary>
         /// </summary>
         /// 
         /// <param name="purchaseReservedDBInstancesOfferingRequest">Container for
         ///           the necessary parameters to execute the
         ///           PurchaseReservedDBInstancesOffering service method on
         ///           AmazonRDS.</param>
         /// 
         /// <returns>The response from the PurchaseReservedDBInstancesOffering
         ///         service method, as returned by AmazonRDS.</returns>
         /// 
         /// <exception cref="ReservedDBInstancesOfferingNotFoundException"/>
         /// <exception cref="ReservedDBInstanceQuotaExceededException"/>
         /// <exception cref="ReservedDBInstanceAlreadyExistsException"/>
        PurchaseReservedDBInstancesOfferingResponse PurchaseReservedDBInstancesOffering(PurchaseReservedDBInstancesOfferingRequest purchaseReservedDBInstancesOfferingRequest); 
    }
}
    
