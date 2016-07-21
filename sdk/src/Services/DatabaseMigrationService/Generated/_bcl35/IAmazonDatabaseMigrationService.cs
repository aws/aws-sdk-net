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

/*
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.DatabaseMigrationService.Model;

namespace Amazon.DatabaseMigrationService
{
    /// <summary>
    /// Interface for accessing DatabaseMigrationService
    ///
    /// AWS Database Migration Service 
    /// <para>
    /// AWS Database Migration Service (AWS DMS) can migrate your data to and from the most
    /// widely used commercial and open-source databases such as Oracle, PostgreSQL, Microsoft
    /// SQL Server, Amazon Redshift, MariaDB, Amazon Aurora, and MySQL. The service supports
    /// homogeneous migrations such as Oracle to Oracle, as well as heterogeneous migrations
    /// between different database platforms, such as Oracle to MySQL or SQL Server to PostgreSQL.
    /// </para>
    /// </summary>
    public partial interface IAmazonDatabaseMigrationService : IDisposable
    {

        
        #region  AddTagsToResource


        /// <summary>
        /// Adds metadata tags to a DMS resource, including replication instance, endpoint, security
        /// group, and migration task. These tags can also be used with cost allocation reporting
        /// to track cost associated with DMS resources, or used in a Condition statement in an
        /// IAM policy for DMS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource service method.</param>
        /// 
        /// <returns>The response from the AddTagsToResource service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTagsToResource
        ///         operation.</returns>
        IAsyncResult BeginAddTagsToResource(AddTagsToResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTagsToResource.</param>
        /// 
        /// <returns>Returns a  AddTagsToResourceResult from DatabaseMigrationService.</returns>
        AddTagsToResourceResponse EndAddTagsToResource(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEndpoint


        /// <summary>
        /// Creates an endpoint using the provided settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateEndpoint service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// AWS DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEndpoint
        ///         operation.</returns>
        IAsyncResult BeginCreateEndpoint(CreateEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateEndpointResult from DatabaseMigrationService.</returns>
        CreateEndpointResponse EndCreateEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateReplicationInstance


        /// <summary>
        /// Creates the replication instance using the specified parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationInstance service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationInstance service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// AWS DMS was denied access to the endpoint.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InsufficientResourceCapacityException">
        /// There are not enough resources allocated to the database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidSubnetException">
        /// The subnet provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// AWS DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ReplicationSubnetGroupDoesNotCoverEnoughAZsException">
        /// The replication subnet group does not cover enough Availability Zones (AZs). Edit
        /// the replication subnet group and add more AZs.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.StorageQuotaExceededException">
        /// The storage quota has been exceeded.
        /// </exception>
        CreateReplicationInstanceResponse CreateReplicationInstance(CreateReplicationInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationInstance operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReplicationInstance
        ///         operation.</returns>
        IAsyncResult BeginCreateReplicationInstance(CreateReplicationInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReplicationInstance.</param>
        /// 
        /// <returns>Returns a  CreateReplicationInstanceResult from DatabaseMigrationService.</returns>
        CreateReplicationInstanceResponse EndCreateReplicationInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateReplicationSubnetGroup


        /// <summary>
        /// Creates a replication subnet group given a list of the subnet IDs in a VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationSubnetGroup service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// AWS DMS was denied access to the endpoint.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidSubnetException">
        /// The subnet provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ReplicationSubnetGroupDoesNotCoverEnoughAZsException">
        /// The replication subnet group does not cover enough Availability Zones (AZs). Edit
        /// the replication subnet group and add more AZs.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        CreateReplicationSubnetGroupResponse CreateReplicationSubnetGroup(CreateReplicationSubnetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationSubnetGroup operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReplicationSubnetGroup
        ///         operation.</returns>
        IAsyncResult BeginCreateReplicationSubnetGroup(CreateReplicationSubnetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReplicationSubnetGroup.</param>
        /// 
        /// <returns>Returns a  CreateReplicationSubnetGroupResult from DatabaseMigrationService.</returns>
        CreateReplicationSubnetGroupResponse EndCreateReplicationSubnetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateReplicationTask


        /// <summary>
        /// Creates a replication task using the specified parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationTask service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationTask service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// AWS DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        CreateReplicationTaskResponse CreateReplicationTask(CreateReplicationTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationTask operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReplicationTask
        ///         operation.</returns>
        IAsyncResult BeginCreateReplicationTask(CreateReplicationTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReplicationTask.</param>
        /// 
        /// <returns>Returns a  CreateReplicationTaskResult from DatabaseMigrationService.</returns>
        CreateReplicationTaskResponse EndCreateReplicationTask(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCertificate


        /// <summary>
        /// Deletes the specified certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCertificate
        ///         operation.</returns>
        IAsyncResult BeginDeleteCertificate(DeleteCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteCertificateResult from DatabaseMigrationService.</returns>
        DeleteCertificateResponse EndDeleteCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEndpoint


        /// <summary>
        /// Deletes the specified endpoint.
        /// 
        ///  <note> 
        /// <para>
        /// All tasks associated with the endpoint must be deleted before you can delete the endpoint.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEndpoint
        ///         operation.</returns>
        IAsyncResult BeginDeleteEndpoint(DeleteEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointResult from DatabaseMigrationService.</returns>
        DeleteEndpointResponse EndDeleteEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteReplicationInstance


        /// <summary>
        /// Deletes the specified replication instance.
        /// 
        ///  <note> 
        /// <para>
        /// You must delete any migration tasks that are associated with the replication instance
        /// before you can delete it.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationInstance service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        DeleteReplicationInstanceResponse DeleteReplicationInstance(DeleteReplicationInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationInstance operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReplicationInstance
        ///         operation.</returns>
        IAsyncResult BeginDeleteReplicationInstance(DeleteReplicationInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReplicationInstance.</param>
        /// 
        /// <returns>Returns a  DeleteReplicationInstanceResult from DatabaseMigrationService.</returns>
        DeleteReplicationInstanceResponse EndDeleteReplicationInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteReplicationSubnetGroup


        /// <summary>
        /// Deletes a subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationSubnetGroup service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        DeleteReplicationSubnetGroupResponse DeleteReplicationSubnetGroup(DeleteReplicationSubnetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationSubnetGroup operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReplicationSubnetGroup
        ///         operation.</returns>
        IAsyncResult BeginDeleteReplicationSubnetGroup(DeleteReplicationSubnetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReplicationSubnetGroup.</param>
        /// 
        /// <returns>Returns a  DeleteReplicationSubnetGroupResult from DatabaseMigrationService.</returns>
        DeleteReplicationSubnetGroupResponse EndDeleteReplicationSubnetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteReplicationTask


        /// <summary>
        /// Deletes the specified replication task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationTask service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationTask service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        DeleteReplicationTaskResponse DeleteReplicationTask(DeleteReplicationTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationTask operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReplicationTask
        ///         operation.</returns>
        IAsyncResult BeginDeleteReplicationTask(DeleteReplicationTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReplicationTask.</param>
        /// 
        /// <returns>Returns a  DeleteReplicationTaskResult from DatabaseMigrationService.</returns>
        DeleteReplicationTaskResponse EndDeleteReplicationTask(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAccountAttributes


        /// <summary>
        /// Lists all of the AWS DMS attributes for a customer account. The attributes include
        /// AWS DMS quotas for the account, such as the number of replication instances allowed.
        /// The description for a quota includes the quota name, current usage toward that quota,
        /// and the quota's maximum value.
        /// 
        ///  
        /// <para>
        /// This command does not take any parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by DatabaseMigrationService.</returns>
        DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountAttributes
        ///         operation.</returns>
        IAsyncResult BeginDescribeAccountAttributes(DescribeAccountAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeAccountAttributesResult from DatabaseMigrationService.</returns>
        DescribeAccountAttributesResponse EndDescribeAccountAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCertificates


        /// <summary>
        /// Provides a description of the certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificates service method.</param>
        /// 
        /// <returns>The response from the DescribeCertificates service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        DescribeCertificatesResponse DescribeCertificates(DescribeCertificatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificates operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCertificates
        ///         operation.</returns>
        IAsyncResult BeginDescribeCertificates(DescribeCertificatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCertificates.</param>
        /// 
        /// <returns>Returns a  DescribeCertificatesResult from DatabaseMigrationService.</returns>
        DescribeCertificatesResponse EndDescribeCertificates(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeConnections


        /// <summary>
        /// Describes the status of the connections that have been made between the replication
        /// instance and an endpoint. Connections are created when you test an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        DescribeConnectionsResponse DescribeConnections(DescribeConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConnections
        ///         operation.</returns>
        IAsyncResult BeginDescribeConnections(DescribeConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnections.</param>
        /// 
        /// <returns>Returns a  DescribeConnectionsResult from DatabaseMigrationService.</returns>
        DescribeConnectionsResponse EndDescribeConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEndpoints


        /// <summary>
        /// Returns information about the endpoints for your account in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpoints service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        DescribeEndpointsResponse DescribeEndpoints(DescribeEndpointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEndpoints
        ///         operation.</returns>
        IAsyncResult BeginDescribeEndpoints(DescribeEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpoints.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointsResult from DatabaseMigrationService.</returns>
        DescribeEndpointsResponse EndDescribeEndpoints(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEndpointTypes


        /// <summary>
        /// Returns information about the type of endpoints available.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpointTypes service method, as returned by DatabaseMigrationService.</returns>
        DescribeEndpointTypesResponse DescribeEndpointTypes(DescribeEndpointTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpointTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointTypes operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEndpointTypes
        ///         operation.</returns>
        IAsyncResult BeginDescribeEndpointTypes(DescribeEndpointTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpointTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpointTypes.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointTypesResult from DatabaseMigrationService.</returns>
        DescribeEndpointTypesResponse EndDescribeEndpointTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeOrderableReplicationInstances


        /// <summary>
        /// Returns information about the replication instance types that can be created in the
        /// specified region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableReplicationInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeOrderableReplicationInstances service method, as returned by DatabaseMigrationService.</returns>
        DescribeOrderableReplicationInstancesResponse DescribeOrderableReplicationInstances(DescribeOrderableReplicationInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableReplicationInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableReplicationInstances operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOrderableReplicationInstances
        ///         operation.</returns>
        IAsyncResult BeginDescribeOrderableReplicationInstances(DescribeOrderableReplicationInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOrderableReplicationInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOrderableReplicationInstances.</param>
        /// 
        /// <returns>Returns a  DescribeOrderableReplicationInstancesResult from DatabaseMigrationService.</returns>
        DescribeOrderableReplicationInstancesResponse EndDescribeOrderableReplicationInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRefreshSchemasStatus


        /// <summary>
        /// Returns the status of the RefreshSchemas operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRefreshSchemasStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeRefreshSchemasStatus service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        DescribeRefreshSchemasStatusResponse DescribeRefreshSchemasStatus(DescribeRefreshSchemasStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRefreshSchemasStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRefreshSchemasStatus operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRefreshSchemasStatus
        ///         operation.</returns>
        IAsyncResult BeginDescribeRefreshSchemasStatus(DescribeRefreshSchemasStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRefreshSchemasStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRefreshSchemasStatus.</param>
        /// 
        /// <returns>Returns a  DescribeRefreshSchemasStatusResult from DatabaseMigrationService.</returns>
        DescribeRefreshSchemasStatusResponse EndDescribeRefreshSchemasStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReplicationInstances


        /// <summary>
        /// Returns information about replication instances for your account in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationInstances service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        DescribeReplicationInstancesResponse DescribeReplicationInstances(DescribeReplicationInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationInstances operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReplicationInstances
        ///         operation.</returns>
        IAsyncResult BeginDescribeReplicationInstances(DescribeReplicationInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplicationInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplicationInstances.</param>
        /// 
        /// <returns>Returns a  DescribeReplicationInstancesResult from DatabaseMigrationService.</returns>
        DescribeReplicationInstancesResponse EndDescribeReplicationInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReplicationSubnetGroups


        /// <summary>
        /// Returns information about the replication subnet groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationSubnetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationSubnetGroups service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        DescribeReplicationSubnetGroupsResponse DescribeReplicationSubnetGroups(DescribeReplicationSubnetGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationSubnetGroups operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReplicationSubnetGroups
        ///         operation.</returns>
        IAsyncResult BeginDescribeReplicationSubnetGroups(DescribeReplicationSubnetGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplicationSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplicationSubnetGroups.</param>
        /// 
        /// <returns>Returns a  DescribeReplicationSubnetGroupsResult from DatabaseMigrationService.</returns>
        DescribeReplicationSubnetGroupsResponse EndDescribeReplicationSubnetGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReplicationTasks


        /// <summary>
        /// Returns information about replication tasks for your account in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationTasks service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        DescribeReplicationTasksResponse DescribeReplicationTasks(DescribeReplicationTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTasks operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReplicationTasks
        ///         operation.</returns>
        IAsyncResult BeginDescribeReplicationTasks(DescribeReplicationTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplicationTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplicationTasks.</param>
        /// 
        /// <returns>Returns a  DescribeReplicationTasksResult from DatabaseMigrationService.</returns>
        DescribeReplicationTasksResponse EndDescribeReplicationTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSchemas


        /// <summary>
        /// Returns information about the schema for the specified endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchemas service method.</param>
        /// 
        /// <returns>The response from the DescribeSchemas service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        DescribeSchemasResponse DescribeSchemas(DescribeSchemasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchemas operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSchemas
        ///         operation.</returns>
        IAsyncResult BeginDescribeSchemas(DescribeSchemasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSchemas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSchemas.</param>
        /// 
        /// <returns>Returns a  DescribeSchemasResult from DatabaseMigrationService.</returns>
        DescribeSchemasResponse EndDescribeSchemas(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTableStatistics


        /// <summary>
        /// Returns table statistics on the database migration task, including table name, rows
        /// inserted, rows updated, and rows deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableStatistics service method.</param>
        /// 
        /// <returns>The response from the DescribeTableStatistics service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        DescribeTableStatisticsResponse DescribeTableStatistics(DescribeTableStatisticsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTableStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableStatistics operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTableStatistics
        ///         operation.</returns>
        IAsyncResult BeginDescribeTableStatistics(DescribeTableStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTableStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTableStatistics.</param>
        /// 
        /// <returns>Returns a  DescribeTableStatisticsResult from DatabaseMigrationService.</returns>
        DescribeTableStatisticsResponse EndDescribeTableStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportCertificate


        /// <summary>
        /// Uploads the specified certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate service method.</param>
        /// 
        /// <returns>The response from the ImportCertificate service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidCertificateException">
        /// The certificate was not valid.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        ImportCertificateResponse ImportCertificate(ImportCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportCertificate
        ///         operation.</returns>
        IAsyncResult BeginImportCertificate(ImportCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportCertificate.</param>
        /// 
        /// <returns>Returns a  ImportCertificateResult from DatabaseMigrationService.</returns>
        ImportCertificateResponse EndImportCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags for an AWS DMS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from DatabaseMigrationService.</returns>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyEndpoint


        /// <summary>
        /// Modifies the specified endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEndpoint service method.</param>
        /// 
        /// <returns>The response from the ModifyEndpoint service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// AWS DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        ModifyEndpointResponse ModifyEndpoint(ModifyEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEndpoint operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyEndpoint
        ///         operation.</returns>
        IAsyncResult BeginModifyEndpoint(ModifyEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyEndpoint.</param>
        /// 
        /// <returns>Returns a  ModifyEndpointResult from DatabaseMigrationService.</returns>
        ModifyEndpointResponse EndModifyEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyReplicationInstance


        /// <summary>
        /// Modifies the replication instance to apply new settings. You can change one or more
        /// parameters by specifying these parameters and the new values in the request.
        /// 
        ///  
        /// <para>
        /// Some settings are applied during the maintenance window.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationInstance service method.</param>
        /// 
        /// <returns>The response from the ModifyReplicationInstance service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InsufficientResourceCapacityException">
        /// There are not enough resources allocated to the database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceAlreadyExistsException">
        /// The resource you are attempting to create already exists.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.StorageQuotaExceededException">
        /// The storage quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.UpgradeDependencyFailureException">
        /// An upgrade dependency is preventing the database migration.
        /// </exception>
        ModifyReplicationInstanceResponse ModifyReplicationInstance(ModifyReplicationInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationInstance operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyReplicationInstance
        ///         operation.</returns>
        IAsyncResult BeginModifyReplicationInstance(ModifyReplicationInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyReplicationInstance.</param>
        /// 
        /// <returns>Returns a  ModifyReplicationInstanceResult from DatabaseMigrationService.</returns>
        ModifyReplicationInstanceResponse EndModifyReplicationInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyReplicationSubnetGroup


        /// <summary>
        /// Modifies the settings for the specified replication subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyReplicationSubnetGroup service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.AccessDeniedException">
        /// AWS DMS was denied access to the endpoint.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidSubnetException">
        /// The subnet provided is invalid.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ReplicationSubnetGroupDoesNotCoverEnoughAZsException">
        /// The replication subnet group does not cover enough Availability Zones (AZs). Edit
        /// the replication subnet group and add more AZs.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.SubnetAlreadyInUseException">
        /// The specified subnet is already in use.
        /// </exception>
        ModifyReplicationSubnetGroupResponse ModifyReplicationSubnetGroup(ModifyReplicationSubnetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationSubnetGroup operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyReplicationSubnetGroup
        ///         operation.</returns>
        IAsyncResult BeginModifyReplicationSubnetGroup(ModifyReplicationSubnetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyReplicationSubnetGroup.</param>
        /// 
        /// <returns>Returns a  ModifyReplicationSubnetGroupResult from DatabaseMigrationService.</returns>
        ModifyReplicationSubnetGroupResponse EndModifyReplicationSubnetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  RefreshSchemas


        /// <summary>
        /// Populates the schema for the specified endpoint. This is an asynchronous operation
        /// and can take several minutes. You can check the status of this operation by calling
        /// the DescribeRefreshSchemasStatus operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RefreshSchemas service method.</param>
        /// 
        /// <returns>The response from the RefreshSchemas service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// AWS DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        RefreshSchemasResponse RefreshSchemas(RefreshSchemasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RefreshSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RefreshSchemas operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRefreshSchemas
        ///         operation.</returns>
        IAsyncResult BeginRefreshSchemas(RefreshSchemasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RefreshSchemas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRefreshSchemas.</param>
        /// 
        /// <returns>Returns a  RefreshSchemasResult from DatabaseMigrationService.</returns>
        RefreshSchemasResponse EndRefreshSchemas(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveTagsFromResource


        /// <summary>
        /// Removes metadata tags from a DMS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromResource service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTagsFromResource
        ///         operation.</returns>
        IAsyncResult BeginRemoveTagsFromResource(RemoveTagsFromResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTagsFromResource.</param>
        /// 
        /// <returns>Returns a  RemoveTagsFromResourceResult from DatabaseMigrationService.</returns>
        RemoveTagsFromResourceResponse EndRemoveTagsFromResource(IAsyncResult asyncResult);

        #endregion
        
        #region  StartReplicationTask


        /// <summary>
        /// Starts the replication task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReplicationTask service method.</param>
        /// 
        /// <returns>The response from the StartReplicationTask service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        StartReplicationTaskResponse StartReplicationTask(StartReplicationTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReplicationTask operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartReplicationTask
        ///         operation.</returns>
        IAsyncResult BeginStartReplicationTask(StartReplicationTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartReplicationTask.</param>
        /// 
        /// <returns>Returns a  StartReplicationTaskResult from DatabaseMigrationService.</returns>
        StartReplicationTaskResponse EndStartReplicationTask(IAsyncResult asyncResult);

        #endregion
        
        #region  StopReplicationTask


        /// <summary>
        /// Stops the replication task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopReplicationTask service method.</param>
        /// 
        /// <returns>The response from the StopReplicationTask service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        StopReplicationTaskResponse StopReplicationTask(StopReplicationTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopReplicationTask operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopReplicationTask
        ///         operation.</returns>
        IAsyncResult BeginStopReplicationTask(StopReplicationTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopReplicationTask.</param>
        /// 
        /// <returns>Returns a  StopReplicationTaskResult from DatabaseMigrationService.</returns>
        StopReplicationTaskResponse EndStopReplicationTask(IAsyncResult asyncResult);

        #endregion
        
        #region  TestConnection


        /// <summary>
        /// Tests the connection between the replication instance and the endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestConnection service method.</param>
        /// 
        /// <returns>The response from the TestConnection service method, as returned by DatabaseMigrationService.</returns>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.InvalidResourceStateException">
        /// The resource is in a state that prevents it from being used for database migration.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.KMSKeyNotAccessibleException">
        /// AWS DMS cannot access the KMS key.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DatabaseMigrationService.Model.ResourceQuotaExceededException">
        /// The quota for this resource quota has been exceeded.
        /// </exception>
        TestConnectionResponse TestConnection(TestConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TestConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestConnection operation on AmazonDatabaseMigrationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestConnection
        ///         operation.</returns>
        IAsyncResult BeginTestConnection(TestConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestConnection.</param>
        /// 
        /// <returns>Returns a  TestConnectionResult from DatabaseMigrationService.</returns>
        TestConnectionResponse EndTestConnection(IAsyncResult asyncResult);

        #endregion
        
    }
}