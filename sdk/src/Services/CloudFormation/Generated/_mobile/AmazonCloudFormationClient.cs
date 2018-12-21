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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CloudFormation.Model;
using Amazon.CloudFormation.Model.Internal.MarshallTransformations;
using Amazon.CloudFormation.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudFormation
{
    /// <summary>
    /// Implementation for accessing CloudFormation
    ///
    /// AWS CloudFormation 
    /// <para>
    /// AWS CloudFormation allows you to create and manage AWS infrastructure deployments
    /// predictably and repeatedly. You can use AWS CloudFormation to leverage AWS products,
    /// such as Amazon Elastic Compute Cloud, Amazon Elastic Block Store, Amazon Simple Notification
    /// Service, Elastic Load Balancing, and Auto Scaling to build highly-reliable, highly
    /// scalable, cost-effective applications without creating or configuring the underlying
    /// AWS infrastructure.
    /// </para>
    ///  
    /// <para>
    /// With AWS CloudFormation, you declare all of your resources and dependencies in a template
    /// file. The template defines a collection of resources as a single unit called a stack.
    /// AWS CloudFormation creates and deletes all member resources of the stack together
    /// and manages all dependencies between the resources for you.
    /// </para>
    ///  
    /// <para>
    /// For more information about AWS CloudFormation, see the <a href="http://aws.amazon.com/cloudformation/">AWS
    /// CloudFormation Product Page</a>.
    /// </para>
    ///  
    /// <para>
    /// Amazon CloudFormation makes use of other AWS products. If you need additional technical
    /// information about a specific AWS product, you can find the product's technical documentation
    /// at <a href="http://docs.aws.amazon.com/">docs.aws.amazon.com</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCloudFormationClient : AmazonServiceClient, IAmazonCloudFormation
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudFormationMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonCloudFormationClient with the credentials loaded from the application's
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
        public AmazonCloudFormationClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFormationConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with the credentials loaded from the application's
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
        public AmazonCloudFormationClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudFormationConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(AmazonCloudFormationConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudFormationClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFormationClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudFormationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Credentials and an
        /// AmazonCloudFormationClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(AWSCredentials credentials, AmazonCloudFormationConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudFormationConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFormationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudFormationConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFormationConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudFormationConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudFormationClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudFormationClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudFormationClient Configuration Object</param>
        public AmazonCloudFormationClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudFormationConfig clientConfig)
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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.CloudFormation.Internal.ProcessRequestHandler());
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


        #region  CancelUpdateStack

        internal virtual CancelUpdateStackResponse CancelUpdateStack(CancelUpdateStackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelUpdateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelUpdateStackResponseUnmarshaller.Instance;

            return Invoke<CancelUpdateStackResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelUpdateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelUpdateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CancelUpdateStack">REST API Reference for CancelUpdateStack Operation</seealso>
        public virtual Task<CancelUpdateStackResponse> CancelUpdateStackAsync(CancelUpdateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelUpdateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelUpdateStackResponseUnmarshaller.Instance;

            return InvokeAsync<CancelUpdateStackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ContinueUpdateRollback

        internal virtual ContinueUpdateRollbackResponse ContinueUpdateRollback(ContinueUpdateRollbackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ContinueUpdateRollbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ContinueUpdateRollbackResponseUnmarshaller.Instance;

            return Invoke<ContinueUpdateRollbackResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ContinueUpdateRollback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ContinueUpdateRollback operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ContinueUpdateRollback">REST API Reference for ContinueUpdateRollback Operation</seealso>
        public virtual Task<ContinueUpdateRollbackResponse> ContinueUpdateRollbackAsync(ContinueUpdateRollbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ContinueUpdateRollbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ContinueUpdateRollbackResponseUnmarshaller.Instance;

            return InvokeAsync<ContinueUpdateRollbackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateChangeSet

        internal virtual CreateChangeSetResponse CreateChangeSet(CreateChangeSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChangeSetResponseUnmarshaller.Instance;

            return Invoke<CreateChangeSetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChangeSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateChangeSet">REST API Reference for CreateChangeSet Operation</seealso>
        public virtual Task<CreateChangeSetResponse> CreateChangeSetAsync(CreateChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateChangeSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStack

        internal virtual CreateStackResponse CreateStack(CreateStackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackResponseUnmarshaller.Instance;

            return Invoke<CreateStackResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStack">REST API Reference for CreateStack Operation</seealso>
        public virtual Task<CreateStackResponse> CreateStackAsync(CreateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStackInstances

        internal virtual CreateStackInstancesResponse CreateStackInstances(CreateStackInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackInstancesResponseUnmarshaller.Instance;

            return Invoke<CreateStackInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStackInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStackInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackInstances">REST API Reference for CreateStackInstances Operation</seealso>
        public virtual Task<CreateStackInstancesResponse> CreateStackInstancesAsync(CreateStackInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStackInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStackSet

        internal virtual CreateStackSetResponse CreateStackSet(CreateStackSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackSetResponseUnmarshaller.Instance;

            return Invoke<CreateStackSetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStackSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStackSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/CreateStackSet">REST API Reference for CreateStackSet Operation</seealso>
        public virtual Task<CreateStackSetResponse> CreateStackSetAsync(CreateStackSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStackSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStackSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteChangeSet

        internal virtual DeleteChangeSetResponse DeleteChangeSet(DeleteChangeSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChangeSetResponseUnmarshaller.Instance;

            return Invoke<DeleteChangeSetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChangeSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteChangeSet">REST API Reference for DeleteChangeSet Operation</seealso>
        public virtual Task<DeleteChangeSetResponse> DeleteChangeSetAsync(DeleteChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChangeSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStack

        internal virtual DeleteStackResponse DeleteStack(DeleteStackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return Invoke<DeleteStackResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStack">REST API Reference for DeleteStack Operation</seealso>
        public virtual Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStackInstances

        internal virtual DeleteStackInstancesResponse DeleteStackInstances(DeleteStackInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackInstancesResponseUnmarshaller.Instance;

            return Invoke<DeleteStackInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStackInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStackInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStackInstances">REST API Reference for DeleteStackInstances Operation</seealso>
        public virtual Task<DeleteStackInstancesResponse> DeleteStackInstancesAsync(DeleteStackInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStackInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStackSet

        internal virtual DeleteStackSetResponse DeleteStackSet(DeleteStackSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackSetResponseUnmarshaller.Instance;

            return Invoke<DeleteStackSetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStackSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStackSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DeleteStackSet">REST API Reference for DeleteStackSet Operation</seealso>
        public virtual Task<DeleteStackSetResponse> DeleteStackSetAsync(DeleteStackSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStackSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStackSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountLimits

        internal virtual DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountLimitsResponse>(request, options);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public virtual Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(DescribeAccountLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountLimitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeChangeSet

        internal virtual DescribeChangeSetResponse DescribeChangeSet(DescribeChangeSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChangeSetResponseUnmarshaller.Instance;

            return Invoke<DescribeChangeSetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChangeSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeChangeSet">REST API Reference for DescribeChangeSet Operation</seealso>
        public virtual Task<DescribeChangeSetResponse> DescribeChangeSetAsync(DescribeChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeChangeSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackDriftDetectionStatus

        internal virtual DescribeStackDriftDetectionStatusResponse DescribeStackDriftDetectionStatus(DescribeStackDriftDetectionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackDriftDetectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackDriftDetectionStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeStackDriftDetectionStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackDriftDetectionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackDriftDetectionStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackDriftDetectionStatus">REST API Reference for DescribeStackDriftDetectionStatus Operation</seealso>
        public virtual Task<DescribeStackDriftDetectionStatusResponse> DescribeStackDriftDetectionStatusAsync(DescribeStackDriftDetectionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackDriftDetectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackDriftDetectionStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackDriftDetectionStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackEvents

        internal virtual DescribeStackEventsResponse DescribeStackEvents(DescribeStackEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeStackEventsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackEvents">REST API Reference for DescribeStackEvents Operation</seealso>
        public virtual Task<DescribeStackEventsResponse> DescribeStackEventsAsync(DescribeStackEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackInstance

        internal virtual DescribeStackInstanceResponse DescribeStackInstance(DescribeStackInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackInstanceResponseUnmarshaller.Instance;

            return Invoke<DescribeStackInstanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackInstance">REST API Reference for DescribeStackInstance Operation</seealso>
        public virtual Task<DescribeStackInstanceResponse> DescribeStackInstanceAsync(DescribeStackInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackResource

        internal virtual DescribeStackResourceResponse DescribeStackResource(DescribeStackResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackResourceResponseUnmarshaller.Instance;

            return Invoke<DescribeStackResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResource">REST API Reference for DescribeStackResource Operation</seealso>
        public virtual Task<DescribeStackResourceResponse> DescribeStackResourceAsync(DescribeStackResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackResourceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackResourceDrifts

        internal virtual DescribeStackResourceDriftsResponse DescribeStackResourceDrifts(DescribeStackResourceDriftsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackResourceDriftsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackResourceDriftsResponseUnmarshaller.Instance;

            return Invoke<DescribeStackResourceDriftsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackResourceDrifts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResourceDrifts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResourceDrifts">REST API Reference for DescribeStackResourceDrifts Operation</seealso>
        public virtual Task<DescribeStackResourceDriftsResponse> DescribeStackResourceDriftsAsync(DescribeStackResourceDriftsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackResourceDriftsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackResourceDriftsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackResourceDriftsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackResources

        internal virtual DescribeStackResourcesResponse DescribeStackResources(DescribeStackResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackResourcesResponseUnmarshaller.Instance;

            return Invoke<DescribeStackResourcesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackResources">REST API Reference for DescribeStackResources Operation</seealso>
        public virtual Task<DescribeStackResourcesResponse> DescribeStackResourcesAsync(DescribeStackResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStacks

        internal virtual DescribeStacksResponse DescribeStacks()
        {
            return DescribeStacks(new DescribeStacksRequest());
        }
        internal virtual DescribeStacksResponse DescribeStacks(DescribeStacksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return Invoke<DescribeStacksResponse>(request, options);
        }


        /// <summary>
        /// Returns the description for the specified stack; if no stack name was specified, then
        /// it returns the description for all the stacks created.
        /// 
        ///  <note> 
        /// <para>
        /// If the stack does not exist, an <code>AmazonCloudFormationException</code> is returned.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        public virtual Task<DescribeStacksResponse> DescribeStacksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeStacksAsync(new DescribeStacksRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStacks">REST API Reference for DescribeStacks Operation</seealso>
        public virtual Task<DescribeStacksResponse> DescribeStacksAsync(DescribeStacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStacksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackSet

        internal virtual DescribeStackSetResponse DescribeStackSet(DescribeStackSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackSetResponseUnmarshaller.Instance;

            return Invoke<DescribeStackSetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackSet">REST API Reference for DescribeStackSet Operation</seealso>
        public virtual Task<DescribeStackSetResponse> DescribeStackSetAsync(DescribeStackSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackSetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackSetOperation

        internal virtual DescribeStackSetOperationResponse DescribeStackSetOperation(DescribeStackSetOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackSetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackSetOperationResponseUnmarshaller.Instance;

            return Invoke<DescribeStackSetOperationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStackSetOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackSetOperation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeStackSetOperation">REST API Reference for DescribeStackSetOperation Operation</seealso>
        public virtual Task<DescribeStackSetOperationResponse> DescribeStackSetOperationAsync(DescribeStackSetOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStackSetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStackSetOperationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackSetOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectStackDrift

        internal virtual DetectStackDriftResponse DetectStackDrift(DetectStackDriftRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectStackDriftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectStackDriftResponseUnmarshaller.Instance;

            return Invoke<DetectStackDriftResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetectStackDrift operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectStackDrift operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackDrift">REST API Reference for DetectStackDrift Operation</seealso>
        public virtual Task<DetectStackDriftResponse> DetectStackDriftAsync(DetectStackDriftRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectStackDriftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectStackDriftResponseUnmarshaller.Instance;

            return InvokeAsync<DetectStackDriftResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectStackResourceDrift

        internal virtual DetectStackResourceDriftResponse DetectStackResourceDrift(DetectStackResourceDriftRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectStackResourceDriftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectStackResourceDriftResponseUnmarshaller.Instance;

            return Invoke<DetectStackResourceDriftResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetectStackResourceDrift operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectStackResourceDrift operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DetectStackResourceDrift">REST API Reference for DetectStackResourceDrift Operation</seealso>
        public virtual Task<DetectStackResourceDriftResponse> DetectStackResourceDriftAsync(DetectStackResourceDriftRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectStackResourceDriftRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectStackResourceDriftResponseUnmarshaller.Instance;

            return InvokeAsync<DetectStackResourceDriftResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EstimateTemplateCost

        internal virtual EstimateTemplateCostResponse EstimateTemplateCost(EstimateTemplateCostRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EstimateTemplateCostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EstimateTemplateCostResponseUnmarshaller.Instance;

            return Invoke<EstimateTemplateCostResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EstimateTemplateCost operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EstimateTemplateCost operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/EstimateTemplateCost">REST API Reference for EstimateTemplateCost Operation</seealso>
        public virtual Task<EstimateTemplateCostResponse> EstimateTemplateCostAsync(EstimateTemplateCostRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EstimateTemplateCostRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EstimateTemplateCostResponseUnmarshaller.Instance;

            return InvokeAsync<EstimateTemplateCostResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteChangeSet

        internal virtual ExecuteChangeSetResponse ExecuteChangeSet(ExecuteChangeSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteChangeSetResponseUnmarshaller.Instance;

            return Invoke<ExecuteChangeSetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteChangeSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ExecuteChangeSet">REST API Reference for ExecuteChangeSet Operation</seealso>
        public virtual Task<ExecuteChangeSetResponse> ExecuteChangeSetAsync(ExecuteChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<ExecuteChangeSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetStackPolicy

        internal virtual GetStackPolicyResponse GetStackPolicy(GetStackPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStackPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStackPolicyResponseUnmarshaller.Instance;

            return Invoke<GetStackPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetStackPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStackPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetStackPolicy">REST API Reference for GetStackPolicy Operation</seealso>
        public virtual Task<GetStackPolicyResponse> GetStackPolicyAsync(GetStackPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStackPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStackPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetStackPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTemplate

        internal virtual GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return Invoke<GetTemplateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        public virtual Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTemplateSummary

        internal virtual GetTemplateSummaryResponse GetTemplateSummary(GetTemplateSummaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemplateSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateSummaryResponseUnmarshaller.Instance;

            return Invoke<GetTemplateSummaryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTemplateSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateSummary operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/GetTemplateSummary">REST API Reference for GetTemplateSummary Operation</seealso>
        public virtual Task<GetTemplateSummaryResponse> GetTemplateSummaryAsync(GetTemplateSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemplateSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateSummaryResponseUnmarshaller.Instance;

            return InvokeAsync<GetTemplateSummaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChangeSets

        internal virtual ListChangeSetsResponse ListChangeSets(ListChangeSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChangeSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChangeSetsResponseUnmarshaller.Instance;

            return Invoke<ListChangeSetsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListChangeSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChangeSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListChangeSets">REST API Reference for ListChangeSets Operation</seealso>
        public virtual Task<ListChangeSetsResponse> ListChangeSetsAsync(ListChangeSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChangeSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChangeSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListChangeSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListExports

        internal virtual ListExportsResponse ListExports(ListExportsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExportsResponseUnmarshaller.Instance;

            return Invoke<ListExportsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListExports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExports operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListExports">REST API Reference for ListExports Operation</seealso>
        public virtual Task<ListExportsResponse> ListExportsAsync(ListExportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListExportsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListImports

        internal virtual ListImportsResponse ListImports(ListImportsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportsResponseUnmarshaller.Instance;

            return Invoke<ListImportsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListImports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImports operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListImports">REST API Reference for ListImports Operation</seealso>
        public virtual Task<ListImportsResponse> ListImportsAsync(ListImportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListImportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListImportsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStackInstances

        internal virtual ListStackInstancesResponse ListStackInstances(ListStackInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackInstancesResponseUnmarshaller.Instance;

            return Invoke<ListStackInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListStackInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackInstances">REST API Reference for ListStackInstances Operation</seealso>
        public virtual Task<ListStackInstancesResponse> ListStackInstancesAsync(ListStackInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStackResources

        internal virtual ListStackResourcesResponse ListStackResources(ListStackResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackResourcesResponseUnmarshaller.Instance;

            return Invoke<ListStackResourcesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListStackResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackResources">REST API Reference for ListStackResources Operation</seealso>
        public virtual Task<ListStackResourcesResponse> ListStackResourcesAsync(ListStackResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStacks

        internal virtual ListStacksResponse ListStacks()
        {
            return ListStacks(new ListStacksRequest());
        }
        internal virtual ListStacksResponse ListStacks(ListStacksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStacksResponseUnmarshaller.Instance;

            return Invoke<ListStacksResponse>(request, options);
        }


        /// <summary>
        /// Returns the summary information for stacks whose status matches the specified StackStatusFilter.
        /// Summary information for stacks that have been deleted is kept for 90 days after the
        /// stack is deleted. If no StackStatusFilter is specified, summary information for all
        /// stacks is returned (including existing stacks and stacks that have been deleted).
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStacks service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStacks">REST API Reference for ListStacks Operation</seealso>
        public virtual Task<ListStacksResponse> ListStacksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListStacksAsync(new ListStacksRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStacks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStacks">REST API Reference for ListStacks Operation</seealso>
        public virtual Task<ListStacksResponse> ListStacksAsync(ListStacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStacksResponseUnmarshaller.Instance;

            return InvokeAsync<ListStacksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStackSetOperationResults

        internal virtual ListStackSetOperationResultsResponse ListStackSetOperationResults(ListStackSetOperationResultsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackSetOperationResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackSetOperationResultsResponseUnmarshaller.Instance;

            return Invoke<ListStackSetOperationResultsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListStackSetOperationResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetOperationResults operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetOperationResults">REST API Reference for ListStackSetOperationResults Operation</seealso>
        public virtual Task<ListStackSetOperationResultsResponse> ListStackSetOperationResultsAsync(ListStackSetOperationResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackSetOperationResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackSetOperationResultsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackSetOperationResultsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStackSetOperations

        internal virtual ListStackSetOperationsResponse ListStackSetOperations(ListStackSetOperationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackSetOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackSetOperationsResponseUnmarshaller.Instance;

            return Invoke<ListStackSetOperationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListStackSetOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackSetOperations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSetOperations">REST API Reference for ListStackSetOperations Operation</seealso>
        public virtual Task<ListStackSetOperationsResponse> ListStackSetOperationsAsync(ListStackSetOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackSetOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackSetOperationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackSetOperationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStackSets

        internal virtual ListStackSetsResponse ListStackSets(ListStackSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackSetsResponseUnmarshaller.Instance;

            return Invoke<ListStackSetsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListStackSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStackSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ListStackSets">REST API Reference for ListStackSets Operation</seealso>
        public virtual Task<ListStackSetsResponse> ListStackSetsAsync(ListStackSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStackSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStackSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetStackPolicy

        internal virtual SetStackPolicyResponse SetStackPolicy(SetStackPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetStackPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetStackPolicyResponseUnmarshaller.Instance;

            return Invoke<SetStackPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SetStackPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetStackPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SetStackPolicy">REST API Reference for SetStackPolicy Operation</seealso>
        public virtual Task<SetStackPolicyResponse> SetStackPolicyAsync(SetStackPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetStackPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetStackPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<SetStackPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SignalResource

        internal virtual SignalResourceResponse SignalResource(SignalResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignalResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignalResourceResponseUnmarshaller.Instance;

            return Invoke<SignalResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SignalResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignalResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/SignalResource">REST API Reference for SignalResource Operation</seealso>
        public virtual Task<SignalResourceResponse> SignalResourceAsync(SignalResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignalResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignalResourceResponseUnmarshaller.Instance;

            return InvokeAsync<SignalResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopStackSetOperation

        internal virtual StopStackSetOperationResponse StopStackSetOperation(StopStackSetOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopStackSetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStackSetOperationResponseUnmarshaller.Instance;

            return Invoke<StopStackSetOperationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopStackSetOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopStackSetOperation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/StopStackSetOperation">REST API Reference for StopStackSetOperation Operation</seealso>
        public virtual Task<StopStackSetOperationResponse> StopStackSetOperationAsync(StopStackSetOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopStackSetOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStackSetOperationResponseUnmarshaller.Instance;

            return InvokeAsync<StopStackSetOperationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateStack

        internal virtual UpdateStackResponse UpdateStack(UpdateStackRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return Invoke<UpdateStackResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStack operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStack">REST API Reference for UpdateStack Operation</seealso>
        public virtual Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStackResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateStackInstances

        internal virtual UpdateStackInstancesResponse UpdateStackInstances(UpdateStackInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackInstancesResponseUnmarshaller.Instance;

            return Invoke<UpdateStackInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStackInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStackInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStackInstances">REST API Reference for UpdateStackInstances Operation</seealso>
        public virtual Task<UpdateStackInstancesResponse> UpdateStackInstancesAsync(UpdateStackInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStackInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStackInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateStackSet

        internal virtual UpdateStackSetResponse UpdateStackSet(UpdateStackSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackSetResponseUnmarshaller.Instance;

            return Invoke<UpdateStackSetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStackSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStackSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateStackSet">REST API Reference for UpdateStackSet Operation</seealso>
        public virtual Task<UpdateStackSetResponse> UpdateStackSetAsync(UpdateStackSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStackSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStackSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStackSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTerminationProtection

        internal virtual UpdateTerminationProtectionResponse UpdateTerminationProtection(UpdateTerminationProtectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTerminationProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTerminationProtectionResponseUnmarshaller.Instance;

            return Invoke<UpdateTerminationProtectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTerminationProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTerminationProtection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/UpdateTerminationProtection">REST API Reference for UpdateTerminationProtection Operation</seealso>
        public virtual Task<UpdateTerminationProtectionResponse> UpdateTerminationProtectionAsync(UpdateTerminationProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTerminationProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTerminationProtectionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTerminationProtectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ValidateTemplate

        internal virtual ValidateTemplateResponse ValidateTemplate()
        {
            return ValidateTemplate(new ValidateTemplateRequest());
        }
        internal virtual ValidateTemplateResponse ValidateTemplate(ValidateTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateTemplateResponseUnmarshaller.Instance;

            return Invoke<ValidateTemplateResponse>(request, options);
        }


        /// <summary>
        /// Validates a specified template. AWS CloudFormation first checks if the template is
        /// valid JSON. If it isn't, AWS CloudFormation checks if the template is valid YAML.
        /// If both these checks fail, AWS CloudFormation returns a template validation error.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateTemplate service method, as returned by CloudFormation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ValidateTemplate">REST API Reference for ValidateTemplate Operation</seealso>
        public virtual Task<ValidateTemplateResponse> ValidateTemplateAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ValidateTemplateAsync(new ValidateTemplateRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ValidateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/ValidateTemplate">REST API Reference for ValidateTemplate Operation</seealso>
        public virtual Task<ValidateTemplateResponse> ValidateTemplateAsync(ValidateTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<ValidateTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}