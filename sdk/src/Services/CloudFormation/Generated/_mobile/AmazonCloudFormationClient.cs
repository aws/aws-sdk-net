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

using Amazon.CloudFormation.Model;
using Amazon.CloudFormation.Model.Internal.MarshallTransformations;
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

        internal CancelUpdateStackResponse CancelUpdateStack(CancelUpdateStackRequest request)
        {
            var marshaller = new CancelUpdateStackRequestMarshaller();
            var unmarshaller = CancelUpdateStackResponseUnmarshaller.Instance;

            return Invoke<CancelUpdateStackRequest,CancelUpdateStackResponse>(request, marshaller, unmarshaller);
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
        public Task<CancelUpdateStackResponse> CancelUpdateStackAsync(CancelUpdateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelUpdateStackRequestMarshaller();
            var unmarshaller = CancelUpdateStackResponseUnmarshaller.Instance;

            return InvokeAsync<CancelUpdateStackRequest,CancelUpdateStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ContinueUpdateRollback

        internal ContinueUpdateRollbackResponse ContinueUpdateRollback(ContinueUpdateRollbackRequest request)
        {
            var marshaller = new ContinueUpdateRollbackRequestMarshaller();
            var unmarshaller = ContinueUpdateRollbackResponseUnmarshaller.Instance;

            return Invoke<ContinueUpdateRollbackRequest,ContinueUpdateRollbackResponse>(request, marshaller, unmarshaller);
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
        public Task<ContinueUpdateRollbackResponse> ContinueUpdateRollbackAsync(ContinueUpdateRollbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ContinueUpdateRollbackRequestMarshaller();
            var unmarshaller = ContinueUpdateRollbackResponseUnmarshaller.Instance;

            return InvokeAsync<ContinueUpdateRollbackRequest,ContinueUpdateRollbackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateChangeSet

        internal CreateChangeSetResponse CreateChangeSet(CreateChangeSetRequest request)
        {
            var marshaller = new CreateChangeSetRequestMarshaller();
            var unmarshaller = CreateChangeSetResponseUnmarshaller.Instance;

            return Invoke<CreateChangeSetRequest,CreateChangeSetResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateChangeSetResponse> CreateChangeSetAsync(CreateChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateChangeSetRequestMarshaller();
            var unmarshaller = CreateChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateChangeSetRequest,CreateChangeSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateStack

        internal CreateStackResponse CreateStack(CreateStackRequest request)
        {
            var marshaller = new CreateStackRequestMarshaller();
            var unmarshaller = CreateStackResponseUnmarshaller.Instance;

            return Invoke<CreateStackRequest,CreateStackResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateStackResponse> CreateStackAsync(CreateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStackRequestMarshaller();
            var unmarshaller = CreateStackResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStackRequest,CreateStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateStackInstances

        internal CreateStackInstancesResponse CreateStackInstances(CreateStackInstancesRequest request)
        {
            var marshaller = new CreateStackInstancesRequestMarshaller();
            var unmarshaller = CreateStackInstancesResponseUnmarshaller.Instance;

            return Invoke<CreateStackInstancesRequest,CreateStackInstancesResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateStackInstancesResponse> CreateStackInstancesAsync(CreateStackInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStackInstancesRequestMarshaller();
            var unmarshaller = CreateStackInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStackInstancesRequest,CreateStackInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateStackSet

        internal CreateStackSetResponse CreateStackSet(CreateStackSetRequest request)
        {
            var marshaller = new CreateStackSetRequestMarshaller();
            var unmarshaller = CreateStackSetResponseUnmarshaller.Instance;

            return Invoke<CreateStackSetRequest,CreateStackSetResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateStackSetResponse> CreateStackSetAsync(CreateStackSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateStackSetRequestMarshaller();
            var unmarshaller = CreateStackSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStackSetRequest,CreateStackSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteChangeSet

        internal DeleteChangeSetResponse DeleteChangeSet(DeleteChangeSetRequest request)
        {
            var marshaller = new DeleteChangeSetRequestMarshaller();
            var unmarshaller = DeleteChangeSetResponseUnmarshaller.Instance;

            return Invoke<DeleteChangeSetRequest,DeleteChangeSetResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteChangeSetResponse> DeleteChangeSetAsync(DeleteChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteChangeSetRequestMarshaller();
            var unmarshaller = DeleteChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteChangeSetRequest,DeleteChangeSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteStack

        internal DeleteStackResponse DeleteStack(DeleteStackRequest request)
        {
            var marshaller = new DeleteStackRequestMarshaller();
            var unmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return Invoke<DeleteStackRequest,DeleteStackResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteStackResponse> DeleteStackAsync(DeleteStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteStackRequestMarshaller();
            var unmarshaller = DeleteStackResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStackRequest,DeleteStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteStackInstances

        internal DeleteStackInstancesResponse DeleteStackInstances(DeleteStackInstancesRequest request)
        {
            var marshaller = new DeleteStackInstancesRequestMarshaller();
            var unmarshaller = DeleteStackInstancesResponseUnmarshaller.Instance;

            return Invoke<DeleteStackInstancesRequest,DeleteStackInstancesResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteStackInstancesResponse> DeleteStackInstancesAsync(DeleteStackInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteStackInstancesRequestMarshaller();
            var unmarshaller = DeleteStackInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStackInstancesRequest,DeleteStackInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteStackSet

        internal DeleteStackSetResponse DeleteStackSet(DeleteStackSetRequest request)
        {
            var marshaller = new DeleteStackSetRequestMarshaller();
            var unmarshaller = DeleteStackSetResponseUnmarshaller.Instance;

            return Invoke<DeleteStackSetRequest,DeleteStackSetResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteStackSetResponse> DeleteStackSetAsync(DeleteStackSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteStackSetRequestMarshaller();
            var unmarshaller = DeleteStackSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStackSetRequest,DeleteStackSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountLimits

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cloudformation-2010-05-15/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(DescribeAccountLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAccountLimitsRequestMarshaller();
            var unmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountLimitsRequest,DescribeAccountLimitsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeChangeSet

        internal DescribeChangeSetResponse DescribeChangeSet(DescribeChangeSetRequest request)
        {
            var marshaller = new DescribeChangeSetRequestMarshaller();
            var unmarshaller = DescribeChangeSetResponseUnmarshaller.Instance;

            return Invoke<DescribeChangeSetRequest,DescribeChangeSetResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeChangeSetResponse> DescribeChangeSetAsync(DescribeChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeChangeSetRequestMarshaller();
            var unmarshaller = DescribeChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeChangeSetRequest,DescribeChangeSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackEvents

        internal DescribeStackEventsResponse DescribeStackEvents(DescribeStackEventsRequest request)
        {
            var marshaller = new DescribeStackEventsRequestMarshaller();
            var unmarshaller = DescribeStackEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeStackEventsRequest,DescribeStackEventsResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeStackEventsResponse> DescribeStackEventsAsync(DescribeStackEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackEventsRequestMarshaller();
            var unmarshaller = DescribeStackEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackEventsRequest,DescribeStackEventsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackInstance

        internal DescribeStackInstanceResponse DescribeStackInstance(DescribeStackInstanceRequest request)
        {
            var marshaller = new DescribeStackInstanceRequestMarshaller();
            var unmarshaller = DescribeStackInstanceResponseUnmarshaller.Instance;

            return Invoke<DescribeStackInstanceRequest,DescribeStackInstanceResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeStackInstanceResponse> DescribeStackInstanceAsync(DescribeStackInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackInstanceRequestMarshaller();
            var unmarshaller = DescribeStackInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackInstanceRequest,DescribeStackInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackResource

        internal DescribeStackResourceResponse DescribeStackResource(DescribeStackResourceRequest request)
        {
            var marshaller = new DescribeStackResourceRequestMarshaller();
            var unmarshaller = DescribeStackResourceResponseUnmarshaller.Instance;

            return Invoke<DescribeStackResourceRequest,DescribeStackResourceResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeStackResourceResponse> DescribeStackResourceAsync(DescribeStackResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackResourceRequestMarshaller();
            var unmarshaller = DescribeStackResourceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackResourceRequest,DescribeStackResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackResources

        internal DescribeStackResourcesResponse DescribeStackResources(DescribeStackResourcesRequest request)
        {
            var marshaller = new DescribeStackResourcesRequestMarshaller();
            var unmarshaller = DescribeStackResourcesResponseUnmarshaller.Instance;

            return Invoke<DescribeStackResourcesRequest,DescribeStackResourcesResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeStackResourcesResponse> DescribeStackResourcesAsync(DescribeStackResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackResourcesRequestMarshaller();
            var unmarshaller = DescribeStackResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackResourcesRequest,DescribeStackResourcesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStacks

        internal DescribeStacksResponse DescribeStacks()
        {
            return DescribeStacks(new DescribeStacksRequest());
        }
        internal DescribeStacksResponse DescribeStacks(DescribeStacksRequest request)
        {
            var marshaller = new DescribeStacksRequestMarshaller();
            var unmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return Invoke<DescribeStacksRequest,DescribeStacksResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeStacksResponse> DescribeStacksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeStacksResponse> DescribeStacksAsync(DescribeStacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStacksRequestMarshaller();
            var unmarshaller = DescribeStacksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStacksRequest,DescribeStacksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackSet

        internal DescribeStackSetResponse DescribeStackSet(DescribeStackSetRequest request)
        {
            var marshaller = new DescribeStackSetRequestMarshaller();
            var unmarshaller = DescribeStackSetResponseUnmarshaller.Instance;

            return Invoke<DescribeStackSetRequest,DescribeStackSetResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeStackSetResponse> DescribeStackSetAsync(DescribeStackSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackSetRequestMarshaller();
            var unmarshaller = DescribeStackSetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackSetRequest,DescribeStackSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStackSetOperation

        internal DescribeStackSetOperationResponse DescribeStackSetOperation(DescribeStackSetOperationRequest request)
        {
            var marshaller = new DescribeStackSetOperationRequestMarshaller();
            var unmarshaller = DescribeStackSetOperationResponseUnmarshaller.Instance;

            return Invoke<DescribeStackSetOperationRequest,DescribeStackSetOperationResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeStackSetOperationResponse> DescribeStackSetOperationAsync(DescribeStackSetOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeStackSetOperationRequestMarshaller();
            var unmarshaller = DescribeStackSetOperationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStackSetOperationRequest,DescribeStackSetOperationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EstimateTemplateCost

        internal EstimateTemplateCostResponse EstimateTemplateCost(EstimateTemplateCostRequest request)
        {
            var marshaller = new EstimateTemplateCostRequestMarshaller();
            var unmarshaller = EstimateTemplateCostResponseUnmarshaller.Instance;

            return Invoke<EstimateTemplateCostRequest,EstimateTemplateCostResponse>(request, marshaller, unmarshaller);
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
        public Task<EstimateTemplateCostResponse> EstimateTemplateCostAsync(EstimateTemplateCostRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EstimateTemplateCostRequestMarshaller();
            var unmarshaller = EstimateTemplateCostResponseUnmarshaller.Instance;

            return InvokeAsync<EstimateTemplateCostRequest,EstimateTemplateCostResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ExecuteChangeSet

        internal ExecuteChangeSetResponse ExecuteChangeSet(ExecuteChangeSetRequest request)
        {
            var marshaller = new ExecuteChangeSetRequestMarshaller();
            var unmarshaller = ExecuteChangeSetResponseUnmarshaller.Instance;

            return Invoke<ExecuteChangeSetRequest,ExecuteChangeSetResponse>(request, marshaller, unmarshaller);
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
        public Task<ExecuteChangeSetResponse> ExecuteChangeSetAsync(ExecuteChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ExecuteChangeSetRequestMarshaller();
            var unmarshaller = ExecuteChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<ExecuteChangeSetRequest,ExecuteChangeSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetStackPolicy

        internal GetStackPolicyResponse GetStackPolicy(GetStackPolicyRequest request)
        {
            var marshaller = new GetStackPolicyRequestMarshaller();
            var unmarshaller = GetStackPolicyResponseUnmarshaller.Instance;

            return Invoke<GetStackPolicyRequest,GetStackPolicyResponse>(request, marshaller, unmarshaller);
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
        public Task<GetStackPolicyResponse> GetStackPolicyAsync(GetStackPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetStackPolicyRequestMarshaller();
            var unmarshaller = GetStackPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetStackPolicyRequest,GetStackPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTemplate

        internal GetTemplateResponse GetTemplate(GetTemplateRequest request)
        {
            var marshaller = new GetTemplateRequestMarshaller();
            var unmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return Invoke<GetTemplateRequest,GetTemplateResponse>(request, marshaller, unmarshaller);
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
        public Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTemplateRequestMarshaller();
            var unmarshaller = GetTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetTemplateRequest,GetTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTemplateSummary

        internal GetTemplateSummaryResponse GetTemplateSummary(GetTemplateSummaryRequest request)
        {
            var marshaller = new GetTemplateSummaryRequestMarshaller();
            var unmarshaller = GetTemplateSummaryResponseUnmarshaller.Instance;

            return Invoke<GetTemplateSummaryRequest,GetTemplateSummaryResponse>(request, marshaller, unmarshaller);
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
        public Task<GetTemplateSummaryResponse> GetTemplateSummaryAsync(GetTemplateSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTemplateSummaryRequestMarshaller();
            var unmarshaller = GetTemplateSummaryResponseUnmarshaller.Instance;

            return InvokeAsync<GetTemplateSummaryRequest,GetTemplateSummaryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListChangeSets

        internal ListChangeSetsResponse ListChangeSets(ListChangeSetsRequest request)
        {
            var marshaller = new ListChangeSetsRequestMarshaller();
            var unmarshaller = ListChangeSetsResponseUnmarshaller.Instance;

            return Invoke<ListChangeSetsRequest,ListChangeSetsResponse>(request, marshaller, unmarshaller);
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
        public Task<ListChangeSetsResponse> ListChangeSetsAsync(ListChangeSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListChangeSetsRequestMarshaller();
            var unmarshaller = ListChangeSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListChangeSetsRequest,ListChangeSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListExports

        internal ListExportsResponse ListExports(ListExportsRequest request)
        {
            var marshaller = new ListExportsRequestMarshaller();
            var unmarshaller = ListExportsResponseUnmarshaller.Instance;

            return Invoke<ListExportsRequest,ListExportsResponse>(request, marshaller, unmarshaller);
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
        public Task<ListExportsResponse> ListExportsAsync(ListExportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListExportsRequestMarshaller();
            var unmarshaller = ListExportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListExportsRequest,ListExportsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListImports

        internal ListImportsResponse ListImports(ListImportsRequest request)
        {
            var marshaller = new ListImportsRequestMarshaller();
            var unmarshaller = ListImportsResponseUnmarshaller.Instance;

            return Invoke<ListImportsRequest,ListImportsResponse>(request, marshaller, unmarshaller);
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
        public Task<ListImportsResponse> ListImportsAsync(ListImportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListImportsRequestMarshaller();
            var unmarshaller = ListImportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListImportsRequest,ListImportsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListStackInstances

        internal ListStackInstancesResponse ListStackInstances(ListStackInstancesRequest request)
        {
            var marshaller = new ListStackInstancesRequestMarshaller();
            var unmarshaller = ListStackInstancesResponseUnmarshaller.Instance;

            return Invoke<ListStackInstancesRequest,ListStackInstancesResponse>(request, marshaller, unmarshaller);
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
        public Task<ListStackInstancesResponse> ListStackInstancesAsync(ListStackInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStackInstancesRequestMarshaller();
            var unmarshaller = ListStackInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackInstancesRequest,ListStackInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListStackResources

        internal ListStackResourcesResponse ListStackResources(ListStackResourcesRequest request)
        {
            var marshaller = new ListStackResourcesRequestMarshaller();
            var unmarshaller = ListStackResourcesResponseUnmarshaller.Instance;

            return Invoke<ListStackResourcesRequest,ListStackResourcesResponse>(request, marshaller, unmarshaller);
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
        public Task<ListStackResourcesResponse> ListStackResourcesAsync(ListStackResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStackResourcesRequestMarshaller();
            var unmarshaller = ListStackResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackResourcesRequest,ListStackResourcesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListStacks

        internal ListStacksResponse ListStacks()
        {
            return ListStacks(new ListStacksRequest());
        }
        internal ListStacksResponse ListStacks(ListStacksRequest request)
        {
            var marshaller = new ListStacksRequestMarshaller();
            var unmarshaller = ListStacksResponseUnmarshaller.Instance;

            return Invoke<ListStacksRequest,ListStacksResponse>(request, marshaller, unmarshaller);
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
        public Task<ListStacksResponse> ListStacksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<ListStacksResponse> ListStacksAsync(ListStacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStacksRequestMarshaller();
            var unmarshaller = ListStacksResponseUnmarshaller.Instance;

            return InvokeAsync<ListStacksRequest,ListStacksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListStackSetOperationResults

        internal ListStackSetOperationResultsResponse ListStackSetOperationResults(ListStackSetOperationResultsRequest request)
        {
            var marshaller = new ListStackSetOperationResultsRequestMarshaller();
            var unmarshaller = ListStackSetOperationResultsResponseUnmarshaller.Instance;

            return Invoke<ListStackSetOperationResultsRequest,ListStackSetOperationResultsResponse>(request, marshaller, unmarshaller);
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
        public Task<ListStackSetOperationResultsResponse> ListStackSetOperationResultsAsync(ListStackSetOperationResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStackSetOperationResultsRequestMarshaller();
            var unmarshaller = ListStackSetOperationResultsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackSetOperationResultsRequest,ListStackSetOperationResultsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListStackSetOperations

        internal ListStackSetOperationsResponse ListStackSetOperations(ListStackSetOperationsRequest request)
        {
            var marshaller = new ListStackSetOperationsRequestMarshaller();
            var unmarshaller = ListStackSetOperationsResponseUnmarshaller.Instance;

            return Invoke<ListStackSetOperationsRequest,ListStackSetOperationsResponse>(request, marshaller, unmarshaller);
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
        public Task<ListStackSetOperationsResponse> ListStackSetOperationsAsync(ListStackSetOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStackSetOperationsRequestMarshaller();
            var unmarshaller = ListStackSetOperationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackSetOperationsRequest,ListStackSetOperationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListStackSets

        internal ListStackSetsResponse ListStackSets(ListStackSetsRequest request)
        {
            var marshaller = new ListStackSetsRequestMarshaller();
            var unmarshaller = ListStackSetsResponseUnmarshaller.Instance;

            return Invoke<ListStackSetsRequest,ListStackSetsResponse>(request, marshaller, unmarshaller);
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
        public Task<ListStackSetsResponse> ListStackSetsAsync(ListStackSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListStackSetsRequestMarshaller();
            var unmarshaller = ListStackSetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStackSetsRequest,ListStackSetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetStackPolicy

        internal SetStackPolicyResponse SetStackPolicy(SetStackPolicyRequest request)
        {
            var marshaller = new SetStackPolicyRequestMarshaller();
            var unmarshaller = SetStackPolicyResponseUnmarshaller.Instance;

            return Invoke<SetStackPolicyRequest,SetStackPolicyResponse>(request, marshaller, unmarshaller);
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
        public Task<SetStackPolicyResponse> SetStackPolicyAsync(SetStackPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetStackPolicyRequestMarshaller();
            var unmarshaller = SetStackPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<SetStackPolicyRequest,SetStackPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SignalResource

        internal SignalResourceResponse SignalResource(SignalResourceRequest request)
        {
            var marshaller = new SignalResourceRequestMarshaller();
            var unmarshaller = SignalResourceResponseUnmarshaller.Instance;

            return Invoke<SignalResourceRequest,SignalResourceResponse>(request, marshaller, unmarshaller);
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
        public Task<SignalResourceResponse> SignalResourceAsync(SignalResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SignalResourceRequestMarshaller();
            var unmarshaller = SignalResourceResponseUnmarshaller.Instance;

            return InvokeAsync<SignalResourceRequest,SignalResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopStackSetOperation

        internal StopStackSetOperationResponse StopStackSetOperation(StopStackSetOperationRequest request)
        {
            var marshaller = new StopStackSetOperationRequestMarshaller();
            var unmarshaller = StopStackSetOperationResponseUnmarshaller.Instance;

            return Invoke<StopStackSetOperationRequest,StopStackSetOperationResponse>(request, marshaller, unmarshaller);
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
        public Task<StopStackSetOperationResponse> StopStackSetOperationAsync(StopStackSetOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopStackSetOperationRequestMarshaller();
            var unmarshaller = StopStackSetOperationResponseUnmarshaller.Instance;

            return InvokeAsync<StopStackSetOperationRequest,StopStackSetOperationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateStack

        internal UpdateStackResponse UpdateStack(UpdateStackRequest request)
        {
            var marshaller = new UpdateStackRequestMarshaller();
            var unmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return Invoke<UpdateStackRequest,UpdateStackResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateStackResponse> UpdateStackAsync(UpdateStackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateStackRequestMarshaller();
            var unmarshaller = UpdateStackResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStackRequest,UpdateStackResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateStackSet

        internal UpdateStackSetResponse UpdateStackSet(UpdateStackSetRequest request)
        {
            var marshaller = new UpdateStackSetRequestMarshaller();
            var unmarshaller = UpdateStackSetResponseUnmarshaller.Instance;

            return Invoke<UpdateStackSetRequest,UpdateStackSetResponse>(request, marshaller, unmarshaller);
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
        public Task<UpdateStackSetResponse> UpdateStackSetAsync(UpdateStackSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateStackSetRequestMarshaller();
            var unmarshaller = UpdateStackSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStackSetRequest,UpdateStackSetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ValidateTemplate

        internal ValidateTemplateResponse ValidateTemplate()
        {
            return ValidateTemplate(new ValidateTemplateRequest());
        }
        internal ValidateTemplateResponse ValidateTemplate(ValidateTemplateRequest request)
        {
            var marshaller = new ValidateTemplateRequestMarshaller();
            var unmarshaller = ValidateTemplateResponseUnmarshaller.Instance;

            return Invoke<ValidateTemplateRequest,ValidateTemplateResponse>(request, marshaller, unmarshaller);
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
        public Task<ValidateTemplateResponse> ValidateTemplateAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<ValidateTemplateResponse> ValidateTemplateAsync(ValidateTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ValidateTemplateRequestMarshaller();
            var unmarshaller = ValidateTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<ValidateTemplateRequest,ValidateTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}