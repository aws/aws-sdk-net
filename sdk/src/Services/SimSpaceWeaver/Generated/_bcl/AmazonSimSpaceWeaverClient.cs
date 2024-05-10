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
 * Do not modify this file. This file is generated from the simspaceweaver-2022-10-28.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SimSpaceWeaver.Model;
using Amazon.SimSpaceWeaver.Model.Internal.MarshallTransformations;
using Amazon.SimSpaceWeaver.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.SimSpaceWeaver
{
    /// <summary>
    /// <para>Implementation for accessing SimSpaceWeaver</para>
    ///
    /// SimSpace Weaver (SimSpace Weaver) is a service that you can use to build and run large-scale
    /// spatial simulations in the Amazon Web Services Cloud. For example, you can create
    /// crowd simulations, large real-world environments, and immersive and interactive experiences.
    /// For more information about SimSpace Weaver, see the <i> <a href="https://docs.aws.amazon.com/simspaceweaver/latest/userguide/">SimSpace
    /// Weaver User Guide</a> </i>.
    /// 
    ///  
    /// <para>
    /// This API reference describes the API operations and data types that you can use to
    /// communicate directly with SimSpace Weaver.
    /// </para>
    ///  
    /// <para>
    /// SimSpace Weaver also provides the SimSpace Weaver app SDK, which you use for app development.
    /// The SimSpace Weaver app SDK API reference is included in the SimSpace Weaver app SDK
    /// documentation. This documentation is part of the SimSpace Weaver app SDK distributable
    /// package.
    /// </para>
    /// </summary>
    public partial class AmazonSimSpaceWeaverClient : AmazonServiceClient, IAmazonSimSpaceWeaver
    {
        private static IServiceMetadata serviceMetadata = new AmazonSimSpaceWeaverMetadata();
        private ISimSpaceWeaverPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISimSpaceWeaverPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SimSpaceWeaverPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with the credentials loaded from the application's
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
        public AmazonSimSpaceWeaverClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimSpaceWeaverConfig()) { }

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with the credentials loaded from the application's
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
        public AmazonSimSpaceWeaverClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimSpaceWeaverConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSimSpaceWeaverClient Configuration Object</param>
        public AmazonSimSpaceWeaverClient(AmazonSimSpaceWeaverConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSimSpaceWeaverClient(AWSCredentials credentials)
            : this(credentials, new AmazonSimSpaceWeaverConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimSpaceWeaverClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSimSpaceWeaverConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with AWS Credentials and an
        /// AmazonSimSpaceWeaverClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimSpaceWeaverClient Configuration Object</param>
        public AmazonSimSpaceWeaverClient(AWSCredentials credentials, AmazonSimSpaceWeaverConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimSpaceWeaverClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimSpaceWeaverConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimSpaceWeaverClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimSpaceWeaverConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimSpaceWeaverClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimSpaceWeaverClient Configuration Object</param>
        public AmazonSimSpaceWeaverClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimSpaceWeaverConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSimSpaceWeaverClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimSpaceWeaverConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimSpaceWeaverClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimSpaceWeaverConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimSpaceWeaverClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimSpaceWeaverClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSimSpaceWeaverClient Configuration Object</param>
        public AmazonSimSpaceWeaverClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSimSpaceWeaverConfig clientConfig)
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSimSpaceWeaverEndpointResolver());
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


        #region  CreateSnapshot


        /// <summary>
        /// Creates a snapshot of the specified simulation. A snapshot is a file that contains
        /// simulation state data at a specific time. The state data saved in a snapshot includes
        /// entity data from the State Fabric, the simulation configuration specified in the schema,
        /// and the clock tick number. You can use the snapshot to initialize a new simulation.
        /// For more information about snapshots, see <a href="https://docs.aws.amazon.com/simspaceweaver/latest/userguide/working-with_snapshots.html">Snapshots</a>
        /// in the <i>SimSpace Weaver User Guide</i>. 
        /// 
        ///  
        /// <para>
        /// You specify a <c>Destination</c> when you create a snapshot. The <c>Destination</c>
        /// is the name of an Amazon S3 bucket and an optional <c>ObjectKeyPrefix</c>. The <c>ObjectKeyPrefix</c>
        /// is usually the name of a folder in the bucket. SimSpace Weaver creates a <c>snapshot</c>
        /// folder inside the <c>Destination</c> and places the snapshot file there.
        /// </para>
        ///  
        /// <para>
        /// The snapshot file is an Amazon S3 object. It has an object key with the form: <c>
        /// <i>object-key-prefix</i>/snapshot/<i>simulation-name</i>-<i>YYMMdd</i>-<i>HHmm</i>-<i>ss</i>.zip</c>,
        /// where: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c> <i>YY</i> </c> is the 2-digit year
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c> <i>MM</i> </c> is the 2-digit month
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c> <i>dd</i> </c> is the 2-digit day of the month
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c> <i>HH</i> </c> is the 2-digit hour (24-hour clock)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c> <i>mm</i> </c> is the 2-digit minutes
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c> <i>ss</i> </c> is the 2-digit seconds
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Creates a snapshot of the specified simulation. A snapshot is a file that contains
        /// simulation state data at a specific time. The state data saved in a snapshot includes
        /// entity data from the State Fabric, the simulation configuration specified in the schema,
        /// and the clock tick number. You can use the snapshot to initialize a new simulation.
        /// For more information about snapshots, see <a href="https://docs.aws.amazon.com/simspaceweaver/latest/userguide/working-with_snapshots.html">Snapshots</a>
        /// in the <i>SimSpace Weaver User Guide</i>. 
        /// 
        ///  
        /// <para>
        /// You specify a <c>Destination</c> when you create a snapshot. The <c>Destination</c>
        /// is the name of an Amazon S3 bucket and an optional <c>ObjectKeyPrefix</c>. The <c>ObjectKeyPrefix</c>
        /// is usually the name of a folder in the bucket. SimSpace Weaver creates a <c>snapshot</c>
        /// folder inside the <c>Destination</c> and places the snapshot file there.
        /// </para>
        ///  
        /// <para>
        /// The snapshot file is an Amazon S3 object. It has an object key with the form: <c>
        /// <i>object-key-prefix</i>/snapshot/<i>simulation-name</i>-<i>YYMMdd</i>-<i>HHmm</i>-<i>ss</i>.zip</c>,
        /// where: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c> <i>YY</i> </c> is the 2-digit year
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c> <i>MM</i> </c> is the 2-digit month
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c> <i>dd</i> </c> is the 2-digit day of the month
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c> <i>HH</i> </c> is the 2-digit hour (24-hour clock)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c> <i>mm</i> </c> is the 2-digit minutes
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c> <i>ss</i> </c> is the 2-digit seconds
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApp


        /// <summary>
        /// Deletes the instance of the given custom app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return Invoke<DeleteAppResponse>(request, options);
        }


        /// <summary>
        /// Deletes the instance of the given custom app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSimulation


        /// <summary>
        /// Deletes all SimSpace Weaver resources assigned to the given simulation.
        /// 
        ///  <note> 
        /// <para>
        /// Your simulation uses resources in other Amazon Web Services. This API operation doesn't
        /// delete resources in other Amazon Web Services.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSimulation service method.</param>
        /// 
        /// <returns>The response from the DeleteSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DeleteSimulation">REST API Reference for DeleteSimulation Operation</seealso>
        public virtual DeleteSimulationResponse DeleteSimulation(DeleteSimulationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSimulationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSimulationResponseUnmarshaller.Instance;

            return Invoke<DeleteSimulationResponse>(request, options);
        }


        /// <summary>
        /// Deletes all SimSpace Weaver resources assigned to the given simulation.
        /// 
        ///  <note> 
        /// <para>
        /// Your simulation uses resources in other Amazon Web Services. This API operation doesn't
        /// delete resources in other Amazon Web Services.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSimulation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DeleteSimulation">REST API Reference for DeleteSimulation Operation</seealso>
        public virtual Task<DeleteSimulationResponse> DeleteSimulationAsync(DeleteSimulationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSimulationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSimulationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSimulationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeApp


        /// <summary>
        /// Returns the state of the given custom app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApp service method.</param>
        /// 
        /// <returns>The response from the DescribeApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        public virtual DescribeAppResponse DescribeApp(DescribeAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppResponseUnmarshaller.Instance;

            return Invoke<DescribeAppResponse>(request, options);
        }


        /// <summary>
        /// Returns the state of the given custom app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        public virtual Task<DescribeAppResponse> DescribeAppAsync(DescribeAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSimulation


        /// <summary>
        /// Returns the current state of the given simulation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulation service method.</param>
        /// 
        /// <returns>The response from the DescribeSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DescribeSimulation">REST API Reference for DescribeSimulation Operation</seealso>
        public virtual DescribeSimulationResponse DescribeSimulation(DescribeSimulationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSimulationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSimulationResponseUnmarshaller.Instance;

            return Invoke<DescribeSimulationResponse>(request, options);
        }


        /// <summary>
        /// Returns the current state of the given simulation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSimulation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/DescribeSimulation">REST API Reference for DescribeSimulation Operation</seealso>
        public virtual Task<DescribeSimulationResponse> DescribeSimulationAsync(DescribeSimulationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSimulationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSimulationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeSimulationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApps


        /// <summary>
        /// Lists all custom apps or service apps for the given simulation and domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListApps">REST API Reference for ListApps Operation</seealso>
        public virtual ListAppsResponse ListApps(ListAppsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsResponseUnmarshaller.Instance;

            return Invoke<ListAppsResponse>(request, options);
        }


        /// <summary>
        /// Lists all custom apps or service apps for the given simulation and domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListApps">REST API Reference for ListApps Operation</seealso>
        public virtual Task<ListAppsResponse> ListAppsAsync(ListAppsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAppsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSimulations


        /// <summary>
        /// Lists the SimSpace Weaver simulations in the Amazon Web Services account used to make
        /// the API call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSimulations service method.</param>
        /// 
        /// <returns>The response from the ListSimulations service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListSimulations">REST API Reference for ListSimulations Operation</seealso>
        public virtual ListSimulationsResponse ListSimulations(ListSimulationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSimulationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSimulationsResponseUnmarshaller.Instance;

            return Invoke<ListSimulationsResponse>(request, options);
        }


        /// <summary>
        /// Lists the SimSpace Weaver simulations in the Amazon Web Services account used to make
        /// the API call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSimulations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSimulations service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListSimulations">REST API Reference for ListSimulations Operation</seealso>
        public virtual Task<ListSimulationsResponse> ListSimulationsAsync(ListSimulationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSimulationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSimulationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListSimulationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags on a SimSpace Weaver resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists all tags on a SimSpace Weaver resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartApp


        /// <summary>
        /// Starts a custom app with the configuration specified in the simulation schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartApp service method.</param>
        /// 
        /// <returns>The response from the StartApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartApp">REST API Reference for StartApp Operation</seealso>
        public virtual StartAppResponse StartApp(StartAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAppResponseUnmarshaller.Instance;

            return Invoke<StartAppResponse>(request, options);
        }


        /// <summary>
        /// Starts a custom app with the configuration specified in the simulation schema.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartApp">REST API Reference for StartApp Operation</seealso>
        public virtual Task<StartAppResponse> StartAppAsync(StartAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAppResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartClock


        /// <summary>
        /// Starts the simulation clock.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartClock service method.</param>
        /// 
        /// <returns>The response from the StartClock service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartClock">REST API Reference for StartClock Operation</seealso>
        public virtual StartClockResponse StartClock(StartClockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartClockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartClockResponseUnmarshaller.Instance;

            return Invoke<StartClockResponse>(request, options);
        }


        /// <summary>
        /// Starts the simulation clock.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartClock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartClock service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartClock">REST API Reference for StartClock Operation</seealso>
        public virtual Task<StartClockResponse> StartClockAsync(StartClockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartClockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartClockResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartClockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartSimulation


        /// <summary>
        /// Starts a simulation with the given name. You must choose to start your simulation
        /// from a schema or from a snapshot. For more information about the schema, see the <a
        /// href="https://docs.aws.amazon.com/simspaceweaver/latest/userguide/schema-reference.html">schema
        /// reference</a> in the <i>SimSpace Weaver User Guide</i>. For more information about
        /// snapshots, see <a href="https://docs.aws.amazon.com/simspaceweaver/latest/userguide/working-with_snapshots.html">Snapshots</a>
        /// in the <i>SimSpace Weaver User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSimulation service method.</param>
        /// 
        /// <returns>The response from the StartSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartSimulation">REST API Reference for StartSimulation Operation</seealso>
        public virtual StartSimulationResponse StartSimulation(StartSimulationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSimulationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSimulationResponseUnmarshaller.Instance;

            return Invoke<StartSimulationResponse>(request, options);
        }


        /// <summary>
        /// Starts a simulation with the given name. You must choose to start your simulation
        /// from a schema or from a snapshot. For more information about the schema, see the <a
        /// href="https://docs.aws.amazon.com/simspaceweaver/latest/userguide/schema-reference.html">schema
        /// reference</a> in the <i>SimSpace Weaver User Guide</i>. For more information about
        /// snapshots, see <a href="https://docs.aws.amazon.com/simspaceweaver/latest/userguide/working-with_snapshots.html">Snapshots</a>
        /// in the <i>SimSpace Weaver User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSimulation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StartSimulation">REST API Reference for StartSimulation Operation</seealso>
        public virtual Task<StartSimulationResponse> StartSimulationAsync(StartSimulationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSimulationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSimulationResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartSimulationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopApp


        /// <summary>
        /// Stops the given custom app and shuts down all of its allocated compute resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopApp service method.</param>
        /// 
        /// <returns>The response from the StopApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopApp">REST API Reference for StopApp Operation</seealso>
        public virtual StopAppResponse StopApp(StopAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAppResponseUnmarshaller.Instance;

            return Invoke<StopAppResponse>(request, options);
        }


        /// <summary>
        /// Stops the given custom app and shuts down all of its allocated compute resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopApp service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopApp">REST API Reference for StopApp Operation</seealso>
        public virtual Task<StopAppResponse> StopAppAsync(StopAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopAppResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopClock


        /// <summary>
        /// Stops the simulation clock.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopClock service method.</param>
        /// 
        /// <returns>The response from the StopClock service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopClock">REST API Reference for StopClock Operation</seealso>
        public virtual StopClockResponse StopClock(StopClockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopClockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopClockResponseUnmarshaller.Instance;

            return Invoke<StopClockResponse>(request, options);
        }


        /// <summary>
        /// Stops the simulation clock.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopClock service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopClock service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopClock">REST API Reference for StopClock Operation</seealso>
        public virtual Task<StopClockResponse> StopClockAsync(StopClockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopClockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopClockResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopClockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopSimulation


        /// <summary>
        /// Stops the given simulation.
        /// 
        ///  <important> 
        /// <para>
        /// You can't restart a simulation after you stop it. If you want to restart a simulation,
        /// then you must stop it, delete it, and start a new instance of it.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSimulation service method.</param>
        /// 
        /// <returns>The response from the StopSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopSimulation">REST API Reference for StopSimulation Operation</seealso>
        public virtual StopSimulationResponse StopSimulation(StopSimulationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopSimulationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopSimulationResponseUnmarshaller.Instance;

            return Invoke<StopSimulationResponse>(request, options);
        }


        /// <summary>
        /// Stops the given simulation.
        /// 
        ///  <important> 
        /// <para>
        /// You can't restart a simulation after you stop it. If you want to restart a simulation,
        /// then you must stop it, delete it, and start a new instance of it.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSimulation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopSimulation service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/StopSimulation">REST API Reference for StopSimulation Operation</seealso>
        public virtual Task<StopSimulationResponse> StopSimulationAsync(StopSimulationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopSimulationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopSimulationResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopSimulationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a SimSpace Weaver resource. For more information about tags, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.TooManyTagsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds tags to a SimSpace Weaver resource. For more information about tags, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.TooManyTagsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a SimSpace Weaver resource. For more information about tags, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes tags from a SimSpace Weaver resource. For more information about tags, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SimSpaceWeaver.</returns>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.SimSpaceWeaver.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/simspaceweaver-2022-10-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonSimSpaceWeaverEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}