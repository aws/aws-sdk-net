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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.AutoScalingPlans.Model;
using Amazon.AutoScalingPlans.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AutoScalingPlans
{
    /// <summary>
    /// Implementation for accessing AutoScalingPlans
    ///
    /// AWS Auto Scaling 
    /// <para>
    /// Use AWS Auto Scaling to quickly discover all the scalable AWS resources for your application
    /// and configure dynamic scaling for your scalable resources.
    /// </para>
    ///  
    /// <para>
    /// To get started, create a scaling plan with a set of instructions used to configure
    /// dynamic scaling for the scalable resources in your application. AWS Auto Scaling creates
    /// target tracking scaling policies for the scalable resources in your scaling plan.
    /// Target tracking scaling policies adjust the capacity of your scalable resource as
    /// required to maintain resource utilization at the target value that you specified.
    /// </para>
    /// </summary>
    public partial class AmazonAutoScalingPlansClient : AmazonServiceClient, IAmazonAutoScalingPlans
    {
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with the credentials loaded from the application's
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
        public AmazonAutoScalingPlansClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAutoScalingPlansConfig()) { }

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with the credentials loaded from the application's
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
        public AmazonAutoScalingPlansClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAutoScalingPlansConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAutoScalingPlansClient Configuration Object</param>
        public AmazonAutoScalingPlansClient(AmazonAutoScalingPlansConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAutoScalingPlansClient(AWSCredentials credentials)
            : this(credentials, new AmazonAutoScalingPlansConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAutoScalingPlansClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAutoScalingPlansConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with AWS Credentials and an
        /// AmazonAutoScalingPlansClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAutoScalingPlansClient Configuration Object</param>
        public AmazonAutoScalingPlansClient(AWSCredentials credentials, AmazonAutoScalingPlansConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAutoScalingPlansClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAutoScalingPlansConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAutoScalingPlansClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAutoScalingPlansConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAutoScalingPlansClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAutoScalingPlansClient Configuration Object</param>
        public AmazonAutoScalingPlansClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAutoScalingPlansConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAutoScalingPlansClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAutoScalingPlansConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAutoScalingPlansClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAutoScalingPlansConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAutoScalingPlansClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAutoScalingPlansClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAutoScalingPlansClient Configuration Object</param>
        public AmazonAutoScalingPlansClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAutoScalingPlansConfig clientConfig)
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

        
        #region  CreateScalingPlan

        internal virtual CreateScalingPlanResponse CreateScalingPlan(CreateScalingPlanRequest request)
        {
            var marshaller = CreateScalingPlanRequestMarshaller.Instance;
            var unmarshaller = CreateScalingPlanResponseUnmarshaller.Instance;

            return Invoke<CreateScalingPlanRequest,CreateScalingPlanResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateScalingPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateScalingPlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/CreateScalingPlan">REST API Reference for CreateScalingPlan Operation</seealso>
        public virtual Task<CreateScalingPlanResponse> CreateScalingPlanAsync(CreateScalingPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateScalingPlanRequestMarshaller.Instance;
            var unmarshaller = CreateScalingPlanResponseUnmarshaller.Instance;

            return InvokeAsync<CreateScalingPlanRequest,CreateScalingPlanResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteScalingPlan

        internal virtual DeleteScalingPlanResponse DeleteScalingPlan(DeleteScalingPlanRequest request)
        {
            var marshaller = DeleteScalingPlanRequestMarshaller.Instance;
            var unmarshaller = DeleteScalingPlanResponseUnmarshaller.Instance;

            return Invoke<DeleteScalingPlanRequest,DeleteScalingPlanResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScalingPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScalingPlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DeleteScalingPlan">REST API Reference for DeleteScalingPlan Operation</seealso>
        public virtual Task<DeleteScalingPlanResponse> DeleteScalingPlanAsync(DeleteScalingPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteScalingPlanRequestMarshaller.Instance;
            var unmarshaller = DeleteScalingPlanResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScalingPlanRequest,DeleteScalingPlanResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalingPlanResources

        internal virtual DescribeScalingPlanResourcesResponse DescribeScalingPlanResources(DescribeScalingPlanResourcesRequest request)
        {
            var marshaller = DescribeScalingPlanResourcesRequestMarshaller.Instance;
            var unmarshaller = DescribeScalingPlanResourcesResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingPlanResourcesRequest,DescribeScalingPlanResourcesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingPlanResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPlanResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DescribeScalingPlanResources">REST API Reference for DescribeScalingPlanResources Operation</seealso>
        public virtual Task<DescribeScalingPlanResourcesResponse> DescribeScalingPlanResourcesAsync(DescribeScalingPlanResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeScalingPlanResourcesRequestMarshaller.Instance;
            var unmarshaller = DescribeScalingPlanResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalingPlanResourcesRequest,DescribeScalingPlanResourcesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalingPlans

        internal virtual DescribeScalingPlansResponse DescribeScalingPlans(DescribeScalingPlansRequest request)
        {
            var marshaller = DescribeScalingPlansRequestMarshaller.Instance;
            var unmarshaller = DescribeScalingPlansResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingPlansRequest,DescribeScalingPlansResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingPlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPlans operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/DescribeScalingPlans">REST API Reference for DescribeScalingPlans Operation</seealso>
        public virtual Task<DescribeScalingPlansResponse> DescribeScalingPlansAsync(DescribeScalingPlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeScalingPlansRequestMarshaller.Instance;
            var unmarshaller = DescribeScalingPlansResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalingPlansRequest,DescribeScalingPlansResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateScalingPlan

        internal virtual UpdateScalingPlanResponse UpdateScalingPlan(UpdateScalingPlanRequest request)
        {
            var marshaller = UpdateScalingPlanRequestMarshaller.Instance;
            var unmarshaller = UpdateScalingPlanResponseUnmarshaller.Instance;

            return Invoke<UpdateScalingPlanRequest,UpdateScalingPlanResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateScalingPlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateScalingPlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/autoscaling-plans-2018-01-06/UpdateScalingPlan">REST API Reference for UpdateScalingPlan Operation</seealso>
        public virtual Task<UpdateScalingPlanResponse> UpdateScalingPlanAsync(UpdateScalingPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateScalingPlanRequestMarshaller.Instance;
            var unmarshaller = UpdateScalingPlanResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateScalingPlanRequest,UpdateScalingPlanResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}