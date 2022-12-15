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
    /// Provides translation of the input content from the source language to the target language.
    /// </summary>
    public partial interface IAmazonTranslate : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ITranslatePaginatorFactory Paginators { get; }
#endif


        
        #region  CreateParallelData


        /// <summary>
        /// Creates a parallel data resource in Amazon Translate by importing an input file from
        /// Amazon S3. Parallel data files contain examples that show how you want segments of
        /// text to be translated. By adding parallel data, you can influence the style, tone,
        /// and word choice in your translation output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateParallelData service method.</param>
        /// 
        /// <returns>The response from the CreateParallelData service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidRequestException">
        /// The request that you made is not valid. Check your request to determine why it's
        /// not valid and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.LimitExceededException">
        /// The specified limit has been exceeded. Review your request and retry it with a quantity
        /// below the stated limit.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyTagsException">
        /// You have added too many tags to this resource. The maximum is 50 tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/CreateParallelData">REST API Reference for CreateParallelData Operation</seealso>
        CreateParallelDataResponse CreateParallelData(CreateParallelDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateParallelData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateParallelData operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateParallelData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/CreateParallelData">REST API Reference for CreateParallelData Operation</seealso>
        IAsyncResult BeginCreateParallelData(CreateParallelDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateParallelData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateParallelData.</param>
        /// 
        /// <returns>Returns a  CreateParallelDataResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/CreateParallelData">REST API Reference for CreateParallelData Operation</seealso>
        CreateParallelDataResponse EndCreateParallelData(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteParallelData


        /// <summary>
        /// Deletes a parallel data resource in Amazon Translate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteParallelData service method.</param>
        /// 
        /// <returns>The response from the DeleteParallelData service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DeleteParallelData">REST API Reference for DeleteParallelData Operation</seealso>
        DeleteParallelDataResponse DeleteParallelData(DeleteParallelDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteParallelData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteParallelData operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteParallelData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DeleteParallelData">REST API Reference for DeleteParallelData Operation</seealso>
        IAsyncResult BeginDeleteParallelData(DeleteParallelDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteParallelData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteParallelData.</param>
        /// 
        /// <returns>Returns a  DeleteParallelDataResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DeleteParallelData">REST API Reference for DeleteParallelData Operation</seealso>
        DeleteParallelDataResponse EndDeleteParallelData(IAsyncResult asyncResult);

        #endregion
        
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
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
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
        
        #region  DescribeTextTranslationJob


        /// <summary>
        /// Gets the properties associated with an asynchronous batch translation job including
        /// name, ID, status, source and target languages, input/output S3 buckets, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTextTranslationJob service method.</param>
        /// 
        /// <returns>The response from the DescribeTextTranslationJob service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DescribeTextTranslationJob">REST API Reference for DescribeTextTranslationJob Operation</seealso>
        DescribeTextTranslationJobResponse DescribeTextTranslationJob(DescribeTextTranslationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTextTranslationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTextTranslationJob operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTextTranslationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DescribeTextTranslationJob">REST API Reference for DescribeTextTranslationJob Operation</seealso>
        IAsyncResult BeginDescribeTextTranslationJob(DescribeTextTranslationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTextTranslationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTextTranslationJob.</param>
        /// 
        /// <returns>Returns a  DescribeTextTranslationJobResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/DescribeTextTranslationJob">REST API Reference for DescribeTextTranslationJob Operation</seealso>
        DescribeTextTranslationJobResponse EndDescribeTextTranslationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetParallelData


        /// <summary>
        /// Provides information about a parallel data resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParallelData service method.</param>
        /// 
        /// <returns>The response from the GetParallelData service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/GetParallelData">REST API Reference for GetParallelData Operation</seealso>
        GetParallelDataResponse GetParallelData(GetParallelDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetParallelData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetParallelData operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetParallelData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/GetParallelData">REST API Reference for GetParallelData Operation</seealso>
        IAsyncResult BeginGetParallelData(GetParallelDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetParallelData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetParallelData.</param>
        /// 
        /// <returns>Returns a  GetParallelDataResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/GetParallelData">REST API Reference for GetParallelData Operation</seealso>
        GetParallelDataResponse EndGetParallelData(IAsyncResult asyncResult);

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
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
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
        /// Creates or updates a custom terminology, depending on whether one already exists for
        /// the given terminology name. Importing a terminology with the same name as an existing
        /// one will merge the terminologies based on the chosen merge strategy. The only supported
        /// merge strategy is OVERWRITE, where the imported terminology overwrites the existing
        /// terminology of the same name.
        /// 
        ///  
        /// <para>
        /// If you import a terminology that overwrites an existing one, the new terminology takes
        /// up to 10 minutes to fully propagate. After that, translations have access to the new
        /// terminology.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportTerminology service method.</param>
        /// 
        /// <returns>The response from the ImportTerminology service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.LimitExceededException">
        /// The specified limit has been exceeded. Review your request and retry it with a quantity
        /// below the stated limit.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyTagsException">
        /// You have added too many tags to this resource. The maximum is 50 tags.
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
        
        #region  ListLanguages


        /// <summary>
        /// Provides a list of languages (RFC-5646 codes and names) that Amazon Translate supports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLanguages service method.</param>
        /// 
        /// <returns>The response from the ListLanguages service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.UnsupportedDisplayLanguageCodeException">
        /// Requested display language code is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListLanguages">REST API Reference for ListLanguages Operation</seealso>
        ListLanguagesResponse ListLanguages(ListLanguagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLanguages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLanguages operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLanguages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListLanguages">REST API Reference for ListLanguages Operation</seealso>
        IAsyncResult BeginListLanguages(ListLanguagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLanguages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLanguages.</param>
        /// 
        /// <returns>Returns a  ListLanguagesResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListLanguages">REST API Reference for ListLanguages Operation</seealso>
        ListLanguagesResponse EndListLanguages(IAsyncResult asyncResult);

        #endregion
        
        #region  ListParallelData


        /// <summary>
        /// Provides a list of your parallel data resources in Amazon Translate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListParallelData service method.</param>
        /// 
        /// <returns>The response from the ListParallelData service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListParallelData">REST API Reference for ListParallelData Operation</seealso>
        ListParallelDataResponse ListParallelData(ListParallelDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListParallelData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListParallelData operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListParallelData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListParallelData">REST API Reference for ListParallelData Operation</seealso>
        IAsyncResult BeginListParallelData(ListParallelDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListParallelData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListParallelData.</param>
        /// 
        /// <returns>Returns a  ListParallelDataResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListParallelData">REST API Reference for ListParallelData Operation</seealso>
        ListParallelDataResponse EndListParallelData(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags associated with a given Amazon Translate resource. For more information,
        /// see <a href="https://docs.aws.amazon.com/translate/latest/dg/tagging.html"> Tagging
        /// your resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
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
        
        #region  ListTextTranslationJobs


        /// <summary>
        /// Gets a list of the batch translation jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTextTranslationJobs service method.</param>
        /// 
        /// <returns>The response from the ListTextTranslationJobs service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidFilterException">
        /// The filter specified for the operation is not valid. Specify a different filter.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidRequestException">
        /// The request that you made is not valid. Check your request to determine why it's
        /// not valid and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListTextTranslationJobs">REST API Reference for ListTextTranslationJobs Operation</seealso>
        ListTextTranslationJobsResponse ListTextTranslationJobs(ListTextTranslationJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTextTranslationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTextTranslationJobs operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTextTranslationJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListTextTranslationJobs">REST API Reference for ListTextTranslationJobs Operation</seealso>
        IAsyncResult BeginListTextTranslationJobs(ListTextTranslationJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTextTranslationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTextTranslationJobs.</param>
        /// 
        /// <returns>Returns a  ListTextTranslationJobsResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/ListTextTranslationJobs">REST API Reference for ListTextTranslationJobs Operation</seealso>
        ListTextTranslationJobsResponse EndListTextTranslationJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  StartTextTranslationJob


        /// <summary>
        /// Starts an asynchronous batch translation job. Use batch translation jobs to translate
        /// large volumes of text across multiple documents at once. For batch translation, you
        /// can input documents with different source languages (specify <code>auto</code> as
        /// the source language). You can specify one or more target languages. Batch translation
        /// translates each input document into each of the target languages. For more information,
        /// see <a href="https://docs.aws.amazon.com/translate/latest/dg/async.html">Asynchronous
        /// batch processing</a>.
        /// 
        ///  
        /// <para>
        /// Batch translation jobs can be described with the <a>DescribeTextTranslationJob</a>
        /// operation, listed with the <a>ListTextTranslationJobs</a> operation, and stopped with
        /// the <a>StopTextTranslationJob</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTextTranslationJob service method.</param>
        /// 
        /// <returns>The response from the StartTextTranslationJob service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidRequestException">
        /// The request that you made is not valid. Check your request to determine why it's
        /// not valid and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.UnsupportedLanguagePairException">
        /// Amazon Translate does not support translation from the language of the source text
        /// into the requested target language. For more information, see <a href="https://docs.aws.amazon.com/translate/latest/dg/how-to-error-msg.html">Error
        /// messages</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/StartTextTranslationJob">REST API Reference for StartTextTranslationJob Operation</seealso>
        StartTextTranslationJobResponse StartTextTranslationJob(StartTextTranslationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartTextTranslationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTextTranslationJob operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTextTranslationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/StartTextTranslationJob">REST API Reference for StartTextTranslationJob Operation</seealso>
        IAsyncResult BeginStartTextTranslationJob(StartTextTranslationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartTextTranslationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTextTranslationJob.</param>
        /// 
        /// <returns>Returns a  StartTextTranslationJobResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/StartTextTranslationJob">REST API Reference for StartTextTranslationJob Operation</seealso>
        StartTextTranslationJobResponse EndStartTextTranslationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StopTextTranslationJob


        /// <summary>
        /// Stops an asynchronous batch translation job that is in progress.
        /// 
        ///  
        /// <para>
        /// If the job's state is <code>IN_PROGRESS</code>, the job will be marked for termination
        /// and put into the <code>STOP_REQUESTED</code> state. If the job completes before it
        /// can be stopped, it is put into the <code>COMPLETED</code> state. Otherwise, the job
        /// is put into the <code>STOPPED</code> state.
        /// </para>
        ///  
        /// <para>
        /// Asynchronous batch translation jobs are started with the <a>StartTextTranslationJob</a>
        /// operation. You can use the <a>DescribeTextTranslationJob</a> or <a>ListTextTranslationJobs</a>
        /// operations to get a batch translation job's <code>JobId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTextTranslationJob service method.</param>
        /// 
        /// <returns>The response from the StopTextTranslationJob service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/StopTextTranslationJob">REST API Reference for StopTextTranslationJob Operation</seealso>
        StopTextTranslationJobResponse StopTextTranslationJob(StopTextTranslationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopTextTranslationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTextTranslationJob operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTextTranslationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/StopTextTranslationJob">REST API Reference for StopTextTranslationJob Operation</seealso>
        IAsyncResult BeginStopTextTranslationJob(StopTextTranslationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopTextTranslationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTextTranslationJob.</param>
        /// 
        /// <returns>Returns a  StopTextTranslationJobResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/StopTextTranslationJob">REST API Reference for StopTextTranslationJob Operation</seealso>
        StopTextTranslationJobResponse EndStopTextTranslationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates a specific tag with a resource. A tag is a key-value pair that adds as
        /// a metadata to a resource. For more information, see <a href="https://docs.aws.amazon.com/translate/latest/dg/tagging.html">
        /// Tagging your resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyTagsException">
        /// You have added too many tags to this resource. The maximum is 50 tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TranslateText


        /// <summary>
        /// Translates input text from the source language to the target language. For a list
        /// of available languages and language codes, see <a href="https://docs.aws.amazon.com/translate/latest/dg/what-is-languages.html">Supported
        /// languages</a>.
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
        /// The request that you made is not valid. Check your request to determine why it's
        /// not valid and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ServiceUnavailableException">
        /// The Amazon Translate service is temporarily unavailable. Wait a bit and then retry
        /// your request.
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
        /// into the requested target language. For more information, see <a href="https://docs.aws.amazon.com/translate/latest/dg/how-to-error-msg.html">Error
        /// messages</a>.
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
        
        #region  UntagResource


        /// <summary>
        /// Removes a specific tag associated with an Amazon Translate resource. For more information,
        /// see <a href="https://docs.aws.amazon.com/translate/latest/dg/tagging.html"> Tagging
        /// your resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateParallelData


        /// <summary>
        /// Updates a previously created parallel data resource by importing a new input file
        /// from Amazon S3.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateParallelData service method.</param>
        /// 
        /// <returns>The response from the UpdateParallelData service method, as returned by Translate.</returns>
        /// <exception cref="Amazon.Translate.Model.ConcurrentModificationException">
        /// Another modification is being made. That modification must complete before you can
        /// make your change.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ConflictException">
        /// There was a conflict processing the request. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidParameterValueException">
        /// The value of the parameter is not valid. Review the value of the parameter you are
        /// using to correct it, and then retry your operation.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.InvalidRequestException">
        /// The request that you made is not valid. Check your request to determine why it's
        /// not valid and then retry the request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.LimitExceededException">
        /// The specified limit has been exceeded. Review your request and retry it with a quantity
        /// below the stated limit.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.ResourceNotFoundException">
        /// The resource you are looking for has not been found. Review the resource you're looking
        /// for and see if a different resource will accomplish your needs before retrying the
        /// revised request.
        /// </exception>
        /// <exception cref="Amazon.Translate.Model.TooManyRequestsException">
        /// You have made too many requests within a short period of time. Wait for a short time
        /// and then try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/UpdateParallelData">REST API Reference for UpdateParallelData Operation</seealso>
        UpdateParallelDataResponse UpdateParallelData(UpdateParallelDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateParallelData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateParallelData operation on AmazonTranslateClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateParallelData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/UpdateParallelData">REST API Reference for UpdateParallelData Operation</seealso>
        IAsyncResult BeginUpdateParallelData(UpdateParallelDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateParallelData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateParallelData.</param>
        /// 
        /// <returns>Returns a  UpdateParallelDataResult from Translate.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/translate-2017-07-01/UpdateParallelData">REST API Reference for UpdateParallelData Operation</seealso>
        UpdateParallelDataResponse EndUpdateParallelData(IAsyncResult asyncResult);

        #endregion
        
    }
}