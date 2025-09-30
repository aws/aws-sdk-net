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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.DAX.Model;
using Amazon.DAX.Model.Internal.MarshallTransformations;
using Amazon.DAX.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.DAX
{
    /// <summary>
    /// <para>Implementation for accessing DAX</para>
    ///
    /// DAX is a managed caching service engineered for Amazon DynamoDB. DAX dramatically
    /// speeds up database reads by caching frequently-accessed data from DynamoDB, so applications
    /// can access that data with sub-millisecond latency. You can create a DAX cluster easily,
    /// using the Amazon Web Services Management Console. With a few simple modifications
    /// to your code, your application can begin taking advantage of the DAX cluster and realize
    /// significant improvements in read performance.
    /// </summary>
    public partial class AmazonDAXClient : AmazonServiceClient, IAmazonDAX
    {
        private static IServiceMetadata serviceMetadata = new AmazonDAXMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonDAXClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonDAXClient()
            : base(new AmazonDAXConfig()) { }

        /// <summary>
        /// Constructs AmazonDAXClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonDAXClient(RegionEndpoint region)
            : base(new AmazonDAXConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDAXClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonDAXClient Configuration Object</param>
        public AmazonDAXClient(AmazonDAXConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonDAXClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDAXClient(AWSCredentials credentials)
            : this(credentials, new AmazonDAXConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDAXClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDAXClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDAXConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDAXClient with AWS Credentials and an
        /// AmazonDAXClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDAXClient Configuration Object</param>
        public AmazonDAXClient(AWSCredentials credentials, AmazonDAXConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDAXClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDAXClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDAXConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDAXClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDAXClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDAXConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDAXClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDAXClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDAXClient Configuration Object</param>
        public AmazonDAXClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDAXConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDAXClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDAXClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDAXConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDAXClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDAXClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDAXConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDAXClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDAXClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDAXClient Configuration Object</param>
        public AmazonDAXClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDAXConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDAXEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDAXAuthSchemeHandler());
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CreateCluster

        internal virtual CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterResponse>(request, options);
        }



        /// <summary>
        /// Creates a DAX cluster. All nodes in the cluster run the same DAX caching software.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateParameterGroup

        internal virtual CreateParameterGroupResponse CreateParameterGroup(CreateParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a new parameter group. A parameter group is a collection of parameters that
        /// you apply to all of the nodes in a DAX cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateParameterGroupResponse> CreateParameterGroupAsync(CreateParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateParameterGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSubnetGroup

        internal virtual CreateSubnetGroupResponse CreateSubnetGroup(CreateSubnetGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateSubnetGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a new subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateSubnetGroupResponse> CreateSubnetGroupAsync(CreateSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSubnetGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DecreaseReplicationFactor

        internal virtual DecreaseReplicationFactorResponse DecreaseReplicationFactor(DecreaseReplicationFactorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DecreaseReplicationFactorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecreaseReplicationFactorResponseUnmarshaller.Instance;

            return Invoke<DecreaseReplicationFactorResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DecreaseReplicationFactorResponse> DecreaseReplicationFactorAsync(DecreaseReplicationFactorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DecreaseReplicationFactorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecreaseReplicationFactorResponseUnmarshaller.Instance;

            return InvokeAsync<DecreaseReplicationFactorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCluster

        internal virtual DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterResponse>(request, options);
        }



        /// <summary>
        /// Deletes a previously provisioned DAX cluster. <i>DeleteCluster</i> deletes all associated
        /// nodes, node endpoints and the DAX cluster itself. When you receive a successful response
        /// from this action, DAX immediately begins deleting the cluster; you cannot cancel or
        /// revert this action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteParameterGroup

        internal virtual DeleteParameterGroupResponse DeleteParameterGroup(DeleteParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified parameter group. You cannot delete a parameter group if it is
        /// associated with any DAX clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteParameterGroupResponse> DeleteParameterGroupAsync(DeleteParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteParameterGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSubnetGroup

        internal virtual DeleteSubnetGroupResponse DeleteSubnetGroup(DeleteSubnetGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteSubnetGroupResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteSubnetGroupResponse> DeleteSubnetGroupAsync(DeleteSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSubnetGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeClusters

        internal virtual DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeClustersResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClustersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDefaultParameters

        internal virtual DescribeDefaultParametersResponse DescribeDefaultParameters(DescribeDefaultParametersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDefaultParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDefaultParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeDefaultParametersResponse>(request, options);
        }



        /// <summary>
        /// Returns the default system parameter information for the DAX caching software.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeDefaultParametersResponse> DescribeDefaultParametersAsync(DescribeDefaultParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDefaultParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDefaultParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDefaultParametersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeEvents

        internal virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeParameterGroups

        internal virtual DescribeParameterGroupsResponse DescribeParameterGroups(DescribeParameterGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeParameterGroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of parameter group descriptions. If a parameter group name is specified,
        /// the list will contain only the descriptions for that group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameterGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeParameterGroupsResponse> DescribeParameterGroupsAsync(DescribeParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeParameterGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeParameterGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeParameters

        internal virtual DescribeParametersResponse DescribeParameters(DescribeParametersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeParametersResponse>(request, options);
        }



        /// <summary>
        /// Returns the detailed parameter list for a particular parameter group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeParametersResponse> DescribeParametersAsync(DescribeParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeParametersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSubnetGroups

        internal virtual DescribeSubnetGroupsResponse DescribeSubnetGroups(DescribeSubnetGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeSubnetGroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of subnet group descriptions. If a subnet group name is specified,
        /// the list will contain only the description of that group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubnetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSubnetGroups service method, as returned by DAX.</returns>
        /// <exception cref="Amazon.DAX.Model.ServiceLinkedRoleNotFoundException">
        /// The specified service linked role (SLR) was not found.
        /// </exception>
        /// <exception cref="Amazon.DAX.Model.SubnetGroupNotFoundException">
        /// The requested subnet group name does not refer to an existing subnet group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeSubnetGroups">REST API Reference for DescribeSubnetGroups Operation</seealso>
        public virtual Task<DescribeSubnetGroupsResponse> DescribeSubnetGroupsAsync(DescribeSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubnetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSubnetGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  IncreaseReplicationFactor

        internal virtual IncreaseReplicationFactorResponse IncreaseReplicationFactor(IncreaseReplicationFactorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = IncreaseReplicationFactorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IncreaseReplicationFactorResponseUnmarshaller.Instance;

            return Invoke<IncreaseReplicationFactorResponse>(request, options);
        }



        /// <summary>
        /// Adds one or more nodes to a DAX cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IncreaseReplicationFactor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<IncreaseReplicationFactorResponse> IncreaseReplicationFactorAsync(IncreaseReplicationFactorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = IncreaseReplicationFactorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IncreaseReplicationFactorResponseUnmarshaller.Instance;

            return InvokeAsync<IncreaseReplicationFactorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTags

        internal virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }



        /// <summary>
        /// List all of the tags for a DAX cluster. You can call <c>ListTags</c> up to 10 times
        /// per second, per account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RebootNode

        internal virtual RebootNodeResponse RebootNode(RebootNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootNodeResponseUnmarshaller.Instance;

            return Invoke<RebootNodeResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RebootNodeResponse> RebootNodeAsync(RebootNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootNodeResponseUnmarshaller.Instance;

            return InvokeAsync<RebootNodeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Associates a set of tags with a DAX resource. You can call <c>TagResource</c> up to
        /// 5 times per second, per account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes the association of tags from a DAX resource. You can call <c>UntagResource</c>
        /// up to 5 times per second, per account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateCluster

        internal virtual UpdateClusterResponse UpdateCluster(UpdateClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterResponseUnmarshaller.Instance;

            return Invoke<UpdateClusterResponse>(request, options);
        }



        /// <summary>
        /// Modifies the settings for a DAX cluster. You can use this action to change one or
        /// more cluster configuration parameters by specifying the parameters and the new values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateClusterResponse> UpdateClusterAsync(UpdateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateParameterGroup

        internal virtual UpdateParameterGroupResponse UpdateParameterGroup(UpdateParameterGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateParameterGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateParameterGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies the parameters of a parameter group. You can modify up to 20 parameters in
        /// a single request by submitting a list parameter name and value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateParameterGroupResponse> UpdateParameterGroupAsync(UpdateParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateParameterGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSubnetGroup

        internal virtual UpdateSubnetGroupResponse UpdateSubnetGroup(UpdateSubnetGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateSubnetGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies an existing subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateSubnetGroupResponse> UpdateSubnetGroupAsync(UpdateSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSubnetGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}