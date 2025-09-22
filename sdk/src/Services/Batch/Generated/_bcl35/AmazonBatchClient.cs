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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Batch.Model;
using Amazon.Batch.Model.Internal.MarshallTransformations;
using Amazon.Batch.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.Batch
{
    /// <summary>
    /// <para>Implementation for accessing Batch</para>
    ///
    /// Batch 
    /// <para>
    /// Using Batch, you can run batch computing workloads on the Amazon Web Services Cloud.
    /// Batch computing is a common means for developers, scientists, and engineers to access
    /// large amounts of compute resources. Batch uses the advantages of the batch computing
    /// to remove the undifferentiated heavy lifting of configuring and managing required
    /// infrastructure. At the same time, it also adopts a familiar batch computing software
    /// approach. You can use Batch to efficiently provision resources, and work toward eliminating
    /// capacity constraints, reducing your overall compute costs, and delivering results
    /// more quickly.
    /// </para>
    ///  
    /// <para>
    /// As a fully managed service, Batch can run batch computing workloads of any scale.
    /// Batch automatically provisions compute resources and optimizes workload distribution
    /// based on the quantity and scale of your specific workloads. With Batch, there's no
    /// need to install or manage batch computing software. This means that you can focus
    /// on analyzing results and solving your specific problems instead.
    /// </para>
    /// </summary>
    public partial class AmazonBatchClient : AmazonServiceClient, IAmazonBatch
    {
        private static IServiceMetadata serviceMetadata = new AmazonBatchMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IBatchPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBatchPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BatchPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonBatchClient with the credentials loaded from the application's
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
        public AmazonBatchClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBatchConfig()) { }

        /// <summary>
        /// Constructs AmazonBatchClient with the credentials loaded from the application's
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
        public AmazonBatchClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBatchConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBatchClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBatchClient Configuration Object</param>
        public AmazonBatchClient(AmazonBatchConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonBatchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBatchClient(AWSCredentials credentials)
            : this(credentials, new AmazonBatchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBatchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBatchClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBatchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBatchClient with AWS Credentials and an
        /// AmazonBatchClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBatchClient Configuration Object</param>
        public AmazonBatchClient(AWSCredentials credentials, AmazonBatchConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBatchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBatchClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBatchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBatchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBatchClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBatchConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBatchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBatchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBatchClient Configuration Object</param>
        public AmazonBatchClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBatchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBatchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBatchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBatchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBatchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBatchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBatchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBatchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBatchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBatchClient Configuration Object</param>
        public AmazonBatchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBatchConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBatchEndpointResolver());
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


        #region  CancelJob

        /// <summary>
        /// Cancels a job in an Batch job queue. Jobs that are in a <c>SUBMITTED</c>, <c>PENDING</c>,
        /// or <c>RUNNABLE</c> state are cancelled and the job status is updated to <c>FAILED</c>.
        /// 
        ///  <note> 
        /// <para>
        /// A <c>PENDING</c> job is canceled after all dependency jobs are completed. Therefore,
        /// it may take longer than expected to cancel a job in <c>PENDING</c> status.
        /// </para>
        ///  
        /// <para>
        /// When you try to cancel an array parent job in <c>PENDING</c>, Batch attempts to cancel
        /// all child jobs. The array parent job is canceled when all child jobs are completed.
        /// </para>
        ///  </note> 
        /// <para>
        /// Jobs that progressed to the <c>STARTING</c> or <c>RUNNING</c> state aren't canceled.
        /// However, the API operation still succeeds, even if no job is canceled. These jobs
        /// must be terminated with the <a>TerminateJob</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CancelJob">REST API Reference for CancelJob Operation</seealso>
        public virtual CancelJobResponse CancelJob(CancelJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;

            return Invoke<CancelJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJob operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CancelJob">REST API Reference for CancelJob Operation</seealso>
        public virtual IAsyncResult BeginCancelJob(CancelJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelJob.</param>
        /// 
        /// <returns>Returns a  CancelJobResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CancelJob">REST API Reference for CancelJob Operation</seealso>
        public virtual CancelJobResponse EndCancelJob(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelJobResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateComputeEnvironment

        /// <summary>
        /// Creates an Batch compute environment. You can create <c>MANAGED</c> or <c>UNMANAGED</c>
        /// compute environments. <c>MANAGED</c> compute environments can use Amazon EC2 or Fargate
        /// resources. <c>UNMANAGED</c> compute environments can only use EC2 resources.
        /// 
        ///  
        /// <para>
        /// In a managed compute environment, Batch manages the capacity and instance types of
        /// the compute resources within the environment. This is based on the compute resource
        /// specification that you define or the <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">launch
        /// template</a> that you specify when you create the compute environment. Either, you
        /// can choose to use EC2 On-Demand Instances and EC2 Spot Instances. Or, you can use
        /// Fargate and Fargate Spot capacity in your managed compute environment. You can optionally
        /// set a maximum price so that Spot Instances only launch when the Spot Instance price
        /// is less than a specified percentage of the On-Demand price.
        /// </para>
        ///  
        /// <para>
        /// In an unmanaged compute environment, you can manage your own EC2 compute resources
        /// and have flexibility with how you configure your compute resources. For example, you
        /// can use custom AMIs. However, you must verify that each of your AMIs meet the Amazon
        /// ECS container instance AMI specification. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/container_instance_AMIs.html">container
        /// instance AMIs</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// After you created your unmanaged compute environment, you can use the <a>DescribeComputeEnvironments</a>
        /// operation to find the Amazon ECS cluster that's associated with it. Then, launch your
        /// container instances into that Amazon ECS cluster. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_container_instance.html">Launching
        /// an Amazon ECS container instance</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Batch doesn't automatically upgrade the AMIs in a compute environment after it's created.
        /// For more information on how to update a compute environment's AMI, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/updating-compute-environments.html">Updating
        /// compute environments</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComputeEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateComputeEnvironment service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateComputeEnvironment">REST API Reference for CreateComputeEnvironment Operation</seealso>
        public virtual CreateComputeEnvironmentResponse CreateComputeEnvironment(CreateComputeEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComputeEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComputeEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateComputeEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateComputeEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateComputeEnvironment operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateComputeEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateComputeEnvironment">REST API Reference for CreateComputeEnvironment Operation</seealso>
        public virtual IAsyncResult BeginCreateComputeEnvironment(CreateComputeEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComputeEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComputeEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateComputeEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateComputeEnvironment.</param>
        /// 
        /// <returns>Returns a  CreateComputeEnvironmentResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateComputeEnvironment">REST API Reference for CreateComputeEnvironment Operation</seealso>
        public virtual CreateComputeEnvironmentResponse EndCreateComputeEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateComputeEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConsumableResource

        /// <summary>
        /// Creates an Batch consumable resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConsumableResource service method.</param>
        /// 
        /// <returns>The response from the CreateConsumableResource service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateConsumableResource">REST API Reference for CreateConsumableResource Operation</seealso>
        public virtual CreateConsumableResourceResponse CreateConsumableResource(CreateConsumableResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConsumableResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConsumableResourceResponseUnmarshaller.Instance;

            return Invoke<CreateConsumableResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConsumableResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConsumableResource operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConsumableResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateConsumableResource">REST API Reference for CreateConsumableResource Operation</seealso>
        public virtual IAsyncResult BeginCreateConsumableResource(CreateConsumableResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConsumableResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConsumableResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConsumableResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConsumableResource.</param>
        /// 
        /// <returns>Returns a  CreateConsumableResourceResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateConsumableResource">REST API Reference for CreateConsumableResource Operation</seealso>
        public virtual CreateConsumableResourceResponse EndCreateConsumableResource(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConsumableResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateJobQueue

        /// <summary>
        /// Creates an Batch job queue. When you create a job queue, you associate one or more
        /// compute environments to the queue and assign an order of preference for the compute
        /// environments.
        /// 
        ///  
        /// <para>
        /// You also set a priority to the job queue that determines the order that the Batch
        /// scheduler places jobs onto its associated compute environments. For example, if a
        /// compute environment is associated with more than one job queue, the job queue with
        /// a higher priority is given preference for scheduling jobs to that compute environment.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJobQueue service method.</param>
        /// 
        /// <returns>The response from the CreateJobQueue service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateJobQueue">REST API Reference for CreateJobQueue Operation</seealso>
        public virtual CreateJobQueueResponse CreateJobQueue(CreateJobQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobQueueResponseUnmarshaller.Instance;

            return Invoke<CreateJobQueueResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJobQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJobQueue operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJobQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateJobQueue">REST API Reference for CreateJobQueue Operation</seealso>
        public virtual IAsyncResult BeginCreateJobQueue(CreateJobQueueRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobQueueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJobQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJobQueue.</param>
        /// 
        /// <returns>Returns a  CreateJobQueueResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateJobQueue">REST API Reference for CreateJobQueue Operation</seealso>
        public virtual CreateJobQueueResponse EndCreateJobQueue(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateJobQueueResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSchedulingPolicy

        /// <summary>
        /// Creates an Batch scheduling policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchedulingPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateSchedulingPolicy service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateSchedulingPolicy">REST API Reference for CreateSchedulingPolicy Operation</seealso>
        public virtual CreateSchedulingPolicyResponse CreateSchedulingPolicy(CreateSchedulingPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSchedulingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchedulingPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateSchedulingPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSchedulingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSchedulingPolicy operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSchedulingPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateSchedulingPolicy">REST API Reference for CreateSchedulingPolicy Operation</seealso>
        public virtual IAsyncResult BeginCreateSchedulingPolicy(CreateSchedulingPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSchedulingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSchedulingPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSchedulingPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSchedulingPolicy.</param>
        /// 
        /// <returns>Returns a  CreateSchedulingPolicyResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateSchedulingPolicy">REST API Reference for CreateSchedulingPolicy Operation</seealso>
        public virtual CreateSchedulingPolicyResponse EndCreateSchedulingPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSchedulingPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateServiceEnvironment

        /// <summary>
        /// Creates a service environment for running service jobs. Service environments define
        /// capacity limits for specific service types such as SageMaker Training jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateServiceEnvironment service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateServiceEnvironment">REST API Reference for CreateServiceEnvironment Operation</seealso>
        public virtual CreateServiceEnvironmentResponse CreateServiceEnvironment(CreateServiceEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateServiceEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateServiceEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceEnvironment operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateServiceEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateServiceEnvironment">REST API Reference for CreateServiceEnvironment Operation</seealso>
        public virtual IAsyncResult BeginCreateServiceEnvironment(CreateServiceEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateServiceEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateServiceEnvironment.</param>
        /// 
        /// <returns>Returns a  CreateServiceEnvironmentResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateServiceEnvironment">REST API Reference for CreateServiceEnvironment Operation</seealso>
        public virtual CreateServiceEnvironmentResponse EndCreateServiceEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateServiceEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteComputeEnvironment

        /// <summary>
        /// Deletes an Batch compute environment.
        /// 
        ///  
        /// <para>
        /// Before you can delete a compute environment, you must set its state to <c>DISABLED</c>
        /// with the <a>UpdateComputeEnvironment</a> API operation and disassociate it from any
        /// job queues with the <a>UpdateJobQueue</a> API operation. Compute environments that
        /// use Fargate resources must terminate all active jobs on that compute environment before
        /// deleting the compute environment. If this isn't done, the compute environment enters
        /// an invalid state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComputeEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteComputeEnvironment service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteComputeEnvironment">REST API Reference for DeleteComputeEnvironment Operation</seealso>
        public virtual DeleteComputeEnvironmentResponse DeleteComputeEnvironment(DeleteComputeEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComputeEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComputeEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteComputeEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteComputeEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteComputeEnvironment operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteComputeEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteComputeEnvironment">REST API Reference for DeleteComputeEnvironment Operation</seealso>
        public virtual IAsyncResult BeginDeleteComputeEnvironment(DeleteComputeEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComputeEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComputeEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteComputeEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteComputeEnvironment.</param>
        /// 
        /// <returns>Returns a  DeleteComputeEnvironmentResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteComputeEnvironment">REST API Reference for DeleteComputeEnvironment Operation</seealso>
        public virtual DeleteComputeEnvironmentResponse EndDeleteComputeEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteComputeEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConsumableResource

        /// <summary>
        /// Deletes the specified consumable resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConsumableResource service method.</param>
        /// 
        /// <returns>The response from the DeleteConsumableResource service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteConsumableResource">REST API Reference for DeleteConsumableResource Operation</seealso>
        public virtual DeleteConsumableResourceResponse DeleteConsumableResource(DeleteConsumableResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConsumableResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConsumableResourceResponseUnmarshaller.Instance;

            return Invoke<DeleteConsumableResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConsumableResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConsumableResource operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConsumableResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteConsumableResource">REST API Reference for DeleteConsumableResource Operation</seealso>
        public virtual IAsyncResult BeginDeleteConsumableResource(DeleteConsumableResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConsumableResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConsumableResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConsumableResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConsumableResource.</param>
        /// 
        /// <returns>Returns a  DeleteConsumableResourceResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteConsumableResource">REST API Reference for DeleteConsumableResource Operation</seealso>
        public virtual DeleteConsumableResourceResponse EndDeleteConsumableResource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConsumableResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteJobQueue

        /// <summary>
        /// Deletes the specified job queue. You must first disable submissions for a queue with
        /// the <a>UpdateJobQueue</a> operation. All jobs in the queue are eventually terminated
        /// when you delete a job queue. The jobs are terminated at a rate of about 16 jobs each
        /// second.
        /// 
        ///  
        /// <para>
        /// It's not necessary to disassociate compute environments from a queue before submitting
        /// a <c>DeleteJobQueue</c> request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobQueue service method.</param>
        /// 
        /// <returns>The response from the DeleteJobQueue service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteJobQueue">REST API Reference for DeleteJobQueue Operation</seealso>
        public virtual DeleteJobQueueResponse DeleteJobQueue(DeleteJobQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobQueueResponseUnmarshaller.Instance;

            return Invoke<DeleteJobQueueResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJobQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobQueue operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteJobQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteJobQueue">REST API Reference for DeleteJobQueue Operation</seealso>
        public virtual IAsyncResult BeginDeleteJobQueue(DeleteJobQueueRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobQueueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteJobQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteJobQueue.</param>
        /// 
        /// <returns>Returns a  DeleteJobQueueResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteJobQueue">REST API Reference for DeleteJobQueue Operation</seealso>
        public virtual DeleteJobQueueResponse EndDeleteJobQueue(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteJobQueueResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSchedulingPolicy

        /// <summary>
        /// Deletes the specified scheduling policy.
        /// 
        ///  
        /// <para>
        /// You can't delete a scheduling policy that's used in any job queues.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchedulingPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteSchedulingPolicy service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteSchedulingPolicy">REST API Reference for DeleteSchedulingPolicy Operation</seealso>
        public virtual DeleteSchedulingPolicyResponse DeleteSchedulingPolicy(DeleteSchedulingPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSchedulingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchedulingPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteSchedulingPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSchedulingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchedulingPolicy operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSchedulingPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteSchedulingPolicy">REST API Reference for DeleteSchedulingPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteSchedulingPolicy(DeleteSchedulingPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSchedulingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSchedulingPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSchedulingPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSchedulingPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteSchedulingPolicyResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteSchedulingPolicy">REST API Reference for DeleteSchedulingPolicy Operation</seealso>
        public virtual DeleteSchedulingPolicyResponse EndDeleteSchedulingPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSchedulingPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteServiceEnvironment

        /// <summary>
        /// Deletes a Service environment. Before you can delete a service environment, you must
        /// first set its state to <c>DISABLED</c> with the <c>UpdateServiceEnvironment</c> API
        /// operation and disassociate it from any job queues with the <c>UpdateJobQueue</c> API
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceEnvironment service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteServiceEnvironment">REST API Reference for DeleteServiceEnvironment Operation</seealso>
        public virtual DeleteServiceEnvironmentResponse DeleteServiceEnvironment(DeleteServiceEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceEnvironment operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServiceEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteServiceEnvironment">REST API Reference for DeleteServiceEnvironment Operation</seealso>
        public virtual IAsyncResult BeginDeleteServiceEnvironment(DeleteServiceEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServiceEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServiceEnvironment.</param>
        /// 
        /// <returns>Returns a  DeleteServiceEnvironmentResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteServiceEnvironment">REST API Reference for DeleteServiceEnvironment Operation</seealso>
        public virtual DeleteServiceEnvironmentResponse EndDeleteServiceEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteServiceEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterJobDefinition

        /// <summary>
        /// Deregisters an Batch job definition. Job definitions are permanently deleted after
        /// 180 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterJobDefinition service method.</param>
        /// 
        /// <returns>The response from the DeregisterJobDefinition service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeregisterJobDefinition">REST API Reference for DeregisterJobDefinition Operation</seealso>
        public virtual DeregisterJobDefinitionResponse DeregisterJobDefinition(DeregisterJobDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterJobDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeregisterJobDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterJobDefinition operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterJobDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeregisterJobDefinition">REST API Reference for DeregisterJobDefinition Operation</seealso>
        public virtual IAsyncResult BeginDeregisterJobDefinition(DeregisterJobDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterJobDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterJobDefinition.</param>
        /// 
        /// <returns>Returns a  DeregisterJobDefinitionResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeregisterJobDefinition">REST API Reference for DeregisterJobDefinition Operation</seealso>
        public virtual DeregisterJobDefinitionResponse EndDeregisterJobDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterJobDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeComputeEnvironments

        /// <summary>
        /// Describes one or more of your compute environments.
        /// 
        ///  
        /// <para>
        /// If you're using an unmanaged compute environment, you can use the <c>DescribeComputeEnvironment</c>
        /// operation to determine the <c>ecsClusterArn</c> that you launch your Amazon ECS container
        /// instances into.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComputeEnvironments service method.</param>
        /// 
        /// <returns>The response from the DescribeComputeEnvironments service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeComputeEnvironments">REST API Reference for DescribeComputeEnvironments Operation</seealso>
        public virtual DescribeComputeEnvironmentsResponse DescribeComputeEnvironments(DescribeComputeEnvironmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComputeEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComputeEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeComputeEnvironmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComputeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComputeEnvironments operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeComputeEnvironments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeComputeEnvironments">REST API Reference for DescribeComputeEnvironments Operation</seealso>
        public virtual IAsyncResult BeginDescribeComputeEnvironments(DescribeComputeEnvironmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComputeEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComputeEnvironmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeComputeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeComputeEnvironments.</param>
        /// 
        /// <returns>Returns a  DescribeComputeEnvironmentsResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeComputeEnvironments">REST API Reference for DescribeComputeEnvironments Operation</seealso>
        public virtual DescribeComputeEnvironmentsResponse EndDescribeComputeEnvironments(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeComputeEnvironmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConsumableResource

        /// <summary>
        /// Returns a description of the specified consumable resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConsumableResource service method.</param>
        /// 
        /// <returns>The response from the DescribeConsumableResource service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeConsumableResource">REST API Reference for DescribeConsumableResource Operation</seealso>
        public virtual DescribeConsumableResourceResponse DescribeConsumableResource(DescribeConsumableResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConsumableResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConsumableResourceResponseUnmarshaller.Instance;

            return Invoke<DescribeConsumableResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConsumableResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConsumableResource operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConsumableResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeConsumableResource">REST API Reference for DescribeConsumableResource Operation</seealso>
        public virtual IAsyncResult BeginDescribeConsumableResource(DescribeConsumableResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConsumableResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConsumableResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConsumableResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConsumableResource.</param>
        /// 
        /// <returns>Returns a  DescribeConsumableResourceResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeConsumableResource">REST API Reference for DescribeConsumableResource Operation</seealso>
        public virtual DescribeConsumableResourceResponse EndDescribeConsumableResource(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConsumableResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeJobDefinitions

        /// <summary>
        /// Describes a list of job definitions. You can specify a <c>status</c> (such as <c>ACTIVE</c>)
        /// to only return job definitions that match that status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobDefinitions service method.</param>
        /// 
        /// <returns>The response from the DescribeJobDefinitions service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeJobDefinitions">REST API Reference for DescribeJobDefinitions Operation</seealso>
        public virtual DescribeJobDefinitionsResponse DescribeJobDefinitions(DescribeJobDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobDefinitionsResponseUnmarshaller.Instance;

            return Invoke<DescribeJobDefinitionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobDefinitions operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJobDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeJobDefinitions">REST API Reference for DescribeJobDefinitions Operation</seealso>
        public virtual IAsyncResult BeginDescribeJobDefinitions(DescribeJobDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobDefinitionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJobDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobDefinitions.</param>
        /// 
        /// <returns>Returns a  DescribeJobDefinitionsResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeJobDefinitions">REST API Reference for DescribeJobDefinitions Operation</seealso>
        public virtual DescribeJobDefinitionsResponse EndDescribeJobDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeJobDefinitionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeJobQueues

        /// <summary>
        /// Describes one or more of your job queues.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobQueues service method.</param>
        /// 
        /// <returns>The response from the DescribeJobQueues service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeJobQueues">REST API Reference for DescribeJobQueues Operation</seealso>
        public virtual DescribeJobQueuesResponse DescribeJobQueues(DescribeJobQueuesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobQueuesResponseUnmarshaller.Instance;

            return Invoke<DescribeJobQueuesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobQueues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobQueues operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJobQueues
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeJobQueues">REST API Reference for DescribeJobQueues Operation</seealso>
        public virtual IAsyncResult BeginDescribeJobQueues(DescribeJobQueuesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobQueuesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJobQueues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobQueues.</param>
        /// 
        /// <returns>Returns a  DescribeJobQueuesResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeJobQueues">REST API Reference for DescribeJobQueues Operation</seealso>
        public virtual DescribeJobQueuesResponse EndDescribeJobQueues(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeJobQueuesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeJobs

        /// <summary>
        /// Describes a list of Batch jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobs service method.</param>
        /// 
        /// <returns>The response from the DescribeJobs service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeJobs">REST API Reference for DescribeJobs Operation</seealso>
        public virtual DescribeJobsResponse DescribeJobs(DescribeJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobsResponseUnmarshaller.Instance;

            return Invoke<DescribeJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobs operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeJobs">REST API Reference for DescribeJobs Operation</seealso>
        public virtual IAsyncResult BeginDescribeJobs(DescribeJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobs.</param>
        /// 
        /// <returns>Returns a  DescribeJobsResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeJobs">REST API Reference for DescribeJobs Operation</seealso>
        public virtual DescribeJobsResponse EndDescribeJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSchedulingPolicies

        /// <summary>
        /// Describes one or more of your scheduling policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchedulingPolicies service method.</param>
        /// 
        /// <returns>The response from the DescribeSchedulingPolicies service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeSchedulingPolicies">REST API Reference for DescribeSchedulingPolicies Operation</seealso>
        public virtual DescribeSchedulingPoliciesResponse DescribeSchedulingPolicies(DescribeSchedulingPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSchedulingPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSchedulingPoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribeSchedulingPoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSchedulingPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchedulingPolicies operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSchedulingPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeSchedulingPolicies">REST API Reference for DescribeSchedulingPolicies Operation</seealso>
        public virtual IAsyncResult BeginDescribeSchedulingPolicies(DescribeSchedulingPoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSchedulingPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSchedulingPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSchedulingPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSchedulingPolicies.</param>
        /// 
        /// <returns>Returns a  DescribeSchedulingPoliciesResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeSchedulingPolicies">REST API Reference for DescribeSchedulingPolicies Operation</seealso>
        public virtual DescribeSchedulingPoliciesResponse EndDescribeSchedulingPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSchedulingPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeServiceEnvironments

        /// <summary>
        /// Describes one or more of your service environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceEnvironments service method.</param>
        /// 
        /// <returns>The response from the DescribeServiceEnvironments service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeServiceEnvironments">REST API Reference for DescribeServiceEnvironments Operation</seealso>
        public virtual DescribeServiceEnvironmentsResponse DescribeServiceEnvironments(DescribeServiceEnvironmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServiceEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeServiceEnvironmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceEnvironments operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeServiceEnvironments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeServiceEnvironments">REST API Reference for DescribeServiceEnvironments Operation</seealso>
        public virtual IAsyncResult BeginDescribeServiceEnvironments(DescribeServiceEnvironmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServiceEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceEnvironmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeServiceEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServiceEnvironments.</param>
        /// 
        /// <returns>Returns a  DescribeServiceEnvironmentsResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeServiceEnvironments">REST API Reference for DescribeServiceEnvironments Operation</seealso>
        public virtual DescribeServiceEnvironmentsResponse EndDescribeServiceEnvironments(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeServiceEnvironmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeServiceJob

        /// <summary>
        /// The details of a service job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceJob service method.</param>
        /// 
        /// <returns>The response from the DescribeServiceJob service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeServiceJob">REST API Reference for DescribeServiceJob Operation</seealso>
        public virtual DescribeServiceJobResponse DescribeServiceJob(DescribeServiceJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServiceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceJobResponseUnmarshaller.Instance;

            return Invoke<DescribeServiceJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeServiceJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeServiceJob operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeServiceJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeServiceJob">REST API Reference for DescribeServiceJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeServiceJob(DescribeServiceJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeServiceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeServiceJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeServiceJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeServiceJob.</param>
        /// 
        /// <returns>Returns a  DescribeServiceJobResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeServiceJob">REST API Reference for DescribeServiceJob Operation</seealso>
        public virtual DescribeServiceJobResponse EndDescribeServiceJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeServiceJobResponse>(asyncResult);
        }

        #endregion
        
        #region  GetJobQueueSnapshot

        /// <summary>
        /// Provides a list of the first 100 <c>RUNNABLE</c> jobs associated to a single job queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobQueueSnapshot service method.</param>
        /// 
        /// <returns>The response from the GetJobQueueSnapshot service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/GetJobQueueSnapshot">REST API Reference for GetJobQueueSnapshot Operation</seealso>
        public virtual GetJobQueueSnapshotResponse GetJobQueueSnapshot(GetJobQueueSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobQueueSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobQueueSnapshotResponseUnmarshaller.Instance;

            return Invoke<GetJobQueueSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetJobQueueSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobQueueSnapshot operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJobQueueSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/GetJobQueueSnapshot">REST API Reference for GetJobQueueSnapshot Operation</seealso>
        public virtual IAsyncResult BeginGetJobQueueSnapshot(GetJobQueueSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetJobQueueSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobQueueSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetJobQueueSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJobQueueSnapshot.</param>
        /// 
        /// <returns>Returns a  GetJobQueueSnapshotResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/GetJobQueueSnapshot">REST API Reference for GetJobQueueSnapshot Operation</seealso>
        public virtual GetJobQueueSnapshotResponse EndGetJobQueueSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<GetJobQueueSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConsumableResources

        /// <summary>
        /// Returns a list of Batch consumable resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConsumableResources service method.</param>
        /// 
        /// <returns>The response from the ListConsumableResources service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListConsumableResources">REST API Reference for ListConsumableResources Operation</seealso>
        public virtual ListConsumableResourcesResponse ListConsumableResources(ListConsumableResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConsumableResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConsumableResourcesResponseUnmarshaller.Instance;

            return Invoke<ListConsumableResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConsumableResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConsumableResources operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConsumableResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListConsumableResources">REST API Reference for ListConsumableResources Operation</seealso>
        public virtual IAsyncResult BeginListConsumableResources(ListConsumableResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConsumableResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConsumableResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConsumableResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConsumableResources.</param>
        /// 
        /// <returns>Returns a  ListConsumableResourcesResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListConsumableResources">REST API Reference for ListConsumableResources Operation</seealso>
        public virtual ListConsumableResourcesResponse EndListConsumableResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConsumableResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListJobs

        /// <summary>
        /// Returns a list of Batch jobs.
        /// 
        ///  
        /// <para>
        /// You must specify only one of the following items:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A job queue ID to return a list of jobs in that job queue
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A multi-node parallel job ID to return a list of nodes for that job
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An array job ID to return a list of the children for that job
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can filter the results by job status with the <c>jobStatus</c> parameter. If you
        /// don't specify a status, only <c>RUNNING</c> jobs are returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual IAsyncResult BeginListJobs(ListJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobs.</param>
        /// 
        /// <returns>Returns a  ListJobsResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual ListJobsResponse EndListJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListJobsByConsumableResource

        /// <summary>
        /// Returns a list of Batch jobs that require a specific consumable resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByConsumableResource service method.</param>
        /// 
        /// <returns>The response from the ListJobsByConsumableResource service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListJobsByConsumableResource">REST API Reference for ListJobsByConsumableResource Operation</seealso>
        public virtual ListJobsByConsumableResourceResponse ListJobsByConsumableResource(ListJobsByConsumableResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsByConsumableResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsByConsumableResourceResponseUnmarshaller.Instance;

            return Invoke<ListJobsByConsumableResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobsByConsumableResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobsByConsumableResource operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobsByConsumableResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListJobsByConsumableResource">REST API Reference for ListJobsByConsumableResource Operation</seealso>
        public virtual IAsyncResult BeginListJobsByConsumableResource(ListJobsByConsumableResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsByConsumableResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsByConsumableResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobsByConsumableResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobsByConsumableResource.</param>
        /// 
        /// <returns>Returns a  ListJobsByConsumableResourceResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListJobsByConsumableResource">REST API Reference for ListJobsByConsumableResource Operation</seealso>
        public virtual ListJobsByConsumableResourceResponse EndListJobsByConsumableResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListJobsByConsumableResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSchedulingPolicies

        /// <summary>
        /// Returns a list of Batch scheduling policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchedulingPolicies service method.</param>
        /// 
        /// <returns>The response from the ListSchedulingPolicies service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListSchedulingPolicies">REST API Reference for ListSchedulingPolicies Operation</seealso>
        public virtual ListSchedulingPoliciesResponse ListSchedulingPolicies(ListSchedulingPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchedulingPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchedulingPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListSchedulingPoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSchedulingPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSchedulingPolicies operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSchedulingPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListSchedulingPolicies">REST API Reference for ListSchedulingPolicies Operation</seealso>
        public virtual IAsyncResult BeginListSchedulingPolicies(ListSchedulingPoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSchedulingPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSchedulingPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSchedulingPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSchedulingPolicies.</param>
        /// 
        /// <returns>Returns a  ListSchedulingPoliciesResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListSchedulingPolicies">REST API Reference for ListSchedulingPolicies Operation</seealso>
        public virtual ListSchedulingPoliciesResponse EndListSchedulingPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSchedulingPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServiceJobs

        /// <summary>
        /// Returns a list of service jobs for a specified job queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceJobs service method.</param>
        /// 
        /// <returns>The response from the ListServiceJobs service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListServiceJobs">REST API Reference for ListServiceJobs Operation</seealso>
        public virtual ListServiceJobsResponse ListServiceJobs(ListServiceJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceJobsResponseUnmarshaller.Instance;

            return Invoke<ListServiceJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceJobs operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListServiceJobs">REST API Reference for ListServiceJobs Operation</seealso>
        public virtual IAsyncResult BeginListServiceJobs(ListServiceJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceJobs.</param>
        /// 
        /// <returns>Returns a  ListServiceJobsResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListServiceJobs">REST API Reference for ListServiceJobs Operation</seealso>
        public virtual ListServiceJobsResponse EndListServiceJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServiceJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags for an Batch resource. Batch resources that support tags are compute
        /// environments, jobs, job definitions, job queues, and scheduling policies. ARNs for
        /// child jobs of array and multi-node parallel (MNP) jobs aren't supported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterJobDefinition

        /// <summary>
        /// Registers an Batch job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterJobDefinition service method.</param>
        /// 
        /// <returns>The response from the RegisterJobDefinition service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/RegisterJobDefinition">REST API Reference for RegisterJobDefinition Operation</seealso>
        public virtual RegisterJobDefinitionResponse RegisterJobDefinition(RegisterJobDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterJobDefinitionResponseUnmarshaller.Instance;

            return Invoke<RegisterJobDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterJobDefinition operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterJobDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/RegisterJobDefinition">REST API Reference for RegisterJobDefinition Operation</seealso>
        public virtual IAsyncResult BeginRegisterJobDefinition(RegisterJobDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterJobDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterJobDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterJobDefinition.</param>
        /// 
        /// <returns>Returns a  RegisterJobDefinitionResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/RegisterJobDefinition">REST API Reference for RegisterJobDefinition Operation</seealso>
        public virtual RegisterJobDefinitionResponse EndRegisterJobDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterJobDefinitionResponse>(asyncResult);
        }

        #endregion
        
        #region  SubmitJob

        /// <summary>
        /// Submits an Batch job from a job definition. Parameters that are specified during <a>SubmitJob</a>
        /// override parameters defined in the job definition. vCPU and memory requirements that
        /// are specified in the <c>resourceRequirements</c> objects in the job definition are
        /// the exception. They can't be overridden this way using the <c>memory</c> and <c>vcpus</c>
        /// parameters. Rather, you must specify updates to job definition parameters in a <c>resourceRequirements</c>
        /// object that's included in the <c>containerOverrides</c> parameter.
        /// 
        ///  <note> 
        /// <para>
        /// Job queues with a scheduling policy are limited to 500 active share identifiers at
        /// a time. 
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// Jobs that run on Fargate resources can't be guaranteed to run for more than 14 days.
        /// This is because, after 14 days, Fargate resources might become unavailable and job
        /// might be terminated.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitJob service method.</param>
        /// 
        /// <returns>The response from the SubmitJob service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/SubmitJob">REST API Reference for SubmitJob Operation</seealso>
        public virtual SubmitJobResponse SubmitJob(SubmitJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SubmitJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitJobResponseUnmarshaller.Instance;

            return Invoke<SubmitJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SubmitJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SubmitJob operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSubmitJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/SubmitJob">REST API Reference for SubmitJob Operation</seealso>
        public virtual IAsyncResult BeginSubmitJob(SubmitJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SubmitJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SubmitJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSubmitJob.</param>
        /// 
        /// <returns>Returns a  SubmitJobResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/SubmitJob">REST API Reference for SubmitJob Operation</seealso>
        public virtual SubmitJobResponse EndSubmitJob(IAsyncResult asyncResult)
        {
            return EndInvoke<SubmitJobResponse>(asyncResult);
        }

        #endregion
        
        #region  SubmitServiceJob

        /// <summary>
        /// Submits a service job to a specified job queue to run on SageMaker AI. A service job
        /// is a unit of work that you submit to Batch for execution on SageMaker AI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitServiceJob service method.</param>
        /// 
        /// <returns>The response from the SubmitServiceJob service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/SubmitServiceJob">REST API Reference for SubmitServiceJob Operation</seealso>
        public virtual SubmitServiceJobResponse SubmitServiceJob(SubmitServiceJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SubmitServiceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitServiceJobResponseUnmarshaller.Instance;

            return Invoke<SubmitServiceJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SubmitServiceJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SubmitServiceJob operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSubmitServiceJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/SubmitServiceJob">REST API Reference for SubmitServiceJob Operation</seealso>
        public virtual IAsyncResult BeginSubmitServiceJob(SubmitServiceJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SubmitServiceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitServiceJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SubmitServiceJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSubmitServiceJob.</param>
        /// 
        /// <returns>Returns a  SubmitServiceJobResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/SubmitServiceJob">REST API Reference for SubmitServiceJob Operation</seealso>
        public virtual SubmitServiceJobResponse EndSubmitServiceJob(IAsyncResult asyncResult)
        {
            return EndInvoke<SubmitServiceJobResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Associates the specified tags to a resource with the specified <c>resourceArn</c>.
        /// If existing tags on a resource aren't specified in the request parameters, they aren't
        /// changed. When a resource is deleted, the tags that are associated with that resource
        /// are deleted as well. Batch resources that support tags are compute environments, jobs,
        /// job definitions, job queues, and scheduling policies. ARNs for child jobs of array
        /// and multi-node parallel (MNP) jobs aren't supported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TerminateJob

        /// <summary>
        /// Terminates a job in a job queue. Jobs that are in the <c>STARTING</c> or <c>RUNNING</c>
        /// state are terminated, which causes them to transition to <c>FAILED</c>. Jobs that
        /// have not progressed to the <c>STARTING</c> state are cancelled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateJob service method.</param>
        /// 
        /// <returns>The response from the TerminateJob service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/TerminateJob">REST API Reference for TerminateJob Operation</seealso>
        public virtual TerminateJobResponse TerminateJob(TerminateJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateJobResponseUnmarshaller.Instance;

            return Invoke<TerminateJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateJob operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/TerminateJob">REST API Reference for TerminateJob Operation</seealso>
        public virtual IAsyncResult BeginTerminateJob(TerminateJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateJob.</param>
        /// 
        /// <returns>Returns a  TerminateJobResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/TerminateJob">REST API Reference for TerminateJob Operation</seealso>
        public virtual TerminateJobResponse EndTerminateJob(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateJobResponse>(asyncResult);
        }

        #endregion
        
        #region  TerminateServiceJob

        /// <summary>
        /// Terminates a service job in a job queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateServiceJob service method.</param>
        /// 
        /// <returns>The response from the TerminateServiceJob service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/TerminateServiceJob">REST API Reference for TerminateServiceJob Operation</seealso>
        public virtual TerminateServiceJobResponse TerminateServiceJob(TerminateServiceJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateServiceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateServiceJobResponseUnmarshaller.Instance;

            return Invoke<TerminateServiceJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateServiceJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateServiceJob operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateServiceJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/TerminateServiceJob">REST API Reference for TerminateServiceJob Operation</seealso>
        public virtual IAsyncResult BeginTerminateServiceJob(TerminateServiceJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateServiceJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateServiceJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateServiceJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateServiceJob.</param>
        /// 
        /// <returns>Returns a  TerminateServiceJobResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/TerminateServiceJob">REST API Reference for TerminateServiceJob Operation</seealso>
        public virtual TerminateServiceJobResponse EndTerminateServiceJob(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateServiceJobResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Deletes specified tags from an Batch resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateComputeEnvironment

        /// <summary>
        /// Updates an Batch compute environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComputeEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateComputeEnvironment service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateComputeEnvironment">REST API Reference for UpdateComputeEnvironment Operation</seealso>
        public virtual UpdateComputeEnvironmentResponse UpdateComputeEnvironment(UpdateComputeEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateComputeEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComputeEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateComputeEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateComputeEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateComputeEnvironment operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateComputeEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateComputeEnvironment">REST API Reference for UpdateComputeEnvironment Operation</seealso>
        public virtual IAsyncResult BeginUpdateComputeEnvironment(UpdateComputeEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateComputeEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComputeEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateComputeEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateComputeEnvironment.</param>
        /// 
        /// <returns>Returns a  UpdateComputeEnvironmentResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateComputeEnvironment">REST API Reference for UpdateComputeEnvironment Operation</seealso>
        public virtual UpdateComputeEnvironmentResponse EndUpdateComputeEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateComputeEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConsumableResource

        /// <summary>
        /// Updates a consumable resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConsumableResource service method.</param>
        /// 
        /// <returns>The response from the UpdateConsumableResource service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateConsumableResource">REST API Reference for UpdateConsumableResource Operation</seealso>
        public virtual UpdateConsumableResourceResponse UpdateConsumableResource(UpdateConsumableResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConsumableResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConsumableResourceResponseUnmarshaller.Instance;

            return Invoke<UpdateConsumableResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConsumableResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConsumableResource operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConsumableResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateConsumableResource">REST API Reference for UpdateConsumableResource Operation</seealso>
        public virtual IAsyncResult BeginUpdateConsumableResource(UpdateConsumableResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConsumableResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConsumableResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConsumableResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConsumableResource.</param>
        /// 
        /// <returns>Returns a  UpdateConsumableResourceResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateConsumableResource">REST API Reference for UpdateConsumableResource Operation</seealso>
        public virtual UpdateConsumableResourceResponse EndUpdateConsumableResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConsumableResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateJobQueue

        /// <summary>
        /// Updates a job queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobQueue service method.</param>
        /// 
        /// <returns>The response from the UpdateJobQueue service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateJobQueue">REST API Reference for UpdateJobQueue Operation</seealso>
        public virtual UpdateJobQueueResponse UpdateJobQueue(UpdateJobQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobQueueResponseUnmarshaller.Instance;

            return Invoke<UpdateJobQueueResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJobQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobQueue operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateJobQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateJobQueue">REST API Reference for UpdateJobQueue Operation</seealso>
        public virtual IAsyncResult BeginUpdateJobQueue(UpdateJobQueueRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobQueueResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJobQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJobQueue.</param>
        /// 
        /// <returns>Returns a  UpdateJobQueueResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateJobQueue">REST API Reference for UpdateJobQueue Operation</seealso>
        public virtual UpdateJobQueueResponse EndUpdateJobQueue(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateJobQueueResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSchedulingPolicy

        /// <summary>
        /// Updates a scheduling policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchedulingPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateSchedulingPolicy service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateSchedulingPolicy">REST API Reference for UpdateSchedulingPolicy Operation</seealso>
        public virtual UpdateSchedulingPolicyResponse UpdateSchedulingPolicy(UpdateSchedulingPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSchedulingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSchedulingPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateSchedulingPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSchedulingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchedulingPolicy operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSchedulingPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateSchedulingPolicy">REST API Reference for UpdateSchedulingPolicy Operation</seealso>
        public virtual IAsyncResult BeginUpdateSchedulingPolicy(UpdateSchedulingPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSchedulingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSchedulingPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSchedulingPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSchedulingPolicy.</param>
        /// 
        /// <returns>Returns a  UpdateSchedulingPolicyResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateSchedulingPolicy">REST API Reference for UpdateSchedulingPolicy Operation</seealso>
        public virtual UpdateSchedulingPolicyResponse EndUpdateSchedulingPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSchedulingPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateServiceEnvironment

        /// <summary>
        /// Updates a service environment. You can update the state of a service environment from
        /// <c>ENABLED</c> to <c>DISABLED</c> to prevent new service jobs from being placed in
        /// the service environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceEnvironment service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action. One example cause is using an
        /// action or resource on behalf of a user that doesn't have permissions to use the action
        /// or resource. Another cause is specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateServiceEnvironment">REST API Reference for UpdateServiceEnvironment Operation</seealso>
        public virtual UpdateServiceEnvironmentResponse UpdateServiceEnvironment(UpdateServiceEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceEnvironment operation on AmazonBatchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServiceEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateServiceEnvironment">REST API Reference for UpdateServiceEnvironment Operation</seealso>
        public virtual IAsyncResult BeginUpdateServiceEnvironment(UpdateServiceEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServiceEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceEnvironment.</param>
        /// 
        /// <returns>Returns a  UpdateServiceEnvironmentResult from Batch.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateServiceEnvironment">REST API Reference for UpdateServiceEnvironment Operation</seealso>
        public virtual UpdateServiceEnvironmentResponse EndUpdateServiceEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateServiceEnvironmentResponse>(asyncResult);
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
            var resolver = new AmazonBatchEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}