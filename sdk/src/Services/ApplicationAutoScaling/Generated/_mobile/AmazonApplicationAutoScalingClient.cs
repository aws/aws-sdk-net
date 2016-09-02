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
    /// Application Auto Scaling is a general purpose Auto Scaling service for supported elastic
    /// AWS resources. With Application Auto Scaling, you can automatically scale your AWS
    /// resources, with an experience similar to that of Auto Scaling.
    /// 
    ///  
    /// <para>
    /// Application Auto Scaling supports scaling the following AWS resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon ECS services
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon EC2 Spot fleet instances
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can use Application Auto Scaling to accomplish the following tasks:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Define scaling policies for automatically adjusting your AWS resources
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Scale your resources in response to CloudWatch alarms
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// View history of your scaling events 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Application Auto Scaling is available in the following regions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>us-east-1</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>us-west-1</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>us-west-2</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ap-southeast-1</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ap-southeast-2</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ap-northeast-1</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>eu-central-1</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>eu-west-1</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonApplicationAutoScalingClient : AmazonServiceClient, IAmazonApplicationAutoScaling
    {
        
        #region Constructors

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

        internal DeleteScalingPolicyResponse DeleteScalingPolicy(DeleteScalingPolicyRequest request)
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
        public Task<DeleteScalingPolicyResponse> DeleteScalingPolicyAsync(DeleteScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteScalingPolicyRequestMarshaller();
            var unmarshaller = DeleteScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScalingPolicyRequest,DeleteScalingPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterScalableTarget

        internal DeregisterScalableTargetResponse DeregisterScalableTarget(DeregisterScalableTargetRequest request)
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
        public Task<DeregisterScalableTargetResponse> DeregisterScalableTargetAsync(DeregisterScalableTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterScalableTargetRequestMarshaller();
            var unmarshaller = DeregisterScalableTargetResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterScalableTargetRequest,DeregisterScalableTargetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalableTargets

        internal DescribeScalableTargetsResponse DescribeScalableTargets(DescribeScalableTargetsRequest request)
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
        public Task<DescribeScalableTargetsResponse> DescribeScalableTargetsAsync(DescribeScalableTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeScalableTargetsRequestMarshaller();
            var unmarshaller = DescribeScalableTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalableTargetsRequest,DescribeScalableTargetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalingActivities

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
        
        #region  DescribeScalingPolicies

        internal DescribeScalingPoliciesResponse DescribeScalingPolicies(DescribeScalingPoliciesRequest request)
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
        public Task<DescribeScalingPoliciesResponse> DescribeScalingPoliciesAsync(DescribeScalingPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeScalingPoliciesRequestMarshaller();
            var unmarshaller = DescribeScalingPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalingPoliciesRequest,DescribeScalingPoliciesResponse>(request, marshaller, 
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
        
        #region  RegisterScalableTarget

        internal RegisterScalableTargetResponse RegisterScalableTarget(RegisterScalableTargetRequest request)
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