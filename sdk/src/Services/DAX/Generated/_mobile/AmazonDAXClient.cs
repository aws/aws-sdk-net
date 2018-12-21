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

namespace Amazon.DAX
{
    /// <summary>
    /// Implementation for accessing DAX
    ///
    /// DAX is a managed caching service engineered for Amazon DynamoDB. DAX dramatically
    /// speeds up database reads by caching frequently-accessed data from DynamoDB, so applications
    /// can access that data with sub-millisecond latency. You can create a DAX cluster easily,
    /// using the AWS Management Console. With a few simple modifications to your code, your
    /// application can begin taking advantage of the DAX cluster and realize significant
    /// improvements in read performance.
    /// </summary>
    public partial class AmazonDAXClient : AmazonServiceClient, IAmazonDAX
    {
        private static IServiceMetadata serviceMetadata = new AmazonDAXMetadata();
        
        #region Constructors

#if CORECLR
    
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDAXConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDAXConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

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
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateParameterGroup

        internal virtual CreateParameterGroupResponse CreateParameterGroup(CreateParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateParameterGroupResponseUnmarshaller.Instance;

            return Invoke<CreateParameterGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/CreateParameterGroup">REST API Reference for CreateParameterGroup Operation</seealso>
        public virtual Task<CreateParameterGroupResponse> CreateParameterGroupAsync(CreateParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSubnetGroup

        internal virtual CreateSubnetGroupResponse CreateSubnetGroup(CreateSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateSubnetGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/CreateSubnetGroup">REST API Reference for CreateSubnetGroup Operation</seealso>
        public virtual Task<CreateSubnetGroupResponse> CreateSubnetGroupAsync(CreateSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSubnetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DecreaseReplicationFactor

        internal virtual DecreaseReplicationFactorResponse DecreaseReplicationFactor(DecreaseReplicationFactorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecreaseReplicationFactorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecreaseReplicationFactorResponseUnmarshaller.Instance;

            return Invoke<DecreaseReplicationFactorResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DecreaseReplicationFactor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DecreaseReplicationFactor operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DecreaseReplicationFactor">REST API Reference for DecreaseReplicationFactor Operation</seealso>
        public virtual Task<DecreaseReplicationFactorResponse> DecreaseReplicationFactorAsync(DecreaseReplicationFactorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecreaseReplicationFactorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecreaseReplicationFactorResponseUnmarshaller.Instance;

            return InvokeAsync<DecreaseReplicationFactorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCluster

        internal virtual DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteParameterGroup

        internal virtual DeleteParameterGroupResponse DeleteParameterGroup(DeleteParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteParameterGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteParameterGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DeleteParameterGroup">REST API Reference for DeleteParameterGroup Operation</seealso>
        public virtual Task<DeleteParameterGroupResponse> DeleteParameterGroupAsync(DeleteParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSubnetGroup

        internal virtual DeleteSubnetGroupResponse DeleteSubnetGroup(DeleteSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteSubnetGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DeleteSubnetGroup">REST API Reference for DeleteSubnetGroup Operation</seealso>
        public virtual Task<DeleteSubnetGroupResponse> DeleteSubnetGroupAsync(DeleteSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSubnetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClusters

        internal virtual DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return Invoke<DescribeClustersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        public virtual Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClustersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClustersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDefaultParameters

        internal virtual DescribeDefaultParametersResponse DescribeDefaultParameters(DescribeDefaultParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDefaultParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDefaultParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeDefaultParametersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDefaultParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeDefaultParameters">REST API Reference for DescribeDefaultParameters Operation</seealso>
        public virtual Task<DescribeDefaultParametersResponse> DescribeDefaultParametersAsync(DescribeDefaultParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDefaultParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDefaultParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDefaultParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEvents

        internal virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeParameterGroups

        internal virtual DescribeParameterGroupsResponse DescribeParameterGroups(DescribeParameterGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeParameterGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeParameterGroupsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeParameterGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameterGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeParameterGroups">REST API Reference for DescribeParameterGroups Operation</seealso>
        public virtual Task<DescribeParameterGroupsResponse> DescribeParameterGroupsAsync(DescribeParameterGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeParameterGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeParameterGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeParameterGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeParameters

        internal virtual DescribeParametersResponse DescribeParameters(DescribeParametersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeParametersResponseUnmarshaller.Instance;

            return Invoke<DescribeParametersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeParameters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeParameters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeParameters">REST API Reference for DescribeParameters Operation</seealso>
        public virtual Task<DescribeParametersResponse> DescribeParametersAsync(DescribeParametersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeParametersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeParametersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeParametersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSubnetGroups

        internal virtual DescribeSubnetGroupsResponse DescribeSubnetGroups(DescribeSubnetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeSubnetGroupsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/DescribeSubnetGroups">REST API Reference for DescribeSubnetGroups Operation</seealso>
        public virtual Task<DescribeSubnetGroupsResponse> DescribeSubnetGroupsAsync(DescribeSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubnetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubnetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSubnetGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  IncreaseReplicationFactor

        internal virtual IncreaseReplicationFactorResponse IncreaseReplicationFactor(IncreaseReplicationFactorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IncreaseReplicationFactorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IncreaseReplicationFactorResponseUnmarshaller.Instance;

            return Invoke<IncreaseReplicationFactorResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the IncreaseReplicationFactor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IncreaseReplicationFactor operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/IncreaseReplicationFactor">REST API Reference for IncreaseReplicationFactor Operation</seealso>
        public virtual Task<IncreaseReplicationFactorResponse> IncreaseReplicationFactorAsync(IncreaseReplicationFactorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IncreaseReplicationFactorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IncreaseReplicationFactorResponseUnmarshaller.Instance;

            return InvokeAsync<IncreaseReplicationFactorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTags

        internal virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebootNode

        internal virtual RebootNodeResponse RebootNode(RebootNodeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootNodeResponseUnmarshaller.Instance;

            return Invoke<RebootNodeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RebootNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootNode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/RebootNode">REST API Reference for RebootNode Operation</seealso>
        public virtual Task<RebootNodeResponse> RebootNodeAsync(RebootNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootNodeResponseUnmarshaller.Instance;

            return InvokeAsync<RebootNodeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCluster

        internal virtual UpdateClusterResponse UpdateCluster(UpdateClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterResponseUnmarshaller.Instance;

            return Invoke<UpdateClusterResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        public virtual Task<UpdateClusterResponse> UpdateClusterAsync(UpdateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateParameterGroup

        internal virtual UpdateParameterGroupResponse UpdateParameterGroup(UpdateParameterGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateParameterGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateParameterGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateParameterGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateParameterGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/UpdateParameterGroup">REST API Reference for UpdateParameterGroup Operation</seealso>
        public virtual Task<UpdateParameterGroupResponse> UpdateParameterGroupAsync(UpdateParameterGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateParameterGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateParameterGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateParameterGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSubnetGroup

        internal virtual UpdateSubnetGroupResponse UpdateSubnetGroup(UpdateSubnetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateSubnetGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dax-2017-04-19/UpdateSubnetGroup">REST API Reference for UpdateSubnetGroup Operation</seealso>
        public virtual Task<UpdateSubnetGroupResponse> UpdateSubnetGroupAsync(UpdateSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubnetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSubnetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}