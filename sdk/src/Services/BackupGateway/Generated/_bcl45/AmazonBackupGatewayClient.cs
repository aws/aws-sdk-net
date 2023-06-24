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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.BackupGateway.Model;
using Amazon.BackupGateway.Model.Internal.MarshallTransformations;
using Amazon.BackupGateway.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.BackupGateway
{
    /// <summary>
    /// Implementation for accessing BackupGateway
    ///
    /// Backup gateway 
    /// <para>
    /// Backup gateway connects Backup to your hypervisor, so you can create, store, and restore
    /// backups of your virtual machines (VMs) anywhere, whether on-premises or in the VMware
    /// Cloud (VMC) on Amazon Web Services.
    /// 
    ///  
    /// <para>
    /// Add on-premises resources by connecting to a hypervisor through a gateway. Backup
    /// will automatically discover the resources in your hypervisor.
    /// </para>
    ///  
    /// <para>
    /// Use Backup to assign virtual or on-premises resources to a backup plan, or run on-demand
    /// backups. Once you have backed up your resources, you can view them and restore them
    /// like any resource supported by Backup.
    /// </para>
    ///  
    /// <para>
    /// To download the Amazon Web Services software to get started, navigate to the Backup
    /// console, choose <b>Gateways</b>, then choose <b>Create gateway</b>.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class AmazonBackupGatewayClient : AmazonServiceClient, IAmazonBackupGateway
    {
        private static IServiceMetadata serviceMetadata = new AmazonBackupGatewayMetadata();
        private IBackupGatewayPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBackupGatewayPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BackupGatewayPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonBackupGatewayClient with the credentials loaded from the application's
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
        public AmazonBackupGatewayClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBackupGatewayConfig()) { }

        /// <summary>
        /// Constructs AmazonBackupGatewayClient with the credentials loaded from the application's
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
        public AmazonBackupGatewayClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBackupGatewayConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBackupGatewayClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBackupGatewayClient Configuration Object</param>
        public AmazonBackupGatewayClient(AmazonBackupGatewayConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonBackupGatewayClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBackupGatewayClient(AWSCredentials credentials)
            : this(credentials, new AmazonBackupGatewayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBackupGatewayClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBackupGatewayClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBackupGatewayConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBackupGatewayClient with AWS Credentials and an
        /// AmazonBackupGatewayClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBackupGatewayClient Configuration Object</param>
        public AmazonBackupGatewayClient(AWSCredentials credentials, AmazonBackupGatewayConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBackupGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBackupGatewayClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBackupGatewayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBackupGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBackupGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBackupGatewayConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBackupGatewayClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBackupGatewayClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBackupGatewayClient Configuration Object</param>
        public AmazonBackupGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBackupGatewayConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBackupGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBackupGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBackupGatewayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBackupGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBackupGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBackupGatewayConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBackupGatewayClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBackupGatewayClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBackupGatewayClient Configuration Object</param>
        public AmazonBackupGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBackupGatewayConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBackupGatewayEndpointResolver());
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


        #region  AssociateGatewayToServer


        /// <summary>
        /// Associates a backup gateway with your server. After you complete the association process,
        /// you can back up and restore your VMs through the gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateGatewayToServer service method.</param>
        /// 
        /// <returns>The response from the AssociateGatewayToServer service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/AssociateGatewayToServer">REST API Reference for AssociateGatewayToServer Operation</seealso>
        public virtual AssociateGatewayToServerResponse AssociateGatewayToServer(AssociateGatewayToServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateGatewayToServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateGatewayToServerResponseUnmarshaller.Instance;

            return Invoke<AssociateGatewayToServerResponse>(request, options);
        }


        /// <summary>
        /// Associates a backup gateway with your server. After you complete the association process,
        /// you can back up and restore your VMs through the gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateGatewayToServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateGatewayToServer service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/AssociateGatewayToServer">REST API Reference for AssociateGatewayToServer Operation</seealso>
        public virtual Task<AssociateGatewayToServerResponse> AssociateGatewayToServerAsync(AssociateGatewayToServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateGatewayToServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateGatewayToServerResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateGatewayToServerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGateway


        /// <summary>
        /// Creates a backup gateway. After you create a gateway, you can associate it with a
        /// server using the <code>AssociateGatewayToServer</code> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGateway service method.</param>
        /// 
        /// <returns>The response from the CreateGateway service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/CreateGateway">REST API Reference for CreateGateway Operation</seealso>
        public virtual CreateGatewayResponse CreateGateway(CreateGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateGatewayResponse>(request, options);
        }


        /// <summary>
        /// Creates a backup gateway. After you create a gateway, you can associate it with a
        /// server using the <code>AssociateGatewayToServer</code> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGateway service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/CreateGateway">REST API Reference for CreateGateway Operation</seealso>
        public virtual Task<CreateGatewayResponse> CreateGatewayAsync(CreateGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGatewayResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGateway


        /// <summary>
        /// Deletes a backup gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteGateway service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        public virtual DeleteGatewayResponse DeleteGateway(DeleteGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteGatewayResponse>(request, options);
        }


        /// <summary>
        /// Deletes a backup gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGateway service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/DeleteGateway">REST API Reference for DeleteGateway Operation</seealso>
        public virtual Task<DeleteGatewayResponse> DeleteGatewayAsync(DeleteGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGatewayResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteHypervisor


        /// <summary>
        /// Deletes a hypervisor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHypervisor service method.</param>
        /// 
        /// <returns>The response from the DeleteHypervisor service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.AccessDeniedException">
        /// The operation cannot proceed because you have insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/DeleteHypervisor">REST API Reference for DeleteHypervisor Operation</seealso>
        public virtual DeleteHypervisorResponse DeleteHypervisor(DeleteHypervisorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHypervisorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHypervisorResponseUnmarshaller.Instance;

            return Invoke<DeleteHypervisorResponse>(request, options);
        }


        /// <summary>
        /// Deletes a hypervisor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHypervisor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHypervisor service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.AccessDeniedException">
        /// The operation cannot proceed because you have insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/DeleteHypervisor">REST API Reference for DeleteHypervisor Operation</seealso>
        public virtual Task<DeleteHypervisorResponse> DeleteHypervisorAsync(DeleteHypervisorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHypervisorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHypervisorResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteHypervisorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateGatewayFromServer


        /// <summary>
        /// Disassociates a backup gateway from the specified server. After the disassociation
        /// process finishes, the gateway can no longer access the virtual machines on the server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateGatewayFromServer service method.</param>
        /// 
        /// <returns>The response from the DisassociateGatewayFromServer service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/DisassociateGatewayFromServer">REST API Reference for DisassociateGatewayFromServer Operation</seealso>
        public virtual DisassociateGatewayFromServerResponse DisassociateGatewayFromServer(DisassociateGatewayFromServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateGatewayFromServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateGatewayFromServerResponseUnmarshaller.Instance;

            return Invoke<DisassociateGatewayFromServerResponse>(request, options);
        }


        /// <summary>
        /// Disassociates a backup gateway from the specified server. After the disassociation
        /// process finishes, the gateway can no longer access the virtual machines on the server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateGatewayFromServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateGatewayFromServer service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/DisassociateGatewayFromServer">REST API Reference for DisassociateGatewayFromServer Operation</seealso>
        public virtual Task<DisassociateGatewayFromServerResponse> DisassociateGatewayFromServerAsync(DisassociateGatewayFromServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateGatewayFromServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateGatewayFromServerResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateGatewayFromServerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBandwidthRateLimitSchedule


        /// <summary>
        /// Retrieves the bandwidth rate limit schedule for a specified gateway. By default, gateways
        /// do not have bandwidth rate limit schedules, which means no bandwidth rate limiting
        /// is in effect. Use this to get a gateway's bandwidth rate limit schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBandwidthRateLimitSchedule service method.</param>
        /// 
        /// <returns>The response from the GetBandwidthRateLimitSchedule service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetBandwidthRateLimitSchedule">REST API Reference for GetBandwidthRateLimitSchedule Operation</seealso>
        public virtual GetBandwidthRateLimitScheduleResponse GetBandwidthRateLimitSchedule(GetBandwidthRateLimitScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBandwidthRateLimitScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBandwidthRateLimitScheduleResponseUnmarshaller.Instance;

            return Invoke<GetBandwidthRateLimitScheduleResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the bandwidth rate limit schedule for a specified gateway. By default, gateways
        /// do not have bandwidth rate limit schedules, which means no bandwidth rate limiting
        /// is in effect. Use this to get a gateway's bandwidth rate limit schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBandwidthRateLimitSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBandwidthRateLimitSchedule service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetBandwidthRateLimitSchedule">REST API Reference for GetBandwidthRateLimitSchedule Operation</seealso>
        public virtual Task<GetBandwidthRateLimitScheduleResponse> GetBandwidthRateLimitScheduleAsync(GetBandwidthRateLimitScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBandwidthRateLimitScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBandwidthRateLimitScheduleResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetBandwidthRateLimitScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGateway


        /// <summary>
        /// By providing the ARN (Amazon Resource Name), this API returns the gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGateway service method.</param>
        /// 
        /// <returns>The response from the GetGateway service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetGateway">REST API Reference for GetGateway Operation</seealso>
        public virtual GetGatewayResponse GetGateway(GetGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGatewayResponseUnmarshaller.Instance;

            return Invoke<GetGatewayResponse>(request, options);
        }


        /// <summary>
        /// By providing the ARN (Amazon Resource Name), this API returns the gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGateway service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetGateway">REST API Reference for GetGateway Operation</seealso>
        public virtual Task<GetGatewayResponse> GetGatewayAsync(GetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGatewayResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetHypervisor


        /// <summary>
        /// This action requests information about the specified hypervisor to which the gateway
        /// will connect. A hypervisor is hardware, software, or firmware that creates and manages
        /// virtual machines, and allocates resources to them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHypervisor service method.</param>
        /// 
        /// <returns>The response from the GetHypervisor service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetHypervisor">REST API Reference for GetHypervisor Operation</seealso>
        public virtual GetHypervisorResponse GetHypervisor(GetHypervisorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHypervisorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHypervisorResponseUnmarshaller.Instance;

            return Invoke<GetHypervisorResponse>(request, options);
        }


        /// <summary>
        /// This action requests information about the specified hypervisor to which the gateway
        /// will connect. A hypervisor is hardware, software, or firmware that creates and manages
        /// virtual machines, and allocates resources to them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHypervisor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHypervisor service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetHypervisor">REST API Reference for GetHypervisor Operation</seealso>
        public virtual Task<GetHypervisorResponse> GetHypervisorAsync(GetHypervisorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHypervisorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHypervisorResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetHypervisorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetHypervisorPropertyMappings


        /// <summary>
        /// This action retrieves the property mappings for the specified hypervisor. A hypervisor
        /// property mapping displays the relationship of entity properties available from the
        /// on-premises hypervisor to the properties available in Amazon Web Services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHypervisorPropertyMappings service method.</param>
        /// 
        /// <returns>The response from the GetHypervisorPropertyMappings service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetHypervisorPropertyMappings">REST API Reference for GetHypervisorPropertyMappings Operation</seealso>
        public virtual GetHypervisorPropertyMappingsResponse GetHypervisorPropertyMappings(GetHypervisorPropertyMappingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHypervisorPropertyMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHypervisorPropertyMappingsResponseUnmarshaller.Instance;

            return Invoke<GetHypervisorPropertyMappingsResponse>(request, options);
        }


        /// <summary>
        /// This action retrieves the property mappings for the specified hypervisor. A hypervisor
        /// property mapping displays the relationship of entity properties available from the
        /// on-premises hypervisor to the properties available in Amazon Web Services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHypervisorPropertyMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHypervisorPropertyMappings service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetHypervisorPropertyMappings">REST API Reference for GetHypervisorPropertyMappings Operation</seealso>
        public virtual Task<GetHypervisorPropertyMappingsResponse> GetHypervisorPropertyMappingsAsync(GetHypervisorPropertyMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHypervisorPropertyMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHypervisorPropertyMappingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetHypervisorPropertyMappingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVirtualMachine


        /// <summary>
        /// By providing the ARN (Amazon Resource Name), this API returns the virtual machine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVirtualMachine service method.</param>
        /// 
        /// <returns>The response from the GetVirtualMachine service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetVirtualMachine">REST API Reference for GetVirtualMachine Operation</seealso>
        public virtual GetVirtualMachineResponse GetVirtualMachine(GetVirtualMachineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVirtualMachineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVirtualMachineResponseUnmarshaller.Instance;

            return Invoke<GetVirtualMachineResponse>(request, options);
        }


        /// <summary>
        /// By providing the ARN (Amazon Resource Name), this API returns the virtual machine.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVirtualMachine service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVirtualMachine service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/GetVirtualMachine">REST API Reference for GetVirtualMachine Operation</seealso>
        public virtual Task<GetVirtualMachineResponse> GetVirtualMachineAsync(GetVirtualMachineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVirtualMachineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVirtualMachineResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetVirtualMachineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportHypervisorConfiguration


        /// <summary>
        /// Connect to a hypervisor by importing its configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportHypervisorConfiguration service method.</param>
        /// 
        /// <returns>The response from the ImportHypervisorConfiguration service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.AccessDeniedException">
        /// The operation cannot proceed because you have insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ImportHypervisorConfiguration">REST API Reference for ImportHypervisorConfiguration Operation</seealso>
        public virtual ImportHypervisorConfigurationResponse ImportHypervisorConfiguration(ImportHypervisorConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportHypervisorConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportHypervisorConfigurationResponseUnmarshaller.Instance;

            return Invoke<ImportHypervisorConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Connect to a hypervisor by importing its configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportHypervisorConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportHypervisorConfiguration service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.AccessDeniedException">
        /// The operation cannot proceed because you have insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ImportHypervisorConfiguration">REST API Reference for ImportHypervisorConfiguration Operation</seealso>
        public virtual Task<ImportHypervisorConfigurationResponse> ImportHypervisorConfigurationAsync(ImportHypervisorConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportHypervisorConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportHypervisorConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<ImportHypervisorConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGateways


        /// <summary>
        /// Lists backup gateways owned by an Amazon Web Services account in an Amazon Web Services
        /// Region. The returned list is ordered by gateway Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method.</param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ListGateways">REST API Reference for ListGateways Operation</seealso>
        public virtual ListGatewaysResponse ListGateways(ListGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewaysResponseUnmarshaller.Instance;

            return Invoke<ListGatewaysResponse>(request, options);
        }


        /// <summary>
        /// Lists backup gateways owned by an Amazon Web Services account in an Amazon Web Services
        /// Region. The returned list is ordered by gateway Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGateways service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ListGateways">REST API Reference for ListGateways Operation</seealso>
        public virtual Task<ListGatewaysResponse> ListGatewaysAsync(ListGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGatewaysResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListGatewaysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHypervisors


        /// <summary>
        /// Lists your hypervisors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHypervisors service method.</param>
        /// 
        /// <returns>The response from the ListHypervisors service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ListHypervisors">REST API Reference for ListHypervisors Operation</seealso>
        public virtual ListHypervisorsResponse ListHypervisors(ListHypervisorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHypervisorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHypervisorsResponseUnmarshaller.Instance;

            return Invoke<ListHypervisorsResponse>(request, options);
        }


        /// <summary>
        /// Lists your hypervisors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHypervisors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHypervisors service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ListHypervisors">REST API Reference for ListHypervisors Operation</seealso>
        public virtual Task<ListHypervisorsResponse> ListHypervisorsAsync(ListHypervisorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHypervisorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHypervisorsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListHypervisorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags applied to the resource identified by its Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags applied to the resource identified by its Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVirtualMachines


        /// <summary>
        /// Lists your virtual machines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMachines service method.</param>
        /// 
        /// <returns>The response from the ListVirtualMachines service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ListVirtualMachines">REST API Reference for ListVirtualMachines Operation</seealso>
        public virtual ListVirtualMachinesResponse ListVirtualMachines(ListVirtualMachinesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVirtualMachinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVirtualMachinesResponseUnmarshaller.Instance;

            return Invoke<ListVirtualMachinesResponse>(request, options);
        }


        /// <summary>
        /// Lists your virtual machines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMachines service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVirtualMachines service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/ListVirtualMachines">REST API Reference for ListVirtualMachines Operation</seealso>
        public virtual Task<ListVirtualMachinesResponse> ListVirtualMachinesAsync(ListVirtualMachinesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVirtualMachinesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVirtualMachinesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListVirtualMachinesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBandwidthRateLimitSchedule


        /// <summary>
        /// This action sets the bandwidth rate limit schedule for a specified gateway. By default,
        /// gateways do not have a bandwidth rate limit schedule, which means no bandwidth rate
        /// limiting is in effect. Use this to initiate a gateway's bandwidth rate limit schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBandwidthRateLimitSchedule service method.</param>
        /// 
        /// <returns>The response from the PutBandwidthRateLimitSchedule service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/PutBandwidthRateLimitSchedule">REST API Reference for PutBandwidthRateLimitSchedule Operation</seealso>
        public virtual PutBandwidthRateLimitScheduleResponse PutBandwidthRateLimitSchedule(PutBandwidthRateLimitScheduleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBandwidthRateLimitScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBandwidthRateLimitScheduleResponseUnmarshaller.Instance;

            return Invoke<PutBandwidthRateLimitScheduleResponse>(request, options);
        }


        /// <summary>
        /// This action sets the bandwidth rate limit schedule for a specified gateway. By default,
        /// gateways do not have a bandwidth rate limit schedule, which means no bandwidth rate
        /// limiting is in effect. Use this to initiate a gateway's bandwidth rate limit schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBandwidthRateLimitSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBandwidthRateLimitSchedule service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/PutBandwidthRateLimitSchedule">REST API Reference for PutBandwidthRateLimitSchedule Operation</seealso>
        public virtual Task<PutBandwidthRateLimitScheduleResponse> PutBandwidthRateLimitScheduleAsync(PutBandwidthRateLimitScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBandwidthRateLimitScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBandwidthRateLimitScheduleResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutBandwidthRateLimitScheduleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutHypervisorPropertyMappings


        /// <summary>
        /// This action sets the property mappings for the specified hypervisor. A hypervisor
        /// property mapping displays the relationship of entity properties available from the
        /// on-premises hypervisor to the properties available in Amazon Web Services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutHypervisorPropertyMappings service method.</param>
        /// 
        /// <returns>The response from the PutHypervisorPropertyMappings service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.AccessDeniedException">
        /// The operation cannot proceed because you have insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/PutHypervisorPropertyMappings">REST API Reference for PutHypervisorPropertyMappings Operation</seealso>
        public virtual PutHypervisorPropertyMappingsResponse PutHypervisorPropertyMappings(PutHypervisorPropertyMappingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutHypervisorPropertyMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutHypervisorPropertyMappingsResponseUnmarshaller.Instance;

            return Invoke<PutHypervisorPropertyMappingsResponse>(request, options);
        }


        /// <summary>
        /// This action sets the property mappings for the specified hypervisor. A hypervisor
        /// property mapping displays the relationship of entity properties available from the
        /// on-premises hypervisor to the properties available in Amazon Web Services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutHypervisorPropertyMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutHypervisorPropertyMappings service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.AccessDeniedException">
        /// The operation cannot proceed because you have insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/PutHypervisorPropertyMappings">REST API Reference for PutHypervisorPropertyMappings Operation</seealso>
        public virtual Task<PutHypervisorPropertyMappingsResponse> PutHypervisorPropertyMappingsAsync(PutHypervisorPropertyMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutHypervisorPropertyMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutHypervisorPropertyMappingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutHypervisorPropertyMappingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutMaintenanceStartTime


        /// <summary>
        /// Set the maintenance start time for a gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMaintenanceStartTime service method.</param>
        /// 
        /// <returns>The response from the PutMaintenanceStartTime service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/PutMaintenanceStartTime">REST API Reference for PutMaintenanceStartTime Operation</seealso>
        public virtual PutMaintenanceStartTimeResponse PutMaintenanceStartTime(PutMaintenanceStartTimeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMaintenanceStartTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMaintenanceStartTimeResponseUnmarshaller.Instance;

            return Invoke<PutMaintenanceStartTimeResponse>(request, options);
        }


        /// <summary>
        /// Set the maintenance start time for a gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMaintenanceStartTime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutMaintenanceStartTime service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/PutMaintenanceStartTime">REST API Reference for PutMaintenanceStartTime Operation</seealso>
        public virtual Task<PutMaintenanceStartTimeResponse> PutMaintenanceStartTimeAsync(PutMaintenanceStartTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMaintenanceStartTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMaintenanceStartTimeResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutMaintenanceStartTimeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartVirtualMachinesMetadataSync


        /// <summary>
        /// This action sends a request to sync metadata across the specified virtual machines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartVirtualMachinesMetadataSync service method.</param>
        /// 
        /// <returns>The response from the StartVirtualMachinesMetadataSync service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.AccessDeniedException">
        /// The operation cannot proceed because you have insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/StartVirtualMachinesMetadataSync">REST API Reference for StartVirtualMachinesMetadataSync Operation</seealso>
        public virtual StartVirtualMachinesMetadataSyncResponse StartVirtualMachinesMetadataSync(StartVirtualMachinesMetadataSyncRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartVirtualMachinesMetadataSyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartVirtualMachinesMetadataSyncResponseUnmarshaller.Instance;

            return Invoke<StartVirtualMachinesMetadataSyncResponse>(request, options);
        }


        /// <summary>
        /// This action sends a request to sync metadata across the specified virtual machines.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartVirtualMachinesMetadataSync service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartVirtualMachinesMetadataSync service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.AccessDeniedException">
        /// The operation cannot proceed because you have insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/StartVirtualMachinesMetadataSync">REST API Reference for StartVirtualMachinesMetadataSync Operation</seealso>
        public virtual Task<StartVirtualMachinesMetadataSyncResponse> StartVirtualMachinesMetadataSyncAsync(StartVirtualMachinesMetadataSyncRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartVirtualMachinesMetadataSyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartVirtualMachinesMetadataSyncResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartVirtualMachinesMetadataSyncResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tag the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Tag the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestHypervisorConfiguration


        /// <summary>
        /// Tests your hypervisor configuration to validate that backup gateway can connect with
        /// the hypervisor and its resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestHypervisorConfiguration service method.</param>
        /// 
        /// <returns>The response from the TestHypervisorConfiguration service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/TestHypervisorConfiguration">REST API Reference for TestHypervisorConfiguration Operation</seealso>
        public virtual TestHypervisorConfigurationResponse TestHypervisorConfiguration(TestHypervisorConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestHypervisorConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestHypervisorConfigurationResponseUnmarshaller.Instance;

            return Invoke<TestHypervisorConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Tests your hypervisor configuration to validate that backup gateway can connect with
        /// the hypervisor and its resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestHypervisorConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestHypervisorConfiguration service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/TestHypervisorConfiguration">REST API Reference for TestHypervisorConfiguration Operation</seealso>
        public virtual Task<TestHypervisorConfigurationResponse> TestHypervisorConfigurationAsync(TestHypervisorConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestHypervisorConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestHypervisorConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<TestHypervisorConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes tags from the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGatewayInformation


        /// <summary>
        /// Updates a gateway's name. Specify which gateway to update using the Amazon Resource
        /// Name (ARN) of the gateway in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInformation service method.</param>
        /// 
        /// <returns>The response from the UpdateGatewayInformation service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/UpdateGatewayInformation">REST API Reference for UpdateGatewayInformation Operation</seealso>
        public virtual UpdateGatewayInformationResponse UpdateGatewayInformation(UpdateGatewayInformationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGatewayInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayInformationResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewayInformationResponse>(request, options);
        }


        /// <summary>
        /// Updates a gateway's name. Specify which gateway to update using the Amazon Resource
        /// Name (ARN) of the gateway in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayInformation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGatewayInformation service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/UpdateGatewayInformation">REST API Reference for UpdateGatewayInformation Operation</seealso>
        public virtual Task<UpdateGatewayInformationResponse> UpdateGatewayInformationAsync(UpdateGatewayInformationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGatewayInformationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewayInformationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateGatewayInformationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGatewaySoftwareNow


        /// <summary>
        /// Updates the gateway virtual machine (VM) software. The request immediately triggers
        /// the software update.
        /// 
        ///  <note> 
        /// <para>
        /// When you make this request, you get a <code>200 OK</code> success response immediately.
        /// However, it might take some time for the update to complete.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow service method.</param>
        /// 
        /// <returns>The response from the UpdateGatewaySoftwareNow service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/UpdateGatewaySoftwareNow">REST API Reference for UpdateGatewaySoftwareNow Operation</seealso>
        public virtual UpdateGatewaySoftwareNowResponse UpdateGatewaySoftwareNow(UpdateGatewaySoftwareNowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGatewaySoftwareNowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewaySoftwareNowResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewaySoftwareNowResponse>(request, options);
        }


        /// <summary>
        /// Updates the gateway virtual machine (VM) software. The request immediately triggers
        /// the software update.
        /// 
        ///  <note> 
        /// <para>
        /// When you make this request, you get a <code>200 OK</code> success response immediately.
        /// However, it might take some time for the update to complete.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewaySoftwareNow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGatewaySoftwareNow service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/UpdateGatewaySoftwareNow">REST API Reference for UpdateGatewaySoftwareNow Operation</seealso>
        public virtual Task<UpdateGatewaySoftwareNowResponse> UpdateGatewaySoftwareNowAsync(UpdateGatewaySoftwareNowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGatewaySoftwareNowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGatewaySoftwareNowResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateGatewaySoftwareNowResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateHypervisor


        /// <summary>
        /// Updates a hypervisor metadata, including its host, username, and password. Specify
        /// which hypervisor to update using the Amazon Resource Name (ARN) of the hypervisor
        /// in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHypervisor service method.</param>
        /// 
        /// <returns>The response from the UpdateHypervisor service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.AccessDeniedException">
        /// The operation cannot proceed because you have insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/UpdateHypervisor">REST API Reference for UpdateHypervisor Operation</seealso>
        public virtual UpdateHypervisorResponse UpdateHypervisor(UpdateHypervisorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateHypervisorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHypervisorResponseUnmarshaller.Instance;

            return Invoke<UpdateHypervisorResponse>(request, options);
        }


        /// <summary>
        /// Updates a hypervisor metadata, including its host, username, and password. Specify
        /// which hypervisor to update using the Amazon Resource Name (ARN) of the hypervisor
        /// in your request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHypervisor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateHypervisor service method, as returned by BackupGateway.</returns>
        /// <exception cref="Amazon.BackupGateway.Model.AccessDeniedException">
        /// The operation cannot proceed because you have insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ConflictException">
        /// The operation cannot proceed because it is not supported.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.InternalServerException">
        /// The operation did not succeed because an internal error occurred. Try again later.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ResourceNotFoundException">
        /// A resource that is required for the action wasn't found.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ThrottlingException">
        /// TPS has been limited to protect against intentional or unintentional high request
        /// volumes.
        /// </exception>
        /// <exception cref="Amazon.BackupGateway.Model.ValidationException">
        /// The operation did not succeed because a validation error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backup-gateway-2021-01-01/UpdateHypervisor">REST API Reference for UpdateHypervisor Operation</seealso>
        public virtual Task<UpdateHypervisorResponse> UpdateHypervisorAsync(UpdateHypervisorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateHypervisorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateHypervisorResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateHypervisorResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}