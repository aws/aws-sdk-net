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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.DirectoryService.Model;
using Amazon.DirectoryService.Model.Internal.MarshallTransformations;
using Amazon.DirectoryService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.DirectoryService
{
    /// <summary>
    /// Implementation for accessing DirectoryService
    ///
    /// AWS Directory Service 
    /// <para>
    /// AWS Directory Service is a web service that makes it easy for you to setup and run
    /// directories in the AWS cloud, or connect your AWS resources with an existing on-premises
    /// Microsoft Active Directory. This guide provides detailed information about AWS Directory
    /// Service operations, data types, parameters, and errors. For information about AWS
    /// Directory Services features, see <a href="https://aws.amazon.com/directoryservice/">AWS
    /// Directory Service</a> and the <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/what_is.html">AWS
    /// Directory Service Administration Guide</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// AWS provides SDKs that consist of libraries and sample code for various programming
    /// languages and platforms (Java, Ruby, .Net, iOS, Android, etc.). The SDKs provide a
    /// convenient way to create programmatic access to AWS Directory Service and other AWS
    /// services. For more information about the AWS SDKs, including how to download and install
    /// them, see <a href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AmazonDirectoryServiceClient : AmazonServiceClient, IAmazonDirectoryService
    {
        private static IServiceMetadata serviceMetadata = new AmazonDirectoryServiceMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with the credentials loaded from the application's
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
        public AmazonDirectoryServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDirectoryServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with the credentials loaded from the application's
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
        public AmazonDirectoryServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDirectoryServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDirectoryServiceClient Configuration Object</param>
        public AmazonDirectoryServiceClient(AmazonDirectoryServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDirectoryServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonDirectoryServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectoryServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDirectoryServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Credentials and an
        /// AmazonDirectoryServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDirectoryServiceClient Configuration Object</param>
        public AmazonDirectoryServiceClient(AWSCredentials credentials, AmazonDirectoryServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDirectoryServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDirectoryServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectoryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDirectoryServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDirectoryServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDirectoryServiceClient Configuration Object</param>
        public AmazonDirectoryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDirectoryServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDirectoryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDirectoryServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectoryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDirectoryServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectoryServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDirectoryServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDirectoryServiceClient Configuration Object</param>
        public AmazonDirectoryServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDirectoryServiceConfig clientConfig)
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


        #region  AcceptSharedDirectory

        internal virtual AcceptSharedDirectoryResponse AcceptSharedDirectory(AcceptSharedDirectoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptSharedDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptSharedDirectoryResponseUnmarshaller.Instance;

            return Invoke<AcceptSharedDirectoryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AcceptSharedDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptSharedDirectory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/AcceptSharedDirectory">REST API Reference for AcceptSharedDirectory Operation</seealso>
        public virtual Task<AcceptSharedDirectoryResponse> AcceptSharedDirectoryAsync(AcceptSharedDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptSharedDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptSharedDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptSharedDirectoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddIpRoutes

        internal virtual AddIpRoutesResponse AddIpRoutes(AddIpRoutesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddIpRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddIpRoutesResponseUnmarshaller.Instance;

            return Invoke<AddIpRoutesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddIpRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddIpRoutes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/AddIpRoutes">REST API Reference for AddIpRoutes Operation</seealso>
        public virtual Task<AddIpRoutesResponse> AddIpRoutesAsync(AddIpRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddIpRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddIpRoutesResponseUnmarshaller.Instance;

            return InvokeAsync<AddIpRoutesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddTagsToResource

        internal virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsToResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelSchemaExtension

        internal virtual CancelSchemaExtensionResponse CancelSchemaExtension(CancelSchemaExtensionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSchemaExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSchemaExtensionResponseUnmarshaller.Instance;

            return Invoke<CancelSchemaExtensionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelSchemaExtension operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSchemaExtension operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CancelSchemaExtension">REST API Reference for CancelSchemaExtension Operation</seealso>
        public virtual Task<CancelSchemaExtensionResponse> CancelSchemaExtensionAsync(CancelSchemaExtensionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSchemaExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSchemaExtensionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelSchemaExtensionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConnectDirectory

        internal virtual ConnectDirectoryResponse ConnectDirectory(ConnectDirectoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConnectDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConnectDirectoryResponseUnmarshaller.Instance;

            return Invoke<ConnectDirectoryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ConnectDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConnectDirectory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ConnectDirectory">REST API Reference for ConnectDirectory Operation</seealso>
        public virtual Task<ConnectDirectoryResponse> ConnectDirectoryAsync(ConnectDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConnectDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConnectDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<ConnectDirectoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAlias

        internal virtual CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateComputer

        internal virtual CreateComputerResponse CreateComputer(CreateComputerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComputerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComputerResponseUnmarshaller.Instance;

            return Invoke<CreateComputerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateComputer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateComputer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateComputer">REST API Reference for CreateComputer Operation</seealso>
        public virtual Task<CreateComputerResponse> CreateComputerAsync(CreateComputerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComputerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComputerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateComputerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConditionalForwarder

        internal virtual CreateConditionalForwarderResponse CreateConditionalForwarder(CreateConditionalForwarderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConditionalForwarderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConditionalForwarderResponseUnmarshaller.Instance;

            return Invoke<CreateConditionalForwarderResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateConditionalForwarder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConditionalForwarder operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateConditionalForwarder">REST API Reference for CreateConditionalForwarder Operation</seealso>
        public virtual Task<CreateConditionalForwarderResponse> CreateConditionalForwarderAsync(CreateConditionalForwarderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConditionalForwarderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConditionalForwarderResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConditionalForwarderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDirectory

        internal virtual CreateDirectoryResponse CreateDirectory(CreateDirectoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return Invoke<CreateDirectoryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateDirectory">REST API Reference for CreateDirectory Operation</seealso>
        public virtual Task<CreateDirectoryResponse> CreateDirectoryAsync(CreateDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDirectoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLogSubscription

        internal virtual CreateLogSubscriptionResponse CreateLogSubscription(CreateLogSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLogSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateLogSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLogSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLogSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateLogSubscription">REST API Reference for CreateLogSubscription Operation</seealso>
        public virtual Task<CreateLogSubscriptionResponse> CreateLogSubscriptionAsync(CreateLogSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLogSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLogSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMicrosoftAD

        internal virtual CreateMicrosoftADResponse CreateMicrosoftAD(CreateMicrosoftADRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMicrosoftADRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMicrosoftADResponseUnmarshaller.Instance;

            return Invoke<CreateMicrosoftADResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateMicrosoftAD operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMicrosoftAD operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateMicrosoftAD">REST API Reference for CreateMicrosoftAD Operation</seealso>
        public virtual Task<CreateMicrosoftADResponse> CreateMicrosoftADAsync(CreateMicrosoftADRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMicrosoftADRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMicrosoftADResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMicrosoftADResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshot

        internal virtual CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTrust

        internal virtual CreateTrustResponse CreateTrust(CreateTrustRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrustResponseUnmarshaller.Instance;

            return Invoke<CreateTrustResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrust operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrust operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/CreateTrust">REST API Reference for CreateTrust Operation</seealso>
        public virtual Task<CreateTrustResponse> CreateTrustAsync(CreateTrustRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrustResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrustResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConditionalForwarder

        internal virtual DeleteConditionalForwarderResponse DeleteConditionalForwarder(DeleteConditionalForwarderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConditionalForwarderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConditionalForwarderResponseUnmarshaller.Instance;

            return Invoke<DeleteConditionalForwarderResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConditionalForwarder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConditionalForwarder operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteConditionalForwarder">REST API Reference for DeleteConditionalForwarder Operation</seealso>
        public virtual Task<DeleteConditionalForwarderResponse> DeleteConditionalForwarderAsync(DeleteConditionalForwarderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConditionalForwarderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConditionalForwarderResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConditionalForwarderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDirectory

        internal virtual DeleteDirectoryResponse DeleteDirectory(DeleteDirectoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectoryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteDirectory">REST API Reference for DeleteDirectory Operation</seealso>
        public virtual Task<DeleteDirectoryResponse> DeleteDirectoryAsync(DeleteDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDirectoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLogSubscription

        internal virtual DeleteLogSubscriptionResponse DeleteLogSubscription(DeleteLogSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLogSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLogSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteLogSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLogSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteLogSubscription">REST API Reference for DeleteLogSubscription Operation</seealso>
        public virtual Task<DeleteLogSubscriptionResponse> DeleteLogSubscriptionAsync(DeleteLogSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLogSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLogSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLogSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSnapshot

        internal virtual DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        public virtual Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrust

        internal virtual DeleteTrustResponse DeleteTrust(DeleteTrustRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrustResponseUnmarshaller.Instance;

            return Invoke<DeleteTrustResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrust operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrust operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeleteTrust">REST API Reference for DeleteTrust Operation</seealso>
        public virtual Task<DeleteTrustResponse> DeleteTrustAsync(DeleteTrustRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrustResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrustResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterEventTopic

        internal virtual DeregisterEventTopicResponse DeregisterEventTopic(DeregisterEventTopicRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterEventTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterEventTopicResponseUnmarshaller.Instance;

            return Invoke<DeregisterEventTopicResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterEventTopic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterEventTopic operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DeregisterEventTopic">REST API Reference for DeregisterEventTopic Operation</seealso>
        public virtual Task<DeregisterEventTopicResponse> DeregisterEventTopicAsync(DeregisterEventTopicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterEventTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterEventTopicResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterEventTopicResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConditionalForwarders

        internal virtual DescribeConditionalForwardersResponse DescribeConditionalForwarders(DescribeConditionalForwardersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConditionalForwardersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConditionalForwardersResponseUnmarshaller.Instance;

            return Invoke<DescribeConditionalForwardersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConditionalForwarders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConditionalForwarders operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeConditionalForwarders">REST API Reference for DescribeConditionalForwarders Operation</seealso>
        public virtual Task<DescribeConditionalForwardersResponse> DescribeConditionalForwardersAsync(DescribeConditionalForwardersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConditionalForwardersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConditionalForwardersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConditionalForwardersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDirectories

        internal virtual DescribeDirectoriesResponse DescribeDirectories()
        {
            return DescribeDirectories(new DescribeDirectoriesRequest());
        }
        internal virtual DescribeDirectoriesResponse DescribeDirectories(DescribeDirectoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeDirectoriesResponse>(request, options);
        }


        /// <summary>
        /// Obtains information about the directories that belong to this account.
        /// 
        ///  
        /// <para>
        /// You can retrieve information about specific directories by passing the directory identifiers
        /// in the <code>DirectoryIds</code> parameter. Otherwise, all directories that belong
        /// to the current account are returned.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <code>NextToken</code> request
        /// and response parameters. If more results are available, the <code>DescribeDirectoriesResult.NextToken</code>
        /// member contains a token that you pass in the next call to <a>DescribeDirectories</a>
        /// to retrieve the next set of items.
        /// </para>
        ///  
        /// <para>
        /// You can also specify a maximum number of return results with the <code>Limit</code>
        /// parameter.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDirectories service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeDirectories">REST API Reference for DescribeDirectories Operation</seealso>
        public virtual Task<DescribeDirectoriesResponse> DescribeDirectoriesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDirectoriesAsync(new DescribeDirectoriesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDirectories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeDirectories">REST API Reference for DescribeDirectories Operation</seealso>
        public virtual Task<DescribeDirectoriesResponse> DescribeDirectoriesAsync(DescribeDirectoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectoriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDirectoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDomainControllers

        internal virtual DescribeDomainControllersResponse DescribeDomainControllers(DescribeDomainControllersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainControllersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainControllersResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainControllersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomainControllers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainControllers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeDomainControllers">REST API Reference for DescribeDomainControllers Operation</seealso>
        public virtual Task<DescribeDomainControllersResponse> DescribeDomainControllersAsync(DescribeDomainControllersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainControllersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainControllersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDomainControllersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventTopics

        internal virtual DescribeEventTopicsResponse DescribeEventTopics(DescribeEventTopicsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventTopicsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventTopicsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventTopicsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventTopics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventTopics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeEventTopics">REST API Reference for DescribeEventTopics Operation</seealso>
        public virtual Task<DescribeEventTopicsResponse> DescribeEventTopicsAsync(DescribeEventTopicsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventTopicsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventTopicsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventTopicsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSharedDirectories

        internal virtual DescribeSharedDirectoriesResponse DescribeSharedDirectories(DescribeSharedDirectoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSharedDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSharedDirectoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeSharedDirectoriesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSharedDirectories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSharedDirectories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeSharedDirectories">REST API Reference for DescribeSharedDirectories Operation</seealso>
        public virtual Task<DescribeSharedDirectoriesResponse> DescribeSharedDirectoriesAsync(DescribeSharedDirectoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSharedDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSharedDirectoriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSharedDirectoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshots

        internal virtual DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        public virtual Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTrusts

        internal virtual DescribeTrustsResponse DescribeTrusts(DescribeTrustsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrustsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrustsResponseUnmarshaller.Instance;

            return Invoke<DescribeTrustsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrusts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrusts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DescribeTrusts">REST API Reference for DescribeTrusts Operation</seealso>
        public virtual Task<DescribeTrustsResponse> DescribeTrustsAsync(DescribeTrustsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTrustsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTrustsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTrustsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableRadius

        internal virtual DisableRadiusResponse DisableRadius(DisableRadiusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableRadiusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableRadiusResponseUnmarshaller.Instance;

            return Invoke<DisableRadiusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableRadius operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableRadius operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableRadius">REST API Reference for DisableRadius Operation</seealso>
        public virtual Task<DisableRadiusResponse> DisableRadiusAsync(DisableRadiusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableRadiusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableRadiusResponseUnmarshaller.Instance;

            return InvokeAsync<DisableRadiusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableSso

        internal virtual DisableSsoResponse DisableSso(DisableSsoRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableSsoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSsoResponseUnmarshaller.Instance;

            return Invoke<DisableSsoResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableSso operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableSso operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/DisableSso">REST API Reference for DisableSso Operation</seealso>
        public virtual Task<DisableSsoResponse> DisableSsoAsync(DisableSsoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableSsoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableSsoResponseUnmarshaller.Instance;

            return InvokeAsync<DisableSsoResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableRadius

        internal virtual EnableRadiusResponse EnableRadius(EnableRadiusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableRadiusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableRadiusResponseUnmarshaller.Instance;

            return Invoke<EnableRadiusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableRadius operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableRadius operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableRadius">REST API Reference for EnableRadius Operation</seealso>
        public virtual Task<EnableRadiusResponse> EnableRadiusAsync(EnableRadiusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableRadiusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableRadiusResponseUnmarshaller.Instance;

            return InvokeAsync<EnableRadiusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableSso

        internal virtual EnableSsoResponse EnableSso(EnableSsoRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableSsoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSsoResponseUnmarshaller.Instance;

            return Invoke<EnableSsoResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableSso operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableSso operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/EnableSso">REST API Reference for EnableSso Operation</seealso>
        public virtual Task<EnableSsoResponse> EnableSsoAsync(EnableSsoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableSsoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableSsoResponseUnmarshaller.Instance;

            return InvokeAsync<EnableSsoResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDirectoryLimits

        internal virtual GetDirectoryLimitsResponse GetDirectoryLimits()
        {
            return GetDirectoryLimits(new GetDirectoryLimitsRequest());
        }
        internal virtual GetDirectoryLimitsResponse GetDirectoryLimits(GetDirectoryLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDirectoryLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDirectoryLimitsResponseUnmarshaller.Instance;

            return Invoke<GetDirectoryLimitsResponse>(request, options);
        }


        /// <summary>
        /// Obtains directory limit information for the current region.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDirectoryLimits service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// A client exception has occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// The specified entity could not be found.
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// An exception has occurred in AWS Directory Service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/GetDirectoryLimits">REST API Reference for GetDirectoryLimits Operation</seealso>
        public virtual Task<GetDirectoryLimitsResponse> GetDirectoryLimitsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetDirectoryLimitsAsync(new GetDirectoryLimitsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDirectoryLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDirectoryLimits operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/GetDirectoryLimits">REST API Reference for GetDirectoryLimits Operation</seealso>
        public virtual Task<GetDirectoryLimitsResponse> GetDirectoryLimitsAsync(GetDirectoryLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDirectoryLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDirectoryLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDirectoryLimitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSnapshotLimits

        internal virtual GetSnapshotLimitsResponse GetSnapshotLimits(GetSnapshotLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSnapshotLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotLimitsResponseUnmarshaller.Instance;

            return Invoke<GetSnapshotLimitsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSnapshotLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshotLimits operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/GetSnapshotLimits">REST API Reference for GetSnapshotLimits Operation</seealso>
        public virtual Task<GetSnapshotLimitsResponse> GetSnapshotLimitsAsync(GetSnapshotLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSnapshotLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSnapshotLimitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListIpRoutes

        internal virtual ListIpRoutesResponse ListIpRoutes(ListIpRoutesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIpRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIpRoutesResponseUnmarshaller.Instance;

            return Invoke<ListIpRoutesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListIpRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIpRoutes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListIpRoutes">REST API Reference for ListIpRoutes Operation</seealso>
        public virtual Task<ListIpRoutesResponse> ListIpRoutesAsync(ListIpRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListIpRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIpRoutesResponseUnmarshaller.Instance;

            return InvokeAsync<ListIpRoutesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLogSubscriptions

        internal virtual ListLogSubscriptionsResponse ListLogSubscriptions(ListLogSubscriptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLogSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLogSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<ListLogSubscriptionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListLogSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLogSubscriptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListLogSubscriptions">REST API Reference for ListLogSubscriptions Operation</seealso>
        public virtual Task<ListLogSubscriptionsResponse> ListLogSubscriptionsAsync(ListLogSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLogSubscriptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLogSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLogSubscriptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSchemaExtensions

        internal virtual ListSchemaExtensionsResponse ListSchemaExtensions(ListSchemaExtensionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchemaExtensionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaExtensionsResponseUnmarshaller.Instance;

            return Invoke<ListSchemaExtensionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListSchemaExtensions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaExtensions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListSchemaExtensions">REST API Reference for ListSchemaExtensions Operation</seealso>
        public virtual Task<ListSchemaExtensionsResponse> ListSchemaExtensionsAsync(ListSchemaExtensionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchemaExtensionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchemaExtensionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSchemaExtensionsResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterEventTopic

        internal virtual RegisterEventTopicResponse RegisterEventTopic(RegisterEventTopicRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterEventTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterEventTopicResponseUnmarshaller.Instance;

            return Invoke<RegisterEventTopicResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterEventTopic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterEventTopic operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RegisterEventTopic">REST API Reference for RegisterEventTopic Operation</seealso>
        public virtual Task<RegisterEventTopicResponse> RegisterEventTopicAsync(RegisterEventTopicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterEventTopicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterEventTopicResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterEventTopicResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectSharedDirectory

        internal virtual RejectSharedDirectoryResponse RejectSharedDirectory(RejectSharedDirectoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectSharedDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectSharedDirectoryResponseUnmarshaller.Instance;

            return Invoke<RejectSharedDirectoryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RejectSharedDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectSharedDirectory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RejectSharedDirectory">REST API Reference for RejectSharedDirectory Operation</seealso>
        public virtual Task<RejectSharedDirectoryResponse> RejectSharedDirectoryAsync(RejectSharedDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectSharedDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectSharedDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<RejectSharedDirectoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveIpRoutes

        internal virtual RemoveIpRoutesResponse RemoveIpRoutes(RemoveIpRoutesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveIpRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveIpRoutesResponseUnmarshaller.Instance;

            return Invoke<RemoveIpRoutesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveIpRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveIpRoutes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RemoveIpRoutes">REST API Reference for RemoveIpRoutes Operation</seealso>
        public virtual Task<RemoveIpRoutesResponse> RemoveIpRoutesAsync(RemoveIpRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveIpRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveIpRoutesResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveIpRoutesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromResource

        internal virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetUserPassword

        internal virtual ResetUserPasswordResponse ResetUserPassword(ResetUserPasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetUserPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetUserPasswordResponseUnmarshaller.Instance;

            return Invoke<ResetUserPasswordResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResetUserPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetUserPassword operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ResetUserPassword">REST API Reference for ResetUserPassword Operation</seealso>
        public virtual Task<ResetUserPasswordResponse> ResetUserPasswordAsync(ResetUserPasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetUserPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetUserPasswordResponseUnmarshaller.Instance;

            return InvokeAsync<ResetUserPasswordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreFromSnapshot

        internal virtual RestoreFromSnapshotResponse RestoreFromSnapshot(RestoreFromSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreFromSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/RestoreFromSnapshot">REST API Reference for RestoreFromSnapshot Operation</seealso>
        public virtual Task<RestoreFromSnapshotResponse> RestoreFromSnapshotAsync(RestoreFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreFromSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ShareDirectory

        internal virtual ShareDirectoryResponse ShareDirectory(ShareDirectoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ShareDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ShareDirectoryResponseUnmarshaller.Instance;

            return Invoke<ShareDirectoryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ShareDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ShareDirectory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/ShareDirectory">REST API Reference for ShareDirectory Operation</seealso>
        public virtual Task<ShareDirectoryResponse> ShareDirectoryAsync(ShareDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ShareDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ShareDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<ShareDirectoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartSchemaExtension

        internal virtual StartSchemaExtensionResponse StartSchemaExtension(StartSchemaExtensionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSchemaExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSchemaExtensionResponseUnmarshaller.Instance;

            return Invoke<StartSchemaExtensionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartSchemaExtension operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSchemaExtension operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/StartSchemaExtension">REST API Reference for StartSchemaExtension Operation</seealso>
        public virtual Task<StartSchemaExtensionResponse> StartSchemaExtensionAsync(StartSchemaExtensionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSchemaExtensionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSchemaExtensionResponseUnmarshaller.Instance;

            return InvokeAsync<StartSchemaExtensionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UnshareDirectory

        internal virtual UnshareDirectoryResponse UnshareDirectory(UnshareDirectoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnshareDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnshareDirectoryResponseUnmarshaller.Instance;

            return Invoke<UnshareDirectoryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UnshareDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnshareDirectory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UnshareDirectory">REST API Reference for UnshareDirectory Operation</seealso>
        public virtual Task<UnshareDirectoryResponse> UnshareDirectoryAsync(UnshareDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnshareDirectoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnshareDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<UnshareDirectoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConditionalForwarder

        internal virtual UpdateConditionalForwarderResponse UpdateConditionalForwarder(UpdateConditionalForwarderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConditionalForwarderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConditionalForwarderResponseUnmarshaller.Instance;

            return Invoke<UpdateConditionalForwarderResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConditionalForwarder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConditionalForwarder operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateConditionalForwarder">REST API Reference for UpdateConditionalForwarder Operation</seealso>
        public virtual Task<UpdateConditionalForwarderResponse> UpdateConditionalForwarderAsync(UpdateConditionalForwarderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConditionalForwarderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConditionalForwarderResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConditionalForwarderResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNumberOfDomainControllers

        internal virtual UpdateNumberOfDomainControllersResponse UpdateNumberOfDomainControllers(UpdateNumberOfDomainControllersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNumberOfDomainControllersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNumberOfDomainControllersResponseUnmarshaller.Instance;

            return Invoke<UpdateNumberOfDomainControllersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNumberOfDomainControllers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNumberOfDomainControllers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateNumberOfDomainControllers">REST API Reference for UpdateNumberOfDomainControllers Operation</seealso>
        public virtual Task<UpdateNumberOfDomainControllersResponse> UpdateNumberOfDomainControllersAsync(UpdateNumberOfDomainControllersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNumberOfDomainControllersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNumberOfDomainControllersResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNumberOfDomainControllersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRadius

        internal virtual UpdateRadiusResponse UpdateRadius(UpdateRadiusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRadiusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRadiusResponseUnmarshaller.Instance;

            return Invoke<UpdateRadiusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRadius operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRadius operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateRadius">REST API Reference for UpdateRadius Operation</seealso>
        public virtual Task<UpdateRadiusResponse> UpdateRadiusAsync(UpdateRadiusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRadiusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRadiusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRadiusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTrust

        internal virtual UpdateTrustResponse UpdateTrust(UpdateTrustRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrustResponseUnmarshaller.Instance;

            return Invoke<UpdateTrustResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrust operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrust operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/UpdateTrust">REST API Reference for UpdateTrust Operation</seealso>
        public virtual Task<UpdateTrustResponse> UpdateTrustAsync(UpdateTrustRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrustResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTrustResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  VerifyTrust

        internal virtual VerifyTrustResponse VerifyTrust(VerifyTrustRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyTrustResponseUnmarshaller.Instance;

            return Invoke<VerifyTrustResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the VerifyTrust operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyTrust operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ds-2015-04-16/VerifyTrust">REST API Reference for VerifyTrust Operation</seealso>
        public virtual Task<VerifyTrustResponse> VerifyTrustAsync(VerifyTrustRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyTrustRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyTrustResponseUnmarshaller.Instance;

            return InvokeAsync<VerifyTrustResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}