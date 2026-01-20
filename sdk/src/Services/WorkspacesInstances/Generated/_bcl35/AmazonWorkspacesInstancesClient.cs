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
using System.Collections.Generic;
using System.Net;

using Amazon.WorkspacesInstances.Model;
using Amazon.WorkspacesInstances.Model.Internal.MarshallTransformations;
using Amazon.WorkspacesInstances.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
#endif
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkspacesInstancesConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkspacesInstancesConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonWorkspacesInstancesEndpointResolver());
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
        /// Initiates the asynchronous execution of the AssociateVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateVolume operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/AssociateVolume">REST API Reference for AssociateVolume Operation</seealso>
        public virtual IAsyncResult BeginAssociateVolume(AssociateVolumeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateVolumeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateVolume.</param>
        /// 
        /// <returns>Returns a  AssociateVolumeResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/AssociateVolume">REST API Reference for AssociateVolume Operation</seealso>
        public virtual AssociateVolumeResponse EndAssociateVolume(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateVolumeResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
        public virtual IAsyncResult BeginCreateVolume(CreateVolumeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVolumeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVolume.</param>
        /// 
        /// <returns>Returns a  CreateVolumeResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
        public virtual CreateVolumeResponse EndCreateVolume(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVolumeResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the CreateWorkspaceInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceInstance operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkspaceInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/CreateWorkspaceInstance">REST API Reference for CreateWorkspaceInstance Operation</seealso>
        public virtual IAsyncResult BeginCreateWorkspaceInstance(CreateWorkspaceInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWorkspaceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspaceInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkspaceInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkspaceInstance.</param>
        /// 
        /// <returns>Returns a  CreateWorkspaceInstanceResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/CreateWorkspaceInstance">REST API Reference for CreateWorkspaceInstance Operation</seealso>
        public virtual CreateWorkspaceInstanceResponse EndCreateWorkspaceInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateWorkspaceInstanceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DeleteVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        public virtual IAsyncResult BeginDeleteVolume(DeleteVolumeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVolume.</param>
        /// 
        /// <returns>Returns a  DeleteVolumeResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        public virtual DeleteVolumeResponse EndDeleteVolume(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVolumeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteWorkspaceInstance

        /// <summary>
        /// Deletes the specified WorkSpace
        /// 
        ///  <important> 
        /// <para>
        /// Usage of this API will result in deletion of the resource in question.
        /// </para>
        ///  </important>
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
        /// Initiates the asynchronous execution of the DeleteWorkspaceInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceInstance operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkspaceInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DeleteWorkspaceInstance">REST API Reference for DeleteWorkspaceInstance Operation</seealso>
        public virtual IAsyncResult BeginDeleteWorkspaceInstance(DeleteWorkspaceInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkspaceInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkspaceInstance.</param>
        /// 
        /// <returns>Returns a  DeleteWorkspaceInstanceResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DeleteWorkspaceInstance">REST API Reference for DeleteWorkspaceInstance Operation</seealso>
        public virtual DeleteWorkspaceInstanceResponse EndDeleteWorkspaceInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteWorkspaceInstanceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the DisassociateVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVolume operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DisassociateVolume">REST API Reference for DisassociateVolume Operation</seealso>
        public virtual IAsyncResult BeginDisassociateVolume(DisassociateVolumeRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateVolumeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateVolume.</param>
        /// 
        /// <returns>Returns a  DisassociateVolumeResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DisassociateVolume">REST API Reference for DisassociateVolume Operation</seealso>
        public virtual DisassociateVolumeResponse EndDisassociateVolume(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateVolumeResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the GetWorkspaceInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkspaceInstance operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkspaceInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/GetWorkspaceInstance">REST API Reference for GetWorkspaceInstance Operation</seealso>
        public virtual IAsyncResult BeginGetWorkspaceInstance(GetWorkspaceInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWorkspaceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkspaceInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkspaceInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkspaceInstance.</param>
        /// 
        /// <returns>Returns a  GetWorkspaceInstanceResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/GetWorkspaceInstance">REST API Reference for GetWorkspaceInstance Operation</seealso>
        public virtual GetWorkspaceInstanceResponse EndGetWorkspaceInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<GetWorkspaceInstanceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListInstanceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceTypes operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstanceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListInstanceTypes">REST API Reference for ListInstanceTypes Operation</seealso>
        public virtual IAsyncResult BeginListInstanceTypes(ListInstanceTypesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListInstanceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceTypesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstanceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceTypes.</param>
        /// 
        /// <returns>Returns a  ListInstanceTypesResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListInstanceTypes">REST API Reference for ListInstanceTypes Operation</seealso>
        public virtual ListInstanceTypesResponse EndListInstanceTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListInstanceTypesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListRegions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRegions operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRegions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListRegions">REST API Reference for ListRegions Operation</seealso>
        public virtual IAsyncResult BeginListRegions(ListRegionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRegions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRegions.</param>
        /// 
        /// <returns>Returns a  ListRegionsResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListRegions">REST API Reference for ListRegions Operation</seealso>
        public virtual ListRegionsResponse EndListRegions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRegionsResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the ListWorkspaceInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaceInstances operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkspaceInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListWorkspaceInstances">REST API Reference for ListWorkspaceInstances Operation</seealso>
        public virtual IAsyncResult BeginListWorkspaceInstances(ListWorkspaceInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWorkspaceInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkspaceInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkspaceInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkspaceInstances.</param>
        /// 
        /// <returns>Returns a  ListWorkspaceInstancesResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListWorkspaceInstances">REST API Reference for ListWorkspaceInstances Operation</seealso>
        public virtual ListWorkspaceInstancesResponse EndListWorkspaceInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListWorkspaceInstancesResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonWorkspacesInstancesEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}