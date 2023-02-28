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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
        public virtual CancelSolNetworkOperationResponse CancelSolNetworkOperation(CancelSolNetworkOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSolNetworkOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSolNetworkOperationResponseUnmarshaller.Instance;

            return Invoke<CancelSolNetworkOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelSolNetworkOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSolNetworkOperation operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelSolNetworkOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/CancelSolNetworkOperation">REST API Reference for CancelSolNetworkOperation Operation</seealso>
        public virtual IAsyncResult BeginCancelSolNetworkOperation(CancelSolNetworkOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSolNetworkOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSolNetworkOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelSolNetworkOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelSolNetworkOperation.</param>
        /// 
        /// <returns>Returns a  CancelSolNetworkOperationResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/CancelSolNetworkOperation">REST API Reference for CancelSolNetworkOperation Operation</seealso>
        public virtual CancelSolNetworkOperationResponse EndCancelSolNetworkOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelSolNetworkOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSolFunctionPackage

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
        public virtual CreateSolFunctionPackageResponse CreateSolFunctionPackage(CreateSolFunctionPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSolFunctionPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSolFunctionPackageResponseUnmarshaller.Instance;

            return Invoke<CreateSolFunctionPackageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSolFunctionPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSolFunctionPackage operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSolFunctionPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/CreateSolFunctionPackage">REST API Reference for CreateSolFunctionPackage Operation</seealso>
        public virtual IAsyncResult BeginCreateSolFunctionPackage(CreateSolFunctionPackageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSolFunctionPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSolFunctionPackageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSolFunctionPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSolFunctionPackage.</param>
        /// 
        /// <returns>Returns a  CreateSolFunctionPackageResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/CreateSolFunctionPackage">REST API Reference for CreateSolFunctionPackage Operation</seealso>
        public virtual CreateSolFunctionPackageResponse EndCreateSolFunctionPackage(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSolFunctionPackageResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSolNetworkInstance

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
        public virtual CreateSolNetworkInstanceResponse CreateSolNetworkInstance(CreateSolNetworkInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSolNetworkInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateSolNetworkInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSolNetworkInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSolNetworkInstance operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSolNetworkInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/CreateSolNetworkInstance">REST API Reference for CreateSolNetworkInstance Operation</seealso>
        public virtual IAsyncResult BeginCreateSolNetworkInstance(CreateSolNetworkInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSolNetworkInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSolNetworkInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSolNetworkInstance.</param>
        /// 
        /// <returns>Returns a  CreateSolNetworkInstanceResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/CreateSolNetworkInstance">REST API Reference for CreateSolNetworkInstance Operation</seealso>
        public virtual CreateSolNetworkInstanceResponse EndCreateSolNetworkInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSolNetworkInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSolNetworkPackage

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
        public virtual CreateSolNetworkPackageResponse CreateSolNetworkPackage(CreateSolNetworkPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSolNetworkPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSolNetworkPackageResponseUnmarshaller.Instance;

            return Invoke<CreateSolNetworkPackageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSolNetworkPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSolNetworkPackage operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSolNetworkPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/CreateSolNetworkPackage">REST API Reference for CreateSolNetworkPackage Operation</seealso>
        public virtual IAsyncResult BeginCreateSolNetworkPackage(CreateSolNetworkPackageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSolNetworkPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSolNetworkPackageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSolNetworkPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSolNetworkPackage.</param>
        /// 
        /// <returns>Returns a  CreateSolNetworkPackageResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/CreateSolNetworkPackage">REST API Reference for CreateSolNetworkPackage Operation</seealso>
        public virtual CreateSolNetworkPackageResponse EndCreateSolNetworkPackage(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSolNetworkPackageResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSolFunctionPackage

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
        public virtual DeleteSolFunctionPackageResponse DeleteSolFunctionPackage(DeleteSolFunctionPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSolFunctionPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSolFunctionPackageResponseUnmarshaller.Instance;

            return Invoke<DeleteSolFunctionPackageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSolFunctionPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSolFunctionPackage operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSolFunctionPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/DeleteSolFunctionPackage">REST API Reference for DeleteSolFunctionPackage Operation</seealso>
        public virtual IAsyncResult BeginDeleteSolFunctionPackage(DeleteSolFunctionPackageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSolFunctionPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSolFunctionPackageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSolFunctionPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSolFunctionPackage.</param>
        /// 
        /// <returns>Returns a  DeleteSolFunctionPackageResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/DeleteSolFunctionPackage">REST API Reference for DeleteSolFunctionPackage Operation</seealso>
        public virtual DeleteSolFunctionPackageResponse EndDeleteSolFunctionPackage(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSolFunctionPackageResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSolNetworkInstance

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
        public virtual DeleteSolNetworkInstanceResponse DeleteSolNetworkInstance(DeleteSolNetworkInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSolNetworkInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteSolNetworkInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSolNetworkInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSolNetworkInstance operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSolNetworkInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/DeleteSolNetworkInstance">REST API Reference for DeleteSolNetworkInstance Operation</seealso>
        public virtual IAsyncResult BeginDeleteSolNetworkInstance(DeleteSolNetworkInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSolNetworkInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSolNetworkInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSolNetworkInstance.</param>
        /// 
        /// <returns>Returns a  DeleteSolNetworkInstanceResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/DeleteSolNetworkInstance">REST API Reference for DeleteSolNetworkInstance Operation</seealso>
        public virtual DeleteSolNetworkInstanceResponse EndDeleteSolNetworkInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSolNetworkInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSolNetworkPackage

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
        public virtual DeleteSolNetworkPackageResponse DeleteSolNetworkPackage(DeleteSolNetworkPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSolNetworkPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSolNetworkPackageResponseUnmarshaller.Instance;

            return Invoke<DeleteSolNetworkPackageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSolNetworkPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSolNetworkPackage operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSolNetworkPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/DeleteSolNetworkPackage">REST API Reference for DeleteSolNetworkPackage Operation</seealso>
        public virtual IAsyncResult BeginDeleteSolNetworkPackage(DeleteSolNetworkPackageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSolNetworkPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSolNetworkPackageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSolNetworkPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSolNetworkPackage.</param>
        /// 
        /// <returns>Returns a  DeleteSolNetworkPackageResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/DeleteSolNetworkPackage">REST API Reference for DeleteSolNetworkPackage Operation</seealso>
        public virtual DeleteSolNetworkPackageResponse EndDeleteSolNetworkPackage(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSolNetworkPackageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSolFunctionInstance

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
        public virtual GetSolFunctionInstanceResponse GetSolFunctionInstance(GetSolFunctionInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolFunctionInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolFunctionInstanceResponseUnmarshaller.Instance;

            return Invoke<GetSolFunctionInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSolFunctionInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSolFunctionInstance operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSolFunctionInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolFunctionInstance">REST API Reference for GetSolFunctionInstance Operation</seealso>
        public virtual IAsyncResult BeginGetSolFunctionInstance(GetSolFunctionInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolFunctionInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolFunctionInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSolFunctionInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSolFunctionInstance.</param>
        /// 
        /// <returns>Returns a  GetSolFunctionInstanceResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolFunctionInstance">REST API Reference for GetSolFunctionInstance Operation</seealso>
        public virtual GetSolFunctionInstanceResponse EndGetSolFunctionInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSolFunctionInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSolFunctionPackage

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
        public virtual GetSolFunctionPackageResponse GetSolFunctionPackage(GetSolFunctionPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolFunctionPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolFunctionPackageResponseUnmarshaller.Instance;

            return Invoke<GetSolFunctionPackageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSolFunctionPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSolFunctionPackage operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSolFunctionPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolFunctionPackage">REST API Reference for GetSolFunctionPackage Operation</seealso>
        public virtual IAsyncResult BeginGetSolFunctionPackage(GetSolFunctionPackageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolFunctionPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolFunctionPackageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSolFunctionPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSolFunctionPackage.</param>
        /// 
        /// <returns>Returns a  GetSolFunctionPackageResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolFunctionPackage">REST API Reference for GetSolFunctionPackage Operation</seealso>
        public virtual GetSolFunctionPackageResponse EndGetSolFunctionPackage(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSolFunctionPackageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSolFunctionPackageContent

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
        public virtual GetSolFunctionPackageContentResponse GetSolFunctionPackageContent(GetSolFunctionPackageContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolFunctionPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolFunctionPackageContentResponseUnmarshaller.Instance;

            return Invoke<GetSolFunctionPackageContentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSolFunctionPackageContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSolFunctionPackageContent operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSolFunctionPackageContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolFunctionPackageContent">REST API Reference for GetSolFunctionPackageContent Operation</seealso>
        public virtual IAsyncResult BeginGetSolFunctionPackageContent(GetSolFunctionPackageContentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolFunctionPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolFunctionPackageContentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSolFunctionPackageContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSolFunctionPackageContent.</param>
        /// 
        /// <returns>Returns a  GetSolFunctionPackageContentResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolFunctionPackageContent">REST API Reference for GetSolFunctionPackageContent Operation</seealso>
        public virtual GetSolFunctionPackageContentResponse EndGetSolFunctionPackageContent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSolFunctionPackageContentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSolFunctionPackageDescriptor

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
        public virtual GetSolFunctionPackageDescriptorResponse GetSolFunctionPackageDescriptor(GetSolFunctionPackageDescriptorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolFunctionPackageDescriptorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolFunctionPackageDescriptorResponseUnmarshaller.Instance;

            return Invoke<GetSolFunctionPackageDescriptorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSolFunctionPackageDescriptor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSolFunctionPackageDescriptor operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSolFunctionPackageDescriptor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolFunctionPackageDescriptor">REST API Reference for GetSolFunctionPackageDescriptor Operation</seealso>
        public virtual IAsyncResult BeginGetSolFunctionPackageDescriptor(GetSolFunctionPackageDescriptorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolFunctionPackageDescriptorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolFunctionPackageDescriptorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSolFunctionPackageDescriptor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSolFunctionPackageDescriptor.</param>
        /// 
        /// <returns>Returns a  GetSolFunctionPackageDescriptorResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolFunctionPackageDescriptor">REST API Reference for GetSolFunctionPackageDescriptor Operation</seealso>
        public virtual GetSolFunctionPackageDescriptorResponse EndGetSolFunctionPackageDescriptor(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSolFunctionPackageDescriptorResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSolNetworkInstance

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
        public virtual GetSolNetworkInstanceResponse GetSolNetworkInstance(GetSolNetworkInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolNetworkInstanceResponseUnmarshaller.Instance;

            return Invoke<GetSolNetworkInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSolNetworkInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSolNetworkInstance operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSolNetworkInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolNetworkInstance">REST API Reference for GetSolNetworkInstance Operation</seealso>
        public virtual IAsyncResult BeginGetSolNetworkInstance(GetSolNetworkInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolNetworkInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSolNetworkInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSolNetworkInstance.</param>
        /// 
        /// <returns>Returns a  GetSolNetworkInstanceResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolNetworkInstance">REST API Reference for GetSolNetworkInstance Operation</seealso>
        public virtual GetSolNetworkInstanceResponse EndGetSolNetworkInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSolNetworkInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSolNetworkOperation

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
        public virtual GetSolNetworkOperationResponse GetSolNetworkOperation(GetSolNetworkOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolNetworkOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolNetworkOperationResponseUnmarshaller.Instance;

            return Invoke<GetSolNetworkOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSolNetworkOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSolNetworkOperation operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSolNetworkOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolNetworkOperation">REST API Reference for GetSolNetworkOperation Operation</seealso>
        public virtual IAsyncResult BeginGetSolNetworkOperation(GetSolNetworkOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolNetworkOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolNetworkOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSolNetworkOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSolNetworkOperation.</param>
        /// 
        /// <returns>Returns a  GetSolNetworkOperationResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolNetworkOperation">REST API Reference for GetSolNetworkOperation Operation</seealso>
        public virtual GetSolNetworkOperationResponse EndGetSolNetworkOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSolNetworkOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSolNetworkPackage

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
        public virtual GetSolNetworkPackageResponse GetSolNetworkPackage(GetSolNetworkPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolNetworkPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolNetworkPackageResponseUnmarshaller.Instance;

            return Invoke<GetSolNetworkPackageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSolNetworkPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSolNetworkPackage operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSolNetworkPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolNetworkPackage">REST API Reference for GetSolNetworkPackage Operation</seealso>
        public virtual IAsyncResult BeginGetSolNetworkPackage(GetSolNetworkPackageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolNetworkPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolNetworkPackageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSolNetworkPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSolNetworkPackage.</param>
        /// 
        /// <returns>Returns a  GetSolNetworkPackageResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolNetworkPackage">REST API Reference for GetSolNetworkPackage Operation</seealso>
        public virtual GetSolNetworkPackageResponse EndGetSolNetworkPackage(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSolNetworkPackageResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSolNetworkPackageContent

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
        public virtual GetSolNetworkPackageContentResponse GetSolNetworkPackageContent(GetSolNetworkPackageContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolNetworkPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolNetworkPackageContentResponseUnmarshaller.Instance;

            return Invoke<GetSolNetworkPackageContentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSolNetworkPackageContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSolNetworkPackageContent operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSolNetworkPackageContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolNetworkPackageContent">REST API Reference for GetSolNetworkPackageContent Operation</seealso>
        public virtual IAsyncResult BeginGetSolNetworkPackageContent(GetSolNetworkPackageContentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolNetworkPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolNetworkPackageContentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSolNetworkPackageContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSolNetworkPackageContent.</param>
        /// 
        /// <returns>Returns a  GetSolNetworkPackageContentResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolNetworkPackageContent">REST API Reference for GetSolNetworkPackageContent Operation</seealso>
        public virtual GetSolNetworkPackageContentResponse EndGetSolNetworkPackageContent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSolNetworkPackageContentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSolNetworkPackageDescriptor

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
        public virtual GetSolNetworkPackageDescriptorResponse GetSolNetworkPackageDescriptor(GetSolNetworkPackageDescriptorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolNetworkPackageDescriptorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolNetworkPackageDescriptorResponseUnmarshaller.Instance;

            return Invoke<GetSolNetworkPackageDescriptorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSolNetworkPackageDescriptor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSolNetworkPackageDescriptor operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSolNetworkPackageDescriptor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolNetworkPackageDescriptor">REST API Reference for GetSolNetworkPackageDescriptor Operation</seealso>
        public virtual IAsyncResult BeginGetSolNetworkPackageDescriptor(GetSolNetworkPackageDescriptorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSolNetworkPackageDescriptorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSolNetworkPackageDescriptorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSolNetworkPackageDescriptor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSolNetworkPackageDescriptor.</param>
        /// 
        /// <returns>Returns a  GetSolNetworkPackageDescriptorResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/GetSolNetworkPackageDescriptor">REST API Reference for GetSolNetworkPackageDescriptor Operation</seealso>
        public virtual GetSolNetworkPackageDescriptorResponse EndGetSolNetworkPackageDescriptor(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSolNetworkPackageDescriptorResponse>(asyncResult);
        }

        #endregion
        
        #region  InstantiateSolNetworkInstance

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
        public virtual InstantiateSolNetworkInstanceResponse InstantiateSolNetworkInstance(InstantiateSolNetworkInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InstantiateSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InstantiateSolNetworkInstanceResponseUnmarshaller.Instance;

            return Invoke<InstantiateSolNetworkInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InstantiateSolNetworkInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InstantiateSolNetworkInstance operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInstantiateSolNetworkInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/InstantiateSolNetworkInstance">REST API Reference for InstantiateSolNetworkInstance Operation</seealso>
        public virtual IAsyncResult BeginInstantiateSolNetworkInstance(InstantiateSolNetworkInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InstantiateSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InstantiateSolNetworkInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  InstantiateSolNetworkInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInstantiateSolNetworkInstance.</param>
        /// 
        /// <returns>Returns a  InstantiateSolNetworkInstanceResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/InstantiateSolNetworkInstance">REST API Reference for InstantiateSolNetworkInstance Operation</seealso>
        public virtual InstantiateSolNetworkInstanceResponse EndInstantiateSolNetworkInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<InstantiateSolNetworkInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSolFunctionInstances

        /// <summary>
        /// Lists network function instances.
        /// 
        ///  
        /// <para>
        /// A network function instance is a function in a function package .
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSolFunctionInstances service method.</param>
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
        public virtual ListSolFunctionInstancesResponse ListSolFunctionInstances(ListSolFunctionInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolFunctionInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolFunctionInstancesResponseUnmarshaller.Instance;

            return Invoke<ListSolFunctionInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSolFunctionInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSolFunctionInstances operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSolFunctionInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListSolFunctionInstances">REST API Reference for ListSolFunctionInstances Operation</seealso>
        public virtual IAsyncResult BeginListSolFunctionInstances(ListSolFunctionInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolFunctionInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolFunctionInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSolFunctionInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSolFunctionInstances.</param>
        /// 
        /// <returns>Returns a  ListSolFunctionInstancesResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListSolFunctionInstances">REST API Reference for ListSolFunctionInstances Operation</seealso>
        public virtual ListSolFunctionInstancesResponse EndListSolFunctionInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSolFunctionInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSolFunctionPackages

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
        public virtual ListSolFunctionPackagesResponse ListSolFunctionPackages(ListSolFunctionPackagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolFunctionPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolFunctionPackagesResponseUnmarshaller.Instance;

            return Invoke<ListSolFunctionPackagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSolFunctionPackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSolFunctionPackages operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSolFunctionPackages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListSolFunctionPackages">REST API Reference for ListSolFunctionPackages Operation</seealso>
        public virtual IAsyncResult BeginListSolFunctionPackages(ListSolFunctionPackagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolFunctionPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolFunctionPackagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSolFunctionPackages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSolFunctionPackages.</param>
        /// 
        /// <returns>Returns a  ListSolFunctionPackagesResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListSolFunctionPackages">REST API Reference for ListSolFunctionPackages Operation</seealso>
        public virtual ListSolFunctionPackagesResponse EndListSolFunctionPackages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSolFunctionPackagesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSolNetworkInstances

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
        public virtual ListSolNetworkInstancesResponse ListSolNetworkInstances(ListSolNetworkInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolNetworkInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolNetworkInstancesResponseUnmarshaller.Instance;

            return Invoke<ListSolNetworkInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSolNetworkInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSolNetworkInstances operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSolNetworkInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListSolNetworkInstances">REST API Reference for ListSolNetworkInstances Operation</seealso>
        public virtual IAsyncResult BeginListSolNetworkInstances(ListSolNetworkInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolNetworkInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolNetworkInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSolNetworkInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSolNetworkInstances.</param>
        /// 
        /// <returns>Returns a  ListSolNetworkInstancesResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListSolNetworkInstances">REST API Reference for ListSolNetworkInstances Operation</seealso>
        public virtual ListSolNetworkInstancesResponse EndListSolNetworkInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSolNetworkInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSolNetworkOperations

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
        public virtual ListSolNetworkOperationsResponse ListSolNetworkOperations(ListSolNetworkOperationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolNetworkOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolNetworkOperationsResponseUnmarshaller.Instance;

            return Invoke<ListSolNetworkOperationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSolNetworkOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSolNetworkOperations operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSolNetworkOperations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListSolNetworkOperations">REST API Reference for ListSolNetworkOperations Operation</seealso>
        public virtual IAsyncResult BeginListSolNetworkOperations(ListSolNetworkOperationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolNetworkOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolNetworkOperationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSolNetworkOperations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSolNetworkOperations.</param>
        /// 
        /// <returns>Returns a  ListSolNetworkOperationsResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListSolNetworkOperations">REST API Reference for ListSolNetworkOperations Operation</seealso>
        public virtual ListSolNetworkOperationsResponse EndListSolNetworkOperations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSolNetworkOperationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSolNetworkPackages

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
        public virtual ListSolNetworkPackagesResponse ListSolNetworkPackages(ListSolNetworkPackagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolNetworkPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolNetworkPackagesResponseUnmarshaller.Instance;

            return Invoke<ListSolNetworkPackagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSolNetworkPackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSolNetworkPackages operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSolNetworkPackages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListSolNetworkPackages">REST API Reference for ListSolNetworkPackages Operation</seealso>
        public virtual IAsyncResult BeginListSolNetworkPackages(ListSolNetworkPackagesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSolNetworkPackagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSolNetworkPackagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSolNetworkPackages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSolNetworkPackages.</param>
        /// 
        /// <returns>Returns a  ListSolNetworkPackagesResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListSolNetworkPackages">REST API Reference for ListSolNetworkPackages Operation</seealso>
        public virtual ListSolNetworkPackagesResponse EndListSolNetworkPackages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSolNetworkPackagesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists tags for AWS TNB resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutSolFunctionPackageContent

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
        public virtual PutSolFunctionPackageContentResponse PutSolFunctionPackageContent(PutSolFunctionPackageContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSolFunctionPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSolFunctionPackageContentResponseUnmarshaller.Instance;

            return Invoke<PutSolFunctionPackageContentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutSolFunctionPackageContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSolFunctionPackageContent operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSolFunctionPackageContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/PutSolFunctionPackageContent">REST API Reference for PutSolFunctionPackageContent Operation</seealso>
        public virtual IAsyncResult BeginPutSolFunctionPackageContent(PutSolFunctionPackageContentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSolFunctionPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSolFunctionPackageContentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutSolFunctionPackageContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSolFunctionPackageContent.</param>
        /// 
        /// <returns>Returns a  PutSolFunctionPackageContentResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/PutSolFunctionPackageContent">REST API Reference for PutSolFunctionPackageContent Operation</seealso>
        public virtual PutSolFunctionPackageContentResponse EndPutSolFunctionPackageContent(IAsyncResult asyncResult)
        {
            return EndInvoke<PutSolFunctionPackageContentResponse>(asyncResult);
        }

        #endregion
        
        #region  PutSolNetworkPackageContent

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
        public virtual PutSolNetworkPackageContentResponse PutSolNetworkPackageContent(PutSolNetworkPackageContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSolNetworkPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSolNetworkPackageContentResponseUnmarshaller.Instance;

            return Invoke<PutSolNetworkPackageContentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutSolNetworkPackageContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSolNetworkPackageContent operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSolNetworkPackageContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/PutSolNetworkPackageContent">REST API Reference for PutSolNetworkPackageContent Operation</seealso>
        public virtual IAsyncResult BeginPutSolNetworkPackageContent(PutSolNetworkPackageContentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSolNetworkPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSolNetworkPackageContentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutSolNetworkPackageContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSolNetworkPackageContent.</param>
        /// 
        /// <returns>Returns a  PutSolNetworkPackageContentResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/PutSolNetworkPackageContent">REST API Reference for PutSolNetworkPackageContent Operation</seealso>
        public virtual PutSolNetworkPackageContentResponse EndPutSolNetworkPackageContent(IAsyncResult asyncResult)
        {
            return EndInvoke<PutSolNetworkPackageContentResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TerminateSolNetworkInstance

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
        public virtual TerminateSolNetworkInstanceResponse TerminateSolNetworkInstance(TerminateSolNetworkInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateSolNetworkInstanceResponseUnmarshaller.Instance;

            return Invoke<TerminateSolNetworkInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateSolNetworkInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateSolNetworkInstance operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateSolNetworkInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/TerminateSolNetworkInstance">REST API Reference for TerminateSolNetworkInstance Operation</seealso>
        public virtual IAsyncResult BeginTerminateSolNetworkInstance(TerminateSolNetworkInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateSolNetworkInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateSolNetworkInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateSolNetworkInstance.</param>
        /// 
        /// <returns>Returns a  TerminateSolNetworkInstanceResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/TerminateSolNetworkInstance">REST API Reference for TerminateSolNetworkInstance Operation</seealso>
        public virtual TerminateSolNetworkInstanceResponse EndTerminateSolNetworkInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateSolNetworkInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSolFunctionPackage

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
        public virtual UpdateSolFunctionPackageResponse UpdateSolFunctionPackage(UpdateSolFunctionPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSolFunctionPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSolFunctionPackageResponseUnmarshaller.Instance;

            return Invoke<UpdateSolFunctionPackageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSolFunctionPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSolFunctionPackage operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSolFunctionPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/UpdateSolFunctionPackage">REST API Reference for UpdateSolFunctionPackage Operation</seealso>
        public virtual IAsyncResult BeginUpdateSolFunctionPackage(UpdateSolFunctionPackageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSolFunctionPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSolFunctionPackageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSolFunctionPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSolFunctionPackage.</param>
        /// 
        /// <returns>Returns a  UpdateSolFunctionPackageResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/UpdateSolFunctionPackage">REST API Reference for UpdateSolFunctionPackage Operation</seealso>
        public virtual UpdateSolFunctionPackageResponse EndUpdateSolFunctionPackage(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSolFunctionPackageResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSolNetworkInstance

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
        public virtual UpdateSolNetworkInstanceResponse UpdateSolNetworkInstance(UpdateSolNetworkInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSolNetworkInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateSolNetworkInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSolNetworkInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSolNetworkInstance operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSolNetworkInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/UpdateSolNetworkInstance">REST API Reference for UpdateSolNetworkInstance Operation</seealso>
        public virtual IAsyncResult BeginUpdateSolNetworkInstance(UpdateSolNetworkInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSolNetworkInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSolNetworkInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSolNetworkInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSolNetworkInstance.</param>
        /// 
        /// <returns>Returns a  UpdateSolNetworkInstanceResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/UpdateSolNetworkInstance">REST API Reference for UpdateSolNetworkInstance Operation</seealso>
        public virtual UpdateSolNetworkInstanceResponse EndUpdateSolNetworkInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSolNetworkInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSolNetworkPackage

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
        public virtual UpdateSolNetworkPackageResponse UpdateSolNetworkPackage(UpdateSolNetworkPackageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSolNetworkPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSolNetworkPackageResponseUnmarshaller.Instance;

            return Invoke<UpdateSolNetworkPackageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSolNetworkPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSolNetworkPackage operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSolNetworkPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/UpdateSolNetworkPackage">REST API Reference for UpdateSolNetworkPackage Operation</seealso>
        public virtual IAsyncResult BeginUpdateSolNetworkPackage(UpdateSolNetworkPackageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSolNetworkPackageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSolNetworkPackageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSolNetworkPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSolNetworkPackage.</param>
        /// 
        /// <returns>Returns a  UpdateSolNetworkPackageResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/UpdateSolNetworkPackage">REST API Reference for UpdateSolNetworkPackage Operation</seealso>
        public virtual UpdateSolNetworkPackageResponse EndUpdateSolNetworkPackage(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSolNetworkPackageResponse>(asyncResult);
        }

        #endregion
        
        #region  ValidateSolFunctionPackageContent

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
        public virtual ValidateSolFunctionPackageContentResponse ValidateSolFunctionPackageContent(ValidateSolFunctionPackageContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateSolFunctionPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateSolFunctionPackageContentResponseUnmarshaller.Instance;

            return Invoke<ValidateSolFunctionPackageContentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateSolFunctionPackageContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateSolFunctionPackageContent operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidateSolFunctionPackageContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ValidateSolFunctionPackageContent">REST API Reference for ValidateSolFunctionPackageContent Operation</seealso>
        public virtual IAsyncResult BeginValidateSolFunctionPackageContent(ValidateSolFunctionPackageContentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateSolFunctionPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateSolFunctionPackageContentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ValidateSolFunctionPackageContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateSolFunctionPackageContent.</param>
        /// 
        /// <returns>Returns a  ValidateSolFunctionPackageContentResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ValidateSolFunctionPackageContent">REST API Reference for ValidateSolFunctionPackageContent Operation</seealso>
        public virtual ValidateSolFunctionPackageContentResponse EndValidateSolFunctionPackageContent(IAsyncResult asyncResult)
        {
            return EndInvoke<ValidateSolFunctionPackageContentResponse>(asyncResult);
        }

        #endregion
        
        #region  ValidateSolNetworkPackageContent

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
        public virtual ValidateSolNetworkPackageContentResponse ValidateSolNetworkPackageContent(ValidateSolNetworkPackageContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateSolNetworkPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateSolNetworkPackageContentResponseUnmarshaller.Instance;

            return Invoke<ValidateSolNetworkPackageContentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateSolNetworkPackageContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateSolNetworkPackageContent operation on AmazonTnbClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidateSolNetworkPackageContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ValidateSolNetworkPackageContent">REST API Reference for ValidateSolNetworkPackageContent Operation</seealso>
        public virtual IAsyncResult BeginValidateSolNetworkPackageContent(ValidateSolNetworkPackageContentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateSolNetworkPackageContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateSolNetworkPackageContentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ValidateSolNetworkPackageContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateSolNetworkPackageContent.</param>
        /// 
        /// <returns>Returns a  ValidateSolNetworkPackageContentResult from Tnb.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/tnb-2008-10-21/ValidateSolNetworkPackageContent">REST API Reference for ValidateSolNetworkPackageContent Operation</seealso>
        public virtual ValidateSolNetworkPackageContentResponse EndValidateSolNetworkPackageContent(IAsyncResult asyncResult)
        {
            return EndInvoke<ValidateSolNetworkPackageContentResponse>(asyncResult);
        }

        #endregion
        
    }
}