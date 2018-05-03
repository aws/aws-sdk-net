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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */


using System;
using System.Collections.Generic;

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

        
        #region  BatchDetectDominantLanguage

        /// <summary>
        /// Determines the dominant language of the input text for a batch of documents. For a
        /// list of languages that Amazon Comprehend can detect, see <a href="http://docs.aws.amazon.com/comprehend/latest/dg/how-languages.html">Amazon
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
            var marshaller = BatchDetectDominantLanguageRequestMarshaller.Instance;
            var unmarshaller = BatchDetectDominantLanguageResponseUnmarshaller.Instance;

            return Invoke<BatchDetectDominantLanguageRequest,BatchDetectDominantLanguageResponse>(request, marshaller, unmarshaller);
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
            var marshaller = BatchDetectDominantLanguageRequestMarshaller.Instance;
            var unmarshaller = BatchDetectDominantLanguageResponseUnmarshaller.Instance;

            return BeginInvoke<BatchDetectDominantLanguageRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// about them. For more information about named entities, see <a>how-entities</a>
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
        /// Amazon Comprehend can't process the language of the input text. For all APIs except
        /// <code>DetectDominantLanguage</code>, Amazon Comprehend accepts only English or Spanish
        /// text. For the <code>DetectDominantLanguage</code> API, Amazon Comprehend detects 100
        /// languages. For a list of languages, see <a>how-languages</a>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectEntities">REST API Reference for BatchDetectEntities Operation</seealso>
        public virtual BatchDetectEntitiesResponse BatchDetectEntities(BatchDetectEntitiesRequest request)
        {
            var marshaller = BatchDetectEntitiesRequestMarshaller.Instance;
            var unmarshaller = BatchDetectEntitiesResponseUnmarshaller.Instance;

            return Invoke<BatchDetectEntitiesRequest,BatchDetectEntitiesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = BatchDetectEntitiesRequestMarshaller.Instance;
            var unmarshaller = BatchDetectEntitiesResponseUnmarshaller.Instance;

            return BeginInvoke<BatchDetectEntitiesRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Amazon Comprehend can't process the language of the input text. For all APIs except
        /// <code>DetectDominantLanguage</code>, Amazon Comprehend accepts only English or Spanish
        /// text. For the <code>DetectDominantLanguage</code> API, Amazon Comprehend detects 100
        /// languages. For a list of languages, see <a>how-languages</a>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectKeyPhrases">REST API Reference for BatchDetectKeyPhrases Operation</seealso>
        public virtual BatchDetectKeyPhrasesResponse BatchDetectKeyPhrases(BatchDetectKeyPhrasesRequest request)
        {
            var marshaller = BatchDetectKeyPhrasesRequestMarshaller.Instance;
            var unmarshaller = BatchDetectKeyPhrasesResponseUnmarshaller.Instance;

            return Invoke<BatchDetectKeyPhrasesRequest,BatchDetectKeyPhrasesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = BatchDetectKeyPhrasesRequestMarshaller.Instance;
            var unmarshaller = BatchDetectKeyPhrasesResponseUnmarshaller.Instance;

            return BeginInvoke<BatchDetectKeyPhrasesRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Amazon Comprehend can't process the language of the input text. For all APIs except
        /// <code>DetectDominantLanguage</code>, Amazon Comprehend accepts only English or Spanish
        /// text. For the <code>DetectDominantLanguage</code> API, Amazon Comprehend detects 100
        /// languages. For a list of languages, see <a>how-languages</a>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectSentiment">REST API Reference for BatchDetectSentiment Operation</seealso>
        public virtual BatchDetectSentimentResponse BatchDetectSentiment(BatchDetectSentimentRequest request)
        {
            var marshaller = BatchDetectSentimentRequestMarshaller.Instance;
            var unmarshaller = BatchDetectSentimentResponseUnmarshaller.Instance;

            return Invoke<BatchDetectSentimentRequest,BatchDetectSentimentResponse>(request, marshaller, unmarshaller);
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
            var marshaller = BatchDetectSentimentRequestMarshaller.Instance;
            var unmarshaller = BatchDetectSentimentResponseUnmarshaller.Instance;

            return BeginInvoke<BatchDetectSentimentRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// <a>how-syntax</a>.
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
        /// Amazon Comprehend can't process the language of the input text. For all APIs except
        /// <code>DetectDominantLanguage</code>, Amazon Comprehend accepts only English or Spanish
        /// text. For the <code>DetectDominantLanguage</code> API, Amazon Comprehend detects 100
        /// languages. For a list of languages, see <a>how-languages</a>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectSyntax">REST API Reference for BatchDetectSyntax Operation</seealso>
        public virtual BatchDetectSyntaxResponse BatchDetectSyntax(BatchDetectSyntaxRequest request)
        {
            var marshaller = BatchDetectSyntaxRequestMarshaller.Instance;
            var unmarshaller = BatchDetectSyntaxResponseUnmarshaller.Instance;

            return Invoke<BatchDetectSyntaxRequest,BatchDetectSyntaxResponse>(request, marshaller, unmarshaller);
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
            var marshaller = BatchDetectSyntaxRequestMarshaller.Instance;
            var unmarshaller = BatchDetectSyntaxResponseUnmarshaller.Instance;

            return BeginInvoke<BatchDetectSyntaxRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = DescribeDominantLanguageDetectionJobRequestMarshaller.Instance;
            var unmarshaller = DescribeDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeDominantLanguageDetectionJobRequest,DescribeDominantLanguageDetectionJobResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeDominantLanguageDetectionJobRequestMarshaller.Instance;
            var unmarshaller = DescribeDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDominantLanguageDetectionJobRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = DescribeEntitiesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = DescribeEntitiesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeEntitiesDetectionJobRequest,DescribeEntitiesDetectionJobResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeEntitiesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = DescribeEntitiesDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeEntitiesDetectionJobRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = DescribeKeyPhrasesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = DescribeKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeKeyPhrasesDetectionJobRequest,DescribeKeyPhrasesDetectionJobResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeKeyPhrasesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = DescribeKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeKeyPhrasesDetectionJobRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = DescribeSentimentDetectionJobRequestMarshaller.Instance;
            var unmarshaller = DescribeSentimentDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeSentimentDetectionJobRequest,DescribeSentimentDetectionJobResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeSentimentDetectionJobRequestMarshaller.Instance;
            var unmarshaller = DescribeSentimentDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeSentimentDetectionJobRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = DescribeTopicsDetectionJobRequestMarshaller.Instance;
            var unmarshaller = DescribeTopicsDetectionJobResponseUnmarshaller.Instance;

            return Invoke<DescribeTopicsDetectionJobRequest,DescribeTopicsDetectionJobResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DescribeTopicsDetectionJobRequestMarshaller.Instance;
            var unmarshaller = DescribeTopicsDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeTopicsDetectionJobRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Comprehend can detect, see <a href="http://docs.aws.amazon.com/comprehend/latest/dg/how-languages.html">Amazon
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
            var marshaller = DetectDominantLanguageRequestMarshaller.Instance;
            var unmarshaller = DetectDominantLanguageResponseUnmarshaller.Instance;

            return Invoke<DetectDominantLanguageRequest,DetectDominantLanguageResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DetectDominantLanguageRequestMarshaller.Instance;
            var unmarshaller = DetectDominantLanguageResponseUnmarshaller.Instance;

            return BeginInvoke<DetectDominantLanguageRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Inspects text for named entities, and returns information about them. For more information,
        /// about named entities, see <a>how-entities</a>.
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
        /// <exception cref="Amazon.Comprehend.Model.TextSizeLimitExceededException">
        /// The size of the input text exceeds the limit. Use a smaller document.
        /// </exception>
        /// <exception cref="Amazon.Comprehend.Model.UnsupportedLanguageException">
        /// Amazon Comprehend can't process the language of the input text. For all APIs except
        /// <code>DetectDominantLanguage</code>, Amazon Comprehend accepts only English or Spanish
        /// text. For the <code>DetectDominantLanguage</code> API, Amazon Comprehend detects 100
        /// languages. For a list of languages, see <a>how-languages</a>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectEntities">REST API Reference for DetectEntities Operation</seealso>
        public virtual DetectEntitiesResponse DetectEntities(DetectEntitiesRequest request)
        {
            var marshaller = DetectEntitiesRequestMarshaller.Instance;
            var unmarshaller = DetectEntitiesResponseUnmarshaller.Instance;

            return Invoke<DetectEntitiesRequest,DetectEntitiesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DetectEntitiesRequestMarshaller.Instance;
            var unmarshaller = DetectEntitiesResponseUnmarshaller.Instance;

            return BeginInvoke<DetectEntitiesRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Amazon Comprehend can't process the language of the input text. For all APIs except
        /// <code>DetectDominantLanguage</code>, Amazon Comprehend accepts only English or Spanish
        /// text. For the <code>DetectDominantLanguage</code> API, Amazon Comprehend detects 100
        /// languages. For a list of languages, see <a>how-languages</a>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectKeyPhrases">REST API Reference for DetectKeyPhrases Operation</seealso>
        public virtual DetectKeyPhrasesResponse DetectKeyPhrases(DetectKeyPhrasesRequest request)
        {
            var marshaller = DetectKeyPhrasesRequestMarshaller.Instance;
            var unmarshaller = DetectKeyPhrasesResponseUnmarshaller.Instance;

            return Invoke<DetectKeyPhrasesRequest,DetectKeyPhrasesResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DetectKeyPhrasesRequestMarshaller.Instance;
            var unmarshaller = DetectKeyPhrasesResponseUnmarshaller.Instance;

            return BeginInvoke<DetectKeyPhrasesRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// Amazon Comprehend can't process the language of the input text. For all APIs except
        /// <code>DetectDominantLanguage</code>, Amazon Comprehend accepts only English or Spanish
        /// text. For the <code>DetectDominantLanguage</code> API, Amazon Comprehend detects 100
        /// languages. For a list of languages, see <a>how-languages</a>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectSentiment">REST API Reference for DetectSentiment Operation</seealso>
        public virtual DetectSentimentResponse DetectSentiment(DetectSentimentRequest request)
        {
            var marshaller = DetectSentimentRequestMarshaller.Instance;
            var unmarshaller = DetectSentimentResponseUnmarshaller.Instance;

            return Invoke<DetectSentimentRequest,DetectSentimentResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DetectSentimentRequestMarshaller.Instance;
            var unmarshaller = DetectSentimentResponseUnmarshaller.Instance;

            return BeginInvoke<DetectSentimentRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// information, <a>how-syntax</a>.
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
        /// Amazon Comprehend can't process the language of the input text. For all APIs except
        /// <code>DetectDominantLanguage</code>, Amazon Comprehend accepts only English or Spanish
        /// text. For the <code>DetectDominantLanguage</code> API, Amazon Comprehend detects 100
        /// languages. For a list of languages, see <a>how-languages</a>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectSyntax">REST API Reference for DetectSyntax Operation</seealso>
        public virtual DetectSyntaxResponse DetectSyntax(DetectSyntaxRequest request)
        {
            var marshaller = DetectSyntaxRequestMarshaller.Instance;
            var unmarshaller = DetectSyntaxResponseUnmarshaller.Instance;

            return Invoke<DetectSyntaxRequest,DetectSyntaxResponse>(request, marshaller, unmarshaller);
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
            var marshaller = DetectSyntaxRequestMarshaller.Instance;
            var unmarshaller = DetectSyntaxResponseUnmarshaller.Instance;

            return BeginInvoke<DetectSyntaxRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The filter specified for the <code>ListTopicDetectionJobs</code> operation is invalid.
        /// Specify a different filter.
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
            var marshaller = ListDominantLanguageDetectionJobsRequestMarshaller.Instance;
            var unmarshaller = ListDominantLanguageDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListDominantLanguageDetectionJobsRequest,ListDominantLanguageDetectionJobsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListDominantLanguageDetectionJobsRequestMarshaller.Instance;
            var unmarshaller = ListDominantLanguageDetectionJobsResponseUnmarshaller.Instance;

            return BeginInvoke<ListDominantLanguageDetectionJobsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The filter specified for the <code>ListTopicDetectionJobs</code> operation is invalid.
        /// Specify a different filter.
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
            var marshaller = ListEntitiesDetectionJobsRequestMarshaller.Instance;
            var unmarshaller = ListEntitiesDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListEntitiesDetectionJobsRequest,ListEntitiesDetectionJobsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListEntitiesDetectionJobsRequestMarshaller.Instance;
            var unmarshaller = ListEntitiesDetectionJobsResponseUnmarshaller.Instance;

            return BeginInvoke<ListEntitiesDetectionJobsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The filter specified for the <code>ListTopicDetectionJobs</code> operation is invalid.
        /// Specify a different filter.
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
            var marshaller = ListKeyPhrasesDetectionJobsRequestMarshaller.Instance;
            var unmarshaller = ListKeyPhrasesDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListKeyPhrasesDetectionJobsRequest,ListKeyPhrasesDetectionJobsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListKeyPhrasesDetectionJobsRequestMarshaller.Instance;
            var unmarshaller = ListKeyPhrasesDetectionJobsResponseUnmarshaller.Instance;

            return BeginInvoke<ListKeyPhrasesDetectionJobsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The filter specified for the <code>ListTopicDetectionJobs</code> operation is invalid.
        /// Specify a different filter.
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
            var marshaller = ListSentimentDetectionJobsRequestMarshaller.Instance;
            var unmarshaller = ListSentimentDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListSentimentDetectionJobsRequest,ListSentimentDetectionJobsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListSentimentDetectionJobsRequestMarshaller.Instance;
            var unmarshaller = ListSentimentDetectionJobsResponseUnmarshaller.Instance;

            return BeginInvoke<ListSentimentDetectionJobsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// The filter specified for the <code>ListTopicDetectionJobs</code> operation is invalid.
        /// Specify a different filter.
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
            var marshaller = ListTopicsDetectionJobsRequestMarshaller.Instance;
            var unmarshaller = ListTopicsDetectionJobsResponseUnmarshaller.Instance;

            return Invoke<ListTopicsDetectionJobsRequest,ListTopicsDetectionJobsResponse>(request, marshaller, unmarshaller);
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
            var marshaller = ListTopicsDetectionJobsRequestMarshaller.Instance;
            var unmarshaller = ListTopicsDetectionJobsResponseUnmarshaller.Instance;

            return BeginInvoke<ListTopicsDetectionJobsRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartDominantLanguageDetectionJob">REST API Reference for StartDominantLanguageDetectionJob Operation</seealso>
        public virtual StartDominantLanguageDetectionJobResponse StartDominantLanguageDetectionJob(StartDominantLanguageDetectionJobRequest request)
        {
            var marshaller = StartDominantLanguageDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StartDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartDominantLanguageDetectionJobRequest,StartDominantLanguageDetectionJobResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StartDominantLanguageDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StartDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke<StartDominantLanguageDetectionJobRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartEntitiesDetectionJob">REST API Reference for StartEntitiesDetectionJob Operation</seealso>
        public virtual StartEntitiesDetectionJobResponse StartEntitiesDetectionJob(StartEntitiesDetectionJobRequest request)
        {
            var marshaller = StartEntitiesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StartEntitiesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartEntitiesDetectionJobRequest,StartEntitiesDetectionJobResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StartEntitiesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StartEntitiesDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke<StartEntitiesDetectionJobRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartKeyPhrasesDetectionJob">REST API Reference for StartKeyPhrasesDetectionJob Operation</seealso>
        public virtual StartKeyPhrasesDetectionJobResponse StartKeyPhrasesDetectionJob(StartKeyPhrasesDetectionJobRequest request)
        {
            var marshaller = StartKeyPhrasesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StartKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartKeyPhrasesDetectionJobRequest,StartKeyPhrasesDetectionJobResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StartKeyPhrasesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StartKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke<StartKeyPhrasesDetectionJobRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  StartSentimentDetectionJob

        /// <summary>
        /// Starts an asynchronous sentiment detection job for a collection of documents. use
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
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartSentimentDetectionJob">REST API Reference for StartSentimentDetectionJob Operation</seealso>
        public virtual StartSentimentDetectionJobResponse StartSentimentDetectionJob(StartSentimentDetectionJobRequest request)
        {
            var marshaller = StartSentimentDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StartSentimentDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartSentimentDetectionJobRequest,StartSentimentDetectionJobResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StartSentimentDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StartSentimentDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke<StartSentimentDetectionJobRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        /// <exception cref="Amazon.Comprehend.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartTopicsDetectionJob">REST API Reference for StartTopicsDetectionJob Operation</seealso>
        public virtual StartTopicsDetectionJobResponse StartTopicsDetectionJob(StartTopicsDetectionJobRequest request)
        {
            var marshaller = StartTopicsDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StartTopicsDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StartTopicsDetectionJobRequest,StartTopicsDetectionJobResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StartTopicsDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StartTopicsDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke<StartTopicsDetectionJobRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = StopDominantLanguageDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StopDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopDominantLanguageDetectionJobRequest,StopDominantLanguageDetectionJobResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StopDominantLanguageDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StopDominantLanguageDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke<StopDominantLanguageDetectionJobRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = StopEntitiesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StopEntitiesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopEntitiesDetectionJobRequest,StopEntitiesDetectionJobResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StopEntitiesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StopEntitiesDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke<StopEntitiesDetectionJobRequest>(request, marshaller, unmarshaller,
                callback, state);
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
            var marshaller = StopKeyPhrasesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StopKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopKeyPhrasesDetectionJobRequest,StopKeyPhrasesDetectionJobResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StopKeyPhrasesDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StopKeyPhrasesDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke<StopKeyPhrasesDetectionJobRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
        #region  StopSentimentDetectionJob

        /// <summary>
        /// Stops a sentiment detection job in progress.
        /// 
        ///  
        /// <para>
        /// If the job state is <code>IN_PROGRESS</code> the job is marked for termination and
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
            var marshaller = StopSentimentDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StopSentimentDetectionJobResponseUnmarshaller.Instance;

            return Invoke<StopSentimentDetectionJobRequest,StopSentimentDetectionJobResponse>(request, marshaller, unmarshaller);
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
            var marshaller = StopSentimentDetectionJobRequestMarshaller.Instance;
            var unmarshaller = StopSentimentDetectionJobResponseUnmarshaller.Instance;

            return BeginInvoke<StopSentimentDetectionJobRequest>(request, marshaller, unmarshaller,
                callback, state);
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
        
    }
}