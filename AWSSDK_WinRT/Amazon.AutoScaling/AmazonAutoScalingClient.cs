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
    /// Auto Scaling is designed to automatically launch or terminate EC2 instances based
    /// on user-defined policies, schedules, and health checks. Use this service in conjunction
    /// with the Amazon CloudWatch and Elastic Load Balancing services.
    /// </para>
    /// </summary>
    public partial class AmazonAutoScalingClient : AmazonServiceClient, IAmazonAutoScaling
    {
        
        #region Constructors

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

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 


        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AttachInstances

        internal AttachInstancesResponse AttachInstances(AttachInstancesRequest request)
        {
            var marshaller = new AttachInstancesRequestMarshaller();
            var unmarshaller = AttachInstancesResponseUnmarshaller.Instance;

            return Invoke<AttachInstancesRequest,AttachInstancesResponse>(request, marshaller, unmarshaller);
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
        public Task<AttachInstancesResponse> AttachInstancesAsync(AttachInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachInstancesRequestMarshaller();
            var unmarshaller = AttachInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<AttachInstancesRequest,AttachInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CompleteLifecycleAction

        internal CompleteLifecycleActionResponse CompleteLifecycleAction(CompleteLifecycleActionRequest request)
        {
            var marshaller = new CompleteLifecycleActionRequestMarshaller();
            var unmarshaller = CompleteLifecycleActionResponseUnmarshaller.Instance;

            return Invoke<CompleteLifecycleActionRequest,CompleteLifecycleActionResponse>(request, marshaller, unmarshaller);
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
        public Task<CompleteLifecycleActionResponse> CompleteLifecycleActionAsync(CompleteLifecycleActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CompleteLifecycleActionRequestMarshaller();
            var unmarshaller = CompleteLifecycleActionResponseUnmarshaller.Instance;

            return InvokeAsync<CompleteLifecycleActionRequest,CompleteLifecycleActionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAutoScalingGroup

        internal CreateAutoScalingGroupResponse CreateAutoScalingGroup(CreateAutoScalingGroupRequest request)
        {
            var marshaller = new CreateAutoScalingGroupRequestMarshaller();
            var unmarshaller = CreateAutoScalingGroupResponseUnmarshaller.Instance;

            return Invoke<CreateAutoScalingGroupRequest,CreateAutoScalingGroupResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateAutoScalingGroupResponse> CreateAutoScalingGroupAsync(CreateAutoScalingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateAutoScalingGroupRequestMarshaller();
            var unmarshaller = CreateAutoScalingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAutoScalingGroupRequest,CreateAutoScalingGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateLaunchConfiguration

        internal CreateLaunchConfigurationResponse CreateLaunchConfiguration(CreateLaunchConfigurationRequest request)
        {
            var marshaller = new CreateLaunchConfigurationRequestMarshaller();
            var unmarshaller = CreateLaunchConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateLaunchConfigurationRequest,CreateLaunchConfigurationResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateLaunchConfigurationResponse> CreateLaunchConfigurationAsync(CreateLaunchConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLaunchConfigurationRequestMarshaller();
            var unmarshaller = CreateLaunchConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLaunchConfigurationRequest,CreateLaunchConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateOrUpdateTags

        internal CreateOrUpdateTagsResponse CreateOrUpdateTags(CreateOrUpdateTagsRequest request)
        {
            var marshaller = new CreateOrUpdateTagsRequestMarshaller();
            var unmarshaller = CreateOrUpdateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateOrUpdateTagsRequest,CreateOrUpdateTagsResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateOrUpdateTagsResponse> CreateOrUpdateTagsAsync(CreateOrUpdateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateOrUpdateTagsRequestMarshaller();
            var unmarshaller = CreateOrUpdateTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOrUpdateTagsRequest,CreateOrUpdateTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAutoScalingGroup

        internal DeleteAutoScalingGroupResponse DeleteAutoScalingGroup(DeleteAutoScalingGroupRequest request)
        {
            var marshaller = new DeleteAutoScalingGroupRequestMarshaller();
            var unmarshaller = DeleteAutoScalingGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteAutoScalingGroupRequest,DeleteAutoScalingGroupResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteAutoScalingGroupResponse> DeleteAutoScalingGroupAsync(DeleteAutoScalingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteAutoScalingGroupRequestMarshaller();
            var unmarshaller = DeleteAutoScalingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAutoScalingGroupRequest,DeleteAutoScalingGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteLaunchConfiguration

        internal DeleteLaunchConfigurationResponse DeleteLaunchConfiguration(DeleteLaunchConfigurationRequest request)
        {
            var marshaller = new DeleteLaunchConfigurationRequestMarshaller();
            var unmarshaller = DeleteLaunchConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteLaunchConfigurationRequest,DeleteLaunchConfigurationResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteLaunchConfigurationResponse> DeleteLaunchConfigurationAsync(DeleteLaunchConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLaunchConfigurationRequestMarshaller();
            var unmarshaller = DeleteLaunchConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLaunchConfigurationRequest,DeleteLaunchConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteLifecycleHook

        internal DeleteLifecycleHookResponse DeleteLifecycleHook(DeleteLifecycleHookRequest request)
        {
            var marshaller = new DeleteLifecycleHookRequestMarshaller();
            var unmarshaller = DeleteLifecycleHookResponseUnmarshaller.Instance;

            return Invoke<DeleteLifecycleHookRequest,DeleteLifecycleHookResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteLifecycleHookResponse> DeleteLifecycleHookAsync(DeleteLifecycleHookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLifecycleHookRequestMarshaller();
            var unmarshaller = DeleteLifecycleHookResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLifecycleHookRequest,DeleteLifecycleHookResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteNotificationConfiguration

        internal DeleteNotificationConfigurationResponse DeleteNotificationConfiguration(DeleteNotificationConfigurationRequest request)
        {
            var marshaller = new DeleteNotificationConfigurationRequestMarshaller();
            var unmarshaller = DeleteNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteNotificationConfigurationRequest,DeleteNotificationConfigurationResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteNotificationConfigurationResponse> DeleteNotificationConfigurationAsync(DeleteNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteNotificationConfigurationRequestMarshaller();
            var unmarshaller = DeleteNotificationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNotificationConfigurationRequest,DeleteNotificationConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeletePolicy

        internal DeletePolicyResponse DeletePolicy(DeletePolicyRequest request)
        {
            var marshaller = new DeletePolicyRequestMarshaller();
            var unmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return Invoke<DeletePolicyRequest,DeletePolicyResponse>(request, marshaller, unmarshaller);
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
        public Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeletePolicyRequestMarshaller();
            var unmarshaller = DeletePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePolicyRequest,DeletePolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteScheduledAction

        internal DeleteScheduledActionResponse DeleteScheduledAction(DeleteScheduledActionRequest request)
        {
            var marshaller = new DeleteScheduledActionRequestMarshaller();
            var unmarshaller = DeleteScheduledActionResponseUnmarshaller.Instance;

            return Invoke<DeleteScheduledActionRequest,DeleteScheduledActionResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteScheduledActionResponse> DeleteScheduledActionAsync(DeleteScheduledActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteScheduledActionRequestMarshaller();
            var unmarshaller = DeleteScheduledActionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScheduledActionRequest,DeleteScheduledActionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags

        internal DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountLimits

        internal DescribeAccountLimitsResponse DescribeAccountLimits()
        {
            return DescribeAccountLimits(new DescribeAccountLimitsRequest());
        }
        internal DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request)
        {
            var marshaller = new DescribeAccountLimitsRequestMarshaller();
            var unmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountLimitsRequest,DescribeAccountLimitsResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(DescribeAccountLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAccountLimitsRequestMarshaller();
            var unmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountLimitsRequest,DescribeAccountLimitsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAdjustmentTypes

        internal DescribeAdjustmentTypesResponse DescribeAdjustmentTypes()
        {
            return DescribeAdjustmentTypes(new DescribeAdjustmentTypesRequest());
        }
        internal DescribeAdjustmentTypesResponse DescribeAdjustmentTypes(DescribeAdjustmentTypesRequest request)
        {
            var marshaller = new DescribeAdjustmentTypesRequestMarshaller();
            var unmarshaller = DescribeAdjustmentTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeAdjustmentTypesRequest,DescribeAdjustmentTypesResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeAdjustmentTypesResponse> DescribeAdjustmentTypesAsync(DescribeAdjustmentTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAdjustmentTypesRequestMarshaller();
            var unmarshaller = DescribeAdjustmentTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAdjustmentTypesRequest,DescribeAdjustmentTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAutoScalingGroups

        internal DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups()
        {
            return DescribeAutoScalingGroups(new DescribeAutoScalingGroupsRequest());
        }
        internal DescribeAutoScalingGroupsResponse DescribeAutoScalingGroups(DescribeAutoScalingGroupsRequest request)
        {
            var marshaller = new DescribeAutoScalingGroupsRequestMarshaller();
            var unmarshaller = DescribeAutoScalingGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeAutoScalingGroupsRequest,DescribeAutoScalingGroupsResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeAutoScalingGroupsResponse> DescribeAutoScalingGroupsAsync(DescribeAutoScalingGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAutoScalingGroupsRequestMarshaller();
            var unmarshaller = DescribeAutoScalingGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAutoScalingGroupsRequest,DescribeAutoScalingGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAutoScalingInstances

        internal DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances()
        {
            return DescribeAutoScalingInstances(new DescribeAutoScalingInstancesRequest());
        }
        internal DescribeAutoScalingInstancesResponse DescribeAutoScalingInstances(DescribeAutoScalingInstancesRequest request)
        {
            var marshaller = new DescribeAutoScalingInstancesRequestMarshaller();
            var unmarshaller = DescribeAutoScalingInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeAutoScalingInstancesRequest,DescribeAutoScalingInstancesResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeAutoScalingInstancesResponse> DescribeAutoScalingInstancesAsync(DescribeAutoScalingInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAutoScalingInstancesRequestMarshaller();
            var unmarshaller = DescribeAutoScalingInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAutoScalingInstancesRequest,DescribeAutoScalingInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAutoScalingNotificationTypes

        internal DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes()
        {
            return DescribeAutoScalingNotificationTypes(new DescribeAutoScalingNotificationTypesRequest());
        }
        internal DescribeAutoScalingNotificationTypesResponse DescribeAutoScalingNotificationTypes(DescribeAutoScalingNotificationTypesRequest request)
        {
            var marshaller = new DescribeAutoScalingNotificationTypesRequestMarshaller();
            var unmarshaller = DescribeAutoScalingNotificationTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeAutoScalingNotificationTypesRequest,DescribeAutoScalingNotificationTypesResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeAutoScalingNotificationTypesResponse> DescribeAutoScalingNotificationTypesAsync(DescribeAutoScalingNotificationTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAutoScalingNotificationTypesRequestMarshaller();
            var unmarshaller = DescribeAutoScalingNotificationTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAutoScalingNotificationTypesRequest,DescribeAutoScalingNotificationTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLaunchConfigurations

        internal DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations()
        {
            return DescribeLaunchConfigurations(new DescribeLaunchConfigurationsRequest());
        }
        internal DescribeLaunchConfigurationsResponse DescribeLaunchConfigurations(DescribeLaunchConfigurationsRequest request)
        {
            var marshaller = new DescribeLaunchConfigurationsRequestMarshaller();
            var unmarshaller = DescribeLaunchConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeLaunchConfigurationsRequest,DescribeLaunchConfigurationsResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeLaunchConfigurationsResponse> DescribeLaunchConfigurationsAsync(DescribeLaunchConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLaunchConfigurationsRequestMarshaller();
            var unmarshaller = DescribeLaunchConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLaunchConfigurationsRequest,DescribeLaunchConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLifecycleHooks

        internal DescribeLifecycleHooksResponse DescribeLifecycleHooks(DescribeLifecycleHooksRequest request)
        {
            var marshaller = new DescribeLifecycleHooksRequestMarshaller();
            var unmarshaller = DescribeLifecycleHooksResponseUnmarshaller.Instance;

            return Invoke<DescribeLifecycleHooksRequest,DescribeLifecycleHooksResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeLifecycleHooksResponse> DescribeLifecycleHooksAsync(DescribeLifecycleHooksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLifecycleHooksRequestMarshaller();
            var unmarshaller = DescribeLifecycleHooksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLifecycleHooksRequest,DescribeLifecycleHooksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLifecycleHookTypes

        internal DescribeLifecycleHookTypesResponse DescribeLifecycleHookTypes(DescribeLifecycleHookTypesRequest request)
        {
            var marshaller = new DescribeLifecycleHookTypesRequestMarshaller();
            var unmarshaller = DescribeLifecycleHookTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeLifecycleHookTypesRequest,DescribeLifecycleHookTypesResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeLifecycleHookTypesResponse> DescribeLifecycleHookTypesAsync(DescribeLifecycleHookTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLifecycleHookTypesRequestMarshaller();
            var unmarshaller = DescribeLifecycleHookTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLifecycleHookTypesRequest,DescribeLifecycleHookTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeMetricCollectionTypes

        internal DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes()
        {
            return DescribeMetricCollectionTypes(new DescribeMetricCollectionTypesRequest());
        }
        internal DescribeMetricCollectionTypesResponse DescribeMetricCollectionTypes(DescribeMetricCollectionTypesRequest request)
        {
            var marshaller = new DescribeMetricCollectionTypesRequestMarshaller();
            var unmarshaller = DescribeMetricCollectionTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeMetricCollectionTypesRequest,DescribeMetricCollectionTypesResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeMetricCollectionTypesResponse> DescribeMetricCollectionTypesAsync(DescribeMetricCollectionTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeMetricCollectionTypesRequestMarshaller();
            var unmarshaller = DescribeMetricCollectionTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMetricCollectionTypesRequest,DescribeMetricCollectionTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeNotificationConfigurations

        internal DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations()
        {
            return DescribeNotificationConfigurations(new DescribeNotificationConfigurationsRequest());
        }
        internal DescribeNotificationConfigurationsResponse DescribeNotificationConfigurations(DescribeNotificationConfigurationsRequest request)
        {
            var marshaller = new DescribeNotificationConfigurationsRequestMarshaller();
            var unmarshaller = DescribeNotificationConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeNotificationConfigurationsRequest,DescribeNotificationConfigurationsResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeNotificationConfigurationsResponse> DescribeNotificationConfigurationsAsync(DescribeNotificationConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeNotificationConfigurationsRequestMarshaller();
            var unmarshaller = DescribeNotificationConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNotificationConfigurationsRequest,DescribeNotificationConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribePolicies

        internal DescribePoliciesResponse DescribePolicies()
        {
            return DescribePolicies(new DescribePoliciesRequest());
        }
        internal DescribePoliciesResponse DescribePolicies(DescribePoliciesRequest request)
        {
            var marshaller = new DescribePoliciesRequestMarshaller();
            var unmarshaller = DescribePoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribePoliciesRequest,DescribePoliciesResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribePoliciesResponse> DescribePoliciesAsync(DescribePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribePoliciesRequestMarshaller();
            var unmarshaller = DescribePoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePoliciesRequest,DescribePoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalingActivities

        internal DescribeScalingActivitiesResponse DescribeScalingActivities()
        {
            return DescribeScalingActivities(new DescribeScalingActivitiesRequest());
        }
        internal DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest request)
        {
            var marshaller = new DescribeScalingActivitiesRequestMarshaller();
            var unmarshaller = DescribeScalingActivitiesResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingActivitiesRequest,DescribeScalingActivitiesResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(DescribeScalingActivitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeScalingActivitiesRequestMarshaller();
            var unmarshaller = DescribeScalingActivitiesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalingActivitiesRequest,DescribeScalingActivitiesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalingProcessTypes

        internal DescribeScalingProcessTypesResponse DescribeScalingProcessTypes()
        {
            return DescribeScalingProcessTypes(new DescribeScalingProcessTypesRequest());
        }
        internal DescribeScalingProcessTypesResponse DescribeScalingProcessTypes(DescribeScalingProcessTypesRequest request)
        {
            var marshaller = new DescribeScalingProcessTypesRequestMarshaller();
            var unmarshaller = DescribeScalingProcessTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingProcessTypesRequest,DescribeScalingProcessTypesResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeScalingProcessTypesResponse> DescribeScalingProcessTypesAsync(DescribeScalingProcessTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeScalingProcessTypesRequestMarshaller();
            var unmarshaller = DescribeScalingProcessTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalingProcessTypesRequest,DescribeScalingProcessTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeScheduledActions

        internal DescribeScheduledActionsResponse DescribeScheduledActions()
        {
            return DescribeScheduledActions(new DescribeScheduledActionsRequest());
        }
        internal DescribeScheduledActionsResponse DescribeScheduledActions(DescribeScheduledActionsRequest request)
        {
            var marshaller = new DescribeScheduledActionsRequestMarshaller();
            var unmarshaller = DescribeScheduledActionsResponseUnmarshaller.Instance;

            return Invoke<DescribeScheduledActionsRequest,DescribeScheduledActionsResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeScheduledActionsResponse> DescribeScheduledActionsAsync(DescribeScheduledActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeScheduledActionsRequestMarshaller();
            var unmarshaller = DescribeScheduledActionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScheduledActionsRequest,DescribeScheduledActionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags

        internal DescribeTagsResponse DescribeTags()
        {
            return DescribeTags(new DescribeTagsRequest());
        }
        internal DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTerminationPolicyTypes

        internal DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes()
        {
            return DescribeTerminationPolicyTypes(new DescribeTerminationPolicyTypesRequest());
        }
        internal DescribeTerminationPolicyTypesResponse DescribeTerminationPolicyTypes(DescribeTerminationPolicyTypesRequest request)
        {
            var marshaller = new DescribeTerminationPolicyTypesRequestMarshaller();
            var unmarshaller = DescribeTerminationPolicyTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeTerminationPolicyTypesRequest,DescribeTerminationPolicyTypesResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeTerminationPolicyTypesResponse> DescribeTerminationPolicyTypesAsync(DescribeTerminationPolicyTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTerminationPolicyTypesRequestMarshaller();
            var unmarshaller = DescribeTerminationPolicyTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTerminationPolicyTypesRequest,DescribeTerminationPolicyTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachInstances

        internal DetachInstancesResponse DetachInstances(DetachInstancesRequest request)
        {
            var marshaller = new DetachInstancesRequestMarshaller();
            var unmarshaller = DetachInstancesResponseUnmarshaller.Instance;

            return Invoke<DetachInstancesRequest,DetachInstancesResponse>(request, marshaller, unmarshaller);
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
        public Task<DetachInstancesResponse> DetachInstancesAsync(DetachInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachInstancesRequestMarshaller();
            var unmarshaller = DetachInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DetachInstancesRequest,DetachInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableMetricsCollection

        internal DisableMetricsCollectionResponse DisableMetricsCollection(DisableMetricsCollectionRequest request)
        {
            var marshaller = new DisableMetricsCollectionRequestMarshaller();
            var unmarshaller = DisableMetricsCollectionResponseUnmarshaller.Instance;

            return Invoke<DisableMetricsCollectionRequest,DisableMetricsCollectionResponse>(request, marshaller, unmarshaller);
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
        public Task<DisableMetricsCollectionResponse> DisableMetricsCollectionAsync(DisableMetricsCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableMetricsCollectionRequestMarshaller();
            var unmarshaller = DisableMetricsCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<DisableMetricsCollectionRequest,DisableMetricsCollectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableMetricsCollection

        internal EnableMetricsCollectionResponse EnableMetricsCollection(EnableMetricsCollectionRequest request)
        {
            var marshaller = new EnableMetricsCollectionRequestMarshaller();
            var unmarshaller = EnableMetricsCollectionResponseUnmarshaller.Instance;

            return Invoke<EnableMetricsCollectionRequest,EnableMetricsCollectionResponse>(request, marshaller, unmarshaller);
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
        public Task<EnableMetricsCollectionResponse> EnableMetricsCollectionAsync(EnableMetricsCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableMetricsCollectionRequestMarshaller();
            var unmarshaller = EnableMetricsCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<EnableMetricsCollectionRequest,EnableMetricsCollectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnterStandby

        internal EnterStandbyResponse EnterStandby(EnterStandbyRequest request)
        {
            var marshaller = new EnterStandbyRequestMarshaller();
            var unmarshaller = EnterStandbyResponseUnmarshaller.Instance;

            return Invoke<EnterStandbyRequest,EnterStandbyResponse>(request, marshaller, unmarshaller);
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
        public Task<EnterStandbyResponse> EnterStandbyAsync(EnterStandbyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnterStandbyRequestMarshaller();
            var unmarshaller = EnterStandbyResponseUnmarshaller.Instance;

            return InvokeAsync<EnterStandbyRequest,EnterStandbyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ExecutePolicy

        internal ExecutePolicyResponse ExecutePolicy(ExecutePolicyRequest request)
        {
            var marshaller = new ExecutePolicyRequestMarshaller();
            var unmarshaller = ExecutePolicyResponseUnmarshaller.Instance;

            return Invoke<ExecutePolicyRequest,ExecutePolicyResponse>(request, marshaller, unmarshaller);
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
        public Task<ExecutePolicyResponse> ExecutePolicyAsync(ExecutePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ExecutePolicyRequestMarshaller();
            var unmarshaller = ExecutePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<ExecutePolicyRequest,ExecutePolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ExitStandby

        internal ExitStandbyResponse ExitStandby(ExitStandbyRequest request)
        {
            var marshaller = new ExitStandbyRequestMarshaller();
            var unmarshaller = ExitStandbyResponseUnmarshaller.Instance;

            return Invoke<ExitStandbyRequest,ExitStandbyResponse>(request, marshaller, unmarshaller);
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
        public Task<ExitStandbyResponse> ExitStandbyAsync(ExitStandbyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ExitStandbyRequestMarshaller();
            var unmarshaller = ExitStandbyResponseUnmarshaller.Instance;

            return InvokeAsync<ExitStandbyRequest,ExitStandbyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutLifecycleHook

        internal PutLifecycleHookResponse PutLifecycleHook(PutLifecycleHookRequest request)
        {
            var marshaller = new PutLifecycleHookRequestMarshaller();
            var unmarshaller = PutLifecycleHookResponseUnmarshaller.Instance;

            return Invoke<PutLifecycleHookRequest,PutLifecycleHookResponse>(request, marshaller, unmarshaller);
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
        public Task<PutLifecycleHookResponse> PutLifecycleHookAsync(PutLifecycleHookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutLifecycleHookRequestMarshaller();
            var unmarshaller = PutLifecycleHookResponseUnmarshaller.Instance;

            return InvokeAsync<PutLifecycleHookRequest,PutLifecycleHookResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutNotificationConfiguration

        internal PutNotificationConfigurationResponse PutNotificationConfiguration(PutNotificationConfigurationRequest request)
        {
            var marshaller = new PutNotificationConfigurationRequestMarshaller();
            var unmarshaller = PutNotificationConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutNotificationConfigurationRequest,PutNotificationConfigurationResponse>(request, marshaller, unmarshaller);
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
        public Task<PutNotificationConfigurationResponse> PutNotificationConfigurationAsync(PutNotificationConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutNotificationConfigurationRequestMarshaller();
            var unmarshaller = PutNotificationConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutNotificationConfigurationRequest,PutNotificationConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutScalingPolicy

        internal PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest request)
        {
            var marshaller = new PutScalingPolicyRequestMarshaller();
            var unmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<PutScalingPolicyRequest,PutScalingPolicyResponse>(request, marshaller, unmarshaller);
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
        public Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutScalingPolicyRequestMarshaller();
            var unmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutScalingPolicyRequest,PutScalingPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutScheduledUpdateGroupAction

        internal PutScheduledUpdateGroupActionResponse PutScheduledUpdateGroupAction(PutScheduledUpdateGroupActionRequest request)
        {
            var marshaller = new PutScheduledUpdateGroupActionRequestMarshaller();
            var unmarshaller = PutScheduledUpdateGroupActionResponseUnmarshaller.Instance;

            return Invoke<PutScheduledUpdateGroupActionRequest,PutScheduledUpdateGroupActionResponse>(request, marshaller, unmarshaller);
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
        public Task<PutScheduledUpdateGroupActionResponse> PutScheduledUpdateGroupActionAsync(PutScheduledUpdateGroupActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutScheduledUpdateGroupActionRequestMarshaller();
            var unmarshaller = PutScheduledUpdateGroupActionResponseUnmarshaller.Instance;

            return InvokeAsync<PutScheduledUpdateGroupActionRequest,PutScheduledUpdateGroupActionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RecordLifecycleActionHeartbeat

        internal RecordLifecycleActionHeartbeatResponse RecordLifecycleActionHeartbeat(RecordLifecycleActionHeartbeatRequest request)
        {
            var marshaller = new RecordLifecycleActionHeartbeatRequestMarshaller();
            var unmarshaller = RecordLifecycleActionHeartbeatResponseUnmarshaller.Instance;

            return Invoke<RecordLifecycleActionHeartbeatRequest,RecordLifecycleActionHeartbeatResponse>(request, marshaller, unmarshaller);
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
        public Task<RecordLifecycleActionHeartbeatResponse> RecordLifecycleActionHeartbeatAsync(RecordLifecycleActionHeartbeatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RecordLifecycleActionHeartbeatRequestMarshaller();
            var unmarshaller = RecordLifecycleActionHeartbeatResponseUnmarshaller.Instance;

            return InvokeAsync<RecordLifecycleActionHeartbeatRequest,RecordLifecycleActionHeartbeatResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResumeProcesses

        internal ResumeProcessesResponse ResumeProcesses(ResumeProcessesRequest request)
        {
            var marshaller = new ResumeProcessesRequestMarshaller();
            var unmarshaller = ResumeProcessesResponseUnmarshaller.Instance;

            return Invoke<ResumeProcessesRequest,ResumeProcessesResponse>(request, marshaller, unmarshaller);
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
        public Task<ResumeProcessesResponse> ResumeProcessesAsync(ResumeProcessesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResumeProcessesRequestMarshaller();
            var unmarshaller = ResumeProcessesResponseUnmarshaller.Instance;

            return InvokeAsync<ResumeProcessesRequest,ResumeProcessesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetDesiredCapacity

        internal SetDesiredCapacityResponse SetDesiredCapacity(SetDesiredCapacityRequest request)
        {
            var marshaller = new SetDesiredCapacityRequestMarshaller();
            var unmarshaller = SetDesiredCapacityResponseUnmarshaller.Instance;

            return Invoke<SetDesiredCapacityRequest,SetDesiredCapacityResponse>(request, marshaller, unmarshaller);
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
        public Task<SetDesiredCapacityResponse> SetDesiredCapacityAsync(SetDesiredCapacityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetDesiredCapacityRequestMarshaller();
            var unmarshaller = SetDesiredCapacityResponseUnmarshaller.Instance;

            return InvokeAsync<SetDesiredCapacityRequest,SetDesiredCapacityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetInstanceHealth

        internal SetInstanceHealthResponse SetInstanceHealth(SetInstanceHealthRequest request)
        {
            var marshaller = new SetInstanceHealthRequestMarshaller();
            var unmarshaller = SetInstanceHealthResponseUnmarshaller.Instance;

            return Invoke<SetInstanceHealthRequest,SetInstanceHealthResponse>(request, marshaller, unmarshaller);
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
        public Task<SetInstanceHealthResponse> SetInstanceHealthAsync(SetInstanceHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetInstanceHealthRequestMarshaller();
            var unmarshaller = SetInstanceHealthResponseUnmarshaller.Instance;

            return InvokeAsync<SetInstanceHealthRequest,SetInstanceHealthResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SuspendProcesses

        internal SuspendProcessesResponse SuspendProcesses(SuspendProcessesRequest request)
        {
            var marshaller = new SuspendProcessesRequestMarshaller();
            var unmarshaller = SuspendProcessesResponseUnmarshaller.Instance;

            return Invoke<SuspendProcessesRequest,SuspendProcessesResponse>(request, marshaller, unmarshaller);
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
        public Task<SuspendProcessesResponse> SuspendProcessesAsync(SuspendProcessesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SuspendProcessesRequestMarshaller();
            var unmarshaller = SuspendProcessesResponseUnmarshaller.Instance;

            return InvokeAsync<SuspendProcessesRequest,SuspendProcessesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TerminateInstanceInAutoScalingGroup

        internal TerminateInstanceInAutoScalingGroupResponse TerminateInstanceInAutoScalingGroup(TerminateInstanceInAutoScalingGroupRequest request)
        {
            var marshaller = new TerminateInstanceInAutoScalingGroupRequestMarshaller();
            var unmarshaller = TerminateInstanceInAutoScalingGroupResponseUnmarshaller.Instance;

            return Invoke<TerminateInstanceInAutoScalingGroupRequest,TerminateInstanceInAutoScalingGroupResponse>(request, marshaller, unmarshaller);
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
        public Task<TerminateInstanceInAutoScalingGroupResponse> TerminateInstanceInAutoScalingGroupAsync(TerminateInstanceInAutoScalingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TerminateInstanceInAutoScalingGroupRequestMarshaller();
            var unmarshaller = TerminateInstanceInAutoScalingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateInstanceInAutoScalingGroupRequest,TerminateInstanceInAutoScalingGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAutoScalingGroup

        internal UpdateAutoScalingGroupResponse UpdateAutoScalingGroup(UpdateAutoScalingGroupRequest request)
        {
            var marshaller = new UpdateAutoScalingGroupRequestMarshaller();
            var unmarshaller = UpdateAutoScalingGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateAutoScalingGroupRequest,UpdateAutoScalingGroupResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateAutoScalingGroupResponse> UpdateAutoScalingGroupAsync(UpdateAutoScalingGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateAutoScalingGroupRequestMarshaller();
            var unmarshaller = UpdateAutoScalingGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAutoScalingGroupRequest,UpdateAutoScalingGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}