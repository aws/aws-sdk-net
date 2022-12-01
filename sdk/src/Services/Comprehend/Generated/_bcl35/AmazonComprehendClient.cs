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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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

        /// <summary>
        /// Determines the dominant language of the input text for a batch of documents. For a
        /// list of languages that Amazon Comprehend can detect, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-languages.html">Amazon
        /// Comprehend Supported Languages</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectDominantLanguage service method.</param>
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
        public virtual BatchDetectDominantLanguageResponse BatchDetectDominantLanguage(BatchDetectDominantLanguageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectDominantLanguageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectDominantLanguageResponseUnmarshaller.Instance;

            return Invoke<BatchDetectDominantLanguageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDetectDominantLanguage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectDominantLanguage operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDetectDominantLanguage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectDominantLanguage">REST API Reference for BatchDetectDominantLanguage Operation</seealso>
        public virtual IAsyncResult BeginBatchDetectDominantLanguage(BatchDetectDominantLanguageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectDominantLanguageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectDominantLanguageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDetectDominantLanguage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDetectDominantLanguage.</param>
        /// 
        /// <returns>Returns a  BatchDetectDominantLanguageResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectDominantLanguage">REST API Reference for BatchDetectDominantLanguage Operation</seealso>
        public virtual BatchDetectDominantLanguageResponse EndBatchDetectDominantLanguage(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDetectDominantLanguageResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDetectEntities

        /// <summary>
        /// Inspects the text of a batch of documents for named entities and returns information
        /// about them. For more information about named entities, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-entities.html">Entities</a>
        /// in the Comprehend Developer Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectEntities service method.</param>
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
        public virtual BatchDetectEntitiesResponse BatchDetectEntities(BatchDetectEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectEntitiesResponseUnmarshaller.Instance;

            return Invoke<BatchDetectEntitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDetectEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectEntities operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDetectEntities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectEntities">REST API Reference for BatchDetectEntities Operation</seealso>
        public virtual IAsyncResult BeginBatchDetectEntities(BatchDetectEntitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectEntitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDetectEntities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDetectEntities.</param>
        /// 
        /// <returns>Returns a  BatchDetectEntitiesResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectEntities">REST API Reference for BatchDetectEntities Operation</seealso>
        public virtual BatchDetectEntitiesResponse EndBatchDetectEntities(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDetectEntitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDetectKeyPhrases

        /// <summary>
        /// Detects the key noun phrases found in a batch of documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectKeyPhrases service method.</param>
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
        public virtual BatchDetectKeyPhrasesResponse BatchDetectKeyPhrases(BatchDetectKeyPhrasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectKeyPhrasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectKeyPhrasesResponseUnmarshaller.Instance;

            return Invoke<BatchDetectKeyPhrasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDetectKeyPhrases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectKeyPhrases operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDetectKeyPhrases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectKeyPhrases">REST API Reference for BatchDetectKeyPhrases Operation</seealso>
        public virtual IAsyncResult BeginBatchDetectKeyPhrases(BatchDetectKeyPhrasesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectKeyPhrasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectKeyPhrasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDetectKeyPhrases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDetectKeyPhrases.</param>
        /// 
        /// <returns>Returns a  BatchDetectKeyPhrasesResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectKeyPhrases">REST API Reference for BatchDetectKeyPhrases Operation</seealso>
        public virtual BatchDetectKeyPhrasesResponse EndBatchDetectKeyPhrases(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDetectKeyPhrasesResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDetectSentiment

        /// <summary>
        /// Inspects a batch of documents and returns an inference of the prevailing sentiment,
        /// <code>POSITIVE</code>, <code>NEUTRAL</code>, <code>MIXED</code>, or <code>NEGATIVE</code>,
        /// in each one.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectSentiment service method.</param>
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
        public virtual BatchDetectSentimentResponse BatchDetectSentiment(BatchDetectSentimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectSentimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectSentimentResponseUnmarshaller.Instance;

            return Invoke<BatchDetectSentimentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDetectSentiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectSentiment operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDetectSentiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectSentiment">REST API Reference for BatchDetectSentiment Operation</seealso>
        public virtual IAsyncResult BeginBatchDetectSentiment(BatchDetectSentimentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectSentimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectSentimentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDetectSentiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDetectSentiment.</param>
        /// 
        /// <returns>Returns a  BatchDetectSentimentResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectSentiment">REST API Reference for BatchDetectSentiment Operation</seealso>
        public virtual BatchDetectSentimentResponse EndBatchDetectSentiment(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDetectSentimentResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDetectSyntax

        /// <summary>
        /// Inspects the text of a batch of documents for the syntax and part of speech of the
        /// words in the document and returns information about them. For more information, see
        /// <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-syntax.html">Syntax</a>
        /// in the Comprehend Developer Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectSyntax service method.</param>
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
        public virtual BatchDetectSyntaxResponse BatchDetectSyntax(BatchDetectSyntaxRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectSyntaxRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectSyntaxResponseUnmarshaller.Instance;

            return Invoke<BatchDetectSyntaxResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDetectSyntax operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectSyntax operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDetectSyntax
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectSyntax">REST API Reference for BatchDetectSyntax Operation</seealso>
        public virtual IAsyncResult BeginBatchDetectSyntax(BatchDetectSyntaxRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectSyntaxRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectSyntaxResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDetectSyntax operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDetectSyntax.</param>
        /// 
        /// <returns>Returns a  BatchDetectSyntaxResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectSyntax">REST API Reference for BatchDetectSyntax Operation</seealso>
        public virtual BatchDetectSyntaxResponse EndBatchDetectSyntax(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDetectSyntaxResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchDetectTargetedSentiment

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
        public virtual BatchDetectTargetedSentimentResponse BatchDetectTargetedSentiment(BatchDetectTargetedSentimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectTargetedSentimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectTargetedSentimentResponseUnmarshaller.Instance;

            return Invoke<BatchDetectTargetedSentimentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDetectTargetedSentiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDetectTargetedSentiment operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDetectTargetedSentiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectTargetedSentiment">REST API Reference for BatchDetectTargetedSentiment Operation</seealso>
        public virtual IAsyncResult BeginBatchDetectTargetedSentiment(BatchDetectTargetedSentimentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchDetectTargetedSentimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchDetectTargetedSentimentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDetectTargetedSentiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDetectTargetedSentiment.</param>
        /// 
        /// <returns>Returns a  BatchDetectTargetedSentimentResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectTargetedSentiment">REST API Reference for BatchDetectTargetedSentiment Operation</seealso>
        public virtual BatchDetectTargetedSentimentResponse EndBatchDetectTargetedSentiment(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchDetectTargetedSentimentResponse>(asyncResult);
        }

        #endregion
        
        #region  ClassifyDocument

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
        public virtual ClassifyDocumentResponse ClassifyDocument(ClassifyDocumentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ClassifyDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ClassifyDocumentResponseUnmarshaller.Instance;

            return Invoke<ClassifyDocumentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ClassifyDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ClassifyDocument operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndClassifyDocument
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ClassifyDocument">REST API Reference for ClassifyDocument Operation</seealso>
        public virtual IAsyncResult BeginClassifyDocument(ClassifyDocumentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ClassifyDocumentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ClassifyDocumentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ClassifyDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginClassifyDocument.</param>
        /// 
        /// <returns>Returns a  ClassifyDocumentResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ClassifyDocument">REST API Reference for ClassifyDocument Operation</seealso>
        public virtual ClassifyDocumentResponse EndClassifyDocument(IAsyncResult asyncResult)
        {
            return EndInvoke<ClassifyDocumentResponse>(asyncResult);
        }

        #endregion
        
        #region  ContainsPiiEntities

        /// <summary>
        /// Analyzes input text for the presence of personally identifiable information (PII)
        /// and returns the labels of identified PII entity types such as name, address, bank
        /// account number, or phone number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ContainsPiiEntities service method.</param>
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
        public virtual ContainsPiiEntitiesResponse ContainsPiiEntities(ContainsPiiEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ContainsPiiEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ContainsPiiEntitiesResponseUnmarshaller.Instance;

            return Invoke<ContainsPiiEntitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ContainsPiiEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ContainsPiiEntities operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndContainsPiiEntities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ContainsPiiEntities">REST API Reference for ContainsPiiEntities Operation</seealso>
        public virtual IAsyncResult BeginContainsPiiEntities(ContainsPiiEntitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ContainsPiiEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ContainsPiiEntitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ContainsPiiEntities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginContainsPiiEntities.</param>
        /// 
        /// <returns>Returns a  ContainsPiiEntitiesResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ContainsPiiEntities">REST API Reference for ContainsPiiEntities Operation</seealso>
        public virtual ContainsPiiEntitiesResponse EndContainsPiiEntities(IAsyncResult asyncResult)
        {
            return EndInvoke<ContainsPiiEntitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDocumentClassifier

        /// <summary>
        /// Creates a new document classifier that you can use to categorize documents. To create
        /// a classifier, you provide a set of training documents that labeled with the categories
        /// that you want to use. After the classifier is trained you can use it to categorize
        /// a set of labeled documents into the categories. For more information, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-document-classification.html">Document
        /// Classification</a> in the Comprehend Developer Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDocumentClassifier service method.</param>
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
        public virtual CreateDocumentClassifierResponse CreateDocumentClassifier(CreateDocumentClassifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDocumentClassifierResponseUnmarshaller.Instance;

            return Invoke<CreateDocumentClassifierResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDocumentClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDocumentClassifier operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDocumentClassifier
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateDocumentClassifier">REST API Reference for CreateDocumentClassifier Operation</seealso>
        public virtual IAsyncResult BeginCreateDocumentClassifier(CreateDocumentClassifierRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDocumentClassifierResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDocumentClassifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDocumentClassifier.</param>
        /// 
        /// <returns>Returns a  CreateDocumentClassifierResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateDocumentClassifier">REST API Reference for CreateDocumentClassifier Operation</seealso>
        public virtual CreateDocumentClassifierResponse EndCreateDocumentClassifier(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDocumentClassifierResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEndpoint

        /// <summary>
        /// Creates a model-specific endpoint for synchronous inference for a previously trained
        /// custom model For information about endpoints, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/manage-endpoints.html">Managing
        /// endpoints</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint service method.</param>
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
        public virtual CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        public virtual IAsyncResult BeginCreateEndpoint(CreateEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateEndpointResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        public virtual CreateEndpointResponse EndCreateEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEntityRecognizer

        /// <summary>
        /// Creates an entity recognizer using submitted files. After your <code>CreateEntityRecognizer</code>
        /// request is submitted, you can check job status using the API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEntityRecognizer service method.</param>
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
        public virtual CreateEntityRecognizerResponse CreateEntityRecognizer(CreateEntityRecognizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEntityRecognizerResponseUnmarshaller.Instance;

            return Invoke<CreateEntityRecognizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEntityRecognizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEntityRecognizer operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEntityRecognizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateEntityRecognizer">REST API Reference for CreateEntityRecognizer Operation</seealso>
        public virtual IAsyncResult BeginCreateEntityRecognizer(CreateEntityRecognizerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEntityRecognizerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEntityRecognizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEntityRecognizer.</param>
        /// 
        /// <returns>Returns a  CreateEntityRecognizerResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateEntityRecognizer">REST API Reference for CreateEntityRecognizer Operation</seealso>
        public virtual CreateEntityRecognizerResponse EndCreateEntityRecognizer(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEntityRecognizerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDocumentClassifier

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
        public virtual DeleteDocumentClassifierResponse DeleteDocumentClassifier(DeleteDocumentClassifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDocumentClassifierResponseUnmarshaller.Instance;

            return Invoke<DeleteDocumentClassifierResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDocumentClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocumentClassifier operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDocumentClassifier
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DeleteDocumentClassifier">REST API Reference for DeleteDocumentClassifier Operation</seealso>
        public virtual IAsyncResult BeginDeleteDocumentClassifier(DeleteDocumentClassifierRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDocumentClassifierResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDocumentClassifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDocumentClassifier.</param>
        /// 
        /// <returns>Returns a  DeleteDocumentClassifierResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DeleteDocumentClassifier">REST API Reference for DeleteDocumentClassifier Operation</seealso>
        public virtual DeleteDocumentClassifierResponse EndDeleteDocumentClassifier(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDocumentClassifierResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEndpoint

        /// <summary>
        /// Deletes a model-specific endpoint for a previously-trained custom model. All endpoints
        /// must be deleted in order for the model to be deleted. For information about endpoints,
        /// see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/manage-endpoints.html">Managing
        /// endpoints</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
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
        public virtual DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        public virtual IAsyncResult BeginDeleteEndpoint(DeleteEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        public virtual DeleteEndpointResponse EndDeleteEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEntityRecognizer

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
        public virtual DeleteEntityRecognizerResponse DeleteEntityRecognizer(DeleteEntityRecognizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEntityRecognizerResponseUnmarshaller.Instance;

            return Invoke<DeleteEntityRecognizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEntityRecognizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEntityRecognizer operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEntityRecognizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DeleteEntityRecognizer">REST API Reference for DeleteEntityRecognizer Operation</seealso>
        public virtual IAsyncResult BeginDeleteEntityRecognizer(DeleteEntityRecognizerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEntityRecognizerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEntityRecognizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEntityRecognizer.</param>
        /// 
        /// <returns>Returns a  DeleteEntityRecognizerResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DeleteEntityRecognizer">REST API Reference for DeleteEntityRecognizer Operation</seealso>
        public virtual DeleteEntityRecognizerResponse EndDeleteEntityRecognizer(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEntityRecognizerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteResourcePolicy

        /// <summary>
        /// Deletes a resource-based policy that is attached to a custom model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
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
        public virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDocumentClassificationJob

        /// <summary>
        /// Gets the properties associated with a document classification job. Use this operation
        /// to get the status of a classification job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentClassificationJob service method.</param>
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
        public virtual DescribeDocumentClassificationJobResponse DescribeDocumentClassificationJob(DescribeDocumentClassificationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDocumentClassificationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDocumentClassificationJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDocumentClassificationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDocumentClassificationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentClassificationJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDocumentClassificationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeDocumentClassificationJob">REST API Reference for DescribeDocumentClassificationJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeDocumentClassificationJob(DescribeDocumentClassificationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDocumentClassificationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDocumentClassificationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDocumentClassificationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDocumentClassificationJob.</param>
        /// 
        /// <returns>Returns a  DescribeDocumentClassificationJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeDocumentClassificationJob">REST API Reference for DescribeDocumentClassificationJob Operation</seealso>
        public virtual DescribeDocumentClassificationJobResponse EndDescribeDocumentClassificationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDocumentClassificationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDocumentClassifier

        /// <summary>
        /// Gets the properties associated with a document classifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentClassifier service method.</param>
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
        public virtual DescribeDocumentClassifierResponse DescribeDocumentClassifier(DescribeDocumentClassifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDocumentClassifierResponseUnmarshaller.Instance;

            return Invoke<DescribeDocumentClassifierResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDocumentClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDocumentClassifier operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDocumentClassifier
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeDocumentClassifier">REST API Reference for DescribeDocumentClassifier Operation</seealso>
        public virtual IAsyncResult BeginDescribeDocumentClassifier(DescribeDocumentClassifierRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDocumentClassifierResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDocumentClassifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDocumentClassifier.</param>
        /// 
        /// <returns>Returns a  DescribeDocumentClassifierResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeDocumentClassifier">REST API Reference for DescribeDocumentClassifier Operation</seealso>
        public virtual DescribeDocumentClassifierResponse EndDescribeDocumentClassifier(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDocumentClassifierResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDominantLanguageDetectionJob

        /// <summary>
        /// Gets the properties associated with a dominant language detection job. Use this operation
        /// to get the status of a detection job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDominantLanguageDetectionJob service method.</param>
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
        public virtual DescribeDominantLanguageDetectionJobResponse DescribeDominantLanguageDetectionJob(DescribeDominantLanguageDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDominantLanguageDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDominantLanguageDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDominantLanguageDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDominantLanguageDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDominantLanguageDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeDominantLanguageDetectionJob">REST API Reference for DescribeDominantLanguageDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeDominantLanguageDetectionJob(DescribeDominantLanguageDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDominantLanguageDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDominantLanguageDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDominantLanguageDetectionJob.</param>
        /// 
        /// <returns>Returns a  DescribeDominantLanguageDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeDominantLanguageDetectionJob">REST API Reference for DescribeDominantLanguageDetectionJob Operation</seealso>
        public virtual DescribeDominantLanguageDetectionJobResponse EndDescribeDominantLanguageDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDominantLanguageDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEndpoint

        /// <summary>
        /// Gets the properties associated with a specific endpoint. Use this operation to get
        /// the status of an endpoint. For information about endpoints, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/manage-endpoints.html">Managing
        /// endpoints</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint service method.</param>
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
        public virtual DescribeEndpointResponse DescribeEndpoint(DescribeEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        public virtual IAsyncResult BeginDescribeEndpoint(DescribeEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpoint.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        public virtual DescribeEndpointResponse EndDescribeEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEntitiesDetectionJob

        /// <summary>
        /// Gets the properties associated with an entities detection job. Use this operation
        /// to get the status of a detection job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntitiesDetectionJob service method.</param>
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
        public virtual DescribeEntitiesDetectionJobResponse DescribeEntitiesDetectionJob(DescribeEntitiesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntitiesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeEntitiesDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEntitiesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntitiesDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEntitiesDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeEntitiesDetectionJob">REST API Reference for DescribeEntitiesDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeEntitiesDetectionJob(DescribeEntitiesDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntitiesDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEntitiesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEntitiesDetectionJob.</param>
        /// 
        /// <returns>Returns a  DescribeEntitiesDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeEntitiesDetectionJob">REST API Reference for DescribeEntitiesDetectionJob Operation</seealso>
        public virtual DescribeEntitiesDetectionJobResponse EndDescribeEntitiesDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEntitiesDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEntityRecognizer

        /// <summary>
        /// Provides details about an entity recognizer including status, S3 buckets containing
        /// training data, recognizer metadata, metrics, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntityRecognizer service method.</param>
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
        public virtual DescribeEntityRecognizerResponse DescribeEntityRecognizer(DescribeEntityRecognizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntityRecognizerResponseUnmarshaller.Instance;

            return Invoke<DescribeEntityRecognizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEntityRecognizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntityRecognizer operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEntityRecognizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeEntityRecognizer">REST API Reference for DescribeEntityRecognizer Operation</seealso>
        public virtual IAsyncResult BeginDescribeEntityRecognizer(DescribeEntityRecognizerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEntityRecognizerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEntityRecognizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEntityRecognizer.</param>
        /// 
        /// <returns>Returns a  DescribeEntityRecognizerResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeEntityRecognizer">REST API Reference for DescribeEntityRecognizer Operation</seealso>
        public virtual DescribeEntityRecognizerResponse EndDescribeEntityRecognizer(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEntityRecognizerResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEventsDetectionJob

        /// <summary>
        /// Gets the status and details of an events detection job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventsDetectionJob service method.</param>
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
        public virtual DescribeEventsDetectionJobResponse DescribeEventsDetectionJob(DescribeEventsDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventsDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventsDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventsDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeEventsDetectionJob">REST API Reference for DescribeEventsDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeEventsDetectionJob(DescribeEventsDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventsDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventsDetectionJob.</param>
        /// 
        /// <returns>Returns a  DescribeEventsDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeEventsDetectionJob">REST API Reference for DescribeEventsDetectionJob Operation</seealso>
        public virtual DescribeEventsDetectionJobResponse EndDescribeEventsDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEventsDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeKeyPhrasesDetectionJob

        /// <summary>
        /// Gets the properties associated with a key phrases detection job. Use this operation
        /// to get the status of a detection job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyPhrasesDetectionJob service method.</param>
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
        public virtual DescribeKeyPhrasesDetectionJobResponse DescribeKeyPhrasesDetectionJob(DescribeKeyPhrasesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeKeyPhrasesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeKeyPhrasesDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKeyPhrasesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyPhrasesDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeKeyPhrasesDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeKeyPhrasesDetectionJob">REST API Reference for DescribeKeyPhrasesDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeKeyPhrasesDetectionJob(DescribeKeyPhrasesDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeKeyPhrasesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeKeyPhrasesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeKeyPhrasesDetectionJob.</param>
        /// 
        /// <returns>Returns a  DescribeKeyPhrasesDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeKeyPhrasesDetectionJob">REST API Reference for DescribeKeyPhrasesDetectionJob Operation</seealso>
        public virtual DescribeKeyPhrasesDetectionJobResponse EndDescribeKeyPhrasesDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeKeyPhrasesDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePiiEntitiesDetectionJob

        /// <summary>
        /// Gets the properties associated with a PII entities detection job. For example, you
        /// can use this operation to get the job status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePiiEntitiesDetectionJob service method.</param>
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
        public virtual DescribePiiEntitiesDetectionJobResponse DescribePiiEntitiesDetectionJob(DescribePiiEntitiesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePiiEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePiiEntitiesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribePiiEntitiesDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePiiEntitiesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePiiEntitiesDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePiiEntitiesDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribePiiEntitiesDetectionJob">REST API Reference for DescribePiiEntitiesDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginDescribePiiEntitiesDetectionJob(DescribePiiEntitiesDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePiiEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePiiEntitiesDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePiiEntitiesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePiiEntitiesDetectionJob.</param>
        /// 
        /// <returns>Returns a  DescribePiiEntitiesDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribePiiEntitiesDetectionJob">REST API Reference for DescribePiiEntitiesDetectionJob Operation</seealso>
        public virtual DescribePiiEntitiesDetectionJobResponse EndDescribePiiEntitiesDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePiiEntitiesDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeResourcePolicy

        /// <summary>
        /// Gets the details of a resource-based policy that is attached to a custom model, including
        /// the JSON body of the policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePolicy service method.</param>
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
        public virtual DescribeResourcePolicyResponse DescribeResourcePolicy(DescribeResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DescribeResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePolicy operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeResourcePolicy">REST API Reference for DescribeResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginDescribeResourcePolicy(DescribeResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DescribeResourcePolicyResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeResourcePolicy">REST API Reference for DescribeResourcePolicy Operation</seealso>
        public virtual DescribeResourcePolicyResponse EndDescribeResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSentimentDetectionJob

        /// <summary>
        /// Gets the properties associated with a sentiment detection job. Use this operation
        /// to get the status of a detection job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSentimentDetectionJob service method.</param>
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
        public virtual DescribeSentimentDetectionJobResponse DescribeSentimentDetectionJob(DescribeSentimentDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSentimentDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeSentimentDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSentimentDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSentimentDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSentimentDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeSentimentDetectionJob">REST API Reference for DescribeSentimentDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeSentimentDetectionJob(DescribeSentimentDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSentimentDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSentimentDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSentimentDetectionJob.</param>
        /// 
        /// <returns>Returns a  DescribeSentimentDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeSentimentDetectionJob">REST API Reference for DescribeSentimentDetectionJob Operation</seealso>
        public virtual DescribeSentimentDetectionJobResponse EndDescribeSentimentDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSentimentDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTargetedSentimentDetectionJob

        /// <summary>
        /// Gets the properties associated with a targeted sentiment detection job. Use this operation
        /// to get the status of the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetedSentimentDetectionJob service method.</param>
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
        public virtual DescribeTargetedSentimentDetectionJobResponse DescribeTargetedSentimentDetectionJob(DescribeTargetedSentimentDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTargetedSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTargetedSentimentDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeTargetedSentimentDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTargetedSentimentDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetedSentimentDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTargetedSentimentDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeTargetedSentimentDetectionJob">REST API Reference for DescribeTargetedSentimentDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeTargetedSentimentDetectionJob(DescribeTargetedSentimentDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTargetedSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTargetedSentimentDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTargetedSentimentDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTargetedSentimentDetectionJob.</param>
        /// 
        /// <returns>Returns a  DescribeTargetedSentimentDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeTargetedSentimentDetectionJob">REST API Reference for DescribeTargetedSentimentDetectionJob Operation</seealso>
        public virtual DescribeTargetedSentimentDetectionJobResponse EndDescribeTargetedSentimentDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTargetedSentimentDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTopicsDetectionJob

        /// <summary>
        /// Gets the properties associated with a topic detection job. Use this operation to get
        /// the status of a detection job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopicsDetectionJob service method.</param>
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
        public virtual DescribeTopicsDetectionJobResponse DescribeTopicsDetectionJob(DescribeTopicsDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTopicsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTopicsDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeTopicsDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTopicsDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTopicsDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTopicsDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeTopicsDetectionJob">REST API Reference for DescribeTopicsDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginDescribeTopicsDetectionJob(DescribeTopicsDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTopicsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTopicsDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTopicsDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTopicsDetectionJob.</param>
        /// 
        /// <returns>Returns a  DescribeTopicsDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeTopicsDetectionJob">REST API Reference for DescribeTopicsDetectionJob Operation</seealso>
        public virtual DescribeTopicsDetectionJobResponse EndDescribeTopicsDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTopicsDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  DetectDominantLanguage

        /// <summary>
        /// Determines the dominant language of the input text. For a list of languages that Amazon
        /// Comprehend can detect, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-languages.html">Amazon
        /// Comprehend Supported Languages</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectDominantLanguage service method.</param>
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
        public virtual DetectDominantLanguageResponse DetectDominantLanguage(DetectDominantLanguageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectDominantLanguageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectDominantLanguageResponseUnmarshaller.Instance;

            return Invoke<DetectDominantLanguageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetectDominantLanguage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectDominantLanguage operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectDominantLanguage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectDominantLanguage">REST API Reference for DetectDominantLanguage Operation</seealso>
        public virtual IAsyncResult BeginDetectDominantLanguage(DetectDominantLanguageRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectDominantLanguageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectDominantLanguageResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetectDominantLanguage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectDominantLanguage.</param>
        /// 
        /// <returns>Returns a  DetectDominantLanguageResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectDominantLanguage">REST API Reference for DetectDominantLanguage Operation</seealso>
        public virtual DetectDominantLanguageResponse EndDetectDominantLanguage(IAsyncResult asyncResult)
        {
            return EndInvoke<DetectDominantLanguageResponse>(asyncResult);
        }

        #endregion
        
        #region  DetectEntities

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
        public virtual DetectEntitiesResponse DetectEntities(DetectEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectEntitiesResponseUnmarshaller.Instance;

            return Invoke<DetectEntitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetectEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectEntities operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectEntities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectEntities">REST API Reference for DetectEntities Operation</seealso>
        public virtual IAsyncResult BeginDetectEntities(DetectEntitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectEntitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetectEntities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectEntities.</param>
        /// 
        /// <returns>Returns a  DetectEntitiesResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectEntities">REST API Reference for DetectEntities Operation</seealso>
        public virtual DetectEntitiesResponse EndDetectEntities(IAsyncResult asyncResult)
        {
            return EndInvoke<DetectEntitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  DetectKeyPhrases

        /// <summary>
        /// Detects the key noun phrases found in the text.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectKeyPhrases service method.</param>
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
        public virtual DetectKeyPhrasesResponse DetectKeyPhrases(DetectKeyPhrasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectKeyPhrasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectKeyPhrasesResponseUnmarshaller.Instance;

            return Invoke<DetectKeyPhrasesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetectKeyPhrases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectKeyPhrases operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectKeyPhrases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectKeyPhrases">REST API Reference for DetectKeyPhrases Operation</seealso>
        public virtual IAsyncResult BeginDetectKeyPhrases(DetectKeyPhrasesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectKeyPhrasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectKeyPhrasesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetectKeyPhrases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectKeyPhrases.</param>
        /// 
        /// <returns>Returns a  DetectKeyPhrasesResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectKeyPhrases">REST API Reference for DetectKeyPhrases Operation</seealso>
        public virtual DetectKeyPhrasesResponse EndDetectKeyPhrases(IAsyncResult asyncResult)
        {
            return EndInvoke<DetectKeyPhrasesResponse>(asyncResult);
        }

        #endregion
        
        #region  DetectPiiEntities

        /// <summary>
        /// Inspects the input text for entities that contain personally identifiable information
        /// (PII) and returns information about them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectPiiEntities service method.</param>
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
        public virtual DetectPiiEntitiesResponse DetectPiiEntities(DetectPiiEntitiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectPiiEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectPiiEntitiesResponseUnmarshaller.Instance;

            return Invoke<DetectPiiEntitiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetectPiiEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectPiiEntities operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectPiiEntities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectPiiEntities">REST API Reference for DetectPiiEntities Operation</seealso>
        public virtual IAsyncResult BeginDetectPiiEntities(DetectPiiEntitiesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectPiiEntitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectPiiEntitiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetectPiiEntities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectPiiEntities.</param>
        /// 
        /// <returns>Returns a  DetectPiiEntitiesResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectPiiEntities">REST API Reference for DetectPiiEntities Operation</seealso>
        public virtual DetectPiiEntitiesResponse EndDetectPiiEntities(IAsyncResult asyncResult)
        {
            return EndInvoke<DetectPiiEntitiesResponse>(asyncResult);
        }

        #endregion
        
        #region  DetectSentiment

        /// <summary>
        /// Inspects text and returns an inference of the prevailing sentiment (<code>POSITIVE</code>,
        /// <code>NEUTRAL</code>, <code>MIXED</code>, or <code>NEGATIVE</code>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectSentiment service method.</param>
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
        public virtual DetectSentimentResponse DetectSentiment(DetectSentimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectSentimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectSentimentResponseUnmarshaller.Instance;

            return Invoke<DetectSentimentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetectSentiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectSentiment operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectSentiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectSentiment">REST API Reference for DetectSentiment Operation</seealso>
        public virtual IAsyncResult BeginDetectSentiment(DetectSentimentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectSentimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectSentimentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetectSentiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectSentiment.</param>
        /// 
        /// <returns>Returns a  DetectSentimentResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectSentiment">REST API Reference for DetectSentiment Operation</seealso>
        public virtual DetectSentimentResponse EndDetectSentiment(IAsyncResult asyncResult)
        {
            return EndInvoke<DetectSentimentResponse>(asyncResult);
        }

        #endregion
        
        #region  DetectSyntax

        /// <summary>
        /// Inspects text for syntax and the part of speech of words in the document. For more
        /// information, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-syntax.html">Syntax</a>
        /// in the Comprehend Developer Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectSyntax service method.</param>
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
        public virtual DetectSyntaxResponse DetectSyntax(DetectSyntaxRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectSyntaxRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectSyntaxResponseUnmarshaller.Instance;

            return Invoke<DetectSyntaxResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetectSyntax operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectSyntax operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectSyntax
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectSyntax">REST API Reference for DetectSyntax Operation</seealso>
        public virtual IAsyncResult BeginDetectSyntax(DetectSyntaxRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectSyntaxRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectSyntaxResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetectSyntax operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectSyntax.</param>
        /// 
        /// <returns>Returns a  DetectSyntaxResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectSyntax">REST API Reference for DetectSyntax Operation</seealso>
        public virtual DetectSyntaxResponse EndDetectSyntax(IAsyncResult asyncResult)
        {
            return EndInvoke<DetectSyntaxResponse>(asyncResult);
        }

        #endregion
        
        #region  DetectTargetedSentiment

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
        public virtual DetectTargetedSentimentResponse DetectTargetedSentiment(DetectTargetedSentimentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectTargetedSentimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectTargetedSentimentResponseUnmarshaller.Instance;

            return Invoke<DetectTargetedSentimentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetectTargetedSentiment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectTargetedSentiment operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetectTargetedSentiment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectTargetedSentiment">REST API Reference for DetectTargetedSentiment Operation</seealso>
        public virtual IAsyncResult BeginDetectTargetedSentiment(DetectTargetedSentimentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetectTargetedSentimentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetectTargetedSentimentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetectTargetedSentiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectTargetedSentiment.</param>
        /// 
        /// <returns>Returns a  DetectTargetedSentimentResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectTargetedSentiment">REST API Reference for DetectTargetedSentiment Operation</seealso>
        public virtual DetectTargetedSentimentResponse EndDetectTargetedSentiment(IAsyncResult asyncResult)
        {
            return EndInvoke<DetectTargetedSentimentResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportModel

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
        public virtual ImportModelResponse ImportModel(ImportModelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportModelResponseUnmarshaller.Instance;

            return Invoke<ImportModelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportModel operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ImportModel">REST API Reference for ImportModel Operation</seealso>
        public virtual IAsyncResult BeginImportModel(ImportModelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportModelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportModelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportModel.</param>
        /// 
        /// <returns>Returns a  ImportModelResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ImportModel">REST API Reference for ImportModel Operation</seealso>
        public virtual ImportModelResponse EndImportModel(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportModelResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDocumentClassificationJobs

        /// <summary>
        /// Gets a list of the documentation classification jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentClassificationJobs service method.</param>
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
        public virtual ListDocumentClassificationJobsResponse ListDocumentClassificationJobs(ListDocumentClassificationJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentClassificationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentClassificationJobsResponseUnmarshaller.Instance;

            return Invoke<ListDocumentClassificationJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDocumentClassificationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentClassificationJobs operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDocumentClassificationJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDocumentClassificationJobs">REST API Reference for ListDocumentClassificationJobs Operation</seealso>
        public virtual IAsyncResult BeginListDocumentClassificationJobs(ListDocumentClassificationJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentClassificationJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentClassificationJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDocumentClassificationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDocumentClassificationJobs.</param>
        /// 
        /// <returns>Returns a  ListDocumentClassificationJobsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDocumentClassificationJobs">REST API Reference for ListDocumentClassificationJobs Operation</seealso>
        public virtual ListDocumentClassificationJobsResponse EndListDocumentClassificationJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDocumentClassificationJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDocumentClassifiers

        /// <summary>
        /// Gets a list of the document classifiers that you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentClassifiers service method.</param>
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
        public virtual ListDocumentClassifiersResponse ListDocumentClassifiers(ListDocumentClassifiersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentClassifiersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentClassifiersResponseUnmarshaller.Instance;

            return Invoke<ListDocumentClassifiersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDocumentClassifiers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentClassifiers operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDocumentClassifiers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDocumentClassifiers">REST API Reference for ListDocumentClassifiers Operation</seealso>
        public virtual IAsyncResult BeginListDocumentClassifiers(ListDocumentClassifiersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentClassifiersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentClassifiersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDocumentClassifiers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDocumentClassifiers.</param>
        /// 
        /// <returns>Returns a  ListDocumentClassifiersResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDocumentClassifiers">REST API Reference for ListDocumentClassifiers Operation</seealso>
        public virtual ListDocumentClassifiersResponse EndListDocumentClassifiers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDocumentClassifiersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDocumentClassifierSummaries

        /// <summary>
        /// Gets a list of summaries of the document classifiers that you have created
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentClassifierSummaries service method.</param>
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
        public virtual ListDocumentClassifierSummariesResponse ListDocumentClassifierSummaries(ListDocumentClassifierSummariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentClassifierSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentClassifierSummariesResponseUnmarshaller.Instance;

            return Invoke<ListDocumentClassifierSummariesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDocumentClassifierSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDocumentClassifierSummaries operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDocumentClassifierSummaries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDocumentClassifierSummaries">REST API Reference for ListDocumentClassifierSummaries Operation</seealso>
        public virtual IAsyncResult BeginListDocumentClassifierSummaries(ListDocumentClassifierSummariesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDocumentClassifierSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDocumentClassifierSummariesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDocumentClassifierSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDocumentClassifierSummaries.</param>
        /// 
        /// <returns>Returns a  ListDocumentClassifierSummariesResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDocumentClassifierSummaries">REST API Reference for ListDocumentClassifierSummaries Operation</seealso>
        public virtual ListDocumentClassifierSummariesResponse EndListDocumentClassifierSummaries(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDocumentClassifierSummariesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDominantLanguageDetectionJobs

        /// <summary>
        /// Gets a list of the dominant language detection jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDominantLanguageDetectionJobs service method.</param>
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
        public virtual ListDominantLanguageDetectionJobsResponse ListDominantLanguageDetectionJobs(ListDominantLanguageDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDominantLanguageDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDominantLanguageDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListDominantLanguageDetectionJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDominantLanguageDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDominantLanguageDetectionJobs operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDominantLanguageDetectionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDominantLanguageDetectionJobs">REST API Reference for ListDominantLanguageDetectionJobs Operation</seealso>
        public virtual IAsyncResult BeginListDominantLanguageDetectionJobs(ListDominantLanguageDetectionJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDominantLanguageDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDominantLanguageDetectionJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDominantLanguageDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDominantLanguageDetectionJobs.</param>
        /// 
        /// <returns>Returns a  ListDominantLanguageDetectionJobsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDominantLanguageDetectionJobs">REST API Reference for ListDominantLanguageDetectionJobs Operation</seealso>
        public virtual ListDominantLanguageDetectionJobsResponse EndListDominantLanguageDetectionJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDominantLanguageDetectionJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEndpoints

        /// <summary>
        /// Gets a list of all existing endpoints that you've created. For information about endpoints,
        /// see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/manage-endpoints.html">Managing
        /// endpoints</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints service method.</param>
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
        public virtual ListEndpointsResponse ListEndpoints(ListEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListEndpointsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        public virtual IAsyncResult BeginListEndpoints(ListEndpointsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEndpoints.</param>
        /// 
        /// <returns>Returns a  ListEndpointsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        public virtual ListEndpointsResponse EndListEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEndpointsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEntitiesDetectionJobs

        /// <summary>
        /// Gets a list of the entity detection jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntitiesDetectionJobs service method.</param>
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
        public virtual ListEntitiesDetectionJobsResponse ListEntitiesDetectionJobs(ListEntitiesDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntitiesDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitiesDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListEntitiesDetectionJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEntitiesDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEntitiesDetectionJobs operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEntitiesDetectionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEntitiesDetectionJobs">REST API Reference for ListEntitiesDetectionJobs Operation</seealso>
        public virtual IAsyncResult BeginListEntitiesDetectionJobs(ListEntitiesDetectionJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntitiesDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntitiesDetectionJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEntitiesDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEntitiesDetectionJobs.</param>
        /// 
        /// <returns>Returns a  ListEntitiesDetectionJobsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEntitiesDetectionJobs">REST API Reference for ListEntitiesDetectionJobs Operation</seealso>
        public virtual ListEntitiesDetectionJobsResponse EndListEntitiesDetectionJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEntitiesDetectionJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEntityRecognizers

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
        public virtual ListEntityRecognizersResponse ListEntityRecognizers(ListEntityRecognizersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntityRecognizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntityRecognizersResponseUnmarshaller.Instance;

            return Invoke<ListEntityRecognizersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEntityRecognizers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEntityRecognizers operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEntityRecognizers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEntityRecognizers">REST API Reference for ListEntityRecognizers Operation</seealso>
        public virtual IAsyncResult BeginListEntityRecognizers(ListEntityRecognizersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntityRecognizersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntityRecognizersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEntityRecognizers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEntityRecognizers.</param>
        /// 
        /// <returns>Returns a  ListEntityRecognizersResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEntityRecognizers">REST API Reference for ListEntityRecognizers Operation</seealso>
        public virtual ListEntityRecognizersResponse EndListEntityRecognizers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEntityRecognizersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEntityRecognizerSummaries

        /// <summary>
        /// Gets a list of summaries for the entity recognizers that you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntityRecognizerSummaries service method.</param>
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
        public virtual ListEntityRecognizerSummariesResponse ListEntityRecognizerSummaries(ListEntityRecognizerSummariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntityRecognizerSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntityRecognizerSummariesResponseUnmarshaller.Instance;

            return Invoke<ListEntityRecognizerSummariesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEntityRecognizerSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEntityRecognizerSummaries operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEntityRecognizerSummaries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEntityRecognizerSummaries">REST API Reference for ListEntityRecognizerSummaries Operation</seealso>
        public virtual IAsyncResult BeginListEntityRecognizerSummaries(ListEntityRecognizerSummariesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEntityRecognizerSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEntityRecognizerSummariesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEntityRecognizerSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEntityRecognizerSummaries.</param>
        /// 
        /// <returns>Returns a  ListEntityRecognizerSummariesResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEntityRecognizerSummaries">REST API Reference for ListEntityRecognizerSummaries Operation</seealso>
        public virtual ListEntityRecognizerSummariesResponse EndListEntityRecognizerSummaries(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEntityRecognizerSummariesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEventsDetectionJobs

        /// <summary>
        /// Gets a list of the events detection jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventsDetectionJobs service method.</param>
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
        public virtual ListEventsDetectionJobsResponse ListEventsDetectionJobs(ListEventsDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventsDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventsDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListEventsDetectionJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventsDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventsDetectionJobs operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventsDetectionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEventsDetectionJobs">REST API Reference for ListEventsDetectionJobs Operation</seealso>
        public virtual IAsyncResult BeginListEventsDetectionJobs(ListEventsDetectionJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEventsDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEventsDetectionJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventsDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventsDetectionJobs.</param>
        /// 
        /// <returns>Returns a  ListEventsDetectionJobsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEventsDetectionJobs">REST API Reference for ListEventsDetectionJobs Operation</seealso>
        public virtual ListEventsDetectionJobsResponse EndListEventsDetectionJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEventsDetectionJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListKeyPhrasesDetectionJobs

        /// <summary>
        /// Get a list of key phrase detection jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeyPhrasesDetectionJobs service method.</param>
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
        public virtual ListKeyPhrasesDetectionJobsResponse ListKeyPhrasesDetectionJobs(ListKeyPhrasesDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeyPhrasesDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeyPhrasesDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListKeyPhrasesDetectionJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListKeyPhrasesDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeyPhrasesDetectionJobs operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKeyPhrasesDetectionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListKeyPhrasesDetectionJobs">REST API Reference for ListKeyPhrasesDetectionJobs Operation</seealso>
        public virtual IAsyncResult BeginListKeyPhrasesDetectionJobs(ListKeyPhrasesDetectionJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeyPhrasesDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeyPhrasesDetectionJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListKeyPhrasesDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKeyPhrasesDetectionJobs.</param>
        /// 
        /// <returns>Returns a  ListKeyPhrasesDetectionJobsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListKeyPhrasesDetectionJobs">REST API Reference for ListKeyPhrasesDetectionJobs Operation</seealso>
        public virtual ListKeyPhrasesDetectionJobsResponse EndListKeyPhrasesDetectionJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListKeyPhrasesDetectionJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPiiEntitiesDetectionJobs

        /// <summary>
        /// Gets a list of the PII entity detection jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPiiEntitiesDetectionJobs service method.</param>
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
        public virtual ListPiiEntitiesDetectionJobsResponse ListPiiEntitiesDetectionJobs(ListPiiEntitiesDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPiiEntitiesDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPiiEntitiesDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListPiiEntitiesDetectionJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPiiEntitiesDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPiiEntitiesDetectionJobs operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPiiEntitiesDetectionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListPiiEntitiesDetectionJobs">REST API Reference for ListPiiEntitiesDetectionJobs Operation</seealso>
        public virtual IAsyncResult BeginListPiiEntitiesDetectionJobs(ListPiiEntitiesDetectionJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPiiEntitiesDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPiiEntitiesDetectionJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPiiEntitiesDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPiiEntitiesDetectionJobs.</param>
        /// 
        /// <returns>Returns a  ListPiiEntitiesDetectionJobsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListPiiEntitiesDetectionJobs">REST API Reference for ListPiiEntitiesDetectionJobs Operation</seealso>
        public virtual ListPiiEntitiesDetectionJobsResponse EndListPiiEntitiesDetectionJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPiiEntitiesDetectionJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSentimentDetectionJobs

        /// <summary>
        /// Gets a list of sentiment detection jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSentimentDetectionJobs service method.</param>
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
        public virtual ListSentimentDetectionJobsResponse ListSentimentDetectionJobs(ListSentimentDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSentimentDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSentimentDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListSentimentDetectionJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSentimentDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSentimentDetectionJobs operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSentimentDetectionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListSentimentDetectionJobs">REST API Reference for ListSentimentDetectionJobs Operation</seealso>
        public virtual IAsyncResult BeginListSentimentDetectionJobs(ListSentimentDetectionJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSentimentDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSentimentDetectionJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSentimentDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSentimentDetectionJobs.</param>
        /// 
        /// <returns>Returns a  ListSentimentDetectionJobsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListSentimentDetectionJobs">REST API Reference for ListSentimentDetectionJobs Operation</seealso>
        public virtual ListSentimentDetectionJobsResponse EndListSentimentDetectionJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSentimentDetectionJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists all tags associated with a given Amazon Comprehend resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTargetedSentimentDetectionJobs

        /// <summary>
        /// Gets a list of targeted sentiment detection jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetedSentimentDetectionJobs service method.</param>
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
        public virtual ListTargetedSentimentDetectionJobsResponse ListTargetedSentimentDetectionJobs(ListTargetedSentimentDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTargetedSentimentDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetedSentimentDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListTargetedSentimentDetectionJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTargetedSentimentDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTargetedSentimentDetectionJobs operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTargetedSentimentDetectionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListTargetedSentimentDetectionJobs">REST API Reference for ListTargetedSentimentDetectionJobs Operation</seealso>
        public virtual IAsyncResult BeginListTargetedSentimentDetectionJobs(ListTargetedSentimentDetectionJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTargetedSentimentDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTargetedSentimentDetectionJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTargetedSentimentDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTargetedSentimentDetectionJobs.</param>
        /// 
        /// <returns>Returns a  ListTargetedSentimentDetectionJobsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListTargetedSentimentDetectionJobs">REST API Reference for ListTargetedSentimentDetectionJobs Operation</seealso>
        public virtual ListTargetedSentimentDetectionJobsResponse EndListTargetedSentimentDetectionJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTargetedSentimentDetectionJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTopicsDetectionJobs

        /// <summary>
        /// Gets a list of the topic detection jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopicsDetectionJobs service method.</param>
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
        public virtual ListTopicsDetectionJobsResponse ListTopicsDetectionJobs(ListTopicsDetectionJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTopicsDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTopicsDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListTopicsDetectionJobsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTopicsDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTopicsDetectionJobs operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTopicsDetectionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListTopicsDetectionJobs">REST API Reference for ListTopicsDetectionJobs Operation</seealso>
        public virtual IAsyncResult BeginListTopicsDetectionJobs(ListTopicsDetectionJobsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTopicsDetectionJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTopicsDetectionJobsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTopicsDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTopicsDetectionJobs.</param>
        /// 
        /// <returns>Returns a  ListTopicsDetectionJobsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListTopicsDetectionJobs">REST API Reference for ListTopicsDetectionJobs Operation</seealso>
        public virtual ListTopicsDetectionJobsResponse EndListTopicsDetectionJobs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTopicsDetectionJobsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutResourcePolicy

        /// <summary>
        /// Attaches a resource-based policy to a custom model. You can use this policy to authorize
        /// an entity in another AWS account to import the custom model, which replicates it in
        /// Amazon Comprehend in their account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
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
        public virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDocumentClassificationJob

        /// <summary>
        /// Starts an asynchronous document classification job. Use the operation to track the
        /// progress of the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDocumentClassificationJob service method.</param>
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
        public virtual StartDocumentClassificationJobResponse StartDocumentClassificationJob(StartDocumentClassificationJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDocumentClassificationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDocumentClassificationJobResponseUnmarshaller.Instance;

            return Invoke<StartDocumentClassificationJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDocumentClassificationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDocumentClassificationJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDocumentClassificationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartDocumentClassificationJob">REST API Reference for StartDocumentClassificationJob Operation</seealso>
        public virtual IAsyncResult BeginStartDocumentClassificationJob(StartDocumentClassificationJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDocumentClassificationJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDocumentClassificationJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDocumentClassificationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDocumentClassificationJob.</param>
        /// 
        /// <returns>Returns a  StartDocumentClassificationJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartDocumentClassificationJob">REST API Reference for StartDocumentClassificationJob Operation</seealso>
        public virtual StartDocumentClassificationJobResponse EndStartDocumentClassificationJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDocumentClassificationJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartDominantLanguageDetectionJob

        /// <summary>
        /// Starts an asynchronous dominant language detection job for a collection of documents.
        /// Use the operation to track the status of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDominantLanguageDetectionJob service method.</param>
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
        public virtual StartDominantLanguageDetectionJobResponse StartDominantLanguageDetectionJob(StartDominantLanguageDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDominantLanguageDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartDominantLanguageDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartDominantLanguageDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDominantLanguageDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDominantLanguageDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartDominantLanguageDetectionJob">REST API Reference for StartDominantLanguageDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginStartDominantLanguageDetectionJob(StartDominantLanguageDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartDominantLanguageDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartDominantLanguageDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDominantLanguageDetectionJob.</param>
        /// 
        /// <returns>Returns a  StartDominantLanguageDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartDominantLanguageDetectionJob">REST API Reference for StartDominantLanguageDetectionJob Operation</seealso>
        public virtual StartDominantLanguageDetectionJobResponse EndStartDominantLanguageDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartDominantLanguageDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartEntitiesDetectionJob

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
        public virtual StartEntitiesDetectionJobResponse StartEntitiesDetectionJob(StartEntitiesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEntitiesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartEntitiesDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartEntitiesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartEntitiesDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartEntitiesDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartEntitiesDetectionJob">REST API Reference for StartEntitiesDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginStartEntitiesDetectionJob(StartEntitiesDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEntitiesDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartEntitiesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartEntitiesDetectionJob.</param>
        /// 
        /// <returns>Returns a  StartEntitiesDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartEntitiesDetectionJob">REST API Reference for StartEntitiesDetectionJob Operation</seealso>
        public virtual StartEntitiesDetectionJobResponse EndStartEntitiesDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartEntitiesDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartEventsDetectionJob

        /// <summary>
        /// Starts an asynchronous event detection job for a collection of documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartEventsDetectionJob service method.</param>
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
        public virtual StartEventsDetectionJobResponse StartEventsDetectionJob(StartEventsDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEventsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEventsDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartEventsDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartEventsDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartEventsDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartEventsDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartEventsDetectionJob">REST API Reference for StartEventsDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginStartEventsDetectionJob(StartEventsDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartEventsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartEventsDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartEventsDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartEventsDetectionJob.</param>
        /// 
        /// <returns>Returns a  StartEventsDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartEventsDetectionJob">REST API Reference for StartEventsDetectionJob Operation</seealso>
        public virtual StartEventsDetectionJobResponse EndStartEventsDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartEventsDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartKeyPhrasesDetectionJob

        /// <summary>
        /// Starts an asynchronous key phrase detection job for a collection of documents. Use
        /// the operation to track the status of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartKeyPhrasesDetectionJob service method.</param>
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
        public virtual StartKeyPhrasesDetectionJobResponse StartKeyPhrasesDetectionJob(StartKeyPhrasesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartKeyPhrasesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartKeyPhrasesDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartKeyPhrasesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartKeyPhrasesDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartKeyPhrasesDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartKeyPhrasesDetectionJob">REST API Reference for StartKeyPhrasesDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginStartKeyPhrasesDetectionJob(StartKeyPhrasesDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartKeyPhrasesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartKeyPhrasesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartKeyPhrasesDetectionJob.</param>
        /// 
        /// <returns>Returns a  StartKeyPhrasesDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartKeyPhrasesDetectionJob">REST API Reference for StartKeyPhrasesDetectionJob Operation</seealso>
        public virtual StartKeyPhrasesDetectionJobResponse EndStartKeyPhrasesDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartKeyPhrasesDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartPiiEntitiesDetectionJob

        /// <summary>
        /// Starts an asynchronous PII entity detection job for a collection of documents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPiiEntitiesDetectionJob service method.</param>
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
        public virtual StartPiiEntitiesDetectionJobResponse StartPiiEntitiesDetectionJob(StartPiiEntitiesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPiiEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPiiEntitiesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartPiiEntitiesDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartPiiEntitiesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPiiEntitiesDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartPiiEntitiesDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartPiiEntitiesDetectionJob">REST API Reference for StartPiiEntitiesDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginStartPiiEntitiesDetectionJob(StartPiiEntitiesDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartPiiEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartPiiEntitiesDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartPiiEntitiesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartPiiEntitiesDetectionJob.</param>
        /// 
        /// <returns>Returns a  StartPiiEntitiesDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartPiiEntitiesDetectionJob">REST API Reference for StartPiiEntitiesDetectionJob Operation</seealso>
        public virtual StartPiiEntitiesDetectionJobResponse EndStartPiiEntitiesDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartPiiEntitiesDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartSentimentDetectionJob

        /// <summary>
        /// Starts an asynchronous sentiment detection job for a collection of documents. Use
        /// the operation to track the status of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSentimentDetectionJob service method.</param>
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
        public virtual StartSentimentDetectionJobResponse StartSentimentDetectionJob(StartSentimentDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSentimentDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartSentimentDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartSentimentDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSentimentDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSentimentDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartSentimentDetectionJob">REST API Reference for StartSentimentDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginStartSentimentDetectionJob(StartSentimentDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSentimentDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartSentimentDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSentimentDetectionJob.</param>
        /// 
        /// <returns>Returns a  StartSentimentDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartSentimentDetectionJob">REST API Reference for StartSentimentDetectionJob Operation</seealso>
        public virtual StartSentimentDetectionJobResponse EndStartSentimentDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartSentimentDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTargetedSentimentDetectionJob

        /// <summary>
        /// Starts an asynchronous targeted sentiment detection job for a collection of documents.
        /// Use the operation to track the status of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTargetedSentimentDetectionJob service method.</param>
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
        public virtual StartTargetedSentimentDetectionJobResponse StartTargetedSentimentDetectionJob(StartTargetedSentimentDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTargetedSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTargetedSentimentDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartTargetedSentimentDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTargetedSentimentDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTargetedSentimentDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTargetedSentimentDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartTargetedSentimentDetectionJob">REST API Reference for StartTargetedSentimentDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginStartTargetedSentimentDetectionJob(StartTargetedSentimentDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTargetedSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTargetedSentimentDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTargetedSentimentDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTargetedSentimentDetectionJob.</param>
        /// 
        /// <returns>Returns a  StartTargetedSentimentDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartTargetedSentimentDetectionJob">REST API Reference for StartTargetedSentimentDetectionJob Operation</seealso>
        public virtual StartTargetedSentimentDetectionJobResponse EndStartTargetedSentimentDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTargetedSentimentDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StartTopicsDetectionJob

        /// <summary>
        /// Starts an asynchronous topic detection job. Use the <code>DescribeTopicDetectionJob</code>
        /// operation to track the status of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTopicsDetectionJob service method.</param>
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
        public virtual StartTopicsDetectionJobResponse StartTopicsDetectionJob(StartTopicsDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTopicsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTopicsDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartTopicsDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartTopicsDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTopicsDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTopicsDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartTopicsDetectionJob">REST API Reference for StartTopicsDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginStartTopicsDetectionJob(StartTopicsDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartTopicsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartTopicsDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartTopicsDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTopicsDetectionJob.</param>
        /// 
        /// <returns>Returns a  StartTopicsDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartTopicsDetectionJob">REST API Reference for StartTopicsDetectionJob Operation</seealso>
        public virtual StartTopicsDetectionJobResponse EndStartTopicsDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StartTopicsDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopDominantLanguageDetectionJob

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
        public virtual StopDominantLanguageDetectionJobResponse StopDominantLanguageDetectionJob(StopDominantLanguageDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDominantLanguageDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopDominantLanguageDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopDominantLanguageDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDominantLanguageDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDominantLanguageDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopDominantLanguageDetectionJob">REST API Reference for StopDominantLanguageDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginStopDominantLanguageDetectionJob(StopDominantLanguageDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopDominantLanguageDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopDominantLanguageDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDominantLanguageDetectionJob.</param>
        /// 
        /// <returns>Returns a  StopDominantLanguageDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopDominantLanguageDetectionJob">REST API Reference for StopDominantLanguageDetectionJob Operation</seealso>
        public virtual StopDominantLanguageDetectionJobResponse EndStopDominantLanguageDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopDominantLanguageDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopEntitiesDetectionJob

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
        public virtual StopEntitiesDetectionJobResponse StopEntitiesDetectionJob(StopEntitiesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEntitiesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopEntitiesDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopEntitiesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopEntitiesDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopEntitiesDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopEntitiesDetectionJob">REST API Reference for StopEntitiesDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginStopEntitiesDetectionJob(StopEntitiesDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEntitiesDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopEntitiesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopEntitiesDetectionJob.</param>
        /// 
        /// <returns>Returns a  StopEntitiesDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopEntitiesDetectionJob">REST API Reference for StopEntitiesDetectionJob Operation</seealso>
        public virtual StopEntitiesDetectionJobResponse EndStopEntitiesDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopEntitiesDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopEventsDetectionJob

        /// <summary>
        /// Stops an events detection job in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopEventsDetectionJob service method.</param>
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
        public virtual StopEventsDetectionJobResponse StopEventsDetectionJob(StopEventsDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEventsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEventsDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopEventsDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopEventsDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopEventsDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopEventsDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopEventsDetectionJob">REST API Reference for StopEventsDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginStopEventsDetectionJob(StopEventsDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopEventsDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopEventsDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopEventsDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopEventsDetectionJob.</param>
        /// 
        /// <returns>Returns a  StopEventsDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopEventsDetectionJob">REST API Reference for StopEventsDetectionJob Operation</seealso>
        public virtual StopEventsDetectionJobResponse EndStopEventsDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopEventsDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopKeyPhrasesDetectionJob

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
        public virtual StopKeyPhrasesDetectionJobResponse StopKeyPhrasesDetectionJob(StopKeyPhrasesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopKeyPhrasesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopKeyPhrasesDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopKeyPhrasesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopKeyPhrasesDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopKeyPhrasesDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopKeyPhrasesDetectionJob">REST API Reference for StopKeyPhrasesDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginStopKeyPhrasesDetectionJob(StopKeyPhrasesDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopKeyPhrasesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopKeyPhrasesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopKeyPhrasesDetectionJob.</param>
        /// 
        /// <returns>Returns a  StopKeyPhrasesDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopKeyPhrasesDetectionJob">REST API Reference for StopKeyPhrasesDetectionJob Operation</seealso>
        public virtual StopKeyPhrasesDetectionJobResponse EndStopKeyPhrasesDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopKeyPhrasesDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopPiiEntitiesDetectionJob

        /// <summary>
        /// Stops a PII entities detection job in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopPiiEntitiesDetectionJob service method.</param>
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
        public virtual StopPiiEntitiesDetectionJobResponse StopPiiEntitiesDetectionJob(StopPiiEntitiesDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopPiiEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopPiiEntitiesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopPiiEntitiesDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopPiiEntitiesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopPiiEntitiesDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopPiiEntitiesDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopPiiEntitiesDetectionJob">REST API Reference for StopPiiEntitiesDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginStopPiiEntitiesDetectionJob(StopPiiEntitiesDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopPiiEntitiesDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopPiiEntitiesDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopPiiEntitiesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopPiiEntitiesDetectionJob.</param>
        /// 
        /// <returns>Returns a  StopPiiEntitiesDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopPiiEntitiesDetectionJob">REST API Reference for StopPiiEntitiesDetectionJob Operation</seealso>
        public virtual StopPiiEntitiesDetectionJobResponse EndStopPiiEntitiesDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopPiiEntitiesDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopSentimentDetectionJob

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
        public virtual StopSentimentDetectionJobResponse StopSentimentDetectionJob(StopSentimentDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopSentimentDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopSentimentDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopSentimentDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopSentimentDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopSentimentDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopSentimentDetectionJob">REST API Reference for StopSentimentDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginStopSentimentDetectionJob(StopSentimentDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopSentimentDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopSentimentDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopSentimentDetectionJob.</param>
        /// 
        /// <returns>Returns a  StopSentimentDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopSentimentDetectionJob">REST API Reference for StopSentimentDetectionJob Operation</seealso>
        public virtual StopSentimentDetectionJobResponse EndStopSentimentDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopSentimentDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopTargetedSentimentDetectionJob

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
        public virtual StopTargetedSentimentDetectionJobResponse StopTargetedSentimentDetectionJob(StopTargetedSentimentDetectionJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTargetedSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTargetedSentimentDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopTargetedSentimentDetectionJobResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopTargetedSentimentDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTargetedSentimentDetectionJob operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTargetedSentimentDetectionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopTargetedSentimentDetectionJob">REST API Reference for StopTargetedSentimentDetectionJob Operation</seealso>
        public virtual IAsyncResult BeginStopTargetedSentimentDetectionJob(StopTargetedSentimentDetectionJobRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTargetedSentimentDetectionJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTargetedSentimentDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopTargetedSentimentDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTargetedSentimentDetectionJob.</param>
        /// 
        /// <returns>Returns a  StopTargetedSentimentDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopTargetedSentimentDetectionJob">REST API Reference for StopTargetedSentimentDetectionJob Operation</seealso>
        public virtual StopTargetedSentimentDetectionJobResponse EndStopTargetedSentimentDetectionJob(IAsyncResult asyncResult)
        {
            return EndInvoke<StopTargetedSentimentDetectionJobResponse>(asyncResult);
        }

        #endregion
        
        #region  StopTrainingDocumentClassifier

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
        public virtual StopTrainingDocumentClassifierResponse StopTrainingDocumentClassifier(StopTrainingDocumentClassifierRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTrainingDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTrainingDocumentClassifierResponseUnmarshaller.Instance;

            return Invoke<StopTrainingDocumentClassifierResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopTrainingDocumentClassifier operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTrainingDocumentClassifier operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTrainingDocumentClassifier
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopTrainingDocumentClassifier">REST API Reference for StopTrainingDocumentClassifier Operation</seealso>
        public virtual IAsyncResult BeginStopTrainingDocumentClassifier(StopTrainingDocumentClassifierRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTrainingDocumentClassifierRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTrainingDocumentClassifierResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopTrainingDocumentClassifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTrainingDocumentClassifier.</param>
        /// 
        /// <returns>Returns a  StopTrainingDocumentClassifierResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopTrainingDocumentClassifier">REST API Reference for StopTrainingDocumentClassifier Operation</seealso>
        public virtual StopTrainingDocumentClassifierResponse EndStopTrainingDocumentClassifier(IAsyncResult asyncResult)
        {
            return EndInvoke<StopTrainingDocumentClassifierResponse>(asyncResult);
        }

        #endregion
        
        #region  StopTrainingEntityRecognizer

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
        public virtual StopTrainingEntityRecognizerResponse StopTrainingEntityRecognizer(StopTrainingEntityRecognizerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTrainingEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTrainingEntityRecognizerResponseUnmarshaller.Instance;

            return Invoke<StopTrainingEntityRecognizerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopTrainingEntityRecognizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTrainingEntityRecognizer operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTrainingEntityRecognizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopTrainingEntityRecognizer">REST API Reference for StopTrainingEntityRecognizer Operation</seealso>
        public virtual IAsyncResult BeginStopTrainingEntityRecognizer(StopTrainingEntityRecognizerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopTrainingEntityRecognizerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopTrainingEntityRecognizerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopTrainingEntityRecognizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTrainingEntityRecognizer.</param>
        /// 
        /// <returns>Returns a  StopTrainingEntityRecognizerResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopTrainingEntityRecognizer">REST API Reference for StopTrainingEntityRecognizer Operation</seealso>
        public virtual StopTrainingEntityRecognizerResponse EndStopTrainingEntityRecognizer(IAsyncResult asyncResult)
        {
            return EndInvoke<StopTrainingEntityRecognizerResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Associates a specific tag with an Amazon Comprehend resource. A tag is a key-value
        /// pair that adds as a metadata to a resource used by Amazon Comprehend. For example,
        /// a tag with "Sales" as the key might be added to a resource to indicate its use by
        /// the sales department.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a specific tag associated with an Amazon Comprehend resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEndpoint

        /// <summary>
        /// Updates information about the specified endpoint. For information about endpoints,
        /// see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/manage-endpoints.html">Managing
        /// endpoints</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint service method.</param>
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
        public virtual UpdateEndpointResponse UpdateEndpoint(UpdateEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        public virtual IAsyncResult BeginUpdateEndpoint(UpdateEndpointRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        public virtual UpdateEndpointResponse EndUpdateEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEndpointResponse>(asyncResult);
        }

        #endregion
        
    }
}