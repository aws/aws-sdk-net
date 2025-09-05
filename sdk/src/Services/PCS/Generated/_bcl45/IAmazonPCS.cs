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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PCS.Model;

#pragma warning disable CS1570
namespace Amazon.PCS
{
    /// <summary>
    /// <para>Interface for accessing PCS</para>
    ///
    /// Parallel Computing Service (PCS) is a managed service that makes it easier for you
    /// to run and scale your high performance computing (HPC) workloads, and build scientific
    /// and engineering models on Amazon Web Services using Slurm. For more information, see
    /// the <a href="https://docs.aws.amazon.com/pcs/latest/userguide">Parallel Computing
    /// Service User Guide</a>.
    /// 
    ///  
    /// <para>
    /// This reference describes the actions and data types of the service management API.
    /// You can use the Amazon Web Services SDKs to call the API actions in software, or use
    /// the Command Line Interface (CLI) to call the API actions manually. These API actions
    /// manage the service through an Amazon Web Services account.
    /// </para>
    ///  
    /// <para>
    /// The API actions operate on PCS resources. A <i>resource</i> is an entity in Amazon
    /// Web Services that you can work with. Amazon Web Services services create resources
    /// when you use the features of the service. Examples of PCS resources include clusters,
    /// compute node groups, and queues. For more information about resources in Amazon Web
    /// Services, see <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/getting-started-terms-and-concepts.html#term-resource">Resource</a>
    /// in the <i>Resource Explorer User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// An PCS <i>compute node</i> is an Amazon EC2 instance. You don't launch compute nodes
    /// directly. PCS uses configuration information that you provide to launch compute nodes
    /// in your Amazon Web Services account. You receive billing charges for your running
    /// compute nodes. PCS automatically terminates your compute nodes when you delete the
    /// PCS resources related to those compute nodes.
    /// </para>
    /// </summary>
    public partial interface IAmazonPCS : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPCSPaginatorFactory Paginators { get; }

        
        #region  CreateCluster


        /// <summary>
        /// Creates a cluster in your account. PCS creates the cluster controller in a service-owned
        /// account. The cluster controller communicates with the cluster resources in your account.
        /// The subnets and security groups for the cluster must already exist before you use
        /// this API action.
        /// 
        ///  <note> 
        /// <para>
        /// It takes time for PCS to create the cluster. The cluster is in a <c>Creating</c> state
        /// until it is ready to use. There can only be 1 cluster in a <c>Creating</c> state per
        /// Amazon Web Services Region per Amazon Web Services account. <c>CreateCluster</c> fails
        /// with a <c>ServiceQuotaExceededException</c> if there is already a cluster in a <c>Creating</c>
        /// state.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// To learn how to increase your service quota, see <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/request-quota-increase.html">Requesting
        /// a quota increase</a> in the <i>Service Quotas User Guide</i> 
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The max number of clusters or queues has been reached for the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The max number of compute node groups has been reached for the associated cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total of <c>maxInstances</c> across all compute node groups has been reached for
        /// associated cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        CreateClusterResponse CreateCluster(CreateClusterRequest request);



        /// <summary>
        /// Creates a cluster in your account. PCS creates the cluster controller in a service-owned
        /// account. The cluster controller communicates with the cluster resources in your account.
        /// The subnets and security groups for the cluster must already exist before you use
        /// this API action.
        /// 
        ///  <note> 
        /// <para>
        /// It takes time for PCS to create the cluster. The cluster is in a <c>Creating</c> state
        /// until it is ready to use. There can only be 1 cluster in a <c>Creating</c> state per
        /// Amazon Web Services Region per Amazon Web Services account. <c>CreateCluster</c> fails
        /// with a <c>ServiceQuotaExceededException</c> if there is already a cluster in a <c>Creating</c>
        /// state.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// To learn how to increase your service quota, see <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/request-quota-increase.html">Requesting
        /// a quota increase</a> in the <i>Service Quotas User Guide</i> 
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The max number of clusters or queues has been reached for the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The max number of compute node groups has been reached for the associated cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total of <c>maxInstances</c> across all compute node groups has been reached for
        /// associated cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateComputeNodeGroup


        /// <summary>
        /// Creates a managed set of compute nodes. You associate a compute node group with a
        /// cluster through 1 or more PCS queues or as part of the login fleet. A compute node
        /// group includes the definition of the compute properties and lifecycle management.
        /// PCS uses the information you provide to this API action to launch compute nodes in
        /// your account. You can only specify subnets in the same Amazon VPC as your cluster.
        /// You receive billing charges for the compute nodes that PCS launches in your account.
        /// You must already have a launch template before you call this API. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">Launch
        /// an instance from a launch template</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide for Linux Instances</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComputeNodeGroup service method.</param>
        /// 
        /// <returns>The response from the CreateComputeNodeGroup service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// To learn how to increase your service quota, see <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/request-quota-increase.html">Requesting
        /// a quota increase</a> in the <i>Service Quotas User Guide</i> 
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The max number of clusters or queues has been reached for the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The max number of compute node groups has been reached for the associated cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total of <c>maxInstances</c> across all compute node groups has been reached for
        /// associated cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/CreateComputeNodeGroup">REST API Reference for CreateComputeNodeGroup Operation</seealso>
        CreateComputeNodeGroupResponse CreateComputeNodeGroup(CreateComputeNodeGroupRequest request);



        /// <summary>
        /// Creates a managed set of compute nodes. You associate a compute node group with a
        /// cluster through 1 or more PCS queues or as part of the login fleet. A compute node
        /// group includes the definition of the compute properties and lifecycle management.
        /// PCS uses the information you provide to this API action to launch compute nodes in
        /// your account. You can only specify subnets in the same Amazon VPC as your cluster.
        /// You receive billing charges for the compute nodes that PCS launches in your account.
        /// You must already have a launch template before you call this API. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">Launch
        /// an instance from a launch template</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide for Linux Instances</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComputeNodeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateComputeNodeGroup service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// To learn how to increase your service quota, see <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/request-quota-increase.html">Requesting
        /// a quota increase</a> in the <i>Service Quotas User Guide</i> 
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The max number of clusters or queues has been reached for the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The max number of compute node groups has been reached for the associated cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total of <c>maxInstances</c> across all compute node groups has been reached for
        /// associated cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/CreateComputeNodeGroup">REST API Reference for CreateComputeNodeGroup Operation</seealso>
        Task<CreateComputeNodeGroupResponse> CreateComputeNodeGroupAsync(CreateComputeNodeGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateQueue


        /// <summary>
        /// Creates a job queue. You must associate 1 or more compute node groups with the queue.
        /// You can associate 1 compute node group with multiple queues.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue service method.</param>
        /// 
        /// <returns>The response from the CreateQueue service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// To learn how to increase your service quota, see <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/request-quota-increase.html">Requesting
        /// a quota increase</a> in the <i>Service Quotas User Guide</i> 
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The max number of clusters or queues has been reached for the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The max number of compute node groups has been reached for the associated cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total of <c>maxInstances</c> across all compute node groups has been reached for
        /// associated cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        CreateQueueResponse CreateQueue(CreateQueueRequest request);



        /// <summary>
        /// Creates a job queue. You must associate 1 or more compute node groups with the queue.
        /// You can associate 1 compute node group with multiple queues.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQueue service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// To learn how to increase your service quota, see <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/request-quota-increase.html">Requesting
        /// a quota increase</a> in the <i>Service Quotas User Guide</i> 
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The max number of clusters or queues has been reached for the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The max number of compute node groups has been reached for the associated cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total of <c>maxInstances</c> across all compute node groups has been reached for
        /// associated cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCluster


        /// <summary>
        /// Deletes a cluster and all its linked resources. You must delete all queues and compute
        /// node groups associated with the cluster before you can delete the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        DeleteClusterResponse DeleteCluster(DeleteClusterRequest request);



        /// <summary>
        /// Deletes a cluster and all its linked resources. You must delete all queues and compute
        /// node groups associated with the cluster before you can delete the cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteComputeNodeGroup


        /// <summary>
        /// Deletes a compute node group. You must delete all queues associated with the compute
        /// node group first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComputeNodeGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteComputeNodeGroup service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/DeleteComputeNodeGroup">REST API Reference for DeleteComputeNodeGroup Operation</seealso>
        DeleteComputeNodeGroupResponse DeleteComputeNodeGroup(DeleteComputeNodeGroupRequest request);



        /// <summary>
        /// Deletes a compute node group. You must delete all queues associated with the compute
        /// node group first.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComputeNodeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteComputeNodeGroup service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/DeleteComputeNodeGroup">REST API Reference for DeleteComputeNodeGroup Operation</seealso>
        Task<DeleteComputeNodeGroupResponse> DeleteComputeNodeGroupAsync(DeleteComputeNodeGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteQueue


        /// <summary>
        /// Deletes a job queue. If the compute node group associated with this queue isn't associated
        /// with any other queues, PCS terminates all the compute nodes for this queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueue service method.</param>
        /// 
        /// <returns>The response from the DeleteQueue service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/DeleteQueue">REST API Reference for DeleteQueue Operation</seealso>
        DeleteQueueResponse DeleteQueue(DeleteQueueRequest request);



        /// <summary>
        /// Deletes a job queue. If the compute node group associated with this queue isn't associated
        /// with any other queues, PCS terminates all the compute nodes for this queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQueue service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/DeleteQueue">REST API Reference for DeleteQueue Operation</seealso>
        Task<DeleteQueueResponse> DeleteQueueAsync(DeleteQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCluster


        /// <summary>
        /// Returns detailed information about a running cluster in your account. This API action
        /// provides networking information, endpoint information for communication with the scheduler,
        /// and provisioning status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCluster service method.</param>
        /// 
        /// <returns>The response from the GetCluster service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/GetCluster">REST API Reference for GetCluster Operation</seealso>
        GetClusterResponse GetCluster(GetClusterRequest request);



        /// <summary>
        /// Returns detailed information about a running cluster in your account. This API action
        /// provides networking information, endpoint information for communication with the scheduler,
        /// and provisioning status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCluster service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/GetCluster">REST API Reference for GetCluster Operation</seealso>
        Task<GetClusterResponse> GetClusterAsync(GetClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetComputeNodeGroup


        /// <summary>
        /// Returns detailed information about a compute node group. This API action provides
        /// networking information, EC2 instance type, compute node group status, and scheduler
        /// (such as Slurm) configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComputeNodeGroup service method.</param>
        /// 
        /// <returns>The response from the GetComputeNodeGroup service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/GetComputeNodeGroup">REST API Reference for GetComputeNodeGroup Operation</seealso>
        GetComputeNodeGroupResponse GetComputeNodeGroup(GetComputeNodeGroupRequest request);



        /// <summary>
        /// Returns detailed information about a compute node group. This API action provides
        /// networking information, EC2 instance type, compute node group status, and scheduler
        /// (such as Slurm) configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComputeNodeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetComputeNodeGroup service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/GetComputeNodeGroup">REST API Reference for GetComputeNodeGroup Operation</seealso>
        Task<GetComputeNodeGroupResponse> GetComputeNodeGroupAsync(GetComputeNodeGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetQueue


        /// <summary>
        /// Returns detailed information about a queue. The information includes the compute node
        /// groups that the queue uses to schedule jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueue service method.</param>
        /// 
        /// <returns>The response from the GetQueue service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/GetQueue">REST API Reference for GetQueue Operation</seealso>
        GetQueueResponse GetQueue(GetQueueRequest request);



        /// <summary>
        /// Returns detailed information about a queue. The information includes the compute node
        /// groups that the queue uses to schedule jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueue service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/GetQueue">REST API Reference for GetQueue Operation</seealso>
        Task<GetQueueResponse> GetQueueAsync(GetQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListClusters


        /// <summary>
        /// Returns a list of running clusters in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/ListClusters">REST API Reference for ListClusters Operation</seealso>
        ListClustersResponse ListClusters(ListClustersRequest request);



        /// <summary>
        /// Returns a list of running clusters in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/ListClusters">REST API Reference for ListClusters Operation</seealso>
        Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListComputeNodeGroups


        /// <summary>
        /// Returns a list of all compute node groups associated with a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComputeNodeGroups service method.</param>
        /// 
        /// <returns>The response from the ListComputeNodeGroups service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/ListComputeNodeGroups">REST API Reference for ListComputeNodeGroups Operation</seealso>
        ListComputeNodeGroupsResponse ListComputeNodeGroups(ListComputeNodeGroupsRequest request);



        /// <summary>
        /// Returns a list of all compute node groups associated with a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComputeNodeGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListComputeNodeGroups service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/ListComputeNodeGroups">REST API Reference for ListComputeNodeGroups Operation</seealso>
        Task<ListComputeNodeGroupsResponse> ListComputeNodeGroupsAsync(ListComputeNodeGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListQueues


        /// <summary>
        /// Returns a list of all queues associated with a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueues service method.</param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/ListQueues">REST API Reference for ListQueues Operation</seealso>
        ListQueuesResponse ListQueues(ListQueuesRequest request);



        /// <summary>
        /// Returns a list of all queues associated with a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/ListQueues">REST API Reference for ListQueues Operation</seealso>
        Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of all tags on an PCS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Returns a list of all tags on an PCS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterComputeNodeGroupInstance


        /// <summary>
        /// <important> 
        /// <para>
        /// This API action isn't intended for you to use.
        /// 
        ///  </important> 
        /// <para>
        /// PCS uses this API action to register the compute nodes it launches in your account.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterComputeNodeGroupInstance service method.</param>
        /// 
        /// <returns>The response from the RegisterComputeNodeGroupInstance service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/RegisterComputeNodeGroupInstance">REST API Reference for RegisterComputeNodeGroupInstance Operation</seealso>
        RegisterComputeNodeGroupInstanceResponse RegisterComputeNodeGroupInstance(RegisterComputeNodeGroupInstanceRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// This API action isn't intended for you to use.
        /// 
        ///  </important> 
        /// <para>
        /// PCS uses this API action to register the compute nodes it launches in your account.
        /// </para>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterComputeNodeGroupInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterComputeNodeGroupInstance service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/RegisterComputeNodeGroupInstance">REST API Reference for RegisterComputeNodeGroupInstance Operation</seealso>
        Task<RegisterComputeNodeGroupInstanceResponse> RegisterComputeNodeGroupInstanceAsync(RegisterComputeNodeGroupInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or edits tags on an PCS resource. Each tag consists of a tag key and a tag value.
        /// The tag key and tag value are case-sensitive strings. The tag value can be an empty
        /// (null) string. To add a tag, specify a new tag key and a tag value. To edit a tag,
        /// specify an existing tag key and a new tag value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// To learn how to increase your service quota, see <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/request-quota-increase.html">Requesting
        /// a quota increase</a> in the <i>Service Quotas User Guide</i> 
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The max number of clusters or queues has been reached for the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The max number of compute node groups has been reached for the associated cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total of <c>maxInstances</c> across all compute node groups has been reached for
        /// associated cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds or edits tags on an PCS resource. Each tag consists of a tag key and a tag value.
        /// The tag key and tag value are case-sensitive strings. The tag value can be an empty
        /// (null) string. To add a tag, specify a new tag key and a tag value. To edit a tag,
        /// specify an existing tag key and a new tag value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// To learn how to increase your service quota, see <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/request-quota-increase.html">Requesting
        /// a quota increase</a> in the <i>Service Quotas User Guide</i> 
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The max number of clusters or queues has been reached for the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The max number of compute node groups has been reached for the associated cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total of <c>maxInstances</c> across all compute node groups has been reached for
        /// associated cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes tags from an PCS resource. To delete a tag, specify the tag key and the Amazon
        /// Resource Name (ARN) of the PCS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Deletes tags from an PCS resource. To delete a tag, specify the tag key and the Amazon
        /// Resource Name (ARN) of the PCS resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateComputeNodeGroup


        /// <summary>
        /// Updates a compute node group. You can update many of the fields related to your compute
        /// node group including the configurations for networking, compute nodes, and settings
        /// specific to your scheduler (such as Slurm).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComputeNodeGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateComputeNodeGroup service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// To learn how to increase your service quota, see <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/request-quota-increase.html">Requesting
        /// a quota increase</a> in the <i>Service Quotas User Guide</i> 
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The max number of clusters or queues has been reached for the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The max number of compute node groups has been reached for the associated cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total of <c>maxInstances</c> across all compute node groups has been reached for
        /// associated cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/UpdateComputeNodeGroup">REST API Reference for UpdateComputeNodeGroup Operation</seealso>
        UpdateComputeNodeGroupResponse UpdateComputeNodeGroup(UpdateComputeNodeGroupRequest request);



        /// <summary>
        /// Updates a compute node group. You can update many of the fields related to your compute
        /// node group including the configurations for networking, compute nodes, and settings
        /// specific to your scheduler (such as Slurm).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComputeNodeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateComputeNodeGroup service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// To learn how to increase your service quota, see <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/request-quota-increase.html">Requesting
        /// a quota increase</a> in the <i>Service Quotas User Guide</i> 
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The max number of clusters or queues has been reached for the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The max number of compute node groups has been reached for the associated cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total of <c>maxInstances</c> across all compute node groups has been reached for
        /// associated cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/UpdateComputeNodeGroup">REST API Reference for UpdateComputeNodeGroup Operation</seealso>
        Task<UpdateComputeNodeGroupResponse> UpdateComputeNodeGroupAsync(UpdateComputeNodeGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateQueue


        /// <summary>
        /// Updates the compute node group configuration of a queue. Use this API to change the
        /// compute node groups that the queue can send jobs to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueue service method.</param>
        /// 
        /// <returns>The response from the UpdateQueue service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// To learn how to increase your service quota, see <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/request-quota-increase.html">Requesting
        /// a quota increase</a> in the <i>Service Quotas User Guide</i> 
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The max number of clusters or queues has been reached for the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The max number of compute node groups has been reached for the associated cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total of <c>maxInstances</c> across all compute node groups has been reached for
        /// associated cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/UpdateQueue">REST API Reference for UpdateQueue Operation</seealso>
        UpdateQueueResponse UpdateQueue(UpdateQueueRequest request);



        /// <summary>
        /// Updates the compute node group configuration of a queue. Use this API to change the
        /// compute node groups that the queue can send jobs to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQueue service method, as returned by PCS.</returns>
        /// <exception cref="Amazon.PCS.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The launch template instance profile doesn't pass <c>iam:PassRole</c> verification.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a mismatch between the account ID and cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster ID doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The EC2 instance isn't present.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than 1 operation on the same resource at the same time.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A cluster with the same name already exists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster isn't in <c>ACTIVE</c> status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A cluster to delete is in an unstable state. For example, because it still has <c>ACTIVE</c>
        /// node groups or queues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A queue already exists in a cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.InternalServerException">
        /// PCS can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ResourceNotFoundException">
        /// The requested resource can't be found. The cluster, node group, or queue you're attempting
        /// to get, update, list, or delete doesn't exist.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// To learn how to increase your service quota, see <a href="https://docs.aws.amazon.com/servicequotas/latest/userguide/request-quota-increase.html">Requesting
        /// a quota increase</a> in the <i>Service Quotas User Guide</i> 
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The max number of clusters or queues has been reached for the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The max number of compute node groups has been reached for the associated cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total of <c>maxInstances</c> across all compute node groups has been reached for
        /// associated cluster.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ThrottlingException">
        /// Your request exceeded a request rate quota. Check the resource's request rate quota
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.PCS.Model.ValidationException">
        /// The request isn't valid.
        /// 
        ///  
        /// <para>
        ///  <u>Examples</u> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your request contains malformed JSON or unsupported characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The scheduler version isn't supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are networking related errors, such as network validation failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AMI type is <c>CUSTOM</c> and the launch template doesn't define the AMI ID, or the
        /// AMI type is AL2 and the launch template defines the AMI.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pcs-2023-02-10/UpdateQueue">REST API Reference for UpdateQueue Operation</seealso>
        Task<UpdateQueueResponse> UpdateQueueAsync(UpdateQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

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