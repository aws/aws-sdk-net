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

using Amazon.Rekognition.Model;
using Amazon.Rekognition.Model.Internal.MarshallTransformations;
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
            var marshaller = CompareFacesRequestMarshaller.Instance;
            var unmarshaller = CompareFacesResponseUnmarshaller.Instance;

            return Invoke<CompareFacesRequest,CompareFacesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CompareFacesRequestMarshaller.Instance;
            var unmarshaller = CompareFacesResponseUnmarshaller.Instance;

            return InvokeAsync<CompareFacesRequest,CompareFacesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateCollection

        internal virtual CreateCollectionResponse CreateCollection(CreateCollectionRequest request)
        {
            var marshaller = CreateCollectionRequestMarshaller.Instance;
            var unmarshaller = CreateCollectionResponseUnmarshaller.Instance;

            return Invoke<CreateCollectionRequest,CreateCollectionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateCollectionRequestMarshaller.Instance;
            var unmarshaller = CreateCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCollectionRequest,CreateCollectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateStreamProcessor

        internal virtual CreateStreamProcessorResponse CreateStreamProcessor(CreateStreamProcessorRequest request)
        {
            var marshaller = CreateStreamProcessorRequestMarshaller.Instance;
            var unmarshaller = CreateStreamProcessorResponseUnmarshaller.Instance;

            return Invoke<CreateStreamProcessorRequest,CreateStreamProcessorResponse>(request, marshaller, unmarshaller);
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
            var marshaller = CreateStreamProcessorRequestMarshaller.Instance;
            var unmarshaller = CreateStreamProcessorResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStreamProcessorRequest,CreateStreamProcessorResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCollection

        internal virtual DeleteCollectionResponse DeleteCollection(DeleteCollectionRequest request)
        {
            var marshaller = DeleteCollectionRequestMarshaller.Instance;
            var unmarshaller = DeleteCollectionResponseUnmarshaller.Instance;

            return Invoke<DeleteCollectionRequest,DeleteCollectionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteCollectionRequestMarshaller.Instance;
            var unmarshaller = DeleteCollectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCollectionRequest,DeleteCollectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteFaces

        internal virtual DeleteFacesResponse DeleteFaces(DeleteFacesRequest request)
        {
            var marshaller = DeleteFacesRequestMarshaller.Instance;
            var unmarshaller = DeleteFacesResponseUnmarshaller.Instance;

            return Invoke<DeleteFacesRequest,DeleteFacesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteFacesRequestMarshaller.Instance;
            var unmarshaller = DeleteFacesResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFacesRequest,DeleteFacesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteStreamProcessor

        internal virtual DeleteStreamProcessorResponse DeleteStreamProcessor(DeleteStreamProcessorRequest request)
        {
            var marshaller = DeleteStreamProcessorRequestMarshaller.Instance;
            var unmarshaller = DeleteStreamProcessorResponseUnmarshaller.Instance;

            return Invoke<DeleteStreamProcessorRequest,DeleteStreamProcessorResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DeleteStreamProcessorRequestMarshaller.Instance;
            var unmarshaller = DeleteStreamProcessorResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStreamProcessorRequest,DeleteStreamProcessorResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStreamProcessor

        internal virtual DescribeStreamProcessorResponse DescribeStreamProcessor(DescribeStreamProcessorRequest request)
        {
            var marshaller = DescribeStreamProcessorRequestMarshaller.Instance;
            var unmarshaller = DescribeStreamProcessorResponseUnmarshaller.Instance;

            return Invoke<DescribeStreamProcessorRequest,DescribeStreamProcessorResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeStreamProcessorRequestMarshaller.Instance;
            var unmarshaller = DescribeStreamProcessorResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStreamProcessorRequest,DescribeStreamProcessorResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetectFaces

        internal virtual DetectFacesResponse DetectFaces(DetectFacesRequest request)
        {
            var marshaller = DetectFacesRequestMarshaller.Instance;
            var unmarshaller = DetectFacesResponseUnmarshaller.Instance;

            return Invoke<DetectFacesRequest,DetectFacesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DetectFacesRequestMarshaller.Instance;
            var unmarshaller = DetectFacesResponseUnmarshaller.Instance;

            return InvokeAsync<DetectFacesRequest,DetectFacesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetectLabels

        internal virtual DetectLabelsResponse DetectLabels(DetectLabelsRequest request)
        {
            var marshaller = DetectLabelsRequestMarshaller.Instance;
            var unmarshaller = DetectLabelsResponseUnmarshaller.Instance;

            return Invoke<DetectLabelsRequest,DetectLabelsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DetectLabelsRequestMarshaller.Instance;
            var unmarshaller = DetectLabelsResponseUnmarshaller.Instance;

            return InvokeAsync<DetectLabelsRequest,DetectLabelsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetectModerationLabels

        internal virtual DetectModerationLabelsResponse DetectModerationLabels(DetectModerationLabelsRequest request)
        {
            var marshaller = DetectModerationLabelsRequestMarshaller.Instance;
            var unmarshaller = DetectModerationLabelsResponseUnmarshaller.Instance;

            return Invoke<DetectModerationLabelsRequest,DetectModerationLabelsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DetectModerationLabelsRequestMarshaller.Instance;
            var unmarshaller = DetectModerationLabelsResponseUnmarshaller.Instance;

            return InvokeAsync<DetectModerationLabelsRequest,DetectModerationLabelsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetectText

        internal virtual DetectTextResponse DetectText(DetectTextRequest request)
        {
            var marshaller = DetectTextRequestMarshaller.Instance;
            var unmarshaller = DetectTextResponseUnmarshaller.Instance;

            return Invoke<DetectTextRequest,DetectTextResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DetectTextRequestMarshaller.Instance;
            var unmarshaller = DetectTextResponseUnmarshaller.Instance;

            return InvokeAsync<DetectTextRequest,DetectTextResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCelebrityInfo

        internal virtual GetCelebrityInfoResponse GetCelebrityInfo(GetCelebrityInfoRequest request)
        {
            var marshaller = GetCelebrityInfoRequestMarshaller.Instance;
            var unmarshaller = GetCelebrityInfoResponseUnmarshaller.Instance;

            return Invoke<GetCelebrityInfoRequest,GetCelebrityInfoResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetCelebrityInfoRequestMarshaller.Instance;
            var unmarshaller = GetCelebrityInfoResponseUnmarshaller.Instance;

            return InvokeAsync<GetCelebrityInfoRequest,GetCelebrityInfoResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCelebrityRecognition

        internal virtual GetCelebrityRecognitionResponse GetCelebrityRecognition(GetCelebrityRecognitionRequest request)
        {
            var marshaller = GetCelebrityRecognitionRequestMarshaller.Instance;
            var unmarshaller = GetCelebrityRecognitionResponseUnmarshaller.Instance;

            return Invoke<GetCelebrityRecognitionRequest,GetCelebrityRecognitionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetCelebrityRecognitionRequestMarshaller.Instance;
            var unmarshaller = GetCelebrityRecognitionResponseUnmarshaller.Instance;

            return InvokeAsync<GetCelebrityRecognitionRequest,GetCelebrityRecognitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetContentModeration

        internal virtual GetContentModerationResponse GetContentModeration(GetContentModerationRequest request)
        {
            var marshaller = GetContentModerationRequestMarshaller.Instance;
            var unmarshaller = GetContentModerationResponseUnmarshaller.Instance;

            return Invoke<GetContentModerationRequest,GetContentModerationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetContentModerationRequestMarshaller.Instance;
            var unmarshaller = GetContentModerationResponseUnmarshaller.Instance;

            return InvokeAsync<GetContentModerationRequest,GetContentModerationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetFaceDetection

        internal virtual GetFaceDetectionResponse GetFaceDetection(GetFaceDetectionRequest request)
        {
            var marshaller = GetFaceDetectionRequestMarshaller.Instance;
            var unmarshaller = GetFaceDetectionResponseUnmarshaller.Instance;

            return Invoke<GetFaceDetectionRequest,GetFaceDetectionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetFaceDetectionRequestMarshaller.Instance;
            var unmarshaller = GetFaceDetectionResponseUnmarshaller.Instance;

            return InvokeAsync<GetFaceDetectionRequest,GetFaceDetectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetFaceSearch

        internal virtual GetFaceSearchResponse GetFaceSearch(GetFaceSearchRequest request)
        {
            var marshaller = GetFaceSearchRequestMarshaller.Instance;
            var unmarshaller = GetFaceSearchResponseUnmarshaller.Instance;

            return Invoke<GetFaceSearchRequest,GetFaceSearchResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetFaceSearchRequestMarshaller.Instance;
            var unmarshaller = GetFaceSearchResponseUnmarshaller.Instance;

            return InvokeAsync<GetFaceSearchRequest,GetFaceSearchResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetLabelDetection

        internal virtual GetLabelDetectionResponse GetLabelDetection(GetLabelDetectionRequest request)
        {
            var marshaller = GetLabelDetectionRequestMarshaller.Instance;
            var unmarshaller = GetLabelDetectionResponseUnmarshaller.Instance;

            return Invoke<GetLabelDetectionRequest,GetLabelDetectionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetLabelDetectionRequestMarshaller.Instance;
            var unmarshaller = GetLabelDetectionResponseUnmarshaller.Instance;

            return InvokeAsync<GetLabelDetectionRequest,GetLabelDetectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPersonTracking

        internal virtual GetPersonTrackingResponse GetPersonTracking(GetPersonTrackingRequest request)
        {
            var marshaller = GetPersonTrackingRequestMarshaller.Instance;
            var unmarshaller = GetPersonTrackingResponseUnmarshaller.Instance;

            return Invoke<GetPersonTrackingRequest,GetPersonTrackingResponse>(request, marshaller, unmarshaller);
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
            var marshaller = GetPersonTrackingRequestMarshaller.Instance;
            var unmarshaller = GetPersonTrackingResponseUnmarshaller.Instance;

            return InvokeAsync<GetPersonTrackingRequest,GetPersonTrackingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  IndexFaces

        internal virtual IndexFacesResponse IndexFaces(IndexFacesRequest request)
        {
            var marshaller = IndexFacesRequestMarshaller.Instance;
            var unmarshaller = IndexFacesResponseUnmarshaller.Instance;

            return Invoke<IndexFacesRequest,IndexFacesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = IndexFacesRequestMarshaller.Instance;
            var unmarshaller = IndexFacesResponseUnmarshaller.Instance;

            return InvokeAsync<IndexFacesRequest,IndexFacesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListCollections

        internal virtual ListCollectionsResponse ListCollections(ListCollectionsRequest request)
        {
            var marshaller = ListCollectionsRequestMarshaller.Instance;
            var unmarshaller = ListCollectionsResponseUnmarshaller.Instance;

            return Invoke<ListCollectionsRequest,ListCollectionsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListCollectionsRequestMarshaller.Instance;
            var unmarshaller = ListCollectionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCollectionsRequest,ListCollectionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListFaces

        internal virtual ListFacesResponse ListFaces(ListFacesRequest request)
        {
            var marshaller = ListFacesRequestMarshaller.Instance;
            var unmarshaller = ListFacesResponseUnmarshaller.Instance;

            return Invoke<ListFacesRequest,ListFacesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListFacesRequestMarshaller.Instance;
            var unmarshaller = ListFacesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFacesRequest,ListFacesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListStreamProcessors

        internal virtual ListStreamProcessorsResponse ListStreamProcessors(ListStreamProcessorsRequest request)
        {
            var marshaller = ListStreamProcessorsRequestMarshaller.Instance;
            var unmarshaller = ListStreamProcessorsResponseUnmarshaller.Instance;

            return Invoke<ListStreamProcessorsRequest,ListStreamProcessorsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListStreamProcessorsRequestMarshaller.Instance;
            var unmarshaller = ListStreamProcessorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStreamProcessorsRequest,ListStreamProcessorsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RecognizeCelebrities

        internal virtual RecognizeCelebritiesResponse RecognizeCelebrities(RecognizeCelebritiesRequest request)
        {
            var marshaller = RecognizeCelebritiesRequestMarshaller.Instance;
            var unmarshaller = RecognizeCelebritiesResponseUnmarshaller.Instance;

            return Invoke<RecognizeCelebritiesRequest,RecognizeCelebritiesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = RecognizeCelebritiesRequestMarshaller.Instance;
            var unmarshaller = RecognizeCelebritiesResponseUnmarshaller.Instance;

            return InvokeAsync<RecognizeCelebritiesRequest,RecognizeCelebritiesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SearchFaces

        internal virtual SearchFacesResponse SearchFaces(SearchFacesRequest request)
        {
            var marshaller = SearchFacesRequestMarshaller.Instance;
            var unmarshaller = SearchFacesResponseUnmarshaller.Instance;

            return Invoke<SearchFacesRequest,SearchFacesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = SearchFacesRequestMarshaller.Instance;
            var unmarshaller = SearchFacesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchFacesRequest,SearchFacesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SearchFacesByImage

        internal virtual SearchFacesByImageResponse SearchFacesByImage(SearchFacesByImageRequest request)
        {
            var marshaller = SearchFacesByImageRequestMarshaller.Instance;
            var unmarshaller = SearchFacesByImageResponseUnmarshaller.Instance;

            return Invoke<SearchFacesByImageRequest,SearchFacesByImageResponse>(request, marshaller, unmarshaller);
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
            var marshaller = SearchFacesByImageRequestMarshaller.Instance;
            var unmarshaller = SearchFacesByImageResponseUnmarshaller.Instance;

            return InvokeAsync<SearchFacesByImageRequest,SearchFacesByImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartCelebrityRecognition

        internal virtual StartCelebrityRecognitionResponse StartCelebrityRecognition(StartCelebrityRecognitionRequest request)
        {
            var marshaller = StartCelebrityRecognitionRequestMarshaller.Instance;
            var unmarshaller = StartCelebrityRecognitionResponseUnmarshaller.Instance;

            return Invoke<StartCelebrityRecognitionRequest,StartCelebrityRecognitionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StartCelebrityRecognitionRequestMarshaller.Instance;
            var unmarshaller = StartCelebrityRecognitionResponseUnmarshaller.Instance;

            return InvokeAsync<StartCelebrityRecognitionRequest,StartCelebrityRecognitionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartContentModeration

        internal virtual StartContentModerationResponse StartContentModeration(StartContentModerationRequest request)
        {
            var marshaller = StartContentModerationRequestMarshaller.Instance;
            var unmarshaller = StartContentModerationResponseUnmarshaller.Instance;

            return Invoke<StartContentModerationRequest,StartContentModerationResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StartContentModerationRequestMarshaller.Instance;
            var unmarshaller = StartContentModerationResponseUnmarshaller.Instance;

            return InvokeAsync<StartContentModerationRequest,StartContentModerationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartFaceDetection

        internal virtual StartFaceDetectionResponse StartFaceDetection(StartFaceDetectionRequest request)
        {
            var marshaller = StartFaceDetectionRequestMarshaller.Instance;
            var unmarshaller = StartFaceDetectionResponseUnmarshaller.Instance;

            return Invoke<StartFaceDetectionRequest,StartFaceDetectionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StartFaceDetectionRequestMarshaller.Instance;
            var unmarshaller = StartFaceDetectionResponseUnmarshaller.Instance;

            return InvokeAsync<StartFaceDetectionRequest,StartFaceDetectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartFaceSearch

        internal virtual StartFaceSearchResponse StartFaceSearch(StartFaceSearchRequest request)
        {
            var marshaller = StartFaceSearchRequestMarshaller.Instance;
            var unmarshaller = StartFaceSearchResponseUnmarshaller.Instance;

            return Invoke<StartFaceSearchRequest,StartFaceSearchResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StartFaceSearchRequestMarshaller.Instance;
            var unmarshaller = StartFaceSearchResponseUnmarshaller.Instance;

            return InvokeAsync<StartFaceSearchRequest,StartFaceSearchResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartLabelDetection

        internal virtual StartLabelDetectionResponse StartLabelDetection(StartLabelDetectionRequest request)
        {
            var marshaller = StartLabelDetectionRequestMarshaller.Instance;
            var unmarshaller = StartLabelDetectionResponseUnmarshaller.Instance;

            return Invoke<StartLabelDetectionRequest,StartLabelDetectionResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StartLabelDetectionRequestMarshaller.Instance;
            var unmarshaller = StartLabelDetectionResponseUnmarshaller.Instance;

            return InvokeAsync<StartLabelDetectionRequest,StartLabelDetectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartPersonTracking

        internal virtual StartPersonTrackingResponse StartPersonTracking(StartPersonTrackingRequest request)
        {
            var marshaller = StartPersonTrackingRequestMarshaller.Instance;
            var unmarshaller = StartPersonTrackingResponseUnmarshaller.Instance;

            return Invoke<StartPersonTrackingRequest,StartPersonTrackingResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StartPersonTrackingRequestMarshaller.Instance;
            var unmarshaller = StartPersonTrackingResponseUnmarshaller.Instance;

            return InvokeAsync<StartPersonTrackingRequest,StartPersonTrackingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartStreamProcessor

        internal virtual StartStreamProcessorResponse StartStreamProcessor(StartStreamProcessorRequest request)
        {
            var marshaller = StartStreamProcessorRequestMarshaller.Instance;
            var unmarshaller = StartStreamProcessorResponseUnmarshaller.Instance;

            return Invoke<StartStreamProcessorRequest,StartStreamProcessorResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StartStreamProcessorRequestMarshaller.Instance;
            var unmarshaller = StartStreamProcessorResponseUnmarshaller.Instance;

            return InvokeAsync<StartStreamProcessorRequest,StartStreamProcessorResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopStreamProcessor

        internal virtual StopStreamProcessorResponse StopStreamProcessor(StopStreamProcessorRequest request)
        {
            var marshaller = StopStreamProcessorRequestMarshaller.Instance;
            var unmarshaller = StopStreamProcessorResponseUnmarshaller.Instance;

            return Invoke<StopStreamProcessorRequest,StopStreamProcessorResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StopStreamProcessorRequestMarshaller.Instance;
            var unmarshaller = StopStreamProcessorResponseUnmarshaller.Instance;

            return InvokeAsync<StopStreamProcessorRequest,StopStreamProcessorResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}