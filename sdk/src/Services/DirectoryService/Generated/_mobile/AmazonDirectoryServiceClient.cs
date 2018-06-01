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

using Amazon.DirectoryService.Model;
using Amazon.DirectoryService.Model.Internal.MarshallTransformations;
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

        
        #region  AddIpRoutes

        internal virtual AddIpRoutesResponse AddIpRoutes(AddIpRoutesRequest request)
        {
            var marshaller = AddIpRoutesRequestMarshaller.Instance;
            var unmarshaller = AddIpRoutesResponseUnmarshaller.Instance;

            return Invoke<AddIpRoutesRequest,AddIpRoutesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = AddIpRoutesRequestMarshaller.Instance;
            var unmarshaller = AddIpRoutesResponseUnmarshaller.Instance;

            return InvokeAsync<AddIpRoutesRequest,AddIpRoutesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AddTagsToResource

        internal virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var marshaller = AddTagsToResourceRequestMarshaller.Instance;
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceRequest,AddTagsToResourceResponse>(request, marshaller, unmarshaller);
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
            var marshaller = AddTagsToResourceRequestMarshaller.Instance;
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToResourceRequest,AddTagsToResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelSchemaExtension

        internal virtual CancelSchemaExtensionResponse CancelSchemaExtension(CancelSchemaExtensionRequest request)
        {
            var marshaller = CancelSchemaExtensionRequestMarshaller.Instance;
            var unmarshaller = CancelSchemaExtensionResponseUnmarshaller.Instance;

            return Invoke<CancelSchemaExtensionRequest,CancelSchemaExtensionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CancelSchemaExtensionRequestMarshaller.Instance;
            var unmarshaller = CancelSchemaExtensionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelSchemaExtensionRequest,CancelSchemaExtensionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ConnectDirectory

        internal virtual ConnectDirectoryResponse ConnectDirectory(ConnectDirectoryRequest request)
        {
            var marshaller = ConnectDirectoryRequestMarshaller.Instance;
            var unmarshaller = ConnectDirectoryResponseUnmarshaller.Instance;

            return Invoke<ConnectDirectoryRequest,ConnectDirectoryResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ConnectDirectoryRequestMarshaller.Instance;
            var unmarshaller = ConnectDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<ConnectDirectoryRequest,ConnectDirectoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAlias

        internal virtual CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var marshaller = CreateAliasRequestMarshaller.Instance;
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasRequest,CreateAliasResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateAliasRequestMarshaller.Instance;
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAliasRequest,CreateAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateComputer

        internal virtual CreateComputerResponse CreateComputer(CreateComputerRequest request)
        {
            var marshaller = CreateComputerRequestMarshaller.Instance;
            var unmarshaller = CreateComputerResponseUnmarshaller.Instance;

            return Invoke<CreateComputerRequest,CreateComputerResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateComputerRequestMarshaller.Instance;
            var unmarshaller = CreateComputerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateComputerRequest,CreateComputerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateConditionalForwarder

        internal virtual CreateConditionalForwarderResponse CreateConditionalForwarder(CreateConditionalForwarderRequest request)
        {
            var marshaller = CreateConditionalForwarderRequestMarshaller.Instance;
            var unmarshaller = CreateConditionalForwarderResponseUnmarshaller.Instance;

            return Invoke<CreateConditionalForwarderRequest,CreateConditionalForwarderResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateConditionalForwarderRequestMarshaller.Instance;
            var unmarshaller = CreateConditionalForwarderResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConditionalForwarderRequest,CreateConditionalForwarderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDirectory

        internal virtual CreateDirectoryResponse CreateDirectory(CreateDirectoryRequest request)
        {
            var marshaller = CreateDirectoryRequestMarshaller.Instance;
            var unmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return Invoke<CreateDirectoryRequest,CreateDirectoryResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateDirectoryRequestMarshaller.Instance;
            var unmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDirectoryRequest,CreateDirectoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateMicrosoftAD

        internal virtual CreateMicrosoftADResponse CreateMicrosoftAD(CreateMicrosoftADRequest request)
        {
            var marshaller = CreateMicrosoftADRequestMarshaller.Instance;
            var unmarshaller = CreateMicrosoftADResponseUnmarshaller.Instance;

            return Invoke<CreateMicrosoftADRequest,CreateMicrosoftADResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateMicrosoftADRequestMarshaller.Instance;
            var unmarshaller = CreateMicrosoftADResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMicrosoftADRequest,CreateMicrosoftADResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshot

        internal virtual CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var marshaller = CreateSnapshotRequestMarshaller.Instance;
            var unmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotRequest,CreateSnapshotResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateSnapshotRequestMarshaller.Instance;
            var unmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotRequest,CreateSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTrust

        internal virtual CreateTrustResponse CreateTrust(CreateTrustRequest request)
        {
            var marshaller = CreateTrustRequestMarshaller.Instance;
            var unmarshaller = CreateTrustResponseUnmarshaller.Instance;

            return Invoke<CreateTrustRequest,CreateTrustResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateTrustRequestMarshaller.Instance;
            var unmarshaller = CreateTrustResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrustRequest,CreateTrustResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteConditionalForwarder

        internal virtual DeleteConditionalForwarderResponse DeleteConditionalForwarder(DeleteConditionalForwarderRequest request)
        {
            var marshaller = DeleteConditionalForwarderRequestMarshaller.Instance;
            var unmarshaller = DeleteConditionalForwarderResponseUnmarshaller.Instance;

            return Invoke<DeleteConditionalForwarderRequest,DeleteConditionalForwarderResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteConditionalForwarderRequestMarshaller.Instance;
            var unmarshaller = DeleteConditionalForwarderResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConditionalForwarderRequest,DeleteConditionalForwarderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDirectory

        internal virtual DeleteDirectoryResponse DeleteDirectory(DeleteDirectoryRequest request)
        {
            var marshaller = DeleteDirectoryRequestMarshaller.Instance;
            var unmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectoryRequest,DeleteDirectoryResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteDirectoryRequestMarshaller.Instance;
            var unmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDirectoryRequest,DeleteDirectoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSnapshot

        internal virtual DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            var marshaller = DeleteSnapshotRequestMarshaller.Instance;
            var unmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotRequest,DeleteSnapshotResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteSnapshotRequestMarshaller.Instance;
            var unmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotRequest,DeleteSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrust

        internal virtual DeleteTrustResponse DeleteTrust(DeleteTrustRequest request)
        {
            var marshaller = DeleteTrustRequestMarshaller.Instance;
            var unmarshaller = DeleteTrustResponseUnmarshaller.Instance;

            return Invoke<DeleteTrustRequest,DeleteTrustResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteTrustRequestMarshaller.Instance;
            var unmarshaller = DeleteTrustResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrustRequest,DeleteTrustResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterEventTopic

        internal virtual DeregisterEventTopicResponse DeregisterEventTopic(DeregisterEventTopicRequest request)
        {
            var marshaller = DeregisterEventTopicRequestMarshaller.Instance;
            var unmarshaller = DeregisterEventTopicResponseUnmarshaller.Instance;

            return Invoke<DeregisterEventTopicRequest,DeregisterEventTopicResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeregisterEventTopicRequestMarshaller.Instance;
            var unmarshaller = DeregisterEventTopicResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterEventTopicRequest,DeregisterEventTopicResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeConditionalForwarders

        internal virtual DescribeConditionalForwardersResponse DescribeConditionalForwarders(DescribeConditionalForwardersRequest request)
        {
            var marshaller = DescribeConditionalForwardersRequestMarshaller.Instance;
            var unmarshaller = DescribeConditionalForwardersResponseUnmarshaller.Instance;

            return Invoke<DescribeConditionalForwardersRequest,DescribeConditionalForwardersResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeConditionalForwardersRequestMarshaller.Instance;
            var unmarshaller = DescribeConditionalForwardersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConditionalForwardersRequest,DescribeConditionalForwardersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDirectories

        internal virtual DescribeDirectoriesResponse DescribeDirectories()
        {
            return DescribeDirectories(new DescribeDirectoriesRequest());
        }
        internal virtual DescribeDirectoriesResponse DescribeDirectories(DescribeDirectoriesRequest request)
        {
            var marshaller = DescribeDirectoriesRequestMarshaller.Instance;
            var unmarshaller = DescribeDirectoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeDirectoriesRequest,DescribeDirectoriesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Obtains information about the directories that belong to this account.
        /// 
        ///  
        /// <para>
        /// You can retrieve information about specific directories by passing the directory identifiers
        /// in the <i>DirectoryIds</i> parameter. Otherwise, all directories that belong to the
        /// current account are returned.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> request and
        /// response parameters. If more results are available, the <i>DescribeDirectoriesResult.NextToken</i>
        /// member contains a token that you pass in the next call to <a>DescribeDirectories</a>
        /// to retrieve the next set of items.
        /// </para>
        ///  
        /// <para>
        /// You can also specify a maximum number of return results with the <i>Limit</i> parameter.
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
        /// The <i>NextToken</i> value is not valid.
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
            var marshaller = DescribeDirectoriesRequestMarshaller.Instance;
            var unmarshaller = DescribeDirectoriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDirectoriesRequest,DescribeDirectoriesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDomainControllers

        internal virtual DescribeDomainControllersResponse DescribeDomainControllers(DescribeDomainControllersRequest request)
        {
            var marshaller = DescribeDomainControllersRequestMarshaller.Instance;
            var unmarshaller = DescribeDomainControllersResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainControllersRequest,DescribeDomainControllersResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeDomainControllersRequestMarshaller.Instance;
            var unmarshaller = DescribeDomainControllersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDomainControllersRequest,DescribeDomainControllersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventTopics

        internal virtual DescribeEventTopicsResponse DescribeEventTopics(DescribeEventTopicsRequest request)
        {
            var marshaller = DescribeEventTopicsRequestMarshaller.Instance;
            var unmarshaller = DescribeEventTopicsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventTopicsRequest,DescribeEventTopicsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeEventTopicsRequestMarshaller.Instance;
            var unmarshaller = DescribeEventTopicsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventTopicsRequest,DescribeEventTopicsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshots

        internal virtual DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            var marshaller = DescribeSnapshotsRequestMarshaller.Instance;
            var unmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotsRequest,DescribeSnapshotsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeSnapshotsRequestMarshaller.Instance;
            var unmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotsRequest,DescribeSnapshotsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTrusts

        internal virtual DescribeTrustsResponse DescribeTrusts(DescribeTrustsRequest request)
        {
            var marshaller = DescribeTrustsRequestMarshaller.Instance;
            var unmarshaller = DescribeTrustsResponseUnmarshaller.Instance;

            return Invoke<DescribeTrustsRequest,DescribeTrustsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeTrustsRequestMarshaller.Instance;
            var unmarshaller = DescribeTrustsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTrustsRequest,DescribeTrustsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableRadius

        internal virtual DisableRadiusResponse DisableRadius(DisableRadiusRequest request)
        {
            var marshaller = DisableRadiusRequestMarshaller.Instance;
            var unmarshaller = DisableRadiusResponseUnmarshaller.Instance;

            return Invoke<DisableRadiusRequest,DisableRadiusResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DisableRadiusRequestMarshaller.Instance;
            var unmarshaller = DisableRadiusResponseUnmarshaller.Instance;

            return InvokeAsync<DisableRadiusRequest,DisableRadiusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableSso

        internal virtual DisableSsoResponse DisableSso(DisableSsoRequest request)
        {
            var marshaller = DisableSsoRequestMarshaller.Instance;
            var unmarshaller = DisableSsoResponseUnmarshaller.Instance;

            return Invoke<DisableSsoRequest,DisableSsoResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DisableSsoRequestMarshaller.Instance;
            var unmarshaller = DisableSsoResponseUnmarshaller.Instance;

            return InvokeAsync<DisableSsoRequest,DisableSsoResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableRadius

        internal virtual EnableRadiusResponse EnableRadius(EnableRadiusRequest request)
        {
            var marshaller = EnableRadiusRequestMarshaller.Instance;
            var unmarshaller = EnableRadiusResponseUnmarshaller.Instance;

            return Invoke<EnableRadiusRequest,EnableRadiusResponse>(request, marshaller, unmarshaller);
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
            var marshaller = EnableRadiusRequestMarshaller.Instance;
            var unmarshaller = EnableRadiusResponseUnmarshaller.Instance;

            return InvokeAsync<EnableRadiusRequest,EnableRadiusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableSso

        internal virtual EnableSsoResponse EnableSso(EnableSsoRequest request)
        {
            var marshaller = EnableSsoRequestMarshaller.Instance;
            var unmarshaller = EnableSsoResponseUnmarshaller.Instance;

            return Invoke<EnableSsoRequest,EnableSsoResponse>(request, marshaller, unmarshaller);
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
            var marshaller = EnableSsoRequestMarshaller.Instance;
            var unmarshaller = EnableSsoResponseUnmarshaller.Instance;

            return InvokeAsync<EnableSsoRequest,EnableSsoResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDirectoryLimits

        internal virtual GetDirectoryLimitsResponse GetDirectoryLimits()
        {
            return GetDirectoryLimits(new GetDirectoryLimitsRequest());
        }
        internal virtual GetDirectoryLimitsResponse GetDirectoryLimits(GetDirectoryLimitsRequest request)
        {
            var marshaller = GetDirectoryLimitsRequestMarshaller.Instance;
            var unmarshaller = GetDirectoryLimitsResponseUnmarshaller.Instance;

            return Invoke<GetDirectoryLimitsRequest,GetDirectoryLimitsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetDirectoryLimitsRequestMarshaller.Instance;
            var unmarshaller = GetDirectoryLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDirectoryLimitsRequest,GetDirectoryLimitsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSnapshotLimits

        internal virtual GetSnapshotLimitsResponse GetSnapshotLimits(GetSnapshotLimitsRequest request)
        {
            var marshaller = GetSnapshotLimitsRequestMarshaller.Instance;
            var unmarshaller = GetSnapshotLimitsResponseUnmarshaller.Instance;

            return Invoke<GetSnapshotLimitsRequest,GetSnapshotLimitsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetSnapshotLimitsRequestMarshaller.Instance;
            var unmarshaller = GetSnapshotLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSnapshotLimitsRequest,GetSnapshotLimitsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListIpRoutes

        internal virtual ListIpRoutesResponse ListIpRoutes(ListIpRoutesRequest request)
        {
            var marshaller = ListIpRoutesRequestMarshaller.Instance;
            var unmarshaller = ListIpRoutesResponseUnmarshaller.Instance;

            return Invoke<ListIpRoutesRequest,ListIpRoutesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListIpRoutesRequestMarshaller.Instance;
            var unmarshaller = ListIpRoutesResponseUnmarshaller.Instance;

            return InvokeAsync<ListIpRoutesRequest,ListIpRoutesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListSchemaExtensions

        internal virtual ListSchemaExtensionsResponse ListSchemaExtensions(ListSchemaExtensionsRequest request)
        {
            var marshaller = ListSchemaExtensionsRequestMarshaller.Instance;
            var unmarshaller = ListSchemaExtensionsResponseUnmarshaller.Instance;

            return Invoke<ListSchemaExtensionsRequest,ListSchemaExtensionsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListSchemaExtensionsRequestMarshaller.Instance;
            var unmarshaller = ListSchemaExtensionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSchemaExtensionsRequest,ListSchemaExtensionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterEventTopic

        internal virtual RegisterEventTopicResponse RegisterEventTopic(RegisterEventTopicRequest request)
        {
            var marshaller = RegisterEventTopicRequestMarshaller.Instance;
            var unmarshaller = RegisterEventTopicResponseUnmarshaller.Instance;

            return Invoke<RegisterEventTopicRequest,RegisterEventTopicResponse>(request, marshaller, unmarshaller);
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
            var marshaller = RegisterEventTopicRequestMarshaller.Instance;
            var unmarshaller = RegisterEventTopicResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterEventTopicRequest,RegisterEventTopicResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveIpRoutes

        internal virtual RemoveIpRoutesResponse RemoveIpRoutes(RemoveIpRoutesRequest request)
        {
            var marshaller = RemoveIpRoutesRequestMarshaller.Instance;
            var unmarshaller = RemoveIpRoutesResponseUnmarshaller.Instance;

            return Invoke<RemoveIpRoutesRequest,RemoveIpRoutesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = RemoveIpRoutesRequestMarshaller.Instance;
            var unmarshaller = RemoveIpRoutesResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveIpRoutesRequest,RemoveIpRoutesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromResource

        internal virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var marshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceRequest,RemoveTagsFromResourceResponse>(request, marshaller, unmarshaller);
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
            var marshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromResourceRequest,RemoveTagsFromResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetUserPassword

        internal virtual ResetUserPasswordResponse ResetUserPassword(ResetUserPasswordRequest request)
        {
            var marshaller = ResetUserPasswordRequestMarshaller.Instance;
            var unmarshaller = ResetUserPasswordResponseUnmarshaller.Instance;

            return Invoke<ResetUserPasswordRequest,ResetUserPasswordResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ResetUserPasswordRequestMarshaller.Instance;
            var unmarshaller = ResetUserPasswordResponseUnmarshaller.Instance;

            return InvokeAsync<ResetUserPasswordRequest,ResetUserPasswordResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreFromSnapshot

        internal virtual RestoreFromSnapshotResponse RestoreFromSnapshot(RestoreFromSnapshotRequest request)
        {
            var marshaller = RestoreFromSnapshotRequestMarshaller.Instance;
            var unmarshaller = RestoreFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreFromSnapshotRequest,RestoreFromSnapshotResponse>(request, marshaller, unmarshaller);
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
            var marshaller = RestoreFromSnapshotRequestMarshaller.Instance;
            var unmarshaller = RestoreFromSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreFromSnapshotRequest,RestoreFromSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartSchemaExtension

        internal virtual StartSchemaExtensionResponse StartSchemaExtension(StartSchemaExtensionRequest request)
        {
            var marshaller = StartSchemaExtensionRequestMarshaller.Instance;
            var unmarshaller = StartSchemaExtensionResponseUnmarshaller.Instance;

            return Invoke<StartSchemaExtensionRequest,StartSchemaExtensionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StartSchemaExtensionRequestMarshaller.Instance;
            var unmarshaller = StartSchemaExtensionResponseUnmarshaller.Instance;

            return InvokeAsync<StartSchemaExtensionRequest,StartSchemaExtensionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateConditionalForwarder

        internal virtual UpdateConditionalForwarderResponse UpdateConditionalForwarder(UpdateConditionalForwarderRequest request)
        {
            var marshaller = UpdateConditionalForwarderRequestMarshaller.Instance;
            var unmarshaller = UpdateConditionalForwarderResponseUnmarshaller.Instance;

            return Invoke<UpdateConditionalForwarderRequest,UpdateConditionalForwarderResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateConditionalForwarderRequestMarshaller.Instance;
            var unmarshaller = UpdateConditionalForwarderResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConditionalForwarderRequest,UpdateConditionalForwarderResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateNumberOfDomainControllers

        internal virtual UpdateNumberOfDomainControllersResponse UpdateNumberOfDomainControllers(UpdateNumberOfDomainControllersRequest request)
        {
            var marshaller = UpdateNumberOfDomainControllersRequestMarshaller.Instance;
            var unmarshaller = UpdateNumberOfDomainControllersResponseUnmarshaller.Instance;

            return Invoke<UpdateNumberOfDomainControllersRequest,UpdateNumberOfDomainControllersResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateNumberOfDomainControllersRequestMarshaller.Instance;
            var unmarshaller = UpdateNumberOfDomainControllersResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNumberOfDomainControllersRequest,UpdateNumberOfDomainControllersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateRadius

        internal virtual UpdateRadiusResponse UpdateRadius(UpdateRadiusRequest request)
        {
            var marshaller = UpdateRadiusRequestMarshaller.Instance;
            var unmarshaller = UpdateRadiusResponseUnmarshaller.Instance;

            return Invoke<UpdateRadiusRequest,UpdateRadiusResponse>(request, marshaller, unmarshaller);
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
            var marshaller = UpdateRadiusRequestMarshaller.Instance;
            var unmarshaller = UpdateRadiusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRadiusRequest,UpdateRadiusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  VerifyTrust

        internal virtual VerifyTrustResponse VerifyTrust(VerifyTrustRequest request)
        {
            var marshaller = VerifyTrustRequestMarshaller.Instance;
            var unmarshaller = VerifyTrustResponseUnmarshaller.Instance;

            return Invoke<VerifyTrustRequest,VerifyTrustResponse>(request, marshaller, unmarshaller);
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
            var marshaller = VerifyTrustRequestMarshaller.Instance;
            var unmarshaller = VerifyTrustResponseUnmarshaller.Instance;

            return InvokeAsync<VerifyTrustRequest,VerifyTrustResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}