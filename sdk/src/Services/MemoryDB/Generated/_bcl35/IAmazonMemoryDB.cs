/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MemoryDB.Model;

namespace Amazon.MemoryDB
{
    /// <summary>
    /// Interface for accessing MemoryDB
    ///
    /// MemoryDB for Redis is a fully managed, Redis-compatible, in-memory database that delivers
    /// ultra-fast performance and Multi-AZ durability for modern applications built using
    /// microservices architectures. MemoryDB stores the entire database in-memory, enabling
    /// low latency and high throughput data access. It is compatible with Redis, a popular
    /// open source data store, enabling you to leverage Redis’ flexible and friendly data
    /// structures, APIs, and commands.
    /// </summary>
    public partial interface IAmazonMemoryDB : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMemoryDBPaginatorFactory Paginators { get; }
#endif


        
        #region  BatchUpdateCluster


        /// <summary>
        /// Apply the service update to a list of clusters supplied. For more information on service
        /// updates and applying them, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/managing-updates.html#applying-updates">Applying
        /// the service updates</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateCluster service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateCluster service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceUpdateNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/BatchUpdateCluster">REST API Reference for BatchUpdateCluster Operation</seealso>
        BatchUpdateClusterResponse BatchUpdateCluster(BatchUpdateClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateCluster operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/BatchUpdateCluster">REST API Reference for BatchUpdateCluster Operation</seealso>
        IAsyncResult BeginBatchUpdateCluster(BatchUpdateClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateCluster.</param>
        /// 
        /// <returns>Returns a  BatchUpdateClusterResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/BatchUpdateCluster">REST API Reference for BatchUpdateCluster Operation</seealso>
        BatchUpdateClusterResponse EndBatchUpdateCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  CopySnapshot


        /// <summary>
        /// Makes a copy of an existing snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot service method.</param>
        /// 
        /// <returns>The response from the CopySnapshot service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidSnapshotStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TagQuotaPerResourceExceededException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CopySnapshot">REST API Reference for CopySnapshot Operation</seealso>
        CopySnapshotResponse CopySnapshot(CopySnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CopySnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopySnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CopySnapshot">REST API Reference for CopySnapshot Operation</seealso>
        IAsyncResult BeginCopySnapshot(CopySnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CopySnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopySnapshot.</param>
        /// 
        /// <returns>Returns a  CopySnapshotResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CopySnapshot">REST API Reference for CopySnapshot Operation</seealso>
        CopySnapshotResponse EndCopySnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateACL


        /// <summary>
        /// Creates an Access Control List. For more information, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/clusters.acls.html">Authenticating
        /// users with Access Contol Lists (ACLs)</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateACL service method.</param>
        /// 
        /// <returns>The response from the CreateACL service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ACLAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ACLQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.DefaultUserRequiredException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.DuplicateUserNameException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TagQuotaPerResourceExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.UserNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateACL">REST API Reference for CreateACL Operation</seealso>
        CreateACLResponse CreateACL(CreateACLRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateACL operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateACL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateACL">REST API Reference for CreateACL Operation</seealso>
        IAsyncResult BeginCreateACL(CreateACLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateACL.</param>
        /// 
        /// <returns>Returns a  CreateACLResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateACL">REST API Reference for CreateACL Operation</seealso>
        CreateACLResponse EndCreateACL(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCluster


        /// <summary>
        /// Creates a cluster. All nodes in the cluster run the same protocol-compliant engine
        /// software.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ACLNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterQuotaForCustomerExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InsufficientClusterCapacityException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidACLStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidCredentialsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidVPCNetworkStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.NodeQuotaForClusterExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.NodeQuotaForCustomerExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ShardsPerClusterQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TagQuotaPerResourceExceededException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        CreateClusterResponse CreateCluster(CreateClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        IAsyncResult BeginCreateCluster(CreateClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCluster.</param>
        /// 
        /// <returns>Returns a  CreateClusterResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        CreateClusterResponse EndCreateCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateParameterGroup


        /// <summary>
        /// Creates a new MemoryDB parameter group. A parameter group is a collection of parameters
        /// and their values that are applied to all of the nodes in any cluster. For more information,
        /// see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/parametergroups.html">Configuring
        /// engine parameters using parameter groups</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CreateParameterGroup service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterGroupStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TagQuotaPerResourceExceededException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateParameterGroup">REST API Reference for CreateParameterGroup Operation</seealso>
        CreateParameterGroupResponse CreateParameterGroup(CreateParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateParameterGroup operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateParameterGroup">REST API Reference for CreateParameterGroup Operation</seealso>
        IAsyncResult BeginCreateParameterGroup(CreateParameterGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateParameterGroup.</param>
        /// 
        /// <returns>Returns a  CreateParameterGroupResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateParameterGroup">REST API Reference for CreateParameterGroup Operation</seealso>
        CreateParameterGroupResponse EndCreateParameterGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSnapshot


        /// <summary>
        /// Creates a copy of an entire cluster at a specific moment in time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidClusterStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TagQuotaPerResourceExceededException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        IAsyncResult BeginCreateSnapshot(CreateSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateSnapshotResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        CreateSnapshotResponse EndCreateSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSubnetGroup


        /// <summary>
        /// Creates a subnet group. A subnet group is a collection of subnets (typically private)
        /// that you can designate for your clusters running in an Amazon Virtual Private Cloud
        /// (VPC) environment. When you create a cluster in an Amazon VPC, you must specify a
        /// subnet group. MemoryDB uses that subnet group to choose a subnet and IP addresses
        /// within that subnet to associate with your nodes. For more information, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/subnetgroups.html">Subnets
        /// and subnet groups</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateSubnetGroup service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidSubnetException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetGroupAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetGroupQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetNotAllowedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TagQuotaPerResourceExceededException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateSubnetGroup">REST API Reference for CreateSubnetGroup Operation</seealso>
        CreateSubnetGroupResponse CreateSubnetGroup(CreateSubnetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnetGroup operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubnetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateSubnetGroup">REST API Reference for CreateSubnetGroup Operation</seealso>
        IAsyncResult BeginCreateSubnetGroup(CreateSubnetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubnetGroup.</param>
        /// 
        /// <returns>Returns a  CreateSubnetGroupResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateSubnetGroup">REST API Reference for CreateSubnetGroup Operation</seealso>
        CreateSubnetGroupResponse EndCreateSubnetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUser


        /// <summary>
        /// Creates a MemoryDB user. For more information, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/clusters.acls.html">Authenticating
        /// users with Access Contol Lists (ACLs)</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.DuplicateUserNameException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TagQuotaPerResourceExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.UserAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.UserQuotaExceededException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        CreateUserResponse CreateUser(CreateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        IAsyncResult BeginCreateUser(CreateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUser.</param>
        /// 
        /// <returns>Returns a  CreateUserResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        CreateUserResponse EndCreateUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteACL


        /// <summary>
        /// Deletes an Access Control List. The ACL must first be disassociated from the cluster
        /// before it can be deleted. For more information, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/clusters.acls.html">Authenticating
        /// users with Access Contol Lists (ACLs)</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteACL service method.</param>
        /// 
        /// <returns>The response from the DeleteACL service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ACLNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidACLStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteACL">REST API Reference for DeleteACL Operation</seealso>
        DeleteACLResponse DeleteACL(DeleteACLRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteACL operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteACL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteACL">REST API Reference for DeleteACL Operation</seealso>
        IAsyncResult BeginDeleteACL(DeleteACLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteACL.</param>
        /// 
        /// <returns>Returns a  DeleteACLResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteACL">REST API Reference for DeleteACL Operation</seealso>
        DeleteACLResponse EndDeleteACL(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCluster


        /// <summary>
        /// Deletes a cluster. It also deletes all associated nodes and node endpoints
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidClusterStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotAlreadyExistsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        DeleteClusterResponse DeleteCluster(DeleteClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        IAsyncResult BeginDeleteCluster(DeleteClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCluster.</param>
        /// 
        /// <returns>Returns a  DeleteClusterResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        DeleteClusterResponse EndDeleteCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteParameterGroup


        /// <summary>
        /// Deletes the specified parameter group. You cannot delete a parameter group if it is
        /// associated with any clusters. You cannot delete the default parameter groups in your
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteParameterGroup service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterGroupStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteParameterGroup">REST API Reference for DeleteParameterGroup Operation</seealso>
        DeleteParameterGroupResponse DeleteParameterGroup(DeleteParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameterGroup operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteParameterGroup">REST API Reference for DeleteParameterGroup Operation</seealso>
        IAsyncResult BeginDeleteParameterGroup(DeleteParameterGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteParameterGroup.</param>
        /// 
        /// <returns>Returns a  DeleteParameterGroupResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteParameterGroup">REST API Reference for DeleteParameterGroup Operation</seealso>
        DeleteParameterGroupResponse EndDeleteParameterGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSnapshot


        /// <summary>
        /// Deletes an existing snapshot. When you receive a successful response from this operation,
        /// MemoryDB immediately begins deleting the snapshot; you cannot cancel or revert this
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteSnapshot service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidSnapshotStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        IAsyncResult BeginDeleteSnapshot(DeleteSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteSnapshotResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        DeleteSnapshotResponse EndDeleteSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSubnetGroup


        /// <summary>
        /// Deletes a subnet group. You cannot delete a default subnet group or one that is associated
        /// with any clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteSubnetGroup service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetGroupInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetGroupNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteSubnetGroup">REST API Reference for DeleteSubnetGroup Operation</seealso>
        DeleteSubnetGroupResponse DeleteSubnetGroup(DeleteSubnetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnetGroup operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSubnetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteSubnetGroup">REST API Reference for DeleteSubnetGroup Operation</seealso>
        IAsyncResult BeginDeleteSubnetGroup(DeleteSubnetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubnetGroup.</param>
        /// 
        /// <returns>Returns a  DeleteSubnetGroupResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteSubnetGroup">REST API Reference for DeleteSubnetGroup Operation</seealso>
        DeleteSubnetGroupResponse EndDeleteSubnetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Deletes a user. The user will be removed from all ACLs and in turn removed from all
        /// clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidUserStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.UserNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse DeleteUser(DeleteUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeACLs


        /// <summary>
        /// Returns a list of ACLs
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeACLs service method.</param>
        /// 
        /// <returns>The response from the DescribeACLs service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ACLNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeACLs">REST API Reference for DescribeACLs Operation</seealso>
        DescribeACLsResponse DescribeACLs(DescribeACLsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeACLs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeACLs operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeACLs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeACLs">REST API Reference for DescribeACLs Operation</seealso>
        IAsyncResult BeginDescribeACLs(DescribeACLsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeACLs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeACLs.</param>
        /// 
        /// <returns>Returns a  DescribeACLsResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeACLs">REST API Reference for DescribeACLs Operation</seealso>
        DescribeACLsResponse EndDescribeACLs(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeClusters


        /// <summary>
        /// Returns information about all provisioned clusters if no cluster identifier is specified,
        /// or about a specific cluster if a cluster name is supplied.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        DescribeClustersResponse DescribeClusters(DescribeClustersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        IAsyncResult BeginDescribeClusters(DescribeClustersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusters.</param>
        /// 
        /// <returns>Returns a  DescribeClustersResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        DescribeClustersResponse EndDescribeClusters(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEngineVersions


        /// <summary>
        /// Returns a list of the available Redis engine versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeEngineVersions service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeEngineVersions">REST API Reference for DescribeEngineVersions Operation</seealso>
        DescribeEngineVersionsResponse DescribeEngineVersions(DescribeEngineVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEngineVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEngineVersions operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEngineVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeEngineVersions">REST API Reference for DescribeEngineVersions Operation</seealso>
        IAsyncResult BeginDescribeEngineVersions(DescribeEngineVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEngineVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEngineVersions.</param>
        /// 
        /// <returns>Returns a  DescribeEngineVersionsResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeEngineVersions">REST API Reference for DescribeEngineVersions Operation</seealso>
        DescribeEngineVersionsResponse EndDescribeEngineVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEvents


        /// <summary>
        /// Returns events related to clusters, security groups, and parameter groups. You can
        /// obtain events specific to a particular cluster, security group, or parameter group
        /// by providing the name as a parameter. By default, only the events occurring within
        /// the last hour are returned; however, you can retrieve up to 14 days' worth of events
        /// if necessary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        DescribeEventsResponse DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        IAsyncResult BeginDescribeEvents(DescribeEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a  DescribeEventsResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeParameterGroups


        /// <summary>
        /// Returns a list of parameter group descriptions. If a parameter group name is specified,
        /// the list contains only the descriptions for that group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameterGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeParameterGroups service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeParameterGroups">REST API Reference for DescribeParameterGroups Operation</seealso>
        DescribeParameterGroupsResponse DescribeParameterGroups(DescribeParameterGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameterGroups operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeParameterGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeParameterGroups">REST API Reference for DescribeParameterGroups Operation</seealso>
        IAsyncResult BeginDescribeParameterGroups(DescribeParameterGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeParameterGroups.</param>
        /// 
        /// <returns>Returns a  DescribeParameterGroupsResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeParameterGroups">REST API Reference for DescribeParameterGroups Operation</seealso>
        DescribeParameterGroupsResponse EndDescribeParameterGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeParameters


        /// <summary>
        /// Returns the detailed parameter list for a particular parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeParameters service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeParameters">REST API Reference for DescribeParameters Operation</seealso>
        DescribeParametersResponse DescribeParameters(DescribeParametersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameters operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeParameters">REST API Reference for DescribeParameters Operation</seealso>
        IAsyncResult BeginDescribeParameters(DescribeParametersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeParameters.</param>
        /// 
        /// <returns>Returns a  DescribeParametersResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeParameters">REST API Reference for DescribeParameters Operation</seealso>
        DescribeParametersResponse EndDescribeParameters(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReservedNodes


        /// <summary>
        /// Returns information about reserved nodes for this account, or about a specified reserved
        /// node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodes service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ReservedNodeNotFoundException">
        /// The requested node does not exist.
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeReservedNodes">REST API Reference for DescribeReservedNodes Operation</seealso>
        DescribeReservedNodesResponse DescribeReservedNodes(DescribeReservedNodesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodes operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedNodes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeReservedNodes">REST API Reference for DescribeReservedNodes Operation</seealso>
        IAsyncResult BeginDescribeReservedNodes(DescribeReservedNodesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedNodes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedNodes.</param>
        /// 
        /// <returns>Returns a  DescribeReservedNodesResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeReservedNodes">REST API Reference for DescribeReservedNodes Operation</seealso>
        DescribeReservedNodesResponse EndDescribeReservedNodes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReservedNodesOfferings


        /// <summary>
        /// Lists available reserved node offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodesOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedNodesOfferings service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ReservedNodesOfferingNotFoundException">
        /// The requested node offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeReservedNodesOfferings">REST API Reference for DescribeReservedNodesOfferings Operation</seealso>
        DescribeReservedNodesOfferingsResponse DescribeReservedNodesOfferings(DescribeReservedNodesOfferingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedNodesOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodesOfferings operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedNodesOfferings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeReservedNodesOfferings">REST API Reference for DescribeReservedNodesOfferings Operation</seealso>
        IAsyncResult BeginDescribeReservedNodesOfferings(DescribeReservedNodesOfferingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedNodesOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedNodesOfferings.</param>
        /// 
        /// <returns>Returns a  DescribeReservedNodesOfferingsResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeReservedNodesOfferings">REST API Reference for DescribeReservedNodesOfferings Operation</seealso>
        DescribeReservedNodesOfferingsResponse EndDescribeReservedNodesOfferings(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeServiceUpdates


        /// <summary>
        /// Returns details of the service updates
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceUpdates service method.</param>
        /// 
        /// <returns>The response from the DescribeServiceUpdates service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeServiceUpdates">REST API Reference for DescribeServiceUpdates Operation</seealso>
        DescribeServiceUpdatesResponse DescribeServiceUpdates(DescribeServiceUpdatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceUpdates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceUpdates operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeServiceUpdates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeServiceUpdates">REST API Reference for DescribeServiceUpdates Operation</seealso>
        IAsyncResult BeginDescribeServiceUpdates(DescribeServiceUpdatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeServiceUpdates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServiceUpdates.</param>
        /// 
        /// <returns>Returns a  DescribeServiceUpdatesResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeServiceUpdates">REST API Reference for DescribeServiceUpdates Operation</seealso>
        DescribeServiceUpdatesResponse EndDescribeServiceUpdates(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSnapshots


        /// <summary>
        /// Returns information about cluster snapshots. By default, DescribeSnapshots lists all
        /// of your snapshots; it can optionally describe a single snapshot, or just the snapshots
        /// associated with a particular cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        IAsyncResult BeginDescribeSnapshots(DescribeSnapshotsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSnapshots.</param>
        /// 
        /// <returns>Returns a  DescribeSnapshotsResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        DescribeSnapshotsResponse EndDescribeSnapshots(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSubnetGroups


        /// <summary>
        /// Returns a list of subnet group descriptions. If a subnet group name is specified,
        /// the list contains only the description of that group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubnetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeSubnetGroups service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetGroupNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeSubnetGroups">REST API Reference for DescribeSubnetGroups Operation</seealso>
        DescribeSubnetGroupsResponse DescribeSubnetGroups(DescribeSubnetGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubnetGroups operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSubnetGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeSubnetGroups">REST API Reference for DescribeSubnetGroups Operation</seealso>
        IAsyncResult BeginDescribeSubnetGroups(DescribeSubnetGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSubnetGroups.</param>
        /// 
        /// <returns>Returns a  DescribeSubnetGroupsResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeSubnetGroups">REST API Reference for DescribeSubnetGroups Operation</seealso>
        DescribeSubnetGroupsResponse EndDescribeSubnetGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeUsers


        /// <summary>
        /// Returns a list of users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUsers service method.</param>
        /// 
        /// <returns>The response from the DescribeUsers service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.UserNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeUsers">REST API Reference for DescribeUsers Operation</seealso>
        DescribeUsersResponse DescribeUsers(DescribeUsersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUsers operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeUsers">REST API Reference for DescribeUsers Operation</seealso>
        IAsyncResult BeginDescribeUsers(DescribeUsersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUsers.</param>
        /// 
        /// <returns>Returns a  DescribeUsersResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/DescribeUsers">REST API Reference for DescribeUsers Operation</seealso>
        DescribeUsersResponse EndDescribeUsers(IAsyncResult asyncResult);

        #endregion
        
        #region  FailoverShard


        /// <summary>
        /// Used to failover a shard. This API is designed for testing the behavior of your application
        /// in case of MemoryDB failover. It is not designed to be used as a production-level
        /// tool for initiating a failover to overcome a problem you may have with the cluster.
        /// Moreover, in certain conditions such as large scale operational events, Amazon may
        /// block this API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FailoverShard service method.</param>
        /// 
        /// <returns>The response from the FailoverShard service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.APICallRateForCustomerExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidClusterStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidKMSKeyException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ShardNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TestFailoverNotAvailableException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/FailoverShard">REST API Reference for FailoverShard Operation</seealso>
        FailoverShardResponse FailoverShard(FailoverShardRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the FailoverShard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FailoverShard operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFailoverShard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/FailoverShard">REST API Reference for FailoverShard Operation</seealso>
        IAsyncResult BeginFailoverShard(FailoverShardRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  FailoverShard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFailoverShard.</param>
        /// 
        /// <returns>Returns a  FailoverShardResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/FailoverShard">REST API Reference for FailoverShard Operation</seealso>
        FailoverShardResponse EndFailoverShard(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAllowedNodeTypeUpdates


        /// <summary>
        /// Lists all available node types that you can scale to from your cluster's current node
        /// type. When you use the UpdateCluster operation to scale your cluster, the value of
        /// the NodeType parameter must be one of the node types returned by this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAllowedNodeTypeUpdates service method.</param>
        /// 
        /// <returns>The response from the ListAllowedNodeTypeUpdates service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/ListAllowedNodeTypeUpdates">REST API Reference for ListAllowedNodeTypeUpdates Operation</seealso>
        ListAllowedNodeTypeUpdatesResponse ListAllowedNodeTypeUpdates(ListAllowedNodeTypeUpdatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAllowedNodeTypeUpdates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAllowedNodeTypeUpdates operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAllowedNodeTypeUpdates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/ListAllowedNodeTypeUpdates">REST API Reference for ListAllowedNodeTypeUpdates Operation</seealso>
        IAsyncResult BeginListAllowedNodeTypeUpdates(ListAllowedNodeTypeUpdatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAllowedNodeTypeUpdates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAllowedNodeTypeUpdates.</param>
        /// 
        /// <returns>Returns a  ListAllowedNodeTypeUpdatesResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/ListAllowedNodeTypeUpdates">REST API Reference for ListAllowedNodeTypeUpdates Operation</seealso>
        ListAllowedNodeTypeUpdatesResponse EndListAllowedNodeTypeUpdates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTags


        /// <summary>
        /// Lists all tags currently on a named resource. A tag is a key-value pair where the
        /// key and value are case-sensitive. You can use tags to categorize and track your MemoryDB
        /// resources. For more information, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/Tagging-Resources.html">Tagging
        /// your MemoryDB resources</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ACLNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidARNException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidClusterStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.UserNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/ListTags">REST API Reference for ListTags Operation</seealso>
        ListTagsResponse ListTags(ListTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/ListTags">REST API Reference for ListTags Operation</seealso>
        IAsyncResult BeginListTags(ListTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTags.</param>
        /// 
        /// <returns>Returns a  ListTagsResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/ListTags">REST API Reference for ListTags Operation</seealso>
        ListTagsResponse EndListTags(IAsyncResult asyncResult);

        #endregion
        
        #region  PurchaseReservedNodesOffering


        /// <summary>
        /// Allows you to purchase a reserved node offering. Reserved nodes are not eligible for
        /// cancellation and are non-refundable.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedNodesOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseReservedNodesOffering service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ReservedNodeAlreadyExistsException">
        /// You already have a reservation with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ReservedNodeQuotaExceededException">
        /// The request cannot be processed because it would exceed the user's node quota.
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ReservedNodesOfferingNotFoundException">
        /// The requested node offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TagQuotaPerResourceExceededException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/PurchaseReservedNodesOffering">REST API Reference for PurchaseReservedNodesOffering Operation</seealso>
        PurchaseReservedNodesOfferingResponse PurchaseReservedNodesOffering(PurchaseReservedNodesOfferingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedNodesOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedNodesOffering operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseReservedNodesOffering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/PurchaseReservedNodesOffering">REST API Reference for PurchaseReservedNodesOffering Operation</seealso>
        IAsyncResult BeginPurchaseReservedNodesOffering(PurchaseReservedNodesOfferingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseReservedNodesOffering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseReservedNodesOffering.</param>
        /// 
        /// <returns>Returns a  PurchaseReservedNodesOfferingResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/PurchaseReservedNodesOffering">REST API Reference for PurchaseReservedNodesOffering Operation</seealso>
        PurchaseReservedNodesOfferingResponse EndPurchaseReservedNodesOffering(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetParameterGroup


        /// <summary>
        /// Modifies the parameters of a parameter group to the engine or system default value.
        /// You can reset specific parameters by submitting a list of parameter names. To reset
        /// the entire parameter group, specify the AllParameters and ParameterGroupName parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ResetParameterGroup service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterGroupStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/ResetParameterGroup">REST API Reference for ResetParameterGroup Operation</seealso>
        ResetParameterGroupResponse ResetParameterGroup(ResetParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetParameterGroup operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/ResetParameterGroup">REST API Reference for ResetParameterGroup Operation</seealso>
        IAsyncResult BeginResetParameterGroup(ResetParameterGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetParameterGroup.</param>
        /// 
        /// <returns>Returns a  ResetParameterGroupResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/ResetParameterGroup">REST API Reference for ResetParameterGroup Operation</seealso>
        ResetParameterGroupResponse EndResetParameterGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// A tag is a key-value pair where the key and value are case-sensitive. You can use
        /// tags to categorize and track all your MemoryDB resources. When you add or remove tags
        /// on clusters, those actions will be replicated to all nodes in the cluster. For more
        /// information, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/iam.resourcelevelpermissions.html">Resource-level
        /// permissions</a>.
        /// 
        ///  
        /// <para>
        /// For example, you can use cost-allocation tags to your MemoryDB resources, Amazon generates
        /// a cost allocation report as a comma-separated value (CSV) file with your usage and
        /// costs aggregated by your tags. You can apply tags that represent business categories
        /// (such as cost centers, application names, or owners) to organize your costs across
        /// multiple services. For more information, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/tagging.html">Using
        /// Cost Allocation Tags</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ACLNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidARNException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidClusterStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TagQuotaPerResourceExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.UserNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Use this operation to remove tags on a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ACLNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidARNException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidClusterStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SnapshotNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.TagNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.UserNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateACL


        /// <summary>
        /// Changes the list of users that belong to the Access Control List.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateACL service method.</param>
        /// 
        /// <returns>The response from the UpdateACL service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ACLNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.DefaultUserRequiredException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.DuplicateUserNameException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidACLStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.UserNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UpdateACL">REST API Reference for UpdateACL Operation</seealso>
        UpdateACLResponse UpdateACL(UpdateACLRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateACL operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateACL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UpdateACL">REST API Reference for UpdateACL Operation</seealso>
        IAsyncResult BeginUpdateACL(UpdateACLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateACL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateACL.</param>
        /// 
        /// <returns>Returns a  UpdateACLResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UpdateACL">REST API Reference for UpdateACL Operation</seealso>
        UpdateACLResponse EndUpdateACL(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCluster


        /// <summary>
        /// Modifies the settings for a cluster. You can use this operation to change one or more
        /// cluster configuration settings by specifying the settings and the new values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster service method.</param>
        /// 
        /// <returns>The response from the UpdateCluster service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.ACLNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ClusterQuotaForCustomerExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidACLStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidClusterStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidKMSKeyException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidNodeStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidVPCNetworkStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.NodeQuotaForClusterExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.NodeQuotaForCustomerExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.NoOperationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ShardsPerClusterQuotaExceededException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        UpdateClusterResponse UpdateCluster(UpdateClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        IAsyncResult BeginUpdateCluster(UpdateClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCluster.</param>
        /// 
        /// <returns>Returns a  UpdateClusterResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        UpdateClusterResponse EndUpdateCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateParameterGroup


        /// <summary>
        /// Updates the parameters of a parameter group. You can modify up to 20 parameters in
        /// a single request by submitting a list parameter name and value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateParameterGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateParameterGroup service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterGroupStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ParameterGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UpdateParameterGroup">REST API Reference for UpdateParameterGroup Operation</seealso>
        UpdateParameterGroupResponse UpdateParameterGroup(UpdateParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateParameterGroup operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UpdateParameterGroup">REST API Reference for UpdateParameterGroup Operation</seealso>
        IAsyncResult BeginUpdateParameterGroup(UpdateParameterGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateParameterGroup.</param>
        /// 
        /// <returns>Returns a  UpdateParameterGroupResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UpdateParameterGroup">REST API Reference for UpdateParameterGroup Operation</seealso>
        UpdateParameterGroupResponse EndUpdateParameterGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSubnetGroup


        /// <summary>
        /// Updates a subnet group. For more information, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/ubnetGroups.Modifying.html">Updating
        /// a subnet group</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateSubnetGroup service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidSubnetException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.ServiceLinkedRoleNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetGroupNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetNotAllowedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.SubnetQuotaExceededException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UpdateSubnetGroup">REST API Reference for UpdateSubnetGroup Operation</seealso>
        UpdateSubnetGroupResponse UpdateSubnetGroup(UpdateSubnetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubnetGroup operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSubnetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UpdateSubnetGroup">REST API Reference for UpdateSubnetGroup Operation</seealso>
        IAsyncResult BeginUpdateSubnetGroup(UpdateSubnetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSubnetGroup.</param>
        /// 
        /// <returns>Returns a  UpdateSubnetGroupResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UpdateSubnetGroup">REST API Reference for UpdateSubnetGroup Operation</seealso>
        UpdateSubnetGroupResponse EndUpdateSubnetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUser


        /// <summary>
        /// Changes user password(s) and/or access string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by MemoryDB.</returns>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterCombinationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.InvalidUserStateException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.MemoryDB.Model.UserNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse UpdateUser(UpdateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation on AmazonMemoryDBClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        IAsyncResult BeginUpdateUser(UpdateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUser.</param>
        /// 
        /// <returns>Returns a  UpdateUserResult from MemoryDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/memorydb-2021-01-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult);

        #endregion
        
    }
}