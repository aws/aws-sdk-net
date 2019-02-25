/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AutoScaling.Model;
using Amazon.AutoScaling.Model.Internal.MarshallTransformations;
using Amazon.AutoScaling.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AutoScaling
{
    /// <summary>
    /// Implementation for accessing AutoScaling
    ///
    /// Amazon EC2 Auto Scaling 
    /// <para>
    /// Amazon EC2 Auto Scaling is designed to automatically launch or terminate EC2 instances
    /// based on user-defined policies, schedules, and health checks. Use this service with
    /// AWS Auto Scaling, Amazon CloudWatch, and Elastic Load Balancing.
    /// </para>
    ///  
    /// <para>
    /// For more information, including information about granting IAM users required permissions
    /// for Amazon EC2 Auto Scaling actions, see the <a href="http://docs.aws.amazon.com/autoscaling/ec2/userguide/what-is-amazon-ec2-auto-scaling.html">Amazon
    /// EC2 Auto Scaling User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonAutoScalingClient : AmazonServiceClient, IAmazonAutoScaling
    {
        private static IServiceMetadata serviceMetadata = new AmazonAutoScalingMetadata();
        
        #region Constructors

#if CORECLR
    
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAutoScalingConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAutoScalingConfig{RegionEndpoint = region}) { }

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
        /// <param name="config">The AmazonAutoScalingClient Configuration Object</param>
        public AmazonAutoScalingClient(AmazonAutoScalingConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

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
            : this(credentials, new AmazonAutoScalingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingClient with AWS Credentials and an
        /// AmazonAutoScalingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAutoScalingClient Configuration Object</param>
        public AmazonAutoScalingClient(AWSCredentials credentials, AmazonAutoScalingConfig clientConfig)
            : base(credentials, clientConfig)
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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAutoScalingConfig{RegionEndpoint = region})
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


        #region  AttachInstances

        internal virtual AttachInstancesResponse AttachInstances(AttachInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachInstancesResponseUnmarshaller.Instance;

            return Invoke<AttachInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachInstances">REST API Reference for AttachInstances Operation</seealso>
        public virtual Task<AttachInstancesResponse> AttachInstancesAsync(AttachInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<AttachInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachLoadBalancers

        internal virtual AttachLoadBalancersResponse AttachLoadBalancers(AttachLoadBalancersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachLoadBalancersResponseUnmarshaller.Instance;

            return Invoke<AttachLoadBalancersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachLoadBalancers">REST API Reference for AttachLoadBalancers Operation</seealso>
        public virtual Task<AttachLoadBalancersResponse> AttachLoadBalancersAsync(AttachLoadBalancersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachLoadBalancersResponseUnmarshaller.Instance;

            return InvokeAsync<AttachLoadBalancersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachLoadBalancerTargetGroups

        internal virtual AttachLoadBalancerTargetGroupsResponse AttachLoadBalancerTargetGroups(AttachLoadBalancerTargetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachLoadBalancerTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachLoadBalancerTargetGroupsResponseUnmarshaller.Instance;

            return Invoke<AttachLoadBalancerTargetGroupsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachLoadBalancerTargetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerTargetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/AttachLoadBalancerTargetGroups">REST API Reference for AttachLoadBalancerTargetGroups Operation</seealso>
        public virtual Task<AttachLoadBalancerTargetGroupsResponse> AttachLoadBalancerTargetGroupsAsync(AttachLoadBalancerTargetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachLoadBalancerTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachLoadBalancerTargetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<AttachLoadBalancerTargetGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDeleteScheduledAction

        internal virtual BatchDeleteScheduledActionResponse BatchDeleteScheduledAction(BatchDeleteScheduledActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteScheduledActionResponseUnmarshaller.Instance;

            return Invoke<BatchDeleteScheduledActionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteScheduledAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/BatchDeleteScheduledAction">REST API Reference for BatchDeleteScheduledAction Operation</seealso>
        public virtual Task<BatchDeleteScheduledActionResponse> BatchDeleteScheduledActionAsync(BatchDeleteScheduledActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDeleteScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDeleteScheduledActionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDeleteScheduledActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchPutScheduledUpdateGroupAction

        internal virtual BatchPutScheduledUpdateGroupActionResponse BatchPutScheduledUpdateGroupAction(BatchPutScheduledUpdateGroupActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutScheduledUpdateGroupActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutScheduledUpdateGroupActionResponseUnmarshaller.Instance;

            return Invoke<BatchPutScheduledUpdateGroupActionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BatchPutScheduledUpdateGroupAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchPutScheduledUpdateGroupAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/BatchPutScheduledUpdateGroupAction">REST API Reference for BatchPutScheduledUpdateGroupAction Operation</seealso>
        public virtual Task<BatchPutScheduledUpdateGroupActionResponse> BatchPutScheduledUpdateGroupActionAsync(BatchPutScheduledUpdateGroupActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchPutScheduledUpdateGroupActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchPutScheduledUpdateGroupActionResponseUnmarshaller.Instance;

            return InvokeAsync<BatchPutScheduledUpdateGroupActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CompleteLifecycleAction

        internal virtual CompleteLifecycleActionResponse CompleteLifecycleAction(CompleteLifecycleActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteLifecycleActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteLifecycleActionResponseUnmarshaller.Instance;

            return Invoke<CompleteLifecycleActionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CompleteLifecycleAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteLifecycleAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CompleteLifecycleAction">REST API Reference for CompleteLifecycleAction Operation</seealso>
        public virtual Task<CompleteLifecycleActionResponse> CompleteLifecycleActionAsync(CompleteLifecycleActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteLifecycleActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteLifecycleActionResponseUnmarshaller.Instance;

            return InvokeAsync<CompleteLifecycleActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAutoScalingGroup

        internal virtual CreateAutoScalingGroupResponse CreateAutoScalingGroup(CreateAutoScalingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAutoScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutoScalingGroupResponseUnmarshaller.Instance;

            return Invoke<CreateAutoScalingGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAutoScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAutoScalingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CreateAutoScalingGroup">REST API Reference for CreateAutoScalingGroup Operation</seealso>
        public virtual Task<CreateAutoScalingGroupResponse> CreateAutoScalingGroupAsync(CreateAutoScalingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAutoScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAutoScalingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAutoScalingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLaunchConfiguration

        internal virtual CreateLaunchConfigurationResponse CreateLaunchConfiguration(CreateLaunchConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLaunchConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateLaunchConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CreateLaunchConfiguration">REST API Reference for CreateLaunchConfiguration Operation</seealso>
        public virtual Task<CreateLaunchConfigurationResponse> CreateLaunchConfigurationAsync(CreateLaunchConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLaunchConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLaunchConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateOrUpdateTags

        internal virtual CreateOrUpdateTagsResponse CreateOrUpdateTags(CreateOrUpdateTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOrUpdateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOrUpdateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateOrUpdateTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateOrUpdateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOrUpdateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/CreateOrUpdateTags">REST API Reference for CreateOrUpdateTags Operation</seealso>
        public virtual Task<CreateOrUpdateTagsResponse> CreateOrUpdateTagsAsync(CreateOrUpdateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateOrUpdateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOrUpdateTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOrUpdateTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAutoScalingGroup

        internal virtual DeleteAutoScalingGroupResponse DeleteAutoScalingGroup(DeleteAutoScalingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAutoScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutoScalingGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteAutoScalingGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAutoScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAutoScalingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteAutoScalingGroup">REST API Reference for DeleteAutoScalingGroup Operation</seealso>
        public virtual Task<DeleteAutoScalingGroupResponse> DeleteAutoScalingGroupAsync(DeleteAutoScalingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAutoScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAutoScalingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAutoScalingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLaunchConfiguration

        internal virtual DeleteLaunchConfigurationResponse DeleteLaunchConfiguration(DeleteLaunchConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLaunchConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteLaunchConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteLaunchConfiguration">REST API Reference for DeleteLaunchConfiguration Operation</seealso>
        public virtual Task<DeleteLaunchConfigurationResponse> DeleteLaunchConfigurationAsync(DeleteLaunchConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLaunchConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLaunchConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLaunchConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLifecycleHook

        internal virtual DeleteLifecycleHookResponse DeleteLifecycleHook(DeleteLifecycleHookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLifecycleHookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecycleHookResponseUnmarshaller.Instance;

            return Invoke<DeleteLifecycleHookResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLifecycleHook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleHook operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteLifecycleHook">REST API Reference for DeleteLifecycleHook Operation</seealso>
        public virtual Task<DeleteLifecycleHookResponse> DeleteLifecycleHookAsync(DeleteLifecycleHookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLifecycleHookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecycleHookResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLifecycleHookResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNotificationConfiguration

        internal virtual DeleteNotificationConfigurationResponse DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteNotificationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotificationConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteNotificationConfiguration">REST API Reference for DeleteNotificationConfiguration Operation</seealso>
        public virtual Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfigurationAsync(DeleteNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotificationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNotificationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePolicy

        internal virtual DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteScheduledAction

        internal virtual DeleteScheduledActionResponse DeleteScheduledAction(DeleteScheduledActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledActionResponseUnmarshaller.Instance;

            return Invoke<DeleteScheduledActionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        public virtual Task<DeleteScheduledActionResponse> DeleteScheduledActionAsync(DeleteScheduledActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledActionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScheduledActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags

        internal virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountLimits

        internal virtual DescribeAccountLimitsResponse DescribeAccountLimits()
        {
            return DescribeAccountLimits(new DescribeAccountLimitsRequest());
        }
        internal virtual DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountLimitsResponse>(request, options);
        }


        /// <summary>
        /// Describes the current Auto Scaling resource limits for your AWS account.
        /// 
        ///  
        /// <para>
        /// For information about requesting an increase in these limits, see <a href="http://docs.aws.amazon.com/autoscaling/ec2/userguide/as-account-limits.html">Amazon
        /// EC2 Auto Scaling Limits</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public virtual Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAccountLimitsAsync(new DescribeAccountLimitsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public virtual Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(DescribeAccountLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountLimitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAdjustmentTypes

        internal virtual DescribeAdjustmentTypesResponse DescribeAdjustmentTypes()
        {
            return DescribeAdjustmentTypes(new DescribeAdjustmentTypesRequest());
        }
        internal virtual DescribeAdjustmentTypesResponse DescribeAdjustmentTypes(DescribeAdjustmentTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAdjustmentTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAdjustmentTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeAdjustmentTypesResponse>(request, options);
        }


        /// <summary>
        /// Describes the policy adjustment types for use with <a>PutScalingPolicy</a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAdjustmentTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAdjustmentTypes">REST API Reference for DescribeAdjustmentTypes Operation</seealso>
        public virtual Task<DescribeAdjustmentTypesResponse> DescribeAdjustmentTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAdjustmentTypesAsync(new DescribeAdjustmentTypesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAdjustmentTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAdjustmentTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAdjustmentTypes">REST API Reference for DescribeAdjustmentTypes Operation</seealso>
        public virtual Task<DescribeAdjustmentTypesResponse> DescribeAdjustmentTypesAsync(DescribeAdjustmentTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAdjustmentTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAdjustmentTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAdjustmentTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAutoScalingGroups

        internal virtual DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups()
        {
            return DescribeAutoScalingGroups(new DescribeAutoScalingGroupsRequest());
        }
        internal virtual DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutoScalingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoScalingGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeAutoScalingGroupsResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more Auto Scaling groups.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutoScalingGroups service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingGroups">REST API Reference for DescribeAutoScalingGroups Operation</seealso>
        public virtual Task<DescribeAutoScalingGroupsResponse> DescribeAutoScalingGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAutoScalingGroupsAsync(new DescribeAutoScalingGroupsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingGroups">REST API Reference for DescribeAutoScalingGroups Operation</seealso>
        public virtual Task<DescribeAutoScalingGroupsResponse> DescribeAutoScalingGroupsAsync(DescribeAutoScalingGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutoScalingGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoScalingGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAutoScalingGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAutoScalingInstances

        internal virtual DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances()
        {
            return DescribeAutoScalingInstances(new DescribeAutoScalingInstancesRequest());
        }
        internal virtual DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutoScalingInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoScalingInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeAutoScalingInstancesResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more Auto Scaling instances.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutoScalingInstances service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingInstances">REST API Reference for DescribeAutoScalingInstances Operation</seealso>
        public virtual Task<DescribeAutoScalingInstancesResponse> DescribeAutoScalingInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAutoScalingInstancesAsync(new DescribeAutoScalingInstancesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingInstances">REST API Reference for DescribeAutoScalingInstances Operation</seealso>
        public virtual Task<DescribeAutoScalingInstancesResponse> DescribeAutoScalingInstancesAsync(DescribeAutoScalingInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutoScalingInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoScalingInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAutoScalingInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAutoScalingNotificationTypes

        internal virtual DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes()
        {
            return DescribeAutoScalingNotificationTypes(new DescribeAutoScalingNotificationTypesRequest());
        }
        internal virtual DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes(DescribeAutoScalingNotificationTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutoScalingNotificationTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoScalingNotificationTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeAutoScalingNotificationTypesResponse>(request, options);
        }


        /// <summary>
        /// Describes the notification types that are supported by Amazon EC2 Auto Scaling.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAutoScalingNotificationTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingNotificationTypes">REST API Reference for DescribeAutoScalingNotificationTypes Operation</seealso>
        public virtual Task<DescribeAutoScalingNotificationTypesResponse> DescribeAutoScalingNotificationTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAutoScalingNotificationTypesAsync(new DescribeAutoScalingNotificationTypesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAutoScalingNotificationTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAutoScalingNotificationTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeAutoScalingNotificationTypes">REST API Reference for DescribeAutoScalingNotificationTypes Operation</seealso>
        public virtual Task<DescribeAutoScalingNotificationTypesResponse> DescribeAutoScalingNotificationTypesAsync(DescribeAutoScalingNotificationTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAutoScalingNotificationTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAutoScalingNotificationTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAutoScalingNotificationTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLaunchConfigurations

        internal virtual DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations()
        {
            return DescribeLaunchConfigurations(new DescribeLaunchConfigurationsRequest());
        }
        internal virtual DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLaunchConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLaunchConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeLaunchConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more launch configurations.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLaunchConfigurations">REST API Reference for DescribeLaunchConfigurations Operation</seealso>
        public virtual Task<DescribeLaunchConfigurationsResponse> DescribeLaunchConfigurationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeLaunchConfigurationsAsync(new DescribeLaunchConfigurationsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLaunchConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLaunchConfigurations">REST API Reference for DescribeLaunchConfigurations Operation</seealso>
        public virtual Task<DescribeLaunchConfigurationsResponse> DescribeLaunchConfigurationsAsync(DescribeLaunchConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLaunchConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLaunchConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLaunchConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLifecycleHooks

        internal virtual DescribeLifecycleHooksResponse DescribeLifecycleHooks(DescribeLifecycleHooksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLifecycleHooksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLifecycleHooksResponseUnmarshaller.Instance;

            return Invoke<DescribeLifecycleHooksResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLifecycleHooks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHooks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLifecycleHooks">REST API Reference for DescribeLifecycleHooks Operation</seealso>
        public virtual Task<DescribeLifecycleHooksResponse> DescribeLifecycleHooksAsync(DescribeLifecycleHooksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLifecycleHooksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLifecycleHooksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLifecycleHooksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLifecycleHookTypes

        internal virtual DescribeLifecycleHookTypesResponse DescribeLifecycleHookTypes(DescribeLifecycleHookTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLifecycleHookTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLifecycleHookTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeLifecycleHookTypesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLifecycleHookTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLifecycleHookTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLifecycleHookTypes">REST API Reference for DescribeLifecycleHookTypes Operation</seealso>
        public virtual Task<DescribeLifecycleHookTypesResponse> DescribeLifecycleHookTypesAsync(DescribeLifecycleHookTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLifecycleHookTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLifecycleHookTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLifecycleHookTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBalancers

        internal virtual DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancersResponseUnmarshaller.Instance;

            return Invoke<DescribeLoadBalancersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLoadBalancers">REST API Reference for DescribeLoadBalancers Operation</seealso>
        public virtual Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoadBalancersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBalancerTargetGroups

        internal virtual DescribeLoadBalancerTargetGroupsResponse DescribeLoadBalancerTargetGroups(DescribeLoadBalancerTargetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancerTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancerTargetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeLoadBalancerTargetGroupsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerTargetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerTargetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeLoadBalancerTargetGroups">REST API Reference for DescribeLoadBalancerTargetGroups Operation</seealso>
        public virtual Task<DescribeLoadBalancerTargetGroupsResponse> DescribeLoadBalancerTargetGroupsAsync(DescribeLoadBalancerTargetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancerTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancerTargetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoadBalancerTargetGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMetricCollectionTypes

        internal virtual DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes()
        {
            return DescribeMetricCollectionTypes(new DescribeMetricCollectionTypesRequest());
        }
        internal virtual DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes(DescribeMetricCollectionTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMetricCollectionTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetricCollectionTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeMetricCollectionTypesResponse>(request, options);
        }


        /// <summary>
        /// Describes the available CloudWatch metrics for Amazon EC2 Auto Scaling.
        /// 
        ///  
        /// <para>
        /// The <code>GroupStandbyInstances</code> metric is not returned by default. You must
        /// explicitly request this metric when calling <a>EnableMetricsCollection</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeMetricCollectionTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeMetricCollectionTypes">REST API Reference for DescribeMetricCollectionTypes Operation</seealso>
        public virtual Task<DescribeMetricCollectionTypesResponse> DescribeMetricCollectionTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeMetricCollectionTypesAsync(new DescribeMetricCollectionTypesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMetricCollectionTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricCollectionTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeMetricCollectionTypes">REST API Reference for DescribeMetricCollectionTypes Operation</seealso>
        public virtual Task<DescribeMetricCollectionTypesResponse> DescribeMetricCollectionTypesAsync(DescribeMetricCollectionTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMetricCollectionTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetricCollectionTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMetricCollectionTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNotificationConfigurations

        internal virtual DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations()
        {
            return DescribeNotificationConfigurations(new DescribeNotificationConfigurationsRequest());
        }
        internal virtual DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotificationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotificationConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeNotificationConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Describes the notification actions associated with the specified Auto Scaling group.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNotificationConfigurations service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeNotificationConfigurations">REST API Reference for DescribeNotificationConfigurations Operation</seealso>
        public virtual Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeNotificationConfigurationsAsync(new DescribeNotificationConfigurationsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotificationConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotificationConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeNotificationConfigurations">REST API Reference for DescribeNotificationConfigurations Operation</seealso>
        public virtual Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurationsAsync(DescribeNotificationConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotificationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotificationConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNotificationConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePolicies

        internal virtual DescribePoliciesResponse DescribePolicies()
        {
            return DescribePolicies(new DescribePoliciesRequest());
        }
        internal virtual DescribePoliciesResponse DescribePolicies(DescribePoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribePoliciesResponse>(request, options);
        }


        /// <summary>
        /// Describes the policies for the specified Auto Scaling group.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePolicies service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ServiceLinkedRoleFailureException">
        /// The service-linked role is not yet ready for use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribePolicies">REST API Reference for DescribePolicies Operation</seealso>
        public virtual Task<DescribePoliciesResponse> DescribePoliciesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribePoliciesAsync(new DescribePoliciesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribePolicies">REST API Reference for DescribePolicies Operation</seealso>
        public virtual Task<DescribePoliciesResponse> DescribePoliciesAsync(DescribePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalingActivities

        internal virtual DescribeScalingActivitiesResponse DescribeScalingActivities()
        {
            return DescribeScalingActivities(new DescribeScalingActivitiesRequest());
        }
        internal virtual DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingActivitiesResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingActivitiesResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more scaling activities for the specified Auto Scaling group.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingActivities">REST API Reference for DescribeScalingActivities Operation</seealso>
        public virtual Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeScalingActivitiesAsync(new DescribeScalingActivitiesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingActivities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingActivities">REST API Reference for DescribeScalingActivities Operation</seealso>
        public virtual Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(DescribeScalingActivitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingActivitiesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalingActivitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalingProcessTypes

        internal virtual DescribeScalingProcessTypesResponse DescribeScalingProcessTypes()
        {
            return DescribeScalingProcessTypes(new DescribeScalingProcessTypesRequest());
        }
        internal virtual DescribeScalingProcessTypesResponse DescribeScalingProcessTypes(DescribeScalingProcessTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingProcessTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingProcessTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingProcessTypesResponse>(request, options);
        }


        /// <summary>
        /// Describes the scaling process types for use with <a>ResumeProcesses</a> and <a>SuspendProcesses</a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScalingProcessTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingProcessTypes">REST API Reference for DescribeScalingProcessTypes Operation</seealso>
        public virtual Task<DescribeScalingProcessTypesResponse> DescribeScalingProcessTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeScalingProcessTypesAsync(new DescribeScalingProcessTypesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingProcessTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingProcessTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScalingProcessTypes">REST API Reference for DescribeScalingProcessTypes Operation</seealso>
        public virtual Task<DescribeScalingProcessTypesResponse> DescribeScalingProcessTypesAsync(DescribeScalingProcessTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingProcessTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingProcessTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalingProcessTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScheduledActions

        internal virtual DescribeScheduledActionsResponse DescribeScheduledActions()
        {
            return DescribeScheduledActions(new DescribeScheduledActionsRequest());
        }
        internal virtual DescribeScheduledActionsResponse DescribeScheduledActions(DescribeScheduledActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledActionsResponseUnmarshaller.Instance;

            return Invoke<DescribeScheduledActionsResponse>(request, options);
        }


        /// <summary>
        /// Describes the actions scheduled for your Auto Scaling group that haven't run. To describe
        /// the actions that have already run, use <a>DescribeScalingActivities</a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        public virtual Task<DescribeScheduledActionsResponse> DescribeScheduledActionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeScheduledActionsAsync(new DescribeScheduledActionsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScheduledActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        public virtual Task<DescribeScheduledActionsResponse> DescribeScheduledActionsAsync(DescribeScheduledActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledActionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScheduledActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags

        internal virtual DescribeTagsResponse DescribeTags()
        {
            return DescribeTags(new DescribeTagsRequest());
        }
        internal virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified tags.
        /// 
        ///  
        /// <para>
        /// You can use filters to limit the results. For example, you can query for the tags
        /// for a specific Auto Scaling group. You can specify multiple values for a filter. A
        /// tag must match at least one of the specified values for it to be included in the results.
        /// </para>
        ///  
        /// <para>
        /// You can also specify multiple filters. The result includes information for a particular
        /// tag only if it matches all the filters. If there's no match, no special message is
        /// returned.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> value is not valid.
        /// </exception>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeTagsAsync(new DescribeTagsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTerminationPolicyTypes

        internal virtual DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes()
        {
            return DescribeTerminationPolicyTypes(new DescribeTerminationPolicyTypesRequest());
        }
        internal virtual DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes(DescribeTerminationPolicyTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTerminationPolicyTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTerminationPolicyTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeTerminationPolicyTypesResponse>(request, options);
        }


        /// <summary>
        /// Describes the termination policies supported by Amazon EC2 Auto Scaling.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/autoscaling/ec2/userguide/as-instance-termination.html">Controlling
        /// Which Auto Scaling Instances Terminate During Scale In</a> in the <i>Amazon EC2 Auto
        /// Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTerminationPolicyTypes service method, as returned by AutoScaling.</returns>
        /// <exception cref="Amazon.AutoScaling.Model.ResourceContentionException">
        /// You already have a pending update to an Auto Scaling resource (for example, a group,
        /// instance, or load balancer).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTerminationPolicyTypes">REST API Reference for DescribeTerminationPolicyTypes Operation</seealso>
        public virtual Task<DescribeTerminationPolicyTypesResponse> DescribeTerminationPolicyTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeTerminationPolicyTypesAsync(new DescribeTerminationPolicyTypesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTerminationPolicyTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTerminationPolicyTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DescribeTerminationPolicyTypes">REST API Reference for DescribeTerminationPolicyTypes Operation</seealso>
        public virtual Task<DescribeTerminationPolicyTypesResponse> DescribeTerminationPolicyTypesAsync(DescribeTerminationPolicyTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTerminationPolicyTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTerminationPolicyTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTerminationPolicyTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachInstances

        internal virtual DetachInstancesResponse DetachInstances(DetachInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachInstancesResponseUnmarshaller.Instance;

            return Invoke<DetachInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachInstances">REST API Reference for DetachInstances Operation</seealso>
        public virtual Task<DetachInstancesResponse> DetachInstancesAsync(DetachInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DetachInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachLoadBalancers

        internal virtual DetachLoadBalancersResponse DetachLoadBalancers(DetachLoadBalancersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachLoadBalancersResponseUnmarshaller.Instance;

            return Invoke<DetachLoadBalancersResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachLoadBalancers">REST API Reference for DetachLoadBalancers Operation</seealso>
        public virtual Task<DetachLoadBalancersResponse> DetachLoadBalancersAsync(DetachLoadBalancersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachLoadBalancersResponseUnmarshaller.Instance;

            return InvokeAsync<DetachLoadBalancersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachLoadBalancerTargetGroups

        internal virtual DetachLoadBalancerTargetGroupsResponse DetachLoadBalancerTargetGroups(DetachLoadBalancerTargetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachLoadBalancerTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachLoadBalancerTargetGroupsResponseUnmarshaller.Instance;

            return Invoke<DetachLoadBalancerTargetGroupsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachLoadBalancerTargetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancerTargetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DetachLoadBalancerTargetGroups">REST API Reference for DetachLoadBalancerTargetGroups Operation</seealso>
        public virtual Task<DetachLoadBalancerTargetGroupsResponse> DetachLoadBalancerTargetGroupsAsync(DetachLoadBalancerTargetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachLoadBalancerTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachLoadBalancerTargetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DetachLoadBalancerTargetGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableMetricsCollection

        internal virtual DisableMetricsCollectionResponse DisableMetricsCollection(DisableMetricsCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableMetricsCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableMetricsCollectionResponseUnmarshaller.Instance;

            return Invoke<DisableMetricsCollectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableMetricsCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableMetricsCollection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/DisableMetricsCollection">REST API Reference for DisableMetricsCollection Operation</seealso>
        public virtual Task<DisableMetricsCollectionResponse> DisableMetricsCollectionAsync(DisableMetricsCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableMetricsCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableMetricsCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<DisableMetricsCollectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableMetricsCollection

        internal virtual EnableMetricsCollectionResponse EnableMetricsCollection(EnableMetricsCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableMetricsCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableMetricsCollectionResponseUnmarshaller.Instance;

            return Invoke<EnableMetricsCollectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableMetricsCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableMetricsCollection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/EnableMetricsCollection">REST API Reference for EnableMetricsCollection Operation</seealso>
        public virtual Task<EnableMetricsCollectionResponse> EnableMetricsCollectionAsync(EnableMetricsCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableMetricsCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableMetricsCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<EnableMetricsCollectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnterStandby

        internal virtual EnterStandbyResponse EnterStandby(EnterStandbyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnterStandbyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnterStandbyResponseUnmarshaller.Instance;

            return Invoke<EnterStandbyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnterStandby operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnterStandby operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/EnterStandby">REST API Reference for EnterStandby Operation</seealso>
        public virtual Task<EnterStandbyResponse> EnterStandbyAsync(EnterStandbyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnterStandbyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnterStandbyResponseUnmarshaller.Instance;

            return InvokeAsync<EnterStandbyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecutePolicy

        internal virtual ExecutePolicyResponse ExecutePolicy(ExecutePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecutePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecutePolicyResponseUnmarshaller.Instance;

            return Invoke<ExecutePolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ExecutePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecutePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/ExecutePolicy">REST API Reference for ExecutePolicy Operation</seealso>
        public virtual Task<ExecutePolicyResponse> ExecutePolicyAsync(ExecutePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecutePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecutePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<ExecutePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExitStandby

        internal virtual ExitStandbyResponse ExitStandby(ExitStandbyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExitStandbyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExitStandbyResponseUnmarshaller.Instance;

            return Invoke<ExitStandbyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ExitStandby operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExitStandby operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/ExitStandby">REST API Reference for ExitStandby Operation</seealso>
        public virtual Task<ExitStandbyResponse> ExitStandbyAsync(ExitStandbyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExitStandbyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExitStandbyResponseUnmarshaller.Instance;

            return InvokeAsync<ExitStandbyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutLifecycleHook

        internal virtual PutLifecycleHookResponse PutLifecycleHook(PutLifecycleHookRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLifecycleHookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLifecycleHookResponseUnmarshaller.Instance;

            return Invoke<PutLifecycleHookResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutLifecycleHook operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleHook operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutLifecycleHook">REST API Reference for PutLifecycleHook Operation</seealso>
        public virtual Task<PutLifecycleHookResponse> PutLifecycleHookAsync(PutLifecycleHookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLifecycleHookRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLifecycleHookResponseUnmarshaller.Instance;

            return InvokeAsync<PutLifecycleHookResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutNotificationConfiguration

        internal virtual PutNotificationConfigurationResponse PutNotificationConfiguration(PutNotificationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutNotificationConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutNotificationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutNotificationConfiguration">REST API Reference for PutNotificationConfiguration Operation</seealso>
        public virtual Task<PutNotificationConfigurationResponse> PutNotificationConfigurationAsync(PutNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutNotificationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutNotificationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutNotificationConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutScalingPolicy

        internal virtual PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<PutScalingPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        public virtual Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutScalingPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutScheduledUpdateGroupAction

        internal virtual PutScheduledUpdateGroupActionResponse PutScheduledUpdateGroupAction(PutScheduledUpdateGroupActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScheduledUpdateGroupActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScheduledUpdateGroupActionResponseUnmarshaller.Instance;

            return Invoke<PutScheduledUpdateGroupActionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutScheduledUpdateGroupAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScheduledUpdateGroupAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/PutScheduledUpdateGroupAction">REST API Reference for PutScheduledUpdateGroupAction Operation</seealso>
        public virtual Task<PutScheduledUpdateGroupActionResponse> PutScheduledUpdateGroupActionAsync(PutScheduledUpdateGroupActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScheduledUpdateGroupActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScheduledUpdateGroupActionResponseUnmarshaller.Instance;

            return InvokeAsync<PutScheduledUpdateGroupActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RecordLifecycleActionHeartbeat

        internal virtual RecordLifecycleActionHeartbeatResponse RecordLifecycleActionHeartbeat(RecordLifecycleActionHeartbeatRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RecordLifecycleActionHeartbeatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecordLifecycleActionHeartbeatResponseUnmarshaller.Instance;

            return Invoke<RecordLifecycleActionHeartbeatResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RecordLifecycleActionHeartbeat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecordLifecycleActionHeartbeat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/RecordLifecycleActionHeartbeat">REST API Reference for RecordLifecycleActionHeartbeat Operation</seealso>
        public virtual Task<RecordLifecycleActionHeartbeatResponse> RecordLifecycleActionHeartbeatAsync(RecordLifecycleActionHeartbeatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RecordLifecycleActionHeartbeatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecordLifecycleActionHeartbeatResponseUnmarshaller.Instance;

            return InvokeAsync<RecordLifecycleActionHeartbeatResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResumeProcesses

        internal virtual ResumeProcessesResponse ResumeProcesses(ResumeProcessesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeProcessesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeProcessesResponseUnmarshaller.Instance;

            return Invoke<ResumeProcessesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResumeProcesses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResumeProcesses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/ResumeProcesses">REST API Reference for ResumeProcesses Operation</seealso>
        public virtual Task<ResumeProcessesResponse> ResumeProcessesAsync(ResumeProcessesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResumeProcessesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResumeProcessesResponseUnmarshaller.Instance;

            return InvokeAsync<ResumeProcessesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetDesiredCapacity

        internal virtual SetDesiredCapacityResponse SetDesiredCapacity(SetDesiredCapacityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDesiredCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDesiredCapacityResponseUnmarshaller.Instance;

            return Invoke<SetDesiredCapacityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetDesiredCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDesiredCapacity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SetDesiredCapacity">REST API Reference for SetDesiredCapacity Operation</seealso>
        public virtual Task<SetDesiredCapacityResponse> SetDesiredCapacityAsync(SetDesiredCapacityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetDesiredCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDesiredCapacityResponseUnmarshaller.Instance;

            return InvokeAsync<SetDesiredCapacityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetInstanceHealth

        internal virtual SetInstanceHealthResponse SetInstanceHealth(SetInstanceHealthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetInstanceHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetInstanceHealthResponseUnmarshaller.Instance;

            return Invoke<SetInstanceHealthResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetInstanceHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceHealth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SetInstanceHealth">REST API Reference for SetInstanceHealth Operation</seealso>
        public virtual Task<SetInstanceHealthResponse> SetInstanceHealthAsync(SetInstanceHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetInstanceHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetInstanceHealthResponseUnmarshaller.Instance;

            return InvokeAsync<SetInstanceHealthResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetInstanceProtection

        internal virtual SetInstanceProtectionResponse SetInstanceProtection(SetInstanceProtectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetInstanceProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetInstanceProtectionResponseUnmarshaller.Instance;

            return Invoke<SetInstanceProtectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetInstanceProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetInstanceProtection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SetInstanceProtection">REST API Reference for SetInstanceProtection Operation</seealso>
        public virtual Task<SetInstanceProtectionResponse> SetInstanceProtectionAsync(SetInstanceProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetInstanceProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetInstanceProtectionResponseUnmarshaller.Instance;

            return InvokeAsync<SetInstanceProtectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SuspendProcesses

        internal virtual SuspendProcessesResponse SuspendProcesses(SuspendProcessesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SuspendProcessesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SuspendProcessesResponseUnmarshaller.Instance;

            return Invoke<SuspendProcessesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SuspendProcesses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SuspendProcesses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/SuspendProcesses">REST API Reference for SuspendProcesses Operation</seealso>
        public virtual Task<SuspendProcessesResponse> SuspendProcessesAsync(SuspendProcessesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SuspendProcessesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SuspendProcessesResponseUnmarshaller.Instance;

            return InvokeAsync<SuspendProcessesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TerminateInstanceInAutoScalingGroup

        internal virtual TerminateInstanceInAutoScalingGroupResponse TerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateInstanceInAutoScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateInstanceInAutoScalingGroupResponseUnmarshaller.Instance;

            return Invoke<TerminateInstanceInAutoScalingGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TerminateInstanceInAutoScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstanceInAutoScalingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/TerminateInstanceInAutoScalingGroup">REST API Reference for TerminateInstanceInAutoScalingGroup Operation</seealso>
        public virtual Task<TerminateInstanceInAutoScalingGroupResponse> TerminateInstanceInAutoScalingGroupAsync(TerminateInstanceInAutoScalingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateInstanceInAutoScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateInstanceInAutoScalingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateInstanceInAutoScalingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAutoScalingGroup

        internal virtual UpdateAutoScalingGroupResponse UpdateAutoScalingGroup(UpdateAutoScalingGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAutoScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutoScalingGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateAutoScalingGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAutoScalingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAutoScalingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-2011-01-01/UpdateAutoScalingGroup">REST API Reference for UpdateAutoScalingGroup Operation</seealso>
        public virtual Task<UpdateAutoScalingGroupResponse> UpdateAutoScalingGroupAsync(UpdateAutoScalingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAutoScalingGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAutoScalingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAutoScalingGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}