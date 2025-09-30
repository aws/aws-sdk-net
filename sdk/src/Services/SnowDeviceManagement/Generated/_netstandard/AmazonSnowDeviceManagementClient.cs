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
 * Do not modify this file. This file is generated from the snow-device-management-2021-08-04.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SnowDeviceManagement.Model;
using Amazon.SnowDeviceManagement.Model.Internal.MarshallTransformations;
using Amazon.SnowDeviceManagement.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.SnowDeviceManagement
{
    /// <summary>
    /// <para>Implementation for accessing SnowDeviceManagement</para>
    ///
    /// Amazon Web Services Snow Device Management documentation.
    /// </summary>
    public partial class AmazonSnowDeviceManagementClient : AmazonServiceClient, IAmazonSnowDeviceManagement
    {
        private static IServiceMetadata serviceMetadata = new AmazonSnowDeviceManagementMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSnowDeviceManagementClient with the credentials loaded from the application's
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
        public AmazonSnowDeviceManagementClient()
            : base(new AmazonSnowDeviceManagementConfig()) { }

        /// <summary>
        /// Constructs AmazonSnowDeviceManagementClient with the credentials loaded from the application's
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
        public AmazonSnowDeviceManagementClient(RegionEndpoint region)
            : base(new AmazonSnowDeviceManagementConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSnowDeviceManagementClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSnowDeviceManagementClient Configuration Object</param>
        public AmazonSnowDeviceManagementClient(AmazonSnowDeviceManagementConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonSnowDeviceManagementClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSnowDeviceManagementClient(AWSCredentials credentials)
            : this(credentials, new AmazonSnowDeviceManagementConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSnowDeviceManagementClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSnowDeviceManagementClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSnowDeviceManagementConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSnowDeviceManagementClient with AWS Credentials and an
        /// AmazonSnowDeviceManagementClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSnowDeviceManagementClient Configuration Object</param>
        public AmazonSnowDeviceManagementClient(AWSCredentials credentials, AmazonSnowDeviceManagementConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSnowDeviceManagementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSnowDeviceManagementClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSnowDeviceManagementConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSnowDeviceManagementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSnowDeviceManagementClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSnowDeviceManagementConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSnowDeviceManagementClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSnowDeviceManagementClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSnowDeviceManagementClient Configuration Object</param>
        public AmazonSnowDeviceManagementClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSnowDeviceManagementConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSnowDeviceManagementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSnowDeviceManagementClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSnowDeviceManagementConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSnowDeviceManagementClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSnowDeviceManagementClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSnowDeviceManagementConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSnowDeviceManagementClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSnowDeviceManagementClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSnowDeviceManagementClient Configuration Object</param>
        public AmazonSnowDeviceManagementClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSnowDeviceManagementConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ISnowDeviceManagementPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISnowDeviceManagementPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SnowDeviceManagementPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSnowDeviceManagementEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSnowDeviceManagementAuthSchemeHandler());
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


        #region  CancelTask

        internal virtual CancelTaskResponse CancelTask(CancelTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTaskResponseUnmarshaller.Instance;

            return Invoke<CancelTaskResponse>(request, options);
        }



        /// <summary>
        /// Sends a cancel request for a specified task. You can cancel a task only if it's still
        /// in a <c>QUEUED</c> state. Tasks that are already running can't be cancelled.
        /// 
        ///  <note> 
        /// <para>
        /// A task might still run if it's processed from the queue before the <c>CancelTask</c>
        /// operation changes the task's state.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelTask service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/CancelTask">REST API Reference for CancelTask Operation</seealso>
        public virtual Task<CancelTaskResponse> CancelTaskAsync(CancelTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTask

        internal virtual CreateTaskResponse CreateTask(CreateTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTaskResponseUnmarshaller.Instance;

            return Invoke<CreateTaskResponse>(request, options);
        }



        /// <summary>
        /// Instructs one or more devices to start a task, such as unlocking or rebooting.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTask service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/CreateTask">REST API Reference for CreateTask Operation</seealso>
        public virtual Task<CreateTaskResponse> CreateTaskAsync(CreateTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDevice

        internal virtual DescribeDeviceResponse DescribeDevice(DescribeDeviceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceResponseUnmarshaller.Instance;

            return Invoke<DescribeDeviceResponse>(request, options);
        }



        /// <summary>
        /// Checks device-specific information, such as the device type, software version, IP
        /// addresses, and lock status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDevice service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        public virtual Task<DescribeDeviceResponse> DescribeDeviceAsync(DescribeDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDeviceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeDeviceEc2Instances

        internal virtual DescribeDeviceEc2InstancesResponse DescribeDeviceEc2Instances(DescribeDeviceEc2InstancesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDeviceEc2InstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceEc2InstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeDeviceEc2InstancesResponse>(request, options);
        }



        /// <summary>
        /// Checks the current state of the Amazon EC2 instances. The output is similar to <c>describeDevice</c>,
        /// but the results are sourced from the device cache in the Amazon Web Services Cloud
        /// and include a subset of the available fields.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeviceEc2Instances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDeviceEc2Instances service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/DescribeDeviceEc2Instances">REST API Reference for DescribeDeviceEc2Instances Operation</seealso>
        public virtual Task<DescribeDeviceEc2InstancesResponse> DescribeDeviceEc2InstancesAsync(DescribeDeviceEc2InstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeDeviceEc2InstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceEc2InstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDeviceEc2InstancesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeExecution

        internal virtual DescribeExecutionResponse DescribeExecution(DescribeExecutionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribeExecutionResponse>(request, options);
        }



        /// <summary>
        /// Checks the status of a remote task running on one or more target devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExecution service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        public virtual Task<DescribeExecutionResponse> DescribeExecutionAsync(DescribeExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExecutionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTask

        internal virtual DescribeTaskResponse DescribeTask(DescribeTaskRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskResponseUnmarshaller.Instance;

            return Invoke<DescribeTaskResponse>(request, options);
        }



        /// <summary>
        /// Checks the metadata for a given task on a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTask service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/DescribeTask">REST API Reference for DescribeTask Operation</seealso>
        public virtual Task<DescribeTaskResponse> DescribeTaskAsync(DescribeTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTaskResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDeviceResources

        internal virtual ListDeviceResourcesResponse ListDeviceResources(ListDeviceResourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeviceResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceResourcesResponseUnmarshaller.Instance;

            return Invoke<ListDeviceResourcesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the Amazon Web Services resources available for a device. Currently,
        /// Amazon EC2 instances are the only supported resource type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeviceResources service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/ListDeviceResources">REST API Reference for ListDeviceResources Operation</seealso>
        public virtual Task<ListDeviceResourcesResponse> ListDeviceResourcesAsync(ListDeviceResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDeviceResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeviceResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeviceResourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListDevices

        internal virtual ListDevicesResponse ListDevices(ListDevicesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return Invoke<ListDevicesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all devices on your Amazon Web Services account that have Amazon
        /// Web Services Snow Device Management enabled in the Amazon Web Services Region where
        /// the command is run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDevices service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/ListDevices">REST API Reference for ListDevices Operation</seealso>
        public virtual Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDevicesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListExecutions

        internal virtual ListExecutionsResponse ListExecutions(ListExecutionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListExecutionsResponse>(request, options);
        }



        /// <summary>
        /// Returns the status of tasks for one or more target devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExecutions service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        public virtual Task<ListExecutionsResponse> ListExecutionsAsync(ListExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListExecutionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of tags for a managed device or task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTasks

        internal virtual ListTasksResponse ListTasks(ListTasksRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTasksResponseUnmarshaller.Instance;

            return Invoke<ListTasksResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of tasks that can be filtered by state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTasks service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/ListTasks">REST API Reference for ListTasks Operation</seealso>
        public virtual Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListTasksResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds or replaces tags on a device or task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes a tag from a device or task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/UntagResource">REST API Reference for UntagResource Operation</seealso>
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