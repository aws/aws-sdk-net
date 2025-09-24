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
 * Do not modify this file. This file is generated from the dax-2017-04-19.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DAX.Model;

#pragma warning disable CS1570
namespace Amazon.DAX
{
    /// <summary>
    /// <para>Interface for accessing DAX</para>
    ///
    /// DAX is a managed caching service engineered for Amazon DynamoDB. DAX dramatically
    /// speeds up database reads by caching frequently-accessed data from DynamoDB, so applications
    /// can access that data with sub-millisecond latency. You can create a DAX cluster easily,
    /// using the Amazon Web Services Management Console. With a few simple modifications
    /// to your code, your application can begin taking advantage of the DAX cluster and realize
    /// significant improvements in read performance.
    /// </summary>
    public partial interface IAmazonDAX : IAmazonService, IDisposable
    {




        
        #region  CreateCluster


        /// <summary>
        /// Creates a DAX cluster. All nodes in the cluster run the same DAX caching software.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.ClusterAlreadyExistsException">
        /// You already have a DAX cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ClusterQuotaForCustomerExceededException">
        /// You have attempted to exceed the maximum number of DAX clusters for your Amazon Web
        /// Services account.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InsufficientClusterCapacityException">
        /// There are not enough system resources to create the cluster you requested (or to resize
        /// an already-existing cluster).
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidClusterStateException">
        /// The requested DAX cluster is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterGroupStateException">
        /// One or more parameters in a parameter group are in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidVPCNetworkStateException">
        /// The VPC network is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.NodeQuotaForClusterExceededException">
        /// You have attempted to exceed the maximum number of nodes for a DAX cluster.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.NodeQuotaForCustomerExceededException">
        /// You have attempted to exceed the maximum number of nodes for your Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ParameterGroupNotFoundException">
        /// The specified parameter group does not exist.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ServiceQuotaExceededException">
        /// You have reached the maximum number of x509 certificates that can be created for encrypted
        /// clusters in a 30 day period. Contact Amazon Web Services customer support to discuss
        /// options for continuing to create encrypted clusters.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.SubnetGroupNotFoundException">
        /// The requested subnet group name does not refer to an existing subnet group.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.TagQuotaPerResourceExceededException">
        /// You have exceeded the maximum number of tags for this DAX cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        CreateClusterResponse CreateCluster(CreateClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation on AmazonDAXClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        IAsyncResult BeginCreateCluster(CreateClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCluster.</param>
        /// 
        /// <returns>Returns a  CreateClusterResult from DAX.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        CreateClusterResponse EndCreateCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateParameterGroup


        /// <summary>
        /// Creates a new parameter group. A parameter group is a collection of parameters that
        /// you apply to all of the nodes in a DAX cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CreateParameterGroup service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterGroupStateException">
        /// One or more parameters in a parameter group are in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ParameterGroupAlreadyExistsException">
        /// The specified parameter group already exists.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ParameterGroupQuotaExceededException">
        /// You have attempted to exceed the maximum number of parameter groups.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/CreateParameterGroup">REST API Reference for CreateParameterGroup Operation</seealso>
        CreateParameterGroupResponse CreateParameterGroup(CreateParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateParameterGroup operation on AmazonDAXClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/CreateParameterGroup">REST API Reference for CreateParameterGroup Operation</seealso>
        IAsyncResult BeginCreateParameterGroup(CreateParameterGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateParameterGroup.</param>
        /// 
        /// <returns>Returns a  CreateParameterGroupResult from DAX.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/CreateParameterGroup">REST API Reference for CreateParameterGroup Operation</seealso>
        CreateParameterGroupResponse EndCreateParameterGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSubnetGroup


        /// <summary>
        /// Creates a new subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateSubnetGroup service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.InvalidSubnetException">
        /// An invalid subnet identifier was specified.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.SubnetGroupAlreadyExistsException">
        /// The specified subnet group already exists.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.SubnetGroupQuotaExceededException">
        /// The request cannot be processed because it would exceed the allowed number of subnets
        /// in a subnet group.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.SubnetNotAllowedException">
        /// The specified subnet can't be used for the requested network type. This error occurs
        /// when either there aren't enough subnets of the required network type to create the
        /// cluster, or when you try to use a subnet that doesn't support the requested network
        /// type (for example, trying to create a dual-stack cluster with a subnet that doesn't
        /// have IPv6 CIDR).
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.SubnetQuotaExceededException">
        /// The request cannot be processed because it would exceed the allowed number of subnets
        /// in a subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/CreateSubnetGroup">REST API Reference for CreateSubnetGroup Operation</seealso>
        CreateSubnetGroupResponse CreateSubnetGroup(CreateSubnetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnetGroup operation on AmazonDAXClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubnetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/CreateSubnetGroup">REST API Reference for CreateSubnetGroup Operation</seealso>
        IAsyncResult BeginCreateSubnetGroup(CreateSubnetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubnetGroup.</param>
        /// 
        /// <returns>Returns a  CreateSubnetGroupResult from DAX.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/CreateSubnetGroup">REST API Reference for CreateSubnetGroup Operation</seealso>
        CreateSubnetGroupResponse EndCreateSubnetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DecreaseReplicationFactor


        /// <summary>
        /// Removes one or more nodes from a DAX cluster.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot use <c>DecreaseReplicationFactor</c> to remove the last node in a DAX cluster.
        /// If you need to do this, use <c>DeleteCluster</c> instead.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DecreaseReplicationFactor service method.</param>
        /// 
        /// <returns>The response from the DecreaseReplicationFactor service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.ClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing DAX cluster.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidClusterStateException">
        /// The requested DAX cluster is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.NodeNotFoundException">
        /// None of the nodes in the cluster have the given node ID.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DecreaseReplicationFactor">REST API Reference for DecreaseReplicationFactor Operation</seealso>
        DecreaseReplicationFactorResponse DecreaseReplicationFactor(DecreaseReplicationFactorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DecreaseReplicationFactor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DecreaseReplicationFactor operation on AmazonDAXClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDecreaseReplicationFactor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DecreaseReplicationFactor">REST API Reference for DecreaseReplicationFactor Operation</seealso>
        IAsyncResult BeginDecreaseReplicationFactor(DecreaseReplicationFactorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DecreaseReplicationFactor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDecreaseReplicationFactor.</param>
        /// 
        /// <returns>Returns a  DecreaseReplicationFactorResult from DAX.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DecreaseReplicationFactor">REST API Reference for DecreaseReplicationFactor Operation</seealso>
        DecreaseReplicationFactorResponse EndDecreaseReplicationFactor(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCluster


        /// <summary>
        /// Deletes a previously provisioned DAX cluster. <i>DeleteCluster</i> deletes all associated
        /// nodes, node endpoints and the DAX cluster itself. When you receive a successful response
        /// from this action, DAX immediately begins deleting the cluster; you cannot cancel or
        /// revert this action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.ClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing DAX cluster.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidClusterStateException">
        /// The requested DAX cluster is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        DeleteClusterResponse DeleteCluster(DeleteClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation on AmazonDAXClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        IAsyncResult BeginDeleteCluster(DeleteClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCluster.</param>
        /// 
        /// <returns>Returns a  DeleteClusterResult from DAX.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        DeleteClusterResponse EndDeleteCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteParameterGroup


        /// <summary>
        /// Deletes the specified parameter group. You cannot delete a parameter group if it is
        /// associated with any DAX clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteParameterGroup service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterGroupStateException">
        /// One or more parameters in a parameter group are in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ParameterGroupNotFoundException">
        /// The specified parameter group does not exist.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DeleteParameterGroup">REST API Reference for DeleteParameterGroup Operation</seealso>
        DeleteParameterGroupResponse DeleteParameterGroup(DeleteParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameterGroup operation on AmazonDAXClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DeleteParameterGroup">REST API Reference for DeleteParameterGroup Operation</seealso>
        IAsyncResult BeginDeleteParameterGroup(DeleteParameterGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteParameterGroup.</param>
        /// 
        /// <returns>Returns a  DeleteParameterGroupResult from DAX.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DeleteParameterGroup">REST API Reference for DeleteParameterGroup Operation</seealso>
        DeleteParameterGroupResponse EndDeleteParameterGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSubnetGroup


        /// <summary>
        /// Deletes a subnet group.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete a subnet group if it is associated with any DAX clusters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteSubnetGroup service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.SubnetGroupInUseException">
        /// The specified subnet group is currently in use.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.SubnetGroupNotFoundException">
        /// The requested subnet group name does not refer to an existing subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DeleteSubnetGroup">REST API Reference for DeleteSubnetGroup Operation</seealso>
        DeleteSubnetGroupResponse DeleteSubnetGroup(DeleteSubnetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnetGroup operation on AmazonDAXClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSubnetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DeleteSubnetGroup">REST API Reference for DeleteSubnetGroup Operation</seealso>
        IAsyncResult BeginDeleteSubnetGroup(DeleteSubnetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubnetGroup.</param>
        /// 
        /// <returns>Returns a  DeleteSubnetGroupResult from DAX.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DeleteSubnetGroup">REST API Reference for DeleteSubnetGroup Operation</seealso>
        DeleteSubnetGroupResponse EndDeleteSubnetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeClusters


        /// <summary>
        /// Returns information about all provisioned DAX clusters if no cluster identifier is
        /// specified, or about a specific DAX cluster if a cluster identifier is supplied.
        /// 
        ///  
        /// <para>
        /// If the cluster is in the CREATING state, only cluster level information will be displayed
        /// until all of the nodes are successfully provisioned.
        /// </para>
        ///  
        /// <para>
        /// If the cluster is in the DELETING state, only cluster level information will be displayed.
        /// </para>
        ///  
        /// <para>
        /// If nodes are currently being added to the DAX cluster, node endpoint information and
        /// creation time for the additional nodes will not be displayed until they are completely
        /// provisioned. When the DAX cluster state is <i>available</i>, the cluster is ready
        /// for use.
        /// </para>
        ///  
        /// <para>
        /// If nodes are currently being removed from the DAX cluster, no endpoint information
        /// for the removed nodes is displayed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.ClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing DAX cluster.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        DescribeClustersResponse DescribeClusters(DescribeClustersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters operation on AmazonDAXClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        IAsyncResult BeginDescribeClusters(DescribeClustersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClusters.</param>
        /// 
        /// <returns>Returns a  DescribeClustersResult from DAX.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        DescribeClustersResponse EndDescribeClusters(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDefaultParameters


        /// <summary>
        /// Returns the default system parameter information for the DAX caching software.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeDefaultParameters service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeDefaultParameters">REST API Reference for DescribeDefaultParameters Operation</seealso>
        DescribeDefaultParametersResponse DescribeDefaultParameters(DescribeDefaultParametersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDefaultParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultParameters operation on AmazonDAXClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDefaultParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeDefaultParameters">REST API Reference for DescribeDefaultParameters Operation</seealso>
        IAsyncResult BeginDescribeDefaultParameters(DescribeDefaultParametersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDefaultParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDefaultParameters.</param>
        /// 
        /// <returns>Returns a  DescribeDefaultParametersResult from DAX.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeDefaultParameters">REST API Reference for DescribeDefaultParameters Operation</seealso>
        DescribeDefaultParametersResponse EndDescribeDefaultParameters(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEvents


        /// <summary>
        /// Returns events related to DAX clusters and parameter groups. You can obtain events
        /// specific to a particular DAX cluster or parameter group by providing the name as a
        /// parameter.
        /// 
        ///  
        /// <para>
        /// By default, only the events occurring within the last 24 hours are returned; however,
        /// you can retrieve up to 14 days' worth of events if necessary.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        DescribeEventsResponse DescribeEvents(DescribeEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation on AmazonDAXClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        IAsyncResult BeginDescribeEvents(DescribeEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEvents.</param>
        /// 
        /// <returns>Returns a  DescribeEventsResult from DAX.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        DescribeEventsResponse EndDescribeEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeParameterGroups


        /// <summary>
        /// Returns a list of parameter group descriptions. If a parameter group name is specified,
        /// the list will contain only the descriptions for that group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameterGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeParameterGroups service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ParameterGroupNotFoundException">
        /// The specified parameter group does not exist.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeParameterGroups">REST API Reference for DescribeParameterGroups Operation</seealso>
        DescribeParameterGroupsResponse DescribeParameterGroups(DescribeParameterGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameterGroups operation on AmazonDAXClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeParameterGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeParameterGroups">REST API Reference for DescribeParameterGroups Operation</seealso>
        IAsyncResult BeginDescribeParameterGroups(DescribeParameterGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeParameterGroups.</param>
        /// 
        /// <returns>Returns a  DescribeParameterGroupsResult from DAX.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeParameterGroups">REST API Reference for DescribeParameterGroups Operation</seealso>
        DescribeParameterGroupsResponse EndDescribeParameterGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeParameters


        /// <summary>
        /// Returns the detailed parameter list for a particular parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeParameters service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ParameterGroupNotFoundException">
        /// The specified parameter group does not exist.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeParameters">REST API Reference for DescribeParameters Operation</seealso>
        DescribeParametersResponse DescribeParameters(DescribeParametersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameters operation on AmazonDAXClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeParameters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeParameters">REST API Reference for DescribeParameters Operation</seealso>
        IAsyncResult BeginDescribeParameters(DescribeParametersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeParameters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeParameters.</param>
        /// 
        /// <returns>Returns a  DescribeParametersResult from DAX.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeParameters">REST API Reference for DescribeParameters Operation</seealso>
        DescribeParametersResponse EndDescribeParameters(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSubnetGroups


        /// <summary>
        /// Returns a list of subnet group descriptions. If a subnet group name is specified,
        /// the list will contain only the description of that group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubnetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeSubnetGroups service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.SubnetGroupNotFoundException">
        /// The requested subnet group name does not refer to an existing subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeSubnetGroups">REST API Reference for DescribeSubnetGroups Operation</seealso>
        DescribeSubnetGroupsResponse DescribeSubnetGroups(DescribeSubnetGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubnetGroups operation on AmazonDAXClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSubnetGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeSubnetGroups">REST API Reference for DescribeSubnetGroups Operation</seealso>
        IAsyncResult BeginDescribeSubnetGroups(DescribeSubnetGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSubnetGroups.</param>
        /// 
        /// <returns>Returns a  DescribeSubnetGroupsResult from DAX.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeSubnetGroups">REST API Reference for DescribeSubnetGroups Operation</seealso>
        DescribeSubnetGroupsResponse EndDescribeSubnetGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  IncreaseReplicationFactor


        /// <summary>
        /// Adds one or more nodes to a DAX cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IncreaseReplicationFactor service method.</param>
        /// 
        /// <returns>The response from the IncreaseReplicationFactor service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.ClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing DAX cluster.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InsufficientClusterCapacityException">
        /// There are not enough system resources to create the cluster you requested (or to resize
        /// an already-existing cluster).
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidClusterStateException">
        /// The requested DAX cluster is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidVPCNetworkStateException">
        /// The VPC network is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.NodeQuotaForClusterExceededException">
        /// You have attempted to exceed the maximum number of nodes for a DAX cluster.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.NodeQuotaForCustomerExceededException">
        /// You have attempted to exceed the maximum number of nodes for your Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/IncreaseReplicationFactor">REST API Reference for IncreaseReplicationFactor Operation</seealso>
        IncreaseReplicationFactorResponse IncreaseReplicationFactor(IncreaseReplicationFactorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the IncreaseReplicationFactor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IncreaseReplicationFactor operation on AmazonDAXClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndIncreaseReplicationFactor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/IncreaseReplicationFactor">REST API Reference for IncreaseReplicationFactor Operation</seealso>
        IAsyncResult BeginIncreaseReplicationFactor(IncreaseReplicationFactorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  IncreaseReplicationFactor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIncreaseReplicationFactor.</param>
        /// 
        /// <returns>Returns a  IncreaseReplicationFactorResult from DAX.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/IncreaseReplicationFactor">REST API Reference for IncreaseReplicationFactor Operation</seealso>
        IncreaseReplicationFactorResponse EndIncreaseReplicationFactor(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTags


        /// <summary>
        /// List all of the tags for a DAX cluster. You can call <c>ListTags</c> up to 10 times
        /// per second, per account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.ClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing DAX cluster.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidARNException">
        /// The Amazon Resource Name (ARN) supplied in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidClusterStateException">
        /// The requested DAX cluster is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/ListTags">REST API Reference for ListTags Operation</seealso>
        ListTagsResponse ListTags(ListTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation on AmazonDAXClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/ListTags">REST API Reference for ListTags Operation</seealso>
        IAsyncResult BeginListTags(ListTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTags.</param>
        /// 
        /// <returns>Returns a  ListTagsResult from DAX.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/ListTags">REST API Reference for ListTags Operation</seealso>
        ListTagsResponse EndListTags(IAsyncResult asyncResult);

        #endregion
        
        #region  RebootNode


        /// <summary>
        /// Reboots a single node of a DAX cluster. The reboot action takes place as soon as possible.
        /// During the reboot, the node status is set to REBOOTING.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>RebootNode</c> restarts the DAX engine process and does not remove the contents
        /// of the cache.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootNode service method.</param>
        /// 
        /// <returns>The response from the RebootNode service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.ClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing DAX cluster.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidClusterStateException">
        /// The requested DAX cluster is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.NodeNotFoundException">
        /// None of the nodes in the cluster have the given node ID.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/RebootNode">REST API Reference for RebootNode Operation</seealso>
        RebootNodeResponse RebootNode(RebootNodeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RebootNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootNode operation on AmazonDAXClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/RebootNode">REST API Reference for RebootNode Operation</seealso>
        IAsyncResult BeginRebootNode(RebootNodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RebootNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootNode.</param>
        /// 
        /// <returns>Returns a  RebootNodeResult from DAX.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/RebootNode">REST API Reference for RebootNode Operation</seealso>
        RebootNodeResponse EndRebootNode(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates a set of tags with a DAX resource. You can call <c>TagResource</c> up to
        /// 5 times per second, per account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.ClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing DAX cluster.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidARNException">
        /// The Amazon Resource Name (ARN) supplied in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidClusterStateException">
        /// The requested DAX cluster is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.TagQuotaPerResourceExceededException">
        /// You have exceeded the maximum number of tags for this DAX cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonDAXClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from DAX.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the association of tags from a DAX resource. You can call <c>UntagResource</c>
        /// up to 5 times per second, per account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.ClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing DAX cluster.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidARNException">
        /// The Amazon Resource Name (ARN) supplied in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidClusterStateException">
        /// The requested DAX cluster is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.TagNotFoundException">
        /// The tag does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonDAXClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from DAX.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCluster


        /// <summary>
        /// Modifies the settings for a DAX cluster. You can use this action to change one or
        /// more cluster configuration parameters by specifying the parameters and the new values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster service method.</param>
        /// 
        /// <returns>The response from the UpdateCluster service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.ClusterNotFoundException">
        /// The requested cluster ID does not refer to an existing DAX cluster.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidClusterStateException">
        /// The requested DAX cluster is not in the <i>available</i> state.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterGroupStateException">
        /// One or more parameters in a parameter group are in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ParameterGroupNotFoundException">
        /// The specified parameter group does not exist.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        UpdateClusterResponse UpdateCluster(UpdateClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster operation on AmazonDAXClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        IAsyncResult BeginUpdateCluster(UpdateClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCluster.</param>
        /// 
        /// <returns>Returns a  UpdateClusterResult from DAX.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        UpdateClusterResponse EndUpdateCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateParameterGroup


        /// <summary>
        /// Modifies the parameters of a parameter group. You can modify up to 20 parameters in
        /// a single request by submitting a list parameter name and value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateParameterGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateParameterGroup service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterCombinationException">
        /// Two or more incompatible parameters were specified.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterGroupStateException">
        /// One or more parameters in a parameter group are in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.InvalidParameterValueException">
        /// The value for a parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ParameterGroupNotFoundException">
        /// The specified parameter group does not exist.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/UpdateParameterGroup">REST API Reference for UpdateParameterGroup Operation</seealso>
        UpdateParameterGroupResponse UpdateParameterGroup(UpdateParameterGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateParameterGroup operation on AmazonDAXClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateParameterGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/UpdateParameterGroup">REST API Reference for UpdateParameterGroup Operation</seealso>
        IAsyncResult BeginUpdateParameterGroup(UpdateParameterGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateParameterGroup.</param>
        /// 
        /// <returns>Returns a  UpdateParameterGroupResult from DAX.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/UpdateParameterGroup">REST API Reference for UpdateParameterGroup Operation</seealso>
        UpdateParameterGroupResponse EndUpdateParameterGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSubnetGroup


        /// <summary>
        /// Modifies an existing subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateSubnetGroup service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.InvalidSubnetException">
        /// An invalid subnet identifier was specified.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.SubnetGroupNotFoundException">
        /// The requested subnet group name does not refer to an existing subnet group.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.SubnetInUseException">
        /// The requested subnet is being used by another subnet group.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.SubnetNotAllowedException">
        /// The specified subnet can't be used for the requested network type. This error occurs
        /// when either there aren't enough subnets of the required network type to create the
        /// cluster, or when you try to use a subnet that doesn't support the requested network
        /// type (for example, trying to create a dual-stack cluster with a subnet that doesn't
        /// have IPv6 CIDR).
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.SubnetQuotaExceededException">
        /// The request cannot be processed because it would exceed the allowed number of subnets
        /// in a subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/UpdateSubnetGroup">REST API Reference for UpdateSubnetGroup Operation</seealso>
        UpdateSubnetGroupResponse UpdateSubnetGroup(UpdateSubnetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubnetGroup operation on AmazonDAXClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSubnetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/UpdateSubnetGroup">REST API Reference for UpdateSubnetGroup Operation</seealso>
        IAsyncResult BeginUpdateSubnetGroup(UpdateSubnetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSubnetGroup.</param>
        /// 
        /// <returns>Returns a  UpdateSubnetGroupResult from DAX.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/UpdateSubnetGroup">REST API Reference for UpdateSubnetGroup Operation</seealso>
        UpdateSubnetGroupResponse EndUpdateSubnetGroup(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}