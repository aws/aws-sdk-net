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
using System.Net;

using Amazon.ApplicationAutoScaling.Model;
using Amazon.ApplicationAutoScaling.Model.Internal.MarshallTransformations;
using Amazon.ApplicationAutoScaling.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ApplicationAutoScaling
{
    /// <summary>
    /// Implementation for accessing ApplicationAutoScaling
    ///
    /// With Application Auto Scaling, you can configure automatic scaling for the following
    /// resources:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Amazon ECS services
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon EC2 Spot Fleet requests
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon EMR clusters
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon AppStream 2.0 fleets
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon DynamoDB tables and global secondary indexes throughput capacity
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Aurora Replicas
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon SageMaker endpoint variants
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Custom resources provided by your own applications or services
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Comprehend document classification and entity recognizer endpoints
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AWS Lambda function provisioned concurrency
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Keyspaces (for Apache Cassandra) tables
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Managed Streaming for Apache Kafka cluster storage
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
    /// Register and manage scalable targets - Register AWS or custom resources as scalable
    /// targets (a resource that Application Auto Scaling can scale), set minimum and maximum
    /// capacity limits, and retrieve information on existing scalable targets.
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
    public partial class AmazonApplicationAutoScalingClient : AmazonServiceClient, IAmazonApplicationAutoScaling
    {
        private static IServiceMetadata serviceMetadata = new AmazonApplicationAutoScalingMetadata();

        #region Constructors

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with the credentials loaded from the application's
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
        public AmazonApplicationAutoScalingClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApplicationAutoScalingConfig()) { }

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with the credentials loaded from the application's
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
        public AmazonApplicationAutoScalingClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonApplicationAutoScalingConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonApplicationAutoScalingClient Configuration Object</param>
        public AmazonApplicationAutoScalingClient(AmazonApplicationAutoScalingConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonApplicationAutoScalingClient(AWSCredentials credentials)
            : this(credentials, new AmazonApplicationAutoScalingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationAutoScalingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonApplicationAutoScalingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with AWS Credentials and an
        /// AmazonApplicationAutoScalingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonApplicationAutoScalingClient Configuration Object</param>
        public AmazonApplicationAutoScalingClient(AWSCredentials credentials, AmazonApplicationAutoScalingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonApplicationAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApplicationAutoScalingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonApplicationAutoScalingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApplicationAutoScalingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonApplicationAutoScalingClient Configuration Object</param>
        public AmazonApplicationAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonApplicationAutoScalingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonApplicationAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApplicationAutoScalingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonApplicationAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonApplicationAutoScalingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonApplicationAutoScalingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonApplicationAutoScalingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonApplicationAutoScalingClient Configuration Object</param>
        public AmazonApplicationAutoScalingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonApplicationAutoScalingConfig clientConfig)
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
        /// a Step Scaling Policy</a> and <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-target-tracking.html#delete-target-tracking-policy">Delete
        /// a Target Tracking Scaling Policy</a> in the <i>Application Auto Scaling User Guide</i>.
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
        public virtual DeleteScalingPolicyResponse DeleteScalingPolicy(DeleteScalingPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteScalingPolicyResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDeleteScalingPolicy(DeleteScalingPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScalingPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScalingPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteScalingPolicyResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DeleteScalingPolicy">REST API Reference for DeleteScalingPolicy Operation</seealso>
        public virtual DeleteScalingPolicyResponse EndDeleteScalingPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteScalingPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteScheduledAction

        /// <summary>
        /// Deletes the specified scheduled action for an Application Auto Scaling scalable target.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-scheduled-scaling.html#delete-scheduled-action">Delete
        /// a Scheduled Action</a> in the <i>Application Auto Scaling User Guide</i>.
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
        public virtual DeleteScheduledActionResponse DeleteScheduledAction(DeleteScheduledActionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction operation on AmazonApplicationAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteScheduledAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        public virtual IAsyncResult BeginDeleteScheduledAction(DeleteScheduledActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScheduledActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScheduledAction.</param>
        /// 
        /// <returns>Returns a  DeleteScheduledActionResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        public virtual DeleteScheduledActionResponse EndDeleteScheduledAction(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteScheduledActionResponse>(asyncResult);
        }

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
        public virtual DeregisterScalableTargetResponse DeregisterScalableTarget(DeregisterScalableTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterScalableTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterScalableTargetResponseUnmarshaller.Instance;

            return Invoke<DeregisterScalableTargetResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDeregisterScalableTarget(DeregisterScalableTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterScalableTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterScalableTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterScalableTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterScalableTarget.</param>
        /// 
        /// <returns>Returns a  DeregisterScalableTargetResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DeregisterScalableTarget">REST API Reference for DeregisterScalableTarget Operation</seealso>
        public virtual DeregisterScalableTargetResponse EndDeregisterScalableTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterScalableTargetResponse>(asyncResult);
        }

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
        public virtual DescribeScalableTargetsResponse DescribeScalableTargets(DescribeScalableTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalableTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalableTargetsResponseUnmarshaller.Instance;

            return Invoke<DescribeScalableTargetsResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDescribeScalableTargets(DescribeScalableTargetsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalableTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalableTargetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScalableTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalableTargets.</param>
        /// 
        /// <returns>Returns a  DescribeScalableTargetsResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScalableTargets">REST API Reference for DescribeScalableTargets Operation</seealso>
        public virtual DescribeScalableTargetsResponse EndDescribeScalableTargets(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeScalableTargetsResponse>(asyncResult);
        }

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
        public virtual DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingActivitiesResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingActivitiesResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDescribeScalingActivities(DescribeScalingActivitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingActivitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingActivitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScalingActivities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingActivities.</param>
        /// 
        /// <returns>Returns a  DescribeScalingActivitiesResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScalingActivities">REST API Reference for DescribeScalingActivities Operation</seealso>
        public virtual DescribeScalingActivitiesResponse EndDescribeScalingActivities(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeScalingActivitiesResponse>(asyncResult);
        }

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
        /// Tracking Scaling Policies</a> and <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-step-scaling-policies.html">Step
        /// Scaling Policies</a> in the <i>Application Auto Scaling User Guide</i>.
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
        public virtual DescribeScalingPoliciesResponse DescribeScalingPolicies(DescribeScalingPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingPoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingPoliciesResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDescribeScalingPolicies(DescribeScalingPoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScalingPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScalingPolicies.</param>
        /// 
        /// <returns>Returns a  DescribeScalingPoliciesResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScalingPolicies">REST API Reference for DescribeScalingPolicies Operation</seealso>
        public virtual DescribeScalingPoliciesResponse EndDescribeScalingPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeScalingPoliciesResponse>(asyncResult);
        }

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
        /// Scaling</a> in the <i>Application Auto Scaling User Guide</i>.
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
        public virtual DescribeScheduledActionsResponse DescribeScheduledActions(DescribeScheduledActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledActionsResponseUnmarshaller.Instance;

            return Invoke<DescribeScheduledActionsResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginDescribeScheduledActions(DescribeScheduledActionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledActionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScheduledActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScheduledActions.</param>
        /// 
        /// <returns>Returns a  DescribeScheduledActionsResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        public virtual DescribeScheduledActionsResponse EndDescribeScheduledActions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeScheduledActionsResponse>(asyncResult);
        }

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
        /// Tracking Scaling Policies</a> and <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-step-scaling-policies.html">Step
        /// Scaling Policies</a> in the <i>Application Auto Scaling User Guide</i>.
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
        /// A per-account resource limit is exceeded. For more information, see <a href="https://docs.aws.amazon.com/ApplicationAutoScaling/latest/userguide/application-auto-scaling-limits.html">Application
        /// Auto Scaling Limits</a>.
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
        public virtual PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy operation on AmazonApplicationAutoScalingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutScalingPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutScalingPolicy(PutScalingPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutScalingPolicy.</param>
        /// 
        /// <returns>Returns a  PutScalingPolicyResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        public virtual PutScalingPolicyResponse EndPutScalingPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutScalingPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutScheduledAction

        /// <summary>
        /// Creates or updates a scheduled action for an Application Auto Scaling scalable target.
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
        /// or rates, they form the boundaries of when the recurring action starts and stops.
        /// </para>
        ///  
        /// <para>
        /// To update a scheduled action, specify the parameters that you want to change. If you
        /// don't specify start and end times, the old values are deleted.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-scheduled-scaling.html">Scheduled
        /// Scaling</a> in the <i>Application Auto Scaling User Guide</i>.
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
        /// A per-account resource limit is exceeded. For more information, see <a href="https://docs.aws.amazon.com/ApplicationAutoScaling/latest/userguide/application-auto-scaling-limits.html">Application
        /// Auto Scaling Limits</a>.
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
        public virtual PutScheduledActionResponse PutScheduledAction(PutScheduledActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScheduledActionResponseUnmarshaller.Instance;

            return Invoke<PutScheduledActionResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginPutScheduledAction(PutScheduledActionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScheduledActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScheduledActionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutScheduledAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutScheduledAction.</param>
        /// 
        /// <returns>Returns a  PutScheduledActionResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/PutScheduledAction">REST API Reference for PutScheduledAction Operation</seealso>
        public virtual PutScheduledActionResponse EndPutScheduledAction(IAsyncResult asyncResult)
        {
            return EndInvoke<PutScheduledActionResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterScalableTarget

        /// <summary>
        /// Registers or updates a scalable target. 
        /// 
        ///  
        /// <para>
        /// A scalable target is a resource that Application Auto Scaling can scale out and scale
        /// in. Scalable targets are uniquely identified by the combination of resource ID, scalable
        /// dimension, and namespace. 
        /// </para>
        ///  
        /// <para>
        /// When you register a new scalable target, you must specify values for minimum and maximum
        /// capacity. Current capacity will be adjusted within the specified range when scaling
        /// starts. Application Auto Scaling scaling policies will not scale capacity to values
        /// that are outside of this range.
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
        /// A per-account resource limit is exceeded. For more information, see <a href="https://docs.aws.amazon.com/ApplicationAutoScaling/latest/userguide/application-auto-scaling-limits.html">Application
        /// Auto Scaling Limits</a>.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/RegisterScalableTarget">REST API Reference for RegisterScalableTarget Operation</seealso>
        public virtual RegisterScalableTargetResponse RegisterScalableTarget(RegisterScalableTargetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterScalableTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterScalableTargetResponseUnmarshaller.Instance;

            return Invoke<RegisterScalableTargetResponse>(request, options);
        }

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
        public virtual IAsyncResult BeginRegisterScalableTarget(RegisterScalableTargetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterScalableTargetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterScalableTargetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterScalableTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterScalableTarget.</param>
        /// 
        /// <returns>Returns a  RegisterScalableTargetResult from ApplicationAutoScaling.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/RegisterScalableTarget">REST API Reference for RegisterScalableTarget Operation</seealso>
        public virtual RegisterScalableTargetResponse EndRegisterScalableTarget(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterScalableTargetResponse>(asyncResult);
        }

        #endregion
        
    }
}