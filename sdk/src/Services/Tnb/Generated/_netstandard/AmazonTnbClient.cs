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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Tnb.Model;
using Amazon.Tnb.Model.Internal.MarshallTransformations;
using Amazon.Tnb.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Tnb
{
    /// <summary>
    /// Implementation for accessing Tnb
    ///
    /// Amazon Web Services Telco Network Builder (TNB) is a network automation service that
    /// helps you deploy and manage telecom networks. AWS TNB helps you with the lifecycle
    /// management of your telecommunication network functions throughout planning, deployment,
    /// and post-deployment activities.
    /// </summary>
    public partial class AmazonTnbClient : AmazonServiceClient, IAmazonTnb
    {
        private static IServiceMetadata serviceMetadata = new AmazonTnbMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonTnbClient with the credentials loaded from the application's
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
        public AmazonTnbClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTnbConfig()) { }

        /// <summary>
        /// Constructs AmazonTnbClient with the credentials loaded from the application's
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
        public AmazonTnbClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonTnbConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonTnbClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonTnbClient Configuration Object</param>
        public AmazonTnbClient(AmazonTnbConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonTnbClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonTnbClient(AWSCredentials credentials)
            : this(credentials, new AmazonTnbConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTnbClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTnbClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonTnbConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTnbClient with AWS Credentials and an
        /// AmazonTnbClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonTnbClient Configuration Object</param>
        public AmazonTnbClient(AWSCredentials credentials, AmazonTnbConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTnbClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonTnbClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTnbConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTnbClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTnbClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonTnbConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonTnbClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTnbClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonTnbClient Configuration Object</param>
        public AmazonTnbClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonTnbConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonTnbClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonTnbClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTnbConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonTnbClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonTnbClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonTnbConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonTnbClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonTnbClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonTnbClient Configuration Object</param>
        public AmazonTnbClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonTnbConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ITnbPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ITnbPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new TnbPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonTnbEndpointResolver());
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


        #region  CancelSolNetworkOperation

        internal virtual CancelSolNetworkOperationResponse CancelSolNetworkOperation(CancelSolNetworkOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSolNetworkOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSolNetworkOperationResponseUnmarshaller.Instance;

            return Invoke<CancelSolNetworkOperationResponse>(request, options);
        }



        /// <summary>
        /// Cancels a network operation.
        /// 
        ///  
        /// <para>
        /// A network operation is any operation that is done to your network, such as network
        /// instance instantiation or termination.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSolNetworkOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSolNetworkOperation service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/CancelSolNetworkOperation">REST API Reference for CancelSolNetworkOperation Operation</seealso>
        public virtual Task<CancelSolNetworkOperationResponse> CancelSolNetworkOperationAsync(CancelSolNetworkOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSolNetworkOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSolNetworkOperationResponseUnmarshaller.Instance;

            return InvokeAsync<CancelSolNetworkOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSolFunctionPackage

        internal virtual CreateSolFunctionPackageResponse CreateSolFunctionPackage(CreateSolFunctionPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSolFunctionPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSolFunctionPackageResponseUnmarshaller.Instance;

            return Invoke<CreateSolFunctionPackageResponse>(request, options);
        }



        /// <summary>
        /// Creates a function package.
        /// 
        ///  
        /// <para>
        /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
        /// a network function (an ETSI standard telecommunication application) and function package
        /// descriptor that uses the TOSCA standard to describe how the network functions should
        /// run on your network. For more information, see <a href="https://docs.aws.amazon.com/tnb/latest/ug/function-packages.html">Function
        /// packages</a> in the <i>Amazon Web Services Telco Network Builder User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// Creating a function package is the first step for creating a network in AWS TNB. This
        /// request creates an empty container with an ID. The next step is to upload the actual
        /// CSAR zip file into that empty container. To upload function package content, see <a
        /// href="https://docs.aws.amazon.com/TNB/latest/APIReference/API_PutSolFunctionPackageContent.html">PutSolFunctionPackageContent</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSolFunctionPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSolFunctionPackage service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ServiceQuotaExceededException">
        /// Service quotas have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/CreateSolFunctionPackage">REST API Reference for CreateSolFunctionPackage Operation</seealso>
        public virtual Task<CreateSolFunctionPackageResponse> CreateSolFunctionPackageAsync(CreateSolFunctionPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSolFunctionPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSolFunctionPackageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSolFunctionPackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSolNetworkInstance

        internal virtual CreateSolNetworkInstanceResponse CreateSolNetworkInstance(CreateSolNetworkInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSolNetworkInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateSolNetworkInstanceResponse>(request, options);
        }



        /// <summary>
        /// Creates a network instance.
        /// 
        ///  
        /// <para>
        /// A network instance is a single network created in Amazon Web Services TNB that can
        /// be deployed and on which life-cycle operations (like terminate, update, and delete)
        /// can be performed. Creating a network instance is the third step after creating a network
        /// package. For more information about network instances, <a href="https://docs.aws.amazon.com/tnb/latest/ug/network-instances.html">Network
        /// instances</a> in the <i>Amazon Web Services Telco Network Builder User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Once you create a network instance, you can instantiate it. To instantiate a network,
        /// see <a href="https://docs.aws.amazon.com/TNB/latest/APIReference/API_InstantiateSolNetworkInstance.html">InstantiateSolNetworkInstance</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSolNetworkInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSolNetworkInstance service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ServiceQuotaExceededException">
        /// Service quotas have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/CreateSolNetworkInstance">REST API Reference for CreateSolNetworkInstance Operation</seealso>
        public virtual Task<CreateSolNetworkInstanceResponse> CreateSolNetworkInstanceAsync(CreateSolNetworkInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSolNetworkInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSolNetworkInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSolNetworkPackage

        internal virtual CreateSolNetworkPackageResponse CreateSolNetworkPackage(CreateSolNetworkPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSolNetworkPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSolNetworkPackageResponseUnmarshaller.Instance;

            return Invoke<CreateSolNetworkPackageResponse>(request, options);
        }



        /// <summary>
        /// Creates a network package.
        /// 
        ///  
        /// <para>
        /// A network package is a .zip file in CSAR (Cloud Service Archive) format defines the
        /// function packages you want to deploy and the Amazon Web Services infrastructure you
        /// want to deploy them on. For more information, see <a href="https://docs.aws.amazon.com/tnb/latest/ug/network-instances.html">Network
        /// instances</a> in the <i>Amazon Web Services Telco Network Builder User Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// A network package consists of a network service descriptor (NSD) file (required) and
        /// any additional files (optional), such as scripts specific to your needs. For example,
        /// if you have multiple function packages in your network package, you can use the NSD
        /// to define which network functions should run in certain VPCs, subnets, or EKS clusters.
        /// </para>
        ///  
        /// <para>
        /// This request creates an empty network package container with an ID. Once you create
        /// a network package, you can upload the network package content using <a href="https://docs.aws.amazon.com/TNB/latest/APIReference/API_PutSolNetworkPackageContent.html">PutSolNetworkPackageContent</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSolNetworkPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSolNetworkPackage service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ServiceQuotaExceededException">
        /// Service quotas have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/CreateSolNetworkPackage">REST API Reference for CreateSolNetworkPackage Operation</seealso>
        public virtual Task<CreateSolNetworkPackageResponse> CreateSolNetworkPackageAsync(CreateSolNetworkPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSolNetworkPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSolNetworkPackageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSolNetworkPackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSolFunctionPackage

        internal virtual DeleteSolFunctionPackageResponse DeleteSolFunctionPackage(DeleteSolFunctionPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSolFunctionPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSolFunctionPackageResponseUnmarshaller.Instance;

            return Invoke<DeleteSolFunctionPackageResponse>(request, options);
        }



        /// <summary>
        /// Deletes a function package.
        /// 
        ///  
        /// <para>
        /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
        /// a network function (an ETSI standard telecommunication application) and function package
        /// descriptor that uses the TOSCA standard to describe how the network functions should
        /// run on your network.
        /// </para>
        ///  
        /// <para>
        /// To delete a function package, the package must be in a disabled state. To disable
        /// a function package, see <a href="https://docs.aws.amazon.com/TNB/latest/APIReference/API_UpdateSolFunctionPackage.html">UpdateSolFunctionPackage</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSolFunctionPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSolFunctionPackage service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/DeleteSolFunctionPackage">REST API Reference for DeleteSolFunctionPackage Operation</seealso>
        public virtual Task<DeleteSolFunctionPackageResponse> DeleteSolFunctionPackageAsync(DeleteSolFunctionPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSolFunctionPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSolFunctionPackageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSolFunctionPackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSolNetworkInstance

        internal virtual DeleteSolNetworkInstanceResponse DeleteSolNetworkInstance(DeleteSolNetworkInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSolNetworkInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteSolNetworkInstanceResponse>(request, options);
        }



        /// <summary>
        /// Deletes a network instance.
        /// 
        ///  
        /// <para>
        /// A network instance is a single network created in Amazon Web Services TNB that can
        /// be deployed and on which life-cycle operations (like terminate, update, and delete)
        /// can be performed.
        /// </para>
        ///  
        /// <para>
        /// To delete a network instance, the instance must be in a stopped or terminated state.
        /// To terminate a network instance, see <a href="https://docs.aws.amazon.com/TNB/latest/APIReference/API_TerminateSolNetworkInstance.html">TerminateSolNetworkInstance</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSolNetworkInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSolNetworkInstance service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/DeleteSolNetworkInstance">REST API Reference for DeleteSolNetworkInstance Operation</seealso>
        public virtual Task<DeleteSolNetworkInstanceResponse> DeleteSolNetworkInstanceAsync(DeleteSolNetworkInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSolNetworkInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSolNetworkInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSolNetworkPackage

        internal virtual DeleteSolNetworkPackageResponse DeleteSolNetworkPackage(DeleteSolNetworkPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSolNetworkPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSolNetworkPackageResponseUnmarshaller.Instance;

            return Invoke<DeleteSolNetworkPackageResponse>(request, options);
        }



        /// <summary>
        /// Deletes network package.
        /// 
        ///  
        /// <para>
        /// A network package is a .zip file in CSAR (Cloud Service Archive) format defines the
        /// function packages you want to deploy and the Amazon Web Services infrastructure you
        /// want to deploy them on.
        /// </para>
        ///  
        /// <para>
        /// To delete a network package, the package must be in a disable state. To disable a
        /// network package, see <a href="https://docs.aws.amazon.com/TNB/latest/APIReference/API_UpdateSolNetworkPackage.html">UpdateSolNetworkPackage</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSolNetworkPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSolNetworkPackage service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/DeleteSolNetworkPackage">REST API Reference for DeleteSolNetworkPackage Operation</seealso>
        public virtual Task<DeleteSolNetworkPackageResponse> DeleteSolNetworkPackageAsync(DeleteSolNetworkPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSolNetworkPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSolNetworkPackageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSolNetworkPackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSolFunctionInstance

        internal virtual GetSolFunctionInstanceResponse GetSolFunctionInstance(GetSolFunctionInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolFunctionInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolFunctionInstanceResponseUnmarshaller.Instance;

            return Invoke<GetSolFunctionInstanceResponse>(request, options);
        }



        /// <summary>
        /// Gets the details of a network function instance, including the instantation state
        /// and metadata from the function package descriptor in the network function package.
        /// 
        ///  
        /// <para>
        /// A network function instance is a function in a function package .
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSolFunctionInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSolFunctionInstance service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolFunctionInstance">REST API Reference for GetSolFunctionInstance Operation</seealso>
        public virtual Task<GetSolFunctionInstanceResponse> GetSolFunctionInstanceAsync(GetSolFunctionInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolFunctionInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolFunctionInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetSolFunctionInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSolFunctionPackage

        internal virtual GetSolFunctionPackageResponse GetSolFunctionPackage(GetSolFunctionPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolFunctionPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolFunctionPackageResponseUnmarshaller.Instance;

            return Invoke<GetSolFunctionPackageResponse>(request, options);
        }



        /// <summary>
        /// Gets the details of an individual function package, such as the operational state
        /// and whether the package is in use.
        /// 
        ///  
        /// <para>
        /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
        /// a network function (an ETSI standard telecommunication application) and function package
        /// descriptor that uses the TOSCA standard to describe how the network functions should
        /// run on your network..
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSolFunctionPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSolFunctionPackage service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolFunctionPackage">REST API Reference for GetSolFunctionPackage Operation</seealso>
        public virtual Task<GetSolFunctionPackageResponse> GetSolFunctionPackageAsync(GetSolFunctionPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolFunctionPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolFunctionPackageResponseUnmarshaller.Instance;

            return InvokeAsync<GetSolFunctionPackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSolFunctionPackageContent

        internal virtual GetSolFunctionPackageContentResponse GetSolFunctionPackageContent(GetSolFunctionPackageContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolFunctionPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolFunctionPackageContentResponseUnmarshaller.Instance;

            return Invoke<GetSolFunctionPackageContentResponse>(request, options);
        }



        /// <summary>
        /// Gets the contents of a function package.
        /// 
        ///  
        /// <para>
        /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
        /// a network function (an ETSI standard telecommunication application) and function package
        /// descriptor that uses the TOSCA standard to describe how the network functions should
        /// run on your network.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSolFunctionPackageContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSolFunctionPackageContent service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolFunctionPackageContent">REST API Reference for GetSolFunctionPackageContent Operation</seealso>
        public virtual Task<GetSolFunctionPackageContentResponse> GetSolFunctionPackageContentAsync(GetSolFunctionPackageContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolFunctionPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolFunctionPackageContentResponseUnmarshaller.Instance;

            return InvokeAsync<GetSolFunctionPackageContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSolFunctionPackageDescriptor

        internal virtual GetSolFunctionPackageDescriptorResponse GetSolFunctionPackageDescriptor(GetSolFunctionPackageDescriptorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolFunctionPackageDescriptorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolFunctionPackageDescriptorResponseUnmarshaller.Instance;

            return Invoke<GetSolFunctionPackageDescriptorResponse>(request, options);
        }



        /// <summary>
        /// Gets a function package descriptor in a function package.
        /// 
        ///  
        /// <para>
        /// A function package descriptor is a .yaml file in a function package that uses the
        /// TOSCA standard to describe how the network function in the function package should
        /// run on your network.
        /// </para>
        ///  
        /// <para>
        /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
        /// a network function (an ETSI standard telecommunication application) and function package
        /// descriptor that uses the TOSCA standard to describe how the network functions should
        /// run on your network.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSolFunctionPackageDescriptor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSolFunctionPackageDescriptor service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolFunctionPackageDescriptor">REST API Reference for GetSolFunctionPackageDescriptor Operation</seealso>
        public virtual Task<GetSolFunctionPackageDescriptorResponse> GetSolFunctionPackageDescriptorAsync(GetSolFunctionPackageDescriptorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolFunctionPackageDescriptorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolFunctionPackageDescriptorResponseUnmarshaller.Instance;

            return InvokeAsync<GetSolFunctionPackageDescriptorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSolNetworkInstance

        internal virtual GetSolNetworkInstanceResponse GetSolNetworkInstance(GetSolNetworkInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolNetworkInstanceResponseUnmarshaller.Instance;

            return Invoke<GetSolNetworkInstanceResponse>(request, options);
        }



        /// <summary>
        /// Gets the details of the network instance.
        /// 
        ///  
        /// <para>
        /// A network instance is a single network created in Amazon Web Services TNB that can
        /// be deployed and on which life-cycle operations (like terminate, update, and delete)
        /// can be performed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSolNetworkInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSolNetworkInstance service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolNetworkInstance">REST API Reference for GetSolNetworkInstance Operation</seealso>
        public virtual Task<GetSolNetworkInstanceResponse> GetSolNetworkInstanceAsync(GetSolNetworkInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolNetworkInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetSolNetworkInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSolNetworkOperation

        internal virtual GetSolNetworkOperationResponse GetSolNetworkOperation(GetSolNetworkOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolNetworkOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolNetworkOperationResponseUnmarshaller.Instance;

            return Invoke<GetSolNetworkOperationResponse>(request, options);
        }



        /// <summary>
        /// Gets the details of a network operation, including the tasks involved in the network
        /// operation and the status of the tasks.
        /// 
        ///  
        /// <para>
        /// A network operation is any operation that is done to your network, such as network
        /// instance instantiation or termination.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSolNetworkOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSolNetworkOperation service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolNetworkOperation">REST API Reference for GetSolNetworkOperation Operation</seealso>
        public virtual Task<GetSolNetworkOperationResponse> GetSolNetworkOperationAsync(GetSolNetworkOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolNetworkOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolNetworkOperationResponseUnmarshaller.Instance;

            return InvokeAsync<GetSolNetworkOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSolNetworkPackage

        internal virtual GetSolNetworkPackageResponse GetSolNetworkPackage(GetSolNetworkPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolNetworkPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolNetworkPackageResponseUnmarshaller.Instance;

            return Invoke<GetSolNetworkPackageResponse>(request, options);
        }



        /// <summary>
        /// Gets the details of a network package.
        /// 
        ///  
        /// <para>
        /// A network package is a .zip file in CSAR (Cloud Service Archive) format defines the
        /// function packages you want to deploy and the Amazon Web Services infrastructure you
        /// want to deploy them on.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSolNetworkPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSolNetworkPackage service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolNetworkPackage">REST API Reference for GetSolNetworkPackage Operation</seealso>
        public virtual Task<GetSolNetworkPackageResponse> GetSolNetworkPackageAsync(GetSolNetworkPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolNetworkPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolNetworkPackageResponseUnmarshaller.Instance;

            return InvokeAsync<GetSolNetworkPackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSolNetworkPackageContent

        internal virtual GetSolNetworkPackageContentResponse GetSolNetworkPackageContent(GetSolNetworkPackageContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolNetworkPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolNetworkPackageContentResponseUnmarshaller.Instance;

            return Invoke<GetSolNetworkPackageContentResponse>(request, options);
        }



        /// <summary>
        /// Gets the contents of a network package.
        /// 
        ///  
        /// <para>
        /// A network package is a .zip file in CSAR (Cloud Service Archive) format defines the
        /// function packages you want to deploy and the Amazon Web Services infrastructure you
        /// want to deploy them on.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSolNetworkPackageContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSolNetworkPackageContent service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolNetworkPackageContent">REST API Reference for GetSolNetworkPackageContent Operation</seealso>
        public virtual Task<GetSolNetworkPackageContentResponse> GetSolNetworkPackageContentAsync(GetSolNetworkPackageContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolNetworkPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolNetworkPackageContentResponseUnmarshaller.Instance;

            return InvokeAsync<GetSolNetworkPackageContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSolNetworkPackageDescriptor

        internal virtual GetSolNetworkPackageDescriptorResponse GetSolNetworkPackageDescriptor(GetSolNetworkPackageDescriptorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolNetworkPackageDescriptorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolNetworkPackageDescriptorResponseUnmarshaller.Instance;

            return Invoke<GetSolNetworkPackageDescriptorResponse>(request, options);
        }



        /// <summary>
        /// Gets the content of the network service descriptor.
        /// 
        ///  
        /// <para>
        /// A network service descriptor is a .yaml file in a network package that uses the TOSCA
        /// standard to describe the network functions you want to deploy and the Amazon Web Services
        /// infrastructure you want to deploy the network functions on.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSolNetworkPackageDescriptor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSolNetworkPackageDescriptor service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolNetworkPackageDescriptor">REST API Reference for GetSolNetworkPackageDescriptor Operation</seealso>
        public virtual Task<GetSolNetworkPackageDescriptorResponse> GetSolNetworkPackageDescriptorAsync(GetSolNetworkPackageDescriptorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolNetworkPackageDescriptorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolNetworkPackageDescriptorResponseUnmarshaller.Instance;

            return InvokeAsync<GetSolNetworkPackageDescriptorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InstantiateSolNetworkInstance

        internal virtual InstantiateSolNetworkInstanceResponse InstantiateSolNetworkInstance(InstantiateSolNetworkInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InstantiateSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InstantiateSolNetworkInstanceResponseUnmarshaller.Instance;

            return Invoke<InstantiateSolNetworkInstanceResponse>(request, options);
        }



        /// <summary>
        /// Instantiates a network instance.
        /// 
        ///  
        /// <para>
        /// A network instance is a single network created in Amazon Web Services TNB that can
        /// be deployed and on which life-cycle operations (like terminate, update, and delete)
        /// can be performed.
        /// </para>
        ///  
        /// <para>
        /// Before you can instantiate a network instance, you have to create a network instance.
        /// For more information, see <a href="https://docs.aws.amazon.com/TNB/latest/APIReference/API_CreateSolNetworkInstance.html">CreateSolNetworkInstance</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InstantiateSolNetworkInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InstantiateSolNetworkInstance service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ServiceQuotaExceededException">
        /// Service quotas have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/InstantiateSolNetworkInstance">REST API Reference for InstantiateSolNetworkInstance Operation</seealso>
        public virtual Task<InstantiateSolNetworkInstanceResponse> InstantiateSolNetworkInstanceAsync(InstantiateSolNetworkInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InstantiateSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InstantiateSolNetworkInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<InstantiateSolNetworkInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSolFunctionInstances

        internal virtual ListSolFunctionInstancesResponse ListSolFunctionInstances(ListSolFunctionInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolFunctionInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolFunctionInstancesResponseUnmarshaller.Instance;

            return Invoke<ListSolFunctionInstancesResponse>(request, options);
        }



        /// <summary>
        /// Lists network function instances.
        /// 
        ///  
        /// <para>
        /// A network function instance is a function in a function package .
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSolFunctionInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSolFunctionInstances service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListSolFunctionInstances">REST API Reference for ListSolFunctionInstances Operation</seealso>
        public virtual Task<ListSolFunctionInstancesResponse> ListSolFunctionInstancesAsync(ListSolFunctionInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolFunctionInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolFunctionInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSolFunctionInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSolFunctionPackages

        internal virtual ListSolFunctionPackagesResponse ListSolFunctionPackages(ListSolFunctionPackagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolFunctionPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolFunctionPackagesResponseUnmarshaller.Instance;

            return Invoke<ListSolFunctionPackagesResponse>(request, options);
        }



        /// <summary>
        /// Lists information about function packages.
        /// 
        ///  
        /// <para>
        /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
        /// a network function (an ETSI standard telecommunication application) and function package
        /// descriptor that uses the TOSCA standard to describe how the network functions should
        /// run on your network.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSolFunctionPackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSolFunctionPackages service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListSolFunctionPackages">REST API Reference for ListSolFunctionPackages Operation</seealso>
        public virtual Task<ListSolFunctionPackagesResponse> ListSolFunctionPackagesAsync(ListSolFunctionPackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolFunctionPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolFunctionPackagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSolFunctionPackagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSolNetworkInstances

        internal virtual ListSolNetworkInstancesResponse ListSolNetworkInstances(ListSolNetworkInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolNetworkInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolNetworkInstancesResponseUnmarshaller.Instance;

            return Invoke<ListSolNetworkInstancesResponse>(request, options);
        }



        /// <summary>
        /// Lists your network instances.
        /// 
        ///  
        /// <para>
        /// A network instance is a single network created in Amazon Web Services TNB that can
        /// be deployed and on which life-cycle operations (like terminate, update, and delete)
        /// can be performed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSolNetworkInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSolNetworkInstances service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListSolNetworkInstances">REST API Reference for ListSolNetworkInstances Operation</seealso>
        public virtual Task<ListSolNetworkInstancesResponse> ListSolNetworkInstancesAsync(ListSolNetworkInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolNetworkInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolNetworkInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSolNetworkInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSolNetworkOperations

        internal virtual ListSolNetworkOperationsResponse ListSolNetworkOperations(ListSolNetworkOperationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolNetworkOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolNetworkOperationsResponseUnmarshaller.Instance;

            return Invoke<ListSolNetworkOperationsResponse>(request, options);
        }



        /// <summary>
        /// Lists details for a network operation, including when the operation started and the
        /// status of the operation.
        /// 
        ///  
        /// <para>
        /// A network operation is any operation that is done to your network, such as network
        /// instance instantiation or termination.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSolNetworkOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSolNetworkOperations service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListSolNetworkOperations">REST API Reference for ListSolNetworkOperations Operation</seealso>
        public virtual Task<ListSolNetworkOperationsResponse> ListSolNetworkOperationsAsync(ListSolNetworkOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolNetworkOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolNetworkOperationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSolNetworkOperationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSolNetworkPackages

        internal virtual ListSolNetworkPackagesResponse ListSolNetworkPackages(ListSolNetworkPackagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolNetworkPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolNetworkPackagesResponseUnmarshaller.Instance;

            return Invoke<ListSolNetworkPackagesResponse>(request, options);
        }



        /// <summary>
        /// Lists network packages.
        /// 
        ///  
        /// <para>
        /// A network package is a .zip file in CSAR (Cloud Service Archive) format defines the
        /// function packages you want to deploy and the Amazon Web Services infrastructure you
        /// want to deploy them on.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSolNetworkPackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSolNetworkPackages service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListSolNetworkPackages">REST API Reference for ListSolNetworkPackages Operation</seealso>
        public virtual Task<ListSolNetworkPackagesResponse> ListSolNetworkPackagesAsync(ListSolNetworkPackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolNetworkPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolNetworkPackagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSolNetworkPackagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists tags for AWS TNB resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutSolFunctionPackageContent

        internal virtual PutSolFunctionPackageContentResponse PutSolFunctionPackageContent(PutSolFunctionPackageContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSolFunctionPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSolFunctionPackageContentResponseUnmarshaller.Instance;

            return Invoke<PutSolFunctionPackageContentResponse>(request, options);
        }



        /// <summary>
        /// Uploads the contents of a function package.
        /// 
        ///  
        /// <para>
        /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
        /// a network function (an ETSI standard telecommunication application) and function package
        /// descriptor that uses the TOSCA standard to describe how the network functions should
        /// run on your network.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSolFunctionPackageContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSolFunctionPackageContent service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/PutSolFunctionPackageContent">REST API Reference for PutSolFunctionPackageContent Operation</seealso>
        public virtual Task<PutSolFunctionPackageContentResponse> PutSolFunctionPackageContentAsync(PutSolFunctionPackageContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSolFunctionPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSolFunctionPackageContentResponseUnmarshaller.Instance;

            return InvokeAsync<PutSolFunctionPackageContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutSolNetworkPackageContent

        internal virtual PutSolNetworkPackageContentResponse PutSolNetworkPackageContent(PutSolNetworkPackageContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSolNetworkPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSolNetworkPackageContentResponseUnmarshaller.Instance;

            return Invoke<PutSolNetworkPackageContentResponse>(request, options);
        }



        /// <summary>
        /// Uploads the contents of a network package.
        /// 
        ///  
        /// <para>
        /// A network package is a .zip file in CSAR (Cloud Service Archive) format defines the
        /// function packages you want to deploy and the Amazon Web Services infrastructure you
        /// want to deploy them on.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSolNetworkPackageContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSolNetworkPackageContent service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/PutSolNetworkPackageContent">REST API Reference for PutSolNetworkPackageContent Operation</seealso>
        public virtual Task<PutSolNetworkPackageContentResponse> PutSolNetworkPackageContentAsync(PutSolNetworkPackageContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSolNetworkPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSolNetworkPackageContentResponseUnmarshaller.Instance;

            return InvokeAsync<PutSolNetworkPackageContentResponse>(request, options, cancellationToken);
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
        /// Tags an AWS TNB resource.
        /// 
        ///  
        /// <para>
        /// A tag is a label that you assign to an Amazon Web Services resource. Each tag consists
        /// of a key and an optional value. You can use tags to search and filter your resources
        /// or track your Amazon Web Services costs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TerminateSolNetworkInstance

        internal virtual TerminateSolNetworkInstanceResponse TerminateSolNetworkInstance(TerminateSolNetworkInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateSolNetworkInstanceResponseUnmarshaller.Instance;

            return Invoke<TerminateSolNetworkInstanceResponse>(request, options);
        }



        /// <summary>
        /// Terminates a network instance.
        /// 
        ///  
        /// <para>
        /// A network instance is a single network created in Amazon Web Services TNB that can
        /// be deployed and on which life-cycle operations (like terminate, update, and delete)
        /// can be performed.
        /// </para>
        ///  
        /// <para>
        /// You must terminate a network instance before you can delete it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateSolNetworkInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateSolNetworkInstance service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ServiceQuotaExceededException">
        /// Service quotas have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/TerminateSolNetworkInstance">REST API Reference for TerminateSolNetworkInstance Operation</seealso>
        public virtual Task<TerminateSolNetworkInstanceResponse> TerminateSolNetworkInstanceAsync(TerminateSolNetworkInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateSolNetworkInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateSolNetworkInstanceResponse>(request, options, cancellationToken);
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
        /// Untags an AWS TNB resource.
        /// 
        ///  
        /// <para>
        /// A tag is a label that you assign to an Amazon Web Services resource. Each tag consists
        /// of a key and an optional value. You can use tags to search and filter your resources
        /// or track your Amazon Web Services costs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSolFunctionPackage

        internal virtual UpdateSolFunctionPackageResponse UpdateSolFunctionPackage(UpdateSolFunctionPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSolFunctionPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSolFunctionPackageResponseUnmarshaller.Instance;

            return Invoke<UpdateSolFunctionPackageResponse>(request, options);
        }



        /// <summary>
        /// Updates the operational state of function package.
        /// 
        ///  
        /// <para>
        /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
        /// a network function (an ETSI standard telecommunication application) and function package
        /// descriptor that uses the TOSCA standard to describe how the network functions should
        /// run on your network.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSolFunctionPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSolFunctionPackage service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/UpdateSolFunctionPackage">REST API Reference for UpdateSolFunctionPackage Operation</seealso>
        public virtual Task<UpdateSolFunctionPackageResponse> UpdateSolFunctionPackageAsync(UpdateSolFunctionPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSolFunctionPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSolFunctionPackageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSolFunctionPackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSolNetworkInstance

        internal virtual UpdateSolNetworkInstanceResponse UpdateSolNetworkInstance(UpdateSolNetworkInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSolNetworkInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateSolNetworkInstanceResponse>(request, options);
        }



        /// <summary>
        /// Update a network instance.
        /// 
        ///  
        /// <para>
        /// A network instance is a single network created in Amazon Web Services TNB that can
        /// be deployed and on which life-cycle operations (like terminate, update, and delete)
        /// can be performed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSolNetworkInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSolNetworkInstance service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ServiceQuotaExceededException">
        /// Service quotas have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/UpdateSolNetworkInstance">REST API Reference for UpdateSolNetworkInstance Operation</seealso>
        public virtual Task<UpdateSolNetworkInstanceResponse> UpdateSolNetworkInstanceAsync(UpdateSolNetworkInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSolNetworkInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSolNetworkInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSolNetworkPackage

        internal virtual UpdateSolNetworkPackageResponse UpdateSolNetworkPackage(UpdateSolNetworkPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSolNetworkPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSolNetworkPackageResponseUnmarshaller.Instance;

            return Invoke<UpdateSolNetworkPackageResponse>(request, options);
        }



        /// <summary>
        /// Updates the operational state of a network package.
        /// 
        ///  
        /// <para>
        /// A network package is a .zip file in CSAR (Cloud Service Archive) format defines the
        /// function packages you want to deploy and the Amazon Web Services infrastructure you
        /// want to deploy them on.
        /// </para>
        ///  
        /// <para>
        /// A network service descriptor is a .yaml file in a network package that uses the TOSCA
        /// standard to describe the network functions you want to deploy and the Amazon Web Services
        /// infrastructure you want to deploy the network functions on.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSolNetworkPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSolNetworkPackage service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/UpdateSolNetworkPackage">REST API Reference for UpdateSolNetworkPackage Operation</seealso>
        public virtual Task<UpdateSolNetworkPackageResponse> UpdateSolNetworkPackageAsync(UpdateSolNetworkPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSolNetworkPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSolNetworkPackageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSolNetworkPackageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ValidateSolFunctionPackageContent

        internal virtual ValidateSolFunctionPackageContentResponse ValidateSolFunctionPackageContent(ValidateSolFunctionPackageContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateSolFunctionPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateSolFunctionPackageContentResponseUnmarshaller.Instance;

            return Invoke<ValidateSolFunctionPackageContentResponse>(request, options);
        }



        /// <summary>
        /// Validates function package content. This can be used as a dry run before uploading
        /// function package content with <a href="https://docs.aws.amazon.com/TNB/latest/APIReference/API_PutSolFunctionPackageContent.html">PutSolFunctionPackageContent</a>.
        /// 
        ///  
        /// <para>
        /// A function package is a .zip file in CSAR (Cloud Service Archive) format that contains
        /// a network function (an ETSI standard telecommunication application) and function package
        /// descriptor that uses the TOSCA standard to describe how the network functions should
        /// run on your network.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateSolFunctionPackageContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateSolFunctionPackageContent service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ValidateSolFunctionPackageContent">REST API Reference for ValidateSolFunctionPackageContent Operation</seealso>
        public virtual Task<ValidateSolFunctionPackageContentResponse> ValidateSolFunctionPackageContentAsync(ValidateSolFunctionPackageContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateSolFunctionPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateSolFunctionPackageContentResponseUnmarshaller.Instance;

            return InvokeAsync<ValidateSolFunctionPackageContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ValidateSolNetworkPackageContent

        internal virtual ValidateSolNetworkPackageContentResponse ValidateSolNetworkPackageContent(ValidateSolNetworkPackageContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateSolNetworkPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateSolNetworkPackageContentResponseUnmarshaller.Instance;

            return Invoke<ValidateSolNetworkPackageContentResponse>(request, options);
        }



        /// <summary>
        /// Validates network package content. This can be used as a dry run before uploading
        /// network package content with <a href="https://docs.aws.amazon.com/TNB/latest/APIReference/API_PutSolNetworkPackageContent.html">PutSolNetworkPackageContent</a>.
        /// 
        ///  
        /// <para>
        /// A network package is a .zip file in CSAR (Cloud Service Archive) format defines the
        /// function packages you want to deploy and the Amazon Web Services infrastructure you
        /// want to deploy them on.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateSolNetworkPackageContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateSolNetworkPackageContent service method, as returned by Tnb.</returns>
        /// <exception cref="Amazon.Tnb.Model.AccessDeniedException">
        /// Insufficient permissions to make request.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.InternalServerException">
        /// Unexpected error occurred. Problem on the server.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ResourceNotFoundException">
        /// Request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ThrottlingException">
        /// Exception caused by throttling.
        /// </exception>
        /// <exception cref="Amazon.Tnb.Model.ValidationException">
        /// Unable to process the request because the client provided input failed to satisfy
        /// request constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ValidateSolNetworkPackageContent">REST API Reference for ValidateSolNetworkPackageContent Operation</seealso>
        public virtual Task<ValidateSolNetworkPackageContentResponse> ValidateSolNetworkPackageContentAsync(ValidateSolNetworkPackageContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateSolNetworkPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateSolNetworkPackageContentResponseUnmarshaller.Instance;

            return InvokeAsync<ValidateSolNetworkPackageContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}