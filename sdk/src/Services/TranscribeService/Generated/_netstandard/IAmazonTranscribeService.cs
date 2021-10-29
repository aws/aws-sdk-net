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
using System.Threading;
using System.Threading.Tasks;
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
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ITranscribeServicePaginatorFactory Paginators { get; }
#endif
                
        #region  CreateCallAnalyticsCategory



        /// <summary>
        /// Creates an analytics category. Amazon Transcribe applies the conditions specified
        /// by your analytics categories to your call analytics jobs. For each analytics category,
        /// you specify one or more rules. For example, you can specify a rule that the customer
        /// sentiment was neutral or negative within that category. If you start a call analytics
        /// job, Amazon Transcribe applies the category to the analytics job that you've specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCallAnalyticsCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/CreateCallAnalyticsCategory">REST API Reference for CreateCallAnalyticsCategory Operation</seealso>
        Task<CreateCallAnalyticsCategoryResponse> CreateCallAnalyticsCategoryAsync(CreateCallAnalyticsCategoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLanguageModel



        /// <summary>
        /// Creates a new custom language model. Use Amazon S3 prefixes to provide the location
        /// of your input files. The time it takes to create your model depends on the size of
        /// your training data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLanguageModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateLanguageModelResponse> CreateLanguageModelAsync(CreateLanguageModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMedicalVocabulary



        /// <summary>
        /// Creates a new custom vocabulary that you can use to modify how Amazon Transcribe Medical
        /// transcribes your audio file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMedicalVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateMedicalVocabularyResponse> CreateMedicalVocabularyAsync(CreateMedicalVocabularyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVocabulary



        /// <summary>
        /// Creates a new custom vocabulary that you can use to change the way Amazon Transcribe
        /// handles transcription of an audio file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateVocabularyResponse> CreateVocabularyAsync(CreateVocabularyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVocabularyFilter



        /// <summary>
        /// Creates a new vocabulary filter that you can use to filter words, such as profane
        /// words, from the output of a transcription job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVocabularyFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateVocabularyFilterResponse> CreateVocabularyFilterAsync(CreateVocabularyFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCallAnalyticsCategory



        /// <summary>
        /// Deletes a call analytics category using its name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCallAnalyticsCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteCallAnalyticsCategory">REST API Reference for DeleteCallAnalyticsCategory Operation</seealso>
        Task<DeleteCallAnalyticsCategoryResponse> DeleteCallAnalyticsCategoryAsync(DeleteCallAnalyticsCategoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCallAnalyticsJob



        /// <summary>
        /// Deletes a call analytics job using its name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCallAnalyticsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCallAnalyticsJob service method, as returned by TranscribeService.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/DeleteCallAnalyticsJob">REST API Reference for DeleteCallAnalyticsJob Operation</seealso>
        Task<DeleteCallAnalyticsJobResponse> DeleteCallAnalyticsJobAsync(DeleteCallAnalyticsJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLanguageModel



        /// <summary>
        /// Deletes a custom language model using its name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLanguageModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteLanguageModelResponse> DeleteLanguageModelAsync(DeleteLanguageModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMedicalTranscriptionJob



        /// <summary>
        /// Deletes a transcription job generated by Amazon Transcribe Medical and any related
        /// information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteMedicalTranscriptionJobResponse> DeleteMedicalTranscriptionJobAsync(DeleteMedicalTranscriptionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMedicalVocabulary



        /// <summary>
        /// Deletes a vocabulary from Amazon Transcribe Medical.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMedicalVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteMedicalVocabularyResponse> DeleteMedicalVocabularyAsync(DeleteMedicalVocabularyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTranscriptionJob



        /// <summary>
        /// Deletes a previously submitted transcription job along with any other generated results
        /// such as the transcription, models, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteTranscriptionJobResponse> DeleteTranscriptionJobAsync(DeleteTranscriptionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVocabulary



        /// <summary>
        /// Deletes a vocabulary from Amazon Transcribe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteVocabularyResponse> DeleteVocabularyAsync(DeleteVocabularyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVocabularyFilter



        /// <summary>
        /// Removes a vocabulary filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVocabularyFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteVocabularyFilterResponse> DeleteVocabularyFilterAsync(DeleteVocabularyFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLanguageModel



        /// <summary>
        /// Gets information about a single custom language model. Use this information to see
        /// details about the language model in your Amazon Web Services account. You can also
        /// see whether the base language model used to create your custom language model has
        /// been updated. If Amazon Transcribe has updated the base model, you can create a new
        /// custom language model using the updated base model. If the language model wasn't created,
        /// you can use this operation to understand why Amazon Transcribe couldn't create it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLanguageModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeLanguageModelResponse> DescribeLanguageModelAsync(DescribeLanguageModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCallAnalyticsCategory



        /// <summary>
        /// Retrieves information about a call analytics category.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCallAnalyticsCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetCallAnalyticsCategory">REST API Reference for GetCallAnalyticsCategory Operation</seealso>
        Task<GetCallAnalyticsCategoryResponse> GetCallAnalyticsCategoryAsync(GetCallAnalyticsCategoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCallAnalyticsJob



        /// <summary>
        /// Returns information about a call analytics job. To see the status of the job, check
        /// the <code>CallAnalyticsJobStatus</code> field. If the status is <code>COMPLETED</code>,
        /// the job is finished and you can find the results at the location specified in the
        /// <code>TranscriptFileUri</code> field. If you enable personally identifiable information
        /// (PII) redaction, the redacted transcript appears in the <code>RedactedTranscriptFileUri</code>
        /// field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCallAnalyticsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCallAnalyticsJob service method, as returned by TranscribeService.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetCallAnalyticsJob">REST API Reference for GetCallAnalyticsJob Operation</seealso>
        Task<GetCallAnalyticsJobResponse> GetCallAnalyticsJobAsync(GetCallAnalyticsJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMedicalTranscriptionJob



        /// <summary>
        /// Returns information about a transcription job from Amazon Transcribe Medical. To see
        /// the status of the job, check the <code>TranscriptionJobStatus</code> field. If the
        /// status is <code>COMPLETED</code>, the job is finished. You find the results of the
        /// completed job in the <code>TranscriptFileUri</code> field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetMedicalTranscriptionJobResponse> GetMedicalTranscriptionJobAsync(GetMedicalTranscriptionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMedicalVocabulary



        /// <summary>
        /// Retrieves information about a medical vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetMedicalVocabularyResponse> GetMedicalVocabularyAsync(GetMedicalVocabularyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetTranscriptionJobResponse> GetTranscriptionJobAsync(GetTranscriptionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVocabulary



        /// <summary>
        /// Gets information about a vocabulary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetVocabularyResponse> GetVocabularyAsync(GetVocabularyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVocabularyFilter



        /// <summary>
        /// Returns information about a vocabulary filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVocabularyFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetVocabularyFilterResponse> GetVocabularyFilterAsync(GetVocabularyFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCallAnalyticsCategories



        /// <summary>
        /// Provides more information about the call analytics categories that you've created.
        /// You can use the information in this list to find a specific category. You can then
        /// use the operation to get more information about it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCallAnalyticsCategories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCallAnalyticsCategories service method, as returned by TranscribeService.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListCallAnalyticsCategories">REST API Reference for ListCallAnalyticsCategories Operation</seealso>
        Task<ListCallAnalyticsCategoriesResponse> ListCallAnalyticsCategoriesAsync(ListCallAnalyticsCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCallAnalyticsJobs



        /// <summary>
        /// List call analytics jobs with a specified status or substring that matches their names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCallAnalyticsJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCallAnalyticsJobs service method, as returned by TranscribeService.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListCallAnalyticsJobs">REST API Reference for ListCallAnalyticsJobs Operation</seealso>
        Task<ListCallAnalyticsJobsResponse> ListCallAnalyticsJobsAsync(ListCallAnalyticsJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLanguageModels



        /// <summary>
        /// Provides more information about the custom language models you've created. You can
        /// use the information in this list to find a specific custom language model. You can
        /// then use the operation to get more information about it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLanguageModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListLanguageModelsResponse> ListLanguageModelsAsync(ListLanguageModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMedicalTranscriptionJobs



        /// <summary>
        /// Lists medical transcription jobs with a specified status or substring that matches
        /// their names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalTranscriptionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListMedicalTranscriptionJobsResponse> ListMedicalTranscriptionJobsAsync(ListMedicalTranscriptionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMedicalVocabularies



        /// <summary>
        /// Returns a list of vocabularies that match the specified criteria. If you don't enter
        /// a value in any of the request parameters, returns the entire list of vocabularies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMedicalVocabularies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListMedicalVocabulariesResponse> ListMedicalVocabulariesAsync(ListMedicalVocabulariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists all tags associated with a given transcription job, vocabulary, or resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by TranscribeService.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTranscriptionJobs



        /// <summary>
        /// Lists transcription jobs with the specified status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTranscriptionJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTranscriptionJobsResponse> ListTranscriptionJobsAsync(ListTranscriptionJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVocabularies



        /// <summary>
        /// Returns a list of vocabularies that match the specified criteria. If no criteria are
        /// specified, returns the entire list of vocabularies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVocabularies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListVocabulariesResponse> ListVocabulariesAsync(ListVocabulariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVocabularyFilters



        /// <summary>
        /// Gets information about vocabulary filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVocabularyFilters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListVocabularyFiltersResponse> ListVocabularyFiltersAsync(ListVocabularyFiltersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartCallAnalyticsJob



        /// <summary>
        /// Starts an asynchronous analytics job that not only transcribes the audio recording
        /// of a caller and agent, but also returns additional insights. These insights include
        /// how quickly or loudly the caller or agent was speaking. To retrieve additional insights
        /// with your analytics jobs, create categories. A category is a way to classify analytics
        /// jobs based on attributes, such as a customer's sentiment or a particular phrase being
        /// used during the call. For more information, see the operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCallAnalyticsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCallAnalyticsJob service method, as returned by TranscribeService.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartCallAnalyticsJob">REST API Reference for StartCallAnalyticsJob Operation</seealso>
        Task<StartCallAnalyticsJobResponse> StartCallAnalyticsJobAsync(StartCallAnalyticsJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartMedicalTranscriptionJob



        /// <summary>
        /// Starts a batch job to transcribe medical speech to text.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMedicalTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartMedicalTranscriptionJobResponse> StartMedicalTranscriptionJobAsync(StartMedicalTranscriptionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartTranscriptionJob



        /// <summary>
        /// Starts an asynchronous job to transcribe speech to text.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTranscriptionJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartTranscriptionJobResponse> StartTranscriptionJobAsync(StartTranscriptionJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Tags an Amazon Transcribe resource with the given list of tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by TranscribeService.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes specified tags from a specified Amazon Transcribe resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by TranscribeService.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCallAnalyticsCategory



        /// <summary>
        /// Updates the call analytics category with new values. The <code>UpdateCallAnalyticsCategory</code>
        /// operation overwrites all of the existing information with the values that you provide
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCallAnalyticsCategory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCallAnalyticsCategory service method, as returned by TranscribeService.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/UpdateCallAnalyticsCategory">REST API Reference for UpdateCallAnalyticsCategory Operation</seealso>
        Task<UpdateCallAnalyticsCategoryResponse> UpdateCallAnalyticsCategoryAsync(UpdateCallAnalyticsCategoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMedicalVocabulary



        /// <summary>
        /// Updates a vocabulary with new values that you provide in a different text file from
        /// the one you used to create the vocabulary. The <code>UpdateMedicalVocabulary</code>
        /// operation overwrites all of the existing information with the values that you provide
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMedicalVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateMedicalVocabularyResponse> UpdateMedicalVocabularyAsync(UpdateMedicalVocabularyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVocabulary



        /// <summary>
        /// Updates an existing vocabulary with new values. The <code>UpdateVocabulary</code>
        /// operation overwrites all of the existing information with the values that you provide
        /// in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabulary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateVocabularyResponse> UpdateVocabularyAsync(UpdateVocabularyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVocabularyFilter



        /// <summary>
        /// Updates a vocabulary filter with a new list of filtered words.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVocabularyFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateVocabularyFilterResponse> UpdateVocabularyFilterAsync(UpdateVocabularyFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}