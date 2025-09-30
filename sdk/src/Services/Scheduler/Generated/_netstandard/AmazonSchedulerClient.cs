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
 * Do not modify this file. This file is generated from the scheduler-2021-06-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Scheduler.Model;
using Amazon.Scheduler.Model.Internal.MarshallTransformations;
using Amazon.Scheduler.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Scheduler
{
    /// <summary>
    /// <para>Implementation for accessing Scheduler</para>
    ///
    /// Amazon EventBridge Scheduler is a serverless scheduler that allows you to create,
    /// run, and manage tasks from one central, managed service. EventBridge Scheduler delivers
    /// your tasks reliably, with built-in mechanisms that adjust your schedules based on
    /// the availability of downstream targets. The following reference lists the available
    /// API actions, and data types for EventBridge Scheduler.
    /// </summary>
    public partial class AmazonSchedulerClient : AmazonServiceClient, IAmazonScheduler
    {
        private static IServiceMetadata serviceMetadata = new AmazonSchedulerMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSchedulerClient with the credentials loaded from the application's
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
        public AmazonSchedulerClient()
            : base(new AmazonSchedulerConfig()) { }

        /// <summary>
        /// Constructs AmazonSchedulerClient with the credentials loaded from the application's
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
        public AmazonSchedulerClient(RegionEndpoint region)
            : base(new AmazonSchedulerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSchedulerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSchedulerClient Configuration Object</param>
        public AmazonSchedulerClient(AmazonSchedulerConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonSchedulerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSchedulerClient(AWSCredentials credentials)
            : this(credentials, new AmazonSchedulerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSchedulerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSchedulerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSchedulerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSchedulerClient with AWS Credentials and an
        /// AmazonSchedulerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSchedulerClient Configuration Object</param>
        public AmazonSchedulerClient(AWSCredentials credentials, AmazonSchedulerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSchedulerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSchedulerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSchedulerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSchedulerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSchedulerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSchedulerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSchedulerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSchedulerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSchedulerClient Configuration Object</param>
        public AmazonSchedulerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSchedulerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSchedulerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSchedulerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSchedulerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSchedulerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSchedulerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSchedulerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSchedulerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSchedulerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSchedulerClient Configuration Object</param>
        public AmazonSchedulerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSchedulerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ISchedulerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISchedulerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SchedulerPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSchedulerEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSchedulerAuthSchemeHandler());
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


        #region  CreateSchedule

        internal virtual CreateScheduleResponse CreateSchedule(CreateScheduleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScheduleResponseUnmarshaller.Instance;

            return Invoke<CreateScheduleResponse>(request, options);
        }



        /// <summary>
        /// Creates the specified schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSchedule service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/CreateSchedule">REST API Reference for CreateSchedule Operation</seealso>
        public virtual Task<CreateScheduleResponse> CreateScheduleAsync(CreateScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateScheduleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateScheduleGroup

        internal virtual CreateScheduleGroupResponse CreateScheduleGroup(CreateScheduleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateScheduleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScheduleGroupResponseUnmarshaller.Instance;

            return Invoke<CreateScheduleGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates the specified schedule group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateScheduleGroup service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/CreateScheduleGroup">REST API Reference for CreateScheduleGroup Operation</seealso>
        public virtual Task<CreateScheduleGroupResponse> CreateScheduleGroupAsync(CreateScheduleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateScheduleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScheduleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateScheduleGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSchedule

        internal virtual DeleteScheduleResponse DeleteSchedule(DeleteScheduleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduleResponseUnmarshaller.Instance;

            return Invoke<DeleteScheduleResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSchedule service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/DeleteSchedule">REST API Reference for DeleteSchedule Operation</seealso>
        public virtual Task<DeleteScheduleResponse> DeleteScheduleAsync(DeleteScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScheduleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteScheduleGroup

        internal virtual DeleteScheduleGroupResponse DeleteScheduleGroup(DeleteScheduleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteScheduleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduleGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteScheduleGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified schedule group. Deleting a schedule group results in EventBridge
        /// Scheduler deleting all schedules associated with the group. When you delete a group,
        /// it remains in a <c>DELETING</c> state until all of its associated schedules are deleted.
        /// Schedules associated with the group that are set to run while the schedule group is
        /// in the process of being deleted might continue to invoke their targets until the schedule
        /// group and its associated schedules are deleted.
        /// 
        ///  <note> 
        /// <para>
        ///  This operation is eventually consistent. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteScheduleGroup service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/DeleteScheduleGroup">REST API Reference for DeleteScheduleGroup Operation</seealso>
        public virtual Task<DeleteScheduleGroupResponse> DeleteScheduleGroupAsync(DeleteScheduleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteScheduleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScheduleGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSchedule

        internal virtual GetScheduleResponse GetSchedule(GetScheduleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetScheduleResponseUnmarshaller.Instance;

            return Invoke<GetScheduleResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the specified schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSchedule service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/GetSchedule">REST API Reference for GetSchedule Operation</seealso>
        public virtual Task<GetScheduleResponse> GetScheduleAsync(GetScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<GetScheduleResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetScheduleGroup

        internal virtual GetScheduleGroupResponse GetScheduleGroup(GetScheduleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetScheduleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetScheduleGroupResponseUnmarshaller.Instance;

            return Invoke<GetScheduleGroupResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the specified schedule group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScheduleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetScheduleGroup service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/GetScheduleGroup">REST API Reference for GetScheduleGroup Operation</seealso>
        public virtual Task<GetScheduleGroupResponse> GetScheduleGroupAsync(GetScheduleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetScheduleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetScheduleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetScheduleGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListScheduleGroups

        internal virtual ListScheduleGroupsResponse ListScheduleGroups(ListScheduleGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListScheduleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScheduleGroupsResponseUnmarshaller.Instance;

            return Invoke<ListScheduleGroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of your schedule groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScheduleGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListScheduleGroups service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/ListScheduleGroups">REST API Reference for ListScheduleGroups Operation</seealso>
        public virtual Task<ListScheduleGroupsResponse> ListScheduleGroupsAsync(ListScheduleGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListScheduleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScheduleGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListScheduleGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSchedules

        internal virtual ListSchedulesResponse ListSchedules(ListSchedulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchedulesResponseUnmarshaller.Instance;

            return Invoke<ListSchedulesResponse>(request, options);
        }



        /// <summary>
        /// Returns a paginated list of your EventBridge Scheduler schedules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchedules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSchedules service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/ListSchedules">REST API Reference for ListSchedules Operation</seealso>
        public virtual Task<ListSchedulesResponse> ListSchedulesAsync(ListSchedulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSchedulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchedulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSchedulesResponse>(request, options, cancellationToken);
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
        /// Lists the tags associated with the Scheduler resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
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
        /// Assigns one or more tags (key-value pairs) to the specified EventBridge Scheduler
        /// resource. You can only assign tags to schedule groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes one or more tags from the specified EventBridge Scheduler schedule group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSchedule

        internal virtual UpdateScheduleResponse UpdateSchedule(UpdateScheduleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScheduleResponseUnmarshaller.Instance;

            return Invoke<UpdateScheduleResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified schedule. When you call <c>UpdateSchedule</c>, EventBridge
        /// Scheduler uses all values, including empty values, specified in the request and overrides
        /// the existing schedule. This is by design. This means that if you do not set an optional
        /// field in your request, that field will be set to its system-default value after the
        /// update. 
        /// 
        ///  
        /// <para>
        ///  Before calling this operation, we recommend that you call the <c>GetSchedule</c>
        /// API operation and make a note of all optional parameters for your <c>UpdateSchedule</c>
        /// call. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSchedule service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/UpdateSchedule">REST API Reference for UpdateSchedule Operation</seealso>
        public virtual Task<UpdateScheduleResponse> UpdateScheduleAsync(UpdateScheduleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateScheduleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScheduleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateScheduleResponse>(request, options, cancellationToken);
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