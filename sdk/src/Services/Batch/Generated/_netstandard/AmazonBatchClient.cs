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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Batch.Model;
using Amazon.Batch.Model.Internal.MarshallTransformations;
using Amazon.Batch.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Batch
{
    /// <summary>
    /// Implementation for accessing Batch
    ///
    /// Using AWS Batch, you can run batch computing workloads on the AWS Cloud. Batch computing
    /// is a common means for developers, scientists, and engineers to access large amounts
    /// of compute resources. AWS Batch utilizes the advantages of this computing workload
    /// to remove the undifferentiated heavy lifting of configuring and managing required
    /// infrastructure, while also adopting a familiar batch computing software approach.
    /// Given these advantages, AWS Batch can help you to efficiently provision resources
    /// in response to jobs submitted, thus effectively helping to eliminate capacity constraints,
    /// reduce compute costs, and deliver your results more quickly.
    /// 
    ///  
    /// <para>
    /// As a fully managed service, AWS Batch can run batch computing workloads of any scale.
    /// AWS Batch automatically provisions compute resources and optimizes workload distribution
    /// based on the quantity and scale of your specific workloads. With AWS Batch, there's
    /// no need to install or manage batch computing software. This means that you can focus
    /// your time and energy on analyzing results and solving your specific problems. 
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonBatchClient : AmazonServiceClient, IAmazonBatch
    {
        private static IServiceMetadata serviceMetadata = new AmazonBatchMetadata();
        
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
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

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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

        internal virtual CancelJobResponse CancelJob(CancelJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;

            return Invoke<CancelJobResponse>(request, options);
        }



        /// <summary>
        /// Cancels a job in an AWS Batch job queue. Jobs that are in the <code>SUBMITTED</code>,
        /// <code>PENDING</code>, or <code>RUNNABLE</code> state are canceled. Jobs that have
        /// progressed to <code>STARTING</code> or <code>RUNNING</code> are not canceled (but
        /// the API operation still succeeds, even if no job is canceled); these jobs must be
        /// terminated with the <a>TerminateJob</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CancelJob">REST API Reference for CancelJob Operation</seealso>
        public virtual Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelJobResponseUnmarshaller.Instance;

            return InvokeAsync<CancelJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateComputeEnvironment

        internal virtual CreateComputeEnvironmentResponse CreateComputeEnvironment(CreateComputeEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComputeEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComputeEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateComputeEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Creates an AWS Batch compute environment. You can create <code>MANAGED</code> or <code>UNMANAGED</code>
        /// compute environments. <code>MANAGED</code> compute environments can use Amazon EC2
        /// or AWS Fargate resources. <code>UNMANAGED</code> compute environments can only use
        /// EC2 resources.
        /// 
        ///  
        /// <para>
        /// In a managed compute environment, AWS Batch manages the capacity and instance types
        /// of the compute resources within the environment. This is based on the compute resource
        /// specification that you define or the <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">launch
        /// template</a> that you specify when you create the compute environment. You can choose
        /// either to use EC2 On-Demand Instances and EC2 Spot Instances, or to use Fargate and
        /// Fargate Spot capacity in your managed compute environment. You can optionally set
        /// a maximum price so that Spot Instances only launch when the Spot Instance price is
        /// less than a specified percentage of the On-Demand price.
        /// </para>
        ///  <note> 
        /// <para>
        /// Multi-node parallel jobs are not supported on Spot Instances.
        /// </para>
        ///  </note> 
        /// <para>
        /// In an unmanaged compute environment, you can manage your own EC2 compute resources
        /// and have a lot of flexibility with how you configure your compute resources. For example,
        /// you can use custom AMI. However, you need to verify that your AMI meets the Amazon
        /// ECS container instance AMI specification. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/container_instance_AMIs.html">container
        /// instance AMIs</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// After you have created your unmanaged compute environment, you can use the <a>DescribeComputeEnvironments</a>
        /// operation to find the Amazon ECS cluster that's associated with it. Then, manually
        /// launch your container instances into that Amazon ECS cluster. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/launch_container_instance.html">Launching
        /// an Amazon ECS container instance</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// AWS Batch doesn't upgrade the AMIs in a compute environment after it's created. For
        /// example, it doesn't update the AMIs when a newer version of the Amazon ECS-optimized
        /// AMI is available. Therefore, you're responsible for the management of the guest operating
        /// system (including updates and security patches) and any additional application software
        /// or utilities that you install on the compute resources. To use a new AMI for your
        /// AWS Batch jobs, complete these steps:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Create a new compute environment with the new AMI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Add the compute environment to an existing job queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Remove the earlier compute environment from your job queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete the earlier compute environment.
        /// </para>
        ///  </li> </ol> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComputeEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateComputeEnvironment service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateComputeEnvironment">REST API Reference for CreateComputeEnvironment Operation</seealso>
        public virtual Task<CreateComputeEnvironmentResponse> CreateComputeEnvironmentAsync(CreateComputeEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComputeEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComputeEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateComputeEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateJobQueue

        internal virtual CreateJobQueueResponse CreateJobQueue(CreateJobQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobQueueResponseUnmarshaller.Instance;

            return Invoke<CreateJobQueueResponse>(request, options);
        }



        /// <summary>
        /// Creates an AWS Batch job queue. When you create a job queue, you associate one or
        /// more compute environments to the queue and assign an order of preference for the compute
        /// environments.
        /// 
        ///  
        /// <para>
        /// You also set a priority to the job queue that determines the order in which the AWS
        /// Batch scheduler places jobs onto its associated compute environments. For example,
        /// if a compute environment is associated with more than one job queue, the job queue
        /// with a higher priority is given preference for scheduling jobs to that compute environment.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJobQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateJobQueue service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/CreateJobQueue">REST API Reference for CreateJobQueue Operation</seealso>
        public virtual Task<CreateJobQueueResponse> CreateJobQueueAsync(CreateJobQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateJobQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateJobQueueResponseUnmarshaller.Instance;

            return InvokeAsync<CreateJobQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteComputeEnvironment

        internal virtual DeleteComputeEnvironmentResponse DeleteComputeEnvironment(DeleteComputeEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComputeEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComputeEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteComputeEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Deletes an AWS Batch compute environment.
        /// 
        ///  
        /// <para>
        /// Before you can delete a compute environment, you must set its state to <code>DISABLED</code>
        /// with the <a>UpdateComputeEnvironment</a> API operation and disassociate it from any
        /// job queues with the <a>UpdateJobQueue</a> API operation. Compute environments that
        /// use AWS Fargate resources must terminate all active jobs on that compute environment
        /// before deleting the compute environment. If this isn't done, the compute environment
        /// will end up in an invalid state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComputeEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteComputeEnvironment service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteComputeEnvironment">REST API Reference for DeleteComputeEnvironment Operation</seealso>
        public virtual Task<DeleteComputeEnvironmentResponse> DeleteComputeEnvironmentAsync(DeleteComputeEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComputeEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComputeEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteComputeEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteJobQueue

        internal virtual DeleteJobQueueResponse DeleteJobQueue(DeleteJobQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobQueueResponseUnmarshaller.Instance;

            return Invoke<DeleteJobQueueResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified job queue. You must first disable submissions for a queue with
        /// the <a>UpdateJobQueue</a> operation. All jobs in the queue are eventually terminated
        /// when you delete a job queue. The jobs are terminated at a rate of about 16 jobs each
        /// second.
        /// 
        ///  
        /// <para>
        /// It's not necessary to disassociate compute environments from a queue before submitting
        /// a <code>DeleteJobQueue</code> request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteJobQueue service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeleteJobQueue">REST API Reference for DeleteJobQueue Operation</seealso>
        public virtual Task<DeleteJobQueueResponse> DeleteJobQueueAsync(DeleteJobQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteJobQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteJobQueueResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteJobQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterJobDefinition

        internal virtual DeregisterJobDefinitionResponse DeregisterJobDefinition(DeregisterJobDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterJobDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeregisterJobDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Deregisters an AWS Batch job definition. Job definitions are permanently deleted after
        /// 180 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterJobDefinition service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DeregisterJobDefinition">REST API Reference for DeregisterJobDefinition Operation</seealso>
        public virtual Task<DeregisterJobDefinitionResponse> DeregisterJobDefinitionAsync(DeregisterJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterJobDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterJobDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeComputeEnvironments

        internal virtual DescribeComputeEnvironmentsResponse DescribeComputeEnvironments(DescribeComputeEnvironmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComputeEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComputeEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeComputeEnvironmentsResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more of your compute environments.
        /// 
        ///  
        /// <para>
        /// If you're using an unmanaged compute environment, you can use the <code>DescribeComputeEnvironment</code>
        /// operation to determine the <code>ecsClusterArn</code> that you should launch your
        /// Amazon ECS container instances into.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComputeEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeComputeEnvironments service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeComputeEnvironments">REST API Reference for DescribeComputeEnvironments Operation</seealso>
        public virtual Task<DescribeComputeEnvironmentsResponse> DescribeComputeEnvironmentsAsync(DescribeComputeEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComputeEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComputeEnvironmentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeComputeEnvironmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeJobDefinitions

        internal virtual DescribeJobDefinitionsResponse DescribeJobDefinitions(DescribeJobDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobDefinitionsResponseUnmarshaller.Instance;

            return Invoke<DescribeJobDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Describes a list of job definitions. You can specify a <code>status</code> (such as
        /// <code>ACTIVE</code>) to only return job definitions that match that status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJobDefinitions service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeJobDefinitions">REST API Reference for DescribeJobDefinitions Operation</seealso>
        public virtual Task<DescribeJobDefinitionsResponse> DescribeJobDefinitionsAsync(DescribeJobDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJobDefinitionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeJobQueues

        internal virtual DescribeJobQueuesResponse DescribeJobQueues(DescribeJobQueuesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobQueuesResponseUnmarshaller.Instance;

            return Invoke<DescribeJobQueuesResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more of your job queues.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobQueues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJobQueues service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeJobQueues">REST API Reference for DescribeJobQueues Operation</seealso>
        public virtual Task<DescribeJobQueuesResponse> DescribeJobQueuesAsync(DescribeJobQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobQueuesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJobQueuesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeJobs

        internal virtual DescribeJobsResponse DescribeJobs(DescribeJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobsResponseUnmarshaller.Instance;

            return Invoke<DescribeJobsResponse>(request, options);
        }



        /// <summary>
        /// Describes a list of AWS Batch jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJobs service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/DescribeJobs">REST API Reference for DescribeJobs Operation</seealso>
        public virtual Task<DescribeJobsResponse> DescribeJobsAsync(DescribeJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListJobs

        internal virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of AWS Batch jobs.
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
        /// A multi-node parallel job ID to return a list of that job's nodes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An array job ID to return a list of that job's children
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can filter the results by job status with the <code>jobStatus</code> parameter.
        /// If you don't specify a status, only <code>RUNNING</code> jobs are returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags for an AWS Batch resource. AWS Batch resources that support tags are
        /// compute environments, jobs, job definitions, and job queues. ARNs for child jobs of
        /// array and multi-node parallel (MNP) jobs are not supported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterJobDefinition

        internal virtual RegisterJobDefinitionResponse RegisterJobDefinition(RegisterJobDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterJobDefinitionResponseUnmarshaller.Instance;

            return Invoke<RegisterJobDefinitionResponse>(request, options);
        }



        /// <summary>
        /// Registers an AWS Batch job definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterJobDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterJobDefinition service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/RegisterJobDefinition">REST API Reference for RegisterJobDefinition Operation</seealso>
        public virtual Task<RegisterJobDefinitionResponse> RegisterJobDefinitionAsync(RegisterJobDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterJobDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterJobDefinitionResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterJobDefinitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SubmitJob

        internal virtual SubmitJobResponse SubmitJob(SubmitJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SubmitJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitJobResponseUnmarshaller.Instance;

            return Invoke<SubmitJobResponse>(request, options);
        }



        /// <summary>
        /// Submits an AWS Batch job from a job definition. Parameters specified during <a>SubmitJob</a>
        /// override parameters defined in the job definition.
        /// 
        ///  <important> 
        /// <para>
        /// Jobs run on Fargate resources don't run for more than 14 days. After 14 days, the
        /// Fargate resources might no longer be available and the job is terminated.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SubmitJob service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/SubmitJob">REST API Reference for SubmitJob Operation</seealso>
        public virtual Task<SubmitJobResponse> SubmitJobAsync(SubmitJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SubmitJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitJobResponseUnmarshaller.Instance;

            return InvokeAsync<SubmitJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Associates the specified tags to a resource with the specified <code>resourceArn</code>.
        /// If existing tags on a resource aren't specified in the request parameters, they aren't
        /// changed. When a resource is deleted, the tags associated with that resource are deleted
        /// as well. AWS Batch resources that support tags are compute environments, jobs, job
        /// definitions, and job queues. ARNs for child jobs of array and multi-node parallel
        /// (MNP) jobs are not supported.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TerminateJob

        internal virtual TerminateJobResponse TerminateJob(TerminateJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateJobResponseUnmarshaller.Instance;

            return Invoke<TerminateJobResponse>(request, options);
        }



        /// <summary>
        /// Terminates a job in a job queue. Jobs that are in the <code>STARTING</code> or <code>RUNNING</code>
        /// state are terminated, which causes them to transition to <code>FAILED</code>. Jobs
        /// that have not progressed to the <code>STARTING</code> state are cancelled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateJob service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/TerminateJob">REST API Reference for TerminateJob Operation</seealso>
        public virtual Task<TerminateJobResponse> TerminateJobAsync(TerminateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateJobResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Deletes specified tags from an AWS Batch resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateComputeEnvironment

        internal virtual UpdateComputeEnvironmentResponse UpdateComputeEnvironment(UpdateComputeEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateComputeEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComputeEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateComputeEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Updates an AWS Batch compute environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComputeEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateComputeEnvironment service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateComputeEnvironment">REST API Reference for UpdateComputeEnvironment Operation</seealso>
        public virtual Task<UpdateComputeEnvironmentResponse> UpdateComputeEnvironmentAsync(UpdateComputeEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateComputeEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComputeEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateComputeEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateJobQueue

        internal virtual UpdateJobQueueResponse UpdateJobQueue(UpdateJobQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobQueueResponseUnmarshaller.Instance;

            return Invoke<UpdateJobQueueResponse>(request, options);
        }



        /// <summary>
        /// Updates a job queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateJobQueue service method, as returned by Batch.</returns>
        /// <exception cref="Amazon.Batch.Model.ClientException">
        /// These errors are usually caused by a client action, such as using an action or resource
        /// on behalf of a user that doesn't have permissions to use the action or resource, or
        /// specifying an identifier that's not valid.
        /// </exception>
        /// <exception cref="Amazon.Batch.Model.ServerException">
        /// These errors are usually caused by a server issue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/batch-2016-08-10/UpdateJobQueue">REST API Reference for UpdateJobQueue Operation</seealso>
        public virtual Task<UpdateJobQueueResponse> UpdateJobQueueAsync(UpdateJobQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateJobQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateJobQueueResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateJobQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}