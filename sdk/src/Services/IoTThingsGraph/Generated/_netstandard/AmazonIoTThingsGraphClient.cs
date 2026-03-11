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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.IoTThingsGraph.Model;
using Amazon.IoTThingsGraph.Model.Internal.MarshallTransformations;
using Amazon.IoTThingsGraph.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.IoTThingsGraph
{
    /// <summary>
    /// <para>Implementation for accessing IoTThingsGraph</para>
    ///
    /// AWS IoT Things Graph 
    /// <para>
    /// AWS IoT Things Graph provides an integrated set of tools that enable developers to
    /// connect devices and services that use different standards, such as units of measure
    /// and communication protocols. AWS IoT Things Graph makes it possible to build IoT applications
    /// with little to no code by connecting devices and services and defining how they interact
    /// at an abstract level.
    /// </para>
    ///  
    /// <para>
    /// For more information about how AWS IoT Things Graph works, see the <a href="https://docs.aws.amazon.com/thingsgraph/latest/ug/iot-tg-whatis.html">User
    /// Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// The AWS IoT Things Graph service is discontinued.
    /// </para>
    /// </summary>
    public partial class AmazonIoTThingsGraphClient : AmazonServiceClient, IAmazonIoTThingsGraph
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoTThingsGraphMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with the credentials loaded from the application's
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
        public AmazonIoTThingsGraphClient()
            : base(new AmazonIoTThingsGraphConfig()) { }

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with the credentials loaded from the application's
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
        public AmazonIoTThingsGraphClient(RegionEndpoint region)
            : base(new AmazonIoTThingsGraphConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoTThingsGraphClient Configuration Object</param>
        public AmazonIoTThingsGraphClient(AmazonIoTThingsGraphConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoTThingsGraphClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoTThingsGraphConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTThingsGraphClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoTThingsGraphConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with AWS Credentials and an
        /// AmazonIoTThingsGraphClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoTThingsGraphClient Configuration Object</param>
        public AmazonIoTThingsGraphClient(AWSCredentials credentials, AmazonIoTThingsGraphConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoTThingsGraphClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTThingsGraphConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTThingsGraphClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoTThingsGraphConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTThingsGraphClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoTThingsGraphClient Configuration Object</param>
        public AmazonIoTThingsGraphClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoTThingsGraphConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoTThingsGraphClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTThingsGraphConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoTThingsGraphClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoTThingsGraphConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoTThingsGraphClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoTThingsGraphClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoTThingsGraphClient Configuration Object</param>
        public AmazonIoTThingsGraphClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoTThingsGraphConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IIoTThingsGraphPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIoTThingsGraphPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IoTThingsGraphPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoTThingsGraphEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoTThingsGraphAuthSchemeHandler());
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


        #region  AssociateEntityToThing

        [Obsolete("since: 2022-08-30")]
        internal virtual AssociateEntityToThingResponse AssociateEntityToThing(AssociateEntityToThingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateEntityToThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateEntityToThingResponseUnmarshaller.Instance;

            return Invoke<AssociateEntityToThingResponse>(request, options);
        }



        /// <summary>
        /// Associates a device with a concrete thing that is in the user's registry.
        /// 
        ///  
        /// <para>
        /// A thing can be associated with only one device at a time. If you associate a thing
        /// with a new device id, its previous association will be removed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateEntityToThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateEntityToThing service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/AssociateEntityToThing">REST API Reference for AssociateEntityToThing Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<AssociateEntityToThingResponse> AssociateEntityToThingAsync(AssociateEntityToThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateEntityToThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateEntityToThingResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateEntityToThingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFlowTemplate

        [Obsolete("since: 2022-08-30")]
        internal virtual CreateFlowTemplateResponse CreateFlowTemplate(CreateFlowTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateFlowTemplateResponse>(request, options);
        }



        /// <summary>
        /// Creates a workflow template. Workflows can be created only in the user's namespace.
        /// (The public namespace contains only entities.) The workflow can contain only entities
        /// in the specified namespace. The workflow is validated against the entities in the
        /// latest version of the user's namespace unless another namespace version is specified
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFlowTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/CreateFlowTemplate">REST API Reference for CreateFlowTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<CreateFlowTemplateResponse> CreateFlowTemplateAsync(CreateFlowTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFlowTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSystemInstance

        [Obsolete("since: 2022-08-30")]
        internal virtual CreateSystemInstanceResponse CreateSystemInstance(CreateSystemInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSystemInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateSystemInstanceResponse>(request, options);
        }



        /// <summary>
        /// Creates a system instance. 
        /// 
        ///  
        /// <para>
        /// This action validates the system instance, prepares the deployment-related resources.
        /// For Greengrass deployments, it updates the Greengrass group that is specified by the
        /// <c>greengrassGroupName</c> parameter. It also adds a file to the S3 bucket specified
        /// by the <c>s3BucketName</c> parameter. You need to call <c>DeploySystemInstance</c>
        /// after running this action.
        /// </para>
        ///  
        /// <para>
        /// For Greengrass deployments, since this action modifies and adds resources to a Greengrass
        /// group and an S3 bucket on the caller's behalf, the calling identity must have write
        /// permissions to both the specified Greengrass group and S3 bucket. Otherwise, the call
        /// will fail with an authorization error.
        /// </para>
        ///  
        /// <para>
        /// For cloud deployments, this action requires a <c>flowActionsRoleArn</c> value. This
        /// is an IAM role that has permissions to access AWS services, such as AWS Lambda and
        /// AWS IoT, that the flow uses when it executes.
        /// </para>
        ///  
        /// <para>
        /// If the definition document doesn't specify a version of the user's namespace, the
        /// latest version will be used by default.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSystemInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSystemInstance service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/CreateSystemInstance">REST API Reference for CreateSystemInstance Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<CreateSystemInstanceResponse> CreateSystemInstanceAsync(CreateSystemInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSystemInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSystemInstanceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSystemTemplate

        [Obsolete("since: 2022-08-30")]
        internal virtual CreateSystemTemplateResponse CreateSystemTemplate(CreateSystemTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSystemTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateSystemTemplateResponse>(request, options);
        }



        /// <summary>
        /// Creates a system. The system is validated against the entities in the latest version
        /// of the user's namespace unless another namespace version is specified in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSystemTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSystemTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/CreateSystemTemplate">REST API Reference for CreateSystemTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<CreateSystemTemplateResponse> CreateSystemTemplateAsync(CreateSystemTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSystemTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSystemTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFlowTemplate

        [Obsolete("since: 2022-08-30")]
        internal virtual DeleteFlowTemplateResponse DeleteFlowTemplate(DeleteFlowTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteFlowTemplateResponse>(request, options);
        }



        /// <summary>
        /// Deletes a workflow. Any new system or deployment that contains this workflow will
        /// fail to update or deploy. Existing deployments that contain the workflow will continue
        /// to run (since they use a snapshot of the workflow taken at the time of deployment).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFlowTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteFlowTemplate">REST API Reference for DeleteFlowTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<DeleteFlowTemplateResponse> DeleteFlowTemplateAsync(DeleteFlowTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFlowTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteNamespace

        [Obsolete("since: 2022-08-30")]
        internal virtual DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;

            return Invoke<DeleteNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified namespace. This action deletes all of the entities in the namespace.
        /// Delete the systems and flows that use entities in the namespace before performing
        /// this action. This action takes no request parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNamespace service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<DeleteNamespaceResponse> DeleteNamespaceAsync(DeleteNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSystemInstance

        [Obsolete("since: 2022-08-30")]
        internal virtual DeleteSystemInstanceResponse DeleteSystemInstance(DeleteSystemInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSystemInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteSystemInstanceResponse>(request, options);
        }



        /// <summary>
        /// Deletes a system instance. Only system instances that have never been deployed, or
        /// that have been undeployed can be deleted.
        /// 
        ///  
        /// <para>
        /// Users can create a new system instance that has the same ID as a deleted system instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSystemInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSystemInstance service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteSystemInstance">REST API Reference for DeleteSystemInstance Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<DeleteSystemInstanceResponse> DeleteSystemInstanceAsync(DeleteSystemInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSystemInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSystemInstanceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSystemTemplate

        [Obsolete("since: 2022-08-30")]
        internal virtual DeleteSystemTemplateResponse DeleteSystemTemplate(DeleteSystemTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSystemTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteSystemTemplateResponse>(request, options);
        }



        /// <summary>
        /// Deletes a system. New deployments can't contain the system after its deletion. Existing
        /// deployments that contain the system will continue to work because they use a snapshot
        /// of the system that is taken when it is deployed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSystemTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSystemTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteSystemTemplate">REST API Reference for DeleteSystemTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<DeleteSystemTemplateResponse> DeleteSystemTemplateAsync(DeleteSystemTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSystemTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSystemTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeploySystemInstance

        [Obsolete("since: 2022-08-30")]
        internal virtual DeploySystemInstanceResponse DeploySystemInstance(DeploySystemInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeploySystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeploySystemInstanceResponseUnmarshaller.Instance;

            return Invoke<DeploySystemInstanceResponse>(request, options);
        }



        /// <summary>
        /// <b>Greengrass and Cloud Deployments</b> 
        /// 
        ///  
        /// <para>
        /// Deploys the system instance to the target specified in <c>CreateSystemInstance</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Greengrass Deployments</b> 
        /// </para>
        ///  
        /// <para>
        /// If the system or any workflows and entities have been updated before this action is
        /// called, then the deployment will create a new Amazon Simple Storage Service resource
        /// file and then deploy it.
        /// </para>
        ///  
        /// <para>
        /// Since this action creates a Greengrass deployment on the caller's behalf, the calling
        /// identity must have write permissions to the specified Greengrass group. Otherwise,
        /// the call will fail with an authorization error.
        /// </para>
        ///  
        /// <para>
        /// For information about the artifacts that get added to your Greengrass core device
        /// when you use this API, see <a href="https://docs.aws.amazon.com/thingsgraph/latest/ug/iot-tg-greengrass.html">AWS
        /// IoT Things Graph and AWS IoT Greengrass</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeploySystemInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeploySystemInstance service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeploySystemInstance">REST API Reference for DeploySystemInstance Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<DeploySystemInstanceResponse> DeploySystemInstanceAsync(DeploySystemInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeploySystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeploySystemInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeploySystemInstanceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeprecateFlowTemplate

        [Obsolete("since: 2022-08-30")]
        internal virtual DeprecateFlowTemplateResponse DeprecateFlowTemplate(DeprecateFlowTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeprecateFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateFlowTemplateResponseUnmarshaller.Instance;

            return Invoke<DeprecateFlowTemplateResponse>(request, options);
        }



        /// <summary>
        /// Deprecates the specified workflow. This action marks the workflow for deletion. Deprecated
        /// flows can't be deployed, but existing deployments will continue to run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateFlowTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeprecateFlowTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeprecateFlowTemplate">REST API Reference for DeprecateFlowTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<DeprecateFlowTemplateResponse> DeprecateFlowTemplateAsync(DeprecateFlowTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeprecateFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateFlowTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeprecateFlowTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeprecateSystemTemplate

        [Obsolete("since: 2022-08-30")]
        internal virtual DeprecateSystemTemplateResponse DeprecateSystemTemplate(DeprecateSystemTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeprecateSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateSystemTemplateResponseUnmarshaller.Instance;

            return Invoke<DeprecateSystemTemplateResponse>(request, options);
        }



        /// <summary>
        /// Deprecates the specified system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateSystemTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeprecateSystemTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeprecateSystemTemplate">REST API Reference for DeprecateSystemTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<DeprecateSystemTemplateResponse> DeprecateSystemTemplateAsync(DeprecateSystemTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeprecateSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateSystemTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeprecateSystemTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeNamespace

        [Obsolete("since: 2022-08-30")]
        internal virtual DescribeNamespaceResponse DescribeNamespace(DescribeNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNamespaceResponseUnmarshaller.Instance;

            return Invoke<DescribeNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Gets the latest version of the user's namespace and the public version that it is
        /// tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNamespace service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DescribeNamespace">REST API Reference for DescribeNamespace Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<DescribeNamespaceResponse> DescribeNamespaceAsync(DescribeNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNamespaceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DissociateEntityFromThing

        [Obsolete("since: 2022-08-30")]
        internal virtual DissociateEntityFromThingResponse DissociateEntityFromThing(DissociateEntityFromThingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DissociateEntityFromThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DissociateEntityFromThingResponseUnmarshaller.Instance;

            return Invoke<DissociateEntityFromThingResponse>(request, options);
        }



        /// <summary>
        /// Dissociates a device entity from a concrete thing. The action takes only the type
        /// of the entity that you need to dissociate because only one entity of a particular
        /// type can be associated with a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DissociateEntityFromThing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DissociateEntityFromThing service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DissociateEntityFromThing">REST API Reference for DissociateEntityFromThing Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<DissociateEntityFromThingResponse> DissociateEntityFromThingAsync(DissociateEntityFromThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DissociateEntityFromThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DissociateEntityFromThingResponseUnmarshaller.Instance;

            return InvokeAsync<DissociateEntityFromThingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEntities

        [Obsolete("since: 2022-08-30")]
        internal virtual GetEntitiesResponse GetEntities(GetEntitiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEntitiesResponseUnmarshaller.Instance;

            return Invoke<GetEntitiesResponse>(request, options);
        }



        /// <summary>
        /// Gets definitions of the specified entities. Uses the latest version of the user's
        /// namespace by default. This API returns the following TDM entities.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Properties
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// States
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Events
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Actions
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Capabilities
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Mappings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Devices
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Device Models
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Services
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This action doesn't return definitions for systems, flows, and deployments.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEntities service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetEntities">REST API Reference for GetEntities Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<GetEntitiesResponse> GetEntitiesAsync(GetEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEntitiesResponseUnmarshaller.Instance;

            return InvokeAsync<GetEntitiesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFlowTemplate

        [Obsolete("since: 2022-08-30")]
        internal virtual GetFlowTemplateResponse GetFlowTemplate(GetFlowTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFlowTemplateResponseUnmarshaller.Instance;

            return Invoke<GetFlowTemplateResponse>(request, options);
        }



        /// <summary>
        /// Gets the latest version of the <c>DefinitionDocument</c> and <c>FlowTemplateSummary</c>
        /// for the specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFlowTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFlowTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetFlowTemplate">REST API Reference for GetFlowTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<GetFlowTemplateResponse> GetFlowTemplateAsync(GetFlowTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFlowTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetFlowTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetFlowTemplateRevisions

        [Obsolete("since: 2022-08-30")]
        internal virtual GetFlowTemplateRevisionsResponse GetFlowTemplateRevisions(GetFlowTemplateRevisionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFlowTemplateRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFlowTemplateRevisionsResponseUnmarshaller.Instance;

            return Invoke<GetFlowTemplateRevisionsResponse>(request, options);
        }



        /// <summary>
        /// Gets revisions of the specified workflow. Only the last 100 revisions are stored.
        /// If the workflow has been deprecated, this action will return revisions that occurred
        /// before the deprecation. This action won't work for workflows that have been deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFlowTemplateRevisions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFlowTemplateRevisions service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetFlowTemplateRevisions">REST API Reference for GetFlowTemplateRevisions Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<GetFlowTemplateRevisionsResponse> GetFlowTemplateRevisionsAsync(GetFlowTemplateRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFlowTemplateRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFlowTemplateRevisionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetFlowTemplateRevisionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetNamespaceDeletionStatus

        [Obsolete("since: 2022-08-30")]
        internal virtual GetNamespaceDeletionStatusResponse GetNamespaceDeletionStatus(GetNamespaceDeletionStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNamespaceDeletionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNamespaceDeletionStatusResponseUnmarshaller.Instance;

            return Invoke<GetNamespaceDeletionStatusResponse>(request, options);
        }



        /// <summary>
        /// Gets the status of a namespace deletion task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNamespaceDeletionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNamespaceDeletionStatus service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetNamespaceDeletionStatus">REST API Reference for GetNamespaceDeletionStatus Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<GetNamespaceDeletionStatusResponse> GetNamespaceDeletionStatusAsync(GetNamespaceDeletionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNamespaceDeletionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNamespaceDeletionStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetNamespaceDeletionStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSystemInstance

        [Obsolete("since: 2022-08-30")]
        internal virtual GetSystemInstanceResponse GetSystemInstance(GetSystemInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSystemInstanceResponseUnmarshaller.Instance;

            return Invoke<GetSystemInstanceResponse>(request, options);
        }



        /// <summary>
        /// Gets a system instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSystemInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSystemInstance service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetSystemInstance">REST API Reference for GetSystemInstance Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<GetSystemInstanceResponse> GetSystemInstanceAsync(GetSystemInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSystemInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetSystemInstanceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSystemTemplate

        [Obsolete("since: 2022-08-30")]
        internal virtual GetSystemTemplateResponse GetSystemTemplate(GetSystemTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSystemTemplateResponseUnmarshaller.Instance;

            return Invoke<GetSystemTemplateResponse>(request, options);
        }



        /// <summary>
        /// Gets a system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSystemTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSystemTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetSystemTemplate">REST API Reference for GetSystemTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<GetSystemTemplateResponse> GetSystemTemplateAsync(GetSystemTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSystemTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetSystemTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSystemTemplateRevisions

        [Obsolete("since: 2022-08-30")]
        internal virtual GetSystemTemplateRevisionsResponse GetSystemTemplateRevisions(GetSystemTemplateRevisionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSystemTemplateRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSystemTemplateRevisionsResponseUnmarshaller.Instance;

            return Invoke<GetSystemTemplateRevisionsResponse>(request, options);
        }



        /// <summary>
        /// Gets revisions made to the specified system template. Only the previous 100 revisions
        /// are stored. If the system has been deprecated, this action will return the revisions
        /// that occurred before its deprecation. This action won't work with systems that have
        /// been deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSystemTemplateRevisions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSystemTemplateRevisions service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetSystemTemplateRevisions">REST API Reference for GetSystemTemplateRevisions Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<GetSystemTemplateRevisionsResponse> GetSystemTemplateRevisionsAsync(GetSystemTemplateRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSystemTemplateRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSystemTemplateRevisionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetSystemTemplateRevisionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetUploadStatus

        [Obsolete("since: 2022-08-30")]
        internal virtual GetUploadStatusResponse GetUploadStatus(GetUploadStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUploadStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUploadStatusResponseUnmarshaller.Instance;

            return Invoke<GetUploadStatusResponse>(request, options);
        }



        /// <summary>
        /// Gets the status of the specified upload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUploadStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUploadStatus service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetUploadStatus">REST API Reference for GetUploadStatus Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<GetUploadStatusResponse> GetUploadStatusAsync(GetUploadStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUploadStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUploadStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetUploadStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFlowExecutionMessages

        [Obsolete("since: 2022-08-30")]
        internal virtual ListFlowExecutionMessagesResponse ListFlowExecutionMessages(ListFlowExecutionMessagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowExecutionMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowExecutionMessagesResponseUnmarshaller.Instance;

            return Invoke<ListFlowExecutionMessagesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of objects that contain information about events in a flow execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlowExecutionMessages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFlowExecutionMessages service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/ListFlowExecutionMessages">REST API Reference for ListFlowExecutionMessages Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<ListFlowExecutionMessagesResponse> ListFlowExecutionMessagesAsync(ListFlowExecutionMessagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowExecutionMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowExecutionMessagesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFlowExecutionMessagesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        [Obsolete("since: 2022-08-30")]
        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists all tags on an AWS IoT Things Graph resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchEntities

        [Obsolete("since: 2022-08-30")]
        internal virtual SearchEntitiesResponse SearchEntities(SearchEntitiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchEntitiesResponseUnmarshaller.Instance;

            return Invoke<SearchEntitiesResponse>(request, options);
        }



        /// <summary>
        /// Searches for entities of the specified type. You can search for entities in your namespace
        /// and the public namespace that you're tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchEntities service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchEntities">REST API Reference for SearchEntities Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<SearchEntitiesResponse> SearchEntitiesAsync(SearchEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchEntitiesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchEntitiesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchFlowExecutions

        [Obsolete("since: 2022-08-30")]
        internal virtual SearchFlowExecutionsResponse SearchFlowExecutions(SearchFlowExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchFlowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFlowExecutionsResponseUnmarshaller.Instance;

            return Invoke<SearchFlowExecutionsResponse>(request, options);
        }



        /// <summary>
        /// Searches for AWS IoT Things Graph workflow execution instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFlowExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchFlowExecutions service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchFlowExecutions">REST API Reference for SearchFlowExecutions Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<SearchFlowExecutionsResponse> SearchFlowExecutionsAsync(SearchFlowExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchFlowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFlowExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchFlowExecutionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchFlowTemplates

        [Obsolete("since: 2022-08-30")]
        internal virtual SearchFlowTemplatesResponse SearchFlowTemplates(SearchFlowTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchFlowTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFlowTemplatesResponseUnmarshaller.Instance;

            return Invoke<SearchFlowTemplatesResponse>(request, options);
        }



        /// <summary>
        /// Searches for summary information about workflows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFlowTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchFlowTemplates service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchFlowTemplates">REST API Reference for SearchFlowTemplates Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<SearchFlowTemplatesResponse> SearchFlowTemplatesAsync(SearchFlowTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchFlowTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFlowTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchFlowTemplatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchSystemInstances

        [Obsolete("since: 2022-08-30")]
        internal virtual SearchSystemInstancesResponse SearchSystemInstances(SearchSystemInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchSystemInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSystemInstancesResponseUnmarshaller.Instance;

            return Invoke<SearchSystemInstancesResponse>(request, options);
        }



        /// <summary>
        /// Searches for system instances in the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSystemInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchSystemInstances service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchSystemInstances">REST API Reference for SearchSystemInstances Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<SearchSystemInstancesResponse> SearchSystemInstancesAsync(SearchSystemInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchSystemInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSystemInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchSystemInstancesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchSystemTemplates

        [Obsolete("since: 2022-08-30")]
        internal virtual SearchSystemTemplatesResponse SearchSystemTemplates(SearchSystemTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchSystemTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSystemTemplatesResponseUnmarshaller.Instance;

            return Invoke<SearchSystemTemplatesResponse>(request, options);
        }



        /// <summary>
        /// Searches for summary information about systems in the user's account. You can filter
        /// by the ID of a workflow to return only systems that use the specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSystemTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchSystemTemplates service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchSystemTemplates">REST API Reference for SearchSystemTemplates Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<SearchSystemTemplatesResponse> SearchSystemTemplatesAsync(SearchSystemTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchSystemTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSystemTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchSystemTemplatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SearchThings

        [Obsolete("since: 2022-08-30")]
        internal virtual SearchThingsResponse SearchThings(SearchThingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchThingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchThingsResponseUnmarshaller.Instance;

            return Invoke<SearchThingsResponse>(request, options);
        }



        /// <summary>
        /// Searches for things associated with the specified entity. You can search by both device
        /// and device model.
        /// 
        ///  
        /// <para>
        /// For example, if two different devices, camera1 and camera2, implement the camera device
        /// model, the user can associate thing1 to camera1 and thing2 to camera2. <c>SearchThings(camera2)</c>
        /// will return only thing2, but <c>SearchThings(camera)</c> will return both thing1 and
        /// thing2.
        /// </para>
        ///  
        /// <para>
        /// This action searches for exact matches and doesn't perform partial text matching.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchThings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchThings service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchThings">REST API Reference for SearchThings Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<SearchThingsResponse> SearchThingsAsync(SearchThingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchThingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchThingsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchThingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        [Obsolete("since: 2022-08-30")]
        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Creates a tag for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/TagResource">REST API Reference for TagResource Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UndeploySystemInstance

        [Obsolete("since: 2022-08-30")]
        internal virtual UndeploySystemInstanceResponse UndeploySystemInstance(UndeploySystemInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UndeploySystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UndeploySystemInstanceResponseUnmarshaller.Instance;

            return Invoke<UndeploySystemInstanceResponse>(request, options);
        }



        /// <summary>
        /// Removes a system instance from its target (Cloud or Greengrass).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UndeploySystemInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UndeploySystemInstance service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UndeploySystemInstance">REST API Reference for UndeploySystemInstance Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<UndeploySystemInstanceResponse> UndeploySystemInstanceAsync(UndeploySystemInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UndeploySystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UndeploySystemInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UndeploySystemInstanceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        [Obsolete("since: 2022-08-30")]
        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes a tag from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFlowTemplate

        [Obsolete("since: 2022-08-30")]
        internal virtual UpdateFlowTemplateResponse UpdateFlowTemplate(UpdateFlowTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateFlowTemplateResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified workflow. All deployed systems and system instances that use
        /// the workflow will see the changes in the flow when it is redeployed. If you don't
        /// want this behavior, copy the workflow (creating a new workflow with a different ID),
        /// and update the copy. The workflow can contain only entities in the specified namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFlowTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UpdateFlowTemplate">REST API Reference for UpdateFlowTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<UpdateFlowTemplateResponse> UpdateFlowTemplateAsync(UpdateFlowTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFlowTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSystemTemplate

        [Obsolete("since: 2022-08-30")]
        internal virtual UpdateSystemTemplateResponse UpdateSystemTemplate(UpdateSystemTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSystemTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateSystemTemplateResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified system. You don't need to run this action after updating a workflow.
        /// Any deployment that uses the system will see the changes in the system when it is
        /// redeployed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSystemTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSystemTemplate service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UpdateSystemTemplate">REST API Reference for UpdateSystemTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<UpdateSystemTemplateResponse> UpdateSystemTemplateAsync(UpdateSystemTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSystemTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSystemTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UploadEntityDefinitions

        [Obsolete("since: 2022-08-30")]
        internal virtual UploadEntityDefinitionsResponse UploadEntityDefinitions(UploadEntityDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UploadEntityDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadEntityDefinitionsResponseUnmarshaller.Instance;

            return Invoke<UploadEntityDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Asynchronously uploads one or more entity definitions to the user's namespace. The
        /// <c>document</c> parameter is required if <c>syncWithPublicNamespace</c> and <c>deleteExistingEntites</c>
        /// are false. If the <c>syncWithPublicNamespace</c> parameter is set to <c>true</c>,
        /// the user's namespace will synchronize with the latest version of the public namespace.
        /// If <c>deprecateExistingEntities</c> is set to true, all entities in the latest version
        /// will be deleted before the new <c>DefinitionDocument</c> is uploaded.
        /// 
        ///  
        /// <para>
        /// When a user uploads entity definitions for the first time, the service creates a new
        /// namespace for the user. The new namespace tracks the public namespace. Currently users
        /// can have only one namespace. The namespace version increments whenever a user uploads
        /// entity definitions that are backwards-incompatible and whenever a user sets the <c>syncWithPublicNamespace</c>
        /// parameter or the <c>deprecateExistingEntities</c> parameter to <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// The IDs for all of the entities should be in URN format. Each entity must be in the
        /// user's namespace. Users can't create entities in the public namespace, but entity
        /// definitions can refer to entities in the public namespace.
        /// </para>
        ///  
        /// <para>
        /// Valid entities are <c>Device</c>, <c>DeviceModel</c>, <c>Service</c>, <c>Capability</c>,
        /// <c>State</c>, <c>Action</c>, <c>Event</c>, <c>Property</c>, <c>Mapping</c>, <c>Enum</c>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadEntityDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UploadEntityDefinitions service method, as returned by IoTThingsGraph.</returns>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoTThingsGraph.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UploadEntityDefinitions">REST API Reference for UploadEntityDefinitions Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual Task<UploadEntityDefinitionsResponse> UploadEntityDefinitionsAsync(UploadEntityDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UploadEntityDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadEntityDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<UploadEntityDefinitionsResponse>(request, options, cancellationToken);
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