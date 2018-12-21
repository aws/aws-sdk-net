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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SimpleWorkflow.Model;
using Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations;
using Amazon.SimpleWorkflow.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleWorkflow
{
    /// <summary>
    /// Implementation for accessing SimpleWorkflow
    ///
    /// Amazon Simple Workflow Service 
    /// <para>
    /// The Amazon Simple Workflow Service (Amazon SWF) makes it easy to build applications
    /// that use Amazon's cloud to coordinate work across distributed components. In Amazon
    /// SWF, a <i>task</i> represents a logical unit of work that is performed by a component
    /// of your workflow. Coordinating tasks in a workflow involves managing intertask dependencies,
    /// scheduling, and concurrency in accordance with the logical flow of the application.
    /// </para>
    ///  
    /// <para>
    /// Amazon SWF gives you full control over implementing tasks and coordinating them without
    /// worrying about underlying complexities such as tracking their progress and maintaining
    /// their state.
    /// </para>
    ///  
    /// <para>
    /// This documentation serves as reference only. For a broader overview of the Amazon
    /// SWF programming model, see the <i> <a href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/">Amazon
    /// SWF Developer Guide</a> </i>.
    /// </para>
    /// </summary>
    public partial class AmazonSimpleWorkflowClient : AmazonServiceClient, IAmazonSimpleWorkflow
    {
        private static IServiceMetadata serviceMetadata = new AmazonSimpleWorkflowMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with the credentials loaded from the application's
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
        public AmazonSimpleWorkflowClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleWorkflowConfig()) { }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with the credentials loaded from the application's
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
        public AmazonSimpleWorkflowClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleWorkflowConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSimpleWorkflowClient Configuration Object</param>
        public AmazonSimpleWorkflowClient(AmazonSimpleWorkflowConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSimpleWorkflowClient(AWSCredentials credentials)
            : this(credentials, new AmazonSimpleWorkflowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleWorkflowClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSimpleWorkflowConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Credentials and an
        /// AmazonSimpleWorkflowClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimpleWorkflowClient Configuration Object</param>
        public AmazonSimpleWorkflowClient(AWSCredentials credentials, AmazonSimpleWorkflowConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimpleWorkflowClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleWorkflowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleWorkflowClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleWorkflowConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleWorkflowClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleWorkflowClient Configuration Object</param>
        public AmazonSimpleWorkflowClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleWorkflowConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSimpleWorkflowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleWorkflowConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleWorkflowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleWorkflowConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleWorkflowClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleWorkflowClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSimpleWorkflowClient Configuration Object</param>
        public AmazonSimpleWorkflowClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSimpleWorkflowConfig clientConfig)
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


        #region  CountClosedWorkflowExecutions

        internal virtual CountClosedWorkflowExecutionsResponse CountClosedWorkflowExecutions(CountClosedWorkflowExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CountClosedWorkflowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CountClosedWorkflowExecutionsResponseUnmarshaller.Instance;

            return Invoke<CountClosedWorkflowExecutionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CountClosedWorkflowExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CountClosedWorkflowExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountClosedWorkflowExecutions">REST API Reference for CountClosedWorkflowExecutions Operation</seealso>
        public virtual Task<CountClosedWorkflowExecutionsResponse> CountClosedWorkflowExecutionsAsync(CountClosedWorkflowExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CountClosedWorkflowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CountClosedWorkflowExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<CountClosedWorkflowExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CountOpenWorkflowExecutions

        internal virtual CountOpenWorkflowExecutionsResponse CountOpenWorkflowExecutions(CountOpenWorkflowExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CountOpenWorkflowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CountOpenWorkflowExecutionsResponseUnmarshaller.Instance;

            return Invoke<CountOpenWorkflowExecutionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CountOpenWorkflowExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CountOpenWorkflowExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountOpenWorkflowExecutions">REST API Reference for CountOpenWorkflowExecutions Operation</seealso>
        public virtual Task<CountOpenWorkflowExecutionsResponse> CountOpenWorkflowExecutionsAsync(CountOpenWorkflowExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CountOpenWorkflowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CountOpenWorkflowExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<CountOpenWorkflowExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CountPendingActivityTasks

        internal virtual CountPendingActivityTasksResponse CountPendingActivityTasks(CountPendingActivityTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CountPendingActivityTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CountPendingActivityTasksResponseUnmarshaller.Instance;

            return Invoke<CountPendingActivityTasksResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CountPendingActivityTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CountPendingActivityTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountPendingActivityTasks">REST API Reference for CountPendingActivityTasks Operation</seealso>
        public virtual Task<CountPendingActivityTasksResponse> CountPendingActivityTasksAsync(CountPendingActivityTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CountPendingActivityTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CountPendingActivityTasksResponseUnmarshaller.Instance;

            return InvokeAsync<CountPendingActivityTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CountPendingDecisionTasks

        internal virtual CountPendingDecisionTasksResponse CountPendingDecisionTasks(CountPendingDecisionTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CountPendingDecisionTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CountPendingDecisionTasksResponseUnmarshaller.Instance;

            return Invoke<CountPendingDecisionTasksResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CountPendingDecisionTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CountPendingDecisionTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/CountPendingDecisionTasks">REST API Reference for CountPendingDecisionTasks Operation</seealso>
        public virtual Task<CountPendingDecisionTasksResponse> CountPendingDecisionTasksAsync(CountPendingDecisionTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CountPendingDecisionTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CountPendingDecisionTasksResponseUnmarshaller.Instance;

            return InvokeAsync<CountPendingDecisionTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeprecateActivityType

        internal virtual DeprecateActivityTypeResponse DeprecateActivityType(DeprecateActivityTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprecateActivityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateActivityTypeResponseUnmarshaller.Instance;

            return Invoke<DeprecateActivityTypeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateActivityType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateActivityType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DeprecateActivityType">REST API Reference for DeprecateActivityType Operation</seealso>
        public virtual Task<DeprecateActivityTypeResponse> DeprecateActivityTypeAsync(DeprecateActivityTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprecateActivityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateActivityTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeprecateActivityTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeprecateDomain

        internal virtual DeprecateDomainResponse DeprecateDomain(DeprecateDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprecateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateDomainResponseUnmarshaller.Instance;

            return Invoke<DeprecateDomainResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DeprecateDomain">REST API Reference for DeprecateDomain Operation</seealso>
        public virtual Task<DeprecateDomainResponse> DeprecateDomainAsync(DeprecateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprecateDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DeprecateDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeprecateWorkflowType

        internal virtual DeprecateWorkflowTypeResponse DeprecateWorkflowType(DeprecateWorkflowTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprecateWorkflowTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateWorkflowTypeResponseUnmarshaller.Instance;

            return Invoke<DeprecateWorkflowTypeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateWorkflowType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateWorkflowType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DeprecateWorkflowType">REST API Reference for DeprecateWorkflowType Operation</seealso>
        public virtual Task<DeprecateWorkflowTypeResponse> DeprecateWorkflowTypeAsync(DeprecateWorkflowTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprecateWorkflowTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateWorkflowTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeprecateWorkflowTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeActivityType

        internal virtual DescribeActivityTypeResponse DescribeActivityType(DescribeActivityTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeActivityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActivityTypeResponseUnmarshaller.Instance;

            return Invoke<DescribeActivityTypeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeActivityType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivityType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeActivityType">REST API Reference for DescribeActivityType Operation</seealso>
        public virtual Task<DescribeActivityTypeResponse> DescribeActivityTypeAsync(DescribeActivityTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeActivityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeActivityTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeActivityTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDomain

        internal virtual DescribeDomainResponse DescribeDomain(DescribeDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainResponseUnmarshaller.Instance;

            return Invoke<DescribeDomainResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        public virtual Task<DescribeDomainResponse> DescribeDomainAsync(DescribeDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDomainResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkflowExecution

        internal virtual DescribeWorkflowExecutionResponse DescribeWorkflowExecution(DescribeWorkflowExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkflowExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkflowExecutionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkflowExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflowExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeWorkflowExecution">REST API Reference for DescribeWorkflowExecution Operation</seealso>
        public virtual Task<DescribeWorkflowExecutionResponse> DescribeWorkflowExecutionAsync(DescribeWorkflowExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkflowExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkflowExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkflowType

        internal virtual DescribeWorkflowTypeResponse DescribeWorkflowType(DescribeWorkflowTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkflowTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkflowTypeResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkflowTypeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkflowType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflowType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/DescribeWorkflowType">REST API Reference for DescribeWorkflowType Operation</seealso>
        public virtual Task<DescribeWorkflowTypeResponse> DescribeWorkflowTypeAsync(DescribeWorkflowTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkflowTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkflowTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWorkflowTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWorkflowExecutionHistory

        internal virtual GetWorkflowExecutionHistoryResponse GetWorkflowExecutionHistory(GetWorkflowExecutionHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowExecutionHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowExecutionHistoryResponseUnmarshaller.Instance;

            return Invoke<GetWorkflowExecutionHistoryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkflowExecutionHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowExecutionHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/GetWorkflowExecutionHistory">REST API Reference for GetWorkflowExecutionHistory Operation</seealso>
        public virtual Task<GetWorkflowExecutionHistoryResponse> GetWorkflowExecutionHistoryAsync(GetWorkflowExecutionHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkflowExecutionHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkflowExecutionHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkflowExecutionHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListActivityTypes

        internal virtual ListActivityTypesResponse ListActivityTypes(ListActivityTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListActivityTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActivityTypesResponseUnmarshaller.Instance;

            return Invoke<ListActivityTypesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListActivityTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActivityTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListActivityTypes">REST API Reference for ListActivityTypes Operation</seealso>
        public virtual Task<ListActivityTypesResponse> ListActivityTypesAsync(ListActivityTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListActivityTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListActivityTypesResponseUnmarshaller.Instance;

            return InvokeAsync<ListActivityTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListClosedWorkflowExecutions

        internal virtual ListClosedWorkflowExecutionsResponse ListClosedWorkflowExecutions(ListClosedWorkflowExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClosedWorkflowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClosedWorkflowExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListClosedWorkflowExecutionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListClosedWorkflowExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClosedWorkflowExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListClosedWorkflowExecutions">REST API Reference for ListClosedWorkflowExecutions Operation</seealso>
        public virtual Task<ListClosedWorkflowExecutionsResponse> ListClosedWorkflowExecutionsAsync(ListClosedWorkflowExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClosedWorkflowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClosedWorkflowExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListClosedWorkflowExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDomains

        internal virtual ListDomainsResponse ListDomains(ListDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return Invoke<ListDomainsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomains operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListDomains">REST API Reference for ListDomains Operation</seealso>
        public virtual Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOpenWorkflowExecutions

        internal virtual ListOpenWorkflowExecutionsResponse ListOpenWorkflowExecutions(ListOpenWorkflowExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOpenWorkflowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOpenWorkflowExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListOpenWorkflowExecutionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListOpenWorkflowExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOpenWorkflowExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListOpenWorkflowExecutions">REST API Reference for ListOpenWorkflowExecutions Operation</seealso>
        public virtual Task<ListOpenWorkflowExecutionsResponse> ListOpenWorkflowExecutionsAsync(ListOpenWorkflowExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOpenWorkflowExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOpenWorkflowExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListOpenWorkflowExecutionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkflowTypes

        internal virtual ListWorkflowTypesResponse ListWorkflowTypes(ListWorkflowTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkflowTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowTypesResponseUnmarshaller.Instance;

            return Invoke<ListWorkflowTypesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkflowTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/ListWorkflowTypes">REST API Reference for ListWorkflowTypes Operation</seealso>
        public virtual Task<ListWorkflowTypesResponse> ListWorkflowTypesAsync(ListWorkflowTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkflowTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkflowTypesResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkflowTypesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PollForActivityTask

        internal virtual PollForActivityTaskResponse PollForActivityTask(PollForActivityTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PollForActivityTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PollForActivityTaskResponseUnmarshaller.Instance;

            return Invoke<PollForActivityTaskResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PollForActivityTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForActivityTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/PollForActivityTask">REST API Reference for PollForActivityTask Operation</seealso>
        public virtual Task<PollForActivityTaskResponse> PollForActivityTaskAsync(PollForActivityTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PollForActivityTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PollForActivityTaskResponseUnmarshaller.Instance;

            return InvokeAsync<PollForActivityTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PollForDecisionTask

        internal virtual PollForDecisionTaskResponse PollForDecisionTask(PollForDecisionTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PollForDecisionTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PollForDecisionTaskResponseUnmarshaller.Instance;

            return Invoke<PollForDecisionTaskResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PollForDecisionTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PollForDecisionTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/PollForDecisionTask">REST API Reference for PollForDecisionTask Operation</seealso>
        public virtual Task<PollForDecisionTaskResponse> PollForDecisionTaskAsync(PollForDecisionTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PollForDecisionTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PollForDecisionTaskResponseUnmarshaller.Instance;

            return InvokeAsync<PollForDecisionTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RecordActivityTaskHeartbeat

        internal virtual RecordActivityTaskHeartbeatResponse RecordActivityTaskHeartbeat(RecordActivityTaskHeartbeatRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RecordActivityTaskHeartbeatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecordActivityTaskHeartbeatResponseUnmarshaller.Instance;

            return Invoke<RecordActivityTaskHeartbeatResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RecordActivityTaskHeartbeat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecordActivityTaskHeartbeat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RecordActivityTaskHeartbeat">REST API Reference for RecordActivityTaskHeartbeat Operation</seealso>
        public virtual Task<RecordActivityTaskHeartbeatResponse> RecordActivityTaskHeartbeatAsync(RecordActivityTaskHeartbeatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RecordActivityTaskHeartbeatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecordActivityTaskHeartbeatResponseUnmarshaller.Instance;

            return InvokeAsync<RecordActivityTaskHeartbeatResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterActivityType

        internal virtual RegisterActivityTypeResponse RegisterActivityType(RegisterActivityTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterActivityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterActivityTypeResponseUnmarshaller.Instance;

            return Invoke<RegisterActivityTypeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterActivityType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterActivityType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RegisterActivityType">REST API Reference for RegisterActivityType Operation</seealso>
        public virtual Task<RegisterActivityTypeResponse> RegisterActivityTypeAsync(RegisterActivityTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterActivityTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterActivityTypeResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterActivityTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterDomain

        internal virtual RegisterDomainResponse RegisterDomain(RegisterDomainRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDomainResponseUnmarshaller.Instance;

            return Invoke<RegisterDomainResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterDomain operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RegisterDomain">REST API Reference for RegisterDomain Operation</seealso>
        public virtual Task<RegisterDomainResponse> RegisterDomainAsync(RegisterDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterDomainRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterDomainResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterDomainResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterWorkflowType

        internal virtual RegisterWorkflowTypeResponse RegisterWorkflowType(RegisterWorkflowTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterWorkflowTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterWorkflowTypeResponseUnmarshaller.Instance;

            return Invoke<RegisterWorkflowTypeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterWorkflowType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterWorkflowType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RegisterWorkflowType">REST API Reference for RegisterWorkflowType Operation</seealso>
        public virtual Task<RegisterWorkflowTypeResponse> RegisterWorkflowTypeAsync(RegisterWorkflowTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterWorkflowTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterWorkflowTypeResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterWorkflowTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RequestCancelWorkflowExecution

        internal virtual RequestCancelWorkflowExecutionResponse RequestCancelWorkflowExecution(RequestCancelWorkflowExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestCancelWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestCancelWorkflowExecutionResponseUnmarshaller.Instance;

            return Invoke<RequestCancelWorkflowExecutionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RequestCancelWorkflowExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestCancelWorkflowExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RequestCancelWorkflowExecution">REST API Reference for RequestCancelWorkflowExecution Operation</seealso>
        public virtual Task<RequestCancelWorkflowExecutionResponse> RequestCancelWorkflowExecutionAsync(RequestCancelWorkflowExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestCancelWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestCancelWorkflowExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<RequestCancelWorkflowExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RespondActivityTaskCanceled

        internal virtual RespondActivityTaskCanceledResponse RespondActivityTaskCanceled(RespondActivityTaskCanceledRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RespondActivityTaskCanceledRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RespondActivityTaskCanceledResponseUnmarshaller.Instance;

            return Invoke<RespondActivityTaskCanceledResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RespondActivityTaskCanceled operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskCanceled operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondActivityTaskCanceled">REST API Reference for RespondActivityTaskCanceled Operation</seealso>
        public virtual Task<RespondActivityTaskCanceledResponse> RespondActivityTaskCanceledAsync(RespondActivityTaskCanceledRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RespondActivityTaskCanceledRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RespondActivityTaskCanceledResponseUnmarshaller.Instance;

            return InvokeAsync<RespondActivityTaskCanceledResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RespondActivityTaskCompleted

        internal virtual RespondActivityTaskCompletedResponse RespondActivityTaskCompleted(RespondActivityTaskCompletedRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RespondActivityTaskCompletedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RespondActivityTaskCompletedResponseUnmarshaller.Instance;

            return Invoke<RespondActivityTaskCompletedResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RespondActivityTaskCompleted operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskCompleted operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondActivityTaskCompleted">REST API Reference for RespondActivityTaskCompleted Operation</seealso>
        public virtual Task<RespondActivityTaskCompletedResponse> RespondActivityTaskCompletedAsync(RespondActivityTaskCompletedRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RespondActivityTaskCompletedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RespondActivityTaskCompletedResponseUnmarshaller.Instance;

            return InvokeAsync<RespondActivityTaskCompletedResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RespondActivityTaskFailed

        internal virtual RespondActivityTaskFailedResponse RespondActivityTaskFailed(RespondActivityTaskFailedRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RespondActivityTaskFailedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RespondActivityTaskFailedResponseUnmarshaller.Instance;

            return Invoke<RespondActivityTaskFailedResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RespondActivityTaskFailed operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondActivityTaskFailed operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondActivityTaskFailed">REST API Reference for RespondActivityTaskFailed Operation</seealso>
        public virtual Task<RespondActivityTaskFailedResponse> RespondActivityTaskFailedAsync(RespondActivityTaskFailedRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RespondActivityTaskFailedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RespondActivityTaskFailedResponseUnmarshaller.Instance;

            return InvokeAsync<RespondActivityTaskFailedResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RespondDecisionTaskCompleted

        internal virtual RespondDecisionTaskCompletedResponse RespondDecisionTaskCompleted(RespondDecisionTaskCompletedRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RespondDecisionTaskCompletedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RespondDecisionTaskCompletedResponseUnmarshaller.Instance;

            return Invoke<RespondDecisionTaskCompletedResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RespondDecisionTaskCompleted operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RespondDecisionTaskCompleted operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/RespondDecisionTaskCompleted">REST API Reference for RespondDecisionTaskCompleted Operation</seealso>
        public virtual Task<RespondDecisionTaskCompletedResponse> RespondDecisionTaskCompletedAsync(RespondDecisionTaskCompletedRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RespondDecisionTaskCompletedRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RespondDecisionTaskCompletedResponseUnmarshaller.Instance;

            return InvokeAsync<RespondDecisionTaskCompletedResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SignalWorkflowExecution

        internal virtual SignalWorkflowExecutionResponse SignalWorkflowExecution(SignalWorkflowExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignalWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignalWorkflowExecutionResponseUnmarshaller.Instance;

            return Invoke<SignalWorkflowExecutionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SignalWorkflowExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignalWorkflowExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/SignalWorkflowExecution">REST API Reference for SignalWorkflowExecution Operation</seealso>
        public virtual Task<SignalWorkflowExecutionResponse> SignalWorkflowExecutionAsync(SignalWorkflowExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignalWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignalWorkflowExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<SignalWorkflowExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartWorkflowExecution

        internal virtual StartWorkflowExecutionResponse StartWorkflowExecution(StartWorkflowExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWorkflowExecutionResponseUnmarshaller.Instance;

            return Invoke<StartWorkflowExecutionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartWorkflowExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartWorkflowExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/StartWorkflowExecution">REST API Reference for StartWorkflowExecution Operation</seealso>
        public virtual Task<StartWorkflowExecutionResponse> StartWorkflowExecutionAsync(StartWorkflowExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWorkflowExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StartWorkflowExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TerminateWorkflowExecution

        internal virtual TerminateWorkflowExecutionResponse TerminateWorkflowExecution(TerminateWorkflowExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateWorkflowExecutionResponseUnmarshaller.Instance;

            return Invoke<TerminateWorkflowExecutionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TerminateWorkflowExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkflowExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/swf-2012-01-25/TerminateWorkflowExecution">REST API Reference for TerminateWorkflowExecution Operation</seealso>
        public virtual Task<TerminateWorkflowExecutionResponse> TerminateWorkflowExecutionAsync(TerminateWorkflowExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateWorkflowExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateWorkflowExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateWorkflowExecutionResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}