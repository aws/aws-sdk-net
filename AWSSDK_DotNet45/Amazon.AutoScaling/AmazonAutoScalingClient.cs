/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

using Amazon.AutoScaling.Model;
using Amazon.AutoScaling.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AutoScaling
{
    /// <summary>
    /// Implementation for accessing AutoScaling
    /// 
    /// Auto Scaling
    /// <para>
    /// Auto Scaling is a web service designed to automatically launch or terminate Amazon
    /// Elastic Compute Cloud (Amazon EC2) instances based on user-defined policies, schedules,
    /// and health checks. This service is used in conjunction with Amazon CloudWatch and
    /// Elastic Load Balancing services.
    /// </para>
    /// 
    /// <para>
    /// Auto Scaling provides APIs that you can call by submitting a Query Request. Query
    /// requests are HTTP or HTTPS requests that use the HTTP verbs GET or POST and a Query
    /// parameter named <i>Action</i> or <i>Operation</i> that specifies the API you are calling.
    /// Action is used throughout this documentation, although Operation is also supported
    /// for backward compatibility with other Amazon Web Services (AWS) Query APIs.
    /// </para>
    /// 
    /// <para>
    /// Calling the API using a Query request is the most direct way to access the web service,
    /// but requires that your application handle low-level details such as generating the
    /// hash to sign the request and error handling. The benefit of calling the service using
    /// a Query request is that you are assured of having access to the complete functionality
    /// of the API. For information about signing a a query request, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/api_requests.html">Use
    /// Query Requests to Call Auto Scaling APIs</a>
    /// </para>
    /// 
    /// <para>
    /// This guide provides detailed information about Auto Scaling actions, data types,
    /// parameters, and errors. For detailed information about Auto Scaling features and their
    /// associated API actions, go to the <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/">Auto
    /// Scaling Developer Guide</a>.
    /// </para>
    /// 
    /// <para>
    /// This reference is based on the current WSDL, which is available at:
    /// </para>
    /// 
    /// <para>
    /// <a href="http://autoscaling.amazonaws.com/doc/2011-01-01/AutoScaling.wsdl">http://autoscaling.amazonaws.com/doc/2011-01-01/AutoScaling.wsdl</a>
    /// 
    /// </para>
    /// 
    /// <para>
    /// <b>Endpoints</b>
    /// </para>
    /// 
    /// <para>
    /// The examples in this guide assume that your instances are launched in the US East
    /// (Northern Virginia) region and use us-east-1 as the endpoint.
    /// </para>
    /// 
    /// <para>
    /// You can set up your Auto Scaling infrastructure in other AWS regions. For information
    /// about this product's regions and endpoints, see <a href="http://docs.aws.amazon.com/general/latest/gr/index.html?rande.html">Regions
    /// and Endpoints</a> in the Amazon Web Services General Reference.
    /// </para>
    /// </summary>
	public partial class AmazonAutoScalingClient : AmazonWebServiceClient, Amazon.AutoScaling.IAmazonAutoScaling
    {

        AWS4Signer signer = new AWS4Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs AmazonAutoScalingClient with the credentials loaded from the application's
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
        public AmazonAutoScalingClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAutoScalingConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with the credentials loaded from the application's
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
        public AmazonAutoScalingClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAutoScalingConfig(){RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAutoScaling Configuration Object</param>
        public AmazonAutoScalingClient(AmazonAutoScalingConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAutoScalingClient(AWSCredentials credentials)
            : this(credentials, new AmazonAutoScalingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAutoScalingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAutoScalingConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Credentials and an
        /// AmazonAutoScalingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAutoScalingClient Configuration Object</param>
        public AmazonAutoScalingClient(AWSCredentials credentials, AmazonAutoScalingConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAutoScalingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAutoScalingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAutoScalingClient Configuration object.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAutoScalingClient Configuration Object</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAutoScalingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAutoScalingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAutoScalingConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAutoScalingClient Configuration object.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAutoScalingClient Configuration Object</param>
        public AmazonAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAutoScalingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
        /// <summary>
        /// Attaches one or more Amazon EC2 instances to an existing Auto Scaling group. After
        /// the instance(s) is attached, it becomes a part of the Auto Scaling group.
        /// 
        /// 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/attach-instance-asg.html">Attach
        /// Amazon EC2 Instances to Your Existing Auto Scaling Group</a> in the <i>Auto Scaling
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachInstances service method.</param>
        /// 
        /// <returns>The response from the AttachInstances service method, as returned by AutoScaling.</returns>
		public AttachInstancesResponse AttachInstances(AttachInstancesRequest request)
        {
            var task = AttachInstancesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the AttachInstances operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.AttachInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<AttachInstancesResponse> AttachInstancesAsync(AttachInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachInstancesRequestMarshaller();
            var unmarshaller = AttachInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AttachInstancesRequest, AttachInstancesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Completes the lifecycle action for the associated token initiated under the given
        /// lifecycle hook with the specified result.
        /// 
        /// 
        /// <para>
        /// This operation is a part of the basic sequence for adding a lifecycle hook to an
        /// Auto Scaling group:
        /// </para>
        /// <ol> <li> Create a notification target. A target can be either an Amazon SQS queue
        /// or an Amazon SNS topic. </li> <li> Create an IAM role. This role allows Auto Scaling
        /// to publish lifecycle notifications to the designated SQS queue or SNS topic. </li>
        /// <li> Create the lifecycle hook. You can create a hook that acts when instances launch
        /// or when instances terminate. </li> <li> If necessary, record the lifecycle action
        /// heartbeat to keep the instance in a pending state. </li> <li> <b>Complete the lifecycle
        /// action.</b> </li> </ol>
        /// <para>
        /// To learn more, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingPendingState.html">Auto
        /// Scaling Pending State</a> and <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingTerminatingState.html">Auto
        /// Scaling Terminating State</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompleteLifecycleAction service method.</param>
        /// 
        /// <returns>The response from the CompleteLifecycleAction service method, as returned by AutoScaling.</returns>
		public CompleteLifecycleActionResponse CompleteLifecycleAction(CompleteLifecycleActionRequest request)
        {
            var task = CompleteLifecycleActionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CompleteLifecycleAction operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.CompleteLifecycleAction"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteLifecycleAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CompleteLifecycleActionResponse> CompleteLifecycleActionAsync(CompleteLifecycleActionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CompleteLifecycleActionRequestMarshaller();
            var unmarshaller = CompleteLifecycleActionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CompleteLifecycleActionRequest, CompleteLifecycleActionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Creates a new Auto Scaling group with the specified name and other attributes. When
        /// the creation request is completed, the Auto Scaling group is ready to be used in other
        /// calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the CreateAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.AlreadyExistsException">
        /// The named Auto Scaling group or launch configuration already exists.
        /// </exception>
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException">
        /// The quota for capacity groups or launch configurations for this customer has already
        /// been reached.
        /// </exception>
		public CreateAutoScalingGroupResponse CreateAutoScalingGroup(CreateAutoScalingGroupRequest request)
        {
            var task = CreateAutoScalingGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.CreateAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoScalingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateAutoScalingGroupResponse> CreateAutoScalingGroupAsync(CreateAutoScalingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAutoScalingGroupRequestMarshaller();
            var unmarshaller = CreateAutoScalingGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateAutoScalingGroupRequest, CreateAutoScalingGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Creates a new launch configuration. The launch configuration name must be unique
        /// within the scope of the client's AWS account. The maximum limit of launch configurations,
        /// which by default is 100, must not yet have been met; otherwise, the call will fail.
        /// When created, the new launch configuration is available for immediate use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateLaunchConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.AlreadyExistsException">
        /// The named Auto Scaling group or launch configuration already exists.
        /// </exception>
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException">
        /// The quota for capacity groups or launch configurations for this customer has already
        /// been reached.
        /// </exception>
		public CreateLaunchConfigurationResponse CreateLaunchConfiguration(CreateLaunchConfigurationRequest request)
        {
            var task = CreateLaunchConfigurationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateLaunchConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.CreateLaunchConfiguration"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateLaunchConfigurationResponse> CreateLaunchConfigurationAsync(CreateLaunchConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLaunchConfigurationRequestMarshaller();
            var unmarshaller = CreateLaunchConfigurationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateLaunchConfigurationRequest, CreateLaunchConfigurationResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Creates new tags or updates existing tags for an Auto Scaling group.
        /// 
        /// 
        /// <para>
        /// For information on creating tags for your Auto Scaling group, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/ASTagging.html">Tag
        /// Your Auto Scaling Groups and Amazon EC2 Instances</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOrUpdateTags service method.</param>
        /// 
        /// <returns>The response from the CreateOrUpdateTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.AlreadyExistsException">
        /// The named Auto Scaling group or launch configuration already exists.
        /// </exception>
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException">
        /// The quota for capacity groups or launch configurations for this customer has already
        /// been reached.
        /// </exception>
		public CreateOrUpdateTagsResponse CreateOrUpdateTags(CreateOrUpdateTagsRequest request)
        {
            var task = CreateOrUpdateTagsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateOrUpdateTags operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.CreateOrUpdateTags"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOrUpdateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateOrUpdateTagsResponse> CreateOrUpdateTagsAsync(CreateOrUpdateTagsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateOrUpdateTagsRequestMarshaller();
            var unmarshaller = CreateOrUpdateTagsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateOrUpdateTagsRequest, CreateOrUpdateTagsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Deletes the specified Auto Scaling group if the group has no instances and no scaling
        /// activities in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.ResourceInUseException">
        /// This is returned when you cannot delete a launch configuration or Auto Scaling group
        /// because it is being used.
        /// </exception>
        /// <exception cref="T:Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// You cannot delete an Auto Scaling group while there are scaling activities in progress
        /// for that group.
        /// </exception>
		public DeleteAutoScalingGroupResponse DeleteAutoScalingGroup(DeleteAutoScalingGroupRequest request)
        {
            var task = DeleteAutoScalingGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeleteAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoScalingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteAutoScalingGroupResponse> DeleteAutoScalingGroupAsync(DeleteAutoScalingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAutoScalingGroupRequestMarshaller();
            var unmarshaller = DeleteAutoScalingGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteAutoScalingGroupRequest, DeleteAutoScalingGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Deletes the specified <a>LaunchConfiguration</a>.
        /// 
        /// 
        /// <para>
        /// The specified launch configuration must not be attached to an Auto Scaling group.
        /// When this call completes, the launch configuration is no longer available for use.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLaunchConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.ResourceInUseException">
        /// This is returned when you cannot delete a launch configuration or Auto Scaling group
        /// because it is being used.
        /// </exception>
		public DeleteLaunchConfigurationResponse DeleteLaunchConfiguration(DeleteLaunchConfigurationRequest request)
        {
            var task = DeleteLaunchConfigurationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLaunchConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeleteLaunchConfiguration"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteLaunchConfigurationResponse> DeleteLaunchConfigurationAsync(DeleteLaunchConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLaunchConfigurationRequestMarshaller();
            var unmarshaller = DeleteLaunchConfigurationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteLaunchConfigurationRequest, DeleteLaunchConfigurationResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Deletes the specified lifecycle hook. If there are any outstanding lifecycle actions,
        /// they are completed first (ABANDON for launching instances, CONTINUE for terminating
        /// instances).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleHook service method.</param>
        /// 
        /// <returns>The response from the DeleteLifecycleHook service method, as returned by AutoScaling.</returns>
		public DeleteLifecycleHookResponse DeleteLifecycleHook(DeleteLifecycleHookRequest request)
        {
            var task = DeleteLifecycleHookAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLifecycleHook operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeleteLifecycleHook"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleHook operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteLifecycleHookResponse> DeleteLifecycleHookAsync(DeleteLifecycleHookRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLifecycleHookRequestMarshaller();
            var unmarshaller = DeleteLifecycleHookResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteLifecycleHookRequest, DeleteLifecycleHookResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Deletes notifications created by <a>PutNotificationConfiguration</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteNotificationConfiguration service method, as returned by AutoScaling.</returns>
		public DeleteNotificationConfigurationResponse DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request)
        {
            var task = DeleteNotificationConfigurationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotificationConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeleteNotificationConfiguration"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfigurationAsync(DeleteNotificationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteNotificationConfigurationRequestMarshaller();
            var unmarshaller = DeleteNotificationConfigurationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteNotificationConfigurationRequest, DeleteNotificationConfigurationResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Deletes a policy created by <a>PutScalingPolicy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by AutoScaling.</returns>
		public DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            var task = DeletePolicyAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeletePolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeletePolicyRequestMarshaller();
            var unmarshaller = DeletePolicyResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeletePolicyRequest, DeletePolicyResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Deletes a scheduled action previously created using the <a>PutScheduledUpdateGroupAction</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction service method.</param>
        /// 
        /// <returns>The response from the DeleteScheduledAction service method, as returned by AutoScaling.</returns>
		public DeleteScheduledActionResponse DeleteScheduledAction(DeleteScheduledActionRequest request)
        {
            var task = DeleteScheduledActionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScheduledAction operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeleteScheduledAction"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteScheduledActionResponse> DeleteScheduledActionAsync(DeleteScheduledActionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteScheduledActionRequestMarshaller();
            var unmarshaller = DeleteScheduledActionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteScheduledActionRequest, DeleteScheduledActionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Removes the specified tags or a set of tags from a set of resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by AutoScaling.</returns>
		public DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var task = DeleteTagsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DeleteTags"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteTagsRequest, DeleteTagsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns the limits for the Auto Scaling resources currently allowed for your AWS
        /// account.
        /// 
        /// 
        /// <para>
        /// Your AWS account comes with default limits on resources for Auto Scaling. There is
        /// a default limit of <code>20</code> Auto Scaling groups and <code>100</code> launch
        /// configurations per region.
        /// </para>
        /// 
        /// <para>
        /// If you reach the limits for the number of Auto Scaling groups or the launch configurations,
        /// you can go to the <a href="https://aws.amazon.com/support/">Support Center</a> and
        /// place a request to raise the limits.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by AutoScaling.</returns>
		public DescribeAccountLimitsResponse DescribeAccountLimits()
        {
            return this.DescribeAccountLimits(new DescribeAccountLimitsRequest());
        }
 
        /// <summary>
        /// Returns the limits for the Auto Scaling resources currently allowed for your AWS
        /// account.
        /// 
        /// 
        /// <para>
        /// Your AWS account comes with default limits on resources for Auto Scaling. There is
        /// a default limit of <code>20</code> Auto Scaling groups and <code>100</code> launch
        /// configurations per region.
        /// </para>
        /// 
        /// <para>
        /// If you reach the limits for the number of Auto Scaling groups or the launch configurations,
        /// you can go to the <a href="https://aws.amazon.com/support/">Support Center</a> and
        /// place a request to raise the limits.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by AutoScaling.</returns>
		public DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request)
        {
            var task = DescribeAccountLimitsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountLimits operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeAccountLimits"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(DescribeAccountLimitsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAccountLimitsRequestMarshaller();
            var unmarshaller = DescribeAccountLimitsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeAccountLimitsRequest, DescribeAccountLimitsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns policy adjustment types for use in the <a>PutScalingPolicy</a> action.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AutoScaling.</returns>
		public DescribeAdjustmentTypesResponse DescribeAdjustmentTypes()
        {
            return this.DescribeAdjustmentTypes(new DescribeAdjustmentTypesRequest());
        }
 
        /// <summary>
        /// Returns policy adjustment types for use in the <a>PutScalingPolicy</a> action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAdjustmentTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AutoScaling.</returns>
		public DescribeAdjustmentTypesResponse DescribeAdjustmentTypes(DescribeAdjustmentTypesRequest request)
        {
            var task = DescribeAdjustmentTypesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAdjustmentTypes operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeAdjustmentTypes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAdjustmentTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeAdjustmentTypesResponse> DescribeAdjustmentTypesAsync(DescribeAdjustmentTypesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAdjustmentTypesRequestMarshaller();
            var unmarshaller = DescribeAdjustmentTypesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeAdjustmentTypesRequest, DescribeAdjustmentTypesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns a full description of each Auto Scaling group in the given list. This includes
        /// all Amazon EC2 instances that are members of the group. If a list of names is not
        /// provided, the service returns the full details of all Auto Scaling groups.
        /// 
        /// 
        /// <para>
        /// This action supports pagination by returning a token if there are more pages to retrieve.
        /// To get the next page, call this action again with the returned token as the <code>NextToken</code>
        /// parameter.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
		public DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups()
        {
            return this.DescribeAutoScalingGroups(new DescribeAutoScalingGroupsRequest());
        }
 
        /// <summary>
        /// Returns a full description of each Auto Scaling group in the given list. This includes
        /// all Amazon EC2 instances that are members of the group. If a list of names is not
        /// provided, the service returns the full details of all Auto Scaling groups.
        /// 
        /// 
        /// <para>
        /// This action supports pagination by returning a token if there are more pages to retrieve.
        /// To get the next page, call this action again with the returned token as the <code>NextToken</code>
        /// parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
		public DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest request)
        {
            var task = DescribeAutoScalingGroupsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingGroups operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeAutoScalingGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeAutoScalingGroupsResponse> DescribeAutoScalingGroupsAsync(DescribeAutoScalingGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAutoScalingGroupsRequestMarshaller();
            var unmarshaller = DescribeAutoScalingGroupsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeAutoScalingGroupsRequest, DescribeAutoScalingGroupsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns a description of each Auto Scaling instance in the <code>InstanceIds</code>
        /// list. If a list is not provided, the service returns the full details of all instances
        /// up to a maximum of 50. By default, the service returns a list of 20 items.
        /// 
        /// 
        /// <para>
        /// This action supports pagination by returning a token if there are more pages to retrieve.
        /// To get the next page, call this action again with the returned token as the <code>NextToken</code>
        /// parameter.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
		public DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances()
        {
            return this.DescribeAutoScalingInstances(new DescribeAutoScalingInstancesRequest());
        }
 
        /// <summary>
        /// Returns a description of each Auto Scaling instance in the <code>InstanceIds</code>
        /// list. If a list is not provided, the service returns the full details of all instances
        /// up to a maximum of 50. By default, the service returns a list of 20 items.
        /// 
        /// 
        /// <para>
        /// This action supports pagination by returning a token if there are more pages to retrieve.
        /// To get the next page, call this action again with the returned token as the <code>NextToken</code>
        /// parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
		public DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest request)
        {
            var task = DescribeAutoScalingInstancesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingInstances operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeAutoScalingInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeAutoScalingInstancesResponse> DescribeAutoScalingInstancesAsync(DescribeAutoScalingInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAutoScalingInstancesRequestMarshaller();
            var unmarshaller = DescribeAutoScalingInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeAutoScalingInstancesRequest, DescribeAutoScalingInstancesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns a list of all notification types that are supported by Auto Scaling.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AutoScaling.</returns>
		public DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes()
        {
            return this.DescribeAutoScalingNotificationTypes(new DescribeAutoScalingNotificationTypesRequest());
        }
 
        /// <summary>
        /// Returns a list of all notification types that are supported by Auto Scaling.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingNotificationTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AutoScaling.</returns>
		public DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes(DescribeAutoScalingNotificationTypesRequest request)
        {
            var task = DescribeAutoScalingNotificationTypesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingNotificationTypes operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeAutoScalingNotificationTypes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingNotificationTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeAutoScalingNotificationTypesResponse> DescribeAutoScalingNotificationTypesAsync(DescribeAutoScalingNotificationTypesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAutoScalingNotificationTypesRequestMarshaller();
            var unmarshaller = DescribeAutoScalingNotificationTypesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeAutoScalingNotificationTypesRequest, DescribeAutoScalingNotificationTypesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns a full description of the launch configurations, or the specified launch
        /// configurations, if they exist.
        /// 
        /// 
        /// <para>
        /// If no name is specified, then the full details of all launch configurations are returned.
        /// 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
		public DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations()
        {
            return this.DescribeLaunchConfigurations(new DescribeLaunchConfigurationsRequest());
        }
 
        /// <summary>
        /// Returns a full description of the launch configurations, or the specified launch
        /// configurations, if they exist.
        /// 
        /// 
        /// <para>
        /// If no name is specified, then the full details of all launch configurations are returned.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
		public DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest request)
        {
            var task = DescribeLaunchConfigurationsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLaunchConfigurations operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeLaunchConfigurations"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeLaunchConfigurationsResponse> DescribeLaunchConfigurationsAsync(DescribeLaunchConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLaunchConfigurationsRequestMarshaller();
            var unmarshaller = DescribeLaunchConfigurationsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeLaunchConfigurationsRequest, DescribeLaunchConfigurationsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Describes the lifecycle hooks that currently belong to the specified Auto Scaling
        /// group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHooks service method.</param>
        /// 
        /// <returns>The response from the DescribeLifecycleHooks service method, as returned by AutoScaling.</returns>
		public DescribeLifecycleHooksResponse DescribeLifecycleHooks(DescribeLifecycleHooksRequest request)
        {
            var task = DescribeLifecycleHooksAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLifecycleHooks operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeLifecycleHooks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHooks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeLifecycleHooksResponse> DescribeLifecycleHooksAsync(DescribeLifecycleHooksRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLifecycleHooksRequestMarshaller();
            var unmarshaller = DescribeLifecycleHooksResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeLifecycleHooksRequest, DescribeLifecycleHooksResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Describes the available types of lifecycle hooks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHookTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeLifecycleHookTypes service method, as returned by AutoScaling.</returns>
		public DescribeLifecycleHookTypesResponse DescribeLifecycleHookTypes(DescribeLifecycleHookTypesRequest request)
        {
            var task = DescribeLifecycleHookTypesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLifecycleHookTypes operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeLifecycleHookTypes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHookTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeLifecycleHookTypesResponse> DescribeLifecycleHookTypesAsync(DescribeLifecycleHookTypesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLifecycleHookTypesRequestMarshaller();
            var unmarshaller = DescribeLifecycleHookTypesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeLifecycleHookTypesRequest, DescribeLifecycleHookTypesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns a list of metrics and a corresponding list of granularities for each metric.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AutoScaling.</returns>
		public DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes()
        {
            return this.DescribeMetricCollectionTypes(new DescribeMetricCollectionTypesRequest());
        }
 
        /// <summary>
        /// Returns a list of metrics and a corresponding list of granularities for each metric.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricCollectionTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AutoScaling.</returns>
		public DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes(DescribeMetricCollectionTypesRequest request)
        {
            var task = DescribeMetricCollectionTypesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMetricCollectionTypes operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeMetricCollectionTypes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricCollectionTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeMetricCollectionTypesResponse> DescribeMetricCollectionTypesAsync(DescribeMetricCollectionTypesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeMetricCollectionTypesRequestMarshaller();
            var unmarshaller = DescribeMetricCollectionTypesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeMetricCollectionTypesRequest, DescribeMetricCollectionTypesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns a list of notification actions associated with Auto Scaling groups for specified
        /// events.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
		public DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations()
        {
            return this.DescribeNotificationConfigurations(new DescribeNotificationConfigurationsRequest());
        }
 
        /// <summary>
        /// Returns a list of notification actions associated with Auto Scaling groups for specified
        /// events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
		public DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest request)
        {
            var task = DescribeNotificationConfigurationsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotificationConfigurations operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeNotificationConfigurations"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurationsAsync(DescribeNotificationConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeNotificationConfigurationsRequestMarshaller();
            var unmarshaller = DescribeNotificationConfigurationsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeNotificationConfigurationsRequest, DescribeNotificationConfigurationsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns descriptions of what each policy does. This action supports pagination. If
        /// the response includes a token, there are more records available. To get the additional
        /// records, repeat the request with the response token as the <code>NextToken</code>
        /// parameter.
        /// </summary>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
		public DescribePoliciesResponse DescribePolicies()
        {
            return this.DescribePolicies(new DescribePoliciesRequest());
        }
 
        /// <summary>
        /// Returns descriptions of what each policy does. This action supports pagination. If
        /// the response includes a token, there are more records available. To get the additional
        /// records, repeat the request with the response token as the <code>NextToken</code>
        /// parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePolicies service method.</param>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
		public DescribePoliciesResponse DescribePolicies(DescribePoliciesRequest request)
        {
            var task = DescribePoliciesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribePolicies operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribePolicies"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribePoliciesResponse> DescribePoliciesAsync(DescribePoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribePoliciesRequestMarshaller();
            var unmarshaller = DescribePoliciesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribePoliciesRequest, DescribePoliciesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns the scaling activities for the specified Auto Scaling group.
        /// 
        /// 
        /// <para>
        /// If the specified <code>ActivityIds</code> list is empty, all the activities from
        /// the past six weeks are returned. Activities are sorted by the start time. Activities
        /// still in progress appear first on the list.
        /// </para>
        /// 
        /// <para>
        /// This action supports pagination. If the response includes a token, there are more
        /// records available. To get the additional records, repeat the request with the response
        /// token as the <code>NextToken</code> parameter.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
		public DescribeScalingActivitiesResponse DescribeScalingActivities()
        {
            return this.DescribeScalingActivities(new DescribeScalingActivitiesRequest());
        }
 
        /// <summary>
        /// Returns the scaling activities for the specified Auto Scaling group.
        /// 
        /// 
        /// <para>
        /// If the specified <code>ActivityIds</code> list is empty, all the activities from
        /// the past six weeks are returned. Activities are sorted by the start time. Activities
        /// still in progress appear first on the list.
        /// </para>
        /// 
        /// <para>
        /// This action supports pagination. If the response includes a token, there are more
        /// records available. To get the additional records, repeat the request with the response
        /// token as the <code>NextToken</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities service method.</param>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
		public DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest request)
        {
            var task = DescribeScalingActivitiesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingActivities operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeScalingActivities"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(DescribeScalingActivitiesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeScalingActivitiesRequestMarshaller();
            var unmarshaller = DescribeScalingActivitiesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeScalingActivitiesRequest, DescribeScalingActivitiesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns scaling process types for use in the <a>ResumeProcesses</a> and <a>SuspendProcesses</a>
        /// actions.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AutoScaling.</returns>
		public DescribeScalingProcessTypesResponse DescribeScalingProcessTypes()
        {
            return this.DescribeScalingProcessTypes(new DescribeScalingProcessTypesRequest());
        }
 
        /// <summary>
        /// Returns scaling process types for use in the <a>ResumeProcesses</a> and <a>SuspendProcesses</a>
        /// actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingProcessTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AutoScaling.</returns>
		public DescribeScalingProcessTypesResponse DescribeScalingProcessTypes(DescribeScalingProcessTypesRequest request)
        {
            var task = DescribeScalingProcessTypesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingProcessTypes operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeScalingProcessTypes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingProcessTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeScalingProcessTypesResponse> DescribeScalingProcessTypesAsync(DescribeScalingProcessTypesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeScalingProcessTypesRequestMarshaller();
            var unmarshaller = DescribeScalingProcessTypesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeScalingProcessTypesRequest, DescribeScalingProcessTypesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Lists all the actions scheduled for your Auto Scaling group that haven't been executed.
        /// To see a list of actions already executed, see the activity record returned in <a>DescribeScalingActivities</a>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
		public DescribeScheduledActionsResponse DescribeScheduledActions()
        {
            return this.DescribeScheduledActions(new DescribeScheduledActionsRequest());
        }
 
        /// <summary>
        /// Lists all the actions scheduled for your Auto Scaling group that haven't been executed.
        /// To see a list of actions already executed, see the activity record returned in <a>DescribeScalingActivities</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions service method.</param>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
		public DescribeScheduledActionsResponse DescribeScheduledActions(DescribeScheduledActionsRequest request)
        {
            var task = DescribeScheduledActionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScheduledActions operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeScheduledActions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeScheduledActionsResponse> DescribeScheduledActionsAsync(DescribeScheduledActionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeScheduledActionsRequestMarshaller();
            var unmarshaller = DescribeScheduledActionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeScheduledActionsRequest, DescribeScheduledActionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Lists the Auto Scaling group tags.
        /// 
        /// 
        /// <para>
        /// You can use filters to limit results when describing tags. For example, you can query
        /// for tags of a particular Auto Scaling group. You can specify multiple values for a
        /// filter. A tag must match at least one of the specified values for it to be included
        /// in the results.
        /// </para>
        /// 
        /// <para>
        /// You can also specify multiple filters. The result includes information for a particular
        /// tag only if it matches all your filters. If there's no match, no special message is
        /// returned.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
		public DescribeTagsResponse DescribeTags()
        {
            return this.DescribeTags(new DescribeTagsRequest());
        }
 
        /// <summary>
        /// Lists the Auto Scaling group tags.
        /// 
        /// 
        /// <para>
        /// You can use filters to limit results when describing tags. For example, you can query
        /// for tags of a particular Auto Scaling group. You can specify multiple values for a
        /// filter. A tag must match at least one of the specified values for it to be included
        /// in the results.
        /// </para>
        /// 
        /// <para>
        /// You can also specify multiple filters. The result includes information for a particular
        /// tag only if it matches all your filters. If there's no match, no special message is
        /// returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is invalid.
        /// </exception>
		public DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var task = DescribeTagsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeTags"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeTagsRequest, DescribeTagsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns a list of all termination policies supported by Auto Scaling.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AutoScaling.</returns>
		public DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes()
        {
            return this.DescribeTerminationPolicyTypes(new DescribeTerminationPolicyTypesRequest());
        }
 
        /// <summary>
        /// Returns a list of all termination policies supported by Auto Scaling.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTerminationPolicyTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AutoScaling.</returns>
		public DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes(DescribeTerminationPolicyTypesRequest request)
        {
            var task = DescribeTerminationPolicyTypesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTerminationPolicyTypes operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DescribeTerminationPolicyTypes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTerminationPolicyTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeTerminationPolicyTypesResponse> DescribeTerminationPolicyTypesAsync(DescribeTerminationPolicyTypesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTerminationPolicyTypesRequestMarshaller();
            var unmarshaller = DescribeTerminationPolicyTypesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeTerminationPolicyTypesRequest, DescribeTerminationPolicyTypesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Using <code>DetachInstances</code>, you can remove an instance from an Auto Scaling
        /// group. After the instances are detached, you can manage them independently from the
        /// rest of the Auto Scaling group.
        /// 
        /// 
        /// <para>
        /// To learn more about detaching instances, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/detach-instance-asg.html">Detach
        /// Amazon EC2 Instances From Your Auto Scaling Group</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachInstances service method.</param>
        /// 
        /// <returns>The response from the DetachInstances service method, as returned by AutoScaling.</returns>
		public DetachInstancesResponse DetachInstances(DetachInstancesRequest request)
        {
            var task = DetachInstancesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DetachInstances operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DetachInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DetachInstancesResponse> DetachInstancesAsync(DetachInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachInstancesRequestMarshaller();
            var unmarshaller = DetachInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DetachInstancesRequest, DetachInstancesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Disables monitoring of group metrics for the Auto Scaling group specified in <code>AutoScalingGroupName</code>.
        /// You can specify the list of affected metrics with the <code>Metrics</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableMetricsCollection service method.</param>
        /// 
        /// <returns>The response from the DisableMetricsCollection service method, as returned by AutoScaling.</returns>
		public DisableMetricsCollectionResponse DisableMetricsCollection(DisableMetricsCollectionRequest request)
        {
            var task = DisableMetricsCollectionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DisableMetricsCollection operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.DisableMetricsCollection"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableMetricsCollection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DisableMetricsCollectionResponse> DisableMetricsCollectionAsync(DisableMetricsCollectionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableMetricsCollectionRequestMarshaller();
            var unmarshaller = DisableMetricsCollectionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DisableMetricsCollectionRequest, DisableMetricsCollectionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Enables monitoring of group metrics for the Auto Scaling group specified in <code>AutoScalingGroupName</code>.
        /// You can specify the list of enabled metrics with the <code>Metrics</code> parameter.
        /// 
        /// 
        /// 
        /// <para>
        /// Auto Scaling metrics collection can be turned on only if the <code>InstanceMonitoring</code>
        /// flag, in the Auto Scaling group's launch configuration, is set to <code>True</code>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMetricsCollection service method.</param>
        /// 
        /// <returns>The response from the EnableMetricsCollection service method, as returned by AutoScaling.</returns>
		public EnableMetricsCollectionResponse EnableMetricsCollection(EnableMetricsCollectionRequest request)
        {
            var task = EnableMetricsCollectionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the EnableMetricsCollection operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.EnableMetricsCollection"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableMetricsCollection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<EnableMetricsCollectionResponse> EnableMetricsCollectionAsync(EnableMetricsCollectionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableMetricsCollectionRequestMarshaller();
            var unmarshaller = EnableMetricsCollectionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, EnableMetricsCollectionRequest, EnableMetricsCollectionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Move instances in an Auto Scaling group into a Standby mode.
        /// 
        /// 
        /// <para>
        /// To learn more about how to put instances into a Standby mode, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingInServiceState.html">Auto
        /// Scaling InService State</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnterStandby service method.</param>
        /// 
        /// <returns>The response from the EnterStandby service method, as returned by AutoScaling.</returns>
		public EnterStandbyResponse EnterStandby(EnterStandbyRequest request)
        {
            var task = EnterStandbyAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the EnterStandby operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.EnterStandby"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnterStandby operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<EnterStandbyResponse> EnterStandbyAsync(EnterStandbyRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnterStandbyRequestMarshaller();
            var unmarshaller = EnterStandbyResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, EnterStandbyRequest, EnterStandbyResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Executes the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecutePolicy service method.</param>
        /// 
        /// <returns>The response from the ExecutePolicy service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// You cannot delete an Auto Scaling group while there are scaling activities in progress
        /// for that group.
        /// </exception>
		public ExecutePolicyResponse ExecutePolicy(ExecutePolicyRequest request)
        {
            var task = ExecutePolicyAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ExecutePolicy operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.ExecutePolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecutePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ExecutePolicyResponse> ExecutePolicyAsync(ExecutePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ExecutePolicyRequestMarshaller();
            var unmarshaller = ExecutePolicyResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ExecutePolicyRequest, ExecutePolicyResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Move an instance out of Standby mode.
        /// 
        /// 
        /// <para>
        /// To learn more about how to put instances that are in a Standby mode back into service,
        /// see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingInServiceState.html">Auto
        /// Scaling InService State</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExitStandby service method.</param>
        /// 
        /// <returns>The response from the ExitStandby service method, as returned by AutoScaling.</returns>
		public ExitStandbyResponse ExitStandby(ExitStandbyRequest request)
        {
            var task = ExitStandbyAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ExitStandby operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.ExitStandby"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExitStandby operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ExitStandbyResponse> ExitStandbyAsync(ExitStandbyRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ExitStandbyRequestMarshaller();
            var unmarshaller = ExitStandbyResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ExitStandbyRequest, ExitStandbyResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Creates or updates a lifecycle hook for an Auto Scaling Group.
        /// 
        /// 
        /// <para>
        /// A lifecycle hook tells Auto Scaling that you want to perform an action on an instance
        /// that is not actively in service; for example, either when the instance launches or
        /// before the instance terminates.
        /// </para>
        /// 
        /// <para>
        /// This operation is a part of the basic sequence for adding a lifecycle hook to an
        /// Auto Scaling group:
        /// </para>
        /// <ol> <li> Create a notification target. A target can be either an Amazon SQS queue
        /// or an Amazon SNS topic. </li> <li> Create an IAM role. This role allows Auto Scaling
        /// to publish lifecycle notifications to the designated SQS queue or SNS topic. </li>
        /// <li> <b>Create the lifecycle hook. You can create a hook that acts when instances
        /// launch or when instances terminate.</b> </li> <li> If necessary, record the lifecycle
        /// action heartbeat to keep the instance in a pending state. </li> <li> Complete the
        /// lifecycle action. </li> </ol>
        /// <para>
        /// To learn more, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingPendingState.html">Auto
        /// Scaling Pending State</a> and <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingTerminatingState.html">Auto
        /// Scaling Terminating State</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleHook service method.</param>
        /// 
        /// <returns>The response from the PutLifecycleHook service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException">
        /// The quota for capacity groups or launch configurations for this customer has already
        /// been reached.
        /// </exception>
		public PutLifecycleHookResponse PutLifecycleHook(PutLifecycleHookRequest request)
        {
            var task = PutLifecycleHookAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the PutLifecycleHook operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.PutLifecycleHook"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleHook operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<PutLifecycleHookResponse> PutLifecycleHookAsync(PutLifecycleHookRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutLifecycleHookRequestMarshaller();
            var unmarshaller = PutLifecycleHookResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PutLifecycleHookRequest, PutLifecycleHookResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Configures an Auto Scaling group to send notifications when specified events take
        /// place. Subscribers to this topic can have messages for events delivered to an endpoint
        /// such as a web server or email address.
        /// 
        /// 
        /// <para>
        /// For more information see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/ASGettingNotifications.html">Get
        /// Email Notifications When Your Auto Scaling Group Changes</a>
        /// </para>
        /// 
        /// <para>
        /// A new <code>PutNotificationConfiguration</code> overwrites an existing configuration.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutNotificationConfiguration service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException">
        /// The quota for capacity groups or launch configurations for this customer has already
        /// been reached.
        /// </exception>
		public PutNotificationConfigurationResponse PutNotificationConfiguration(PutNotificationConfigurationRequest request)
        {
            var task = PutNotificationConfigurationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the PutNotificationConfiguration operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.PutNotificationConfiguration"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<PutNotificationConfigurationResponse> PutNotificationConfigurationAsync(PutNotificationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutNotificationConfigurationRequestMarshaller();
            var unmarshaller = PutNotificationConfigurationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PutNotificationConfigurationRequest, PutNotificationConfigurationResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Creates or updates a policy for an Auto Scaling group. To update an existing policy,
        /// use the existing policy name and set the parameter(s) you want to change. Any existing
        /// parameter not changed in an update to an existing policy is not changed in this update
        /// request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy service method.</param>
        /// 
        /// <returns>The response from the PutScalingPolicy service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException">
        /// The quota for capacity groups or launch configurations for this customer has already
        /// been reached.
        /// </exception>
		public PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest request)
        {
            var task = PutScalingPolicyAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the PutScalingPolicy operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.PutScalingPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutScalingPolicyRequestMarshaller();
            var unmarshaller = PutScalingPolicyResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PutScalingPolicyRequest, PutScalingPolicyResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Creates or updates a scheduled scaling action for an Auto Scaling group. When updating
        /// a scheduled scaling action, if you leave a parameter unspecified, the corresponding
        /// value remains unchanged in the affected Auto Scaling group.
        /// 
        /// 
        /// <para>
        /// For information on creating or updating a scheduled action for your Auto Scaling group,
        /// see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/schedule_time.html">Scale
        /// Based on a Schedule</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction service method.</param>
        /// 
        /// <returns>The response from the PutScheduledUpdateGroupAction service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.AlreadyExistsException">
        /// The named Auto Scaling group or launch configuration already exists.
        /// </exception>
        /// <exception cref="T:Amazon.AutoScaling.Model.LimitExceededException">
        /// The quota for capacity groups or launch configurations for this customer has already
        /// been reached.
        /// </exception>
		public PutScheduledUpdateGroupActionResponse PutScheduledUpdateGroupAction(PutScheduledUpdateGroupActionRequest request)
        {
            var task = PutScheduledUpdateGroupActionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the PutScheduledUpdateGroupAction operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.PutScheduledUpdateGroupAction"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<PutScheduledUpdateGroupActionResponse> PutScheduledUpdateGroupActionAsync(PutScheduledUpdateGroupActionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutScheduledUpdateGroupActionRequestMarshaller();
            var unmarshaller = PutScheduledUpdateGroupActionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PutScheduledUpdateGroupActionRequest, PutScheduledUpdateGroupActionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Records a heartbeat for the lifecycle action associated with a specific token. This
        /// extends the timeout by the length of time defined by the <code>HeartbeatTimeout</code>
        /// parameter of the <a>PutLifecycleHook</a> operation.
        /// 
        /// 
        /// <para>
        /// This operation is a part of the basic sequence for adding a lifecycle hook to an
        /// Auto Scaling group:
        /// </para>
        /// <ol> <li> Create a notification target. A target can be either an Amazon SQS queue
        /// or an Amazon SNS topic. </li> <li> Create an IAM role. This role allows Auto Scaling
        /// to publish lifecycle notifications to the designated SQS queue or SNS topic. </li>
        /// <li> Create the lifecycle hook. You can create a hook that acts when instances launch
        /// or when instances terminate. </li> <li> <b>If necessary, record the lifecycle action
        /// heartbeat to keep the instance in a pending state.</b> </li> <li> Complete the lifecycle
        /// action. </li> </ol>
        /// <para>
        /// To learn more, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingPendingState.html">Auto
        /// Scaling Pending State</a> and <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingTerminatingState.html">Auto
        /// Scaling Terminating State</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecordLifecycleActionHeartbeat service method.</param>
        /// 
        /// <returns>The response from the RecordLifecycleActionHeartbeat service method, as returned by AutoScaling.</returns>
		public RecordLifecycleActionHeartbeatResponse RecordLifecycleActionHeartbeat(RecordLifecycleActionHeartbeatRequest request)
        {
            var task = RecordLifecycleActionHeartbeatAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RecordLifecycleActionHeartbeat operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.RecordLifecycleActionHeartbeat"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecordLifecycleActionHeartbeat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<RecordLifecycleActionHeartbeatResponse> RecordLifecycleActionHeartbeatAsync(RecordLifecycleActionHeartbeatRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RecordLifecycleActionHeartbeatRequestMarshaller();
            var unmarshaller = RecordLifecycleActionHeartbeatResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RecordLifecycleActionHeartbeatRequest, RecordLifecycleActionHeartbeatResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Resumes all suspended Auto Scaling processes for an Auto Scaling group. For information
        /// on suspending and resuming Auto Scaling process, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_SuspendResume.html">Suspend
        /// and Resume Auto Scaling Process</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeProcesses service method.</param>
        /// 
        /// <returns>The response from the ResumeProcesses service method, as returned by AutoScaling.</returns>
		public ResumeProcessesResponse ResumeProcesses(ResumeProcessesRequest request)
        {
            var task = ResumeProcessesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ResumeProcesses operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.ResumeProcesses"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResumeProcesses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ResumeProcessesResponse> ResumeProcessesAsync(ResumeProcessesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResumeProcessesRequestMarshaller();
            var unmarshaller = ResumeProcessesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ResumeProcessesRequest, ResumeProcessesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Sets the desired size of the specified <a>AutoScalingGroup</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDesiredCapacity service method.</param>
        /// 
        /// <returns>The response from the SetDesiredCapacity service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// You cannot delete an Auto Scaling group while there are scaling activities in progress
        /// for that group.
        /// </exception>
		public SetDesiredCapacityResponse SetDesiredCapacity(SetDesiredCapacityRequest request)
        {
            var task = SetDesiredCapacityAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the SetDesiredCapacity operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.SetDesiredCapacity"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDesiredCapacity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<SetDesiredCapacityResponse> SetDesiredCapacityAsync(SetDesiredCapacityRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetDesiredCapacityRequestMarshaller();
            var unmarshaller = SetDesiredCapacityResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SetDesiredCapacityRequest, SetDesiredCapacityResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Sets the health status of a specified instance that belongs to any of your Auto Scaling
        /// groups.
        /// 
        /// 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/as-configure-healthcheck.html">Configure
        /// Health Checks for Your Auto Scaling group</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceHealth service method.</param>
        /// 
        /// <returns>The response from the SetInstanceHealth service method, as returned by AutoScaling.</returns>
		public SetInstanceHealthResponse SetInstanceHealth(SetInstanceHealthRequest request)
        {
            var task = SetInstanceHealthAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the SetInstanceHealth operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.SetInstanceHealth"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceHealth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<SetInstanceHealthResponse> SetInstanceHealthAsync(SetInstanceHealthRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetInstanceHealthRequestMarshaller();
            var unmarshaller = SetInstanceHealthResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SetInstanceHealthRequest, SetInstanceHealthResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Suspends Auto Scaling processes for an Auto Scaling group. To suspend specific process
        /// types, specify them by name with the <code>ScalingProcesses.member.N</code> parameter.
        /// To suspend all process types, omit the <code>ScalingProcesses.member.N</code> parameter.
        /// 
        /// 
        /// <important>
        /// <para>
        /// Suspending either of the two primary process types, <code>Launch</code> or <code>Terminate</code>,
        /// can prevent other process types from functioning properly.
        /// </para>
        /// </important>
        /// <para>
        /// To resume processes that have been suspended, use <a>ResumeProcesses</a> For more
        /// information on suspending and resuming Auto Scaling process, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US_SuspendResume.html">Suspend
        /// and Resume Auto Scaling Process</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SuspendProcesses service method.</param>
        /// 
        /// <returns>The response from the SuspendProcesses service method, as returned by AutoScaling.</returns>
		public SuspendProcessesResponse SuspendProcesses(SuspendProcessesRequest request)
        {
            var task = SuspendProcessesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the SuspendProcesses operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.SuspendProcesses"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SuspendProcesses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<SuspendProcessesResponse> SuspendProcessesAsync(SuspendProcessesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SuspendProcessesRequestMarshaller();
            var unmarshaller = SuspendProcessesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SuspendProcessesRequest, SuspendProcessesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Terminates the specified instance. Optionally, the desired group size can be adjusted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstanceInAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the TerminateInstanceInAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// You cannot delete an Auto Scaling group while there are scaling activities in progress
        /// for that group.
        /// </exception>
		public TerminateInstanceInAutoScalingGroupResponse TerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest request)
        {
            var task = TerminateInstanceInAutoScalingGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the TerminateInstanceInAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.TerminateInstanceInAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstanceInAutoScalingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<TerminateInstanceInAutoScalingGroupResponse> TerminateInstanceInAutoScalingGroupAsync(TerminateInstanceInAutoScalingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TerminateInstanceInAutoScalingGroupRequestMarshaller();
            var unmarshaller = TerminateInstanceInAutoScalingGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, TerminateInstanceInAutoScalingGroupRequest, TerminateInstanceInAutoScalingGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Updates the configuration for the specified <a>AutoScalingGroup</a>.
        /// 
        /// 
        /// <para>
        /// The new settings are registered upon the completion of this call. Any launch configuration
        /// settings take effect on any triggers after this call returns. Scaling activities that
        /// are currently in progress aren't affected.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoScalingGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateAutoScalingGroup service method, as returned by AutoScaling.</returns>
        /// <exception cref="T:Amazon.AutoScaling.Model.ScalingActivityInProgressException">
        /// You cannot delete an Auto Scaling group while there are scaling activities in progress
        /// for that group.
        /// </exception>
		public UpdateAutoScalingGroupResponse UpdateAutoScalingGroup(UpdateAutoScalingGroupRequest request)
        {
            var task = UpdateAutoScalingGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAutoScalingGroup operation.
        /// <seealso cref="Amazon.AutoScaling.IAmazonAutoScaling.UpdateAutoScalingGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoScalingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<UpdateAutoScalingGroupResponse> UpdateAutoScalingGroupAsync(UpdateAutoScalingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateAutoScalingGroupRequestMarshaller();
            var unmarshaller = UpdateAutoScalingGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, UpdateAutoScalingGroupRequest, UpdateAutoScalingGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
    }
}
