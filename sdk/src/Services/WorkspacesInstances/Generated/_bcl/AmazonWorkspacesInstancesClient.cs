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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.WorkspacesInstances.Model;
using Amazon.WorkspacesInstances.Model.Internal.MarshallTransformations;
using Amazon.WorkspacesInstances.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.WorkspacesInstances
{
    /// <summary>
    /// <para>Implementation for accessing WorkspacesInstances</para>
    ///
    /// Amazon WorkSpaces Instances provides an API framework for managing virtual workspace
    /// environments across multiple AWS regions, enabling programmatic creation and configuration
    /// of desktop infrastructure.
    /// </summary>
    public partial class AmazonWorkspacesInstancesClient : AmazonServiceClient, IAmazonWorkspacesInstances
    {
        private static IServiceMetadata serviceMetadata = new AmazonWorkspacesInstancesMetadata();
        private IWorkspacesInstancesPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IWorkspacesInstancesPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new WorkspacesInstancesPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonWorkspacesInstancesClient with the credentials loaded from the application's
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
        public AmazonWorkspacesInstancesClient()
            : base(new AmazonWorkspacesInstancesConfig()) { }

        /// <summary>
        /// Constructs AmazonWorkspacesInstancesClient with the credentials loaded from the application's
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
        public AmazonWorkspacesInstancesClient(RegionEndpoint region)
            : base(new AmazonWorkspacesInstancesConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonWorkspacesInstancesClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonWorkspacesInstancesClient Configuration Object</param>
        public AmazonWorkspacesInstancesClient(AmazonWorkspacesInstancesConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonWorkspacesInstancesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonWorkspacesInstancesClient(AWSCredentials credentials)
            : this(credentials, new AmazonWorkspacesInstancesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkspacesInstancesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkspacesInstancesClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonWorkspacesInstancesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkspacesInstancesClient with AWS Credentials and an
        /// AmazonWorkspacesInstancesClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonWorkspacesInstancesClient Configuration Object</param>
        public AmazonWorkspacesInstancesClient(AWSCredentials credentials, AmazonWorkspacesInstancesConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkspacesInstancesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonWorkspacesInstancesClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkspacesInstancesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkspacesInstancesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkspacesInstancesClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkspacesInstancesConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkspacesInstancesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkspacesInstancesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonWorkspacesInstancesClient Configuration Object</param>
        public AmazonWorkspacesInstancesClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonWorkspacesInstancesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkspacesInstancesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonWorkspacesInstancesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkspacesInstancesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkspacesInstancesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkspacesInstancesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkspacesInstancesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkspacesInstancesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkspacesInstancesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonWorkspacesInstancesClient Configuration Object</param>
        public AmazonWorkspacesInstancesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonWorkspacesInstancesConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonWorkspacesInstancesEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonWorkspacesInstancesAuthSchemeHandler());
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


        #region  AssociateVolume


        /// <summary>
        /// Attaches a volume to a WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVolume service method.</param>
        /// 
        /// <returns>The response from the AssociateVolume service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/AssociateVolume">REST API Reference for AssociateVolume Operation</seealso>
        public virtual AssociateVolumeResponse AssociateVolume(AssociateVolumeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateVolumeResponseUnmarshaller.Instance;

            return Invoke<AssociateVolumeResponse>(request, options);
        }


        /// <summary>
        /// Attaches a volume to a WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateVolume service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/AssociateVolume">REST API Reference for AssociateVolume Operation</seealso>
        public virtual Task<AssociateVolumeResponse> AssociateVolumeAsync(AssociateVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateVolumeResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVolume


        /// <summary>
        /// Creates a new volume for WorkSpace Instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume service method.</param>
        /// 
        /// <returns>The response from the CreateVolume service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ServiceQuotaExceededException">
        /// Indicates that a service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
        public virtual CreateVolumeResponse CreateVolume(CreateVolumeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVolumeResponseUnmarshaller.Instance;

            return Invoke<CreateVolumeResponse>(request, options);
        }


        /// <summary>
        /// Creates a new volume for WorkSpace Instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVolume service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ServiceQuotaExceededException">
        /// Indicates that a service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
        public virtual Task<CreateVolumeResponse> CreateVolumeAsync(CreateVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVolumeResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWorkspaceInstance


        /// <summary>
        /// Launches a new WorkSpace Instance with specified configuration parameters, enabling
        /// programmatic workspace deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceInstance service method.</param>
        /// 
        /// <returns>The response from the CreateWorkspaceInstance service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ServiceQuotaExceededException">
        /// Indicates that a service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/CreateWorkspaceInstance">REST API Reference for CreateWorkspaceInstance Operation</seealso>
        public virtual CreateWorkspaceInstanceResponse CreateWorkspaceInstance(CreateWorkspaceInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkspaceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspaceInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateWorkspaceInstanceResponse>(request, options);
        }


        /// <summary>
        /// Launches a new WorkSpace Instance with specified configuration parameters, enabling
        /// programmatic workspace deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkspaceInstance service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ServiceQuotaExceededException">
        /// Indicates that a service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/CreateWorkspaceInstance">REST API Reference for CreateWorkspaceInstance Operation</seealso>
        public virtual Task<CreateWorkspaceInstanceResponse> CreateWorkspaceInstanceAsync(CreateWorkspaceInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkspaceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspaceInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateWorkspaceInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVolume


        /// <summary>
        /// Deletes a specified volume.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume service method.</param>
        /// 
        /// <returns>The response from the DeleteVolume service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        public virtual DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return Invoke<DeleteVolumeResponse>(request, options);
        }


        /// <summary>
        /// Deletes a specified volume.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVolume service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        public virtual Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVolumeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWorkspaceInstance


        /// <summary>
        /// Deletes the specified WorkSpace
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkspaceInstance service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DeleteWorkspaceInstance">REST API Reference for DeleteWorkspaceInstance Operation</seealso>
        public virtual DeleteWorkspaceInstanceResponse DeleteWorkspaceInstance(DeleteWorkspaceInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkspaceInstanceResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified WorkSpace
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkspaceInstance service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DeleteWorkspaceInstance">REST API Reference for DeleteWorkspaceInstance Operation</seealso>
        public virtual Task<DeleteWorkspaceInstanceResponse> DeleteWorkspaceInstanceAsync(DeleteWorkspaceInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteWorkspaceInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateVolume


        /// <summary>
        /// Detaches a volume from a WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVolume service method.</param>
        /// 
        /// <returns>The response from the DisassociateVolume service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DisassociateVolume">REST API Reference for DisassociateVolume Operation</seealso>
        public virtual DisassociateVolumeResponse DisassociateVolume(DisassociateVolumeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateVolumeResponseUnmarshaller.Instance;

            return Invoke<DisassociateVolumeResponse>(request, options);
        }


        /// <summary>
        /// Detaches a volume from a WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVolume service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateVolume service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DisassociateVolume">REST API Reference for DisassociateVolume Operation</seealso>
        public virtual Task<DisassociateVolumeResponse> DisassociateVolumeAsync(DisassociateVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateVolumeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWorkspaceInstance


        /// <summary>
        /// Retrieves detailed information about a specific WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkspaceInstance service method.</param>
        /// 
        /// <returns>The response from the GetWorkspaceInstance service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/GetWorkspaceInstance">REST API Reference for GetWorkspaceInstance Operation</seealso>
        public virtual GetWorkspaceInstanceResponse GetWorkspaceInstance(GetWorkspaceInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkspaceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkspaceInstanceResponseUnmarshaller.Instance;

            return Invoke<GetWorkspaceInstanceResponse>(request, options);
        }


        /// <summary>
        /// Retrieves detailed information about a specific WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkspaceInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkspaceInstance service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/GetWorkspaceInstance">REST API Reference for GetWorkspaceInstance Operation</seealso>
        public virtual Task<GetWorkspaceInstanceResponse> GetWorkspaceInstanceAsync(GetWorkspaceInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkspaceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkspaceInstanceResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetWorkspaceInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListInstanceTypes


        /// <summary>
        /// Retrieves a list of instance types supported by Amazon WorkSpaces Instances, enabling
        /// precise workspace infrastructure configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceTypes service method.</param>
        /// 
        /// <returns>The response from the ListInstanceTypes service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListInstanceTypes">REST API Reference for ListInstanceTypes Operation</seealso>
        public virtual ListInstanceTypesResponse ListInstanceTypes(ListInstanceTypesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInstanceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceTypesResponseUnmarshaller.Instance;

            return Invoke<ListInstanceTypesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of instance types supported by Amazon WorkSpaces Instances, enabling
        /// precise workspace infrastructure configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstanceTypes service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListInstanceTypes">REST API Reference for ListInstanceTypes Operation</seealso>
        public virtual Task<ListInstanceTypesResponse> ListInstanceTypesAsync(ListInstanceTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInstanceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceTypesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListInstanceTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRegions


        /// <summary>
        /// Retrieves a list of AWS regions supported by Amazon WorkSpaces Instances, enabling
        /// region discovery for workspace deployments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegions service method.</param>
        /// 
        /// <returns>The response from the ListRegions service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListRegions">REST API Reference for ListRegions Operation</seealso>
        public virtual ListRegionsResponse ListRegions(ListRegionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegionsResponseUnmarshaller.Instance;

            return Invoke<ListRegionsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list of AWS regions supported by Amazon WorkSpaces Instances, enabling
        /// region discovery for workspace deployments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegions service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListRegions">REST API Reference for ListRegions Operation</seealso>
        public virtual Task<ListRegionsResponse> ListRegionsAsync(ListRegionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRegionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves tags for a WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Retrieves tags for a WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkspaceInstances


        /// <summary>
        /// Retrieves a collection of WorkSpaces Instances based on specified filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaceInstances service method.</param>
        /// 
        /// <returns>The response from the ListWorkspaceInstances service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListWorkspaceInstances">REST API Reference for ListWorkspaceInstances Operation</seealso>
        public virtual ListWorkspaceInstancesResponse ListWorkspaceInstances(ListWorkspaceInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkspaceInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkspaceInstancesResponseUnmarshaller.Instance;

            return Invoke<ListWorkspaceInstancesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a collection of WorkSpaces Instances based on specified filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaceInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkspaceInstances service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListWorkspaceInstances">REST API Reference for ListWorkspaceInstances Operation</seealso>
        public virtual Task<ListWorkspaceInstancesResponse> ListWorkspaceInstancesAsync(ListWorkspaceInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkspaceInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkspaceInstancesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListWorkspaceInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds tags to a WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes tags from a WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes tags from a WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}