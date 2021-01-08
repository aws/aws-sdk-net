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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.TranscribeService.Model;

namespace Amazon.TranscribeService
{
    /// <summary>
    /// Interface for accessing TranscribeService
    ///
    /// Operations and objects for transcribing speech to text.
    /// </summary>
    public partial interface IAmazonTranscribeService : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ITranscribeServicePaginatorFactory Paginators { get; }
#endif


        
        #region  CreateLanguageModel


        /// <summary>
        /// Creates a new custom language model. Use Amazon S3 prefixes to provide the location
        /// of your input files. The time it takes to create your model depends on the size of
        /// your training data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLanguageModel service method.</param>
        /// 
        /// <returns>The response from the CreateLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateLanguageModel">REST API Reference for CreateLanguageModel Operation</seealso>
        CreateLanguageModelResponse CreateLanguageModel(CreateLanguageModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLanguageModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLanguageModel operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLanguageModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateLanguageModel">REST API Reference for CreateLanguageModel Operation</seealso>
        IAsyncResult BeginCreateLanguageModel(CreateLanguageModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLanguageModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLanguageModel.</param>
        /// 
        /// <returns>Returns a  CreateLanguageModelResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateLanguageModel">REST API Reference for CreateLanguageModel Operation</seealso>
        CreateLanguageModelResponse EndCreateLanguageModel(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMedicalVocabulary


        /// <summary>
        /// Creates a new custom vocabulary that you can use to change how Amazon Transcribe Medical
        /// transcribes your audio file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMedicalVocabulary service method.</param>
        /// 
        /// <returns>The response from the CreateMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateMedicalVocabulary">REST API Reference for CreateMedicalVocabulary Operation</seealso>
        CreateMedicalVocabularyResponse CreateMedicalVocabulary(CreateMedicalVocabularyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMedicalVocabulary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMedicalVocabulary operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMedicalVocabulary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateMedicalVocabulary">REST API Reference for CreateMedicalVocabulary Operation</seealso>
        IAsyncResult BeginCreateMedicalVocabulary(CreateMedicalVocabularyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMedicalVocabulary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMedicalVocabulary.</param>
        /// 
        /// <returns>Returns a  CreateMedicalVocabularyResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateMedicalVocabulary">REST API Reference for CreateMedicalVocabulary Operation</seealso>
        CreateMedicalVocabularyResponse EndCreateMedicalVocabulary(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVocabulary


        /// <summary>
        /// Creates a new custom vocabulary that you can use to change the way Amazon Transcribe
        /// handles transcription of an audio file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabulary service method.</param>
        /// 
        /// <returns>The response from the CreateVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateVocabulary">REST API Reference for CreateVocabulary Operation</seealso>
        CreateVocabularyResponse CreateVocabulary(CreateVocabularyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVocabulary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabulary operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVocabulary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateVocabulary">REST API Reference for CreateVocabulary Operation</seealso>
        IAsyncResult BeginCreateVocabulary(CreateVocabularyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVocabulary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVocabulary.</param>
        /// 
        /// <returns>Returns a  CreateVocabularyResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateVocabulary">REST API Reference for CreateVocabulary Operation</seealso>
        CreateVocabularyResponse EndCreateVocabulary(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVocabularyFilter


        /// <summary>
        /// Creates a new vocabulary filter that you can use to filter words, such as profane
        /// words, from the output of a transcription job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabularyFilter service method.</param>
        /// 
        /// <returns>The response from the CreateVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateVocabularyFilter">REST API Reference for CreateVocabularyFilter Operation</seealso>
        CreateVocabularyFilterResponse CreateVocabularyFilter(CreateVocabularyFilterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVocabularyFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabularyFilter operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVocabularyFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateVocabularyFilter">REST API Reference for CreateVocabularyFilter Operation</seealso>
        IAsyncResult BeginCreateVocabularyFilter(CreateVocabularyFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVocabularyFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVocabularyFilter.</param>
        /// 
        /// <returns>Returns a  CreateVocabularyFilterResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateVocabularyFilter">REST API Reference for CreateVocabularyFilter Operation</seealso>
        CreateVocabularyFilterResponse EndCreateVocabularyFilter(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLanguageModel


        /// <summary>
        /// Deletes a custom language model using its name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLanguageModel service method.</param>
        /// 
        /// <returns>The response from the DeleteLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteLanguageModel">REST API Reference for DeleteLanguageModel Operation</seealso>
        DeleteLanguageModelResponse DeleteLanguageModel(DeleteLanguageModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLanguageModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLanguageModel operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLanguageModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteLanguageModel">REST API Reference for DeleteLanguageModel Operation</seealso>
        IAsyncResult BeginDeleteLanguageModel(DeleteLanguageModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLanguageModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLanguageModel.</param>
        /// 
        /// <returns>Returns a  DeleteLanguageModelResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteLanguageModel">REST API Reference for DeleteLanguageModel Operation</seealso>
        DeleteLanguageModelResponse EndDeleteLanguageModel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMedicalTranscriptionJob


        /// <summary>
        /// Deletes a transcription job generated by Amazon Transcribe Medical and any related
        /// information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the DeleteMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalTranscriptionJob">REST API Reference for DeleteMedicalTranscriptionJob Operation</seealso>
        DeleteMedicalTranscriptionJobResponse DeleteMedicalTranscriptionJob(DeleteMedicalTranscriptionJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMedicalTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalTranscriptionJob operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMedicalTranscriptionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalTranscriptionJob">REST API Reference for DeleteMedicalTranscriptionJob Operation</seealso>
        IAsyncResult BeginDeleteMedicalTranscriptionJob(DeleteMedicalTranscriptionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMedicalTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMedicalTranscriptionJob.</param>
        /// 
        /// <returns>Returns a  DeleteMedicalTranscriptionJobResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalTranscriptionJob">REST API Reference for DeleteMedicalTranscriptionJob Operation</seealso>
        DeleteMedicalTranscriptionJobResponse EndDeleteMedicalTranscriptionJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMedicalVocabulary


        /// <summary>
        /// Deletes a vocabulary from Amazon Transcribe Medical.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalVocabulary service method.</param>
        /// 
        /// <returns>The response from the DeleteMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalVocabulary">REST API Reference for DeleteMedicalVocabulary Operation</seealso>
        DeleteMedicalVocabularyResponse DeleteMedicalVocabulary(DeleteMedicalVocabularyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMedicalVocabulary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalVocabulary operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMedicalVocabulary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalVocabulary">REST API Reference for DeleteMedicalVocabulary Operation</seealso>
        IAsyncResult BeginDeleteMedicalVocabulary(DeleteMedicalVocabularyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMedicalVocabulary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMedicalVocabulary.</param>
        /// 
        /// <returns>Returns a  DeleteMedicalVocabularyResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteMedicalVocabulary">REST API Reference for DeleteMedicalVocabulary Operation</seealso>
        DeleteMedicalVocabularyResponse EndDeleteMedicalVocabulary(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTranscriptionJob


        /// <summary>
        /// Deletes a previously submitted transcription job along with any other generated results
        /// such as the transcription, models, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the DeleteTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteTranscriptionJob">REST API Reference for DeleteTranscriptionJob Operation</seealso>
        DeleteTranscriptionJobResponse DeleteTranscriptionJob(DeleteTranscriptionJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTranscriptionJob operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTranscriptionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteTranscriptionJob">REST API Reference for DeleteTranscriptionJob Operation</seealso>
        IAsyncResult BeginDeleteTranscriptionJob(DeleteTranscriptionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTranscriptionJob.</param>
        /// 
        /// <returns>Returns a  DeleteTranscriptionJobResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteTranscriptionJob">REST API Reference for DeleteTranscriptionJob Operation</seealso>
        DeleteTranscriptionJobResponse EndDeleteTranscriptionJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVocabulary


        /// <summary>
        /// Deletes a vocabulary from Amazon Transcribe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabulary service method.</param>
        /// 
        /// <returns>The response from the DeleteVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteVocabulary">REST API Reference for DeleteVocabulary Operation</seealso>
        DeleteVocabularyResponse DeleteVocabulary(DeleteVocabularyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVocabulary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabulary operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVocabulary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteVocabulary">REST API Reference for DeleteVocabulary Operation</seealso>
        IAsyncResult BeginDeleteVocabulary(DeleteVocabularyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVocabulary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVocabulary.</param>
        /// 
        /// <returns>Returns a  DeleteVocabularyResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteVocabulary">REST API Reference for DeleteVocabulary Operation</seealso>
        DeleteVocabularyResponse EndDeleteVocabulary(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVocabularyFilter


        /// <summary>
        /// Removes a vocabulary filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabularyFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteVocabularyFilter">REST API Reference for DeleteVocabularyFilter Operation</seealso>
        DeleteVocabularyFilterResponse DeleteVocabularyFilter(DeleteVocabularyFilterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVocabularyFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabularyFilter operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVocabularyFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteVocabularyFilter">REST API Reference for DeleteVocabularyFilter Operation</seealso>
        IAsyncResult BeginDeleteVocabularyFilter(DeleteVocabularyFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVocabularyFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVocabularyFilter.</param>
        /// 
        /// <returns>Returns a  DeleteVocabularyFilterResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteVocabularyFilter">REST API Reference for DeleteVocabularyFilter Operation</seealso>
        DeleteVocabularyFilterResponse EndDeleteVocabularyFilter(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLanguageModel


        /// <summary>
        /// Gets information about a single custom language model. Use this information to see
        /// details about the language model in your AWS account. You can also see whether the
        /// base language model used to create your custom language model has been updated. If
        /// Amazon Transcribe has updated the base model, you can create a new custom language
        /// model using the updated base model. If the language model wasn't created, you can
        /// use this operation to understand why Amazon Transcribe couldn't create it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLanguageModel service method.</param>
        /// 
        /// <returns>The response from the DescribeLanguageModel service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DescribeLanguageModel">REST API Reference for DescribeLanguageModel Operation</seealso>
        DescribeLanguageModelResponse DescribeLanguageModel(DescribeLanguageModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLanguageModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLanguageModel operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLanguageModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DescribeLanguageModel">REST API Reference for DescribeLanguageModel Operation</seealso>
        IAsyncResult BeginDescribeLanguageModel(DescribeLanguageModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLanguageModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLanguageModel.</param>
        /// 
        /// <returns>Returns a  DescribeLanguageModelResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DescribeLanguageModel">REST API Reference for DescribeLanguageModel Operation</seealso>
        DescribeLanguageModelResponse EndDescribeLanguageModel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMedicalTranscriptionJob


        /// <summary>
        /// Returns information about a transcription job from Amazon Transcribe Medical. To see
        /// the status of the job, check the <code>TranscriptionJobStatus</code> field. If the
        /// status is <code>COMPLETED</code>, the job is finished. You find the results of the
        /// completed job in the <code>TranscriptFileUri</code> field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the GetMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalTranscriptionJob">REST API Reference for GetMedicalTranscriptionJob Operation</seealso>
        GetMedicalTranscriptionJobResponse GetMedicalTranscriptionJob(GetMedicalTranscriptionJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMedicalTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalTranscriptionJob operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMedicalTranscriptionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalTranscriptionJob">REST API Reference for GetMedicalTranscriptionJob Operation</seealso>
        IAsyncResult BeginGetMedicalTranscriptionJob(GetMedicalTranscriptionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMedicalTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMedicalTranscriptionJob.</param>
        /// 
        /// <returns>Returns a  GetMedicalTranscriptionJobResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalTranscriptionJob">REST API Reference for GetMedicalTranscriptionJob Operation</seealso>
        GetMedicalTranscriptionJobResponse EndGetMedicalTranscriptionJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMedicalVocabulary


        /// <summary>
        /// Retrieves information about a medical vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalVocabulary service method.</param>
        /// 
        /// <returns>The response from the GetMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalVocabulary">REST API Reference for GetMedicalVocabulary Operation</seealso>
        GetMedicalVocabularyResponse GetMedicalVocabulary(GetMedicalVocabularyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMedicalVocabulary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalVocabulary operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMedicalVocabulary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalVocabulary">REST API Reference for GetMedicalVocabulary Operation</seealso>
        IAsyncResult BeginGetMedicalVocabulary(GetMedicalVocabularyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMedicalVocabulary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMedicalVocabulary.</param>
        /// 
        /// <returns>Returns a  GetMedicalVocabularyResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetMedicalVocabulary">REST API Reference for GetMedicalVocabulary Operation</seealso>
        GetMedicalVocabularyResponse EndGetMedicalVocabulary(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTranscriptionJob


        /// <summary>
        /// Returns information about a transcription job. To see the status of the job, check
        /// the <code>TranscriptionJobStatus</code> field. If the status is <code>COMPLETED</code>,
        /// the job is finished and you can find the results at the location specified in the
        /// <code>TranscriptFileUri</code> field. If you enable content redaction, the redacted
        /// transcript appears in <code>RedactedTranscriptFileUri</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the GetTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetTranscriptionJob">REST API Reference for GetTranscriptionJob Operation</seealso>
        GetTranscriptionJobResponse GetTranscriptionJob(GetTranscriptionJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTranscriptionJob operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTranscriptionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetTranscriptionJob">REST API Reference for GetTranscriptionJob Operation</seealso>
        IAsyncResult BeginGetTranscriptionJob(GetTranscriptionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTranscriptionJob.</param>
        /// 
        /// <returns>Returns a  GetTranscriptionJobResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetTranscriptionJob">REST API Reference for GetTranscriptionJob Operation</seealso>
        GetTranscriptionJobResponse EndGetTranscriptionJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVocabulary


        /// <summary>
        /// Gets information about a vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVocabulary service method.</param>
        /// 
        /// <returns>The response from the GetVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetVocabulary">REST API Reference for GetVocabulary Operation</seealso>
        GetVocabularyResponse GetVocabulary(GetVocabularyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVocabulary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVocabulary operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVocabulary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetVocabulary">REST API Reference for GetVocabulary Operation</seealso>
        IAsyncResult BeginGetVocabulary(GetVocabularyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVocabulary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVocabulary.</param>
        /// 
        /// <returns>Returns a  GetVocabularyResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetVocabulary">REST API Reference for GetVocabulary Operation</seealso>
        GetVocabularyResponse EndGetVocabulary(IAsyncResult asyncResult);

        #endregion
        
        #region  GetVocabularyFilter


        /// <summary>
        /// Returns information about a vocabulary filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVocabularyFilter service method.</param>
        /// 
        /// <returns>The response from the GetVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetVocabularyFilter">REST API Reference for GetVocabularyFilter Operation</seealso>
        GetVocabularyFilterResponse GetVocabularyFilter(GetVocabularyFilterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetVocabularyFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVocabularyFilter operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVocabularyFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetVocabularyFilter">REST API Reference for GetVocabularyFilter Operation</seealso>
        IAsyncResult BeginGetVocabularyFilter(GetVocabularyFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetVocabularyFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVocabularyFilter.</param>
        /// 
        /// <returns>Returns a  GetVocabularyFilterResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetVocabularyFilter">REST API Reference for GetVocabularyFilter Operation</seealso>
        GetVocabularyFilterResponse EndGetVocabularyFilter(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLanguageModels


        /// <summary>
        /// Provides more information about the custom language models you've created. You can
        /// use the information in this list to find a specific custom language model. You can
        /// then use the operation to get more information about it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLanguageModels service method.</param>
        /// 
        /// <returns>The response from the ListLanguageModels service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListLanguageModels">REST API Reference for ListLanguageModels Operation</seealso>
        ListLanguageModelsResponse ListLanguageModels(ListLanguageModelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLanguageModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLanguageModels operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLanguageModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListLanguageModels">REST API Reference for ListLanguageModels Operation</seealso>
        IAsyncResult BeginListLanguageModels(ListLanguageModelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLanguageModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLanguageModels.</param>
        /// 
        /// <returns>Returns a  ListLanguageModelsResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListLanguageModels">REST API Reference for ListLanguageModels Operation</seealso>
        ListLanguageModelsResponse EndListLanguageModels(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMedicalTranscriptionJobs


        /// <summary>
        /// Lists medical transcription jobs with a specified status or substring that matches
        /// their names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalTranscriptionJobs service method.</param>
        /// 
        /// <returns>The response from the ListMedicalTranscriptionJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalTranscriptionJobs">REST API Reference for ListMedicalTranscriptionJobs Operation</seealso>
        ListMedicalTranscriptionJobsResponse ListMedicalTranscriptionJobs(ListMedicalTranscriptionJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMedicalTranscriptionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalTranscriptionJobs operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMedicalTranscriptionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalTranscriptionJobs">REST API Reference for ListMedicalTranscriptionJobs Operation</seealso>
        IAsyncResult BeginListMedicalTranscriptionJobs(ListMedicalTranscriptionJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMedicalTranscriptionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMedicalTranscriptionJobs.</param>
        /// 
        /// <returns>Returns a  ListMedicalTranscriptionJobsResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalTranscriptionJobs">REST API Reference for ListMedicalTranscriptionJobs Operation</seealso>
        ListMedicalTranscriptionJobsResponse EndListMedicalTranscriptionJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMedicalVocabularies


        /// <summary>
        /// Returns a list of vocabularies that match the specified criteria. If you don't enter
        /// a value in any of the request parameters, returns the entire list of vocabularies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalVocabularies service method.</param>
        /// 
        /// <returns>The response from the ListMedicalVocabularies service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalVocabularies">REST API Reference for ListMedicalVocabularies Operation</seealso>
        ListMedicalVocabulariesResponse ListMedicalVocabularies(ListMedicalVocabulariesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMedicalVocabularies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalVocabularies operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMedicalVocabularies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalVocabularies">REST API Reference for ListMedicalVocabularies Operation</seealso>
        IAsyncResult BeginListMedicalVocabularies(ListMedicalVocabulariesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMedicalVocabularies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMedicalVocabularies.</param>
        /// 
        /// <returns>Returns a  ListMedicalVocabulariesResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListMedicalVocabularies">REST API Reference for ListMedicalVocabularies Operation</seealso>
        ListMedicalVocabulariesResponse EndListMedicalVocabularies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTranscriptionJobs


        /// <summary>
        /// Lists transcription jobs with the specified status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTranscriptionJobs service method.</param>
        /// 
        /// <returns>The response from the ListTranscriptionJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTranscriptionJobs">REST API Reference for ListTranscriptionJobs Operation</seealso>
        ListTranscriptionJobsResponse ListTranscriptionJobs(ListTranscriptionJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTranscriptionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTranscriptionJobs operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTranscriptionJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTranscriptionJobs">REST API Reference for ListTranscriptionJobs Operation</seealso>
        IAsyncResult BeginListTranscriptionJobs(ListTranscriptionJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTranscriptionJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTranscriptionJobs.</param>
        /// 
        /// <returns>Returns a  ListTranscriptionJobsResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTranscriptionJobs">REST API Reference for ListTranscriptionJobs Operation</seealso>
        ListTranscriptionJobsResponse EndListTranscriptionJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVocabularies


        /// <summary>
        /// Returns a list of vocabularies that match the specified criteria. If no criteria are
        /// specified, returns the entire list of vocabularies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVocabularies service method.</param>
        /// 
        /// <returns>The response from the ListVocabularies service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListVocabularies">REST API Reference for ListVocabularies Operation</seealso>
        ListVocabulariesResponse ListVocabularies(ListVocabulariesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVocabularies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVocabularies operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVocabularies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListVocabularies">REST API Reference for ListVocabularies Operation</seealso>
        IAsyncResult BeginListVocabularies(ListVocabulariesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVocabularies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVocabularies.</param>
        /// 
        /// <returns>Returns a  ListVocabulariesResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListVocabularies">REST API Reference for ListVocabularies Operation</seealso>
        ListVocabulariesResponse EndListVocabularies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVocabularyFilters


        /// <summary>
        /// Gets information about vocabulary filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVocabularyFilters service method.</param>
        /// 
        /// <returns>The response from the ListVocabularyFilters service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListVocabularyFilters">REST API Reference for ListVocabularyFilters Operation</seealso>
        ListVocabularyFiltersResponse ListVocabularyFilters(ListVocabularyFiltersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVocabularyFilters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVocabularyFilters operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVocabularyFilters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListVocabularyFilters">REST API Reference for ListVocabularyFilters Operation</seealso>
        IAsyncResult BeginListVocabularyFilters(ListVocabularyFiltersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVocabularyFilters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVocabularyFilters.</param>
        /// 
        /// <returns>Returns a  ListVocabularyFiltersResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListVocabularyFilters">REST API Reference for ListVocabularyFilters Operation</seealso>
        ListVocabularyFiltersResponse EndListVocabularyFilters(IAsyncResult asyncResult);

        #endregion
        
        #region  StartMedicalTranscriptionJob


        /// <summary>
        /// Starts a batch job to transcribe medical speech to text.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMedicalTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the StartMedicalTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartMedicalTranscriptionJob">REST API Reference for StartMedicalTranscriptionJob Operation</seealso>
        StartMedicalTranscriptionJobResponse StartMedicalTranscriptionJob(StartMedicalTranscriptionJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartMedicalTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMedicalTranscriptionJob operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMedicalTranscriptionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartMedicalTranscriptionJob">REST API Reference for StartMedicalTranscriptionJob Operation</seealso>
        IAsyncResult BeginStartMedicalTranscriptionJob(StartMedicalTranscriptionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartMedicalTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMedicalTranscriptionJob.</param>
        /// 
        /// <returns>Returns a  StartMedicalTranscriptionJobResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartMedicalTranscriptionJob">REST API Reference for StartMedicalTranscriptionJob Operation</seealso>
        StartMedicalTranscriptionJobResponse EndStartMedicalTranscriptionJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StartTranscriptionJob


        /// <summary>
        /// Starts an asynchronous job to transcribe speech to text.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the StartTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartTranscriptionJob">REST API Reference for StartTranscriptionJob Operation</seealso>
        StartTranscriptionJobResponse StartTranscriptionJob(StartTranscriptionJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTranscriptionJob operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTranscriptionJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartTranscriptionJob">REST API Reference for StartTranscriptionJob Operation</seealso>
        IAsyncResult BeginStartTranscriptionJob(StartTranscriptionJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTranscriptionJob.</param>
        /// 
        /// <returns>Returns a  StartTranscriptionJobResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartTranscriptionJob">REST API Reference for StartTranscriptionJob Operation</seealso>
        StartTranscriptionJobResponse EndStartTranscriptionJob(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMedicalVocabulary


        /// <summary>
        /// Updates a vocabulary with new values that you provide in a different text file from
        /// the one you used to create the vocabulary. The <code>UpdateMedicalVocabulary</code>
        /// operation overwrites all of the existing information with the values that you provide
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMedicalVocabulary service method.</param>
        /// 
        /// <returns>The response from the UpdateMedicalVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateMedicalVocabulary">REST API Reference for UpdateMedicalVocabulary Operation</seealso>
        UpdateMedicalVocabularyResponse UpdateMedicalVocabulary(UpdateMedicalVocabularyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMedicalVocabulary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMedicalVocabulary operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMedicalVocabulary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateMedicalVocabulary">REST API Reference for UpdateMedicalVocabulary Operation</seealso>
        IAsyncResult BeginUpdateMedicalVocabulary(UpdateMedicalVocabularyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMedicalVocabulary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMedicalVocabulary.</param>
        /// 
        /// <returns>Returns a  UpdateMedicalVocabularyResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateMedicalVocabulary">REST API Reference for UpdateMedicalVocabulary Operation</seealso>
        UpdateMedicalVocabularyResponse EndUpdateMedicalVocabulary(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVocabulary


        /// <summary>
        /// Updates an existing vocabulary with new values. The <code>UpdateVocabulary</code>
        /// operation overwrites all of the existing information with the values that you provide
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabulary service method.</param>
        /// 
        /// <returns>The response from the UpdateVocabulary service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// There is already a resource with that name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateVocabulary">REST API Reference for UpdateVocabulary Operation</seealso>
        UpdateVocabularyResponse UpdateVocabulary(UpdateVocabularyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVocabulary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabulary operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVocabulary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateVocabulary">REST API Reference for UpdateVocabulary Operation</seealso>
        IAsyncResult BeginUpdateVocabulary(UpdateVocabularyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVocabulary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVocabulary.</param>
        /// 
        /// <returns>Returns a  UpdateVocabularyResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateVocabulary">REST API Reference for UpdateVocabulary Operation</seealso>
        UpdateVocabularyResponse EndUpdateVocabulary(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateVocabularyFilter


        /// <summary>
        /// Updates a vocabulary filter with a new list of filtered words.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabularyFilter service method.</param>
        /// 
        /// <returns>The response from the UpdateVocabularyFilter service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// Your request didn't pass one or more validation tests. For example, if the entity
        /// that you're trying to delete doesn't exist or if it is in a non-terminal state (for
        /// example, it's "in progress"). See the exception <code>Message</code> field for more
        /// information.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is too long. Wait before
        /// you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested resource. Check the name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateVocabularyFilter">REST API Reference for UpdateVocabularyFilter Operation</seealso>
        UpdateVocabularyFilterResponse UpdateVocabularyFilter(UpdateVocabularyFilterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVocabularyFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabularyFilter operation on AmazonTranscribeServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVocabularyFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateVocabularyFilter">REST API Reference for UpdateVocabularyFilter Operation</seealso>
        IAsyncResult BeginUpdateVocabularyFilter(UpdateVocabularyFilterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVocabularyFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVocabularyFilter.</param>
        /// 
        /// <returns>Returns a  UpdateVocabularyFilterResult from TranscribeService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateVocabularyFilter">REST API Reference for UpdateVocabularyFilter Operation</seealso>
        UpdateVocabularyFilterResponse EndUpdateVocabularyFilter(IAsyncResult asyncResult);

        #endregion
        
    }
}