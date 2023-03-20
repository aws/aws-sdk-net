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
    /// To learn more about Application Auto Scaling, see the <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/what-is-application-auto-scaling.html">Application
    /// Auto Scaling User Guide</a>.
    /// </para>
    ///  
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
    /// </summary>
    public partial interface IAmazonApplicationAutoScaling : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
        DeleteScalingPolicyResponse DeleteScalingPolicy(DeleteScalingPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScalingPolicy operation on AmazonApplicationAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteScalingPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DeleteScalingPolicy">REST API Reference for DeleteScalingPolicy Operation</seealso>
        IAsyncResult BeginDeleteScalingPolicy(DeleteScalingPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScalingPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteScalingPolicyResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DeleteScalingPolicy">REST API Reference for DeleteScalingPolicy Operation</seealso>
        DeleteScalingPolicyResponse EndDeleteScalingPolicy(IAsyncResult asyncResult);

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
        DeleteScheduledActionResponse DeleteScheduledAction(DeleteScheduledActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction operation on AmazonApplicationAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteScheduledAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        IAsyncResult BeginDeleteScheduledAction(DeleteScheduledActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScheduledAction.</param>
        /// 
        /// <returns>Returns a  DeleteScheduledActionResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        DeleteScheduledActionResponse EndDeleteScheduledAction(IAsyncResult asyncResult);

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
        DeregisterScalableTargetResponse DeregisterScalableTarget(DeregisterScalableTargetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterScalableTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterScalableTarget operation on AmazonApplicationAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterScalableTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DeregisterScalableTarget">REST API Reference for DeregisterScalableTarget Operation</seealso>
        IAsyncResult BeginDeregisterScalableTarget(DeregisterScalableTargetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterScalableTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterScalableTarget.</param>
        /// 
        /// <returns>Returns a  DeregisterScalableTargetResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DeregisterScalableTarget">REST API Reference for DeregisterScalableTarget Operation</seealso>
        DeregisterScalableTargetResponse EndDeregisterScalableTarget(IAsyncResult asyncResult);

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
        DescribeScalableTargetsResponse DescribeScalableTargets(DescribeScalableTargetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalableTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalableTargets operation on AmazonApplicationAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScalableTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScalableTargets">REST API Reference for DescribeScalableTargets Operation</seealso>
        IAsyncResult BeginDescribeScalableTargets(DescribeScalableTargetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScalableTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalableTargets.</param>
        /// 
        /// <returns>Returns a  DescribeScalableTargetsResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScalableTargets">REST API Reference for DescribeScalableTargets Operation</seealso>
        DescribeScalableTargetsResponse EndDescribeScalableTargets(IAsyncResult asyncResult);

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
        DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingActivities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingActivities operation on AmazonApplicationAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScalingActivities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScalingActivities">REST API Reference for DescribeScalingActivities Operation</seealso>
        IAsyncResult BeginDescribeScalingActivities(DescribeScalingActivitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScalingActivities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingActivities.</param>
        /// 
        /// <returns>Returns a  DescribeScalingActivitiesResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScalingActivities">REST API Reference for DescribeScalingActivities Operation</seealso>
        DescribeScalingActivitiesResponse EndDescribeScalingActivities(IAsyncResult asyncResult);

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
        DescribeScalingPoliciesResponse DescribeScalingPolicies(DescribeScalingPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPolicies operation on AmazonApplicationAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScalingPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScalingPolicies">REST API Reference for DescribeScalingPolicies Operation</seealso>
        IAsyncResult BeginDescribeScalingPolicies(DescribeScalingPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScalingPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingPolicies.</param>
        /// 
        /// <returns>Returns a  DescribeScalingPoliciesResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScalingPolicies">REST API Reference for DescribeScalingPolicies Operation</seealso>
        DescribeScalingPoliciesResponse EndDescribeScalingPolicies(IAsyncResult asyncResult);

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
        DescribeScheduledActionsResponse DescribeScheduledActions(DescribeScheduledActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScheduledActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions operation on AmazonApplicationAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScheduledActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        IAsyncResult BeginDescribeScheduledActions(DescribeScheduledActionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScheduledActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScheduledActions.</param>
        /// 
        /// <returns>Returns a  DescribeScheduledActionsResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        DescribeScheduledActionsResponse EndDescribeScheduledActions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns all the tags on the specified Application Auto Scaling scalable target.
        /// 
        ///  
        /// <para>
        /// For general information about tags, including the format and syntax, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ApplicationAutoScaling.</returns>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonApplicationAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// use scaling policies. Any scaling policies that were specified for the scalable target
        /// are deleted.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy service method.</param>
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
        PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy operation on AmazonApplicationAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutScalingPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        IAsyncResult BeginPutScalingPolicy(PutScalingPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutScalingPolicy.</param>
        /// 
        /// <returns>Returns a  PutScalingPolicyResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        PutScalingPolicyResponse EndPutScalingPolicy(IAsyncResult asyncResult);

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
        /// When you specify start and end times with a recurring schedule using a cron expression
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
        PutScheduledActionResponse PutScheduledAction(PutScheduledActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScheduledAction operation on AmazonApplicationAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutScheduledAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/PutScheduledAction">REST API Reference for PutScheduledAction Operation</seealso>
        IAsyncResult BeginPutScheduledAction(PutScheduledActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutScheduledAction.</param>
        /// 
        /// <returns>Returns a  PutScheduledActionResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/PutScheduledAction">REST API Reference for PutScheduledAction Operation</seealso>
        PutScheduledActionResponse EndPutScheduledAction(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterScalableTarget


        /// <summary>
        /// Registers or updates a scalable target, which is the resource that you want to scale.
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
        /// If you add a scaling policy, current capacity is adjustable within the specified range
        /// when scaling starts. Application Auto Scaling scaling policies will not scale capacity
        /// to values that are outside of the minimum and maximum range.
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
        /// If you call the <code>RegisterScalableTarget</code> API operation to create a scalable
        /// target, there might be a brief delay until the operation achieves <a href="https://en.wikipedia.org/wiki/Eventual_consistency">eventual
        /// consistency</a>. You might become aware of this brief delay if you get unexpected
        /// errors when performing sequential operations. The typical strategy is to retry the
        /// request, and some Amazon Web Services SDKs include automatic backoff and retry logic.
        /// </para>
        ///  
        /// <para>
        /// If you call the <code>RegisterScalableTarget</code> API operation to update an existing
        /// scalable target, Application Auto Scaling retrieves the current capacity of the resource.
        /// If it's below the minimum capacity or above the maximum capacity, Application Auto
        /// Scaling adjusts the capacity of the scalable target to place it within these bounds,
        /// even if you don't include the <code>MinCapacity</code> or <code>MaxCapacity</code>
        /// request parameters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterScalableTarget service method.</param>
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
        RegisterScalableTargetResponse RegisterScalableTarget(RegisterScalableTargetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterScalableTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterScalableTarget operation on AmazonApplicationAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterScalableTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/RegisterScalableTarget">REST API Reference for RegisterScalableTarget Operation</seealso>
        IAsyncResult BeginRegisterScalableTarget(RegisterScalableTargetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterScalableTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterScalableTarget.</param>
        /// 
        /// <returns>Returns a  RegisterScalableTargetResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/RegisterScalableTarget">REST API Reference for RegisterScalableTarget Operation</seealso>
        RegisterScalableTargetResponse EndRegisterScalableTarget(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or edits tags on an Application Auto Scaling scalable target.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a tag key and a tag value, which are both case-sensitive strings.
        /// To add a tag, specify a new tag key and a tag value. To edit a tag, specify an existing
        /// tag key and a new tag value.
        /// </para>
        ///  
        /// <para>
        /// You can use this operation to tag an Application Auto Scaling scalable target, but
        /// you cannot tag a scaling policy or scheduled action.
        /// </para>
        ///  
        /// <para>
        /// You can also add tags to an Application Auto Scaling scalable target while creating
        /// it (<code>RegisterScalableTarget</code>).
        /// </para>
        ///  
        /// <para>
        /// For general information about tags, including the format and syntax, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// Use tags to control access to a scalable target. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/resource-tagging-support.html">Tagging
        /// support for Application Auto Scaling</a> in the <i>Application Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ApplicationAutoScaling.</returns>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.TooManyTagsException">
        /// The request contains too many tags. Try the request again with fewer tags.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonApplicationAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes tags from an Application Auto Scaling scalable target. To delete a tag, specify
        /// the tag key and the Application Auto Scaling scalable target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ApplicationAutoScaling.</returns>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonApplicationAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
    }
}