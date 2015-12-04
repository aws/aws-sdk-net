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
    /// This is the <i>AWS Directory Service API Reference</i>. This guide provides detailed
    /// information about AWS Directory Service operations, data types, parameters, and errors.
    /// </para>
    /// </summary>
    public partial class AmazonDirectoryServiceClient : AmazonServiceClient, IAmazonDirectoryService
    {
        
        #region Constructors

#if DNX
    
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

        
        #region  ConnectDirectory

        internal ConnectDirectoryResponse ConnectDirectory(ConnectDirectoryRequest request)
        {
            var marshaller = new ConnectDirectoryRequestMarshaller();
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
        public Task<ConnectDirectoryResponse> ConnectDirectoryAsync(ConnectDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ConnectDirectoryRequestMarshaller();
            var unmarshaller = ConnectDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<ConnectDirectoryRequest,ConnectDirectoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAlias

        internal CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var marshaller = new CreateAliasRequestMarshaller();
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
        public Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAliasRequestMarshaller();
            var unmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAliasRequest,CreateAliasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateComputer

        internal CreateComputerResponse CreateComputer(CreateComputerRequest request)
        {
            var marshaller = new CreateComputerRequestMarshaller();
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
        public Task<CreateComputerResponse> CreateComputerAsync(CreateComputerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateComputerRequestMarshaller();
            var unmarshaller = CreateComputerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateComputerRequest,CreateComputerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDirectory

        internal CreateDirectoryResponse CreateDirectory(CreateDirectoryRequest request)
        {
            var marshaller = new CreateDirectoryRequestMarshaller();
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
        public Task<CreateDirectoryResponse> CreateDirectoryAsync(CreateDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDirectoryRequestMarshaller();
            var unmarshaller = CreateDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDirectoryRequest,CreateDirectoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateMicrosoftAD

        internal CreateMicrosoftADResponse CreateMicrosoftAD(CreateMicrosoftADRequest request)
        {
            var marshaller = new CreateMicrosoftADRequestMarshaller();
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
        public Task<CreateMicrosoftADResponse> CreateMicrosoftADAsync(CreateMicrosoftADRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateMicrosoftADRequestMarshaller();
            var unmarshaller = CreateMicrosoftADResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMicrosoftADRequest,CreateMicrosoftADResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshot

        internal CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var marshaller = new CreateSnapshotRequestMarshaller();
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
        public Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSnapshotRequestMarshaller();
            var unmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotRequest,CreateSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTrust

        internal CreateTrustResponse CreateTrust(CreateTrustRequest request)
        {
            var marshaller = new CreateTrustRequestMarshaller();
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
        public Task<CreateTrustResponse> CreateTrustAsync(CreateTrustRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTrustRequestMarshaller();
            var unmarshaller = CreateTrustResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrustRequest,CreateTrustResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDirectory

        internal DeleteDirectoryResponse DeleteDirectory(DeleteDirectoryRequest request)
        {
            var marshaller = new DeleteDirectoryRequestMarshaller();
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
        public Task<DeleteDirectoryResponse> DeleteDirectoryAsync(DeleteDirectoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDirectoryRequestMarshaller();
            var unmarshaller = DeleteDirectoryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDirectoryRequest,DeleteDirectoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSnapshot

        internal DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            var marshaller = new DeleteSnapshotRequestMarshaller();
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
        public Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSnapshotRequestMarshaller();
            var unmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotRequest,DeleteSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTrust

        internal DeleteTrustResponse DeleteTrust(DeleteTrustRequest request)
        {
            var marshaller = new DeleteTrustRequestMarshaller();
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
        public Task<DeleteTrustResponse> DeleteTrustAsync(DeleteTrustRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTrustRequestMarshaller();
            var unmarshaller = DeleteTrustResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrustRequest,DeleteTrustResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDirectories

        internal DescribeDirectoriesResponse DescribeDirectories()
        {
            return DescribeDirectories(new DescribeDirectoriesRequest());
        }
        internal DescribeDirectoriesResponse DescribeDirectories(DescribeDirectoriesRequest request)
        {
            var marshaller = new DescribeDirectoriesRequestMarshaller();
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
        /// <param name="cancellationToken"> ttd1
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
        public Task<DescribeDirectoriesResponse> DescribeDirectoriesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeDirectoriesResponse> DescribeDirectoriesAsync(DescribeDirectoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDirectoriesRequestMarshaller();
            var unmarshaller = DescribeDirectoriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDirectoriesRequest,DescribeDirectoriesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshots

        internal DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            var marshaller = new DescribeSnapshotsRequestMarshaller();
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
        public Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSnapshotsRequestMarshaller();
            var unmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotsRequest,DescribeSnapshotsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTrusts

        internal DescribeTrustsResponse DescribeTrusts(DescribeTrustsRequest request)
        {
            var marshaller = new DescribeTrustsRequestMarshaller();
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
        public Task<DescribeTrustsResponse> DescribeTrustsAsync(DescribeTrustsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTrustsRequestMarshaller();
            var unmarshaller = DescribeTrustsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTrustsRequest,DescribeTrustsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableRadius

        internal DisableRadiusResponse DisableRadius(DisableRadiusRequest request)
        {
            var marshaller = new DisableRadiusRequestMarshaller();
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
        public Task<DisableRadiusResponse> DisableRadiusAsync(DisableRadiusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableRadiusRequestMarshaller();
            var unmarshaller = DisableRadiusResponseUnmarshaller.Instance;

            return InvokeAsync<DisableRadiusRequest,DisableRadiusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableSso

        internal DisableSsoResponse DisableSso(DisableSsoRequest request)
        {
            var marshaller = new DisableSsoRequestMarshaller();
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
        public Task<DisableSsoResponse> DisableSsoAsync(DisableSsoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableSsoRequestMarshaller();
            var unmarshaller = DisableSsoResponseUnmarshaller.Instance;

            return InvokeAsync<DisableSsoRequest,DisableSsoResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableRadius

        internal EnableRadiusResponse EnableRadius(EnableRadiusRequest request)
        {
            var marshaller = new EnableRadiusRequestMarshaller();
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
        public Task<EnableRadiusResponse> EnableRadiusAsync(EnableRadiusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableRadiusRequestMarshaller();
            var unmarshaller = EnableRadiusResponseUnmarshaller.Instance;

            return InvokeAsync<EnableRadiusRequest,EnableRadiusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableSso

        internal EnableSsoResponse EnableSso(EnableSsoRequest request)
        {
            var marshaller = new EnableSsoRequestMarshaller();
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
        public Task<EnableSsoResponse> EnableSsoAsync(EnableSsoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableSsoRequestMarshaller();
            var unmarshaller = EnableSsoResponseUnmarshaller.Instance;

            return InvokeAsync<EnableSsoRequest,EnableSsoResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDirectoryLimits

        internal GetDirectoryLimitsResponse GetDirectoryLimits()
        {
            return GetDirectoryLimits(new GetDirectoryLimitsRequest());
        }
        internal GetDirectoryLimitsResponse GetDirectoryLimits(GetDirectoryLimitsRequest request)
        {
            var marshaller = new GetDirectoryLimitsRequestMarshaller();
            var unmarshaller = GetDirectoryLimitsResponseUnmarshaller.Instance;

            return Invoke<GetDirectoryLimitsRequest,GetDirectoryLimitsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Obtains directory limit information for the current region.
        /// </summary>
        /// <param name="cancellationToken"> ttd1
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
        public Task<GetDirectoryLimitsResponse> GetDirectoryLimitsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<GetDirectoryLimitsResponse> GetDirectoryLimitsAsync(GetDirectoryLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetDirectoryLimitsRequestMarshaller();
            var unmarshaller = GetDirectoryLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDirectoryLimitsRequest,GetDirectoryLimitsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSnapshotLimits

        internal GetSnapshotLimitsResponse GetSnapshotLimits(GetSnapshotLimitsRequest request)
        {
            var marshaller = new GetSnapshotLimitsRequestMarshaller();
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
        public Task<GetSnapshotLimitsResponse> GetSnapshotLimitsAsync(GetSnapshotLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetSnapshotLimitsRequestMarshaller();
            var unmarshaller = GetSnapshotLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSnapshotLimitsRequest,GetSnapshotLimitsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreFromSnapshot

        internal RestoreFromSnapshotResponse RestoreFromSnapshot(RestoreFromSnapshotRequest request)
        {
            var marshaller = new RestoreFromSnapshotRequestMarshaller();
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
        public Task<RestoreFromSnapshotResponse> RestoreFromSnapshotAsync(RestoreFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestoreFromSnapshotRequestMarshaller();
            var unmarshaller = RestoreFromSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreFromSnapshotRequest,RestoreFromSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateRadius

        internal UpdateRadiusResponse UpdateRadius(UpdateRadiusRequest request)
        {
            var marshaller = new UpdateRadiusRequestMarshaller();
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
        public Task<UpdateRadiusResponse> UpdateRadiusAsync(UpdateRadiusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateRadiusRequestMarshaller();
            var unmarshaller = UpdateRadiusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRadiusRequest,UpdateRadiusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  VerifyTrust

        internal VerifyTrustResponse VerifyTrust(VerifyTrustRequest request)
        {
            var marshaller = new VerifyTrustRequestMarshaller();
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
        public Task<VerifyTrustResponse> VerifyTrustAsync(VerifyTrustRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new VerifyTrustRequestMarshaller();
            var unmarshaller = VerifyTrustResponseUnmarshaller.Instance;

            return InvokeAsync<VerifyTrustRequest,VerifyTrustResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}