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

        
        #region  GetTranscriptionJob


        /// <summary>
        /// Returns information about a transcription job. To see the status of the job, check
        /// the <code>Status</code> field. If the status is <code>COMPLETE</code>, the job is
        /// finished and you can find the results at the location specified in the <code>TranscriptionFileUri</code>
        /// field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the GetTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// There is a problem with one of the input fields. Check the S3 bucket name, make sure
        /// that the job name is not a duplicate, and confirm that you are using the correct file
        /// format. Then resend your request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is longer than 2 hours.
        /// Wait before you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.NotFoundException">
        /// We can't find the requested job. Check the job name and try your request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetTranscriptionJob">REST API Reference for GetTranscriptionJob Operation</seealso>
        GetTranscriptionJobResponse GetTranscriptionJob(GetTranscriptionJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTranscriptionJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/GetTranscriptionJob">REST API Reference for GetTranscriptionJob Operation</seealso>
        Task<GetTranscriptionJobResponse> GetTranscriptionJobAsync(GetTranscriptionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTranscriptionJobs


        /// <summary>
        /// Lists transcription jobs with the specified status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTranscriptionJobs service method.</param>
        /// 
        /// <returns>The response from the ListTranscriptionJobs service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// There is a problem with one of the input fields. Check the S3 bucket name, make sure
        /// that the job name is not a duplicate, and confirm that you are using the correct file
        /// format. Then resend your request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is longer than 2 hours.
        /// Wait before you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTranscriptionJobs">REST API Reference for ListTranscriptionJobs Operation</seealso>
        ListTranscriptionJobsResponse ListTranscriptionJobs(ListTranscriptionJobsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListTranscriptionJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTranscriptionJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/ListTranscriptionJobs">REST API Reference for ListTranscriptionJobs Operation</seealso>
        Task<ListTranscriptionJobsResponse> ListTranscriptionJobsAsync(ListTranscriptionJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartTranscriptionJob


        /// <summary>
        /// Starts an asynchronous job to transcribe speech to text.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTranscriptionJob service method.</param>
        /// 
        /// <returns>The response from the StartTranscriptionJob service method, as returned by TranscribeService.</returns>
        /// <exception cref="Amazon.TranscribeService.Model.BadRequestException">
        /// There is a problem with one of the input fields. Check the S3 bucket name, make sure
        /// that the job name is not a duplicate, and confirm that you are using the correct file
        /// format. Then resend your request.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.ConflictException">
        /// The <code>JobName</code> field is a duplicate of a previously entered job name. Resend
        /// your request with a different name.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.InternalFailureException">
        /// There was an internal error. Check the error message and try your request again.
        /// </exception>
        /// <exception cref="Amazon.TranscribeService.Model.LimitExceededException">
        /// Either you have sent too many requests or your input file is longer than 2 hours.
        /// Wait before you resend your request, or use a smaller file and resend the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartTranscriptionJob">REST API Reference for StartTranscriptionJob Operation</seealso>
        StartTranscriptionJobResponse StartTranscriptionJob(StartTranscriptionJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartTranscriptionJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTranscriptionJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transcribe-2017-10-26/StartTranscriptionJob">REST API Reference for StartTranscriptionJob Operation</seealso>
        Task<StartTranscriptionJobResponse> StartTranscriptionJobAsync(StartTranscriptionJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}