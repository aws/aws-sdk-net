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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.EKS.Model;

namespace Amazon.EKS
{
    /// <summary>
    /// Interface for accessing EKS
    ///
    /// Amazon Elastic Container Service for Kubernetes (Amazon EKS) is a managed service
    /// that makes it easy for you to run Kubernetes on AWS without needing to stand up or
    /// maintain your own Kubernetes control plane. Kubernetes is an open-source system for
    /// automating the deployment, scaling, and management of containerized applications.
    /// 
    /// 
    ///  
    /// <para>
    /// Amazon EKS runs three Kubernetes control plane instances across three Availability
    /// Zones to ensure high availability. Amazon EKS automatically detects and replaces unhealthy
    /// control plane instances, and it provides automated version upgrades and patching for
    /// them.
    /// </para>
    ///  
    /// <para>
    /// Amazon EKS is also integrated with many AWS services to provide scalability and security
    /// for your applications, including the following: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Elastic Load Balancing for load distribution
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// IAM for authentication
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon VPC for isolation
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Amazon EKS runs up to date versions of the open-source Kubernetes software, so you
    /// can use all the existing plugins and tooling from the Kubernetes community. Applications
    /// running on Amazon EKS are fully compatible with applications running on any standard
    /// Kubernetes environment, whether running in on-premises data centers or public clouds.
    /// This means that you can easily migrate any standard Kubernetes application to Amazon
    /// EKS without any code modification required.
    /// </para>
    /// </summary>
    public partial interface IAmazonEKS : IAmazonService, IDisposable
    {

        
        #region  CreateCluster


        /// <summary>
        /// Creates an Amazon EKS control plane. 
        /// 
        ///  
        /// <para>
        /// The Amazon EKS control plane consists of control plane instances that run the Kubernetes
        /// software, like <code>etcd</code> and the API server. The control plane runs in an
        /// account managed by AWS, and the Kubernetes API is exposed via the Amazon EKS API server
        /// endpoint.
        /// </para>
        ///  
        /// <para>
        /// Amazon EKS worker nodes run in your AWS account and connect to your cluster's control
        /// plane via the Kubernetes API server endpoint and a certificate file that is created
        /// for your cluster.
        /// </para>
        ///  
        /// <para>
        /// The cluster control plane is provisioned across multiple Availability Zones and fronted
        /// by an Elastic Load Balancing Network Load Balancer. Amazon EKS also provisions elastic
        /// network interfaces in your VPC subnets to provide connectivity from the control plane
        /// instances to the worker nodes (for example, to support <code>kubectl exec</code>,
        /// <code>logs</code>, and <code>proxy</code> data flows).
        /// </para>
        ///  
        /// <para>
        /// After you create an Amazon EKS cluster, you must configure your Kubernetes tooling
        /// to communicate with the API server and launch worker nodes into your cluster. For
        /// more information, see <a href="http://docs.aws.amazon.com/eks/latest/userguide/managing-auth.html">Managing
        /// Cluster Authentication</a> and <a href="http://docs.aws.amazon.com/eks/latest/userguide/launch-workers.html">Launching
        /// Amazon EKS Worker Nodes</a>in the <i>Amazon EKS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceLimitExceededException">
        /// You have encountered a service limit on the specified resource.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable, back off and retry the operation.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.UnsupportedAvailabilityZoneException">
        /// At least one of your specified cluster subnets is in an Availability Zone that does
        /// not support Amazon EKS. The exception output will specify the supported Availability
        /// Zones for your account, from which you can choose subnets for your cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        CreateClusterResponse CreateCluster(CreateClusterRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCluster


        /// <summary>
        /// Deletes the Amazon EKS cluster control plane. 
        /// 
        ///  <note> 
        /// <para>
        /// If you have active services in your cluster that are associated with a load balancer,
        /// you must delete those services before deleting the cluster so that the load balancers
        /// are deleted properly. Otherwise, you can have orphaned resources in your VPC that
        /// prevent you from being able to delete the VPC. For more information, see <a href="http://docs.aws.amazon.com/eks/latest/userguide/delete-cluster.html">Deleting
        /// a Cluster</a> in the <i>Amazon EKS User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceInUseException">
        /// The specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon EKS clusters are region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable, back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        DeleteClusterResponse DeleteCluster(DeleteClusterRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCluster


        /// <summary>
        /// Returns descriptive information about an Amazon EKS cluster.
        /// 
        ///  
        /// <para>
        /// The API server endpoint and certificate authority data returned by this operation
        /// are required for <code>kubelet</code> and <code>kubectl</code> to communicate with
        /// your Kubernetes API server. For more information, see <a href="http://docs.aws.amazon.com/eks/latest/userguide/create-kubeconfig.html">Create
        /// a kubeconfig for Amazon EKS</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The API server endpoint and certificate authority data are not available until the
        /// cluster reaches the <code>ACTIVE</code> state.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method.</param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ResourceNotFoundException">
        /// The specified resource could not be found. You can view your available clusters with
        /// <a>ListClusters</a>. Amazon EKS clusters are region-specific.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable, back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        DescribeClusterResponse DescribeCluster(DescribeClusterRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        Task<DescribeClusterResponse> DescribeClusterAsync(DescribeClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListClusters


        /// <summary>
        /// Lists the Amazon EKS clusters in your AWS account in the specified region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by EKS.</returns>
        /// <exception cref="Amazon.EKS.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that is not valid.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.InvalidParameterException">
        /// The specified parameter is invalid. Review the available parameters for the API request.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServerException">
        /// These errors are usually caused by a server-side issue.
        /// </exception>
        /// <exception cref="Amazon.EKS.Model.ServiceUnavailableException">
        /// The service is unavailable, back off and retry the operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListClusters">REST API Reference for ListClusters Operation</seealso>
        ListClustersResponse ListClusters(ListClustersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/eks-2017-11-01/ListClusters">REST API Reference for ListClusters Operation</seealso>
        Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}