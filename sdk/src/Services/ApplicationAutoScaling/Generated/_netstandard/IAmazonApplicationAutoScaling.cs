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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ApplicationAutoScaling.Model;

namespace Amazon.ApplicationAutoScaling
{
    /// <summary>
    /// Interface for accessing ApplicationAutoScaling
    ///
    /// With Application Auto Scaling, you can configure automatic scaling for the following
    /// resources:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Amazon AppStream 2.0 fleets
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Aurora Replicas
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Comprehend document classification and entity recognizer endpoints
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon DynamoDB tables and global secondary indexes throughput capacity
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon ECS services
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon ElastiCache for Redis clusters (replication groups)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon EMR clusters
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Keyspaces (for Apache Cassandra) tables
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Lambda function provisioned concurrency
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Managed Streaming for Apache Kafka broker storage
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Neptune clusters
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon SageMaker endpoint variants
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Spot Fleets (Amazon EC2)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Custom resources provided by your own applications or services
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>API Summary</b> 
    /// </para>
    ///  
    /// <para>
    /// The Application Auto Scaling service API includes three key sets of actions: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Register and manage scalable targets - Register Amazon Web Services or custom resources
    /// as scalable targets (a resource that Application Auto Scaling can scale), set minimum
    /// and maximum capacity limits, and retrieve information on existing scalable targets.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Configure and manage automatic scaling - Define scaling policies to dynamically scale
    /// your resources in response to CloudWatch alarms, schedule one-time or recurring scaling
    /// actions, and retrieve your recent scaling activity history.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Suspend and resume scaling - Temporarily suspend and later resume automatic scaling
    /// by calling the <a href="https://docs.aws.amazon.com/autoscaling/application/APIReference/API_RegisterScalableTarget.html">RegisterScalableTarget</a>
    /// API action for any Application Auto Scaling scalable target. You can suspend and resume
    /// (individually or in combination) scale-out activities that are triggered by a scaling
    /// policy, scale-in activities that are triggered by a scaling policy, and scheduled
    /// scaling.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To learn more about Application Auto Scaling, including information about granting
    /// IAM users required permissions for Application Auto Scaling actions, see the <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/what-is-application-auto-scaling.html">Application
    /// Auto Scaling User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonApplicationAutoScaling : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IApplicationAutoScalingPaginatorFactory Paginators { get; }
#endif
                
        #region  DeleteScalingPolicy



        /// <summary>
        /// Deletes the specified scaling policy for an Application Auto Scaling scalable target.
        /// 
        ///  
        /// <para>
        /// Deleting a step scaling policy deletes the underlying alarm action, but does not delete
        /// the CloudWatch alarm associated with the scaling policy, even if it no longer has
        /// an associated action.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-step-scaling-policies.html#delete-step-scaling-policy">Delete
        /// a step scaling policy</a> and <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-target-tracking.html#delete-target-tracking-policy">Delete
        /// a target tracking scaling policy</a> in the <i>Application Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScalingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteScalingPolicy service method, as returned by ApplicationAutoScaling.</returns>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to an
        /// Application Auto Scaling resource that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ObjectNotFoundException">
        /// The specified object could not be found. For any operation that depends on the existence
        /// of a scalable target, this exception is thrown if the scalable target with the specified
        /// service namespace, resource ID, and scalable dimension does not exist. For any operation
        /// that deletes or deregisters a resource, this exception is thrown if the resource cannot
        /// be found.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DeleteScalingPolicy">REST API Reference for DeleteScalingPolicy Operation</seealso>
        Task<DeleteScalingPolicyResponse> DeleteScalingPolicyAsync(DeleteScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteScheduledAction



        /// <summary>
        /// Deletes the specified scheduled action for an Application Auto Scaling scalable target.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/scheduled-scaling-additional-cli-commands.html#delete-scheduled-action">Delete
        /// a scheduled action</a> in the <i>Application Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteScheduledAction service method, as returned by ApplicationAutoScaling.</returns>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to an
        /// Application Auto Scaling resource that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ObjectNotFoundException">
        /// The specified object could not be found. For any operation that depends on the existence
        /// of a scalable target, this exception is thrown if the scalable target with the specified
        /// service namespace, resource ID, and scalable dimension does not exist. For any operation
        /// that deletes or deregisters a resource, this exception is thrown if the resource cannot
        /// be found.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        Task<DeleteScheduledActionResponse> DeleteScheduledActionAsync(DeleteScheduledActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeregisterScalableTarget



        /// <summary>
        /// Deregisters an Application Auto Scaling scalable target when you have finished using
        /// it. To see which resources have been registered, use <a href="https://docs.aws.amazon.com/autoscaling/application/APIReference/API_DescribeScalableTargets.html">DescribeScalableTargets</a>.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// Deregistering a scalable target deletes the scaling policies and the scheduled actions
        /// that are associated with it.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterScalableTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterScalableTarget service method, as returned by ApplicationAutoScaling.</returns>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to an
        /// Application Auto Scaling resource that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ObjectNotFoundException">
        /// The specified object could not be found. For any operation that depends on the existence
        /// of a scalable target, this exception is thrown if the scalable target with the specified
        /// service namespace, resource ID, and scalable dimension does not exist. For any operation
        /// that deletes or deregisters a resource, this exception is thrown if the resource cannot
        /// be found.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DeregisterScalableTarget">REST API Reference for DeregisterScalableTarget Operation</seealso>
        Task<DeregisterScalableTargetResponse> DeregisterScalableTargetAsync(DeregisterScalableTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeScalableTargets



        /// <summary>
        /// Gets information about the scalable targets in the specified namespace.
        /// 
        ///  
        /// <para>
        /// You can filter the results using <code>ResourceIds</code> and <code>ScalableDimension</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalableTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScalableTargets service method, as returned by ApplicationAutoScaling.</returns>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to an
        /// Application Auto Scaling resource that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InvalidNextTokenException">
        /// The next token supplied was invalid.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScalableTargets">REST API Reference for DescribeScalableTargets Operation</seealso>
        Task<DescribeScalableTargetsResponse> DescribeScalableTargetsAsync(DescribeScalableTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeScalingActivities



        /// <summary>
        /// Provides descriptive information about the scaling activities in the specified namespace
        /// from the previous six weeks.
        /// 
        ///  
        /// <para>
        /// You can filter the results using <code>ResourceId</code> and <code>ScalableDimension</code>.
        /// </para>
        ///  
        /// <para>
        /// For information about viewing scaling activities using the Amazon Web Services CLI,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-scaling-activities.html">Scaling
        /// activities for Application Auto Scaling</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScalingActivities service method, as returned by ApplicationAutoScaling.</returns>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to an
        /// Application Auto Scaling resource that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InvalidNextTokenException">
        /// The next token supplied was invalid.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScalingActivities">REST API Reference for DescribeScalingActivities Operation</seealso>
        Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(DescribeScalingActivitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeScalingPolicies



        /// <summary>
        /// Describes the Application Auto Scaling scaling policies for the specified service
        /// namespace.
        /// 
        ///  
        /// <para>
        /// You can filter the results using <code>ResourceId</code>, <code>ScalableDimension</code>,
        /// and <code>PolicyNames</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-target-tracking.html">Target
        /// tracking scaling policies</a> and <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-step-scaling-policies.html">Step
        /// scaling policies</a> in the <i>Application Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScalingPolicies service method, as returned by ApplicationAutoScaling.</returns>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to an
        /// Application Auto Scaling resource that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.FailedResourceAccessException">
        /// Failed access to resources caused an exception. This exception is thrown when Application
        /// Auto Scaling is unable to retrieve the alarms associated with a scaling policy due
        /// to a client error, for example, if the role ARN specified for a scalable target does
        /// not have permission to call the CloudWatch <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_DescribeAlarms.html">DescribeAlarms</a>
        /// on your behalf.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InvalidNextTokenException">
        /// The next token supplied was invalid.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScalingPolicies">REST API Reference for DescribeScalingPolicies Operation</seealso>
        Task<DescribeScalingPoliciesResponse> DescribeScalingPoliciesAsync(DescribeScalingPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeScheduledActions



        /// <summary>
        /// Describes the Application Auto Scaling scheduled actions for the specified service
        /// namespace.
        /// 
        ///  
        /// <para>
        /// You can filter the results using the <code>ResourceId</code>, <code>ScalableDimension</code>,
        /// and <code>ScheduledActionNames</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-scheduled-scaling.html">Scheduled
        /// scaling</a> and <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/scheduled-scaling-additional-cli-commands.html">Managing
        /// scheduled scaling</a> in the <i>Application Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by ApplicationAutoScaling.</returns>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to an
        /// Application Auto Scaling resource that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InvalidNextTokenException">
        /// The next token supplied was invalid.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        Task<DescribeScheduledActionsResponse> DescribeScheduledActionsAsync(DescribeScheduledActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutScalingPolicy



        /// <summary>
        /// Creates or updates a scaling policy for an Application Auto Scaling scalable target.
        /// 
        ///  
        /// <para>
        /// Each scalable target is identified by a service namespace, resource ID, and scalable
        /// dimension. A scaling policy applies to the scalable target identified by those three
        /// attributes. You cannot create a scaling policy until you have registered the resource
        /// as a scalable target.
        /// </para>
        ///  
        /// <para>
        /// Multiple scaling policies can be in force at the same time for the same scalable target.
        /// You can have one or more target tracking scaling policies, one or more step scaling
        /// policies, or both. However, there is a chance that multiple policies could conflict,
        /// instructing the scalable target to scale out or in at the same time. Application Auto
        /// Scaling gives precedence to the policy that provides the largest capacity for both
        /// scale out and scale in. For example, if one policy increases capacity by 3, another
        /// policy increases capacity by 200 percent, and the current capacity is 10, Application
        /// Auto Scaling uses the policy with the highest calculated capacity (200% of 10 = 20)
        /// and scales out to 30. 
        /// </para>
        ///  
        /// <para>
        /// We recommend caution, however, when using target tracking scaling policies with step
        /// scaling policies because conflicts between these policies can cause undesirable behavior.
        /// For example, if the step scaling policy initiates a scale-in activity before the target
        /// tracking policy is ready to scale in, the scale-in activity will not be blocked. After
        /// the scale-in activity completes, the target tracking policy could instruct the scalable
        /// target to scale out again. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-target-tracking.html">Target
        /// tracking scaling policies</a> and <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-step-scaling-policies.html">Step
        /// scaling policies</a> in the <i>Application Auto Scaling User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If a scalable target is deregistered, the scalable target is no longer available to
        /// execute scaling policies. Any scaling policies that were specified for the scalable
        /// target are deleted.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutScalingPolicy service method, as returned by ApplicationAutoScaling.</returns>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to an
        /// Application Auto Scaling resource that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.FailedResourceAccessException">
        /// Failed access to resources caused an exception. This exception is thrown when Application
        /// Auto Scaling is unable to retrieve the alarms associated with a scaling policy due
        /// to a client error, for example, if the role ARN specified for a scalable target does
        /// not have permission to call the CloudWatch <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_DescribeAlarms.html">DescribeAlarms</a>
        /// on your behalf.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.LimitExceededException">
        /// A per-account resource limit is exceeded. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-limits.html">Application
        /// Auto Scaling service quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ObjectNotFoundException">
        /// The specified object could not be found. For any operation that depends on the existence
        /// of a scalable target, this exception is thrown if the scalable target with the specified
        /// service namespace, resource ID, and scalable dimension does not exist. For any operation
        /// that deletes or deregisters a resource, this exception is thrown if the resource cannot
        /// be found.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutScheduledAction



        /// <summary>
        /// Creates or updates a scheduled action for an Application Auto Scaling scalable target.
        /// 
        /// 
        ///  
        /// <para>
        /// Each scalable target is identified by a service namespace, resource ID, and scalable
        /// dimension. A scheduled action applies to the scalable target identified by those three
        /// attributes. You cannot create a scheduled action until you have registered the resource
        /// as a scalable target.
        /// </para>
        ///  
        /// <para>
        /// When start and end times are specified with a recurring schedule using a cron expression
        /// or rates, they form the boundaries for when the recurring action starts and stops.
        /// </para>
        ///  
        /// <para>
        /// To update a scheduled action, specify the parameters that you want to change. If you
        /// don't specify start and end times, the old values are deleted.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-scheduled-scaling.html">Scheduled
        /// scaling</a> in the <i>Application Auto Scaling User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If a scalable target is deregistered, the scalable target is no longer available to
        /// run scheduled actions. Any scheduled actions that were specified for the scalable
        /// target are deleted.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutScheduledAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutScheduledAction service method, as returned by ApplicationAutoScaling.</returns>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to an
        /// Application Auto Scaling resource that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.LimitExceededException">
        /// A per-account resource limit is exceeded. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-limits.html">Application
        /// Auto Scaling service quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ObjectNotFoundException">
        /// The specified object could not be found. For any operation that depends on the existence
        /// of a scalable target, this exception is thrown if the scalable target with the specified
        /// service namespace, resource ID, and scalable dimension does not exist. For any operation
        /// that deletes or deregisters a resource, this exception is thrown if the resource cannot
        /// be found.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/PutScheduledAction">REST API Reference for PutScheduledAction Operation</seealso>
        Task<PutScheduledActionResponse> PutScheduledActionAsync(PutScheduledActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RegisterScalableTarget



        /// <summary>
        /// Registers or updates a scalable target, the resource that you want to scale.
        /// 
        ///  
        /// <para>
        /// Scalable targets are uniquely identified by the combination of resource ID, scalable
        /// dimension, and namespace, which represents some capacity dimension of the underlying
        /// service.
        /// </para>
        ///  
        /// <para>
        /// When you register a new scalable target, you must specify values for the minimum and
        /// maximum capacity. If the specified resource is not active in the target service, this
        /// operation does not change the resource's current capacity. Otherwise, it changes the
        /// resource's current capacity to a value that is inside of this range.
        /// </para>
        ///  
        /// <para>
        /// If you choose to add a scaling policy, current capacity is adjustable within the specified
        /// range when scaling starts. Application Auto Scaling scaling policies will not scale
        /// capacity to values that are outside of the minimum and maximum range.
        /// </para>
        ///  
        /// <para>
        /// After you register a scalable target, you do not need to register it again to use
        /// other Application Auto Scaling operations. To see which resources have been registered,
        /// use <a href="https://docs.aws.amazon.com/autoscaling/application/APIReference/API_DescribeScalableTargets.html">DescribeScalableTargets</a>.
        /// You can also view the scaling policies for a service namespace by using <a href="https://docs.aws.amazon.com/autoscaling/application/APIReference/API_DescribeScalableTargets.html">DescribeScalableTargets</a>.
        /// If you no longer need a scalable target, you can deregister it by using <a href="https://docs.aws.amazon.com/autoscaling/application/APIReference/API_DeregisterScalableTarget.html">DeregisterScalableTarget</a>.
        /// </para>
        ///  
        /// <para>
        /// To update a scalable target, specify the parameters that you want to change. Include
        /// the parameters that identify the scalable target: resource ID, scalable dimension,
        /// and namespace. Any parameters that you don't specify are not changed by this update
        /// request. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you call the <code>RegisterScalableTarget</code> API to update an existing scalable
        /// target, Application Auto Scaling retrieves the current capacity of the resource. If
        /// it is below the minimum capacity or above the maximum capacity, Application Auto Scaling
        /// adjusts the capacity of the scalable target to place it within these bounds, even
        /// if you don't include the <code>MinCapacity</code> or <code>MaxCapacity</code> request
        /// parameters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterScalableTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterScalableTarget service method, as returned by ApplicationAutoScaling.</returns>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ConcurrentUpdateException">
        /// Concurrent updates caused an exception, for example, if you request an update to an
        /// Application Auto Scaling resource that already has a pending update.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.LimitExceededException">
        /// A per-account resource limit is exceeded. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-limits.html">Application
        /// Auto Scaling service quotas</a>.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/RegisterScalableTarget">REST API Reference for RegisterScalableTarget Operation</seealso>
        Task<RegisterScalableTargetResponse> RegisterScalableTargetAsync(RegisterScalableTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}