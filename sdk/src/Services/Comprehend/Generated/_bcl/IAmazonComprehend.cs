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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Comprehend.Model;

#pragma warning disable CS1570
namespace Amazon.Comprehend
{
    /// <summary>
    /// <para>Interface for accessing Comprehend</para>
    ///
    /// Amazon Comprehend is an Amazon Web Services service for gaining insight into the content
    /// of documents. Use these actions to determine the topics contained in your documents,
    /// the topics they discuss, the predominant sentiment expressed in them, the predominant
    /// language used, and more.
    /// </summary>
    public partial interface IAmazonComprehend : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IComprehendPaginatorFactory Paginators { get; }

        
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
        BatchDetectDominantLanguageResponse BatchDetectDominantLanguage(BatchDetectDominantLanguageRequest request);



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
        Task<BatchDetectDominantLanguageResponse> BatchDetectDominantLanguageAsync(BatchDetectDominantLanguageRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectEntities">REST API Reference for BatchDetectEntities Operation</seealso>
        BatchDetectEntitiesResponse BatchDetectEntities(BatchDetectEntitiesRequest request);



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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectEntities">REST API Reference for BatchDetectEntities Operation</seealso>
        Task<BatchDetectEntitiesResponse> BatchDetectEntitiesAsync(BatchDetectEntitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectKeyPhrases">REST API Reference for BatchDetectKeyPhrases Operation</seealso>
        BatchDetectKeyPhrasesResponse BatchDetectKeyPhrases(BatchDetectKeyPhrasesRequest request);



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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectKeyPhrases">REST API Reference for BatchDetectKeyPhrases Operation</seealso>
        Task<BatchDetectKeyPhrasesResponse> BatchDetectKeyPhrasesAsync(BatchDetectKeyPhrasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDetectSentiment


        /// <summary>
        /// Inspects a batch of documents and returns an inference of the prevailing sentiment,
        /// <c>POSITIVE</c>, <c>NEUTRAL</c>, <c>MIXED</c>, or <c>NEGATIVE</c>, in each one.
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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectSentiment">REST API Reference for BatchDetectSentiment Operation</seealso>
        BatchDetectSentimentResponse BatchDetectSentiment(BatchDetectSentimentRequest request);



        /// <summary>
        /// Inspects a batch of documents and returns an inference of the prevailing sentiment,
        /// <c>POSITIVE</c>, <c>NEUTRAL</c>, <c>MIXED</c>, or <c>NEGATIVE</c>, in each one.
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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectSentiment">REST API Reference for BatchDetectSentiment Operation</seealso>
        Task<BatchDetectSentimentResponse> BatchDetectSentimentAsync(BatchDetectSentimentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectSyntax">REST API Reference for BatchDetectSyntax Operation</seealso>
        BatchDetectSyntaxResponse BatchDetectSyntax(BatchDetectSyntaxRequest request);



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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectSyntax">REST API Reference for BatchDetectSyntax Operation</seealso>
        Task<BatchDetectSyntaxResponse> BatchDetectSyntaxAsync(BatchDetectSyntaxRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDetectTargetedSentiment


        /// <summary>
        /// Inspects a batch of documents and returns a sentiment analysis for each entity identified
        /// in the documents.
        /// 
        ///  
        /// <para>
        /// For more information about targeted sentiment, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-targeted-sentiment.html">Targeted
        /// sentiment</a> in the <i>Amazon Comprehend Developer Guide</i>.
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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectTargetedSentiment">REST API Reference for BatchDetectTargetedSentiment Operation</seealso>
        BatchDetectTargetedSentimentResponse BatchDetectTargetedSentiment(BatchDetectTargetedSentimentRequest request);



        /// <summary>
        /// Inspects a batch of documents and returns a sentiment analysis for each entity identified
        /// in the documents.
        /// 
        ///  
        /// <para>
        /// For more information about targeted sentiment, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-targeted-sentiment.html">Targeted
        /// sentiment</a> in the <i>Amazon Comprehend Developer Guide</i>.
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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectTargetedSentiment">REST API Reference for BatchDetectTargetedSentiment Operation</seealso>
        Task<BatchDetectTargetedSentimentResponse> BatchDetectTargetedSentimentAsync(BatchDetectTargetedSentimentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ClassifyDocument


        /// <summary>
        /// Creates a classification request to analyze a single document in real-time. <c>ClassifyDocument</c>
        /// supports the following model types:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Custom classifier - a custom model that you have created and trained. For input, you
        /// can provide plain text, a single-page document (PDF, Word, or image), or Amazon Textract
        /// API output. For more information, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-document-classification.html">Custom
        /// classification</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Prompt safety classifier - Amazon Comprehend provides a pre-trained model for classifying
        /// input prompts for generative AI applications. For input, you provide English plain
        /// text input. For prompt safety classification, the response includes only the <c>Classes</c>
        /// field. For more information about prompt safety classifiers, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/trust-safety.html#prompt-classification">Prompt
        /// safety classification</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the system detects errors while processing a page in the input document, the API
        /// response includes an <c>Errors</c> field that describes the errors.
        /// </para>
        ///  
        /// <para>
        /// If the system detects a document-level error in your input document, the API returns
        /// an <c>InvalidRequestException</c> error response. For details about this exception,
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
        ClassifyDocumentResponse ClassifyDocument(ClassifyDocumentRequest request);



        /// <summary>
        /// Creates a classification request to analyze a single document in real-time. <c>ClassifyDocument</c>
        /// supports the following model types:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Custom classifier - a custom model that you have created and trained. For input, you
        /// can provide plain text, a single-page document (PDF, Word, or image), or Amazon Textract
        /// API output. For more information, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-document-classification.html">Custom
        /// classification</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Prompt safety classifier - Amazon Comprehend provides a pre-trained model for classifying
        /// input prompts for generative AI applications. For input, you provide English plain
        /// text input. For prompt safety classification, the response includes only the <c>Classes</c>
        /// field. For more information about prompt safety classifiers, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/trust-safety.html#prompt-classification">Prompt
        /// safety classification</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the system detects errors while processing a page in the input document, the API
        /// response includes an <c>Errors</c> field that describes the errors.
        /// </para>
        ///  
        /// <para>
        /// If the system detects a document-level error in your input document, the API returns
        /// an <c>InvalidRequestException</c> error response. For details about this exception,
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
        Task<ClassifyDocumentResponse> ClassifyDocumentAsync(ClassifyDocumentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ContainsPiiEntities">REST API Reference for ContainsPiiEntities Operation</seealso>
        ContainsPiiEntitiesResponse ContainsPiiEntities(ContainsPiiEntitiesRequest request);



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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ContainsPiiEntities">REST API Reference for ContainsPiiEntities Operation</seealso>
        Task<ContainsPiiEntitiesResponse> ContainsPiiEntitiesAsync(ContainsPiiEntitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDataset


        /// <summary>
        /// Creates a dataset to upload training or test data for a model associated with a flywheel.
        /// For more information about datasets, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/flywheels-about.html">
        /// Flywheel overview</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset service method.</param>
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
        CreateDatasetResponse CreateDataset(CreateDatasetRequest request);



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
        Task<CreateDatasetResponse> CreateDatasetAsync(CreateDatasetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDocumentClassifier


        /// <summary>
        /// Creates a new document classifier that you can use to categorize documents. To create
        /// a classifier, you provide a set of training documents that are labeled with the categories
        /// that you want to use. For more information, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/training-classifier-model.html">Training
        /// classifier models</a> in the Comprehend Developer Guide.
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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateDocumentClassifier">REST API Reference for CreateDocumentClassifier Operation</seealso>
        CreateDocumentClassifierResponse CreateDocumentClassifier(CreateDocumentClassifierRequest request);



        /// <summary>
        /// Creates a new document classifier that you can use to categorize documents. To create
        /// a classifier, you provide a set of training documents that are labeled with the categories
        /// that you want to use. For more information, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/training-classifier-model.html">Training
        /// classifier models</a> in the Comprehend Developer Guide.
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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateDocumentClassifier">REST API Reference for CreateDocumentClassifier Operation</seealso>
        Task<CreateDocumentClassifierResponse> CreateDocumentClassifierAsync(CreateDocumentClassifierRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request);



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
        Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateEntityRecognizer


        /// <summary>
        /// Creates an entity recognizer using submitted files. After your <c>CreateEntityRecognizer</c>
        /// request is submitted, you can check job status using the <c>DescribeEntityRecognizer</c>
        /// API.
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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateEntityRecognizer">REST API Reference for CreateEntityRecognizer Operation</seealso>
        CreateEntityRecognizerResponse CreateEntityRecognizer(CreateEntityRecognizerRequest request);



        /// <summary>
        /// Creates an entity recognizer using submitted files. After your <c>CreateEntityRecognizer</c>
        /// request is submitted, you can check job status using the <c>DescribeEntityRecognizer</c>
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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateEntityRecognizer">REST API Reference for CreateEntityRecognizer Operation</seealso>
        Task<CreateEntityRecognizerResponse> CreateEntityRecognizerAsync(CreateEntityRecognizerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFlywheel


        /// <summary>
        /// A flywheel is an Amazon Web Services resource that orchestrates the ongoing training
        /// of a model for custom classification or custom entity recognition. You can create
        /// a flywheel to start with an existing trained model, or Comprehend can create and train
        /// a new model.
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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateFlywheel">REST API Reference for CreateFlywheel Operation</seealso>
        CreateFlywheelResponse CreateFlywheel(CreateFlywheelRequest request);



        /// <summary>
        /// A flywheel is an Amazon Web Services resource that orchestrates the ongoing training
        /// of a model for custom classification or custom entity recognition. You can create
        /// a flywheel to start with an existing trained model, or Comprehend can create and train
        /// a new model.
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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateFlywheel">REST API Reference for CreateFlywheel Operation</seealso>
        Task<CreateFlywheelResponse> CreateFlywheelAsync(CreateFlywheelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDocumentClassifier


        /// <summary>
        /// Deletes a previously created document classifier
        /// 
        ///  
        /// <para>
        /// Only those classifiers that are in terminated states (IN_ERROR, TRAINED) will be deleted.
        /// If an active inference job is using the model, a <c>ResourceInUseException</c> will
        /// be returned.
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
        DeleteDocumentClassifierResponse DeleteDocumentClassifier(DeleteDocumentClassifierRequest request);



        /// <summary>
        /// Deletes a previously created document classifier
        /// 
        ///  
        /// <para>
        /// Only those classifiers that are in terminated states (IN_ERROR, TRAINED) will be deleted.
        /// If an active inference job is using the model, a <c>ResourceInUseException</c> will
        /// be returned.
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
        Task<DeleteDocumentClassifierResponse> DeleteDocumentClassifierAsync(DeleteDocumentClassifierRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request);



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
        Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEntityRecognizer


        /// <summary>
        /// Deletes an entity recognizer.
        /// 
        ///  
        /// <para>
        /// Only those recognizers that are in terminated states (IN_ERROR, TRAINED) will be deleted.
        /// If an active inference job is using the model, a <c>ResourceInUseException</c> will
        /// be returned.
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
        DeleteEntityRecognizerResponse DeleteEntityRecognizer(DeleteEntityRecognizerRequest request);



        /// <summary>
        /// Deletes an entity recognizer.
        /// 
        ///  
        /// <para>
        /// Only those recognizers that are in terminated states (IN_ERROR, TRAINED) will be deleted.
        /// If an active inference job is using the model, a <c>ResourceInUseException</c> will
        /// be returned.
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
        Task<DeleteEntityRecognizerResponse> DeleteEntityRecognizerAsync(DeleteEntityRecognizerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFlywheel


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
        DeleteFlywheelResponse DeleteFlywheel(DeleteFlywheelRequest request);



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
        Task<DeleteFlywheelResponse> DeleteFlywheelAsync(DeleteFlywheelRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);



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
        Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDataset


        /// <summary>
        /// Returns information about the dataset that you specify. For more information about
        /// datasets, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/flywheels-about.html">
        /// Flywheel overview</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset service method.</param>
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
        DescribeDatasetResponse DescribeDataset(DescribeDatasetRequest request);



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
        Task<DescribeDatasetResponse> DescribeDatasetAsync(DescribeDatasetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeDocumentClassificationJobResponse DescribeDocumentClassificationJob(DescribeDocumentClassificationJobRequest request);



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
        Task<DescribeDocumentClassificationJobResponse> DescribeDocumentClassificationJobAsync(DescribeDocumentClassificationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeDocumentClassifierResponse DescribeDocumentClassifier(DescribeDocumentClassifierRequest request);



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
        Task<DescribeDocumentClassifierResponse> DescribeDocumentClassifierAsync(DescribeDocumentClassifierRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeDominantLanguageDetectionJobResponse DescribeDominantLanguageDetectionJob(DescribeDominantLanguageDetectionJobRequest request);



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
        Task<DescribeDominantLanguageDetectionJobResponse> DescribeDominantLanguageDetectionJobAsync(DescribeDominantLanguageDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeEndpointResponse DescribeEndpoint(DescribeEndpointRequest request);



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
        Task<DescribeEndpointResponse> DescribeEndpointAsync(DescribeEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeEntitiesDetectionJobResponse DescribeEntitiesDetectionJob(DescribeEntitiesDetectionJobRequest request);



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
        Task<DescribeEntitiesDetectionJobResponse> DescribeEntitiesDetectionJobAsync(DescribeEntitiesDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeEntityRecognizerResponse DescribeEntityRecognizer(DescribeEntityRecognizerRequest request);



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
        Task<DescribeEntityRecognizerResponse> DescribeEntityRecognizerAsync(DescribeEntityRecognizerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeEventsDetectionJobResponse DescribeEventsDetectionJob(DescribeEventsDetectionJobRequest request);



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
        Task<DescribeEventsDetectionJobResponse> DescribeEventsDetectionJobAsync(DescribeEventsDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFlywheel


        /// <summary>
        /// Provides configuration information about the flywheel. For more information about
        /// flywheels, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/flywheels-about.html">
        /// Flywheel overview</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlywheel service method.</param>
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
        DescribeFlywheelResponse DescribeFlywheel(DescribeFlywheelRequest request);



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
        Task<DescribeFlywheelResponse> DescribeFlywheelAsync(DescribeFlywheelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFlywheelIteration


        /// <summary>
        /// Retrieve the configuration properties of a flywheel iteration. For more information
        /// about flywheels, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/flywheels-about.html">
        /// Flywheel overview</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlywheelIteration service method.</param>
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
        DescribeFlywheelIterationResponse DescribeFlywheelIteration(DescribeFlywheelIterationRequest request);



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
        Task<DescribeFlywheelIterationResponse> DescribeFlywheelIterationAsync(DescribeFlywheelIterationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeKeyPhrasesDetectionJobResponse DescribeKeyPhrasesDetectionJob(DescribeKeyPhrasesDetectionJobRequest request);



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
        Task<DescribeKeyPhrasesDetectionJobResponse> DescribeKeyPhrasesDetectionJobAsync(DescribeKeyPhrasesDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribePiiEntitiesDetectionJobResponse DescribePiiEntitiesDetectionJob(DescribePiiEntitiesDetectionJobRequest request);



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
        Task<DescribePiiEntitiesDetectionJobResponse> DescribePiiEntitiesDetectionJobAsync(DescribePiiEntitiesDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeResourcePolicyResponse DescribeResourcePolicy(DescribeResourcePolicyRequest request);



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
        Task<DescribeResourcePolicyResponse> DescribeResourcePolicyAsync(DescribeResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeSentimentDetectionJobResponse DescribeSentimentDetectionJob(DescribeSentimentDetectionJobRequest request);



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
        Task<DescribeSentimentDetectionJobResponse> DescribeSentimentDetectionJobAsync(DescribeSentimentDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeTargetedSentimentDetectionJobResponse DescribeTargetedSentimentDetectionJob(DescribeTargetedSentimentDetectionJobRequest request);



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
        Task<DescribeTargetedSentimentDetectionJobResponse> DescribeTargetedSentimentDetectionJobAsync(DescribeTargetedSentimentDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeTopicsDetectionJobResponse DescribeTopicsDetectionJob(DescribeTopicsDetectionJobRequest request);



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
        Task<DescribeTopicsDetectionJobResponse> DescribeTopicsDetectionJobAsync(DescribeTopicsDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DetectDominantLanguageResponse DetectDominantLanguage(DetectDominantLanguageRequest request);



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
        Task<DetectDominantLanguageResponse> DetectDominantLanguageAsync(DetectDominantLanguageRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// response includes an entry in <c>Errors</c> for each error. 
        /// </para>
        ///  
        /// <para>
        /// If the system detects a document-level error in your input document, the API returns
        /// an <c>InvalidRequestException</c> error response. For details about this exception,
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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectEntities">REST API Reference for DetectEntities Operation</seealso>
        DetectEntitiesResponse DetectEntities(DetectEntitiesRequest request);



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
        /// response includes an entry in <c>Errors</c> for each error. 
        /// </para>
        ///  
        /// <para>
        /// If the system detects a document-level error in your input document, the API returns
        /// an <c>InvalidRequestException</c> error response. For details about this exception,
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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectEntities">REST API Reference for DetectEntities Operation</seealso>
        Task<DetectEntitiesResponse> DetectEntitiesAsync(DetectEntitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectKeyPhrases">REST API Reference for DetectKeyPhrases Operation</seealso>
        DetectKeyPhrasesResponse DetectKeyPhrases(DetectKeyPhrasesRequest request);



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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectKeyPhrases">REST API Reference for DetectKeyPhrases Operation</seealso>
        Task<DetectKeyPhrasesResponse> DetectKeyPhrasesAsync(DetectKeyPhrasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectPiiEntities">REST API Reference for DetectPiiEntities Operation</seealso>
        DetectPiiEntitiesResponse DetectPiiEntities(DetectPiiEntitiesRequest request);



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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectPiiEntities">REST API Reference for DetectPiiEntities Operation</seealso>
        Task<DetectPiiEntitiesResponse> DetectPiiEntitiesAsync(DetectPiiEntitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetectSentiment


        /// <summary>
        /// Inspects text and returns an inference of the prevailing sentiment (<c>POSITIVE</c>,
        /// <c>NEUTRAL</c>, <c>MIXED</c>, or <c>NEGATIVE</c>).
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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectSentiment">REST API Reference for DetectSentiment Operation</seealso>
        DetectSentimentResponse DetectSentiment(DetectSentimentRequest request);



        /// <summary>
        /// Inspects text and returns an inference of the prevailing sentiment (<c>POSITIVE</c>,
        /// <c>NEUTRAL</c>, <c>MIXED</c>, or <c>NEGATIVE</c>).
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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectSentiment">REST API Reference for DetectSentiment Operation</seealso>
        Task<DetectSentimentResponse> DetectSentimentAsync(DetectSentimentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectSyntax">REST API Reference for DetectSyntax Operation</seealso>
        DetectSyntaxResponse DetectSyntax(DetectSyntaxRequest request);



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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectSyntax">REST API Reference for DetectSyntax Operation</seealso>
        Task<DetectSyntaxResponse> DetectSyntaxAsync(DetectSyntaxRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetectTargetedSentiment


        /// <summary>
        /// Inspects the input text and returns a sentiment analysis for each entity identified
        /// in the text.
        /// 
        ///  
        /// <para>
        /// For more information about targeted sentiment, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-targeted-sentiment.html">Targeted
        /// sentiment</a> in the <i>Amazon Comprehend Developer Guide</i>.
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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectTargetedSentiment">REST API Reference for DetectTargetedSentiment Operation</seealso>
        DetectTargetedSentimentResponse DetectTargetedSentiment(DetectTargetedSentimentRequest request);



        /// <summary>
        /// Inspects the input text and returns a sentiment analysis for each entity identified
        /// in the text.
        /// 
        ///  
        /// <para>
        /// For more information about targeted sentiment, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-targeted-sentiment.html">Targeted
        /// sentiment</a> in the <i>Amazon Comprehend Developer Guide</i>.
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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectTargetedSentiment">REST API Reference for DetectTargetedSentiment Operation</seealso>
        Task<DetectTargetedSentimentResponse> DetectTargetedSentimentAsync(DetectTargetedSentimentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetectToxicContent


        /// <summary>
        /// Performs toxicity analysis on the list of text strings that you provide as input.
        /// The API response contains a results list that matches the size of the input list.
        /// For more information about toxicity detection, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/toxicity-detection.html">Toxicity
        /// detection</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectToxicContent service method.</param>
        /// 
        /// <returns>The response from the DetectToxicContent service method, as returned by Comprehend.</returns>
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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectToxicContent">REST API Reference for DetectToxicContent Operation</seealso>
        DetectToxicContentResponse DetectToxicContent(DetectToxicContentRequest request);



        /// <summary>
        /// Performs toxicity analysis on the list of text strings that you provide as input.
        /// The API response contains a results list that matches the size of the input list.
        /// For more information about toxicity detection, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/toxicity-detection.html">Toxicity
        /// detection</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectToxicContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetectToxicContent service method, as returned by Comprehend.</returns>
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
        /// Amazon Comprehend can't process the language of the input text. For a list of supported
        /// languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectToxicContent">REST API Reference for DetectToxicContent Operation</seealso>
        Task<DetectToxicContentResponse> DetectToxicContentAsync(DetectToxicContentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ImportModel


        /// <summary>
        /// Creates a new custom model that replicates a source custom model that you import.
        /// The source model can be in your Amazon Web Services account or another one.
        /// 
        ///  
        /// <para>
        /// If the source model is in another Amazon Web Services account, then it must have a
        /// resource-based policy that authorizes you to import it.
        /// </para>
        ///  
        /// <para>
        /// The source model must be in the same Amazon Web Services Region that you're using
        /// when you import. You can't import a model that's in a different Region.
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
        ImportModelResponse ImportModel(ImportModelRequest request);



        /// <summary>
        /// Creates a new custom model that replicates a source custom model that you import.
        /// The source model can be in your Amazon Web Services account or another one.
        /// 
        ///  
        /// <para>
        /// If the source model is in another Amazon Web Services account, then it must have a
        /// resource-based policy that authorizes you to import it.
        /// </para>
        ///  
        /// <para>
        /// The source model must be in the same Amazon Web Services Region that you're using
        /// when you import. You can't import a model that's in a different Region.
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
        Task<ImportModelResponse> ImportModelAsync(ImportModelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDatasets


        /// <summary>
        /// List the datasets that you have configured in this Region. For more information about
        /// datasets, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/flywheels-about.html">
        /// Flywheel overview</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets service method.</param>
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
        ListDatasetsResponse ListDatasets(ListDatasetsRequest request);



        /// <summary>
        /// List the datasets that you have configured in this Region. For more information about
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
        Task<ListDatasetsResponse> ListDatasetsAsync(ListDatasetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListDocumentClassificationJobsResponse ListDocumentClassificationJobs(ListDocumentClassificationJobsRequest request);



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
        Task<ListDocumentClassificationJobsResponse> ListDocumentClassificationJobsAsync(ListDocumentClassificationJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListDocumentClassifiersResponse ListDocumentClassifiers(ListDocumentClassifiersRequest request);



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
        Task<ListDocumentClassifiersResponse> ListDocumentClassifiersAsync(ListDocumentClassifiersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListDocumentClassifierSummariesResponse ListDocumentClassifierSummaries(ListDocumentClassifierSummariesRequest request);



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
        Task<ListDocumentClassifierSummariesResponse> ListDocumentClassifierSummariesAsync(ListDocumentClassifierSummariesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListDominantLanguageDetectionJobsResponse ListDominantLanguageDetectionJobs(ListDominantLanguageDetectionJobsRequest request);



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
        Task<ListDominantLanguageDetectionJobsResponse> ListDominantLanguageDetectionJobsAsync(ListDominantLanguageDetectionJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListEndpointsResponse ListEndpoints(ListEndpointsRequest request);



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
        Task<ListEndpointsResponse> ListEndpointsAsync(ListEndpointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListEntitiesDetectionJobsResponse ListEntitiesDetectionJobs(ListEntitiesDetectionJobsRequest request);



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
        Task<ListEntitiesDetectionJobsResponse> ListEntitiesDetectionJobsAsync(ListEntitiesDetectionJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListEntityRecognizersResponse ListEntityRecognizers(ListEntityRecognizersRequest request);



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
        Task<ListEntityRecognizersResponse> ListEntityRecognizersAsync(ListEntityRecognizersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListEntityRecognizerSummariesResponse ListEntityRecognizerSummaries(ListEntityRecognizerSummariesRequest request);



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
        Task<ListEntityRecognizerSummariesResponse> ListEntityRecognizerSummariesAsync(ListEntityRecognizerSummariesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListEventsDetectionJobsResponse ListEventsDetectionJobs(ListEventsDetectionJobsRequest request);



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
        Task<ListEventsDetectionJobsResponse> ListEventsDetectionJobsAsync(ListEventsDetectionJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFlywheelIterationHistory


        /// <summary>
        /// Information about the history of a flywheel iteration. For more information about
        /// flywheels, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/flywheels-about.html">
        /// Flywheel overview</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlywheelIterationHistory service method.</param>
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
        ListFlywheelIterationHistoryResponse ListFlywheelIterationHistory(ListFlywheelIterationHistoryRequest request);



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
        Task<ListFlywheelIterationHistoryResponse> ListFlywheelIterationHistoryAsync(ListFlywheelIterationHistoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFlywheels


        /// <summary>
        /// Gets a list of the flywheels that you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlywheels service method.</param>
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
        ListFlywheelsResponse ListFlywheels(ListFlywheelsRequest request);



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
        Task<ListFlywheelsResponse> ListFlywheelsAsync(ListFlywheelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListKeyPhrasesDetectionJobsResponse ListKeyPhrasesDetectionJobs(ListKeyPhrasesDetectionJobsRequest request);



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
        Task<ListKeyPhrasesDetectionJobsResponse> ListKeyPhrasesDetectionJobsAsync(ListKeyPhrasesDetectionJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListPiiEntitiesDetectionJobsResponse ListPiiEntitiesDetectionJobs(ListPiiEntitiesDetectionJobsRequest request);



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
        Task<ListPiiEntitiesDetectionJobsResponse> ListPiiEntitiesDetectionJobsAsync(ListPiiEntitiesDetectionJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListSentimentDetectionJobsResponse ListSentimentDetectionJobs(ListSentimentDetectionJobsRequest request);



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
        Task<ListSentimentDetectionJobsResponse> ListSentimentDetectionJobsAsync(ListSentimentDetectionJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListTargetedSentimentDetectionJobsResponse ListTargetedSentimentDetectionJobs(ListTargetedSentimentDetectionJobsRequest request);



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
        Task<ListTargetedSentimentDetectionJobsResponse> ListTargetedSentimentDetectionJobsAsync(ListTargetedSentimentDetectionJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListTopicsDetectionJobsResponse ListTopicsDetectionJobs(ListTopicsDetectionJobsRequest request);



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
        Task<ListTopicsDetectionJobsResponse> ListTopicsDetectionJobsAsync(ListTopicsDetectionJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Attaches a resource-based policy to a custom model. You can use this policy to authorize
        /// an entity in another Amazon Web Services account to import the custom model, which
        /// replicates it in Amazon Comprehend in their account.
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
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);



        /// <summary>
        /// Attaches a resource-based policy to a custom model. You can use this policy to authorize
        /// an entity in another Amazon Web Services account to import the custom model, which
        /// replicates it in Amazon Comprehend in their account.
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
        Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartDocumentClassificationJob


        /// <summary>
        /// Starts an asynchronous document classification job using a custom classification model.
        /// Use the <c>DescribeDocumentClassificationJob</c> operation to track the progress of
        /// the job.
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
        /// <exception cref="Amazon.Comprehend.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartDocumentClassificationJob">REST API Reference for StartDocumentClassificationJob Operation</seealso>
        StartDocumentClassificationJobResponse StartDocumentClassificationJob(StartDocumentClassificationJobRequest request);



        /// <summary>
        /// Starts an asynchronous document classification job using a custom classification model.
        /// Use the <c>DescribeDocumentClassificationJob</c> operation to track the progress of
        /// the job.
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
        /// <exception cref="Amazon.Comprehend.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartDocumentClassificationJob">REST API Reference for StartDocumentClassificationJob Operation</seealso>
        Task<StartDocumentClassificationJobResponse> StartDocumentClassificationJobAsync(StartDocumentClassificationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
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
        StartDominantLanguageDetectionJobResponse StartDominantLanguageDetectionJob(StartDominantLanguageDetectionJobRequest request);



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
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
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
        Task<StartDominantLanguageDetectionJobResponse> StartDominantLanguageDetectionJobAsync(StartDominantLanguageDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartEntitiesDetectionJob


        /// <summary>
        /// Starts an asynchronous entity detection job for a collection of documents. Use the
        /// operation to track the status of a job.
        /// 
        ///  
        /// <para>
        /// This API can be used for either standard entity detection or custom entity recognition.
        /// In order to be used for custom entity recognition, the optional <c>EntityRecognizerArn</c>
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
        /// <exception cref="Amazon.Comprehend.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartEntitiesDetectionJob">REST API Reference for StartEntitiesDetectionJob Operation</seealso>
        StartEntitiesDetectionJobResponse StartEntitiesDetectionJob(StartEntitiesDetectionJobRequest request);



        /// <summary>
        /// Starts an asynchronous entity detection job for a collection of documents. Use the
        /// operation to track the status of a job.
        /// 
        ///  
        /// <para>
        /// This API can be used for either standard entity detection or custom entity recognition.
        /// In order to be used for custom entity recognition, the optional <c>EntityRecognizerArn</c>
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
        /// <exception cref="Amazon.Comprehend.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartEntitiesDetectionJob">REST API Reference for StartEntitiesDetectionJob Operation</seealso>
        Task<StartEntitiesDetectionJobResponse> StartEntitiesDetectionJobAsync(StartEntitiesDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
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
        StartEventsDetectionJobResponse StartEventsDetectionJob(StartEventsDetectionJobRequest request);



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
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
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
        Task<StartEventsDetectionJobResponse> StartEventsDetectionJobAsync(StartEventsDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartFlywheelIteration


        /// <summary>
        /// Start the flywheel iteration.This operation uses any new datasets to train a new model
        /// version. For more information about flywheels, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/flywheels-about.html">
        /// Flywheel overview</a> in the <i>Amazon Comprehend Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFlywheelIteration service method.</param>
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
        StartFlywheelIterationResponse StartFlywheelIteration(StartFlywheelIterationRequest request);



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
        Task<StartFlywheelIterationResponse> StartFlywheelIterationAsync(StartFlywheelIterationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
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
        StartKeyPhrasesDetectionJobResponse StartKeyPhrasesDetectionJob(StartKeyPhrasesDetectionJobRequest request);



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
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
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
        Task<StartKeyPhrasesDetectionJobResponse> StartKeyPhrasesDetectionJobAsync(StartKeyPhrasesDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
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
        StartPiiEntitiesDetectionJobResponse StartPiiEntitiesDetectionJob(StartPiiEntitiesDetectionJobRequest request);



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
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
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
        Task<StartPiiEntitiesDetectionJobResponse> StartPiiEntitiesDetectionJobAsync(StartPiiEntitiesDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
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
        StartSentimentDetectionJobResponse StartSentimentDetectionJob(StartSentimentDetectionJobRequest request);



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
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
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
        Task<StartSentimentDetectionJobResponse> StartSentimentDetectionJobAsync(StartSentimentDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartTargetedSentimentDetectionJob


        /// <summary>
        /// Starts an asynchronous targeted sentiment detection job for a collection of documents.
        /// Use the <c>DescribeTargetedSentimentDetectionJob</c> operation to track the status
        /// of a job.
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
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
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
        StartTargetedSentimentDetectionJobResponse StartTargetedSentimentDetectionJob(StartTargetedSentimentDetectionJobRequest request);



        /// <summary>
        /// Starts an asynchronous targeted sentiment detection job for a collection of documents.
        /// Use the <c>DescribeTargetedSentimentDetectionJob</c> operation to track the status
        /// of a job.
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
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
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
        Task<StartTargetedSentimentDetectionJobResponse> StartTargetedSentimentDetectionJobAsync(StartTargetedSentimentDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartTopicsDetectionJob


        /// <summary>
        /// Starts an asynchronous topic detection job. Use the <c>DescribeTopicDetectionJob</c>
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
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
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
        StartTopicsDetectionJobResponse StartTopicsDetectionJob(StartTopicsDetectionJobRequest request);



        /// <summary>
        /// Starts an asynchronous topic detection job. Use the <c>DescribeTopicDetectionJob</c>
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
        /// <exception cref="Amazon.Comprehend.Model.ResourceInUseException">
        /// The specified resource name is already in use. Use a different name and try your request
        /// again.
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
        Task<StartTopicsDetectionJobResponse> StartTopicsDetectionJobAsync(StartTopicsDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopDominantLanguageDetectionJob


        /// <summary>
        /// Stops a dominant language detection job in progress.
        /// 
        ///  
        /// <para>
        /// If the job state is <c>IN_PROGRESS</c> the job is marked for termination and put into
        /// the <c>STOP_REQUESTED</c> state. If the job completes before it can be stopped, it
        /// is put into the <c>COMPLETED</c> state; otherwise the job is stopped and put into
        /// the <c>STOPPED</c> state.
        /// </para>
        ///  
        /// <para>
        /// If the job is in the <c>COMPLETED</c> or <c>FAILED</c> state when you call the <c>StopDominantLanguageDetectionJob</c>
        /// operation, the operation returns a 400 Internal Request Exception. 
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
        StopDominantLanguageDetectionJobResponse StopDominantLanguageDetectionJob(StopDominantLanguageDetectionJobRequest request);



        /// <summary>
        /// Stops a dominant language detection job in progress.
        /// 
        ///  
        /// <para>
        /// If the job state is <c>IN_PROGRESS</c> the job is marked for termination and put into
        /// the <c>STOP_REQUESTED</c> state. If the job completes before it can be stopped, it
        /// is put into the <c>COMPLETED</c> state; otherwise the job is stopped and put into
        /// the <c>STOPPED</c> state.
        /// </para>
        ///  
        /// <para>
        /// If the job is in the <c>COMPLETED</c> or <c>FAILED</c> state when you call the <c>StopDominantLanguageDetectionJob</c>
        /// operation, the operation returns a 400 Internal Request Exception. 
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
        Task<StopDominantLanguageDetectionJobResponse> StopDominantLanguageDetectionJobAsync(StopDominantLanguageDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopEntitiesDetectionJob


        /// <summary>
        /// Stops an entities detection job in progress.
        /// 
        ///  
        /// <para>
        /// If the job state is <c>IN_PROGRESS</c> the job is marked for termination and put into
        /// the <c>STOP_REQUESTED</c> state. If the job completes before it can be stopped, it
        /// is put into the <c>COMPLETED</c> state; otherwise the job is stopped and put into
        /// the <c>STOPPED</c> state.
        /// </para>
        ///  
        /// <para>
        /// If the job is in the <c>COMPLETED</c> or <c>FAILED</c> state when you call the <c>StopDominantLanguageDetectionJob</c>
        /// operation, the operation returns a 400 Internal Request Exception. 
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
        StopEntitiesDetectionJobResponse StopEntitiesDetectionJob(StopEntitiesDetectionJobRequest request);



        /// <summary>
        /// Stops an entities detection job in progress.
        /// 
        ///  
        /// <para>
        /// If the job state is <c>IN_PROGRESS</c> the job is marked for termination and put into
        /// the <c>STOP_REQUESTED</c> state. If the job completes before it can be stopped, it
        /// is put into the <c>COMPLETED</c> state; otherwise the job is stopped and put into
        /// the <c>STOPPED</c> state.
        /// </para>
        ///  
        /// <para>
        /// If the job is in the <c>COMPLETED</c> or <c>FAILED</c> state when you call the <c>StopDominantLanguageDetectionJob</c>
        /// operation, the operation returns a 400 Internal Request Exception. 
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
        Task<StopEntitiesDetectionJobResponse> StopEntitiesDetectionJobAsync(StopEntitiesDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StopEventsDetectionJobResponse StopEventsDetectionJob(StopEventsDetectionJobRequest request);



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
        Task<StopEventsDetectionJobResponse> StopEventsDetectionJobAsync(StopEventsDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopKeyPhrasesDetectionJob


        /// <summary>
        /// Stops a key phrases detection job in progress.
        /// 
        ///  
        /// <para>
        /// If the job state is <c>IN_PROGRESS</c> the job is marked for termination and put into
        /// the <c>STOP_REQUESTED</c> state. If the job completes before it can be stopped, it
        /// is put into the <c>COMPLETED</c> state; otherwise the job is stopped and put into
        /// the <c>STOPPED</c> state.
        /// </para>
        ///  
        /// <para>
        /// If the job is in the <c>COMPLETED</c> or <c>FAILED</c> state when you call the <c>StopDominantLanguageDetectionJob</c>
        /// operation, the operation returns a 400 Internal Request Exception. 
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
        StopKeyPhrasesDetectionJobResponse StopKeyPhrasesDetectionJob(StopKeyPhrasesDetectionJobRequest request);



        /// <summary>
        /// Stops a key phrases detection job in progress.
        /// 
        ///  
        /// <para>
        /// If the job state is <c>IN_PROGRESS</c> the job is marked for termination and put into
        /// the <c>STOP_REQUESTED</c> state. If the job completes before it can be stopped, it
        /// is put into the <c>COMPLETED</c> state; otherwise the job is stopped and put into
        /// the <c>STOPPED</c> state.
        /// </para>
        ///  
        /// <para>
        /// If the job is in the <c>COMPLETED</c> or <c>FAILED</c> state when you call the <c>StopDominantLanguageDetectionJob</c>
        /// operation, the operation returns a 400 Internal Request Exception. 
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
        Task<StopKeyPhrasesDetectionJobResponse> StopKeyPhrasesDetectionJobAsync(StopKeyPhrasesDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        StopPiiEntitiesDetectionJobResponse StopPiiEntitiesDetectionJob(StopPiiEntitiesDetectionJobRequest request);



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
        Task<StopPiiEntitiesDetectionJobResponse> StopPiiEntitiesDetectionJobAsync(StopPiiEntitiesDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopSentimentDetectionJob


        /// <summary>
        /// Stops a sentiment detection job in progress.
        /// 
        ///  
        /// <para>
        /// If the job state is <c>IN_PROGRESS</c>, the job is marked for termination and put
        /// into the <c>STOP_REQUESTED</c> state. If the job completes before it can be stopped,
        /// it is put into the <c>COMPLETED</c> state; otherwise the job is be stopped and put
        /// into the <c>STOPPED</c> state.
        /// </para>
        ///  
        /// <para>
        /// If the job is in the <c>COMPLETED</c> or <c>FAILED</c> state when you call the <c>StopDominantLanguageDetectionJob</c>
        /// operation, the operation returns a 400 Internal Request Exception. 
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
        StopSentimentDetectionJobResponse StopSentimentDetectionJob(StopSentimentDetectionJobRequest request);



        /// <summary>
        /// Stops a sentiment detection job in progress.
        /// 
        ///  
        /// <para>
        /// If the job state is <c>IN_PROGRESS</c>, the job is marked for termination and put
        /// into the <c>STOP_REQUESTED</c> state. If the job completes before it can be stopped,
        /// it is put into the <c>COMPLETED</c> state; otherwise the job is be stopped and put
        /// into the <c>STOPPED</c> state.
        /// </para>
        ///  
        /// <para>
        /// If the job is in the <c>COMPLETED</c> or <c>FAILED</c> state when you call the <c>StopDominantLanguageDetectionJob</c>
        /// operation, the operation returns a 400 Internal Request Exception. 
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
        Task<StopSentimentDetectionJobResponse> StopSentimentDetectionJobAsync(StopSentimentDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopTargetedSentimentDetectionJob


        /// <summary>
        /// Stops a targeted sentiment detection job in progress.
        /// 
        ///  
        /// <para>
        /// If the job state is <c>IN_PROGRESS</c>, the job is marked for termination and put
        /// into the <c>STOP_REQUESTED</c> state. If the job completes before it can be stopped,
        /// it is put into the <c>COMPLETED</c> state; otherwise the job is be stopped and put
        /// into the <c>STOPPED</c> state.
        /// </para>
        ///  
        /// <para>
        /// If the job is in the <c>COMPLETED</c> or <c>FAILED</c> state when you call the <c>StopDominantLanguageDetectionJob</c>
        /// operation, the operation returns a 400 Internal Request Exception. 
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
        StopTargetedSentimentDetectionJobResponse StopTargetedSentimentDetectionJob(StopTargetedSentimentDetectionJobRequest request);



        /// <summary>
        /// Stops a targeted sentiment detection job in progress.
        /// 
        ///  
        /// <para>
        /// If the job state is <c>IN_PROGRESS</c>, the job is marked for termination and put
        /// into the <c>STOP_REQUESTED</c> state. If the job completes before it can be stopped,
        /// it is put into the <c>COMPLETED</c> state; otherwise the job is be stopped and put
        /// into the <c>STOPPED</c> state.
        /// </para>
        ///  
        /// <para>
        /// If the job is in the <c>COMPLETED</c> or <c>FAILED</c> state when you call the <c>StopDominantLanguageDetectionJob</c>
        /// operation, the operation returns a 400 Internal Request Exception. 
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
        Task<StopTargetedSentimentDetectionJobResponse> StopTargetedSentimentDetectionJobAsync(StopTargetedSentimentDetectionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopTrainingDocumentClassifier


        /// <summary>
        /// Stops a document classifier training job while in progress.
        /// 
        ///  
        /// <para>
        /// If the training job state is <c>TRAINING</c>, the job is marked for termination and
        /// put into the <c>STOP_REQUESTED</c> state. If the training job completes before it
        /// can be stopped, it is put into the <c>TRAINED</c>; otherwise the training job is stopped
        /// and put into the <c>STOPPED</c> state and the service sends back an HTTP 200 response
        /// with an empty HTTP body. 
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
        StopTrainingDocumentClassifierResponse StopTrainingDocumentClassifier(StopTrainingDocumentClassifierRequest request);



        /// <summary>
        /// Stops a document classifier training job while in progress.
        /// 
        ///  
        /// <para>
        /// If the training job state is <c>TRAINING</c>, the job is marked for termination and
        /// put into the <c>STOP_REQUESTED</c> state. If the training job completes before it
        /// can be stopped, it is put into the <c>TRAINED</c>; otherwise the training job is stopped
        /// and put into the <c>STOPPED</c> state and the service sends back an HTTP 200 response
        /// with an empty HTTP body. 
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
        Task<StopTrainingDocumentClassifierResponse> StopTrainingDocumentClassifierAsync(StopTrainingDocumentClassifierRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopTrainingEntityRecognizer


        /// <summary>
        /// Stops an entity recognizer training job while in progress.
        /// 
        ///  
        /// <para>
        /// If the training job state is <c>TRAINING</c>, the job is marked for termination and
        /// put into the <c>STOP_REQUESTED</c> state. If the training job completes before it
        /// can be stopped, it is put into the <c>TRAINED</c>; otherwise the training job is stopped
        /// and putted into the <c>STOPPED</c> state and the service sends back an HTTP 200 response
        /// with an empty HTTP body.
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
        StopTrainingEntityRecognizerResponse StopTrainingEntityRecognizer(StopTrainingEntityRecognizerRequest request);



        /// <summary>
        /// Stops an entity recognizer training job while in progress.
        /// 
        ///  
        /// <para>
        /// If the training job state is <c>TRAINING</c>, the job is marked for termination and
        /// put into the <c>STOP_REQUESTED</c> state. If the training job completes before it
        /// can be stopped, it is put into the <c>TRAINED</c>; otherwise the training job is stopped
        /// and putted into the <c>STOPPED</c> state and the service sends back an HTTP 200 response
        /// with an empty HTTP body.
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
        Task<StopTrainingEntityRecognizerResponse> StopTrainingEntityRecognizerAsync(StopTrainingEntityRecognizerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        TagResourceResponse TagResource(TagResourceRequest request);



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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UntagResourceResponse UntagResource(UntagResourceRequest request);



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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateEndpointResponse UpdateEndpoint(UpdateEndpointRequest request);



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
        Task<UpdateEndpointResponse> UpdateEndpointAsync(UpdateEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFlywheel


        /// <summary>
        /// Update the configuration information for an existing flywheel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlywheel service method.</param>
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
        UpdateFlywheelResponse UpdateFlywheel(UpdateFlywheelRequest request);



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
        Task<UpdateFlywheelResponse> UpdateFlywheelAsync(UpdateFlywheelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}