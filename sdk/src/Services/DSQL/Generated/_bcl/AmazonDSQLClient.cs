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
 * Do not modify this file. This file is generated from the dsql-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.DSQL.Model;
using Amazon.DSQL.Model.Internal.MarshallTransformations;
using Amazon.DSQL.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.DSQL
{
    /// <summary>
    /// <para>Implementation for accessing DSQL</para>
    ///
    /// This is an interface reference for Amazon Aurora DSQL. It contains documentation for
    /// one of the programming or command line interfaces you can use to manage Amazon Aurora
    /// DSQL.
    /// 
    ///  
    /// <para>
    /// Amazon Aurora DSQL is a serverless, distributed SQL database suitable for workloads
    /// of any size. is available in both single-Region and multi-Region configurations, so
    /// your clusters and databases are always available even if an Availability Zone or an
    /// Amazon Web Services Region are unavailable. lets you focus on using your data to acquire
    /// new insights for your business and customers.
    /// </para>
    /// </summary>
    public partial class AmazonDSQLClient : AmazonServiceClient, IAmazonDSQL
    {
        private static IServiceMetadata serviceMetadata = new AmazonDSQLMetadata();
        private IDSQLPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDSQLPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DSQLPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonDSQLClient with the credentials loaded from the application's
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
        public AmazonDSQLClient()
            : base(new AmazonDSQLConfig()) { }

        /// <summary>
        /// Constructs AmazonDSQLClient with the credentials loaded from the application's
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
        public AmazonDSQLClient(RegionEndpoint region)
            : base(new AmazonDSQLConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDSQLClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDSQLClient Configuration Object</param>
        public AmazonDSQLClient(AmazonDSQLConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonDSQLClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDSQLClient(AWSCredentials credentials)
            : this(credentials, new AmazonDSQLConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDSQLClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDSQLClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDSQLConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDSQLClient with AWS Credentials and an
        /// AmazonDSQLClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDSQLClient Configuration Object</param>
        public AmazonDSQLClient(AWSCredentials credentials, AmazonDSQLConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDSQLClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDSQLClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDSQLConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDSQLClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDSQLClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDSQLConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDSQLClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDSQLClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDSQLClient Configuration Object</param>
        public AmazonDSQLClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDSQLConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDSQLClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDSQLClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDSQLConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDSQLClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDSQLClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDSQLConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDSQLClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDSQLClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDSQLClient Configuration Object</param>
        public AmazonDSQLClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDSQLConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDSQLEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDSQLAuthSchemeHandler());
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


        /// <summary>
        /// The CreateCluster API allows you to create both single-region clusters and multi-Region
        /// clusters. With the addition of the <i>multiRegionProperties</i> parameter, you can
        /// create a cluster with witness Region support and establish peer relationships with
        /// clusters in other Regions during creation.
        /// 
        ///  <note> 
        /// <para>
        /// Creating multi-Region clusters requires additional IAM permissions beyond those needed
        /// for single-Region clusters, as detailed in the <b>Required permissions</b> section
        /// below.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <dl> <dt>dsql:CreateCluster</dt> <dd> 
        /// <para>
        /// Required to create a cluster.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:region:account-id:cluster/*</c> 
        /// </para>
        ///  </dd> <dt>dsql:TagResource</dt> <dd> 
        /// <para>
        /// Permission to add tags to a resource.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:region:account-id:cluster/*</c> 
        /// </para>
        ///  </dd> <dt>dsql:PutMultiRegionProperties</dt> <dd> 
        /// <para>
        /// Permission to configure multi-region properties for a cluster.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:region:account-id:cluster/*</c> 
        /// </para>
        ///  </dd> <dt>dsql:AddPeerCluster</dt> <dd> 
        /// <para>
        /// When specifying <c>multiRegionProperties.clusters</c>, permission to add peer clusters.
        /// </para>
        ///  
        /// <para>
        /// Resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Local cluster: <c>arn:aws:dsql:region:account-id:cluster/*</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each peer cluster: exact ARN of each specified peer cluster
        /// </para>
        ///  </li> </ul> </dd> <dt>dsql:PutWitnessRegion</dt> <dd> 
        /// <para>
        /// When specifying <c>multiRegionProperties.witnessRegion</c>, permission to set a witness
        /// Region. This permission is checked both in the cluster Region and in the witness Region.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:region:account-id:cluster/*</c> 
        /// </para>
        ///  
        /// <para>
        /// Condition Keys: <c>dsql:WitnessRegion</c> (matching the specified witness region)
        /// </para>
        ///  </dd> </dl> <important> <ul> <li> 
        /// <para>
        /// The witness Region specified in <c>multiRegionProperties.witnessRegion</c> cannot
        /// be the same as the cluster's Region.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterResponse>(request, options);
        }


        /// <summary>
        /// The CreateCluster API allows you to create both single-region clusters and multi-Region
        /// clusters. With the addition of the <i>multiRegionProperties</i> parameter, you can
        /// create a cluster with witness Region support and establish peer relationships with
        /// clusters in other Regions during creation.
        /// 
        ///  <note> 
        /// <para>
        /// Creating multi-Region clusters requires additional IAM permissions beyond those needed
        /// for single-Region clusters, as detailed in the <b>Required permissions</b> section
        /// below.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <dl> <dt>dsql:CreateCluster</dt> <dd> 
        /// <para>
        /// Required to create a cluster.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:region:account-id:cluster/*</c> 
        /// </para>
        ///  </dd> <dt>dsql:TagResource</dt> <dd> 
        /// <para>
        /// Permission to add tags to a resource.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:region:account-id:cluster/*</c> 
        /// </para>
        ///  </dd> <dt>dsql:PutMultiRegionProperties</dt> <dd> 
        /// <para>
        /// Permission to configure multi-region properties for a cluster.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:region:account-id:cluster/*</c> 
        /// </para>
        ///  </dd> <dt>dsql:AddPeerCluster</dt> <dd> 
        /// <para>
        /// When specifying <c>multiRegionProperties.clusters</c>, permission to add peer clusters.
        /// </para>
        ///  
        /// <para>
        /// Resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Local cluster: <c>arn:aws:dsql:region:account-id:cluster/*</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each peer cluster: exact ARN of each specified peer cluster
        /// </para>
        ///  </li> </ul> </dd> <dt>dsql:PutWitnessRegion</dt> <dd> 
        /// <para>
        /// When specifying <c>multiRegionProperties.witnessRegion</c>, permission to set a witness
        /// Region. This permission is checked both in the cluster Region and in the witness Region.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:region:account-id:cluster/*</c> 
        /// </para>
        ///  
        /// <para>
        /// Condition Keys: <c>dsql:WitnessRegion</c> (matching the specified witness region)
        /// </para>
        ///  </dd> </dl> <important> <ul> <li> 
        /// <para>
        /// The witness Region specified in <c>multiRegionProperties.witnessRegion</c> cannot
        /// be the same as the cluster's Region.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCluster


        /// <summary>
        /// Deletes a cluster in Amazon Aurora DSQL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterResponse>(request, options);
        }


        /// <summary>
        /// Deletes a cluster in Amazon Aurora DSQL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCluster


        /// <summary>
        /// Retrieves information about a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCluster service method.</param>
        /// 
        /// <returns>The response from the GetCluster service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/GetCluster">REST API Reference for GetCluster Operation</seealso>
        public virtual GetClusterResponse GetCluster(GetClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterResponseUnmarshaller.Instance;

            return Invoke<GetClusterResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCluster service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/GetCluster">REST API Reference for GetCluster Operation</seealso>
        public virtual Task<GetClusterResponse> GetClusterAsync(GetClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVpcEndpointServiceName


        /// <summary>
        /// Retrieves the VPC endpoint service name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcEndpointServiceName service method.</param>
        /// 
        /// <returns>The response from the GetVpcEndpointServiceName service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/GetVpcEndpointServiceName">REST API Reference for GetVpcEndpointServiceName Operation</seealso>
        public virtual GetVpcEndpointServiceNameResponse GetVpcEndpointServiceName(GetVpcEndpointServiceNameRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVpcEndpointServiceNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcEndpointServiceNameResponseUnmarshaller.Instance;

            return Invoke<GetVpcEndpointServiceNameResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the VPC endpoint service name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcEndpointServiceName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVpcEndpointServiceName service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/GetVpcEndpointServiceName">REST API Reference for GetVpcEndpointServiceName Operation</seealso>
        public virtual Task<GetVpcEndpointServiceNameResponse> GetVpcEndpointServiceNameAsync(GetVpcEndpointServiceNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetVpcEndpointServiceNameRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcEndpointServiceNameResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetVpcEndpointServiceNameResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListClusters


        /// <summary>
        /// Retrieves information about a list of clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return Invoke<ListClustersResponse>(request, options);
        }


        /// <summary>
        /// Retrieves information about a list of clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListClustersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all of the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists all of the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags a resource with a map of key and value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Tags a resource with a map of key and value pairs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCluster


        /// <summary>
        /// The <i>UpdateCluster</i> API allows you to modify both single-Region and multi-Region
        /// cluster configurations. With the <i>multiRegionProperties</i> parameter, you can add
        /// or modify witness Region support and manage peer relationships with clusters in other
        /// Regions.
        /// 
        ///  <note> 
        /// <para>
        /// Note that updating multi-region clusters requires additional IAM permissions beyond
        /// those needed for standard cluster updates, as detailed in the Permissions section.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <dl> <dt>dsql:UpdateCluster</dt> <dd> 
        /// <para>
        /// Permission to update a DSQL cluster.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/<i>cluster-id</i>
        /// </c> 
        /// </para>
        ///  </dd> </dl> <dl> <dt>dsql:PutMultiRegionProperties</dt> <dd> 
        /// <para>
        /// Permission to configure multi-Region properties for a cluster.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/<i>cluster-id</i>
        /// </c> 
        /// </para>
        ///  </dd> </dl> <dl> <dt>dsql:GetCluster</dt> <dd> 
        /// <para>
        /// Permission to retrieve cluster information.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/<i>cluster-id</i>
        /// </c> 
        /// </para>
        ///  </dd> <dt>dsql:AddPeerCluster</dt> <dd> 
        /// <para>
        /// Permission to add peer clusters.
        /// </para>
        ///  
        /// <para>
        /// Resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Local cluster: <c>arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/<i>cluster-id</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each peer cluster: exact ARN of each specified peer cluster
        /// </para>
        ///  </li> </ul> </dd> <dt>dsql:RemovePeerCluster</dt> <dd> 
        /// <para>
        /// Permission to remove peer clusters. The <i>dsql:RemovePeerCluster</i> permission uses
        /// a wildcard ARN pattern to simplify permission management during updates.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:*:<i>account-id</i>:cluster/*</c> 
        /// </para>
        ///  </dd> </dl> <dl> <dt>dsql:PutWitnessRegion</dt> <dd> 
        /// <para>
        /// Permission to set a witness Region.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/<i>cluster-id</i>
        /// </c> 
        /// </para>
        ///  
        /// <para>
        /// Condition Keys: dsql:WitnessRegion (matching the specified witness Region)
        /// </para>
        ///  
        /// <para>
        ///  <b>This permission is checked both in the cluster Region and in the witness Region.</b>
        /// 
        /// </para>
        ///  </dd> </dl> <important> <ul> <li> 
        /// <para>
        /// The witness region specified in <c>multiRegionProperties.witnessRegion</c> cannot
        /// be the same as the cluster's Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When updating clusters with peer relationships, permissions are checked for both adding
        /// and removing peers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>dsql:RemovePeerCluster</c> permission uses a wildcard ARN pattern to simplify
        /// permission management during updates.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster service method.</param>
        /// 
        /// <returns>The response from the UpdateCluster service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        public virtual UpdateClusterResponse UpdateCluster(UpdateClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterResponseUnmarshaller.Instance;

            return Invoke<UpdateClusterResponse>(request, options);
        }


        /// <summary>
        /// The <i>UpdateCluster</i> API allows you to modify both single-Region and multi-Region
        /// cluster configurations. With the <i>multiRegionProperties</i> parameter, you can add
        /// or modify witness Region support and manage peer relationships with clusters in other
        /// Regions.
        /// 
        ///  <note> 
        /// <para>
        /// Note that updating multi-region clusters requires additional IAM permissions beyond
        /// those needed for standard cluster updates, as detailed in the Permissions section.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <dl> <dt>dsql:UpdateCluster</dt> <dd> 
        /// <para>
        /// Permission to update a DSQL cluster.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/<i>cluster-id</i>
        /// </c> 
        /// </para>
        ///  </dd> </dl> <dl> <dt>dsql:PutMultiRegionProperties</dt> <dd> 
        /// <para>
        /// Permission to configure multi-Region properties for a cluster.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/<i>cluster-id</i>
        /// </c> 
        /// </para>
        ///  </dd> </dl> <dl> <dt>dsql:GetCluster</dt> <dd> 
        /// <para>
        /// Permission to retrieve cluster information.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/<i>cluster-id</i>
        /// </c> 
        /// </para>
        ///  </dd> <dt>dsql:AddPeerCluster</dt> <dd> 
        /// <para>
        /// Permission to add peer clusters.
        /// </para>
        ///  
        /// <para>
        /// Resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Local cluster: <c>arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/<i>cluster-id</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each peer cluster: exact ARN of each specified peer cluster
        /// </para>
        ///  </li> </ul> </dd> <dt>dsql:RemovePeerCluster</dt> <dd> 
        /// <para>
        /// Permission to remove peer clusters. The <i>dsql:RemovePeerCluster</i> permission uses
        /// a wildcard ARN pattern to simplify permission management during updates.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:*:<i>account-id</i>:cluster/*</c> 
        /// </para>
        ///  </dd> </dl> <dl> <dt>dsql:PutWitnessRegion</dt> <dd> 
        /// <para>
        /// Permission to set a witness Region.
        /// </para>
        ///  
        /// <para>
        /// Resources: <c>arn:aws:dsql:<i>region</i>:<i>account-id</i>:cluster/<i>cluster-id</i>
        /// </c> 
        /// </para>
        ///  
        /// <para>
        /// Condition Keys: dsql:WitnessRegion (matching the specified witness Region)
        /// </para>
        ///  
        /// <para>
        ///  <b>This permission is checked both in the cluster Region and in the witness Region.</b>
        /// 
        /// </para>
        ///  </dd> </dl> <important> <ul> <li> 
        /// <para>
        /// The witness region specified in <c>multiRegionProperties.witnessRegion</c> cannot
        /// be the same as the cluster's Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When updating clusters with peer relationships, permissions are checked for both adding
        /// and removing peers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>dsql:RemovePeerCluster</c> permission uses a wildcard ARN pattern to simplify
        /// permission management during updates.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCluster service method, as returned by DSQL.</returns>
        /// <exception cref="Amazon.DSQL.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DSQL.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dsql-2018-05-10/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        public virtual Task<UpdateClusterResponse> UpdateClusterAsync(UpdateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateClusterResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateClusterResponse>(request, options, cancellationToken);
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