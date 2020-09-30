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
 * Do not modify this file. This file is generated from the sagemaker-a2i-runtime-2019-11-07.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AugmentedAIRuntime.Model;
using Amazon.AugmentedAIRuntime.Model.Internal.MarshallTransformations;
using Amazon.AugmentedAIRuntime.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AugmentedAIRuntime
{
    /// <summary>
    /// Implementation for accessing AugmentedAIRuntime
    ///
    /// <important> 
    /// <para>
    /// Amazon Augmented AI is in preview release and is subject to change. We do not recommend
    /// using this product in production environments.
    /// </para>
    ///  </important> 
    /// <para>
    /// Amazon Augmented AI (Amazon A2I) adds the benefit of human judgment to any machine
    /// learning application. When an AI application can't evaluate data with a high degree
    /// of confidence, human reviewers can take over. This human review is called a human
    /// review workflow. To create and start a human review workflow, you need three resources:
    /// a <i>worker task template</i>, a <i>flow definition</i>, and a <i>human loop</i>.
    /// </para>
    ///  
    /// <para>
    /// For information about these resources and prerequisites for using Amazon A2I, see
    /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/a2i-getting-started.html">Get
    /// Started with Amazon Augmented AI</a> in the Amazon SageMaker Developer Guide.
    /// </para>
    ///  
    /// <para>
    /// This API reference includes information about API actions and data types that you
    /// can use to interact with Amazon A2I programmatically. Use this guide to:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Start a human loop with the <code>StartHumanLoop</code> operation when using Amazon
    /// A2I with a <i>custom task type</i>. To learn more about the difference between custom
    /// and built-in task types, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/a2i-task-types-general.html">Use
    /// Task Types </a>. To learn how to start a human loop using this API, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/a2i-start-human-loop.html#a2i-instructions-starthumanloop">Create
    /// and Start a Human Loop for a Custom Task Type </a> in the Amazon SageMaker Developer
    /// Guide.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Manage your human loops. You can list all human loops that you have created, describe
    /// individual human loops, and stop and delete human loops. To learn more, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/a2i-monitor-humanloop-results.html">Monitor
    /// and Manage Your Human Loop </a> in the Amazon SageMaker Developer Guide.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Amazon A2I integrates APIs from various AWS services to create and start human review
    /// workflows for those services. To learn how Amazon A2I uses these APIs, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/a2i-api-references.html">Use
    /// APIs in Amazon A2I</a> in the Amazon SageMaker Developer Guide.
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial class AmazonAugmentedAIRuntimeClient : AmazonServiceClient, IAmazonAugmentedAIRuntime
    {
        private static IServiceMetadata serviceMetadata = new AmazonAugmentedAIRuntimeMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonAugmentedAIRuntimeClient with the credentials loaded from the application's
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
        public AmazonAugmentedAIRuntimeClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAugmentedAIRuntimeConfig()) { }

        /// <summary>
        /// Constructs AmazonAugmentedAIRuntimeClient with the credentials loaded from the application's
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
        public AmazonAugmentedAIRuntimeClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAugmentedAIRuntimeConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAugmentedAIRuntimeClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAugmentedAIRuntimeClient Configuration Object</param>
        public AmazonAugmentedAIRuntimeClient(AmazonAugmentedAIRuntimeConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonAugmentedAIRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAugmentedAIRuntimeClient(AWSCredentials credentials)
            : this(credentials, new AmazonAugmentedAIRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAugmentedAIRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAugmentedAIRuntimeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAugmentedAIRuntimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAugmentedAIRuntimeClient with AWS Credentials and an
        /// AmazonAugmentedAIRuntimeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAugmentedAIRuntimeClient Configuration Object</param>
        public AmazonAugmentedAIRuntimeClient(AWSCredentials credentials, AmazonAugmentedAIRuntimeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAugmentedAIRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAugmentedAIRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAugmentedAIRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAugmentedAIRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAugmentedAIRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAugmentedAIRuntimeConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAugmentedAIRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAugmentedAIRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAugmentedAIRuntimeClient Configuration Object</param>
        public AmazonAugmentedAIRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAugmentedAIRuntimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAugmentedAIRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAugmentedAIRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAugmentedAIRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAugmentedAIRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAugmentedAIRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAugmentedAIRuntimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAugmentedAIRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAugmentedAIRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAugmentedAIRuntimeClient Configuration Object</param>
        public AmazonAugmentedAIRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAugmentedAIRuntimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IAugmentedAIRuntimePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IAugmentedAIRuntimePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new AugmentedAIRuntimePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

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


        #region  DeleteHumanLoop

        internal virtual DeleteHumanLoopResponse DeleteHumanLoop(DeleteHumanLoopRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHumanLoopRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHumanLoopResponseUnmarshaller.Instance;

            return Invoke<DeleteHumanLoopResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified human loop for a flow definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHumanLoop service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHumanLoop service method, as returned by AugmentedAIRuntime.</returns>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-a2i-runtime-2019-11-07/DeleteHumanLoop">REST API Reference for DeleteHumanLoop Operation</seealso>
        public virtual Task<DeleteHumanLoopResponse> DeleteHumanLoopAsync(DeleteHumanLoopRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteHumanLoopRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteHumanLoopResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteHumanLoopResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeHumanLoop

        internal virtual DescribeHumanLoopResponse DescribeHumanLoop(DescribeHumanLoopRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHumanLoopRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHumanLoopResponseUnmarshaller.Instance;

            return Invoke<DescribeHumanLoopResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the specified human loop.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHumanLoop service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHumanLoop service method, as returned by AugmentedAIRuntime.</returns>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-a2i-runtime-2019-11-07/DescribeHumanLoop">REST API Reference for DescribeHumanLoop Operation</seealso>
        public virtual Task<DescribeHumanLoopResponse> DescribeHumanLoopAsync(DescribeHumanLoopRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHumanLoopRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHumanLoopResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHumanLoopResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListHumanLoops

        internal virtual ListHumanLoopsResponse ListHumanLoops(ListHumanLoopsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHumanLoopsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHumanLoopsResponseUnmarshaller.Instance;

            return Invoke<ListHumanLoopsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about human loops, given the specified parameters. If a human
        /// loop was deleted, it will not be included.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHumanLoops service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHumanLoops service method, as returned by AugmentedAIRuntime.</returns>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-a2i-runtime-2019-11-07/ListHumanLoops">REST API Reference for ListHumanLoops Operation</seealso>
        public virtual Task<ListHumanLoopsResponse> ListHumanLoopsAsync(ListHumanLoopsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListHumanLoopsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListHumanLoopsResponseUnmarshaller.Instance;

            return InvokeAsync<ListHumanLoopsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartHumanLoop

        internal virtual StartHumanLoopResponse StartHumanLoop(StartHumanLoopRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartHumanLoopRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartHumanLoopResponseUnmarshaller.Instance;

            return Invoke<StartHumanLoopResponse>(request, options);
        }



        /// <summary>
        /// Starts a human loop, provided that at least one activation condition is met.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartHumanLoop service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartHumanLoop service method, as returned by AugmentedAIRuntime.</returns>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ConflictException">
        /// Your request has the same name as another active human loop but has different input
        /// data. You cannot start two human loops with the same name and different input data.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Delete some resources or request an increase in your
        /// service quota.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-a2i-runtime-2019-11-07/StartHumanLoop">REST API Reference for StartHumanLoop Operation</seealso>
        public virtual Task<StartHumanLoopResponse> StartHumanLoopAsync(StartHumanLoopRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartHumanLoopRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartHumanLoopResponseUnmarshaller.Instance;

            return InvokeAsync<StartHumanLoopResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopHumanLoop

        internal virtual StopHumanLoopResponse StopHumanLoop(StopHumanLoopRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopHumanLoopRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopHumanLoopResponseUnmarshaller.Instance;

            return Invoke<StopHumanLoopResponse>(request, options);
        }



        /// <summary>
        /// Stops the specified human loop.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopHumanLoop service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopHumanLoop service method, as returned by AugmentedAIRuntime.</returns>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.InternalServerException">
        /// We couldn't process your request because of an issue with the server. Try again later.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ResourceNotFoundException">
        /// We couldn't find the requested resource.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ThrottlingException">
        /// You exceeded the maximum number of requests.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ValidationException">
        /// The request isn't valid. Check the syntax and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-a2i-runtime-2019-11-07/StopHumanLoop">REST API Reference for StopHumanLoop Operation</seealso>
        public virtual Task<StopHumanLoopResponse> StopHumanLoopAsync(StopHumanLoopRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopHumanLoopRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopHumanLoopResponseUnmarshaller.Instance;

            return InvokeAsync<StopHumanLoopResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}