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
    /// Amazon Augmented AI (Augmented AI) (Preview) is a service that adds human judgment
    /// to any machine learning application. Human reviewers can take over when an AI application
    /// can't evaluate data with a high degree of confidence.
    /// 
    ///  
    /// <para>
    /// From fraudulent bank transaction identification to document processing to image analysis,
    /// machine learning models can be trained to make decisions as well as or better than
    /// a human. Nevertheless, some decisions require contextual interpretation, such as when
    /// you need to decide whether an image is appropriate for a given audience. Content moderation
    /// guidelines are nuanced and highly dependent on context, and they vary between countries.
    /// When trying to apply AI in these situations, you can be forced to choose between "ML
    /// only" systems with unacceptably high error rates or "human only" systems that are
    /// expensive and difficult to scale, and that slow down decision making.
    /// </para>
    ///  
    /// <para>
    /// This API reference includes information about API actions and data types you can use
    /// to interact with Augmented AI programmatically. 
    /// </para>
    ///  
    /// <para>
    /// You can create a flow definition against the Augmented AI API. Provide the Amazon
    /// Resource Name (ARN) of a flow definition to integrate AI service APIs, such as <code>Textract.AnalyzeDocument</code>
    /// and <code>Rekognition.DetectModerationLabels</code>. These AI services, in turn, invoke
    /// the <a>StartHumanLoop</a> API, which evaluates conditions under which humans will
    /// be invoked. If humans are required, Augmented AI creates a human loop. Results of
    /// human work are available asynchronously in Amazon Simple Storage Service (Amazon S3).
    /// You can use Amazon CloudWatch Events to detect human work results.
    /// </para>
    ///  
    /// <para>
    /// You can find additional Augmented AI API documentation in the following reference
    /// guides: <a href="https://docs.aws.amazon.com/rekognition/latest/dg/API_Reference.html">Amazon
    /// Rekognition</a>, <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/API_Reference.html">Amazon
    /// SageMaker</a>, and <a href="https://docs.aws.amazon.com/textract/latest/dg/API_Reference.html">Amazon
    /// Textract</a>.
    /// </para>
    /// </summary>
    public partial class AmazonAugmentedAIRuntimeClient : AmazonServiceClient, IAmazonAugmentedAIRuntime
    {
        private static IServiceMetadata serviceMetadata = new AmazonAugmentedAIRuntimeMetadata();
        
        #region Constructors

#if NETSTANDARD
    
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

#endif

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
        /// Your request could not be processed.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ResourceNotFoundException">
        /// We were unable to find the requested resource.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ThrottlingException">
        /// Your request has exceeded the allowed amount of requests.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ValidationException">
        /// Your request was not valid. Check the syntax and try again.
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
        /// Your request could not be processed.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ResourceNotFoundException">
        /// We were unable to find the requested resource.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ThrottlingException">
        /// Your request has exceeded the allowed amount of requests.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ValidationException">
        /// Your request was not valid. Check the syntax and try again.
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
        /// Your request could not be processed.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ThrottlingException">
        /// Your request has exceeded the allowed amount of requests.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ValidationException">
        /// Your request was not valid. Check the syntax and try again.
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
        /// Your request could not be processed.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ThrottlingException">
        /// Your request has exceeded the allowed amount of requests.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ValidationException">
        /// Your request was not valid. Check the syntax and try again.
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
        /// Your request could not be processed.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ResourceNotFoundException">
        /// We were unable to find the requested resource.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ThrottlingException">
        /// Your request has exceeded the allowed amount of requests.
        /// </exception>
        /// <exception cref="Amazon.AugmentedAIRuntime.Model.ValidationException">
        /// Your request was not valid. Check the syntax and try again.
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