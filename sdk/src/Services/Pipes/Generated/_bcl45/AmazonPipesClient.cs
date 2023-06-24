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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Pipes.Model;
using Amazon.Pipes.Model.Internal.MarshallTransformations;
using Amazon.Pipes.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Pipes
{
    /// <summary>
    /// Implementation for accessing Pipes
    ///
    /// Amazon EventBridge Pipes connects event sources to targets. Pipes reduces the need
    /// for specialized knowledge and integration code when developing event driven architectures.
    /// This helps ensures consistency across your company’s applications. With Pipes, the
    /// target can be any available EventBridge target. To set up a pipe, you select the event
    /// source, add optional event filtering, define optional enrichment, and select the target
    /// for the event data.
    /// </summary>
    public partial class AmazonPipesClient : AmazonServiceClient, IAmazonPipes
    {
        private static IServiceMetadata serviceMetadata = new AmazonPipesMetadata();
        private IPipesPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPipesPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new PipesPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonPipesClient with the credentials loaded from the application's
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
        public AmazonPipesClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPipesConfig()) { }

        /// <summary>
        /// Constructs AmazonPipesClient with the credentials loaded from the application's
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
        public AmazonPipesClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPipesConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPipesClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPipesClient Configuration Object</param>
        public AmazonPipesClient(AmazonPipesConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonPipesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPipesClient(AWSCredentials credentials)
            : this(credentials, new AmazonPipesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPipesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPipesClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPipesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPipesClient with AWS Credentials and an
        /// AmazonPipesClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPipesClient Configuration Object</param>
        public AmazonPipesClient(AWSCredentials credentials, AmazonPipesConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPipesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPipesClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPipesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPipesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPipesClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPipesConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPipesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPipesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPipesClient Configuration Object</param>
        public AmazonPipesClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPipesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPipesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPipesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPipesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPipesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPipesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPipesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPipesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPipesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPipesClient Configuration Object</param>
        public AmazonPipesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPipesConfig clientConfig)
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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPipesEndpointResolver());
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


        #region  CreatePipe


        /// <summary>
        /// Create a pipe. Amazon EventBridge Pipes connect event sources to targets and reduces
        /// the need for specialized knowledge and integration code.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipe service method.</param>
        /// 
        /// <returns>The response from the CreatePipe service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.ConflictException">
        /// An action you attempted resulted in an exception.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ServiceQuotaExceededException">
        /// A quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ThrottlingException">
        /// An action was throttled.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/CreatePipe">REST API Reference for CreatePipe Operation</seealso>
        public virtual CreatePipeResponse CreatePipe(CreatePipeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipeResponseUnmarshaller.Instance;

            return Invoke<CreatePipeResponse>(request, options);
        }


        /// <summary>
        /// Create a pipe. Amazon EventBridge Pipes connect event sources to targets and reduces
        /// the need for specialized knowledge and integration code.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePipe service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.ConflictException">
        /// An action you attempted resulted in an exception.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ServiceQuotaExceededException">
        /// A quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ThrottlingException">
        /// An action was throttled.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/CreatePipe">REST API Reference for CreatePipe Operation</seealso>
        public virtual Task<CreatePipeResponse> CreatePipeAsync(CreatePipeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePipeResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreatePipeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePipe


        /// <summary>
        /// Delete an existing pipe. For more information about pipes, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes.html">Amazon
        /// EventBridge Pipes</a> in the Amazon EventBridge User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipe service method.</param>
        /// 
        /// <returns>The response from the DeletePipe service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.ConflictException">
        /// An action you attempted resulted in an exception.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ThrottlingException">
        /// An action was throttled.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/DeletePipe">REST API Reference for DeletePipe Operation</seealso>
        public virtual DeletePipeResponse DeletePipe(DeletePipeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipeResponseUnmarshaller.Instance;

            return Invoke<DeletePipeResponse>(request, options);
        }


        /// <summary>
        /// Delete an existing pipe. For more information about pipes, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes.html">Amazon
        /// EventBridge Pipes</a> in the Amazon EventBridge User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePipe service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.ConflictException">
        /// An action you attempted resulted in an exception.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ThrottlingException">
        /// An action was throttled.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/DeletePipe">REST API Reference for DeletePipe Operation</seealso>
        public virtual Task<DeletePipeResponse> DeletePipeAsync(DeletePipeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePipeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeletePipeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePipe


        /// <summary>
        /// Get the information about an existing pipe. For more information about pipes, see
        /// <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes.html">Amazon
        /// EventBridge Pipes</a> in the Amazon EventBridge User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePipe service method.</param>
        /// 
        /// <returns>The response from the DescribePipe service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ThrottlingException">
        /// An action was throttled.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/DescribePipe">REST API Reference for DescribePipe Operation</seealso>
        public virtual DescribePipeResponse DescribePipe(DescribePipeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePipeResponseUnmarshaller.Instance;

            return Invoke<DescribePipeResponse>(request, options);
        }


        /// <summary>
        /// Get the information about an existing pipe. For more information about pipes, see
        /// <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes.html">Amazon
        /// EventBridge Pipes</a> in the Amazon EventBridge User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePipe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePipe service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ThrottlingException">
        /// An action was throttled.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/DescribePipe">REST API Reference for DescribePipe Operation</seealso>
        public virtual Task<DescribePipeResponse> DescribePipeAsync(DescribePipeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePipeResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribePipeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPipes


        /// <summary>
        /// Get the pipes associated with this account. For more information about pipes, see
        /// <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes.html">Amazon
        /// EventBridge Pipes</a> in the Amazon EventBridge User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipes service method.</param>
        /// 
        /// <returns>The response from the ListPipes service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ThrottlingException">
        /// An action was throttled.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/ListPipes">REST API Reference for ListPipes Operation</seealso>
        public virtual ListPipesResponse ListPipes(ListPipesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipesResponseUnmarshaller.Instance;

            return Invoke<ListPipesResponse>(request, options);
        }


        /// <summary>
        /// Get the pipes associated with this account. For more information about pipes, see
        /// <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes.html">Amazon
        /// EventBridge Pipes</a> in the Amazon EventBridge User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPipes service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ThrottlingException">
        /// An action was throttled.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/ListPipes">REST API Reference for ListPipes Operation</seealso>
        public virtual Task<ListPipesResponse> ListPipesAsync(ListPipesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPipesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPipesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListPipesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Displays the tags associated with a pipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Displays the tags associated with a pipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartPipe


        /// <summary>
        /// Start an existing pipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPipe service method.</param>
        /// 
        /// <returns>The response from the StartPipe service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.ConflictException">
        /// An action you attempted resulted in an exception.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ThrottlingException">
        /// An action was throttled.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/StartPipe">REST API Reference for StartPipe Operation</seealso>
        public virtual StartPipeResponse StartPipe(StartPipeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPipeResponseUnmarshaller.Instance;

            return Invoke<StartPipeResponse>(request, options);
        }


        /// <summary>
        /// Start an existing pipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPipe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartPipe service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.ConflictException">
        /// An action you attempted resulted in an exception.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ThrottlingException">
        /// An action was throttled.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/StartPipe">REST API Reference for StartPipe Operation</seealso>
        public virtual Task<StartPipeResponse> StartPipeAsync(StartPipeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPipeResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartPipeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopPipe


        /// <summary>
        /// Stop an existing pipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopPipe service method.</param>
        /// 
        /// <returns>The response from the StopPipe service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.ConflictException">
        /// An action you attempted resulted in an exception.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ThrottlingException">
        /// An action was throttled.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/StopPipe">REST API Reference for StopPipe Operation</seealso>
        public virtual StopPipeResponse StopPipe(StopPipeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopPipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopPipeResponseUnmarshaller.Instance;

            return Invoke<StopPipeResponse>(request, options);
        }


        /// <summary>
        /// Stop an existing pipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopPipe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopPipe service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.ConflictException">
        /// An action you attempted resulted in an exception.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ThrottlingException">
        /// An action was throttled.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/StopPipe">REST API Reference for StopPipe Operation</seealso>
        public virtual Task<StopPipeResponse> StopPipeAsync(StopPipeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopPipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopPipeResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopPipeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified pipe. Tags can help you
        /// organize and categorize your resources. You can also use them to scope user permissions
        /// by granting a user permission to access or change only resources with certain tag
        /// values.
        /// 
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>TagResource</code> action with a pipe that already has tags.
        /// If you specify a new tag key, this tag is appended to the list of tags associated
        /// with the pipe. If you specify a tag key that is already associated with the pipe,
        /// the new tag value that you specify replaces the previous value for that tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a pipe.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified pipe. Tags can help you
        /// organize and categorize your resources. You can also use them to scope user permissions
        /// by granting a user permission to access or change only resources with certain tag
        /// values.
        /// 
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>TagResource</code> action with a pipe that already has tags.
        /// If you specify a new tag key, this tag is appended to the list of tags associated
        /// with the pipe. If you specify a tag key that is already associated with the pipe,
        /// the new tag value that you specify replaces the previous value for that tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a pipe.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified pipes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes one or more tags from the specified pipes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdatePipe


        /// <summary>
        /// Update an existing pipe. When you call <code>UpdatePipe</code>, only the fields that
        /// are included in the request are changed, the rest are unchanged. The exception to
        /// this is if you modify any Amazon Web Services-service specific fields in the <code>SourceParameters</code>,
        /// <code>EnrichmentParameters</code>, or <code>TargetParameters</code> objects. The fields
        /// in these objects are updated atomically as one and override existing values. This
        /// is by design and means that if you don't specify an optional field in one of these
        /// Parameters objects, that field will be set to its system-default value after the update.
        /// 
        ///  
        /// <para>
        /// For more information about pipes, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes.html">
        /// Amazon EventBridge Pipes</a> in the Amazon EventBridge User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipe service method.</param>
        /// 
        /// <returns>The response from the UpdatePipe service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.ConflictException">
        /// An action you attempted resulted in an exception.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ThrottlingException">
        /// An action was throttled.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/UpdatePipe">REST API Reference for UpdatePipe Operation</seealso>
        public virtual UpdatePipeResponse UpdatePipe(UpdatePipeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipeResponseUnmarshaller.Instance;

            return Invoke<UpdatePipeResponse>(request, options);
        }


        /// <summary>
        /// Update an existing pipe. When you call <code>UpdatePipe</code>, only the fields that
        /// are included in the request are changed, the rest are unchanged. The exception to
        /// this is if you modify any Amazon Web Services-service specific fields in the <code>SourceParameters</code>,
        /// <code>EnrichmentParameters</code>, or <code>TargetParameters</code> objects. The fields
        /// in these objects are updated atomically as one and override existing values. This
        /// is by design and means that if you don't specify an optional field in one of these
        /// Parameters objects, that field will be set to its system-default value after the update.
        /// 
        ///  
        /// <para>
        /// For more information about pipes, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes.html">
        /// Amazon EventBridge Pipes</a> in the Amazon EventBridge User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipe service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePipe service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.ConflictException">
        /// An action you attempted resulted in an exception.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ThrottlingException">
        /// An action was throttled.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/UpdatePipe">REST API Reference for UpdatePipe Operation</seealso>
        public virtual Task<UpdatePipeResponse> UpdatePipeAsync(UpdatePipeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdatePipeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePipeResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdatePipeResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}