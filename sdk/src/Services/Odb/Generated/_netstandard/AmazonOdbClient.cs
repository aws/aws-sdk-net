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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Odb.Model;
using Amazon.Odb.Model.Internal.MarshallTransformations;
using Amazon.Odb.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Odb
{
    /// <summary>
    /// <para>Implementation for accessing Odb</para>
    ///
    /// Oracle Database@Amazon Web Services is an offering that enables you to access Oracle
    /// Exadata infrastructure managed by Oracle Cloud Infrastructure (OCI) inside Amazon
    /// Web Services data centers. You can migrate your Oracle Exadata workloads, establish
    /// low-latency connectivity with applications running on Amazon Web Services, and integrate
    /// with Amazon Web Services services. For example, you can run application servers in
    /// a virtual private cloud (VPC) and access an Oracle Exadata system running in Oracle
    /// Database@Amazon Web Services. You can get started with Oracle Database@Amazon Web
    /// Services by using the familiar Amazon Web Services Management Console, APIs, or CLI.
    /// 
    ///  
    /// <para>
    /// This interface reference for Oracle Database@Amazon Web Services contains documentation
    /// for a programming or command line interface that you can use to manage Oracle Database@Amazon
    /// Web Services. Oracle Database@Amazon Web Services is asynchronous, which means that
    /// some interfaces might require techniques such as polling or callback functions to
    /// determine when a command has been applied. The reference structure is as follows.
    /// </para>
    ///  <note> 
    /// <para>
    /// In this preview release documentation, the links in the "See Also" sections do not
    /// work.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Oracle Database@Amazon Web Services API Reference</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For the alphabetical list of API actions, see .
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For the alphabetical list of data types, see .
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For a list of common parameters, see <a>CommonParameters</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For descriptions of the error codes, see <a>CommonErrors</a>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonOdbClient : AmazonServiceClient, IAmazonOdb
    {
        private static IServiceMetadata serviceMetadata = new AmazonOdbMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonOdbClient with the credentials loaded from the application's
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
        public AmazonOdbClient()
            : base(new AmazonOdbConfig()) { }

        /// <summary>
        /// Constructs AmazonOdbClient with the credentials loaded from the application's
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
        public AmazonOdbClient(RegionEndpoint region)
            : base(new AmazonOdbConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonOdbClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonOdbClient Configuration Object</param>
        public AmazonOdbClient(AmazonOdbConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonOdbClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonOdbClient(AWSCredentials credentials)
            : this(credentials, new AmazonOdbConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOdbClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonOdbConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Credentials and an
        /// AmazonOdbClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonOdbClient Configuration Object</param>
        public AmazonOdbClient(AWSCredentials credentials, AmazonOdbConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonOdbClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOdbConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOdbClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonOdbConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOdbClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonOdbClient Configuration Object</param>
        public AmazonOdbClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonOdbConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonOdbClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOdbConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonOdbClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonOdbConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonOdbClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonOdbClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonOdbClient Configuration Object</param>
        public AmazonOdbClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonOdbConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IOdbPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IOdbPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new OdbPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonOdbEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonOdbAuthSchemeHandler());
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


        #region  AcceptMarketplaceRegistration

        internal virtual AcceptMarketplaceRegistrationResponse AcceptMarketplaceRegistration(AcceptMarketplaceRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptMarketplaceRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptMarketplaceRegistrationResponseUnmarshaller.Instance;

            return Invoke<AcceptMarketplaceRegistrationResponse>(request, options);
        }



        /// <summary>
        /// Registers the Amazon Web Services Marketplace token for your Amazon Web Services account
        /// to activate your Oracle Database@Amazon Web Services subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptMarketplaceRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptMarketplaceRegistration service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/AcceptMarketplaceRegistration">REST API Reference for AcceptMarketplaceRegistration Operation</seealso>
        public virtual Task<AcceptMarketplaceRegistrationResponse> AcceptMarketplaceRegistrationAsync(AcceptMarketplaceRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptMarketplaceRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptMarketplaceRegistrationResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptMarketplaceRegistrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCloudAutonomousVmCluster

        internal virtual CreateCloudAutonomousVmClusterResponse CreateCloudAutonomousVmCluster(CreateCloudAutonomousVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudAutonomousVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudAutonomousVmClusterResponseUnmarshaller.Instance;

            return Invoke<CreateCloudAutonomousVmClusterResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Autonomous VM cluster in the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudAutonomousVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCloudAutonomousVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudAutonomousVmCluster">REST API Reference for CreateCloudAutonomousVmCluster Operation</seealso>
        public virtual Task<CreateCloudAutonomousVmClusterResponse> CreateCloudAutonomousVmClusterAsync(CreateCloudAutonomousVmClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudAutonomousVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudAutonomousVmClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCloudAutonomousVmClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCloudExadataInfrastructure

        internal virtual CreateCloudExadataInfrastructureResponse CreateCloudExadataInfrastructure(CreateCloudExadataInfrastructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return Invoke<CreateCloudExadataInfrastructureResponse>(request, options);
        }



        /// <summary>
        /// Creates an Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudExadataInfrastructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudExadataInfrastructure">REST API Reference for CreateCloudExadataInfrastructure Operation</seealso>
        public virtual Task<CreateCloudExadataInfrastructureResponse> CreateCloudExadataInfrastructureAsync(CreateCloudExadataInfrastructureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCloudExadataInfrastructureResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateCloudVmCluster

        internal virtual CreateCloudVmClusterResponse CreateCloudVmCluster(CreateCloudVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudVmClusterResponseUnmarshaller.Instance;

            return Invoke<CreateCloudVmClusterResponse>(request, options);
        }



        /// <summary>
        /// Creates a VM cluster on the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCloudVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateCloudVmCluster">REST API Reference for CreateCloudVmCluster Operation</seealso>
        public virtual Task<CreateCloudVmClusterResponse> CreateCloudVmClusterAsync(CreateCloudVmClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCloudVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCloudVmClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCloudVmClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateOdbNetwork

        internal virtual CreateOdbNetworkResponse CreateOdbNetwork(CreateOdbNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOdbNetworkResponseUnmarshaller.Instance;

            return Invoke<CreateOdbNetworkResponse>(request, options);
        }



        /// <summary>
        /// Creates an ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOdbNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOdbNetwork service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateOdbNetwork">REST API Reference for CreateOdbNetwork Operation</seealso>
        public virtual Task<CreateOdbNetworkResponse> CreateOdbNetworkAsync(CreateOdbNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOdbNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOdbNetworkResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateOdbPeeringConnection

        internal virtual CreateOdbPeeringConnectionResponse CreateOdbPeeringConnection(CreateOdbPeeringConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOdbPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateOdbPeeringConnectionResponse>(request, options);
        }



        /// <summary>
        /// Creates a peering connection between an ODB network and either another ODB network
        /// or a customer-owned VPC.
        /// 
        ///  
        /// <para>
        /// A peering connection enables private connectivity between the networks for application-tier
        /// communication.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOdbPeeringConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOdbPeeringConnection service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/CreateOdbPeeringConnection">REST API Reference for CreateOdbPeeringConnection Operation</seealso>
        public virtual Task<CreateOdbPeeringConnectionResponse> CreateOdbPeeringConnectionAsync(CreateOdbPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOdbPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOdbPeeringConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCloudAutonomousVmCluster

        internal virtual DeleteCloudAutonomousVmClusterResponse DeleteCloudAutonomousVmCluster(DeleteCloudAutonomousVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudAutonomousVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudAutonomousVmClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteCloudAutonomousVmClusterResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Autonomous VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudAutonomousVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCloudAutonomousVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudAutonomousVmCluster">REST API Reference for DeleteCloudAutonomousVmCluster Operation</seealso>
        public virtual Task<DeleteCloudAutonomousVmClusterResponse> DeleteCloudAutonomousVmClusterAsync(DeleteCloudAutonomousVmClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudAutonomousVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudAutonomousVmClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCloudAutonomousVmClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCloudExadataInfrastructure

        internal virtual DeleteCloudExadataInfrastructureResponse DeleteCloudExadataInfrastructure(DeleteCloudExadataInfrastructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return Invoke<DeleteCloudExadataInfrastructureResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified Exadata infrastructure. Before you use this operation, make
        /// sure to delete all of the VM clusters that are hosted on this Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudExadataInfrastructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudExadataInfrastructure">REST API Reference for DeleteCloudExadataInfrastructure Operation</seealso>
        public virtual Task<DeleteCloudExadataInfrastructureResponse> DeleteCloudExadataInfrastructureAsync(DeleteCloudExadataInfrastructureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCloudExadataInfrastructureResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCloudVmCluster

        internal virtual DeleteCloudVmClusterResponse DeleteCloudVmCluster(DeleteCloudVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudVmClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteCloudVmClusterResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCloudVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteCloudVmCluster">REST API Reference for DeleteCloudVmCluster Operation</seealso>
        public virtual Task<DeleteCloudVmClusterResponse> DeleteCloudVmClusterAsync(DeleteCloudVmClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCloudVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCloudVmClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCloudVmClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteOdbNetwork

        internal virtual DeleteOdbNetworkResponse DeleteOdbNetwork(DeleteOdbNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOdbNetworkResponseUnmarshaller.Instance;

            return Invoke<DeleteOdbNetworkResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOdbNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOdbNetwork service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteOdbNetwork">REST API Reference for DeleteOdbNetwork Operation</seealso>
        public virtual Task<DeleteOdbNetworkResponse> DeleteOdbNetworkAsync(DeleteOdbNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOdbNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOdbNetworkResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteOdbPeeringConnection

        internal virtual DeleteOdbPeeringConnectionResponse DeleteOdbPeeringConnection(DeleteOdbPeeringConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOdbPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteOdbPeeringConnectionResponse>(request, options);
        }



        /// <summary>
        /// Deletes an ODB peering connection.
        /// 
        ///  
        /// <para>
        /// When you delete an ODB peering connection, the underlying VPC peering connection is
        /// also deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOdbPeeringConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOdbPeeringConnection service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/DeleteOdbPeeringConnection">REST API Reference for DeleteOdbPeeringConnection Operation</seealso>
        public virtual Task<DeleteOdbPeeringConnectionResponse> DeleteOdbPeeringConnectionAsync(DeleteOdbPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOdbPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOdbPeeringConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCloudAutonomousVmCluster

        internal virtual GetCloudAutonomousVmClusterResponse GetCloudAutonomousVmCluster(GetCloudAutonomousVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudAutonomousVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudAutonomousVmClusterResponseUnmarshaller.Instance;

            return Invoke<GetCloudAutonomousVmClusterResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a specific Autonomous VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudAutonomousVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCloudAutonomousVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudAutonomousVmCluster">REST API Reference for GetCloudAutonomousVmCluster Operation</seealso>
        public virtual Task<GetCloudAutonomousVmClusterResponse> GetCloudAutonomousVmClusterAsync(GetCloudAutonomousVmClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudAutonomousVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudAutonomousVmClusterResponseUnmarshaller.Instance;

            return InvokeAsync<GetCloudAutonomousVmClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCloudExadataInfrastructure

        internal virtual GetCloudExadataInfrastructureResponse GetCloudExadataInfrastructure(GetCloudExadataInfrastructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return Invoke<GetCloudExadataInfrastructureResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudExadataInfrastructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudExadataInfrastructure">REST API Reference for GetCloudExadataInfrastructure Operation</seealso>
        public virtual Task<GetCloudExadataInfrastructureResponse> GetCloudExadataInfrastructureAsync(GetCloudExadataInfrastructureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return InvokeAsync<GetCloudExadataInfrastructureResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCloudExadataInfrastructureUnallocatedResources

        internal virtual GetCloudExadataInfrastructureUnallocatedResourcesResponse GetCloudExadataInfrastructureUnallocatedResources(GetCloudExadataInfrastructureUnallocatedResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudExadataInfrastructureUnallocatedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudExadataInfrastructureUnallocatedResourcesResponseUnmarshaller.Instance;

            return Invoke<GetCloudExadataInfrastructureUnallocatedResourcesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about unallocated resources in a specified Cloud Exadata Infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudExadataInfrastructureUnallocatedResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCloudExadataInfrastructureUnallocatedResources service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudExadataInfrastructureUnallocatedResources">REST API Reference for GetCloudExadataInfrastructureUnallocatedResources Operation</seealso>
        public virtual Task<GetCloudExadataInfrastructureUnallocatedResourcesResponse> GetCloudExadataInfrastructureUnallocatedResourcesAsync(GetCloudExadataInfrastructureUnallocatedResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudExadataInfrastructureUnallocatedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudExadataInfrastructureUnallocatedResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<GetCloudExadataInfrastructureUnallocatedResourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCloudVmCluster

        internal virtual GetCloudVmClusterResponse GetCloudVmCluster(GetCloudVmClusterRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudVmClusterResponseUnmarshaller.Instance;

            return Invoke<GetCloudVmClusterResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the specified VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudVmCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCloudVmCluster service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetCloudVmCluster">REST API Reference for GetCloudVmCluster Operation</seealso>
        public virtual Task<GetCloudVmClusterResponse> GetCloudVmClusterAsync(GetCloudVmClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCloudVmClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCloudVmClusterResponseUnmarshaller.Instance;

            return InvokeAsync<GetCloudVmClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDbNode

        internal virtual GetDbNodeResponse GetDbNode(GetDbNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDbNodeResponseUnmarshaller.Instance;

            return Invoke<GetDbNodeResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the specified DB node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDbNode service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetDbNode">REST API Reference for GetDbNode Operation</seealso>
        public virtual Task<GetDbNodeResponse> GetDbNodeAsync(GetDbNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDbNodeResponseUnmarshaller.Instance;

            return InvokeAsync<GetDbNodeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetDbServer

        internal virtual GetDbServerResponse GetDbServer(GetDbServerRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDbServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDbServerResponseUnmarshaller.Instance;

            return Invoke<GetDbServerResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the specified database server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDbServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDbServer service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetDbServer">REST API Reference for GetDbServer Operation</seealso>
        public virtual Task<GetDbServerResponse> GetDbServerAsync(GetDbServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDbServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDbServerResponseUnmarshaller.Instance;

            return InvokeAsync<GetDbServerResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetOciOnboardingStatus

        internal virtual GetOciOnboardingStatusResponse GetOciOnboardingStatus(GetOciOnboardingStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOciOnboardingStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOciOnboardingStatusResponseUnmarshaller.Instance;

            return Invoke<GetOciOnboardingStatusResponse>(request, options);
        }



        /// <summary>
        /// Returns the tenancy activation link and onboarding status for your Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOciOnboardingStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOciOnboardingStatus service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOciOnboardingStatus">REST API Reference for GetOciOnboardingStatus Operation</seealso>
        public virtual Task<GetOciOnboardingStatusResponse> GetOciOnboardingStatusAsync(GetOciOnboardingStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOciOnboardingStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOciOnboardingStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetOciOnboardingStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetOdbNetwork

        internal virtual GetOdbNetworkResponse GetOdbNetwork(GetOdbNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOdbNetworkResponseUnmarshaller.Instance;

            return Invoke<GetOdbNetworkResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the specified ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOdbNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOdbNetwork service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOdbNetwork">REST API Reference for GetOdbNetwork Operation</seealso>
        public virtual Task<GetOdbNetworkResponse> GetOdbNetworkAsync(GetOdbNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOdbNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<GetOdbNetworkResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetOdbPeeringConnection

        internal virtual GetOdbPeeringConnectionResponse GetOdbPeeringConnection(GetOdbPeeringConnectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOdbPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<GetOdbPeeringConnectionResponse>(request, options);
        }



        /// <summary>
        /// Retrieves information about an ODB peering connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOdbPeeringConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOdbPeeringConnection service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/GetOdbPeeringConnection">REST API Reference for GetOdbPeeringConnection Operation</seealso>
        public virtual Task<GetOdbPeeringConnectionResponse> GetOdbPeeringConnectionAsync(GetOdbPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetOdbPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOdbPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<GetOdbPeeringConnectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  InitializeService

        internal virtual InitializeServiceResponse InitializeService(InitializeServiceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InitializeServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitializeServiceResponseUnmarshaller.Instance;

            return Invoke<InitializeServiceResponse>(request, options);
        }



        /// <summary>
        /// Initializes the ODB service for the first time in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitializeService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InitializeService service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/InitializeService">REST API Reference for InitializeService Operation</seealso>
        public virtual Task<InitializeServiceResponse> InitializeServiceAsync(InitializeServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InitializeServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitializeServiceResponseUnmarshaller.Instance;

            return InvokeAsync<InitializeServiceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAutonomousVirtualMachines

        internal virtual ListAutonomousVirtualMachinesResponse ListAutonomousVirtualMachines(ListAutonomousVirtualMachinesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousVirtualMachinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousVirtualMachinesResponseUnmarshaller.Instance;

            return Invoke<ListAutonomousVirtualMachinesResponse>(request, options);
        }



        /// <summary>
        /// Lists all Autonomous VMs in an Autonomous VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAutonomousVirtualMachines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAutonomousVirtualMachines service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListAutonomousVirtualMachines">REST API Reference for ListAutonomousVirtualMachines Operation</seealso>
        public virtual Task<ListAutonomousVirtualMachinesResponse> ListAutonomousVirtualMachinesAsync(ListAutonomousVirtualMachinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAutonomousVirtualMachinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAutonomousVirtualMachinesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAutonomousVirtualMachinesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCloudAutonomousVmClusters

        internal virtual ListCloudAutonomousVmClustersResponse ListCloudAutonomousVmClusters(ListCloudAutonomousVmClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudAutonomousVmClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudAutonomousVmClustersResponseUnmarshaller.Instance;

            return Invoke<ListCloudAutonomousVmClustersResponse>(request, options);
        }



        /// <summary>
        /// Lists all Autonomous VM clusters in a specified Cloud Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudAutonomousVmClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCloudAutonomousVmClusters service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudAutonomousVmClusters">REST API Reference for ListCloudAutonomousVmClusters Operation</seealso>
        public virtual Task<ListCloudAutonomousVmClustersResponse> ListCloudAutonomousVmClustersAsync(ListCloudAutonomousVmClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudAutonomousVmClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudAutonomousVmClustersResponseUnmarshaller.Instance;

            return InvokeAsync<ListCloudAutonomousVmClustersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCloudExadataInfrastructures

        internal virtual ListCloudExadataInfrastructuresResponse ListCloudExadataInfrastructures(ListCloudExadataInfrastructuresRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudExadataInfrastructuresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudExadataInfrastructuresResponseUnmarshaller.Instance;

            return Invoke<ListCloudExadataInfrastructuresResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the Exadata infrastructures owned by your Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudExadataInfrastructures service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCloudExadataInfrastructures service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudExadataInfrastructures">REST API Reference for ListCloudExadataInfrastructures Operation</seealso>
        public virtual Task<ListCloudExadataInfrastructuresResponse> ListCloudExadataInfrastructuresAsync(ListCloudExadataInfrastructuresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudExadataInfrastructuresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudExadataInfrastructuresResponseUnmarshaller.Instance;

            return InvokeAsync<ListCloudExadataInfrastructuresResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCloudVmClusters

        internal virtual ListCloudVmClustersResponse ListCloudVmClusters(ListCloudVmClustersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudVmClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudVmClustersResponseUnmarshaller.Instance;

            return Invoke<ListCloudVmClustersResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the VM clusters owned by your Amazon Web Services account
        /// or only the ones on the specified Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudVmClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCloudVmClusters service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListCloudVmClusters">REST API Reference for ListCloudVmClusters Operation</seealso>
        public virtual Task<ListCloudVmClustersResponse> ListCloudVmClustersAsync(ListCloudVmClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCloudVmClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCloudVmClustersResponseUnmarshaller.Instance;

            return InvokeAsync<ListCloudVmClustersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDbNodes

        internal virtual ListDbNodesResponse ListDbNodes(ListDbNodesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDbNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbNodesResponseUnmarshaller.Instance;

            return Invoke<ListDbNodesResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the DB nodes for the specified VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbNodes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDbNodes service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbNodes">REST API Reference for ListDbNodes Operation</seealso>
        public virtual Task<ListDbNodesResponse> ListDbNodesAsync(ListDbNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDbNodesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbNodesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDbNodesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDbServers

        internal virtual ListDbServersResponse ListDbServers(ListDbServersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDbServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbServersResponseUnmarshaller.Instance;

            return Invoke<ListDbServersResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the database servers that belong to the specified Exadata
        /// infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDbServers service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbServers">REST API Reference for ListDbServers Operation</seealso>
        public virtual Task<ListDbServersResponse> ListDbServersAsync(ListDbServersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDbServersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbServersResponseUnmarshaller.Instance;

            return InvokeAsync<ListDbServersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDbSystemShapes

        internal virtual ListDbSystemShapesResponse ListDbSystemShapes(ListDbSystemShapesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDbSystemShapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbSystemShapesResponseUnmarshaller.Instance;

            return Invoke<ListDbSystemShapesResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the shapes that are available for an Exadata infrastructure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDbSystemShapes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDbSystemShapes service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListDbSystemShapes">REST API Reference for ListDbSystemShapes Operation</seealso>
        public virtual Task<ListDbSystemShapesResponse> ListDbSystemShapesAsync(ListDbSystemShapesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDbSystemShapesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDbSystemShapesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDbSystemShapesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListGiVersions

        internal virtual ListGiVersionsResponse ListGiVersions(ListGiVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGiVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGiVersionsResponseUnmarshaller.Instance;

            return Invoke<ListGiVersionsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about Oracle Grid Infrastructure (GI) software versions that are
        /// available for a VM cluster for the specified shape.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGiVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGiVersions service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListGiVersions">REST API Reference for ListGiVersions Operation</seealso>
        public virtual Task<ListGiVersionsResponse> ListGiVersionsAsync(ListGiVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGiVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGiVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGiVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListOdbNetworks

        internal virtual ListOdbNetworksResponse ListOdbNetworks(ListOdbNetworksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOdbNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOdbNetworksResponseUnmarshaller.Instance;

            return Invoke<ListOdbNetworksResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the ODB networks owned by your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOdbNetworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOdbNetworks service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListOdbNetworks">REST API Reference for ListOdbNetworks Operation</seealso>
        public virtual Task<ListOdbNetworksResponse> ListOdbNetworksAsync(ListOdbNetworksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOdbNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOdbNetworksResponseUnmarshaller.Instance;

            return InvokeAsync<ListOdbNetworksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListOdbPeeringConnections

        internal virtual ListOdbPeeringConnectionsResponse ListOdbPeeringConnections(ListOdbPeeringConnectionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOdbPeeringConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOdbPeeringConnectionsResponseUnmarshaller.Instance;

            return Invoke<ListOdbPeeringConnectionsResponse>(request, options);
        }



        /// <summary>
        /// Lists all ODB peering connections or those associated with a specific ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOdbPeeringConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOdbPeeringConnections service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListOdbPeeringConnections">REST API Reference for ListOdbPeeringConnections Operation</seealso>
        public virtual Task<ListOdbPeeringConnectionsResponse> ListOdbPeeringConnectionsAsync(ListOdbPeeringConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListOdbPeeringConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOdbPeeringConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOdbPeeringConnectionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSystemVersions

        internal virtual ListSystemVersionsResponse ListSystemVersions(ListSystemVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSystemVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSystemVersionsResponseUnmarshaller.Instance;

            return Invoke<ListSystemVersionsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the system versions that are available for a VM cluster
        /// for the specified <c>giVersion</c> and <c>shape</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSystemVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSystemVersions service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListSystemVersions">REST API Reference for ListSystemVersions Operation</seealso>
        public virtual Task<ListSystemVersionsResponse> ListSystemVersionsAsync(ListSystemVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSystemVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSystemVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSystemVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the tags applied to this resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RebootDbNode

        internal virtual RebootDbNodeResponse RebootDbNode(RebootDbNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootDbNodeResponseUnmarshaller.Instance;

            return Invoke<RebootDbNodeResponse>(request, options);
        }



        /// <summary>
        /// Reboots the specified DB node in a VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootDbNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebootDbNode service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/RebootDbNode">REST API Reference for RebootDbNode Operation</seealso>
        public virtual Task<RebootDbNodeResponse> RebootDbNodeAsync(RebootDbNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RebootDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootDbNodeResponseUnmarshaller.Instance;

            return InvokeAsync<RebootDbNodeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartDbNode

        internal virtual StartDbNodeResponse StartDbNode(StartDbNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDbNodeResponseUnmarshaller.Instance;

            return Invoke<StartDbNodeResponse>(request, options);
        }



        /// <summary>
        /// Starts the specified DB node in a VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDbNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDbNode service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StartDbNode">REST API Reference for StartDbNode Operation</seealso>
        public virtual Task<StartDbNodeResponse> StartDbNodeAsync(StartDbNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDbNodeResponseUnmarshaller.Instance;

            return InvokeAsync<StartDbNodeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopDbNode

        internal virtual StopDbNodeResponse StopDbNode(StopDbNodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDbNodeResponseUnmarshaller.Instance;

            return Invoke<StopDbNodeResponse>(request, options);
        }



        /// <summary>
        /// Stops the specified DB node in a VM cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDbNode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopDbNode service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/StopDbNode">REST API Reference for StopDbNode Operation</seealso>
        public virtual Task<StopDbNodeResponse> StopDbNodeAsync(StopDbNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StopDbNodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDbNodeResponseUnmarshaller.Instance;

            return InvokeAsync<StopDbNodeResponse>(request, options, cancellationToken);
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
        /// Applies tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateCloudExadataInfrastructure

        internal virtual UpdateCloudExadataInfrastructureResponse UpdateCloudExadataInfrastructure(UpdateCloudExadataInfrastructureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return Invoke<UpdateCloudExadataInfrastructureResponse>(request, options);
        }



        /// <summary>
        /// Updates the properties of an Exadata infrastructure resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudExadataInfrastructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCloudExadataInfrastructure service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateCloudExadataInfrastructure">REST API Reference for UpdateCloudExadataInfrastructure Operation</seealso>
        public virtual Task<UpdateCloudExadataInfrastructureResponse> UpdateCloudExadataInfrastructureAsync(UpdateCloudExadataInfrastructureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCloudExadataInfrastructureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCloudExadataInfrastructureResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCloudExadataInfrastructureResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateOdbNetwork

        internal virtual UpdateOdbNetworkResponse UpdateOdbNetwork(UpdateOdbNetworkRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOdbNetworkResponseUnmarshaller.Instance;

            return Invoke<UpdateOdbNetworkResponse>(request, options);
        }



        /// <summary>
        /// Updates properties of a specified ODB network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOdbNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOdbNetwork service method, as returned by Odb.</returns>
        /// <exception cref="Amazon.Odb.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action. Make sure you have the required
        /// permissions and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ConflictException">
        /// Occurs when a conflict with the current status of your resource. Fix any inconsistencies
        /// with your resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.InternalServerException">
        /// Occurs when there is an internal failure in the Oracle Database@Amazon Web Services
        /// service. Wait and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ResourceNotFoundException">
        /// The operation tried to access a resource that doesn't exist. Make sure you provided
        /// the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Odb.Model.ValidationException">
        /// The request has failed validation because it is missing required fields or has invalid
        /// inputs.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/odb-2024-08-20/UpdateOdbNetwork">REST API Reference for UpdateOdbNetwork Operation</seealso>
        public virtual Task<UpdateOdbNetworkResponse> UpdateOdbNetworkAsync(UpdateOdbNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateOdbNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateOdbNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateOdbNetworkResponse>(request, options, cancellationToken);
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