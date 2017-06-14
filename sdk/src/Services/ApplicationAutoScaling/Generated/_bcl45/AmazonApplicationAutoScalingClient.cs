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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ApplicationAutoScaling.Model;
using Amazon.ApplicationAutoScaling.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ApplicationAutoScaling
{
    /// <summary>
    /// Implementation for accessing ApplicationAutoScaling
    ///
    /// With Application Auto Scaling, you can automatically scale your AWS resources. The
    /// experience similar to that of <a href="https://aws.amazon.com/autoscaling/">Auto Scaling</a>.
    /// You can use Application Auto Scaling to accomplish the following tasks:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Define scaling policies to automatically scale your AWS resources
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Scale your resources in response to CloudWatch alarms
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// View the history of your scaling events
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Application Auto Scaling can scale the following AWS resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon ECS services. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-auto-scaling.html">Service
    /// Auto Scaling</a> in the <i>Amazon EC2 Container Service Developer Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon EC2 Spot fleets. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/fleet-auto-scaling.html">Automatic
    /// Scaling for Spot Fleet</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon EMR clusters. For more information, see <a href="http://docs.aws.amazon.com/ElasticMapReduce/latest/ManagementGuide/emr-automatic-scaling.html">Using
    /// Automatic Scaling in Amazon EMR</a> in the <i>Amazon EMR Management Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// AppStream 2.0 fleets. For more information, see <a href="http://docs.aws.amazon.com/appstream2/latest/developerguide/autoscaling.html">Fleet
    /// Auto Scaling for Amazon AppStream 2.0</a> in the <i>Amazon AppStream 2.0 Developer
    /// Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Provisioned read and write capacity for Amazon DynamoDB tables and global secondary
    /// indexes. For more information, see <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/TargetTracking.html">Auto
    /// Scaling for DynamoDB</a> in the <i>Amazon DynamoDB Developer Guide</i>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For a list of supported regions, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#as-app_region">AWS
    /// Regions and Endpoints: Application Auto Scaling</a> in the <i>AWS General Reference</i>.
    /// </para>
    /// </summary>
    public partial class AmazonApplicationAutoScalingClient : AmazonServiceClient, IAmazonApplicationAutoScaling
    {
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
        /// Deletes the specified Application Auto Scaling scaling policy.
        /// 
        ///  
        /// <para>
        /// Deleting a policy deletes the underlying alarm action, but does not delete the CloudWatch
        /// alarm associated with the scaling policy, even if it no longer has an associated action.
        /// </para>
        ///  
        /// <para>
        /// To create a scaling policy or update an existing one, see <a>PutScalingPolicy</a>.
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
        /// The specified object could not be found. For any <code>Put</code> or <code>Register</code>
        /// API operation, which depends on the existence of a scalable target, this exception
        /// is thrown if the scalable target with the specified service namespace, resource ID,
        /// and scalable dimension does not exist. For any <code>Delete</code> or <code>Deregister</code>
        /// API operation, this exception is thrown if the resource that is to be deleted or deregistered
        /// cannot be found.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DeleteScalingPolicy">REST API Reference for DeleteScalingPolicy Operation</seealso>
        public DeleteScalingPolicyResponse DeleteScalingPolicy(DeleteScalingPolicyRequest request)
        {
            var marshaller = new DeleteScalingPolicyRequestMarshaller();
            var unmarshaller = DeleteScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteScalingPolicyRequest,DeleteScalingPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScalingPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DeleteScalingPolicy">REST API Reference for DeleteScalingPolicy Operation</seealso>
        public Task<DeleteScalingPolicyResponse> DeleteScalingPolicyAsync(DeleteScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteScalingPolicyRequestMarshaller();
            var unmarshaller = DeleteScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScalingPolicyRequest,DeleteScalingPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterScalableTarget


        /// <summary>
        /// Deregisters a scalable target.
        /// 
        ///  
        /// <para>
        /// Deregistering a scalable target deletes the scaling policies that are associated with
        /// it.
        /// </para>
        ///  
        /// <para>
        /// To create a scalable target or update an existing one, see <a>RegisterScalableTarget</a>.
        /// </para>
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
        /// The specified object could not be found. For any <code>Put</code> or <code>Register</code>
        /// API operation, which depends on the existence of a scalable target, this exception
        /// is thrown if the scalable target with the specified service namespace, resource ID,
        /// and scalable dimension does not exist. For any <code>Delete</code> or <code>Deregister</code>
        /// API operation, this exception is thrown if the resource that is to be deleted or deregistered
        /// cannot be found.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DeregisterScalableTarget">REST API Reference for DeregisterScalableTarget Operation</seealso>
        public DeregisterScalableTargetResponse DeregisterScalableTarget(DeregisterScalableTargetRequest request)
        {
            var marshaller = new DeregisterScalableTargetRequestMarshaller();
            var unmarshaller = DeregisterScalableTargetResponseUnmarshaller.Instance;

            return Invoke<DeregisterScalableTargetRequest,DeregisterScalableTargetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterScalableTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterScalableTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DeregisterScalableTarget">REST API Reference for DeregisterScalableTarget Operation</seealso>
        public Task<DeregisterScalableTargetResponse> DeregisterScalableTargetAsync(DeregisterScalableTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterScalableTargetRequestMarshaller();
            var unmarshaller = DeregisterScalableTargetResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterScalableTargetRequest,DeregisterScalableTargetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalableTargets


        /// <summary>
        /// Provides descriptive information about the scalable targets in the specified namespace.
        /// 
        ///  
        /// <para>
        /// You can filter the results using the <code>ResourceIds</code> and <code>ScalableDimension</code>
        /// parameters.
        /// </para>
        ///  
        /// <para>
        /// To create a scalable target or update an existing one, see <a>RegisterScalableTarget</a>.
        /// If you are no longer using a scalable target, you can deregister it using <a>DeregisterScalableTarget</a>.
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
        public DescribeScalableTargetsResponse DescribeScalableTargets(DescribeScalableTargetsRequest request)
        {
            var marshaller = new DescribeScalableTargetsRequestMarshaller();
            var unmarshaller = DescribeScalableTargetsResponseUnmarshaller.Instance;

            return Invoke<DescribeScalableTargetsRequest,DescribeScalableTargetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalableTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalableTargets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScalableTargets">REST API Reference for DescribeScalableTargets Operation</seealso>
        public Task<DescribeScalableTargetsResponse> DescribeScalableTargetsAsync(DescribeScalableTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeScalableTargetsRequestMarshaller();
            var unmarshaller = DescribeScalableTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalableTargetsRequest,DescribeScalableTargetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalingActivities


        /// <summary>
        /// Provides descriptive information about the scaling activities in the specified namespace
        /// from the previous six weeks.
        /// 
        ///  
        /// <para>
        /// You can filter the results using the <code>ResourceId</code> and <code>ScalableDimension</code>
        /// parameters.
        /// </para>
        ///  
        /// <para>
        /// Scaling activities are triggered by CloudWatch alarms that are associated with scaling
        /// policies. To view the scaling policies for a service namespace, see <a>DescribeScalingPolicies</a>.
        /// To create a scaling policy or update an existing one, see <a>PutScalingPolicy</a>.
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
        public DescribeScalingActivitiesResponse DescribeScalingActivities(DescribeScalingActivitiesRequest request)
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScalingActivities">REST API Reference for DescribeScalingActivities Operation</seealso>
        public Task<DescribeScalingActivitiesResponse> DescribeScalingActivitiesAsync(DescribeScalingActivitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeScalingActivitiesRequestMarshaller();
            var unmarshaller = DescribeScalingActivitiesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalingActivitiesRequest,DescribeScalingActivitiesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalingPolicies


        /// <summary>
        /// Provides descriptive information about the scaling policies in the specified namespace.
        /// 
        ///  
        /// <para>
        /// You can filter the results using the <code>ResourceId</code>, <code>ScalableDimension</code>,
        /// and <code>PolicyNames</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// To create a scaling policy or update an existing one, see <a>PutScalingPolicy</a>.
        /// If you are no longer using a scaling policy, you can delete it using <a>DeleteScalingPolicy</a>.
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
        /// not have permission to call the CloudWatch <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_DescribeAlarms.html">DescribeAlarms</a>
        /// API operation on behalf of your account.
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
        public DescribeScalingPoliciesResponse DescribeScalingPolicies(DescribeScalingPoliciesRequest request)
        {
            var marshaller = new DescribeScalingPoliciesRequestMarshaller();
            var unmarshaller = DescribeScalingPoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingPoliciesRequest,DescribeScalingPoliciesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/DescribeScalingPolicies">REST API Reference for DescribeScalingPolicies Operation</seealso>
        public Task<DescribeScalingPoliciesResponse> DescribeScalingPoliciesAsync(DescribeScalingPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeScalingPoliciesRequestMarshaller();
            var unmarshaller = DescribeScalingPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalingPoliciesRequest,DescribeScalingPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutScalingPolicy


        /// <summary>
        /// Creates or updates a policy for an Application Auto Scaling scalable target.
        /// 
        ///  
        /// <para>
        /// Each scalable target is identified by a service namespace, resource ID, and scalable
        /// dimension. A scaling policy applies to the scalable target identified by those three
        /// attributes. You cannot create a scaling policy without first registering a scalable
        /// target using <a>RegisterScalableTarget</a>.
        /// </para>
        ///  
        /// <para>
        /// To update a policy, specify its policy name and the parameters that you want to change.
        /// Any parameters that you don't specify are not changed by this update request.
        /// </para>
        ///  
        /// <para>
        /// You can view the scaling policies for a service namespace using <a>DescribeScalingPolicies</a>.
        /// If you are no longer using a scaling policy, you can delete it using <a>DeleteScalingPolicy</a>.
        /// </para>
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
        /// not have permission to call the CloudWatch <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_DescribeAlarms.html">DescribeAlarms</a>
        /// API operation on behalf of your account.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.InternalServiceException">
        /// The service encountered an internal error.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.LimitExceededException">
        /// Your account exceeded a limit. This exception is thrown when a per-account resource
        /// limit is exceeded. For more information, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_as-app">Application
        /// Auto Scaling Limits</a>.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ObjectNotFoundException">
        /// The specified object could not be found. For any <code>Put</code> or <code>Register</code>
        /// API operation, which depends on the existence of a scalable target, this exception
        /// is thrown if the scalable target with the specified service namespace, resource ID,
        /// and scalable dimension does not exist. For any <code>Delete</code> or <code>Deregister</code>
        /// API operation, this exception is thrown if the resource that is to be deleted or deregistered
        /// cannot be found.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        public PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest request)
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        public Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutScalingPolicyRequestMarshaller();
            var unmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutScalingPolicyRequest,PutScalingPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterScalableTarget


        /// <summary>
        /// Registers or updates a scalable target. A scalable target is a resource that Application
        /// Auto Scaling can scale out or scale in. After you have registered a scalable target,
        /// you can use this operation to update the minimum and maximum values for your scalable
        /// dimension.
        /// 
        ///  
        /// <para>
        /// After you register a scalable target, you can create and apply scaling policies using
        /// <a>PutScalingPolicy</a>. You can view the scaling policies for a service namespace
        /// using <a>DescribeScalableTargets</a>. If you are no longer using a scalable target,
        /// you can deregister it using <a>DeregisterScalableTarget</a>.
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
        /// Your account exceeded a limit. This exception is thrown when a per-account resource
        /// limit is exceeded. For more information, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_as-app">Application
        /// Auto Scaling Limits</a>.
        /// </exception>
        /// <exception cref="Amazon.ApplicationAutoScaling.Model.ValidationException">
        /// An exception was thrown for a validation issue. Review the available parameters for
        /// the API request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/RegisterScalableTarget">REST API Reference for RegisterScalableTarget Operation</seealso>
        public RegisterScalableTargetResponse RegisterScalableTarget(RegisterScalableTargetRequest request)
        {
            var marshaller = new RegisterScalableTargetRequestMarshaller();
            var unmarshaller = RegisterScalableTargetResponseUnmarshaller.Instance;

            return Invoke<RegisterScalableTargetRequest,RegisterScalableTargetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterScalableTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterScalableTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/application-autoscaling-2016-02-06/RegisterScalableTarget">REST API Reference for RegisterScalableTarget Operation</seealso>
        public Task<RegisterScalableTargetResponse> RegisterScalableTargetAsync(RegisterScalableTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterScalableTargetRequestMarshaller();
            var unmarshaller = RegisterScalableTargetResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterScalableTargetRequest,RegisterScalableTargetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}