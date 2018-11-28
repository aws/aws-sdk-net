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
    /// Provides translation between one source language and another of the same set of languages.
    /// </summary>
    public partial interface IAmazonTranslate : IAmazonService, IDisposable
    {

        
        #region  DeleteTerminology


        /// <summary>
        /// A synchronous action that deletes a custom terminology.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTerminology service method.</param>
        /// 
        /// <returns>The response from the DeleteTerminology service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request. .
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DeleteTerminology">REST API Reference for DeleteTerminology Operation</seealso>
        DeleteTerminologyResponse DeleteTerminology(DeleteTerminologyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTerminology operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTerminology operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTerminology
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DeleteTerminology">REST API Reference for DeleteTerminology Operation</seealso>
        IAsyncResult BeginDeleteTerminology(DeleteTerminologyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTerminology operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTerminology.</param>
        /// 
        /// <returns>Returns a  DeleteTerminologyResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DeleteTerminology">REST API Reference for DeleteTerminology Operation</seealso>
        DeleteTerminologyResponse EndDeleteTerminology(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTerminology


        /// <summary>
        /// Retrieves a custom terminology.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTerminology service method.</param>
        /// 
        /// <returns>The response from the GetTerminology service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is invalid. Review the value of the parameter you are using
        /// to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request. .
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/GetTerminology">REST API Reference for GetTerminology Operation</seealso>
        GetTerminologyResponse GetTerminology(GetTerminologyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTerminology operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTerminology operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTerminology
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/GetTerminology">REST API Reference for GetTerminology Operation</seealso>
        IAsyncResult BeginGetTerminology(GetTerminologyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTerminology operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTerminology.</param>
        /// 
        /// <returns>Returns a  GetTerminologyResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/GetTerminology">REST API Reference for GetTerminology Operation</seealso>
        GetTerminologyResponse EndGetTerminology(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportTerminology


        /// <summary>
        /// Creates or updates a custom terminology, depending on whether or not one already exists
        /// for the given terminology name. Importing a terminology with the same name as an existing
        /// one will merge the terminologies based on the chosen merge strategy. Currently, the
        /// only supported merge strategy is OVERWRITE, and so the imported terminology will overwrite
        /// an existing terminology of the same name.
        /// 
        ///  
        /// <para>
        /// If you import a terminology that overwrites an existing one, the new terminology take
        /// up to 10 minutes to fully propagate and be available for use in a translation due
        /// to cache policies with the DataPlane service that performs the translations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportTerminology service method.</param>
        /// 
        /// <returns>The response from the ImportTerminology service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is invalid. Review the value of the parameter you are using
        /// to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.LimitExceededException">
        /// The specified limit has been exceeded. Review your request and retry it with a quantity
        /// below the stated limit.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ImportTerminology">REST API Reference for ImportTerminology Operation</seealso>
        ImportTerminologyResponse ImportTerminology(ImportTerminologyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportTerminology operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportTerminology operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportTerminology
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ImportTerminology">REST API Reference for ImportTerminology Operation</seealso>
        IAsyncResult BeginImportTerminology(ImportTerminologyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportTerminology operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportTerminology.</param>
        /// 
        /// <returns>Returns a  ImportTerminologyResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ImportTerminology">REST API Reference for ImportTerminology Operation</seealso>
        ImportTerminologyResponse EndImportTerminology(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTerminologies


        /// <summary>
        /// Provides a list of custom terminologies associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTerminologies service method.</param>
        /// 
        /// <returns>The response from the ListTerminologies service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is invalid. Review the value of the parameter you are using
        /// to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListTerminologies">REST API Reference for ListTerminologies Operation</seealso>
        ListTerminologiesResponse ListTerminologies(ListTerminologiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTerminologies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTerminologies operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTerminologies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListTerminologies">REST API Reference for ListTerminologies Operation</seealso>
        IAsyncResult BeginListTerminologies(ListTerminologiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTerminologies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTerminologies.</param>
        /// 
        /// <returns>Returns a  ListTerminologiesResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListTerminologies">REST API Reference for ListTerminologies Operation</seealso>
        ListTerminologiesResponse EndListTerminologies(IAsyncResult asyncResult);

        #endregion
        
        #region  TranslateText


        /// <summary>
        /// Translates input text from the source language to the target language. It is not necessary
        /// to use English (en) as either the source or the target language but not all language
        /// combinations are supported by Amazon Translate. For more information, see <a href="http://docs.aws.amazon.com/translate/latest/dg/pairs.html">Supported
        /// Language Pairs</a>.
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
        /// Chinese (Traditional) (zh-TW)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Czech (cs)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Danish (da)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Dutch (nl)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// English (en)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Finnish (fi)
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
        /// Hebrew (he)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Indonesian (id)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Italian (it)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Japanese (ja)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Korean (ko)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Polish (pl)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Portuguese (pt)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Russian (ru)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Spanish (es)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Swedish (sv)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Turkish (tr)
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
        /// The request that you made is invalid. Check your request to determine why it's invalid
        /// and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request. .
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ServiceUnavailableException">
        /// The Amazon Translate service is temporarily unavailable. Please wait a bit and then
        /// retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TextSizeLimitExceededException">
        /// The size of the text you submitted exceeds the size limit. Reduce the size of the
        /// text or use a smaller document and then retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.UnsupportedLanguagePairException">
        /// Amazon Translate does not support translation from the language of the source text
        /// into the requested target language. For more information, see <a>how-to-error-msg</a>.
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