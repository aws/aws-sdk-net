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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Translate.Model;

namespace Amazon.Translate
{
    /// <summary>
    /// Interface for accessing Translate
    ///
    /// Provides translation between English and one of six languages, or between one of the
    /// six languages and English.
    /// </summary>
    public partial interface IAmazonTranslate : IAmazonService, IDisposable
    {

        
        #region  TranslateText


        /// <summary>
        /// Translates input text from the source language to the target language. You can translate
        /// between English (en) and one of the following languages, or between one of the following
        /// languages and English.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Arabic (ar)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Chinese (Simplified) (zh)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// French (fr)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// German (de)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Portuguese (pt)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Spanish (es)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To have Amazon Translate determine the source language of your text, you can specify
        /// <code>auto</code> in the <code>SourceLanguageCode</code> field. If you specify <code>auto</code>,
        /// Amazon Translate will call Amazon Comprehend to determine the source language.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TranslateText service method.</param>
        /// 
        /// <returns>The response from the TranslateText service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.DetectedLanguageLowConfidenceException">
        /// The confidence that Amazon Comprehend accurately detected the source language is low.
        /// If a low confidence level is acceptable for your application, you can use the language
        /// in the exception to call Amazon Translate again. For more information, see the <a
        /// href="https://docs.aws.amazon.com/comprehend/latest/dg/API_DetectDominantLanguage.html">DetectDominantLanguage</a>
        /// operation in the <i>Amazon Comprehend Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ServiceUnavailableException">
        /// Amazon Translate is unavailable. Retry your request later.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TextSizeLimitExceededException">
        /// The size of the input text exceeds the length constraint for the <code>Text</code>
        /// field. Try again with a shorter text.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.UnsupportedLanguagePairException">
        /// Amazon Translate cannot translate input text in the source language into this target
        /// language. For more information, see <a>how-to-error-msg</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/TranslateText">REST API Reference for TranslateText Operation</seealso>
        TranslateTextResponse TranslateText(TranslateTextRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TranslateText operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TranslateText operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTranslateText
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/TranslateText">REST API Reference for TranslateText Operation</seealso>
        IAsyncResult BeginTranslateText(TranslateTextRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TranslateText operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTranslateText.</param>
        /// 
        /// <returns>Returns a  TranslateTextResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/TranslateText">REST API Reference for TranslateText Operation</seealso>
        TranslateTextResponse EndTranslateText(IAsyncResult asyncResult);

        #endregion
        
    }
}