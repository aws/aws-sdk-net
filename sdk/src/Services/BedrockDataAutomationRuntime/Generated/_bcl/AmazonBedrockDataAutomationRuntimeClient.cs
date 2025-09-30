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
 * Do not modify this file. This file is generated from the bedrock-data-automation-runtime-2024-06-13.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.BedrockDataAutomationRuntime.Model;
using Amazon.BedrockDataAutomationRuntime.Model.Internal.MarshallTransformations;
using Amazon.BedrockDataAutomationRuntime.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.BedrockDataAutomationRuntime
{
    /// <summary>
    /// <para>Implementation for accessing BedrockDataAutomationRuntime</para>
    ///
    /// Amazon Bedrock Data Automation Runtime
    /// </summary>
    public partial class AmazonBedrockDataAutomationRuntimeClient : AmazonServiceClient, IAmazonBedrockDataAutomationRuntime
    {
        private static IServiceMetadata serviceMetadata = new AmazonBedrockDataAutomationRuntimeMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationRuntimeClient with the credentials loaded from the application's
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
        public AmazonBedrockDataAutomationRuntimeClient()
            : base(new AmazonBedrockDataAutomationRuntimeConfig()) { }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationRuntimeClient with the credentials loaded from the application's
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
        public AmazonBedrockDataAutomationRuntimeClient(RegionEndpoint region)
            : base(new AmazonBedrockDataAutomationRuntimeConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationRuntimeClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBedrockDataAutomationRuntimeClient Configuration Object</param>
        public AmazonBedrockDataAutomationRuntimeClient(AmazonBedrockDataAutomationRuntimeConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBedrockDataAutomationRuntimeClient(AWSCredentials credentials)
            : this(credentials, new AmazonBedrockDataAutomationRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationRuntimeClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockDataAutomationRuntimeClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBedrockDataAutomationRuntimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationRuntimeClient with AWS Credentials and an
        /// AmazonBedrockDataAutomationRuntimeClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBedrockDataAutomationRuntimeClient Configuration Object</param>
        public AmazonBedrockDataAutomationRuntimeClient(AWSCredentials credentials, AmazonBedrockDataAutomationRuntimeConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBedrockDataAutomationRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockDataAutomationRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockDataAutomationRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBedrockDataAutomationRuntimeConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockDataAutomationRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBedrockDataAutomationRuntimeClient Configuration Object</param>
        public AmazonBedrockDataAutomationRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBedrockDataAutomationRuntimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBedrockDataAutomationRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockDataAutomationRuntimeConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationRuntimeClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBedrockDataAutomationRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBedrockDataAutomationRuntimeConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBedrockDataAutomationRuntimeClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBedrockDataAutomationRuntimeClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBedrockDataAutomationRuntimeClient Configuration Object</param>
        public AmazonBedrockDataAutomationRuntimeClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBedrockDataAutomationRuntimeConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBedrockDataAutomationRuntimeEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBedrockDataAutomationRuntimeAuthSchemeHandler());
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


        #region  GetDataAutomationStatus


        /// <summary>
        /// API used to get data automation status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataAutomationStatus service method.</param>
        /// 
        /// <returns>The response from the GetDataAutomationStatus service method, as returned by BedrockDataAutomationRuntime.</returns>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.AccessDeniedException">
        /// This exception will be thrown when customer does not have access to API.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.InternalServerException">
        /// This exception is for any internal un-expected service errors.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ResourceNotFoundException">
        /// This exception will be thrown when resource provided from customer not found.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ThrottlingException">
        /// This exception will be thrown when customer reached API TPS limit.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ValidationException">
        /// This exception will be thrown when customer provided invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-runtime-2024-06-13/GetDataAutomationStatus">REST API Reference for GetDataAutomationStatus Operation</seealso>
        public virtual GetDataAutomationStatusResponse GetDataAutomationStatus(GetDataAutomationStatusRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataAutomationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataAutomationStatusResponseUnmarshaller.Instance;

            return Invoke<GetDataAutomationStatusResponse>(request, options);
        }


        /// <summary>
        /// API used to get data automation status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataAutomationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataAutomationStatus service method, as returned by BedrockDataAutomationRuntime.</returns>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.AccessDeniedException">
        /// This exception will be thrown when customer does not have access to API.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.InternalServerException">
        /// This exception is for any internal un-expected service errors.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ResourceNotFoundException">
        /// This exception will be thrown when resource provided from customer not found.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ThrottlingException">
        /// This exception will be thrown when customer reached API TPS limit.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ValidationException">
        /// This exception will be thrown when customer provided invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-runtime-2024-06-13/GetDataAutomationStatus">REST API Reference for GetDataAutomationStatus Operation</seealso>
        public virtual Task<GetDataAutomationStatusResponse> GetDataAutomationStatusAsync(GetDataAutomationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetDataAutomationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataAutomationStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetDataAutomationStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InvokeDataAutomationAsync


        /// <summary>
        /// Async API: Invoke data automation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeDataAutomationAsync service method.</param>
        /// 
        /// <returns>The response from the InvokeDataAutomationAsync service method, as returned by BedrockDataAutomationRuntime.</returns>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.AccessDeniedException">
        /// This exception will be thrown when customer does not have access to API.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.InternalServerException">
        /// This exception is for any internal un-expected service errors.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ServiceQuotaExceededException">
        /// This exception will be thrown when service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ThrottlingException">
        /// This exception will be thrown when customer reached API TPS limit.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ValidationException">
        /// This exception will be thrown when customer provided invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-runtime-2024-06-13/InvokeDataAutomationAsync">REST API Reference for InvokeDataAutomationAsync Operation</seealso>
        public virtual InvokeDataAutomationAsyncResponse InvokeDataAutomationAsync(InvokeDataAutomationAsyncRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeDataAutomationAsyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeDataAutomationAsyncResponseUnmarshaller.Instance;

            return Invoke<InvokeDataAutomationAsyncResponse>(request, options);
        }


        /// <summary>
        /// Async API: Invoke data automation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeDataAutomationAsync service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InvokeDataAutomationAsync service method, as returned by BedrockDataAutomationRuntime.</returns>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.AccessDeniedException">
        /// This exception will be thrown when customer does not have access to API.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.InternalServerException">
        /// This exception is for any internal un-expected service errors.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ServiceQuotaExceededException">
        /// This exception will be thrown when service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ThrottlingException">
        /// This exception will be thrown when customer reached API TPS limit.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ValidationException">
        /// This exception will be thrown when customer provided invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-runtime-2024-06-13/InvokeDataAutomationAsync">REST API Reference for InvokeDataAutomationAsync Operation</seealso>
        public virtual Task<InvokeDataAutomationAsyncResponse> InvokeDataAutomationAsyncAsync(InvokeDataAutomationAsyncRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = InvokeDataAutomationAsyncRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InvokeDataAutomationAsyncResponseUnmarshaller.Instance;
            
            return InvokeAsync<InvokeDataAutomationAsyncResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List tags for an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BedrockDataAutomationRuntime.</returns>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.AccessDeniedException">
        /// This exception will be thrown when customer does not have access to API.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.InternalServerException">
        /// This exception is for any internal un-expected service errors.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ResourceNotFoundException">
        /// This exception will be thrown when resource provided from customer not found.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ThrottlingException">
        /// This exception will be thrown when customer reached API TPS limit.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ValidationException">
        /// This exception will be thrown when customer provided invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-runtime-2024-06-13/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// List tags for an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by BedrockDataAutomationRuntime.</returns>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.AccessDeniedException">
        /// This exception will be thrown when customer does not have access to API.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.InternalServerException">
        /// This exception is for any internal un-expected service errors.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ResourceNotFoundException">
        /// This exception will be thrown when resource provided from customer not found.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ThrottlingException">
        /// This exception will be thrown when customer reached API TPS limit.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ValidationException">
        /// This exception will be thrown when customer provided invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-runtime-2024-06-13/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tag an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BedrockDataAutomationRuntime.</returns>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.AccessDeniedException">
        /// This exception will be thrown when customer does not have access to API.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.InternalServerException">
        /// This exception is for any internal un-expected service errors.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ResourceNotFoundException">
        /// This exception will be thrown when resource provided from customer not found.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ServiceQuotaExceededException">
        /// This exception will be thrown when service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ThrottlingException">
        /// This exception will be thrown when customer reached API TPS limit.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ValidationException">
        /// This exception will be thrown when customer provided invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-runtime-2024-06-13/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Tag an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by BedrockDataAutomationRuntime.</returns>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.AccessDeniedException">
        /// This exception will be thrown when customer does not have access to API.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.InternalServerException">
        /// This exception is for any internal un-expected service errors.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ResourceNotFoundException">
        /// This exception will be thrown when resource provided from customer not found.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ServiceQuotaExceededException">
        /// This exception will be thrown when service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ThrottlingException">
        /// This exception will be thrown when customer reached API TPS limit.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ValidationException">
        /// This exception will be thrown when customer provided invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-runtime-2024-06-13/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Untag an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BedrockDataAutomationRuntime.</returns>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.AccessDeniedException">
        /// This exception will be thrown when customer does not have access to API.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.InternalServerException">
        /// This exception is for any internal un-expected service errors.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ResourceNotFoundException">
        /// This exception will be thrown when resource provided from customer not found.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ThrottlingException">
        /// This exception will be thrown when customer reached API TPS limit.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ValidationException">
        /// This exception will be thrown when customer provided invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-runtime-2024-06-13/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Untag an Amazon Bedrock Data Automation resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by BedrockDataAutomationRuntime.</returns>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.AccessDeniedException">
        /// This exception will be thrown when customer does not have access to API.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.InternalServerException">
        /// This exception is for any internal un-expected service errors.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ResourceNotFoundException">
        /// This exception will be thrown when resource provided from customer not found.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ThrottlingException">
        /// This exception will be thrown when customer reached API TPS limit.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ValidationException">
        /// This exception will be thrown when customer provided invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-runtime-2024-06-13/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}