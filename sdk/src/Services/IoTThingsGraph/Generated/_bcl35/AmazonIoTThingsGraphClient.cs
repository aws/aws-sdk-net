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
using System.Collections.Generic;
using System.Net;

using Amazon.IoTThingsGraph.Model;
using Amazon.IoTThingsGraph.Model.Internal.MarshallTransformations;
using Amazon.IoTThingsGraph.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTThingsGraphConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoTThingsGraphConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIoTThingsGraphEndpointResolver());
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
        public virtual AssociateEntityToThingResponse AssociateEntityToThing(AssociateEntityToThingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateEntityToThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateEntityToThingResponseUnmarshaller.Instance;

            return Invoke<AssociateEntityToThingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateEntityToThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateEntityToThing operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateEntityToThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/AssociateEntityToThing">REST API Reference for AssociateEntityToThing Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginAssociateEntityToThing(AssociateEntityToThingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateEntityToThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateEntityToThingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateEntityToThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateEntityToThing.</param>
        /// 
        /// <returns>Returns a  AssociateEntityToThingResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/AssociateEntityToThing">REST API Reference for AssociateEntityToThing Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual AssociateEntityToThingResponse EndAssociateEntityToThing(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateEntityToThingResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFlowTemplate

        /// <summary>
        /// Creates a workflow template. Workflows can be created only in the user's namespace.
        /// (The public namespace contains only entities.) The workflow can contain only entities
        /// in the specified namespace. The workflow is validated against the entities in the
        /// latest version of the user's namespace unless another namespace version is specified
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowTemplate service method.</param>
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
        public virtual CreateFlowTemplateResponse CreateFlowTemplate(CreateFlowTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateFlowTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFlowTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowTemplate operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFlowTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/CreateFlowTemplate">REST API Reference for CreateFlowTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginCreateFlowTemplate(CreateFlowTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFlowTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFlowTemplate.</param>
        /// 
        /// <returns>Returns a  CreateFlowTemplateResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/CreateFlowTemplate">REST API Reference for CreateFlowTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual CreateFlowTemplateResponse EndCreateFlowTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFlowTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSystemInstance

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
        public virtual CreateSystemInstanceResponse CreateSystemInstance(CreateSystemInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSystemInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateSystemInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSystemInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSystemInstance operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSystemInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/CreateSystemInstance">REST API Reference for CreateSystemInstance Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginCreateSystemInstance(CreateSystemInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSystemInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSystemInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSystemInstance.</param>
        /// 
        /// <returns>Returns a  CreateSystemInstanceResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/CreateSystemInstance">REST API Reference for CreateSystemInstance Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual CreateSystemInstanceResponse EndCreateSystemInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSystemInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSystemTemplate

        /// <summary>
        /// Creates a system. The system is validated against the entities in the latest version
        /// of the user's namespace unless another namespace version is specified in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSystemTemplate service method.</param>
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
        public virtual CreateSystemTemplateResponse CreateSystemTemplate(CreateSystemTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSystemTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateSystemTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSystemTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSystemTemplate operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSystemTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/CreateSystemTemplate">REST API Reference for CreateSystemTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginCreateSystemTemplate(CreateSystemTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSystemTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSystemTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSystemTemplate.</param>
        /// 
        /// <returns>Returns a  CreateSystemTemplateResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/CreateSystemTemplate">REST API Reference for CreateSystemTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual CreateSystemTemplateResponse EndCreateSystemTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSystemTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFlowTemplate

        /// <summary>
        /// Deletes a workflow. Any new system or deployment that contains this workflow will
        /// fail to update or deploy. Existing deployments that contain the workflow will continue
        /// to run (since they use a snapshot of the workflow taken at the time of deployment).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowTemplate service method.</param>
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
        public virtual DeleteFlowTemplateResponse DeleteFlowTemplate(DeleteFlowTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteFlowTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFlowTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowTemplate operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFlowTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteFlowTemplate">REST API Reference for DeleteFlowTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginDeleteFlowTemplate(DeleteFlowTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFlowTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFlowTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteFlowTemplateResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteFlowTemplate">REST API Reference for DeleteFlowTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual DeleteFlowTemplateResponse EndDeleteFlowTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFlowTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteNamespace

        /// <summary>
        /// Deletes the specified namespace. This action deletes all of the entities in the namespace.
        /// Delete the systems and flows that use entities in the namespace before performing
        /// this action. This action takes no request parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace service method.</param>
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
        public virtual DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;

            return Invoke<DeleteNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginDeleteNamespace(DeleteNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNamespace.</param>
        /// 
        /// <returns>Returns a  DeleteNamespaceResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual DeleteNamespaceResponse EndDeleteNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSystemInstance

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
        public virtual DeleteSystemInstanceResponse DeleteSystemInstance(DeleteSystemInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSystemInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteSystemInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSystemInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSystemInstance operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSystemInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteSystemInstance">REST API Reference for DeleteSystemInstance Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginDeleteSystemInstance(DeleteSystemInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSystemInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSystemInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSystemInstance.</param>
        /// 
        /// <returns>Returns a  DeleteSystemInstanceResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteSystemInstance">REST API Reference for DeleteSystemInstance Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual DeleteSystemInstanceResponse EndDeleteSystemInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSystemInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSystemTemplate

        /// <summary>
        /// Deletes a system. New deployments can't contain the system after its deletion. Existing
        /// deployments that contain the system will continue to work because they use a snapshot
        /// of the system that is taken when it is deployed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSystemTemplate service method.</param>
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
        public virtual DeleteSystemTemplateResponse DeleteSystemTemplate(DeleteSystemTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSystemTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteSystemTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSystemTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSystemTemplate operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSystemTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteSystemTemplate">REST API Reference for DeleteSystemTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginDeleteSystemTemplate(DeleteSystemTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSystemTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSystemTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSystemTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteSystemTemplateResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteSystemTemplate">REST API Reference for DeleteSystemTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual DeleteSystemTemplateResponse EndDeleteSystemTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSystemTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeploySystemInstance

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
        public virtual DeploySystemInstanceResponse DeploySystemInstance(DeploySystemInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeploySystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeploySystemInstanceResponseUnmarshaller.Instance;

            return Invoke<DeploySystemInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeploySystemInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeploySystemInstance operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeploySystemInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeploySystemInstance">REST API Reference for DeploySystemInstance Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginDeploySystemInstance(DeploySystemInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeploySystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeploySystemInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeploySystemInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeploySystemInstance.</param>
        /// 
        /// <returns>Returns a  DeploySystemInstanceResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeploySystemInstance">REST API Reference for DeploySystemInstance Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual DeploySystemInstanceResponse EndDeploySystemInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<DeploySystemInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeprecateFlowTemplate

        /// <summary>
        /// Deprecates the specified workflow. This action marks the workflow for deletion. Deprecated
        /// flows can't be deployed, but existing deployments will continue to run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateFlowTemplate service method.</param>
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
        public virtual DeprecateFlowTemplateResponse DeprecateFlowTemplate(DeprecateFlowTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeprecateFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateFlowTemplateResponseUnmarshaller.Instance;

            return Invoke<DeprecateFlowTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateFlowTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateFlowTemplate operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeprecateFlowTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeprecateFlowTemplate">REST API Reference for DeprecateFlowTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginDeprecateFlowTemplate(DeprecateFlowTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeprecateFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateFlowTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeprecateFlowTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeprecateFlowTemplate.</param>
        /// 
        /// <returns>Returns a  DeprecateFlowTemplateResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeprecateFlowTemplate">REST API Reference for DeprecateFlowTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual DeprecateFlowTemplateResponse EndDeprecateFlowTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeprecateFlowTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeprecateSystemTemplate

        /// <summary>
        /// Deprecates the specified system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateSystemTemplate service method.</param>
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
        public virtual DeprecateSystemTemplateResponse DeprecateSystemTemplate(DeprecateSystemTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeprecateSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateSystemTemplateResponseUnmarshaller.Instance;

            return Invoke<DeprecateSystemTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateSystemTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateSystemTemplate operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeprecateSystemTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeprecateSystemTemplate">REST API Reference for DeprecateSystemTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginDeprecateSystemTemplate(DeprecateSystemTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeprecateSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateSystemTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeprecateSystemTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeprecateSystemTemplate.</param>
        /// 
        /// <returns>Returns a  DeprecateSystemTemplateResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeprecateSystemTemplate">REST API Reference for DeprecateSystemTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual DeprecateSystemTemplateResponse EndDeprecateSystemTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeprecateSystemTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeNamespace

        /// <summary>
        /// Gets the latest version of the user's namespace and the public version that it is
        /// tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNamespace service method.</param>
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
        public virtual DescribeNamespaceResponse DescribeNamespace(DescribeNamespaceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNamespaceResponseUnmarshaller.Instance;

            return Invoke<DescribeNamespaceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNamespace operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DescribeNamespace">REST API Reference for DescribeNamespace Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginDescribeNamespace(DescribeNamespaceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNamespaceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNamespace.</param>
        /// 
        /// <returns>Returns a  DescribeNamespaceResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DescribeNamespace">REST API Reference for DescribeNamespace Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual DescribeNamespaceResponse EndDescribeNamespace(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeNamespaceResponse>(asyncResult);
        }

        #endregion
        
        #region  DissociateEntityFromThing

        /// <summary>
        /// Dissociates a device entity from a concrete thing. The action takes only the type
        /// of the entity that you need to dissociate because only one entity of a particular
        /// type can be associated with a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DissociateEntityFromThing service method.</param>
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
        public virtual DissociateEntityFromThingResponse DissociateEntityFromThing(DissociateEntityFromThingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DissociateEntityFromThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DissociateEntityFromThingResponseUnmarshaller.Instance;

            return Invoke<DissociateEntityFromThingResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DissociateEntityFromThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DissociateEntityFromThing operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDissociateEntityFromThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DissociateEntityFromThing">REST API Reference for DissociateEntityFromThing Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginDissociateEntityFromThing(DissociateEntityFromThingRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DissociateEntityFromThingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DissociateEntityFromThingResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DissociateEntityFromThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDissociateEntityFromThing.</param>
        /// 
        /// <returns>Returns a  DissociateEntityFromThingResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DissociateEntityFromThing">REST API Reference for DissociateEntityFromThing Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual DissociateEntityFromThingResponse EndDissociateEntityFromThing(IAsyncResult asyncResult)
        {
            return EndInvoke<DissociateEntityFromThingResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEntities

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
        public virtual GetEntitiesResponse GetEntities(GetEntitiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEntitiesResponseUnmarshaller.Instance;

            return Invoke<GetEntitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEntities operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEntities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetEntities">REST API Reference for GetEntities Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginGetEntities(GetEntitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEntitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEntities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEntities.</param>
        /// 
        /// <returns>Returns a  GetEntitiesResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetEntities">REST API Reference for GetEntities Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual GetEntitiesResponse EndGetEntities(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEntitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFlowTemplate

        /// <summary>
        /// Gets the latest version of the <c>DefinitionDocument</c> and <c>FlowTemplateSummary</c>
        /// for the specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFlowTemplate service method.</param>
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
        public virtual GetFlowTemplateResponse GetFlowTemplate(GetFlowTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFlowTemplateResponseUnmarshaller.Instance;

            return Invoke<GetFlowTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFlowTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFlowTemplate operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFlowTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetFlowTemplate">REST API Reference for GetFlowTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginGetFlowTemplate(GetFlowTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFlowTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFlowTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFlowTemplate.</param>
        /// 
        /// <returns>Returns a  GetFlowTemplateResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetFlowTemplate">REST API Reference for GetFlowTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual GetFlowTemplateResponse EndGetFlowTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFlowTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetFlowTemplateRevisions

        /// <summary>
        /// Gets revisions of the specified workflow. Only the last 100 revisions are stored.
        /// If the workflow has been deprecated, this action will return revisions that occurred
        /// before the deprecation. This action won't work for workflows that have been deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFlowTemplateRevisions service method.</param>
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
        public virtual GetFlowTemplateRevisionsResponse GetFlowTemplateRevisions(GetFlowTemplateRevisionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFlowTemplateRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFlowTemplateRevisionsResponseUnmarshaller.Instance;

            return Invoke<GetFlowTemplateRevisionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetFlowTemplateRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFlowTemplateRevisions operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFlowTemplateRevisions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetFlowTemplateRevisions">REST API Reference for GetFlowTemplateRevisions Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginGetFlowTemplateRevisions(GetFlowTemplateRevisionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetFlowTemplateRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFlowTemplateRevisionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetFlowTemplateRevisions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFlowTemplateRevisions.</param>
        /// 
        /// <returns>Returns a  GetFlowTemplateRevisionsResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetFlowTemplateRevisions">REST API Reference for GetFlowTemplateRevisions Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual GetFlowTemplateRevisionsResponse EndGetFlowTemplateRevisions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetFlowTemplateRevisionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetNamespaceDeletionStatus

        /// <summary>
        /// Gets the status of a namespace deletion task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNamespaceDeletionStatus service method.</param>
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
        public virtual GetNamespaceDeletionStatusResponse GetNamespaceDeletionStatus(GetNamespaceDeletionStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNamespaceDeletionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNamespaceDeletionStatusResponseUnmarshaller.Instance;

            return Invoke<GetNamespaceDeletionStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNamespaceDeletionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNamespaceDeletionStatus operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNamespaceDeletionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetNamespaceDeletionStatus">REST API Reference for GetNamespaceDeletionStatus Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginGetNamespaceDeletionStatus(GetNamespaceDeletionStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNamespaceDeletionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNamespaceDeletionStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNamespaceDeletionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNamespaceDeletionStatus.</param>
        /// 
        /// <returns>Returns a  GetNamespaceDeletionStatusResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetNamespaceDeletionStatus">REST API Reference for GetNamespaceDeletionStatus Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual GetNamespaceDeletionStatusResponse EndGetNamespaceDeletionStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNamespaceDeletionStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSystemInstance

        /// <summary>
        /// Gets a system instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSystemInstance service method.</param>
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
        public virtual GetSystemInstanceResponse GetSystemInstance(GetSystemInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSystemInstanceResponseUnmarshaller.Instance;

            return Invoke<GetSystemInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSystemInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSystemInstance operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSystemInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetSystemInstance">REST API Reference for GetSystemInstance Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginGetSystemInstance(GetSystemInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSystemInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSystemInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSystemInstance.</param>
        /// 
        /// <returns>Returns a  GetSystemInstanceResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetSystemInstance">REST API Reference for GetSystemInstance Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual GetSystemInstanceResponse EndGetSystemInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSystemInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSystemTemplate

        /// <summary>
        /// Gets a system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSystemTemplate service method.</param>
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
        public virtual GetSystemTemplateResponse GetSystemTemplate(GetSystemTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSystemTemplateResponseUnmarshaller.Instance;

            return Invoke<GetSystemTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSystemTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSystemTemplate operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSystemTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetSystemTemplate">REST API Reference for GetSystemTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginGetSystemTemplate(GetSystemTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSystemTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSystemTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSystemTemplate.</param>
        /// 
        /// <returns>Returns a  GetSystemTemplateResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetSystemTemplate">REST API Reference for GetSystemTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual GetSystemTemplateResponse EndGetSystemTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSystemTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSystemTemplateRevisions

        /// <summary>
        /// Gets revisions made to the specified system template. Only the previous 100 revisions
        /// are stored. If the system has been deprecated, this action will return the revisions
        /// that occurred before its deprecation. This action won't work with systems that have
        /// been deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSystemTemplateRevisions service method.</param>
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
        public virtual GetSystemTemplateRevisionsResponse GetSystemTemplateRevisions(GetSystemTemplateRevisionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSystemTemplateRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSystemTemplateRevisionsResponseUnmarshaller.Instance;

            return Invoke<GetSystemTemplateRevisionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSystemTemplateRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSystemTemplateRevisions operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSystemTemplateRevisions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetSystemTemplateRevisions">REST API Reference for GetSystemTemplateRevisions Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginGetSystemTemplateRevisions(GetSystemTemplateRevisionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSystemTemplateRevisionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSystemTemplateRevisionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSystemTemplateRevisions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSystemTemplateRevisions.</param>
        /// 
        /// <returns>Returns a  GetSystemTemplateRevisionsResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetSystemTemplateRevisions">REST API Reference for GetSystemTemplateRevisions Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual GetSystemTemplateRevisionsResponse EndGetSystemTemplateRevisions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSystemTemplateRevisionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUploadStatus

        /// <summary>
        /// Gets the status of the specified upload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUploadStatus service method.</param>
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
        public virtual GetUploadStatusResponse GetUploadStatus(GetUploadStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUploadStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUploadStatusResponseUnmarshaller.Instance;

            return Invoke<GetUploadStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUploadStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUploadStatus operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUploadStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetUploadStatus">REST API Reference for GetUploadStatus Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginGetUploadStatus(GetUploadStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetUploadStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUploadStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUploadStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUploadStatus.</param>
        /// 
        /// <returns>Returns a  GetUploadStatusResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetUploadStatus">REST API Reference for GetUploadStatus Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual GetUploadStatusResponse EndGetUploadStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUploadStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFlowExecutionMessages

        /// <summary>
        /// Returns a list of objects that contain information about events in a flow execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlowExecutionMessages service method.</param>
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
        public virtual ListFlowExecutionMessagesResponse ListFlowExecutionMessages(ListFlowExecutionMessagesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowExecutionMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowExecutionMessagesResponseUnmarshaller.Instance;

            return Invoke<ListFlowExecutionMessagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFlowExecutionMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFlowExecutionMessages operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFlowExecutionMessages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/ListFlowExecutionMessages">REST API Reference for ListFlowExecutionMessages Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginListFlowExecutionMessages(ListFlowExecutionMessagesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowExecutionMessagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowExecutionMessagesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFlowExecutionMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFlowExecutionMessages.</param>
        /// 
        /// <returns>Returns a  ListFlowExecutionMessagesResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/ListFlowExecutionMessages">REST API Reference for ListFlowExecutionMessages Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual ListFlowExecutionMessagesResponse EndListFlowExecutionMessages(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFlowExecutionMessagesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all tags on an AWS IoT Things Graph resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        [Obsolete("since: 2022-08-30")]
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
        /// <returns>Returns a  ListTagsForResourceResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchEntities

        /// <summary>
        /// Searches for entities of the specified type. You can search for entities in your namespace
        /// and the public namespace that you're tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchEntities service method.</param>
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
        public virtual SearchEntitiesResponse SearchEntities(SearchEntitiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchEntitiesResponseUnmarshaller.Instance;

            return Invoke<SearchEntitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchEntities operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchEntities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchEntities">REST API Reference for SearchEntities Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginSearchEntities(SearchEntitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchEntitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchEntities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchEntities.</param>
        /// 
        /// <returns>Returns a  SearchEntitiesResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchEntities">REST API Reference for SearchEntities Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual SearchEntitiesResponse EndSearchEntities(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchEntitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchFlowExecutions

        /// <summary>
        /// Searches for AWS IoT Things Graph workflow execution instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFlowExecutions service method.</param>
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
        public virtual SearchFlowExecutionsResponse SearchFlowExecutions(SearchFlowExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchFlowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFlowExecutionsResponseUnmarshaller.Instance;

            return Invoke<SearchFlowExecutionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchFlowExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchFlowExecutions operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchFlowExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchFlowExecutions">REST API Reference for SearchFlowExecutions Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginSearchFlowExecutions(SearchFlowExecutionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchFlowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFlowExecutionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchFlowExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchFlowExecutions.</param>
        /// 
        /// <returns>Returns a  SearchFlowExecutionsResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchFlowExecutions">REST API Reference for SearchFlowExecutions Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual SearchFlowExecutionsResponse EndSearchFlowExecutions(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchFlowExecutionsResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchFlowTemplates

        /// <summary>
        /// Searches for summary information about workflows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFlowTemplates service method.</param>
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
        public virtual SearchFlowTemplatesResponse SearchFlowTemplates(SearchFlowTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchFlowTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFlowTemplatesResponseUnmarshaller.Instance;

            return Invoke<SearchFlowTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchFlowTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchFlowTemplates operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchFlowTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchFlowTemplates">REST API Reference for SearchFlowTemplates Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginSearchFlowTemplates(SearchFlowTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchFlowTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFlowTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchFlowTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchFlowTemplates.</param>
        /// 
        /// <returns>Returns a  SearchFlowTemplatesResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchFlowTemplates">REST API Reference for SearchFlowTemplates Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual SearchFlowTemplatesResponse EndSearchFlowTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchFlowTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchSystemInstances

        /// <summary>
        /// Searches for system instances in the user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSystemInstances service method.</param>
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
        public virtual SearchSystemInstancesResponse SearchSystemInstances(SearchSystemInstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchSystemInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSystemInstancesResponseUnmarshaller.Instance;

            return Invoke<SearchSystemInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchSystemInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchSystemInstances operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchSystemInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchSystemInstances">REST API Reference for SearchSystemInstances Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginSearchSystemInstances(SearchSystemInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchSystemInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSystemInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchSystemInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchSystemInstances.</param>
        /// 
        /// <returns>Returns a  SearchSystemInstancesResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchSystemInstances">REST API Reference for SearchSystemInstances Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual SearchSystemInstancesResponse EndSearchSystemInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchSystemInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchSystemTemplates

        /// <summary>
        /// Searches for summary information about systems in the user's account. You can filter
        /// by the ID of a workflow to return only systems that use the specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSystemTemplates service method.</param>
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
        public virtual SearchSystemTemplatesResponse SearchSystemTemplates(SearchSystemTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchSystemTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSystemTemplatesResponseUnmarshaller.Instance;

            return Invoke<SearchSystemTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchSystemTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchSystemTemplates operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchSystemTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchSystemTemplates">REST API Reference for SearchSystemTemplates Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginSearchSystemTemplates(SearchSystemTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchSystemTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchSystemTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchSystemTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchSystemTemplates.</param>
        /// 
        /// <returns>Returns a  SearchSystemTemplatesResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchSystemTemplates">REST API Reference for SearchSystemTemplates Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual SearchSystemTemplatesResponse EndSearchSystemTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchSystemTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  SearchThings

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
        public virtual SearchThingsResponse SearchThings(SearchThingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchThingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchThingsResponseUnmarshaller.Instance;

            return Invoke<SearchThingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SearchThings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchThings operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchThings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchThings">REST API Reference for SearchThings Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginSearchThings(SearchThingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SearchThingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchThingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SearchThings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchThings.</param>
        /// 
        /// <returns>Returns a  SearchThingsResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchThings">REST API Reference for SearchThings Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual SearchThingsResponse EndSearchThings(IAsyncResult asyncResult)
        {
            return EndInvoke<SearchThingsResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Creates a tag for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/TagResource">REST API Reference for TagResource Operation</seealso>
        [Obsolete("since: 2022-08-30")]
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
        /// <returns>Returns a  TagResourceResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/TagResource">REST API Reference for TagResource Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UndeploySystemInstance

        /// <summary>
        /// Removes a system instance from its target (Cloud or Greengrass).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UndeploySystemInstance service method.</param>
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
        public virtual UndeploySystemInstanceResponse UndeploySystemInstance(UndeploySystemInstanceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UndeploySystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UndeploySystemInstanceResponseUnmarshaller.Instance;

            return Invoke<UndeploySystemInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UndeploySystemInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UndeploySystemInstance operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUndeploySystemInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UndeploySystemInstance">REST API Reference for UndeploySystemInstance Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginUndeploySystemInstance(UndeploySystemInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UndeploySystemInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UndeploySystemInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UndeploySystemInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUndeploySystemInstance.</param>
        /// 
        /// <returns>Returns a  UndeploySystemInstanceResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UndeploySystemInstance">REST API Reference for UndeploySystemInstance Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual UndeploySystemInstanceResponse EndUndeploySystemInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<UndeploySystemInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        [Obsolete("since: 2022-08-30")]
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
        /// <returns>Returns a  UntagResourceResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFlowTemplate

        /// <summary>
        /// Updates the specified workflow. All deployed systems and system instances that use
        /// the workflow will see the changes in the flow when it is redeployed. If you don't
        /// want this behavior, copy the workflow (creating a new workflow with a different ID),
        /// and update the copy. The workflow can contain only entities in the specified namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowTemplate service method.</param>
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
        public virtual UpdateFlowTemplateResponse UpdateFlowTemplate(UpdateFlowTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateFlowTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFlowTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowTemplate operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFlowTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UpdateFlowTemplate">REST API Reference for UpdateFlowTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginUpdateFlowTemplate(UpdateFlowTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFlowTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlowTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFlowTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFlowTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateFlowTemplateResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UpdateFlowTemplate">REST API Reference for UpdateFlowTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual UpdateFlowTemplateResponse EndUpdateFlowTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFlowTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSystemTemplate

        /// <summary>
        /// Updates the specified system. You don't need to run this action after updating a workflow.
        /// Any deployment that uses the system will see the changes in the system when it is
        /// redeployed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSystemTemplate service method.</param>
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
        public virtual UpdateSystemTemplateResponse UpdateSystemTemplate(UpdateSystemTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSystemTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateSystemTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSystemTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSystemTemplate operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSystemTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UpdateSystemTemplate">REST API Reference for UpdateSystemTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginUpdateSystemTemplate(UpdateSystemTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSystemTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSystemTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSystemTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSystemTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateSystemTemplateResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UpdateSystemTemplate">REST API Reference for UpdateSystemTemplate Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual UpdateSystemTemplateResponse EndUpdateSystemTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSystemTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  UploadEntityDefinitions

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
        public virtual UploadEntityDefinitionsResponse UploadEntityDefinitions(UploadEntityDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UploadEntityDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadEntityDefinitionsResponseUnmarshaller.Instance;

            return Invoke<UploadEntityDefinitionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UploadEntityDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadEntityDefinitions operation on AmazonIoTThingsGraphClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUploadEntityDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UploadEntityDefinitions">REST API Reference for UploadEntityDefinitions Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual IAsyncResult BeginUploadEntityDefinitions(UploadEntityDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UploadEntityDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadEntityDefinitionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UploadEntityDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadEntityDefinitions.</param>
        /// 
        /// <returns>Returns a  UploadEntityDefinitionsResult from IoTThingsGraph.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UploadEntityDefinitions">REST API Reference for UploadEntityDefinitions Operation</seealso>
        [Obsolete("since: 2022-08-30")]
        public virtual UploadEntityDefinitionsResponse EndUploadEntityDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<UploadEntityDefinitionsResponse>(asyncResult);
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
            var resolver = new AmazonIoTThingsGraphEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}