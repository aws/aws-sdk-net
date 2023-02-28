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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Comprehend.Model;
using Amazon.Comprehend.Model.Internal.MarshallTransformations;
using Amazon.Comprehend.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Comprehend
{
    /// <summary>
    /// Implementation for accessing Comprehend
    ///
    /// Amazon Comprehend is an AWS service for gaining insight into the content of documents.
    /// Use these actions to determine the topics contained in your documents, the topics
    /// they discuss, the predominant sentiment expressed in them, the predominant language
    /// used, and more.
    /// </summary>
    public partial class AmazonComprehendClient : AmazonServiceClient, IAmazonComprehend
    {
        private static IServiceMetadata serviceMetadata = new AmazonComprehendMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonComprehendClient with the credentials loaded from the application's
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
        public AmazonComprehendClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonComprehendConfig()) { }

        /// <summary>
        /// Constructs AmazonComprehendClient with the credentials loaded from the application's
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
        public AmazonComprehendClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonComprehendConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonComprehendClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonComprehendClient Configuration Object</param>
        public AmazonComprehendClient(AmazonComprehendConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonComprehendClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonComprehendClient(AWSCredentials credentials)
            : this(credentials, new AmazonComprehendConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonComprehendClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonComprehendConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendClient with AWS Credentials and an
        /// AmazonComprehendClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonComprehendClient Configuration Object</param>
        public AmazonComprehendClient(AWSCredentials credentials, AmazonComprehendConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonComprehendClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonComprehendConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonComprehendClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonComprehendConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonComprehendClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonComprehendClient Configuration Object</param>
        public AmazonComprehendClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonComprehendConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonComprehendClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonComprehendConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonComprehendClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonComprehendConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonComprehendClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonComprehendClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonComprehendClient Configuration Object</param>
        public AmazonComprehendClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonComprehendConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IComprehendPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IComprehendPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ComprehendPaginatorFactory(this);
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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonComprehendEndpointResolver());
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


        #region  BatchDetectDominantLanguage

        internal virtual BatchDetectDominantLanguageResponse BatchDetectDominantLanguage(BatchDetectDominantLanguageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectDominantLanguageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectDominantLanguageResponseUnmarshaller.Instance;

            return Invoke<BatchDetectDominantLanguageResponse>(request, options);
        }



        /// <summary>
        /// Determines the dominant language of the input text for a batch of documents. For a
        /// list of languages that Amazon Comprehend can detect, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-languages.html">Amazon
        /// Comprehend Supported Languages</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectDominantLanguage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDetectDominantLanguage service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.BatchSizeLimitExceededException">
        /// The number of documents in the request exceeds the limit of 25. Try your request again
        /// with fewer documents.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TextSizeLimitExceededException">
        /// The size of the input text exceeds the limit. Use a smaller document.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectDominantLanguage">REST API Reference for BatchDetectDominantLanguage Operation</seealso>
        public virtual Task<BatchDetectDominantLanguageResponse> BatchDetectDominantLanguageAsync(BatchDetectDominantLanguageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectDominantLanguageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectDominantLanguageResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDetectDominantLanguageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDetectEntities

        internal virtual BatchDetectEntitiesResponse BatchDetectEntities(BatchDetectEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectEntitiesResponseUnmarshaller.Instance;

            return Invoke<BatchDetectEntitiesResponse>(request, options);
        }



        /// <summary>
        /// Inspects the text of a batch of documents for named entities and returns information
        /// about them. For more information about named entities, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-entities.html">Entities</a>
        /// in the Comprehend Developer Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDetectEntities service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.BatchSizeLimitExceededException">
        /// The number of documents in the request exceeds the limit of 25. Try your request again
        /// with fewer documents.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TextSizeLimitExceededException">
        /// The size of the input text exceeds the limit. Use a smaller document.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.UnsupportedLanguageException">
        /// Amazon Comprehend can't process the language of the input text. For custom entity
        /// recognition APIs, only English, Spanish, French, Italian, German, or Portuguese are
        /// accepted. For a list of supported languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectEntities">REST API Reference for BatchDetectEntities Operation</seealso>
        public virtual Task<BatchDetectEntitiesResponse> BatchDetectEntitiesAsync(BatchDetectEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectEntitiesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDetectEntitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDetectKeyPhrases

        internal virtual BatchDetectKeyPhrasesResponse BatchDetectKeyPhrases(BatchDetectKeyPhrasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectKeyPhrasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectKeyPhrasesResponseUnmarshaller.Instance;

            return Invoke<BatchDetectKeyPhrasesResponse>(request, options);
        }



        /// <summary>
        /// Detects the key noun phrases found in a batch of documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectKeyPhrases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDetectKeyPhrases service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.BatchSizeLimitExceededException">
        /// The number of documents in the request exceeds the limit of 25. Try your request again
        /// with fewer documents.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TextSizeLimitExceededException">
        /// The size of the input text exceeds the limit. Use a smaller document.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.UnsupportedLanguageException">
        /// Amazon Comprehend can't process the language of the input text. For custom entity
        /// recognition APIs, only English, Spanish, French, Italian, German, or Portuguese are
        /// accepted. For a list of supported languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectKeyPhrases">REST API Reference for BatchDetectKeyPhrases Operation</seealso>
        public virtual Task<BatchDetectKeyPhrasesResponse> BatchDetectKeyPhrasesAsync(BatchDetectKeyPhrasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectKeyPhrasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectKeyPhrasesResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDetectKeyPhrasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDetectSentiment

        internal virtual BatchDetectSentimentResponse BatchDetectSentiment(BatchDetectSentimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectSentimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectSentimentResponseUnmarshaller.Instance;

            return Invoke<BatchDetectSentimentResponse>(request, options);
        }



        /// <summary>
        /// Inspects a batch of documents and returns an inference of the prevailing sentiment,
        /// <code>POSITIVE</code>, <code>NEUTRAL</code>, <code>MIXED</code>, or <code>NEGATIVE</code>,
        /// in each one.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectSentiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDetectSentiment service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.BatchSizeLimitExceededException">
        /// The number of documents in the request exceeds the limit of 25. Try your request again
        /// with fewer documents.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TextSizeLimitExceededException">
        /// The size of the input text exceeds the limit. Use a smaller document.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.UnsupportedLanguageException">
        /// Amazon Comprehend can't process the language of the input text. For custom entity
        /// recognition APIs, only English, Spanish, French, Italian, German, or Portuguese are
        /// accepted. For a list of supported languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectSentiment">REST API Reference for BatchDetectSentiment Operation</seealso>
        public virtual Task<BatchDetectSentimentResponse> BatchDetectSentimentAsync(BatchDetectSentimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectSentimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectSentimentResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDetectSentimentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDetectSyntax

        internal virtual BatchDetectSyntaxResponse BatchDetectSyntax(BatchDetectSyntaxRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectSyntaxRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectSyntaxResponseUnmarshaller.Instance;

            return Invoke<BatchDetectSyntaxResponse>(request, options);
        }



        /// <summary>
        /// Inspects the text of a batch of documents for the syntax and part of speech of the
        /// words in the document and returns information about them. For more information, see
        /// <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-syntax.html">Syntax</a>
        /// in the Comprehend Developer Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectSyntax service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDetectSyntax service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.BatchSizeLimitExceededException">
        /// The number of documents in the request exceeds the limit of 25. Try your request again
        /// with fewer documents.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TextSizeLimitExceededException">
        /// The size of the input text exceeds the limit. Use a smaller document.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.UnsupportedLanguageException">
        /// Amazon Comprehend can't process the language of the input text. For custom entity
        /// recognition APIs, only English, Spanish, French, Italian, German, or Portuguese are
        /// accepted. For a list of supported languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectSyntax">REST API Reference for BatchDetectSyntax Operation</seealso>
        public virtual Task<BatchDetectSyntaxResponse> BatchDetectSyntaxAsync(BatchDetectSyntaxRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectSyntaxRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectSyntaxResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDetectSyntaxResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchDetectTargetedSentiment

        internal virtual BatchDetectTargetedSentimentResponse BatchDetectTargetedSentiment(BatchDetectTargetedSentimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectTargetedSentimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectTargetedSentimentResponseUnmarshaller.Instance;

            return Invoke<BatchDetectTargetedSentimentResponse>(request, options);
        }



        /// <summary>
        /// Inspects a batch of documents and returns a sentiment analysis for each entity identified
        /// in the documents.
        /// 
        ///  
        /// <para>
        /// For more information about targeted sentiment, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-targeted-sentiment.html">Targeted
        /// sentiment</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectTargetedSentiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDetectTargetedSentiment service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.BatchSizeLimitExceededException">
        /// The number of documents in the request exceeds the limit of 25. Try your request again
        /// with fewer documents.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TextSizeLimitExceededException">
        /// The size of the input text exceeds the limit. Use a smaller document.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.UnsupportedLanguageException">
        /// Amazon Comprehend can't process the language of the input text. For custom entity
        /// recognition APIs, only English, Spanish, French, Italian, German, or Portuguese are
        /// accepted. For a list of supported languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectTargetedSentiment">REST API Reference for BatchDetectTargetedSentiment Operation</seealso>
        public virtual Task<BatchDetectTargetedSentimentResponse> BatchDetectTargetedSentimentAsync(BatchDetectTargetedSentimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectTargetedSentimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectTargetedSentimentResponseUnmarshaller.Instance;

            return InvokeAsync<BatchDetectTargetedSentimentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ClassifyDocument

        internal virtual ClassifyDocumentResponse ClassifyDocument(ClassifyDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ClassifyDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ClassifyDocumentResponseUnmarshaller.Instance;

            return Invoke<ClassifyDocumentResponse>(request, options);
        }



        /// <summary>
        /// Creates a new document classification request to analyze a single document in real-time,
        /// using a previously created and trained custom model and an endpoint.
        /// 
        ///  
        /// <para>
        /// You can input plain text or you can upload a single-page input document (text, PDF,
        /// Word, or image). 
        /// </para>
        ///  
        /// <para>
        /// If the system detects errors while processing a page in the input document, the API
        /// response includes an entry in <code>Errors</code> that describes the errors.
        /// </para>
        ///  
        /// <para>
        /// If the system detects a document-level error in your input document, the API returns
        /// an <code>InvalidRequestException</code> error response. For details about this exception,
        /// see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/idp-inputs-sync-err.html">
        /// Errors in semi-structured documents</a> in the Comprehend Developer Guide. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ClassifyDocument service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ClassifyDocument service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceUnavailableException">
        /// The specified resource is not available. Check the resource and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TextSizeLimitExceededException">
        /// The size of the input text exceeds the limit. Use a smaller document.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ClassifyDocument">REST API Reference for ClassifyDocument Operation</seealso>
        public virtual Task<ClassifyDocumentResponse> ClassifyDocumentAsync(ClassifyDocumentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ClassifyDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ClassifyDocumentResponseUnmarshaller.Instance;

            return InvokeAsync<ClassifyDocumentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ContainsPiiEntities

        internal virtual ContainsPiiEntitiesResponse ContainsPiiEntities(ContainsPiiEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ContainsPiiEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ContainsPiiEntitiesResponseUnmarshaller.Instance;

            return Invoke<ContainsPiiEntitiesResponse>(request, options);
        }



        /// <summary>
        /// Analyzes input text for the presence of personally identifiable information (PII)
        /// and returns the labels of identified PII entity types such as name, address, bank
        /// account number, or phone number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ContainsPiiEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ContainsPiiEntities service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TextSizeLimitExceededException">
        /// The size of the input text exceeds the limit. Use a smaller document.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.UnsupportedLanguageException">
        /// Amazon Comprehend can't process the language of the input text. For custom entity
        /// recognition APIs, only English, Spanish, French, Italian, German, or Portuguese are
        /// accepted. For a list of supported languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ContainsPiiEntities">REST API Reference for ContainsPiiEntities Operation</seealso>
        public virtual Task<ContainsPiiEntitiesResponse> ContainsPiiEntitiesAsync(ContainsPiiEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ContainsPiiEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ContainsPiiEntitiesResponseUnmarshaller.Instance;

            return InvokeAsync<ContainsPiiEntitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDataset

        internal virtual CreateDatasetResponse CreateDataset(CreateDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return Invoke<CreateDatasetResponse>(request, options);
        }



        /// <summary>
        /// Creates a dataset to upload training or test data for a model associated with a flywheel.
        /// For more information about datasets, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/flywheels-about.html">
        /// Flywheel overview</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataset service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceLimitExceededException">
        /// The maximum number of resources per account has been exceeded. Review the resources,
        /// and then try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        public virtual Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDocumentClassifier

        internal virtual CreateDocumentClassifierResponse CreateDocumentClassifier(CreateDocumentClassifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDocumentClassifierResponseUnmarshaller.Instance;

            return Invoke<CreateDocumentClassifierResponse>(request, options);
        }



        /// <summary>
        /// Creates a new document classifier that you can use to categorize documents. To create
        /// a classifier, you provide a set of training documents that labeled with the categories
        /// that you want to use. After the classifier is trained you can use it to categorize
        /// a set of labeled documents into the categories. For more information, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-document-classification.html">Document
        /// Classification</a> in the Comprehend Developer Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDocumentClassifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDocumentClassifier service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.KmsKeyValidationException">
        /// The KMS customer managed key (CMK) entered cannot be validated. Verify the key and
        /// re-enter it.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceLimitExceededException">
        /// The maximum number of resources per account has been exceeded. Review the resources,
        /// and then try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.UnsupportedLanguageException">
        /// Amazon Comprehend can't process the language of the input text. For custom entity
        /// recognition APIs, only English, Spanish, French, Italian, German, or Portuguese are
        /// accepted. For a list of supported languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateDocumentClassifier">REST API Reference for CreateDocumentClassifier Operation</seealso>
        public virtual Task<CreateDocumentClassifierResponse> CreateDocumentClassifierAsync(CreateDocumentClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDocumentClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDocumentClassifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEndpoint

        internal virtual CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateEndpointResponse>(request, options);
        }



        /// <summary>
        /// Creates a model-specific endpoint for synchronous inference for a previously trained
        /// custom model For information about endpoints, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/manage-endpoints.html">Managing
        /// endpoints</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEndpoint service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceLimitExceededException">
        /// The maximum number of resources per account has been exceeded. Review the resources,
        /// and then try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceUnavailableException">
        /// The specified resource is not available. Check the resource and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        public virtual Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEntityRecognizer

        internal virtual CreateEntityRecognizerResponse CreateEntityRecognizer(CreateEntityRecognizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEntityRecognizerResponseUnmarshaller.Instance;

            return Invoke<CreateEntityRecognizerResponse>(request, options);
        }



        /// <summary>
        /// Creates an entity recognizer using submitted files. After your <code>CreateEntityRecognizer</code>
        /// request is submitted, you can check job status using the <code>DescribeEntityRecognizer</code>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEntityRecognizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEntityRecognizer service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.KmsKeyValidationException">
        /// The KMS customer managed key (CMK) entered cannot be validated. Verify the key and
        /// re-enter it.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceLimitExceededException">
        /// The maximum number of resources per account has been exceeded. Review the resources,
        /// and then try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.UnsupportedLanguageException">
        /// Amazon Comprehend can't process the language of the input text. For custom entity
        /// recognition APIs, only English, Spanish, French, Italian, German, or Portuguese are
        /// accepted. For a list of supported languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateEntityRecognizer">REST API Reference for CreateEntityRecognizer Operation</seealso>
        public virtual Task<CreateEntityRecognizerResponse> CreateEntityRecognizerAsync(CreateEntityRecognizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEntityRecognizerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEntityRecognizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFlywheel

        internal virtual CreateFlywheelResponse CreateFlywheel(CreateFlywheelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFlywheelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlywheelResponseUnmarshaller.Instance;

            return Invoke<CreateFlywheelResponse>(request, options);
        }



        /// <summary>
        /// A flywheel is an AWS resource that orchestrates the ongoing training of a model for
        /// custom classification or custom entity recognition. You can create a flywheel to start
        /// with an existing trained model, or Comprehend can create and train a new model.
        /// 
        ///  
        /// <para>
        /// When you create the flywheel, Comprehend creates a data lake in your account. The
        /// data lake holds the training data and test data for all versions of the model.
        /// </para>
        ///  
        /// <para>
        /// To use a flywheel with an existing trained model, you specify the active model version.
        /// Comprehend copies the model's training data and test data into the flywheel's data
        /// lake.
        /// </para>
        ///  
        /// <para>
        /// To use the flywheel with a new model, you need to provide a dataset for training data
        /// (and optional test data) when you create the flywheel.
        /// </para>
        ///  
        /// <para>
        /// For more information about flywheels, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/flywheels-about.html">
        /// Flywheel overview</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlywheel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFlywheel service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.KmsKeyValidationException">
        /// The KMS customer managed key (CMK) entered cannot be validated. Verify the key and
        /// re-enter it.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceLimitExceededException">
        /// The maximum number of resources per account has been exceeded. Review the resources,
        /// and then try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceUnavailableException">
        /// The specified resource is not available. Check the resource and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.UnsupportedLanguageException">
        /// Amazon Comprehend can't process the language of the input text. For custom entity
        /// recognition APIs, only English, Spanish, French, Italian, German, or Portuguese are
        /// accepted. For a list of supported languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateFlywheel">REST API Reference for CreateFlywheel Operation</seealso>
        public virtual Task<CreateFlywheelResponse> CreateFlywheelAsync(CreateFlywheelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFlywheelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlywheelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFlywheelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDocumentClassifier

        internal virtual DeleteDocumentClassifierResponse DeleteDocumentClassifier(DeleteDocumentClassifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDocumentClassifierResponseUnmarshaller.Instance;

            return Invoke<DeleteDocumentClassifierResponse>(request, options);
        }



        /// <summary>
        /// Deletes a previously created document classifier
        /// 
        ///  
        /// <para>
        /// Only those classifiers that are in terminated states (IN_ERROR, TRAINED) will be deleted.
        /// If an active inference job is using the model, a <code>ResourceInUseException</code>
        /// will be returned.
        /// </para>
        ///  
        /// <para>
        /// This is an asynchronous action that puts the classifier into a DELETING state, and
        /// it is then removed by a background job. Once removed, the classifier disappears from
        /// your account and is no longer available for use. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocumentClassifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDocumentClassifier service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceUnavailableException">
        /// The specified resource is not available. Check the resource and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DeleteDocumentClassifier">REST API Reference for DeleteDocumentClassifier Operation</seealso>
        public virtual Task<DeleteDocumentClassifierResponse> DeleteDocumentClassifierAsync(DeleteDocumentClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDocumentClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDocumentClassifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEndpoint

        internal virtual DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointResponse>(request, options);
        }



        /// <summary>
        /// Deletes a model-specific endpoint for a previously-trained custom model. All endpoints
        /// must be deleted in order for the model to be deleted. For information about endpoints,
        /// see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/manage-endpoints.html">Managing
        /// endpoints</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        public virtual Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEntityRecognizer

        internal virtual DeleteEntityRecognizerResponse DeleteEntityRecognizer(DeleteEntityRecognizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEntityRecognizerResponseUnmarshaller.Instance;

            return Invoke<DeleteEntityRecognizerResponse>(request, options);
        }



        /// <summary>
        /// Deletes an entity recognizer.
        /// 
        ///  
        /// <para>
        /// Only those recognizers that are in terminated states (IN_ERROR, TRAINED) will be deleted.
        /// If an active inference job is using the model, a <code>ResourceInUseException</code>
        /// will be returned.
        /// </para>
        ///  
        /// <para>
        /// This is an asynchronous action that puts the recognizer into a DELETING state, and
        /// it is then removed by a background job. Once removed, the recognizer disappears from
        /// your account and is no longer available for use. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEntityRecognizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEntityRecognizer service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceUnavailableException">
        /// The specified resource is not available. Check the resource and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DeleteEntityRecognizer">REST API Reference for DeleteEntityRecognizer Operation</seealso>
        public virtual Task<DeleteEntityRecognizerResponse> DeleteEntityRecognizerAsync(DeleteEntityRecognizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEntityRecognizerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEntityRecognizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFlywheel

        internal virtual DeleteFlywheelResponse DeleteFlywheel(DeleteFlywheelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFlywheelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlywheelResponseUnmarshaller.Instance;

            return Invoke<DeleteFlywheelResponse>(request, options);
        }



        /// <summary>
        /// Deletes a flywheel. When you delete the flywheel, Amazon Comprehend does not delete
        /// the data lake or the model associated with the flywheel.
        /// 
        ///  
        /// <para>
        /// For more information about flywheels, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/flywheels-about.html">
        /// Flywheel overview</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlywheel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFlywheel service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceUnavailableException">
        /// The specified resource is not available. Check the resource and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DeleteFlywheel">REST API Reference for DeleteFlywheel Operation</seealso>
        public virtual Task<DeleteFlywheelResponse> DeleteFlywheelAsync(DeleteFlywheelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFlywheelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlywheelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFlywheelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResourcePolicy

        internal virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes a resource-based policy that is attached to a custom model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDataset

        internal virtual DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return Invoke<DescribeDatasetResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the dataset that you specify. For more information about
        /// datasets, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/flywheels-about.html">
        /// Flywheel overview</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDataset service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        public virtual Task<DescribeDatasetResponse> DescribeDatasetAsync(DescribeDatasetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDatasetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDatasetResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDatasetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDocumentClassificationJob

        internal virtual DescribeDocumentClassificationJobResponse DescribeDocumentClassificationJob(DescribeDocumentClassificationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDocumentClassificationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDocumentClassificationJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDocumentClassificationJobResponse>(request, options);
        }



        /// <summary>
        /// Gets the properties associated with a document classification job. Use this operation
        /// to get the status of a classification job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentClassificationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDocumentClassificationJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.JobNotFoundException">
        /// The specified job was not found. Check the job ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeDocumentClassificationJob">REST API Reference for DescribeDocumentClassificationJob Operation</seealso>
        public virtual Task<DescribeDocumentClassificationJobResponse> DescribeDocumentClassificationJobAsync(DescribeDocumentClassificationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDocumentClassificationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDocumentClassificationJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDocumentClassificationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDocumentClassifier

        internal virtual DescribeDocumentClassifierResponse DescribeDocumentClassifier(DescribeDocumentClassifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDocumentClassifierResponseUnmarshaller.Instance;

            return Invoke<DescribeDocumentClassifierResponse>(request, options);
        }



        /// <summary>
        /// Gets the properties associated with a document classifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentClassifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDocumentClassifier service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeDocumentClassifier">REST API Reference for DescribeDocumentClassifier Operation</seealso>
        public virtual Task<DescribeDocumentClassifierResponse> DescribeDocumentClassifierAsync(DescribeDocumentClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDocumentClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDocumentClassifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDominantLanguageDetectionJob

        internal virtual DescribeDominantLanguageDetectionJobResponse DescribeDominantLanguageDetectionJob(DescribeDominantLanguageDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDominantLanguageDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDominantLanguageDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Gets the properties associated with a dominant language detection job. Use this operation
        /// to get the status of a detection job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDominantLanguageDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDominantLanguageDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.JobNotFoundException">
        /// The specified job was not found. Check the job ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeDominantLanguageDetectionJob">REST API Reference for DescribeDominantLanguageDetectionJob Operation</seealso>
        public virtual Task<DescribeDominantLanguageDetectionJobResponse> DescribeDominantLanguageDetectionJobAsync(DescribeDominantLanguageDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDominantLanguageDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDominantLanguageDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEndpoint

        internal virtual DescribeEndpointResponse DescribeEndpoint(DescribeEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointResponse>(request, options);
        }



        /// <summary>
        /// Gets the properties associated with a specific endpoint. Use this operation to get
        /// the status of an endpoint. For information about endpoints, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/manage-endpoints.html">Managing
        /// endpoints</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEndpoint service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        public virtual Task<DescribeEndpointResponse> DescribeEndpointAsync(DescribeEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEntitiesDetectionJob

        internal virtual DescribeEntitiesDetectionJobResponse DescribeEntitiesDetectionJob(DescribeEntitiesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntitiesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeEntitiesDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Gets the properties associated with an entities detection job. Use this operation
        /// to get the status of a detection job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntitiesDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEntitiesDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.JobNotFoundException">
        /// The specified job was not found. Check the job ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeEntitiesDetectionJob">REST API Reference for DescribeEntitiesDetectionJob Operation</seealso>
        public virtual Task<DescribeEntitiesDetectionJobResponse> DescribeEntitiesDetectionJobAsync(DescribeEntitiesDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntitiesDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEntitiesDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEntityRecognizer

        internal virtual DescribeEntityRecognizerResponse DescribeEntityRecognizer(DescribeEntityRecognizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntityRecognizerResponseUnmarshaller.Instance;

            return Invoke<DescribeEntityRecognizerResponse>(request, options);
        }



        /// <summary>
        /// Provides details about an entity recognizer including status, S3 buckets containing
        /// training data, recognizer metadata, metrics, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntityRecognizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEntityRecognizer service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeEntityRecognizer">REST API Reference for DescribeEntityRecognizer Operation</seealso>
        public virtual Task<DescribeEntityRecognizerResponse> DescribeEntityRecognizerAsync(DescribeEntityRecognizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntityRecognizerResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEntityRecognizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventsDetectionJob

        internal virtual DescribeEventsDetectionJobResponse DescribeEventsDetectionJob(DescribeEventsDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Gets the status and details of an events detection job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventsDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventsDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.JobNotFoundException">
        /// The specified job was not found. Check the job ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeEventsDetectionJob">REST API Reference for DescribeEventsDetectionJob Operation</seealso>
        public virtual Task<DescribeEventsDetectionJobResponse> DescribeEventsDetectionJobAsync(DescribeEventsDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventsDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFlywheel

        internal virtual DescribeFlywheelResponse DescribeFlywheel(DescribeFlywheelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFlywheelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlywheelResponseUnmarshaller.Instance;

            return Invoke<DescribeFlywheelResponse>(request, options);
        }



        /// <summary>
        /// Provides configuration information about the flywheel. For more information about
        /// flywheels, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/flywheels-about.html">
        /// Flywheel overview</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlywheel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFlywheel service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeFlywheel">REST API Reference for DescribeFlywheel Operation</seealso>
        public virtual Task<DescribeFlywheelResponse> DescribeFlywheelAsync(DescribeFlywheelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFlywheelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlywheelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFlywheelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFlywheelIteration

        internal virtual DescribeFlywheelIterationResponse DescribeFlywheelIteration(DescribeFlywheelIterationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFlywheelIterationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlywheelIterationResponseUnmarshaller.Instance;

            return Invoke<DescribeFlywheelIterationResponse>(request, options);
        }



        /// <summary>
        /// Retrieve the configuration properties of a flywheel iteration. For more information
        /// about flywheels, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/flywheels-about.html">
        /// Flywheel overview</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlywheelIteration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFlywheelIteration service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeFlywheelIteration">REST API Reference for DescribeFlywheelIteration Operation</seealso>
        public virtual Task<DescribeFlywheelIterationResponse> DescribeFlywheelIterationAsync(DescribeFlywheelIterationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFlywheelIterationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlywheelIterationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFlywheelIterationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeKeyPhrasesDetectionJob

        internal virtual DescribeKeyPhrasesDetectionJobResponse DescribeKeyPhrasesDetectionJob(DescribeKeyPhrasesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeKeyPhrasesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeKeyPhrasesDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Gets the properties associated with a key phrases detection job. Use this operation
        /// to get the status of a detection job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyPhrasesDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKeyPhrasesDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.JobNotFoundException">
        /// The specified job was not found. Check the job ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeKeyPhrasesDetectionJob">REST API Reference for DescribeKeyPhrasesDetectionJob Operation</seealso>
        public virtual Task<DescribeKeyPhrasesDetectionJobResponse> DescribeKeyPhrasesDetectionJobAsync(DescribeKeyPhrasesDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeKeyPhrasesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeKeyPhrasesDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePiiEntitiesDetectionJob

        internal virtual DescribePiiEntitiesDetectionJobResponse DescribePiiEntitiesDetectionJob(DescribePiiEntitiesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePiiEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePiiEntitiesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribePiiEntitiesDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Gets the properties associated with a PII entities detection job. For example, you
        /// can use this operation to get the job status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePiiEntitiesDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePiiEntitiesDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.JobNotFoundException">
        /// The specified job was not found. Check the job ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribePiiEntitiesDetectionJob">REST API Reference for DescribePiiEntitiesDetectionJob Operation</seealso>
        public virtual Task<DescribePiiEntitiesDetectionJobResponse> DescribePiiEntitiesDetectionJobAsync(DescribePiiEntitiesDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePiiEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePiiEntitiesDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePiiEntitiesDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeResourcePolicy

        internal virtual DescribeResourcePolicyResponse DescribeResourcePolicy(DescribeResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DescribeResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Gets the details of a resource-based policy that is attached to a custom model, including
        /// the JSON body of the policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeResourcePolicy service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeResourcePolicy">REST API Reference for DescribeResourcePolicy Operation</seealso>
        public virtual Task<DescribeResourcePolicyResponse> DescribeResourcePolicyAsync(DescribeResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSentimentDetectionJob

        internal virtual DescribeSentimentDetectionJobResponse DescribeSentimentDetectionJob(DescribeSentimentDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSentimentDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeSentimentDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Gets the properties associated with a sentiment detection job. Use this operation
        /// to get the status of a detection job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSentimentDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSentimentDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.JobNotFoundException">
        /// The specified job was not found. Check the job ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeSentimentDetectionJob">REST API Reference for DescribeSentimentDetectionJob Operation</seealso>
        public virtual Task<DescribeSentimentDetectionJobResponse> DescribeSentimentDetectionJobAsync(DescribeSentimentDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSentimentDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSentimentDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTargetedSentimentDetectionJob

        internal virtual DescribeTargetedSentimentDetectionJobResponse DescribeTargetedSentimentDetectionJob(DescribeTargetedSentimentDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTargetedSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTargetedSentimentDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeTargetedSentimentDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Gets the properties associated with a targeted sentiment detection job. Use this operation
        /// to get the status of the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetedSentimentDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTargetedSentimentDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.JobNotFoundException">
        /// The specified job was not found. Check the job ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeTargetedSentimentDetectionJob">REST API Reference for DescribeTargetedSentimentDetectionJob Operation</seealso>
        public virtual Task<DescribeTargetedSentimentDetectionJobResponse> DescribeTargetedSentimentDetectionJobAsync(DescribeTargetedSentimentDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTargetedSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTargetedSentimentDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTargetedSentimentDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTopicsDetectionJob

        internal virtual DescribeTopicsDetectionJobResponse DescribeTopicsDetectionJob(DescribeTopicsDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTopicsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTopicsDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeTopicsDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Gets the properties associated with a topic detection job. Use this operation to get
        /// the status of a detection job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopicsDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTopicsDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.JobNotFoundException">
        /// The specified job was not found. Check the job ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeTopicsDetectionJob">REST API Reference for DescribeTopicsDetectionJob Operation</seealso>
        public virtual Task<DescribeTopicsDetectionJobResponse> DescribeTopicsDetectionJobAsync(DescribeTopicsDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTopicsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTopicsDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTopicsDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectDominantLanguage

        internal virtual DetectDominantLanguageResponse DetectDominantLanguage(DetectDominantLanguageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectDominantLanguageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectDominantLanguageResponseUnmarshaller.Instance;

            return Invoke<DetectDominantLanguageResponse>(request, options);
        }



        /// <summary>
        /// Determines the dominant language of the input text. For a list of languages that Amazon
        /// Comprehend can detect, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-languages.html">Amazon
        /// Comprehend Supported Languages</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectDominantLanguage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectDominantLanguage service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TextSizeLimitExceededException">
        /// The size of the input text exceeds the limit. Use a smaller document.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectDominantLanguage">REST API Reference for DetectDominantLanguage Operation</seealso>
        public virtual Task<DetectDominantLanguageResponse> DetectDominantLanguageAsync(DetectDominantLanguageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectDominantLanguageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectDominantLanguageResponseUnmarshaller.Instance;

            return InvokeAsync<DetectDominantLanguageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectEntities

        internal virtual DetectEntitiesResponse DetectEntities(DetectEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectEntitiesResponseUnmarshaller.Instance;

            return Invoke<DetectEntitiesResponse>(request, options);
        }



        /// <summary>
        /// Detects named entities in input text when you use the pre-trained model. Detects custom
        /// entities if you have a custom entity recognition model. 
        /// 
        ///  
        /// <para>
        ///  When detecting named entities using the pre-trained model, use plain text as the
        /// input. For more information about named entities, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-entities.html">Entities</a>
        /// in the Comprehend Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// When you use a custom entity recognition model, you can input plain text or you can
        /// upload a single-page input document (text, PDF, Word, or image). 
        /// </para>
        ///  
        /// <para>
        /// If the system detects errors while processing a page in the input document, the API
        /// response includes an entry in <code>Errors</code> for each error. 
        /// </para>
        ///  
        /// <para>
        /// If the system detects a document-level error in your input document, the API returns
        /// an <code>InvalidRequestException</code> error response. For details about this exception,
        /// see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/idp-inputs-sync-err.html">
        /// Errors in semi-structured documents</a> in the Comprehend Developer Guide. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectEntities service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceUnavailableException">
        /// The specified resource is not available. Check the resource and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TextSizeLimitExceededException">
        /// The size of the input text exceeds the limit. Use a smaller document.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.UnsupportedLanguageException">
        /// Amazon Comprehend can't process the language of the input text. For custom entity
        /// recognition APIs, only English, Spanish, French, Italian, German, or Portuguese are
        /// accepted. For a list of supported languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectEntities">REST API Reference for DetectEntities Operation</seealso>
        public virtual Task<DetectEntitiesResponse> DetectEntitiesAsync(DetectEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectEntitiesResponseUnmarshaller.Instance;

            return InvokeAsync<DetectEntitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectKeyPhrases

        internal virtual DetectKeyPhrasesResponse DetectKeyPhrases(DetectKeyPhrasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectKeyPhrasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectKeyPhrasesResponseUnmarshaller.Instance;

            return Invoke<DetectKeyPhrasesResponse>(request, options);
        }



        /// <summary>
        /// Detects the key noun phrases found in the text.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectKeyPhrases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectKeyPhrases service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TextSizeLimitExceededException">
        /// The size of the input text exceeds the limit. Use a smaller document.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.UnsupportedLanguageException">
        /// Amazon Comprehend can't process the language of the input text. For custom entity
        /// recognition APIs, only English, Spanish, French, Italian, German, or Portuguese are
        /// accepted. For a list of supported languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectKeyPhrases">REST API Reference for DetectKeyPhrases Operation</seealso>
        public virtual Task<DetectKeyPhrasesResponse> DetectKeyPhrasesAsync(DetectKeyPhrasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectKeyPhrasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectKeyPhrasesResponseUnmarshaller.Instance;

            return InvokeAsync<DetectKeyPhrasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectPiiEntities

        internal virtual DetectPiiEntitiesResponse DetectPiiEntities(DetectPiiEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectPiiEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectPiiEntitiesResponseUnmarshaller.Instance;

            return Invoke<DetectPiiEntitiesResponse>(request, options);
        }



        /// <summary>
        /// Inspects the input text for entities that contain personally identifiable information
        /// (PII) and returns information about them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectPiiEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectPiiEntities service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TextSizeLimitExceededException">
        /// The size of the input text exceeds the limit. Use a smaller document.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.UnsupportedLanguageException">
        /// Amazon Comprehend can't process the language of the input text. For custom entity
        /// recognition APIs, only English, Spanish, French, Italian, German, or Portuguese are
        /// accepted. For a list of supported languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectPiiEntities">REST API Reference for DetectPiiEntities Operation</seealso>
        public virtual Task<DetectPiiEntitiesResponse> DetectPiiEntitiesAsync(DetectPiiEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectPiiEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectPiiEntitiesResponseUnmarshaller.Instance;

            return InvokeAsync<DetectPiiEntitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectSentiment

        internal virtual DetectSentimentResponse DetectSentiment(DetectSentimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectSentimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectSentimentResponseUnmarshaller.Instance;

            return Invoke<DetectSentimentResponse>(request, options);
        }



        /// <summary>
        /// Inspects text and returns an inference of the prevailing sentiment (<code>POSITIVE</code>,
        /// <code>NEUTRAL</code>, <code>MIXED</code>, or <code>NEGATIVE</code>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectSentiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectSentiment service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TextSizeLimitExceededException">
        /// The size of the input text exceeds the limit. Use a smaller document.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.UnsupportedLanguageException">
        /// Amazon Comprehend can't process the language of the input text. For custom entity
        /// recognition APIs, only English, Spanish, French, Italian, German, or Portuguese are
        /// accepted. For a list of supported languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectSentiment">REST API Reference for DetectSentiment Operation</seealso>
        public virtual Task<DetectSentimentResponse> DetectSentimentAsync(DetectSentimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectSentimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectSentimentResponseUnmarshaller.Instance;

            return InvokeAsync<DetectSentimentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectSyntax

        internal virtual DetectSyntaxResponse DetectSyntax(DetectSyntaxRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectSyntaxRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectSyntaxResponseUnmarshaller.Instance;

            return Invoke<DetectSyntaxResponse>(request, options);
        }



        /// <summary>
        /// Inspects text for syntax and the part of speech of words in the document. For more
        /// information, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-syntax.html">Syntax</a>
        /// in the Comprehend Developer Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectSyntax service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectSyntax service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TextSizeLimitExceededException">
        /// The size of the input text exceeds the limit. Use a smaller document.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.UnsupportedLanguageException">
        /// Amazon Comprehend can't process the language of the input text. For custom entity
        /// recognition APIs, only English, Spanish, French, Italian, German, or Portuguese are
        /// accepted. For a list of supported languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectSyntax">REST API Reference for DetectSyntax Operation</seealso>
        public virtual Task<DetectSyntaxResponse> DetectSyntaxAsync(DetectSyntaxRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectSyntaxRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectSyntaxResponseUnmarshaller.Instance;

            return InvokeAsync<DetectSyntaxResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetectTargetedSentiment

        internal virtual DetectTargetedSentimentResponse DetectTargetedSentiment(DetectTargetedSentimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectTargetedSentimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectTargetedSentimentResponseUnmarshaller.Instance;

            return Invoke<DetectTargetedSentimentResponse>(request, options);
        }



        /// <summary>
        /// Inspects the input text and returns a sentiment analysis for each entity identified
        /// in the text.
        /// 
        ///  
        /// <para>
        /// For more information about targeted sentiment, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-targeted-sentiment.html">Targeted
        /// sentiment</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectTargetedSentiment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectTargetedSentiment service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TextSizeLimitExceededException">
        /// The size of the input text exceeds the limit. Use a smaller document.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.UnsupportedLanguageException">
        /// Amazon Comprehend can't process the language of the input text. For custom entity
        /// recognition APIs, only English, Spanish, French, Italian, German, or Portuguese are
        /// accepted. For a list of supported languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectTargetedSentiment">REST API Reference for DetectTargetedSentiment Operation</seealso>
        public virtual Task<DetectTargetedSentimentResponse> DetectTargetedSentimentAsync(DetectTargetedSentimentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectTargetedSentimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectTargetedSentimentResponseUnmarshaller.Instance;

            return InvokeAsync<DetectTargetedSentimentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportModel

        internal virtual ImportModelResponse ImportModel(ImportModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportModelResponseUnmarshaller.Instance;

            return Invoke<ImportModelResponse>(request, options);
        }



        /// <summary>
        /// Creates a new custom model that replicates a source custom model that you import.
        /// The source model can be in your AWS account or another one.
        /// 
        ///  
        /// <para>
        /// If the source model is in another AWS account, then it must have a resource-based
        /// policy that authorizes you to import it.
        /// </para>
        ///  
        /// <para>
        /// The source model must be in the same AWS region that you're using when you import.
        /// You can't import a model that's in a different region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportModel service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.KmsKeyValidationException">
        /// The KMS customer managed key (CMK) entered cannot be validated. Verify the key and
        /// re-enter it.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceLimitExceededException">
        /// The maximum number of resources per account has been exceeded. Review the resources,
        /// and then try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceUnavailableException">
        /// The specified resource is not available. Check the resource and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ImportModel">REST API Reference for ImportModel Operation</seealso>
        public virtual Task<ImportModelResponse> ImportModelAsync(ImportModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportModelResponseUnmarshaller.Instance;

            return InvokeAsync<ImportModelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDatasets

        internal virtual ListDatasetsResponse ListDatasets(ListDatasetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return Invoke<ListDatasetsResponse>(request, options);
        }



        /// <summary>
        /// List the datasets that you have configured in this region. For more information about
        /// datasets, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/flywheels-about.html">
        /// Flywheel overview</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatasets service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidFilterException">
        /// The filter specified for the operation is invalid. Specify a different filter.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        public virtual Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDatasetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDatasetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDatasetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDocumentClassificationJobs

        internal virtual ListDocumentClassificationJobsResponse ListDocumentClassificationJobs(ListDocumentClassificationJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentClassificationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentClassificationJobsResponseUnmarshaller.Instance;

            return Invoke<ListDocumentClassificationJobsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of the documentation classification jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentClassificationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDocumentClassificationJobs service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidFilterException">
        /// The filter specified for the operation is invalid. Specify a different filter.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDocumentClassificationJobs">REST API Reference for ListDocumentClassificationJobs Operation</seealso>
        public virtual Task<ListDocumentClassificationJobsResponse> ListDocumentClassificationJobsAsync(ListDocumentClassificationJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentClassificationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentClassificationJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDocumentClassificationJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDocumentClassifiers

        internal virtual ListDocumentClassifiersResponse ListDocumentClassifiers(ListDocumentClassifiersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentClassifiersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentClassifiersResponseUnmarshaller.Instance;

            return Invoke<ListDocumentClassifiersResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of the document classifiers that you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentClassifiers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDocumentClassifiers service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidFilterException">
        /// The filter specified for the operation is invalid. Specify a different filter.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDocumentClassifiers">REST API Reference for ListDocumentClassifiers Operation</seealso>
        public virtual Task<ListDocumentClassifiersResponse> ListDocumentClassifiersAsync(ListDocumentClassifiersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentClassifiersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentClassifiersResponseUnmarshaller.Instance;

            return InvokeAsync<ListDocumentClassifiersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDocumentClassifierSummaries

        internal virtual ListDocumentClassifierSummariesResponse ListDocumentClassifierSummaries(ListDocumentClassifierSummariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentClassifierSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentClassifierSummariesResponseUnmarshaller.Instance;

            return Invoke<ListDocumentClassifierSummariesResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of summaries of the document classifiers that you have created
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentClassifierSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDocumentClassifierSummaries service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDocumentClassifierSummaries">REST API Reference for ListDocumentClassifierSummaries Operation</seealso>
        public virtual Task<ListDocumentClassifierSummariesResponse> ListDocumentClassifierSummariesAsync(ListDocumentClassifierSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentClassifierSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentClassifierSummariesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDocumentClassifierSummariesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDominantLanguageDetectionJobs

        internal virtual ListDominantLanguageDetectionJobsResponse ListDominantLanguageDetectionJobs(ListDominantLanguageDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDominantLanguageDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDominantLanguageDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListDominantLanguageDetectionJobsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of the dominant language detection jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDominantLanguageDetectionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDominantLanguageDetectionJobs service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidFilterException">
        /// The filter specified for the operation is invalid. Specify a different filter.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDominantLanguageDetectionJobs">REST API Reference for ListDominantLanguageDetectionJobs Operation</seealso>
        public virtual Task<ListDominantLanguageDetectionJobsResponse> ListDominantLanguageDetectionJobsAsync(ListDominantLanguageDetectionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDominantLanguageDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDominantLanguageDetectionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDominantLanguageDetectionJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEndpoints

        internal virtual ListEndpointsResponse ListEndpoints(ListEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListEndpointsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of all existing endpoints that you've created. For information about endpoints,
        /// see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/manage-endpoints.html">Managing
        /// endpoints</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEndpoints service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        public virtual Task<ListEndpointsResponse> ListEndpointsAsync(ListEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEntitiesDetectionJobs

        internal virtual ListEntitiesDetectionJobsResponse ListEntitiesDetectionJobs(ListEntitiesDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntitiesDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitiesDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListEntitiesDetectionJobsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of the entity detection jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntitiesDetectionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEntitiesDetectionJobs service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidFilterException">
        /// The filter specified for the operation is invalid. Specify a different filter.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEntitiesDetectionJobs">REST API Reference for ListEntitiesDetectionJobs Operation</seealso>
        public virtual Task<ListEntitiesDetectionJobsResponse> ListEntitiesDetectionJobsAsync(ListEntitiesDetectionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntitiesDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitiesDetectionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEntitiesDetectionJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEntityRecognizers

        internal virtual ListEntityRecognizersResponse ListEntityRecognizers(ListEntityRecognizersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntityRecognizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntityRecognizersResponseUnmarshaller.Instance;

            return Invoke<ListEntityRecognizersResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of the properties of all entity recognizers that you created, including
        /// recognizers currently in training. Allows you to filter the list of recognizers based
        /// on criteria such as status and submission time. This call returns up to 500 entity
        /// recognizers in the list, with a default number of 100 recognizers in the list.
        /// 
        ///  
        /// <para>
        /// The results of this list are not in any particular order. Please get the list and
        /// sort locally if needed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntityRecognizers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEntityRecognizers service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidFilterException">
        /// The filter specified for the operation is invalid. Specify a different filter.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEntityRecognizers">REST API Reference for ListEntityRecognizers Operation</seealso>
        public virtual Task<ListEntityRecognizersResponse> ListEntityRecognizersAsync(ListEntityRecognizersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntityRecognizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntityRecognizersResponseUnmarshaller.Instance;

            return InvokeAsync<ListEntityRecognizersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEntityRecognizerSummaries

        internal virtual ListEntityRecognizerSummariesResponse ListEntityRecognizerSummaries(ListEntityRecognizerSummariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntityRecognizerSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntityRecognizerSummariesResponseUnmarshaller.Instance;

            return Invoke<ListEntityRecognizerSummariesResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of summaries for the entity recognizers that you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntityRecognizerSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEntityRecognizerSummaries service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEntityRecognizerSummaries">REST API Reference for ListEntityRecognizerSummaries Operation</seealso>
        public virtual Task<ListEntityRecognizerSummariesResponse> ListEntityRecognizerSummariesAsync(ListEntityRecognizerSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntityRecognizerSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntityRecognizerSummariesResponseUnmarshaller.Instance;

            return InvokeAsync<ListEntityRecognizerSummariesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEventsDetectionJobs

        internal virtual ListEventsDetectionJobsResponse ListEventsDetectionJobs(ListEventsDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventsDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventsDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListEventsDetectionJobsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of the events detection jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventsDetectionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEventsDetectionJobs service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidFilterException">
        /// The filter specified for the operation is invalid. Specify a different filter.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEventsDetectionJobs">REST API Reference for ListEventsDetectionJobs Operation</seealso>
        public virtual Task<ListEventsDetectionJobsResponse> ListEventsDetectionJobsAsync(ListEventsDetectionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventsDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventsDetectionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEventsDetectionJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFlywheelIterationHistory

        internal virtual ListFlywheelIterationHistoryResponse ListFlywheelIterationHistory(ListFlywheelIterationHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFlywheelIterationHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlywheelIterationHistoryResponseUnmarshaller.Instance;

            return Invoke<ListFlywheelIterationHistoryResponse>(request, options);
        }



        /// <summary>
        /// Information about the history of a flywheel iteration. For more information about
        /// flywheels, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/flywheels-about.html">
        /// Flywheel overview</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlywheelIterationHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFlywheelIterationHistory service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidFilterException">
        /// The filter specified for the operation is invalid. Specify a different filter.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListFlywheelIterationHistory">REST API Reference for ListFlywheelIterationHistory Operation</seealso>
        public virtual Task<ListFlywheelIterationHistoryResponse> ListFlywheelIterationHistoryAsync(ListFlywheelIterationHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFlywheelIterationHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlywheelIterationHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<ListFlywheelIterationHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFlywheels

        internal virtual ListFlywheelsResponse ListFlywheels(ListFlywheelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFlywheelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlywheelsResponseUnmarshaller.Instance;

            return Invoke<ListFlywheelsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of the flywheels that you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlywheels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFlywheels service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidFilterException">
        /// The filter specified for the operation is invalid. Specify a different filter.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListFlywheels">REST API Reference for ListFlywheels Operation</seealso>
        public virtual Task<ListFlywheelsResponse> ListFlywheelsAsync(ListFlywheelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFlywheelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlywheelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFlywheelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListKeyPhrasesDetectionJobs

        internal virtual ListKeyPhrasesDetectionJobsResponse ListKeyPhrasesDetectionJobs(ListKeyPhrasesDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeyPhrasesDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeyPhrasesDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListKeyPhrasesDetectionJobsResponse>(request, options);
        }



        /// <summary>
        /// Get a list of key phrase detection jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeyPhrasesDetectionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKeyPhrasesDetectionJobs service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidFilterException">
        /// The filter specified for the operation is invalid. Specify a different filter.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListKeyPhrasesDetectionJobs">REST API Reference for ListKeyPhrasesDetectionJobs Operation</seealso>
        public virtual Task<ListKeyPhrasesDetectionJobsResponse> ListKeyPhrasesDetectionJobsAsync(ListKeyPhrasesDetectionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeyPhrasesDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeyPhrasesDetectionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListKeyPhrasesDetectionJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPiiEntitiesDetectionJobs

        internal virtual ListPiiEntitiesDetectionJobsResponse ListPiiEntitiesDetectionJobs(ListPiiEntitiesDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPiiEntitiesDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPiiEntitiesDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListPiiEntitiesDetectionJobsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of the PII entity detection jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPiiEntitiesDetectionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPiiEntitiesDetectionJobs service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidFilterException">
        /// The filter specified for the operation is invalid. Specify a different filter.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListPiiEntitiesDetectionJobs">REST API Reference for ListPiiEntitiesDetectionJobs Operation</seealso>
        public virtual Task<ListPiiEntitiesDetectionJobsResponse> ListPiiEntitiesDetectionJobsAsync(ListPiiEntitiesDetectionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPiiEntitiesDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPiiEntitiesDetectionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPiiEntitiesDetectionJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSentimentDetectionJobs

        internal virtual ListSentimentDetectionJobsResponse ListSentimentDetectionJobs(ListSentimentDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSentimentDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSentimentDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListSentimentDetectionJobsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of sentiment detection jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSentimentDetectionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSentimentDetectionJobs service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidFilterException">
        /// The filter specified for the operation is invalid. Specify a different filter.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListSentimentDetectionJobs">REST API Reference for ListSentimentDetectionJobs Operation</seealso>
        public virtual Task<ListSentimentDetectionJobsResponse> ListSentimentDetectionJobsAsync(ListSentimentDetectionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSentimentDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSentimentDetectionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSentimentDetectionJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists all tags associated with a given Amazon Comprehend resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTargetedSentimentDetectionJobs

        internal virtual ListTargetedSentimentDetectionJobsResponse ListTargetedSentimentDetectionJobs(ListTargetedSentimentDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTargetedSentimentDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetedSentimentDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListTargetedSentimentDetectionJobsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of targeted sentiment detection jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetedSentimentDetectionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTargetedSentimentDetectionJobs service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidFilterException">
        /// The filter specified for the operation is invalid. Specify a different filter.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListTargetedSentimentDetectionJobs">REST API Reference for ListTargetedSentimentDetectionJobs Operation</seealso>
        public virtual Task<ListTargetedSentimentDetectionJobsResponse> ListTargetedSentimentDetectionJobsAsync(ListTargetedSentimentDetectionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTargetedSentimentDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetedSentimentDetectionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTargetedSentimentDetectionJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTopicsDetectionJobs

        internal virtual ListTopicsDetectionJobsResponse ListTopicsDetectionJobs(ListTopicsDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTopicsDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTopicsDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListTopicsDetectionJobsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of the topic detection jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopicsDetectionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTopicsDetectionJobs service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidFilterException">
        /// The filter specified for the operation is invalid. Specify a different filter.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListTopicsDetectionJobs">REST API Reference for ListTopicsDetectionJobs Operation</seealso>
        public virtual Task<ListTopicsDetectionJobsResponse> ListTopicsDetectionJobsAsync(ListTopicsDetectionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTopicsDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTopicsDetectionJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTopicsDetectionJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutResourcePolicy

        internal virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Attaches a resource-based policy to a custom model. You can use this policy to authorize
        /// an entity in another AWS account to import the custom model, which replicates it in
        /// Amazon Comprehend in their account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDocumentClassificationJob

        internal virtual StartDocumentClassificationJobResponse StartDocumentClassificationJob(StartDocumentClassificationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDocumentClassificationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDocumentClassificationJobResponseUnmarshaller.Instance;

            return Invoke<StartDocumentClassificationJobResponse>(request, options);
        }



        /// <summary>
        /// Starts an asynchronous document classification job. Use the <code>DescribeDocumentClassificationJob</code>
        /// operation to track the progress of the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDocumentClassificationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDocumentClassificationJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.KmsKeyValidationException">
        /// The KMS customer managed key (CMK) entered cannot be validated. Verify the key and
        /// re-enter it.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceUnavailableException">
        /// The specified resource is not available. Check the resource and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartDocumentClassificationJob">REST API Reference for StartDocumentClassificationJob Operation</seealso>
        public virtual Task<StartDocumentClassificationJobResponse> StartDocumentClassificationJobAsync(StartDocumentClassificationJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDocumentClassificationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDocumentClassificationJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartDocumentClassificationJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartDominantLanguageDetectionJob

        internal virtual StartDominantLanguageDetectionJobResponse StartDominantLanguageDetectionJob(StartDominantLanguageDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDominantLanguageDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartDominantLanguageDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Starts an asynchronous dominant language detection job for a collection of documents.
        /// Use the operation to track the status of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDominantLanguageDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDominantLanguageDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.KmsKeyValidationException">
        /// The KMS customer managed key (CMK) entered cannot be validated. Verify the key and
        /// re-enter it.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartDominantLanguageDetectionJob">REST API Reference for StartDominantLanguageDetectionJob Operation</seealso>
        public virtual Task<StartDominantLanguageDetectionJobResponse> StartDominantLanguageDetectionJobAsync(StartDominantLanguageDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDominantLanguageDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartDominantLanguageDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartEntitiesDetectionJob

        internal virtual StartEntitiesDetectionJobResponse StartEntitiesDetectionJob(StartEntitiesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEntitiesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartEntitiesDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Starts an asynchronous entity detection job for a collection of documents. Use the
        /// operation to track the status of a job.
        /// 
        ///  
        /// <para>
        /// This API can be used for either standard entity detection or custom entity recognition.
        /// In order to be used for custom entity recognition, the optional <code>EntityRecognizerArn</code>
        /// must be used in order to provide access to the recognizer being used to detect the
        /// custom entity.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEntitiesDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartEntitiesDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.KmsKeyValidationException">
        /// The KMS customer managed key (CMK) entered cannot be validated. Verify the key and
        /// re-enter it.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceUnavailableException">
        /// The specified resource is not available. Check the resource and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartEntitiesDetectionJob">REST API Reference for StartEntitiesDetectionJob Operation</seealso>
        public virtual Task<StartEntitiesDetectionJobResponse> StartEntitiesDetectionJobAsync(StartEntitiesDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEntitiesDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartEntitiesDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartEventsDetectionJob

        internal virtual StartEventsDetectionJobResponse StartEventsDetectionJob(StartEventsDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEventsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEventsDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartEventsDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Starts an asynchronous event detection job for a collection of documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEventsDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartEventsDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.KmsKeyValidationException">
        /// The KMS customer managed key (CMK) entered cannot be validated. Verify the key and
        /// re-enter it.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartEventsDetectionJob">REST API Reference for StartEventsDetectionJob Operation</seealso>
        public virtual Task<StartEventsDetectionJobResponse> StartEventsDetectionJobAsync(StartEventsDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEventsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEventsDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartEventsDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartFlywheelIteration

        internal virtual StartFlywheelIterationResponse StartFlywheelIteration(StartFlywheelIterationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFlywheelIterationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFlywheelIterationResponseUnmarshaller.Instance;

            return Invoke<StartFlywheelIterationResponse>(request, options);
        }



        /// <summary>
        /// Start the flywheel iteration.This operation uses any new datasets to train a new model
        /// version. For more information about flywheels, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/flywheels-about.html">
        /// Flywheel overview</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFlywheelIteration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartFlywheelIteration service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartFlywheelIteration">REST API Reference for StartFlywheelIteration Operation</seealso>
        public virtual Task<StartFlywheelIterationResponse> StartFlywheelIterationAsync(StartFlywheelIterationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFlywheelIterationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFlywheelIterationResponseUnmarshaller.Instance;

            return InvokeAsync<StartFlywheelIterationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartKeyPhrasesDetectionJob

        internal virtual StartKeyPhrasesDetectionJobResponse StartKeyPhrasesDetectionJob(StartKeyPhrasesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartKeyPhrasesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartKeyPhrasesDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Starts an asynchronous key phrase detection job for a collection of documents. Use
        /// the operation to track the status of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartKeyPhrasesDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartKeyPhrasesDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.KmsKeyValidationException">
        /// The KMS customer managed key (CMK) entered cannot be validated. Verify the key and
        /// re-enter it.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartKeyPhrasesDetectionJob">REST API Reference for StartKeyPhrasesDetectionJob Operation</seealso>
        public virtual Task<StartKeyPhrasesDetectionJobResponse> StartKeyPhrasesDetectionJobAsync(StartKeyPhrasesDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartKeyPhrasesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartKeyPhrasesDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartPiiEntitiesDetectionJob

        internal virtual StartPiiEntitiesDetectionJobResponse StartPiiEntitiesDetectionJob(StartPiiEntitiesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPiiEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPiiEntitiesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartPiiEntitiesDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Starts an asynchronous PII entity detection job for a collection of documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPiiEntitiesDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartPiiEntitiesDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.KmsKeyValidationException">
        /// The KMS customer managed key (CMK) entered cannot be validated. Verify the key and
        /// re-enter it.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartPiiEntitiesDetectionJob">REST API Reference for StartPiiEntitiesDetectionJob Operation</seealso>
        public virtual Task<StartPiiEntitiesDetectionJobResponse> StartPiiEntitiesDetectionJobAsync(StartPiiEntitiesDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPiiEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPiiEntitiesDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartPiiEntitiesDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartSentimentDetectionJob

        internal virtual StartSentimentDetectionJobResponse StartSentimentDetectionJob(StartSentimentDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSentimentDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartSentimentDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Starts an asynchronous sentiment detection job for a collection of documents. Use
        /// the operation to track the status of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSentimentDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSentimentDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.KmsKeyValidationException">
        /// The KMS customer managed key (CMK) entered cannot be validated. Verify the key and
        /// re-enter it.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartSentimentDetectionJob">REST API Reference for StartSentimentDetectionJob Operation</seealso>
        public virtual Task<StartSentimentDetectionJobResponse> StartSentimentDetectionJobAsync(StartSentimentDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSentimentDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartSentimentDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartTargetedSentimentDetectionJob

        internal virtual StartTargetedSentimentDetectionJobResponse StartTargetedSentimentDetectionJob(StartTargetedSentimentDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTargetedSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTargetedSentimentDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartTargetedSentimentDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Starts an asynchronous targeted sentiment detection job for a collection of documents.
        /// Use the <code>DescribeTargetedSentimentDetectionJob</code> operation to track the
        /// status of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTargetedSentimentDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTargetedSentimentDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.KmsKeyValidationException">
        /// The KMS customer managed key (CMK) entered cannot be validated. Verify the key and
        /// re-enter it.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartTargetedSentimentDetectionJob">REST API Reference for StartTargetedSentimentDetectionJob Operation</seealso>
        public virtual Task<StartTargetedSentimentDetectionJobResponse> StartTargetedSentimentDetectionJobAsync(StartTargetedSentimentDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTargetedSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTargetedSentimentDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartTargetedSentimentDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartTopicsDetectionJob

        internal virtual StartTopicsDetectionJobResponse StartTopicsDetectionJob(StartTopicsDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTopicsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTopicsDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartTopicsDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Starts an asynchronous topic detection job. Use the <code>DescribeTopicDetectionJob</code>
        /// operation to track the status of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTopicsDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTopicsDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.KmsKeyValidationException">
        /// The KMS customer managed key (CMK) entered cannot be validated. Verify the key and
        /// re-enter it.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartTopicsDetectionJob">REST API Reference for StartTopicsDetectionJob Operation</seealso>
        public virtual Task<StartTopicsDetectionJobResponse> StartTopicsDetectionJobAsync(StartTopicsDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTopicsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTopicsDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartTopicsDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopDominantLanguageDetectionJob

        internal virtual StopDominantLanguageDetectionJobResponse StopDominantLanguageDetectionJob(StopDominantLanguageDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDominantLanguageDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopDominantLanguageDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Stops a dominant language detection job in progress.
        /// 
        ///  
        /// <para>
        /// If the job state is <code>IN_PROGRESS</code> the job is marked for termination and
        /// put into the <code>STOP_REQUESTED</code> state. If the job completes before it can
        /// be stopped, it is put into the <code>COMPLETED</code> state; otherwise the job is
        /// stopped and put into the <code>STOPPED</code> state.
        /// </para>
        ///  
        /// <para>
        /// If the job is in the <code>COMPLETED</code> or <code>FAILED</code> state when you
        /// call the <code>StopDominantLanguageDetectionJob</code> operation, the operation returns
        /// a 400 Internal Request Exception. 
        /// </para>
        ///  
        /// <para>
        /// When a job is stopped, any documents already processed are written to the output location.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDominantLanguageDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopDominantLanguageDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.JobNotFoundException">
        /// The specified job was not found. Check the job ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopDominantLanguageDetectionJob">REST API Reference for StopDominantLanguageDetectionJob Operation</seealso>
        public virtual Task<StopDominantLanguageDetectionJobResponse> StopDominantLanguageDetectionJobAsync(StopDominantLanguageDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDominantLanguageDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopDominantLanguageDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopEntitiesDetectionJob

        internal virtual StopEntitiesDetectionJobResponse StopEntitiesDetectionJob(StopEntitiesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEntitiesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopEntitiesDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Stops an entities detection job in progress.
        /// 
        ///  
        /// <para>
        /// If the job state is <code>IN_PROGRESS</code> the job is marked for termination and
        /// put into the <code>STOP_REQUESTED</code> state. If the job completes before it can
        /// be stopped, it is put into the <code>COMPLETED</code> state; otherwise the job is
        /// stopped and put into the <code>STOPPED</code> state.
        /// </para>
        ///  
        /// <para>
        /// If the job is in the <code>COMPLETED</code> or <code>FAILED</code> state when you
        /// call the <code>StopDominantLanguageDetectionJob</code> operation, the operation returns
        /// a 400 Internal Request Exception. 
        /// </para>
        ///  
        /// <para>
        /// When a job is stopped, any documents already processed are written to the output location.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEntitiesDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopEntitiesDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.JobNotFoundException">
        /// The specified job was not found. Check the job ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopEntitiesDetectionJob">REST API Reference for StopEntitiesDetectionJob Operation</seealso>
        public virtual Task<StopEntitiesDetectionJobResponse> StopEntitiesDetectionJobAsync(StopEntitiesDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEntitiesDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopEntitiesDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopEventsDetectionJob

        internal virtual StopEventsDetectionJobResponse StopEventsDetectionJob(StopEventsDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEventsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEventsDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopEventsDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Stops an events detection job in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEventsDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopEventsDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.JobNotFoundException">
        /// The specified job was not found. Check the job ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopEventsDetectionJob">REST API Reference for StopEventsDetectionJob Operation</seealso>
        public virtual Task<StopEventsDetectionJobResponse> StopEventsDetectionJobAsync(StopEventsDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEventsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEventsDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopEventsDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopKeyPhrasesDetectionJob

        internal virtual StopKeyPhrasesDetectionJobResponse StopKeyPhrasesDetectionJob(StopKeyPhrasesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopKeyPhrasesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopKeyPhrasesDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Stops a key phrases detection job in progress.
        /// 
        ///  
        /// <para>
        /// If the job state is <code>IN_PROGRESS</code> the job is marked for termination and
        /// put into the <code>STOP_REQUESTED</code> state. If the job completes before it can
        /// be stopped, it is put into the <code>COMPLETED</code> state; otherwise the job is
        /// stopped and put into the <code>STOPPED</code> state.
        /// </para>
        ///  
        /// <para>
        /// If the job is in the <code>COMPLETED</code> or <code>FAILED</code> state when you
        /// call the <code>StopDominantLanguageDetectionJob</code> operation, the operation returns
        /// a 400 Internal Request Exception. 
        /// </para>
        ///  
        /// <para>
        /// When a job is stopped, any documents already processed are written to the output location.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopKeyPhrasesDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopKeyPhrasesDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.JobNotFoundException">
        /// The specified job was not found. Check the job ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopKeyPhrasesDetectionJob">REST API Reference for StopKeyPhrasesDetectionJob Operation</seealso>
        public virtual Task<StopKeyPhrasesDetectionJobResponse> StopKeyPhrasesDetectionJobAsync(StopKeyPhrasesDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopKeyPhrasesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopKeyPhrasesDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopPiiEntitiesDetectionJob

        internal virtual StopPiiEntitiesDetectionJobResponse StopPiiEntitiesDetectionJob(StopPiiEntitiesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopPiiEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopPiiEntitiesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopPiiEntitiesDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Stops a PII entities detection job in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopPiiEntitiesDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopPiiEntitiesDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.JobNotFoundException">
        /// The specified job was not found. Check the job ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopPiiEntitiesDetectionJob">REST API Reference for StopPiiEntitiesDetectionJob Operation</seealso>
        public virtual Task<StopPiiEntitiesDetectionJobResponse> StopPiiEntitiesDetectionJobAsync(StopPiiEntitiesDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopPiiEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopPiiEntitiesDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopPiiEntitiesDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopSentimentDetectionJob

        internal virtual StopSentimentDetectionJobResponse StopSentimentDetectionJob(StopSentimentDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopSentimentDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopSentimentDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Stops a sentiment detection job in progress.
        /// 
        ///  
        /// <para>
        /// If the job state is <code>IN_PROGRESS</code>, the job is marked for termination and
        /// put into the <code>STOP_REQUESTED</code> state. If the job completes before it can
        /// be stopped, it is put into the <code>COMPLETED</code> state; otherwise the job is
        /// be stopped and put into the <code>STOPPED</code> state.
        /// </para>
        ///  
        /// <para>
        /// If the job is in the <code>COMPLETED</code> or <code>FAILED</code> state when you
        /// call the <code>StopDominantLanguageDetectionJob</code> operation, the operation returns
        /// a 400 Internal Request Exception. 
        /// </para>
        ///  
        /// <para>
        /// When a job is stopped, any documents already processed are written to the output location.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSentimentDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopSentimentDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.JobNotFoundException">
        /// The specified job was not found. Check the job ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopSentimentDetectionJob">REST API Reference for StopSentimentDetectionJob Operation</seealso>
        public virtual Task<StopSentimentDetectionJobResponse> StopSentimentDetectionJobAsync(StopSentimentDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopSentimentDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopSentimentDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopTargetedSentimentDetectionJob

        internal virtual StopTargetedSentimentDetectionJobResponse StopTargetedSentimentDetectionJob(StopTargetedSentimentDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTargetedSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTargetedSentimentDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopTargetedSentimentDetectionJobResponse>(request, options);
        }



        /// <summary>
        /// Stops a targeted sentiment detection job in progress.
        /// 
        ///  
        /// <para>
        /// If the job state is <code>IN_PROGRESS</code>, the job is marked for termination and
        /// put into the <code>STOP_REQUESTED</code> state. If the job completes before it can
        /// be stopped, it is put into the <code>COMPLETED</code> state; otherwise the job is
        /// be stopped and put into the <code>STOPPED</code> state.
        /// </para>
        ///  
        /// <para>
        /// If the job is in the <code>COMPLETED</code> or <code>FAILED</code> state when you
        /// call the <code>StopDominantLanguageDetectionJob</code> operation, the operation returns
        /// a 400 Internal Request Exception. 
        /// </para>
        ///  
        /// <para>
        /// When a job is stopped, any documents already processed are written to the output location.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTargetedSentimentDetectionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopTargetedSentimentDetectionJob service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.JobNotFoundException">
        /// The specified job was not found. Check the job ID and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopTargetedSentimentDetectionJob">REST API Reference for StopTargetedSentimentDetectionJob Operation</seealso>
        public virtual Task<StopTargetedSentimentDetectionJobResponse> StopTargetedSentimentDetectionJobAsync(StopTargetedSentimentDetectionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTargetedSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTargetedSentimentDetectionJobResponseUnmarshaller.Instance;

            return InvokeAsync<StopTargetedSentimentDetectionJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopTrainingDocumentClassifier

        internal virtual StopTrainingDocumentClassifierResponse StopTrainingDocumentClassifier(StopTrainingDocumentClassifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTrainingDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTrainingDocumentClassifierResponseUnmarshaller.Instance;

            return Invoke<StopTrainingDocumentClassifierResponse>(request, options);
        }



        /// <summary>
        /// Stops a document classifier training job while in progress.
        /// 
        ///  
        /// <para>
        /// If the training job state is <code>TRAINING</code>, the job is marked for termination
        /// and put into the <code>STOP_REQUESTED</code> state. If the training job completes
        /// before it can be stopped, it is put into the <code>TRAINED</code>; otherwise the training
        /// job is stopped and put into the <code>STOPPED</code> state and the service sends back
        /// an HTTP 200 response with an empty HTTP body. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTrainingDocumentClassifier service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopTrainingDocumentClassifier service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopTrainingDocumentClassifier">REST API Reference for StopTrainingDocumentClassifier Operation</seealso>
        public virtual Task<StopTrainingDocumentClassifierResponse> StopTrainingDocumentClassifierAsync(StopTrainingDocumentClassifierRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTrainingDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTrainingDocumentClassifierResponseUnmarshaller.Instance;

            return InvokeAsync<StopTrainingDocumentClassifierResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopTrainingEntityRecognizer

        internal virtual StopTrainingEntityRecognizerResponse StopTrainingEntityRecognizer(StopTrainingEntityRecognizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTrainingEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTrainingEntityRecognizerResponseUnmarshaller.Instance;

            return Invoke<StopTrainingEntityRecognizerResponse>(request, options);
        }



        /// <summary>
        /// Stops an entity recognizer training job while in progress.
        /// 
        ///  
        /// <para>
        /// If the training job state is <code>TRAINING</code>, the job is marked for termination
        /// and put into the <code>STOP_REQUESTED</code> state. If the training job completes
        /// before it can be stopped, it is put into the <code>TRAINED</code>; otherwise the training
        /// job is stopped and putted into the <code>STOPPED</code> state and the service sends
        /// back an HTTP 200 response with an empty HTTP body.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTrainingEntityRecognizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopTrainingEntityRecognizer service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopTrainingEntityRecognizer">REST API Reference for StopTrainingEntityRecognizer Operation</seealso>
        public virtual Task<StopTrainingEntityRecognizerResponse> StopTrainingEntityRecognizerAsync(StopTrainingEntityRecognizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTrainingEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTrainingEntityRecognizerResponseUnmarshaller.Instance;

            return InvokeAsync<StopTrainingEntityRecognizerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Associates a specific tag with an Amazon Comprehend resource. A tag is a key-value
        /// pair that adds as a metadata to a resource used by Amazon Comprehend. For example,
        /// a tag with "Sales" as the key might be added to a resource to indicate its use by
        /// the sales department.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.ConcurrentModificationException">
        /// Concurrent modification of the tags associated with an Amazon Comprehend resource
        /// is not supported.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes a specific tag associated with an Amazon Comprehend resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.ConcurrentModificationException">
        /// Concurrent modification of the tags associated with an Amazon Comprehend resource
        /// is not supported.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyTagKeysException">
        /// The request contains more tag keys than can be associated with a resource (50 tag
        /// keys per resource).
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEndpoint

        internal virtual UpdateEndpointResponse UpdateEndpoint(UpdateEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointResponse>(request, options);
        }



        /// <summary>
        /// Updates information about the specified endpoint. For information about endpoints,
        /// see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/manage-endpoints.html">Managing
        /// endpoints</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEndpoint service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceLimitExceededException">
        /// The maximum number of resources per account has been exceeded. Review the resources,
        /// and then try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceUnavailableException">
        /// The specified resource is not available. Check the resource and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        public virtual Task<UpdateEndpointResponse> UpdateEndpointAsync(UpdateEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFlywheel

        internal virtual UpdateFlywheelResponse UpdateFlywheel(UpdateFlywheelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFlywheelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlywheelResponseUnmarshaller.Instance;

            return Invoke<UpdateFlywheelResponse>(request, options);
        }



        /// <summary>
        /// Update the configuration information for an existing flywheel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlywheel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFlywheel service method, as returned by Comprehend.</returns>
        /// <exception cref="Amazon.Comprehend.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.KmsKeyValidationException">
        /// The KMS customer managed key (CMK) entered cannot be validated. Verify the key and
        /// re-enter it.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/UpdateFlywheel">REST API Reference for UpdateFlywheel Operation</seealso>
        public virtual Task<UpdateFlywheelResponse> UpdateFlywheelAsync(UpdateFlywheelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFlywheelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFlywheelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFlywheelResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}