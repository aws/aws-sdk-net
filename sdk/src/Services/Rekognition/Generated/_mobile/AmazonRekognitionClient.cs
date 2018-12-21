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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Rekognition.Model;
using Amazon.Rekognition.Model.Internal.MarshallTransformations;
using Amazon.Rekognition.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Rekognition
{
    /// <summary>
    /// Implementation for accessing Rekognition
    ///
    /// This is the Amazon Rekognition API reference.
    /// </summary>
    public partial class AmazonRekognitionClient : AmazonServiceClient, IAmazonRekognition
    {
        private static IServiceMetadata serviceMetadata = new AmazonRekognitionMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonRekognitionClient with the credentials loaded from the application's
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
        public AmazonRekognitionClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRekognitionConfig()) { }

        /// <summary>
        /// Constructs AmazonRekognitionClient with the credentials loaded from the application's
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
        public AmazonRekognitionClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRekognitionConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRekognitionClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRekognitionClient Configuration Object</param>
        public AmazonRekognitionClient(AmazonRekognitionConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRekognitionClient(AWSCredentials credentials)
            : this(credentials, new AmazonRekognitionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRekognitionClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRekognitionConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Credentials and an
        /// AmazonRekognitionClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRekognitionClient Configuration Object</param>
        public AmazonRekognitionClient(AWSCredentials credentials, AmazonRekognitionConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRekognitionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRekognitionConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRekognitionClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRekognitionClient Configuration Object</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRekognitionConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRekognitionConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRekognitionConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRekognitionClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRekognitionClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRekognitionClient Configuration Object</param>
        public AmazonRekognitionClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRekognitionConfig clientConfig)
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


        #region  CompareFaces

        internal virtual CompareFacesResponse CompareFaces(CompareFacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompareFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompareFacesResponseUnmarshaller.Instance;

            return Invoke<CompareFacesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CompareFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompareFaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CompareFaces">REST API Reference for CompareFaces Operation</seealso>
        public virtual Task<CompareFacesResponse> CompareFacesAsync(CompareFacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompareFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompareFacesResponseUnmarshaller.Instance;

            return InvokeAsync<CompareFacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCollection

        internal virtual CreateCollectionResponse CreateCollection(CreateCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCollectionResponseUnmarshaller.Instance;

            return Invoke<CreateCollectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCollection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateCollection">REST API Reference for CreateCollection Operation</seealso>
        public virtual Task<CreateCollectionResponse> CreateCollectionAsync(CreateCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCollectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStreamProcessor

        internal virtual CreateStreamProcessorResponse CreateStreamProcessor(CreateStreamProcessorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamProcessorResponseUnmarshaller.Instance;

            return Invoke<CreateStreamProcessorResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamProcessor operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateStreamProcessor">REST API Reference for CreateStreamProcessor Operation</seealso>
        public virtual Task<CreateStreamProcessorResponse> CreateStreamProcessorAsync(CreateStreamProcessorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStreamProcessorResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStreamProcessorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCollection

        internal virtual DeleteCollectionResponse DeleteCollection(DeleteCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCollectionResponseUnmarshaller.Instance;

            return Invoke<DeleteCollectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteCollection">REST API Reference for DeleteCollection Operation</seealso>
        public virtual Task<DeleteCollectionResponse> DeleteCollectionAsync(DeleteCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCollectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFaces

        internal virtual DeleteFacesResponse DeleteFaces(DeleteFacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFacesResponseUnmarshaller.Instance;

            return Invoke<DeleteFacesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteFaces">REST API Reference for DeleteFaces Operation</seealso>
        public virtual Task<DeleteFacesResponse> DeleteFacesAsync(DeleteFacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFacesResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteStreamProcessor

        internal virtual DeleteStreamProcessorResponse DeleteStreamProcessor(DeleteStreamProcessorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamProcessorResponseUnmarshaller.Instance;

            return Invoke<DeleteStreamProcessorResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamProcessor operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteStreamProcessor">REST API Reference for DeleteStreamProcessor Operation</seealso>
        public virtual Task<DeleteStreamProcessorResponse> DeleteStreamProcessorAsync(DeleteStreamProcessorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStreamProcessorResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStreamProcessorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCollection

        internal virtual DescribeCollectionResponse DescribeCollection(DescribeCollectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCollectionResponseUnmarshaller.Instance;

            return Invoke<DescribeCollectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCollection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeCollection">REST API Reference for DescribeCollection Operation</seealso>
        public virtual Task<DescribeCollectionResponse> DescribeCollectionAsync(DescribeCollectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCollectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCollectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStreamProcessor

        internal virtual DescribeStreamProcessorResponse DescribeStreamProcessor(DescribeStreamProcessorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamProcessorResponseUnmarshaller.Instance;

            return Invoke<DescribeStreamProcessorResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStreamProcessor operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeStreamProcessor">REST API Reference for DescribeStreamProcessor Operation</seealso>
        public virtual Task<DescribeStreamProcessorResponse> DescribeStreamProcessorAsync(DescribeStreamProcessorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStreamProcessorResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStreamProcessorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectFaces

        internal virtual DetectFacesResponse DetectFaces(DetectFacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectFacesResponseUnmarshaller.Instance;

            return Invoke<DetectFacesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetectFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectFaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectFaces">REST API Reference for DetectFaces Operation</seealso>
        public virtual Task<DetectFacesResponse> DetectFacesAsync(DetectFacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectFacesResponseUnmarshaller.Instance;

            return InvokeAsync<DetectFacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectLabels

        internal virtual DetectLabelsResponse DetectLabels(DetectLabelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectLabelsResponseUnmarshaller.Instance;

            return Invoke<DetectLabelsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetectLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectLabels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectLabels">REST API Reference for DetectLabels Operation</seealso>
        public virtual Task<DetectLabelsResponse> DetectLabelsAsync(DetectLabelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectLabelsResponseUnmarshaller.Instance;

            return InvokeAsync<DetectLabelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectModerationLabels

        internal virtual DetectModerationLabelsResponse DetectModerationLabels(DetectModerationLabelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectModerationLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectModerationLabelsResponseUnmarshaller.Instance;

            return Invoke<DetectModerationLabelsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetectModerationLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectModerationLabels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectModerationLabels">REST API Reference for DetectModerationLabels Operation</seealso>
        public virtual Task<DetectModerationLabelsResponse> DetectModerationLabelsAsync(DetectModerationLabelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectModerationLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectModerationLabelsResponseUnmarshaller.Instance;

            return InvokeAsync<DetectModerationLabelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectText

        internal virtual DetectTextResponse DetectText(DetectTextRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectTextResponseUnmarshaller.Instance;

            return Invoke<DetectTextResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetectText operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectText operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectText">REST API Reference for DetectText Operation</seealso>
        public virtual Task<DetectTextResponse> DetectTextAsync(DetectTextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectTextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectTextResponseUnmarshaller.Instance;

            return InvokeAsync<DetectTextResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCelebrityInfo

        internal virtual GetCelebrityInfoResponse GetCelebrityInfo(GetCelebrityInfoRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCelebrityInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCelebrityInfoResponseUnmarshaller.Instance;

            return Invoke<GetCelebrityInfoResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCelebrityInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCelebrityInfo operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetCelebrityInfo">REST API Reference for GetCelebrityInfo Operation</seealso>
        public virtual Task<GetCelebrityInfoResponse> GetCelebrityInfoAsync(GetCelebrityInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCelebrityInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCelebrityInfoResponseUnmarshaller.Instance;

            return InvokeAsync<GetCelebrityInfoResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCelebrityRecognition

        internal virtual GetCelebrityRecognitionResponse GetCelebrityRecognition(GetCelebrityRecognitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCelebrityRecognitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCelebrityRecognitionResponseUnmarshaller.Instance;

            return Invoke<GetCelebrityRecognitionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCelebrityRecognition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCelebrityRecognition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetCelebrityRecognition">REST API Reference for GetCelebrityRecognition Operation</seealso>
        public virtual Task<GetCelebrityRecognitionResponse> GetCelebrityRecognitionAsync(GetCelebrityRecognitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCelebrityRecognitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCelebrityRecognitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetCelebrityRecognitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetContentModeration

        internal virtual GetContentModerationResponse GetContentModeration(GetContentModerationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContentModerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContentModerationResponseUnmarshaller.Instance;

            return Invoke<GetContentModerationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetContentModeration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContentModeration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetContentModeration">REST API Reference for GetContentModeration Operation</seealso>
        public virtual Task<GetContentModerationResponse> GetContentModerationAsync(GetContentModerationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetContentModerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetContentModerationResponseUnmarshaller.Instance;

            return InvokeAsync<GetContentModerationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFaceDetection

        internal virtual GetFaceDetectionResponse GetFaceDetection(GetFaceDetectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFaceDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFaceDetectionResponseUnmarshaller.Instance;

            return Invoke<GetFaceDetectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetFaceDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFaceDetection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetFaceDetection">REST API Reference for GetFaceDetection Operation</seealso>
        public virtual Task<GetFaceDetectionResponse> GetFaceDetectionAsync(GetFaceDetectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFaceDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFaceDetectionResponseUnmarshaller.Instance;

            return InvokeAsync<GetFaceDetectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFaceSearch

        internal virtual GetFaceSearchResponse GetFaceSearch(GetFaceSearchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFaceSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFaceSearchResponseUnmarshaller.Instance;

            return Invoke<GetFaceSearchResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetFaceSearch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFaceSearch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetFaceSearch">REST API Reference for GetFaceSearch Operation</seealso>
        public virtual Task<GetFaceSearchResponse> GetFaceSearchAsync(GetFaceSearchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFaceSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFaceSearchResponseUnmarshaller.Instance;

            return InvokeAsync<GetFaceSearchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLabelDetection

        internal virtual GetLabelDetectionResponse GetLabelDetection(GetLabelDetectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLabelDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLabelDetectionResponseUnmarshaller.Instance;

            return Invoke<GetLabelDetectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetLabelDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLabelDetection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetLabelDetection">REST API Reference for GetLabelDetection Operation</seealso>
        public virtual Task<GetLabelDetectionResponse> GetLabelDetectionAsync(GetLabelDetectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLabelDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLabelDetectionResponseUnmarshaller.Instance;

            return InvokeAsync<GetLabelDetectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPersonTracking

        internal virtual GetPersonTrackingResponse GetPersonTracking(GetPersonTrackingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPersonTrackingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPersonTrackingResponseUnmarshaller.Instance;

            return Invoke<GetPersonTrackingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetPersonTracking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPersonTracking operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetPersonTracking">REST API Reference for GetPersonTracking Operation</seealso>
        public virtual Task<GetPersonTrackingResponse> GetPersonTrackingAsync(GetPersonTrackingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPersonTrackingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPersonTrackingResponseUnmarshaller.Instance;

            return InvokeAsync<GetPersonTrackingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  IndexFaces

        internal virtual IndexFacesResponse IndexFaces(IndexFacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IndexFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IndexFacesResponseUnmarshaller.Instance;

            return Invoke<IndexFacesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the IndexFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IndexFaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/IndexFaces">REST API Reference for IndexFaces Operation</seealso>
        public virtual Task<IndexFacesResponse> IndexFacesAsync(IndexFacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = IndexFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IndexFacesResponseUnmarshaller.Instance;

            return InvokeAsync<IndexFacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCollections

        internal virtual ListCollectionsResponse ListCollections(ListCollectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollectionsResponseUnmarshaller.Instance;

            return Invoke<ListCollectionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListCollections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCollections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListCollections">REST API Reference for ListCollections Operation</seealso>
        public virtual Task<ListCollectionsResponse> ListCollectionsAsync(ListCollectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCollectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCollectionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCollectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFaces

        internal virtual ListFacesResponse ListFaces(ListFacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFacesResponseUnmarshaller.Instance;

            return Invoke<ListFacesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListFaces">REST API Reference for ListFaces Operation</seealso>
        public virtual Task<ListFacesResponse> ListFacesAsync(ListFacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFacesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListStreamProcessors

        internal virtual ListStreamProcessorsResponse ListStreamProcessors(ListStreamProcessorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamProcessorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamProcessorsResponseUnmarshaller.Instance;

            return Invoke<ListStreamProcessorsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListStreamProcessors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreamProcessors operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListStreamProcessors">REST API Reference for ListStreamProcessors Operation</seealso>
        public virtual Task<ListStreamProcessorsResponse> ListStreamProcessorsAsync(ListStreamProcessorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStreamProcessorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamProcessorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStreamProcessorsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RecognizeCelebrities

        internal virtual RecognizeCelebritiesResponse RecognizeCelebrities(RecognizeCelebritiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RecognizeCelebritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecognizeCelebritiesResponseUnmarshaller.Instance;

            return Invoke<RecognizeCelebritiesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RecognizeCelebrities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecognizeCelebrities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/RecognizeCelebrities">REST API Reference for RecognizeCelebrities Operation</seealso>
        public virtual Task<RecognizeCelebritiesResponse> RecognizeCelebritiesAsync(RecognizeCelebritiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RecognizeCelebritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RecognizeCelebritiesResponseUnmarshaller.Instance;

            return InvokeAsync<RecognizeCelebritiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchFaces

        internal virtual SearchFacesResponse SearchFaces(SearchFacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFacesResponseUnmarshaller.Instance;

            return Invoke<SearchFacesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SearchFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchFaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchFaces">REST API Reference for SearchFaces Operation</seealso>
        public virtual Task<SearchFacesResponse> SearchFacesAsync(SearchFacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchFacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFacesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchFacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchFacesByImage

        internal virtual SearchFacesByImageResponse SearchFacesByImage(SearchFacesByImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchFacesByImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFacesByImageResponseUnmarshaller.Instance;

            return Invoke<SearchFacesByImageResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SearchFacesByImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchFacesByImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchFacesByImage">REST API Reference for SearchFacesByImage Operation</seealso>
        public virtual Task<SearchFacesByImageResponse> SearchFacesByImageAsync(SearchFacesByImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchFacesByImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchFacesByImageResponseUnmarshaller.Instance;

            return InvokeAsync<SearchFacesByImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartCelebrityRecognition

        internal virtual StartCelebrityRecognitionResponse StartCelebrityRecognition(StartCelebrityRecognitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCelebrityRecognitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCelebrityRecognitionResponseUnmarshaller.Instance;

            return Invoke<StartCelebrityRecognitionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartCelebrityRecognition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCelebrityRecognition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartCelebrityRecognition">REST API Reference for StartCelebrityRecognition Operation</seealso>
        public virtual Task<StartCelebrityRecognitionResponse> StartCelebrityRecognitionAsync(StartCelebrityRecognitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartCelebrityRecognitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartCelebrityRecognitionResponseUnmarshaller.Instance;

            return InvokeAsync<StartCelebrityRecognitionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartContentModeration

        internal virtual StartContentModerationResponse StartContentModeration(StartContentModerationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartContentModerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartContentModerationResponseUnmarshaller.Instance;

            return Invoke<StartContentModerationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartContentModeration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartContentModeration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartContentModeration">REST API Reference for StartContentModeration Operation</seealso>
        public virtual Task<StartContentModerationResponse> StartContentModerationAsync(StartContentModerationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartContentModerationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartContentModerationResponseUnmarshaller.Instance;

            return InvokeAsync<StartContentModerationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartFaceDetection

        internal virtual StartFaceDetectionResponse StartFaceDetection(StartFaceDetectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFaceDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFaceDetectionResponseUnmarshaller.Instance;

            return Invoke<StartFaceDetectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartFaceDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFaceDetection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartFaceDetection">REST API Reference for StartFaceDetection Operation</seealso>
        public virtual Task<StartFaceDetectionResponse> StartFaceDetectionAsync(StartFaceDetectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFaceDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFaceDetectionResponseUnmarshaller.Instance;

            return InvokeAsync<StartFaceDetectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartFaceSearch

        internal virtual StartFaceSearchResponse StartFaceSearch(StartFaceSearchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFaceSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFaceSearchResponseUnmarshaller.Instance;

            return Invoke<StartFaceSearchResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartFaceSearch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFaceSearch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartFaceSearch">REST API Reference for StartFaceSearch Operation</seealso>
        public virtual Task<StartFaceSearchResponse> StartFaceSearchAsync(StartFaceSearchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFaceSearchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFaceSearchResponseUnmarshaller.Instance;

            return InvokeAsync<StartFaceSearchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartLabelDetection

        internal virtual StartLabelDetectionResponse StartLabelDetection(StartLabelDetectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartLabelDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLabelDetectionResponseUnmarshaller.Instance;

            return Invoke<StartLabelDetectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartLabelDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartLabelDetection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartLabelDetection">REST API Reference for StartLabelDetection Operation</seealso>
        public virtual Task<StartLabelDetectionResponse> StartLabelDetectionAsync(StartLabelDetectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartLabelDetectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLabelDetectionResponseUnmarshaller.Instance;

            return InvokeAsync<StartLabelDetectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartPersonTracking

        internal virtual StartPersonTrackingResponse StartPersonTracking(StartPersonTrackingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPersonTrackingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPersonTrackingResponseUnmarshaller.Instance;

            return Invoke<StartPersonTrackingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartPersonTracking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPersonTracking operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartPersonTracking">REST API Reference for StartPersonTracking Operation</seealso>
        public virtual Task<StartPersonTrackingResponse> StartPersonTrackingAsync(StartPersonTrackingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPersonTrackingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPersonTrackingResponseUnmarshaller.Instance;

            return InvokeAsync<StartPersonTrackingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartStreamProcessor

        internal virtual StartStreamProcessorResponse StartStreamProcessor(StartStreamProcessorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartStreamProcessorResponseUnmarshaller.Instance;

            return Invoke<StartStreamProcessorResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartStreamProcessor operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartStreamProcessor">REST API Reference for StartStreamProcessor Operation</seealso>
        public virtual Task<StartStreamProcessorResponse> StartStreamProcessorAsync(StartStreamProcessorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartStreamProcessorResponseUnmarshaller.Instance;

            return InvokeAsync<StartStreamProcessorResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopStreamProcessor

        internal virtual StopStreamProcessorResponse StopStreamProcessor(StopStreamProcessorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStreamProcessorResponseUnmarshaller.Instance;

            return Invoke<StopStreamProcessorResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopStreamProcessor operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StopStreamProcessor">REST API Reference for StopStreamProcessor Operation</seealso>
        public virtual Task<StopStreamProcessorResponse> StopStreamProcessorAsync(StopStreamProcessorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopStreamProcessorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopStreamProcessorResponseUnmarshaller.Instance;

            return InvokeAsync<StopStreamProcessorResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}