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
        /// Amazon Comprehend can't process the language of the input text. For all APIs except
        /// <code>DetectDominantLanguage</code>, Amazon Comprehend accepts only English or Spanish
        /// text. For the <code>DetectDominantLanguage</code> API, Amazon Comprehend detects 100
        /// languages. For a list of languages, see <a>how-languages</a>
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
        /// Amazon Comprehend can't process the language of the input text. For all APIs except
        /// <code>DetectDominantLanguage</code>, Amazon Comprehend accepts only English or Spanish
        /// text. For the <code>DetectDominantLanguage</code> API, Amazon Comprehend detects 100
        /// languages. For a list of languages, see <a>how-languages</a>
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
        /// Amazon Comprehend can't process the language of the input text. For all APIs except
        /// <code>DetectDominantLanguage</code>, Amazon Comprehend accepts only English or Spanish
        /// text. For the <code>DetectDominantLanguage</code> API, Amazon Comprehend detects 100
        /// languages. For a list of languages, see <a>how-languages</a>
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
        
    }
}