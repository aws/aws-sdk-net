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

using Amazon.Runtime;
using Amazon.Comprehend.Model;

namespace Amazon.Comprehend
{
    /// <summary>
    /// Interface for accessing Comprehend
    ///
    /// Amazon Comprehend is an AWS service for gaining insight into the content of documents.
    /// Use these actions to determine the topics contained in your documents, the topics
    /// they discuss, the predominant sentiment expressed in them, the predominant language
    /// used, and more.
    /// </summary>
    public partial interface IAmazonComprehend : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IComprehendPaginatorFactory Paginators { get; }
#endif


        
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
        IAsyncResult BeginBatchDetectDominantLanguage(BatchDetectDominantLanguageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDetectDominantLanguage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDetectDominantLanguage.</param>
        /// 
        /// <returns>Returns a  BatchDetectDominantLanguageResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectDominantLanguage">REST API Reference for BatchDetectDominantLanguage Operation</seealso>
        BatchDetectDominantLanguageResponse EndBatchDetectDominantLanguage(IAsyncResult asyncResult);

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
        BatchDetectEntitiesResponse BatchDetectEntities(BatchDetectEntitiesRequest request);

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
        IAsyncResult BeginBatchDetectEntities(BatchDetectEntitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDetectEntities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDetectEntities.</param>
        /// 
        /// <returns>Returns a  BatchDetectEntitiesResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectEntities">REST API Reference for BatchDetectEntities Operation</seealso>
        BatchDetectEntitiesResponse EndBatchDetectEntities(IAsyncResult asyncResult);

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
        BatchDetectKeyPhrasesResponse BatchDetectKeyPhrases(BatchDetectKeyPhrasesRequest request);

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
        IAsyncResult BeginBatchDetectKeyPhrases(BatchDetectKeyPhrasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDetectKeyPhrases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDetectKeyPhrases.</param>
        /// 
        /// <returns>Returns a  BatchDetectKeyPhrasesResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectKeyPhrases">REST API Reference for BatchDetectKeyPhrases Operation</seealso>
        BatchDetectKeyPhrasesResponse EndBatchDetectKeyPhrases(IAsyncResult asyncResult);

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
        BatchDetectSentimentResponse BatchDetectSentiment(BatchDetectSentimentRequest request);

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
        IAsyncResult BeginBatchDetectSentiment(BatchDetectSentimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDetectSentiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDetectSentiment.</param>
        /// 
        /// <returns>Returns a  BatchDetectSentimentResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectSentiment">REST API Reference for BatchDetectSentiment Operation</seealso>
        BatchDetectSentimentResponse EndBatchDetectSentiment(IAsyncResult asyncResult);

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
        BatchDetectSyntaxResponse BatchDetectSyntax(BatchDetectSyntaxRequest request);

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
        IAsyncResult BeginBatchDetectSyntax(BatchDetectSyntaxRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDetectSyntax operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDetectSyntax.</param>
        /// 
        /// <returns>Returns a  BatchDetectSyntaxResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectSyntax">REST API Reference for BatchDetectSyntax Operation</seealso>
        BatchDetectSyntaxResponse EndBatchDetectSyntax(IAsyncResult asyncResult);

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
        BatchDetectTargetedSentimentResponse BatchDetectTargetedSentiment(BatchDetectTargetedSentimentRequest request);

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
        IAsyncResult BeginBatchDetectTargetedSentiment(BatchDetectTargetedSentimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDetectTargetedSentiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDetectTargetedSentiment.</param>
        /// 
        /// <returns>Returns a  BatchDetectTargetedSentimentResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/BatchDetectTargetedSentiment">REST API Reference for BatchDetectTargetedSentiment Operation</seealso>
        BatchDetectTargetedSentimentResponse EndBatchDetectTargetedSentiment(IAsyncResult asyncResult);

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
        ClassifyDocumentResponse ClassifyDocument(ClassifyDocumentRequest request);

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
        IAsyncResult BeginClassifyDocument(ClassifyDocumentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ClassifyDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginClassifyDocument.</param>
        /// 
        /// <returns>Returns a  ClassifyDocumentResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ClassifyDocument">REST API Reference for ClassifyDocument Operation</seealso>
        ClassifyDocumentResponse EndClassifyDocument(IAsyncResult asyncResult);

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
        ContainsPiiEntitiesResponse ContainsPiiEntities(ContainsPiiEntitiesRequest request);

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
        IAsyncResult BeginContainsPiiEntities(ContainsPiiEntitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ContainsPiiEntities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginContainsPiiEntities.</param>
        /// 
        /// <returns>Returns a  ContainsPiiEntitiesResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ContainsPiiEntities">REST API Reference for ContainsPiiEntities Operation</seealso>
        ContainsPiiEntitiesResponse EndContainsPiiEntities(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataset operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        IAsyncResult BeginCreateDataset(CreateDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataset.</param>
        /// 
        /// <returns>Returns a  CreateDatasetResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateDataset">REST API Reference for CreateDataset Operation</seealso>
        CreateDatasetResponse EndCreateDataset(IAsyncResult asyncResult);

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
        CreateDocumentClassifierResponse CreateDocumentClassifier(CreateDocumentClassifierRequest request);

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
        IAsyncResult BeginCreateDocumentClassifier(CreateDocumentClassifierRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDocumentClassifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDocumentClassifier.</param>
        /// 
        /// <returns>Returns a  CreateDocumentClassifierResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateDocumentClassifier">REST API Reference for CreateDocumentClassifier Operation</seealso>
        CreateDocumentClassifierResponse EndCreateDocumentClassifier(IAsyncResult asyncResult);

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
        IAsyncResult BeginCreateEndpoint(CreateEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateEndpointResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        CreateEndpointResponse EndCreateEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEntityRecognizer


        /// <summary>
        /// Creates an entity recognizer using submitted files. After your <code>CreateEntityRecognizer</code>
        /// request is submitted, you can check job status using the <code>DescribeEntityRecognizer</code>
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
        /// Amazon Comprehend can't process the language of the input text. For custom entity
        /// recognition APIs, only English, Spanish, French, Italian, German, or Portuguese are
        /// accepted. For a list of supported languages, <a href="https://docs.aws.amazon.com/comprehend/latest/dg/supported-languages.html">Supported
        /// languages</a> in the Comprehend Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateEntityRecognizer">REST API Reference for CreateEntityRecognizer Operation</seealso>
        CreateEntityRecognizerResponse CreateEntityRecognizer(CreateEntityRecognizerRequest request);

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
        IAsyncResult BeginCreateEntityRecognizer(CreateEntityRecognizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEntityRecognizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEntityRecognizer.</param>
        /// 
        /// <returns>Returns a  CreateEntityRecognizerResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateEntityRecognizer">REST API Reference for CreateEntityRecognizer Operation</seealso>
        CreateEntityRecognizerResponse EndCreateEntityRecognizer(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFlywheel


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
        CreateFlywheelResponse CreateFlywheel(CreateFlywheelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFlywheel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFlywheel operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFlywheel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateFlywheel">REST API Reference for CreateFlywheel Operation</seealso>
        IAsyncResult BeginCreateFlywheel(CreateFlywheelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFlywheel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFlywheel.</param>
        /// 
        /// <returns>Returns a  CreateFlywheelResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/CreateFlywheel">REST API Reference for CreateFlywheel Operation</seealso>
        CreateFlywheelResponse EndCreateFlywheel(IAsyncResult asyncResult);

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
        DeleteDocumentClassifierResponse DeleteDocumentClassifier(DeleteDocumentClassifierRequest request);

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
        IAsyncResult BeginDeleteDocumentClassifier(DeleteDocumentClassifierRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDocumentClassifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDocumentClassifier.</param>
        /// 
        /// <returns>Returns a  DeleteDocumentClassifierResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DeleteDocumentClassifier">REST API Reference for DeleteDocumentClassifier Operation</seealso>
        DeleteDocumentClassifierResponse EndDeleteDocumentClassifier(IAsyncResult asyncResult);

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
        IAsyncResult BeginDeleteEndpoint(DeleteEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        DeleteEndpointResponse EndDeleteEndpoint(IAsyncResult asyncResult);

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
        DeleteEntityRecognizerResponse DeleteEntityRecognizer(DeleteEntityRecognizerRequest request);

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
        IAsyncResult BeginDeleteEntityRecognizer(DeleteEntityRecognizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEntityRecognizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEntityRecognizer.</param>
        /// 
        /// <returns>Returns a  DeleteEntityRecognizerResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DeleteEntityRecognizer">REST API Reference for DeleteEntityRecognizer Operation</seealso>
        DeleteEntityRecognizerResponse EndDeleteEntityRecognizer(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteFlywheel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlywheel operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFlywheel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DeleteFlywheel">REST API Reference for DeleteFlywheel Operation</seealso>
        IAsyncResult BeginDeleteFlywheel(DeleteFlywheelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFlywheel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFlywheel.</param>
        /// 
        /// <returns>Returns a  DeleteFlywheelResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DeleteFlywheel">REST API Reference for DeleteFlywheel Operation</seealso>
        DeleteFlywheelResponse EndDeleteFlywheel(IAsyncResult asyncResult);

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
        IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataset
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        IAsyncResult BeginDescribeDataset(DescribeDatasetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataset operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataset.</param>
        /// 
        /// <returns>Returns a  DescribeDatasetResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeDataset">REST API Reference for DescribeDataset Operation</seealso>
        DescribeDatasetResponse EndDescribeDataset(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeDocumentClassificationJob(DescribeDocumentClassificationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDocumentClassificationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDocumentClassificationJob.</param>
        /// 
        /// <returns>Returns a  DescribeDocumentClassificationJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeDocumentClassificationJob">REST API Reference for DescribeDocumentClassificationJob Operation</seealso>
        DescribeDocumentClassificationJobResponse EndDescribeDocumentClassificationJob(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeDocumentClassifier(DescribeDocumentClassifierRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDocumentClassifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDocumentClassifier.</param>
        /// 
        /// <returns>Returns a  DescribeDocumentClassifierResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeDocumentClassifier">REST API Reference for DescribeDocumentClassifier Operation</seealso>
        DescribeDocumentClassifierResponse EndDescribeDocumentClassifier(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeDominantLanguageDetectionJob(DescribeDominantLanguageDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDominantLanguageDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDominantLanguageDetectionJob.</param>
        /// 
        /// <returns>Returns a  DescribeDominantLanguageDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeDominantLanguageDetectionJob">REST API Reference for DescribeDominantLanguageDetectionJob Operation</seealso>
        DescribeDominantLanguageDetectionJobResponse EndDescribeDominantLanguageDetectionJob(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeEndpoint(DescribeEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpoint.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        DescribeEndpointResponse EndDescribeEndpoint(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeEntitiesDetectionJob(DescribeEntitiesDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEntitiesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEntitiesDetectionJob.</param>
        /// 
        /// <returns>Returns a  DescribeEntitiesDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeEntitiesDetectionJob">REST API Reference for DescribeEntitiesDetectionJob Operation</seealso>
        DescribeEntitiesDetectionJobResponse EndDescribeEntitiesDetectionJob(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeEntityRecognizer(DescribeEntityRecognizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEntityRecognizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEntityRecognizer.</param>
        /// 
        /// <returns>Returns a  DescribeEntityRecognizerResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeEntityRecognizer">REST API Reference for DescribeEntityRecognizer Operation</seealso>
        DescribeEntityRecognizerResponse EndDescribeEntityRecognizer(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeEventsDetectionJob(DescribeEventsDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventsDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventsDetectionJob.</param>
        /// 
        /// <returns>Returns a  DescribeEventsDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeEventsDetectionJob">REST API Reference for DescribeEventsDetectionJob Operation</seealso>
        DescribeEventsDetectionJobResponse EndDescribeEventsDetectionJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DescribeFlywheel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlywheel operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFlywheel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeFlywheel">REST API Reference for DescribeFlywheel Operation</seealso>
        IAsyncResult BeginDescribeFlywheel(DescribeFlywheelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFlywheel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFlywheel.</param>
        /// 
        /// <returns>Returns a  DescribeFlywheelResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeFlywheel">REST API Reference for DescribeFlywheel Operation</seealso>
        DescribeFlywheelResponse EndDescribeFlywheel(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DescribeFlywheelIteration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlywheelIteration operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFlywheelIteration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeFlywheelIteration">REST API Reference for DescribeFlywheelIteration Operation</seealso>
        IAsyncResult BeginDescribeFlywheelIteration(DescribeFlywheelIterationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFlywheelIteration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFlywheelIteration.</param>
        /// 
        /// <returns>Returns a  DescribeFlywheelIterationResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeFlywheelIteration">REST API Reference for DescribeFlywheelIteration Operation</seealso>
        DescribeFlywheelIterationResponse EndDescribeFlywheelIteration(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeKeyPhrasesDetectionJob(DescribeKeyPhrasesDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeKeyPhrasesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeKeyPhrasesDetectionJob.</param>
        /// 
        /// <returns>Returns a  DescribeKeyPhrasesDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeKeyPhrasesDetectionJob">REST API Reference for DescribeKeyPhrasesDetectionJob Operation</seealso>
        DescribeKeyPhrasesDetectionJobResponse EndDescribeKeyPhrasesDetectionJob(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribePiiEntitiesDetectionJob(DescribePiiEntitiesDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePiiEntitiesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePiiEntitiesDetectionJob.</param>
        /// 
        /// <returns>Returns a  DescribePiiEntitiesDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribePiiEntitiesDetectionJob">REST API Reference for DescribePiiEntitiesDetectionJob Operation</seealso>
        DescribePiiEntitiesDetectionJobResponse EndDescribePiiEntitiesDetectionJob(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeResourcePolicy(DescribeResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DescribeResourcePolicyResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeResourcePolicy">REST API Reference for DescribeResourcePolicy Operation</seealso>
        DescribeResourcePolicyResponse EndDescribeResourcePolicy(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeSentimentDetectionJob(DescribeSentimentDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSentimentDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSentimentDetectionJob.</param>
        /// 
        /// <returns>Returns a  DescribeSentimentDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeSentimentDetectionJob">REST API Reference for DescribeSentimentDetectionJob Operation</seealso>
        DescribeSentimentDetectionJobResponse EndDescribeSentimentDetectionJob(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeTargetedSentimentDetectionJob(DescribeTargetedSentimentDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTargetedSentimentDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTargetedSentimentDetectionJob.</param>
        /// 
        /// <returns>Returns a  DescribeTargetedSentimentDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeTargetedSentimentDetectionJob">REST API Reference for DescribeTargetedSentimentDetectionJob Operation</seealso>
        DescribeTargetedSentimentDetectionJobResponse EndDescribeTargetedSentimentDetectionJob(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeTopicsDetectionJob(DescribeTopicsDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTopicsDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTopicsDetectionJob.</param>
        /// 
        /// <returns>Returns a  DescribeTopicsDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DescribeTopicsDetectionJob">REST API Reference for DescribeTopicsDetectionJob Operation</seealso>
        DescribeTopicsDetectionJobResponse EndDescribeTopicsDetectionJob(IAsyncResult asyncResult);

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
        IAsyncResult BeginDetectDominantLanguage(DetectDominantLanguageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetectDominantLanguage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectDominantLanguage.</param>
        /// 
        /// <returns>Returns a  DetectDominantLanguageResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectDominantLanguage">REST API Reference for DetectDominantLanguage Operation</seealso>
        DetectDominantLanguageResponse EndDetectDominantLanguage(IAsyncResult asyncResult);

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
        DetectEntitiesResponse DetectEntities(DetectEntitiesRequest request);

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
        IAsyncResult BeginDetectEntities(DetectEntitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetectEntities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectEntities.</param>
        /// 
        /// <returns>Returns a  DetectEntitiesResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectEntities">REST API Reference for DetectEntities Operation</seealso>
        DetectEntitiesResponse EndDetectEntities(IAsyncResult asyncResult);

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
        DetectKeyPhrasesResponse DetectKeyPhrases(DetectKeyPhrasesRequest request);

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
        IAsyncResult BeginDetectKeyPhrases(DetectKeyPhrasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetectKeyPhrases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectKeyPhrases.</param>
        /// 
        /// <returns>Returns a  DetectKeyPhrasesResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectKeyPhrases">REST API Reference for DetectKeyPhrases Operation</seealso>
        DetectKeyPhrasesResponse EndDetectKeyPhrases(IAsyncResult asyncResult);

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
        DetectPiiEntitiesResponse DetectPiiEntities(DetectPiiEntitiesRequest request);

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
        IAsyncResult BeginDetectPiiEntities(DetectPiiEntitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetectPiiEntities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectPiiEntities.</param>
        /// 
        /// <returns>Returns a  DetectPiiEntitiesResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectPiiEntities">REST API Reference for DetectPiiEntities Operation</seealso>
        DetectPiiEntitiesResponse EndDetectPiiEntities(IAsyncResult asyncResult);

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
        DetectSentimentResponse DetectSentiment(DetectSentimentRequest request);

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
        IAsyncResult BeginDetectSentiment(DetectSentimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetectSentiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectSentiment.</param>
        /// 
        /// <returns>Returns a  DetectSentimentResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectSentiment">REST API Reference for DetectSentiment Operation</seealso>
        DetectSentimentResponse EndDetectSentiment(IAsyncResult asyncResult);

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
        DetectSyntaxResponse DetectSyntax(DetectSyntaxRequest request);

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
        IAsyncResult BeginDetectSyntax(DetectSyntaxRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetectSyntax operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectSyntax.</param>
        /// 
        /// <returns>Returns a  DetectSyntaxResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectSyntax">REST API Reference for DetectSyntax Operation</seealso>
        DetectSyntaxResponse EndDetectSyntax(IAsyncResult asyncResult);

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
        DetectTargetedSentimentResponse DetectTargetedSentiment(DetectTargetedSentimentRequest request);

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
        IAsyncResult BeginDetectTargetedSentiment(DetectTargetedSentimentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetectTargetedSentiment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetectTargetedSentiment.</param>
        /// 
        /// <returns>Returns a  DetectTargetedSentimentResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/DetectTargetedSentiment">REST API Reference for DetectTargetedSentiment Operation</seealso>
        DetectTargetedSentimentResponse EndDetectTargetedSentiment(IAsyncResult asyncResult);

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
        ImportModelResponse ImportModel(ImportModelRequest request);

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
        IAsyncResult BeginImportModel(ImportModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportModel.</param>
        /// 
        /// <returns>Returns a  ImportModelResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ImportModel">REST API Reference for ImportModel Operation</seealso>
        ImportModelResponse EndImportModel(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDatasets


        /// <summary>
        /// List the datasets that you have configured in this region. For more information about
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
        /// Initiates the asynchronous execution of the ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatasets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        IAsyncResult BeginListDatasets(ListDatasetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatasets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatasets.</param>
        /// 
        /// <returns>Returns a  ListDatasetsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDatasets">REST API Reference for ListDatasets Operation</seealso>
        ListDatasetsResponse EndListDatasets(IAsyncResult asyncResult);

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
        IAsyncResult BeginListDocumentClassificationJobs(ListDocumentClassificationJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDocumentClassificationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDocumentClassificationJobs.</param>
        /// 
        /// <returns>Returns a  ListDocumentClassificationJobsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDocumentClassificationJobs">REST API Reference for ListDocumentClassificationJobs Operation</seealso>
        ListDocumentClassificationJobsResponse EndListDocumentClassificationJobs(IAsyncResult asyncResult);

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
        IAsyncResult BeginListDocumentClassifiers(ListDocumentClassifiersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDocumentClassifiers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDocumentClassifiers.</param>
        /// 
        /// <returns>Returns a  ListDocumentClassifiersResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDocumentClassifiers">REST API Reference for ListDocumentClassifiers Operation</seealso>
        ListDocumentClassifiersResponse EndListDocumentClassifiers(IAsyncResult asyncResult);

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
        IAsyncResult BeginListDocumentClassifierSummaries(ListDocumentClassifierSummariesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDocumentClassifierSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDocumentClassifierSummaries.</param>
        /// 
        /// <returns>Returns a  ListDocumentClassifierSummariesResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDocumentClassifierSummaries">REST API Reference for ListDocumentClassifierSummaries Operation</seealso>
        ListDocumentClassifierSummariesResponse EndListDocumentClassifierSummaries(IAsyncResult asyncResult);

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
        IAsyncResult BeginListDominantLanguageDetectionJobs(ListDominantLanguageDetectionJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDominantLanguageDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDominantLanguageDetectionJobs.</param>
        /// 
        /// <returns>Returns a  ListDominantLanguageDetectionJobsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListDominantLanguageDetectionJobs">REST API Reference for ListDominantLanguageDetectionJobs Operation</seealso>
        ListDominantLanguageDetectionJobsResponse EndListDominantLanguageDetectionJobs(IAsyncResult asyncResult);

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
        IAsyncResult BeginListEndpoints(ListEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEndpoints.</param>
        /// 
        /// <returns>Returns a  ListEndpointsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        ListEndpointsResponse EndListEndpoints(IAsyncResult asyncResult);

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
        IAsyncResult BeginListEntitiesDetectionJobs(ListEntitiesDetectionJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEntitiesDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEntitiesDetectionJobs.</param>
        /// 
        /// <returns>Returns a  ListEntitiesDetectionJobsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEntitiesDetectionJobs">REST API Reference for ListEntitiesDetectionJobs Operation</seealso>
        ListEntitiesDetectionJobsResponse EndListEntitiesDetectionJobs(IAsyncResult asyncResult);

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
        IAsyncResult BeginListEntityRecognizers(ListEntityRecognizersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEntityRecognizers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEntityRecognizers.</param>
        /// 
        /// <returns>Returns a  ListEntityRecognizersResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEntityRecognizers">REST API Reference for ListEntityRecognizers Operation</seealso>
        ListEntityRecognizersResponse EndListEntityRecognizers(IAsyncResult asyncResult);

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
        IAsyncResult BeginListEntityRecognizerSummaries(ListEntityRecognizerSummariesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEntityRecognizerSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEntityRecognizerSummaries.</param>
        /// 
        /// <returns>Returns a  ListEntityRecognizerSummariesResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEntityRecognizerSummaries">REST API Reference for ListEntityRecognizerSummaries Operation</seealso>
        ListEntityRecognizerSummariesResponse EndListEntityRecognizerSummaries(IAsyncResult asyncResult);

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
        IAsyncResult BeginListEventsDetectionJobs(ListEventsDetectionJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventsDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventsDetectionJobs.</param>
        /// 
        /// <returns>Returns a  ListEventsDetectionJobsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListEventsDetectionJobs">REST API Reference for ListEventsDetectionJobs Operation</seealso>
        ListEventsDetectionJobsResponse EndListEventsDetectionJobs(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListFlywheelIterationHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFlywheelIterationHistory operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFlywheelIterationHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListFlywheelIterationHistory">REST API Reference for ListFlywheelIterationHistory Operation</seealso>
        IAsyncResult BeginListFlywheelIterationHistory(ListFlywheelIterationHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFlywheelIterationHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFlywheelIterationHistory.</param>
        /// 
        /// <returns>Returns a  ListFlywheelIterationHistoryResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListFlywheelIterationHistory">REST API Reference for ListFlywheelIterationHistory Operation</seealso>
        ListFlywheelIterationHistoryResponse EndListFlywheelIterationHistory(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListFlywheels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFlywheels operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFlywheels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListFlywheels">REST API Reference for ListFlywheels Operation</seealso>
        IAsyncResult BeginListFlywheels(ListFlywheelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFlywheels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFlywheels.</param>
        /// 
        /// <returns>Returns a  ListFlywheelsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListFlywheels">REST API Reference for ListFlywheels Operation</seealso>
        ListFlywheelsResponse EndListFlywheels(IAsyncResult asyncResult);

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
        IAsyncResult BeginListKeyPhrasesDetectionJobs(ListKeyPhrasesDetectionJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListKeyPhrasesDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKeyPhrasesDetectionJobs.</param>
        /// 
        /// <returns>Returns a  ListKeyPhrasesDetectionJobsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListKeyPhrasesDetectionJobs">REST API Reference for ListKeyPhrasesDetectionJobs Operation</seealso>
        ListKeyPhrasesDetectionJobsResponse EndListKeyPhrasesDetectionJobs(IAsyncResult asyncResult);

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
        IAsyncResult BeginListPiiEntitiesDetectionJobs(ListPiiEntitiesDetectionJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPiiEntitiesDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPiiEntitiesDetectionJobs.</param>
        /// 
        /// <returns>Returns a  ListPiiEntitiesDetectionJobsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListPiiEntitiesDetectionJobs">REST API Reference for ListPiiEntitiesDetectionJobs Operation</seealso>
        ListPiiEntitiesDetectionJobsResponse EndListPiiEntitiesDetectionJobs(IAsyncResult asyncResult);

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
        IAsyncResult BeginListSentimentDetectionJobs(ListSentimentDetectionJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSentimentDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSentimentDetectionJobs.</param>
        /// 
        /// <returns>Returns a  ListSentimentDetectionJobsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListSentimentDetectionJobs">REST API Reference for ListSentimentDetectionJobs Operation</seealso>
        ListSentimentDetectionJobsResponse EndListSentimentDetectionJobs(IAsyncResult asyncResult);

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
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        IAsyncResult BeginListTargetedSentimentDetectionJobs(ListTargetedSentimentDetectionJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTargetedSentimentDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTargetedSentimentDetectionJobs.</param>
        /// 
        /// <returns>Returns a  ListTargetedSentimentDetectionJobsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListTargetedSentimentDetectionJobs">REST API Reference for ListTargetedSentimentDetectionJobs Operation</seealso>
        ListTargetedSentimentDetectionJobsResponse EndListTargetedSentimentDetectionJobs(IAsyncResult asyncResult);

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
        IAsyncResult BeginListTopicsDetectionJobs(ListTopicsDetectionJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTopicsDetectionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTopicsDetectionJobs.</param>
        /// 
        /// <returns>Returns a  ListTopicsDetectionJobsResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/ListTopicsDetectionJobs">REST API Reference for ListTopicsDetectionJobs Operation</seealso>
        ListTopicsDetectionJobsResponse EndListTopicsDetectionJobs(IAsyncResult asyncResult);

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
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);

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
        IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  StartDocumentClassificationJob


        /// <summary>
        /// Starts an asynchronous document classification job. Use the <code>DescribeDocumentClassificationJob</code>
        /// operation to track the progress of the job.
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
        StartDocumentClassificationJobResponse StartDocumentClassificationJob(StartDocumentClassificationJobRequest request);

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
        IAsyncResult BeginStartDocumentClassificationJob(StartDocumentClassificationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartDocumentClassificationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDocumentClassificationJob.</param>
        /// 
        /// <returns>Returns a  StartDocumentClassificationJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartDocumentClassificationJob">REST API Reference for StartDocumentClassificationJob Operation</seealso>
        StartDocumentClassificationJobResponse EndStartDocumentClassificationJob(IAsyncResult asyncResult);

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
        StartDominantLanguageDetectionJobResponse StartDominantLanguageDetectionJob(StartDominantLanguageDetectionJobRequest request);

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
        IAsyncResult BeginStartDominantLanguageDetectionJob(StartDominantLanguageDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartDominantLanguageDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDominantLanguageDetectionJob.</param>
        /// 
        /// <returns>Returns a  StartDominantLanguageDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartDominantLanguageDetectionJob">REST API Reference for StartDominantLanguageDetectionJob Operation</seealso>
        StartDominantLanguageDetectionJobResponse EndStartDominantLanguageDetectionJob(IAsyncResult asyncResult);

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
        StartEntitiesDetectionJobResponse StartEntitiesDetectionJob(StartEntitiesDetectionJobRequest request);

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
        IAsyncResult BeginStartEntitiesDetectionJob(StartEntitiesDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartEntitiesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartEntitiesDetectionJob.</param>
        /// 
        /// <returns>Returns a  StartEntitiesDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartEntitiesDetectionJob">REST API Reference for StartEntitiesDetectionJob Operation</seealso>
        StartEntitiesDetectionJobResponse EndStartEntitiesDetectionJob(IAsyncResult asyncResult);

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
        StartEventsDetectionJobResponse StartEventsDetectionJob(StartEventsDetectionJobRequest request);

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
        IAsyncResult BeginStartEventsDetectionJob(StartEventsDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartEventsDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartEventsDetectionJob.</param>
        /// 
        /// <returns>Returns a  StartEventsDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartEventsDetectionJob">REST API Reference for StartEventsDetectionJob Operation</seealso>
        StartEventsDetectionJobResponse EndStartEventsDetectionJob(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the StartFlywheelIteration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFlywheelIteration operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartFlywheelIteration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartFlywheelIteration">REST API Reference for StartFlywheelIteration Operation</seealso>
        IAsyncResult BeginStartFlywheelIteration(StartFlywheelIterationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartFlywheelIteration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartFlywheelIteration.</param>
        /// 
        /// <returns>Returns a  StartFlywheelIterationResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartFlywheelIteration">REST API Reference for StartFlywheelIteration Operation</seealso>
        StartFlywheelIterationResponse EndStartFlywheelIteration(IAsyncResult asyncResult);

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
        StartKeyPhrasesDetectionJobResponse StartKeyPhrasesDetectionJob(StartKeyPhrasesDetectionJobRequest request);

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
        IAsyncResult BeginStartKeyPhrasesDetectionJob(StartKeyPhrasesDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartKeyPhrasesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartKeyPhrasesDetectionJob.</param>
        /// 
        /// <returns>Returns a  StartKeyPhrasesDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartKeyPhrasesDetectionJob">REST API Reference for StartKeyPhrasesDetectionJob Operation</seealso>
        StartKeyPhrasesDetectionJobResponse EndStartKeyPhrasesDetectionJob(IAsyncResult asyncResult);

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
        StartPiiEntitiesDetectionJobResponse StartPiiEntitiesDetectionJob(StartPiiEntitiesDetectionJobRequest request);

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
        IAsyncResult BeginStartPiiEntitiesDetectionJob(StartPiiEntitiesDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartPiiEntitiesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartPiiEntitiesDetectionJob.</param>
        /// 
        /// <returns>Returns a  StartPiiEntitiesDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartPiiEntitiesDetectionJob">REST API Reference for StartPiiEntitiesDetectionJob Operation</seealso>
        StartPiiEntitiesDetectionJobResponse EndStartPiiEntitiesDetectionJob(IAsyncResult asyncResult);

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
        StartSentimentDetectionJobResponse StartSentimentDetectionJob(StartSentimentDetectionJobRequest request);

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
        IAsyncResult BeginStartSentimentDetectionJob(StartSentimentDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartSentimentDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSentimentDetectionJob.</param>
        /// 
        /// <returns>Returns a  StartSentimentDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartSentimentDetectionJob">REST API Reference for StartSentimentDetectionJob Operation</seealso>
        StartSentimentDetectionJobResponse EndStartSentimentDetectionJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StartTargetedSentimentDetectionJob


        /// <summary>
        /// Starts an asynchronous targeted sentiment detection job for a collection of documents.
        /// Use the <code>DescribeTargetedSentimentDetectionJob</code> operation to track the
        /// status of a job.
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
        StartTargetedSentimentDetectionJobResponse StartTargetedSentimentDetectionJob(StartTargetedSentimentDetectionJobRequest request);

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
        IAsyncResult BeginStartTargetedSentimentDetectionJob(StartTargetedSentimentDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartTargetedSentimentDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTargetedSentimentDetectionJob.</param>
        /// 
        /// <returns>Returns a  StartTargetedSentimentDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartTargetedSentimentDetectionJob">REST API Reference for StartTargetedSentimentDetectionJob Operation</seealso>
        StartTargetedSentimentDetectionJobResponse EndStartTargetedSentimentDetectionJob(IAsyncResult asyncResult);

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
        StartTopicsDetectionJobResponse StartTopicsDetectionJob(StartTopicsDetectionJobRequest request);

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
        IAsyncResult BeginStartTopicsDetectionJob(StartTopicsDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartTopicsDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTopicsDetectionJob.</param>
        /// 
        /// <returns>Returns a  StartTopicsDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StartTopicsDetectionJob">REST API Reference for StartTopicsDetectionJob Operation</seealso>
        StartTopicsDetectionJobResponse EndStartTopicsDetectionJob(IAsyncResult asyncResult);

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
        StopDominantLanguageDetectionJobResponse StopDominantLanguageDetectionJob(StopDominantLanguageDetectionJobRequest request);

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
        IAsyncResult BeginStopDominantLanguageDetectionJob(StopDominantLanguageDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopDominantLanguageDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDominantLanguageDetectionJob.</param>
        /// 
        /// <returns>Returns a  StopDominantLanguageDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopDominantLanguageDetectionJob">REST API Reference for StopDominantLanguageDetectionJob Operation</seealso>
        StopDominantLanguageDetectionJobResponse EndStopDominantLanguageDetectionJob(IAsyncResult asyncResult);

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
        StopEntitiesDetectionJobResponse StopEntitiesDetectionJob(StopEntitiesDetectionJobRequest request);

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
        IAsyncResult BeginStopEntitiesDetectionJob(StopEntitiesDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopEntitiesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopEntitiesDetectionJob.</param>
        /// 
        /// <returns>Returns a  StopEntitiesDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopEntitiesDetectionJob">REST API Reference for StopEntitiesDetectionJob Operation</seealso>
        StopEntitiesDetectionJobResponse EndStopEntitiesDetectionJob(IAsyncResult asyncResult);

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
        IAsyncResult BeginStopEventsDetectionJob(StopEventsDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopEventsDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopEventsDetectionJob.</param>
        /// 
        /// <returns>Returns a  StopEventsDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopEventsDetectionJob">REST API Reference for StopEventsDetectionJob Operation</seealso>
        StopEventsDetectionJobResponse EndStopEventsDetectionJob(IAsyncResult asyncResult);

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
        StopKeyPhrasesDetectionJobResponse StopKeyPhrasesDetectionJob(StopKeyPhrasesDetectionJobRequest request);

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
        IAsyncResult BeginStopKeyPhrasesDetectionJob(StopKeyPhrasesDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopKeyPhrasesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopKeyPhrasesDetectionJob.</param>
        /// 
        /// <returns>Returns a  StopKeyPhrasesDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopKeyPhrasesDetectionJob">REST API Reference for StopKeyPhrasesDetectionJob Operation</seealso>
        StopKeyPhrasesDetectionJobResponse EndStopKeyPhrasesDetectionJob(IAsyncResult asyncResult);

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
        IAsyncResult BeginStopPiiEntitiesDetectionJob(StopPiiEntitiesDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopPiiEntitiesDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopPiiEntitiesDetectionJob.</param>
        /// 
        /// <returns>Returns a  StopPiiEntitiesDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopPiiEntitiesDetectionJob">REST API Reference for StopPiiEntitiesDetectionJob Operation</seealso>
        StopPiiEntitiesDetectionJobResponse EndStopPiiEntitiesDetectionJob(IAsyncResult asyncResult);

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
        StopSentimentDetectionJobResponse StopSentimentDetectionJob(StopSentimentDetectionJobRequest request);

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
        IAsyncResult BeginStopSentimentDetectionJob(StopSentimentDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopSentimentDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopSentimentDetectionJob.</param>
        /// 
        /// <returns>Returns a  StopSentimentDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopSentimentDetectionJob">REST API Reference for StopSentimentDetectionJob Operation</seealso>
        StopSentimentDetectionJobResponse EndStopSentimentDetectionJob(IAsyncResult asyncResult);

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
        StopTargetedSentimentDetectionJobResponse StopTargetedSentimentDetectionJob(StopTargetedSentimentDetectionJobRequest request);

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
        IAsyncResult BeginStopTargetedSentimentDetectionJob(StopTargetedSentimentDetectionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopTargetedSentimentDetectionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTargetedSentimentDetectionJob.</param>
        /// 
        /// <returns>Returns a  StopTargetedSentimentDetectionJobResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopTargetedSentimentDetectionJob">REST API Reference for StopTargetedSentimentDetectionJob Operation</seealso>
        StopTargetedSentimentDetectionJobResponse EndStopTargetedSentimentDetectionJob(IAsyncResult asyncResult);

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
        StopTrainingDocumentClassifierResponse StopTrainingDocumentClassifier(StopTrainingDocumentClassifierRequest request);

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
        IAsyncResult BeginStopTrainingDocumentClassifier(StopTrainingDocumentClassifierRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopTrainingDocumentClassifier operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTrainingDocumentClassifier.</param>
        /// 
        /// <returns>Returns a  StopTrainingDocumentClassifierResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopTrainingDocumentClassifier">REST API Reference for StopTrainingDocumentClassifier Operation</seealso>
        StopTrainingDocumentClassifierResponse EndStopTrainingDocumentClassifier(IAsyncResult asyncResult);

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
        StopTrainingEntityRecognizerResponse StopTrainingEntityRecognizer(StopTrainingEntityRecognizerRequest request);

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
        IAsyncResult BeginStopTrainingEntityRecognizer(StopTrainingEntityRecognizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopTrainingEntityRecognizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTrainingEntityRecognizer.</param>
        /// 
        /// <returns>Returns a  StopTrainingEntityRecognizerResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/StopTrainingEntityRecognizer">REST API Reference for StopTrainingEntityRecognizer Operation</seealso>
        StopTrainingEntityRecognizerResponse EndStopTrainingEntityRecognizer(IAsyncResult asyncResult);

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
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        IAsyncResult BeginUpdateEndpoint(UpdateEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        UpdateEndpointResponse EndUpdateEndpoint(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateFlywheel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlywheel operation on AmazonComprehendClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFlywheel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/UpdateFlywheel">REST API Reference for UpdateFlywheel Operation</seealso>
        IAsyncResult BeginUpdateFlywheel(UpdateFlywheelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFlywheel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFlywheel.</param>
        /// 
        /// <returns>Returns a  UpdateFlywheelResult from Comprehend.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/comprehend-2017-11-27/UpdateFlywheel">REST API Reference for UpdateFlywheel Operation</seealso>
        UpdateFlywheelResponse EndUpdateFlywheel(IAsyncResult asyncResult);

        #endregion
        
    }
}