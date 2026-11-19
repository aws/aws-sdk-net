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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Polly.Model;

#pragma warning disable CS1570

namespace Amazon.Polly
{
    /// <summary>
    /// <para>Interface for accessing Polly</para>
    ///
    /// Amazon Polly is a web service that makes it easy to synthesize speech from text.
    /// 
    ///  
    /// <para>
    /// The Amazon Polly service provides API operations for synthesizing high-quality speech
    /// from plain text and Speech Synthesis Markup Language (SSML), along with managing pronunciations
    /// lexicons that enable you to get the best results for your application domain.
    /// </para>
    ///  
    /// <para>
    /// Authenticated API calls must be signed using the Signature Version 4 Signing Process.
    /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_sigv.html">Signing
    /// Amazon Web Services API Requests</a> in the <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonPolly : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPollyPaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a custom voice from recordings of a speaker and returns it in <c>pending</c>
        /// status. Use <c>GetVoice</c> to check the status. When the status is <c>active</c>,
        /// you can use the voice ID in <c>SynthesizeSpeech</c>, <c>StartSpeechSynthesisTask</c>,
        /// and <c>StartSpeechSynthesisStream</c>.
        /// 
        ///  
        /// <para>
        /// The <c>custom-voice-max-count</c> service quota limits the number of custom voices
        /// in your account in each Region. If you reach the quota, the request fails with <c>ServiceQuotaExceededException</c>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>polly:CreateVoice</c> action.
        /// You also need <c>s3:GetObject</c> permission on each recording that you specify by
        /// <c>S3Url</c>. If you specify a customer managed key, you also need <c>kms:DescribeKey</c>,
        /// <c>kms:GenerateDataKey</c>, and <c>kms:Decrypt</c> permissions on the key. If you
        /// specify <c>Tags</c>, you also need the <c>polly:TagResource</c> permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVoice service method.</param>
        /// <returns>The response from the CreateVoice service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action. For a custom voice that
        /// uses a customer managed key, Amazon Polly also returns this exception if you don't
        /// have the required Amazon Web Services KMS permissions on the key.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidTagParameterException">
        /// The resource ARN or a tag in the request isn't valid. Specify the ARN of a supported
        /// resource in the Amazon Web Services account and Region of the request. Tag keys can
        /// have a maximum length of 128 characters, and tag values can have a maximum length
        /// of 256 characters. Correct the ARN or the tags, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.TooManyTagsException">
        /// The list of tags on the resource is over the limit. The maximum number of tags that
        /// can be applied to a resource is 50. Remove unused tags or reduce the number of tags
        /// in the request, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/CreateVoice">REST API Reference for CreateVoice Operation</seealso>
        CreateVoiceResponse CreateVoice(CreateVoiceRequest request);
#endif

        /// <summary>
        /// Creates a custom voice from recordings of a speaker and returns it in <c>pending</c>
        /// status. Use <c>GetVoice</c> to check the status. When the status is <c>active</c>,
        /// you can use the voice ID in <c>SynthesizeSpeech</c>, <c>StartSpeechSynthesisTask</c>,
        /// and <c>StartSpeechSynthesisStream</c>.
        /// 
        ///  
        /// <para>
        /// The <c>custom-voice-max-count</c> service quota limits the number of custom voices
        /// in your account in each Region. If you reach the quota, the request fails with <c>ServiceQuotaExceededException</c>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>polly:CreateVoice</c> action.
        /// You also need <c>s3:GetObject</c> permission on each recording that you specify by
        /// <c>S3Url</c>. If you specify a customer managed key, you also need <c>kms:DescribeKey</c>,
        /// <c>kms:GenerateDataKey</c>, and <c>kms:Decrypt</c> permissions on the key. If you
        /// specify <c>Tags</c>, you also need the <c>polly:TagResource</c> permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVoice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateVoice service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action. For a custom voice that
        /// uses a customer managed key, Amazon Polly also returns this exception if you don't
        /// have the required Amazon Web Services KMS permissions on the key.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidTagParameterException">
        /// The resource ARN or a tag in the request isn't valid. Specify the ARN of a supported
        /// resource in the Amazon Web Services account and Region of the request. Tag keys can
        /// have a maximum length of 128 characters, and tag values can have a maximum length
        /// of 256 characters. Correct the ARN or the tags, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.TooManyTagsException">
        /// The list of tags on the resource is over the limit. The maximum number of tags that
        /// can be applied to a resource is 50. Remove unused tags or reduce the number of tags
        /// in the request, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/CreateVoice">REST API Reference for CreateVoice Operation</seealso>
        Task<CreateVoiceResponse> CreateVoiceAsync(CreateVoiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the specified pronunciation lexicon stored in an Amazon Web Services Region.
        /// A lexicon which has been deleted is not available for speech synthesis, nor is it
        /// possible to retrieve it using either the <c>GetLexicon</c> or <c>ListLexicon</c> APIs.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
        /// Lexicons</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLexicon service method.</param>
        /// <returns>The response from the DeleteLexicon service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.LexiconNotFoundException">
        /// Amazon Polly can't find the specified lexicon. This could be caused by a lexicon that
        /// is missing, its name is misspelled or specifying a lexicon that is in a different
        /// region.
        /// 
        ///  
        /// <para>
        /// Verify that the lexicon exists, is in the region (see <a>ListLexicons</a>) and that
        /// you spelled its name is spelled correctly. Then try again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/DeleteLexicon">REST API Reference for DeleteLexicon Operation</seealso>
        DeleteLexiconResponse DeleteLexicon(DeleteLexiconRequest request);
#endif

        /// <summary>
        /// Deletes the specified pronunciation lexicon stored in an Amazon Web Services Region.
        /// A lexicon which has been deleted is not available for speech synthesis, nor is it
        /// possible to retrieve it using either the <c>GetLexicon</c> or <c>ListLexicon</c> APIs.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
        /// Lexicons</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLexicon service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteLexicon service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.LexiconNotFoundException">
        /// Amazon Polly can't find the specified lexicon. This could be caused by a lexicon that
        /// is missing, its name is misspelled or specifying a lexicon that is in a different
        /// region.
        /// 
        ///  
        /// <para>
        /// Verify that the lexicon exists, is in the region (see <a>ListLexicons</a>) and that
        /// you spelled its name is spelled correctly. Then try again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/DeleteLexicon">REST API Reference for DeleteLexicon Operation</seealso>
        Task<DeleteLexiconResponse> DeleteLexiconAsync(DeleteLexiconRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a custom voice. <c>DescribeVoices</c> and <c>GetVoice</c> stop returning the
        /// voice immediately. You can't restore a deleted voice.
        /// 
        ///  
        /// <para>
        /// You can delete a voice in <c>active</c> or <c>failed</c> status. If the voice is in
        /// <c>pending</c> status, the request fails with <c>ConflictException</c>. If no custom
        /// voice with the specified ID exists in your account and Region, the request fails with
        /// <c>ResourceNotFoundException</c>. You can delete the voice even if you disabled its
        /// Amazon Web Services KMS key or scheduled it for deletion.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>polly:DeleteVoice</c> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoice service method.</param>
        /// <returns>The response from the DeleteVoice service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For a custom voice,
        /// the voice isn't in the status that the operation requires. Check the status with <c>GetVoice</c>,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ResourceNotFoundException">
        /// Amazon Polly can't find the specified resource. Verify that the resource exists in
        /// the Amazon Web Services account and Region of the request and that its ARN or ID is
        /// spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/DeleteVoice">REST API Reference for DeleteVoice Operation</seealso>
        DeleteVoiceResponse DeleteVoice(DeleteVoiceRequest request);
#endif

        /// <summary>
        /// Deletes a custom voice. <c>DescribeVoices</c> and <c>GetVoice</c> stop returning the
        /// voice immediately. You can't restore a deleted voice.
        /// 
        ///  
        /// <para>
        /// You can delete a voice in <c>active</c> or <c>failed</c> status. If the voice is in
        /// <c>pending</c> status, the request fails with <c>ConflictException</c>. If no custom
        /// voice with the specified ID exists in your account and Region, the request fails with
        /// <c>ResourceNotFoundException</c>. You can delete the voice even if you disabled its
        /// Amazon Web Services KMS key or scheduled it for deletion.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>polly:DeleteVoice</c> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteVoice service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For a custom voice,
        /// the voice isn't in the status that the operation requires. Check the status with <c>GetVoice</c>,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ResourceNotFoundException">
        /// Amazon Polly can't find the specified resource. Verify that the resource exists in
        /// the Amazon Web Services account and Region of the request and that its ARN or ID is
        /// spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/DeleteVoice">REST API Reference for DeleteVoice Operation</seealso>
        Task<DeleteVoiceResponse> DeleteVoiceAsync(DeleteVoiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns the list of voices: the voices that Amazon Polly provides and the custom voices
        /// in your account. Each voice speaks a specified language and is identified by an ID.
        /// A voice that Amazon Polly provides is either male or female, and its ID is the ASCII
        /// version of the voice name.
        /// 
        ///  
        /// <para>
        /// When synthesizing speech (<c>SynthesizeSpeech</c>), you provide the voice ID for the
        /// voice you want from the list of voices returned by <c>DescribeVoices</c>.
        /// </para>
        ///  
        /// <para>
        /// For example, your news reader application reads news in a specific language, and you
        /// want to give users the option to choose the voice. With the <c>DescribeVoices</c>
        /// operation, you can provide a list of available voices for users to choose from.
        /// </para>
        ///  
        /// <para>
        ///  You can optionally specify a language code to filter the available voices. For example,
        /// if you specify <c>en-US</c>, the operation returns a list of all available US English
        /// voices. 
        /// </para>
        ///  
        /// <para>
        /// The list includes custom voices in every status. For each voice, <c>Origin</c> indicates
        /// whether Amazon Polly provides the voice or you created it. You can use a custom voice
        /// for synthesis only when its status is <c>active</c>. A voice in <c>failed</c> status
        /// stays in the list until you delete it.
        /// </para>
        ///  
        /// <para>
        /// For a custom voice, <c>DescribeVoices</c> returns <c>Origin</c>, <c>Id</c>, <c>Name</c>,
        /// <c>Status</c>, <c>LanguageCode</c>, <c>LanguageName</c>, <c>SupportedEngines</c>,
        /// and <c>CreationTime</c>. To get <c>Arn</c>, <c>StatusReason</c>, <c>VoiceCreationData</c>,
        /// and <c>CustomerManagedEncryption</c>, use <c>GetVoice</c>.
        /// </para>
        ///  
        /// <para>
        /// The <c>LanguageCode</c> and <c>Engine</c> filters apply to custom voices in the same
        /// way as to voices that Amazon Polly provides.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>polly:DescribeVoices</c> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVoices service method.</param>
        /// <returns>The response from the DescribeVoices service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidNextTokenException">
        /// The NextToken is invalid. Verify that it's spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/DescribeVoices">REST API Reference for DescribeVoices Operation</seealso>
        DescribeVoicesResponse DescribeVoices(DescribeVoicesRequest request);
#endif

        /// <summary>
        /// Returns the list of voices: the voices that Amazon Polly provides and the custom voices
        /// in your account. Each voice speaks a specified language and is identified by an ID.
        /// A voice that Amazon Polly provides is either male or female, and its ID is the ASCII
        /// version of the voice name.
        /// 
        ///  
        /// <para>
        /// When synthesizing speech (<c>SynthesizeSpeech</c>), you provide the voice ID for the
        /// voice you want from the list of voices returned by <c>DescribeVoices</c>.
        /// </para>
        ///  
        /// <para>
        /// For example, your news reader application reads news in a specific language, and you
        /// want to give users the option to choose the voice. With the <c>DescribeVoices</c>
        /// operation, you can provide a list of available voices for users to choose from.
        /// </para>
        ///  
        /// <para>
        ///  You can optionally specify a language code to filter the available voices. For example,
        /// if you specify <c>en-US</c>, the operation returns a list of all available US English
        /// voices. 
        /// </para>
        ///  
        /// <para>
        /// The list includes custom voices in every status. For each voice, <c>Origin</c> indicates
        /// whether Amazon Polly provides the voice or you created it. You can use a custom voice
        /// for synthesis only when its status is <c>active</c>. A voice in <c>failed</c> status
        /// stays in the list until you delete it.
        /// </para>
        ///  
        /// <para>
        /// For a custom voice, <c>DescribeVoices</c> returns <c>Origin</c>, <c>Id</c>, <c>Name</c>,
        /// <c>Status</c>, <c>LanguageCode</c>, <c>LanguageName</c>, <c>SupportedEngines</c>,
        /// and <c>CreationTime</c>. To get <c>Arn</c>, <c>StatusReason</c>, <c>VoiceCreationData</c>,
        /// and <c>CustomerManagedEncryption</c>, use <c>GetVoice</c>.
        /// </para>
        ///  
        /// <para>
        /// The <c>LanguageCode</c> and <c>Engine</c> filters apply to custom voices in the same
        /// way as to voices that Amazon Polly provides.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>polly:DescribeVoices</c> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVoices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DescribeVoices service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidNextTokenException">
        /// The NextToken is invalid. Verify that it's spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/DescribeVoices">REST API Reference for DescribeVoices Operation</seealso>
        Task<DescribeVoicesResponse> DescribeVoicesAsync(DescribeVoicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns the content of the specified pronunciation lexicon stored in an Amazon Web
        /// Services Region. For more information, see <a href="https://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
        /// Lexicons</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLexicon service method.</param>
        /// <returns>The response from the GetLexicon service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.LexiconNotFoundException">
        /// Amazon Polly can't find the specified lexicon. This could be caused by a lexicon that
        /// is missing, its name is misspelled or specifying a lexicon that is in a different
        /// region.
        /// 
        ///  
        /// <para>
        /// Verify that the lexicon exists, is in the region (see <a>ListLexicons</a>) and that
        /// you spelled its name is spelled correctly. Then try again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/GetLexicon">REST API Reference for GetLexicon Operation</seealso>
        GetLexiconResponse GetLexicon(GetLexiconRequest request);
#endif

        /// <summary>
        /// Returns the content of the specified pronunciation lexicon stored in an Amazon Web
        /// Services Region. For more information, see <a href="https://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
        /// Lexicons</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLexicon service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetLexicon service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.LexiconNotFoundException">
        /// Amazon Polly can't find the specified lexicon. This could be caused by a lexicon that
        /// is missing, its name is misspelled or specifying a lexicon that is in a different
        /// region.
        /// 
        ///  
        /// <para>
        /// Verify that the lexicon exists, is in the region (see <a>ListLexicons</a>) and that
        /// you spelled its name is spelled correctly. Then try again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/GetLexicon">REST API Reference for GetLexicon Operation</seealso>
        Task<GetLexiconResponse> GetLexiconAsync(GetLexiconRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves a specific SpeechSynthesisTask object based on its TaskID. This object contains
        /// information about the given speech synthesis task, including the status of the task,
        /// and a link to the S3 bucket containing the output of the task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpeechSynthesisTask service method.</param>
        /// <returns>The response from the GetSpeechSynthesisTask service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidTaskIdException">
        /// The provided Task ID is not valid. Please provide a valid Task ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.SynthesisTaskNotFoundException">
        /// The Speech Synthesis task with requested Task ID cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/GetSpeechSynthesisTask">REST API Reference for GetSpeechSynthesisTask Operation</seealso>
        GetSpeechSynthesisTaskResponse GetSpeechSynthesisTask(GetSpeechSynthesisTaskRequest request);
#endif

        /// <summary>
        /// Retrieves a specific SpeechSynthesisTask object based on its TaskID. This object contains
        /// information about the given speech synthesis task, including the status of the task,
        /// and a link to the S3 bucket containing the output of the task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSpeechSynthesisTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetSpeechSynthesisTask service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidTaskIdException">
        /// The provided Task ID is not valid. Please provide a valid Task ID and try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.SynthesisTaskNotFoundException">
        /// The Speech Synthesis task with requested Task ID cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/GetSpeechSynthesisTask">REST API Reference for GetSpeechSynthesisTask Operation</seealso>
        Task<GetSpeechSynthesisTaskResponse> GetSpeechSynthesisTaskAsync(GetSpeechSynthesisTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns the status and properties of a custom voice. Use this operation after <c>CreateVoice</c>
        /// to check whether the status of the voice is <c>active</c> or <c>failed</c>. Unlike
        /// <c>DescribeVoices</c>, <c>GetVoice</c> also returns <c>Arn</c>, <c>VoiceCreationData</c>,
        /// <c>CustomerManagedEncryption</c>, and <c>StatusReason</c>. If no custom voice with
        /// the specified ID exists in your account and Region, the request fails with <c>ResourceNotFoundException</c>.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>polly:GetVoice</c> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoice service method.</param>
        /// <returns>The response from the GetVoice service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.ResourceNotFoundException">
        /// Amazon Polly can't find the specified resource. Verify that the resource exists in
        /// the Amazon Web Services account and Region of the request and that its ARN or ID is
        /// spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/GetVoice">REST API Reference for GetVoice Operation</seealso>
        GetVoiceResponse GetVoice(GetVoiceRequest request);
#endif

        /// <summary>
        /// Returns the status and properties of a custom voice. Use this operation after <c>CreateVoice</c>
        /// to check whether the status of the voice is <c>active</c> or <c>failed</c>. Unlike
        /// <c>DescribeVoices</c>, <c>GetVoice</c> also returns <c>Arn</c>, <c>VoiceCreationData</c>,
        /// <c>CustomerManagedEncryption</c>, and <c>StatusReason</c>. If no custom voice with
        /// the specified ID exists in your account and Region, the request fails with <c>ResourceNotFoundException</c>.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <c>polly:GetVoice</c> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVoice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetVoice service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.ResourceNotFoundException">
        /// Amazon Polly can't find the specified resource. Verify that the resource exists in
        /// the Amazon Web Services account and Region of the request and that its ARN or ID is
        /// spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/GetVoice">REST API Reference for GetVoice Operation</seealso>
        Task<GetVoiceResponse> GetVoiceAsync(GetVoiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of pronunciation lexicons stored in an Amazon Web Services Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
        /// Lexicons</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLexicons service method.</param>
        /// <returns>The response from the ListLexicons service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidNextTokenException">
        /// The NextToken is invalid. Verify that it's spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/ListLexicons">REST API Reference for ListLexicons Operation</seealso>
        ListLexiconsResponse ListLexicons(ListLexiconsRequest request);
#endif

        /// <summary>
        /// Returns a list of pronunciation lexicons stored in an Amazon Web Services Region.
        /// For more information, see <a href="https://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
        /// Lexicons</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLexicons service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListLexicons service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidNextTokenException">
        /// The NextToken is invalid. Verify that it's spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/ListLexicons">REST API Reference for ListLexicons Operation</seealso>
        Task<ListLexiconsResponse> ListLexiconsAsync(ListLexiconsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a list of SpeechSynthesisTask objects ordered by their creation date. This
        /// operation can filter the tasks by their status, for example, allowing users to list
        /// only tasks that are completed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpeechSynthesisTasks service method.</param>
        /// <returns>The response from the ListSpeechSynthesisTasks service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidNextTokenException">
        /// The NextToken is invalid. Verify that it's spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/ListSpeechSynthesisTasks">REST API Reference for ListSpeechSynthesisTasks Operation</seealso>
        ListSpeechSynthesisTasksResponse ListSpeechSynthesisTasks(ListSpeechSynthesisTasksRequest request);
#endif

        /// <summary>
        /// Returns a list of SpeechSynthesisTask objects ordered by their creation date. This
        /// operation can filter the tasks by their status, for example, allowing users to list
        /// only tasks that are completed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSpeechSynthesisTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListSpeechSynthesisTasks service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidNextTokenException">
        /// The NextToken is invalid. Verify that it's spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/ListSpeechSynthesisTasks">REST API Reference for ListSpeechSynthesisTasks Operation</seealso>
        Task<ListSpeechSynthesisTasksResponse> ListSpeechSynthesisTasksAsync(ListSpeechSynthesisTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the tags for an Amazon Polly resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidTagParameterException">
        /// The resource ARN or a tag in the request isn't valid. Specify the ARN of a supported
        /// resource in the Amazon Web Services account and Region of the request. Tag keys can
        /// have a maximum length of 128 characters, and tag values can have a maximum length
        /// of 256 characters. Correct the ARN or the tags, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ResourceNotFoundException">
        /// Amazon Polly can't find the specified resource. Verify that the resource exists in
        /// the Amazon Web Services account and Region of the request and that its ARN or ID is
        /// spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);
#endif

        /// <summary>
        /// Lists the tags for an Amazon Polly resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidTagParameterException">
        /// The resource ARN or a tag in the request isn't valid. Specify the ARN of a supported
        /// resource in the Amazon Web Services account and Region of the request. Tag keys can
        /// have a maximum length of 128 characters, and tag values can have a maximum length
        /// of 256 characters. Correct the ARN or the tags, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ResourceNotFoundException">
        /// Amazon Polly can't find the specified resource. Verify that the resource exists in
        /// the Amazon Web Services account and Region of the request and that its ARN or ID is
        /// spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Stores a pronunciation lexicon in an Amazon Web Services Region. If a lexicon with
        /// the same name already exists in the region, it is overwritten by the new lexicon.
        /// Lexicon operations have eventual consistency, therefore, it might take some time before
        /// the lexicon is available to the SynthesizeSpeech operation.
        /// 
        ///  
        /// <para>
        /// Overwriting a lexicon keeps its existing tags. You can specify tags only when you
        /// create a lexicon. If you specify tags for a lexicon that already exists, the request
        /// fails with a <c>ValidationException</c>. To change the tags of an existing lexicon,
        /// use <c>TagResource</c> and <c>UntagResource</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
        /// Lexicons</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLexicon service method.</param>
        /// <returns>The response from the PutLexicon service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidLexiconException">
        /// Amazon Polly can't find the specified lexicon. Verify that the lexicon's name is spelled
        /// correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidTagParameterException">
        /// The resource ARN or a tag in the request isn't valid. Specify the ARN of a supported
        /// resource in the Amazon Web Services account and Region of the request. Tag keys can
        /// have a maximum length of 128 characters, and tag values can have a maximum length
        /// of 256 characters. Correct the ARN or the tags, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.LexiconSizeExceededException">
        /// The maximum size of the specified lexicon would be exceeded by this operation.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.MaxLexemeLengthExceededException">
        /// The maximum size of the lexeme would be exceeded by this operation.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.MaxLexiconsNumberExceededException">
        /// The maximum number of lexicons would be exceeded by this operation.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.TooManyTagsException">
        /// The list of tags on the resource is over the limit. The maximum number of tags that
        /// can be applied to a resource is 50. Remove unused tags or reduce the number of tags
        /// in the request, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.UnsupportedPlsAlphabetException">
        /// The alphabet specified by the lexicon is not a supported alphabet. Valid values are
        /// <c>ipa</c>, <c>x-sampa</c>, <c>x-amazon-pinyin</c>, <c>x-amazon-jyutping</c>, <c>x-amazon-pron-kana</c>,
        /// and <c>x-amazon-yomigana</c>. Replace the unsupported alphabet with one of the valid
        /// values and resubmit your request.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.UnsupportedPlsLanguageException">
        /// The language specified in the lexicon is unsupported. For a list of supported languages,
        /// see <a href="https://docs.aws.amazon.com/polly/latest/dg/API_LexiconAttributes.html">Lexicon
        /// Attributes</a>.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/PutLexicon">REST API Reference for PutLexicon Operation</seealso>
        PutLexiconResponse PutLexicon(PutLexiconRequest request);
#endif

        /// <summary>
        /// Stores a pronunciation lexicon in an Amazon Web Services Region. If a lexicon with
        /// the same name already exists in the region, it is overwritten by the new lexicon.
        /// Lexicon operations have eventual consistency, therefore, it might take some time before
        /// the lexicon is available to the SynthesizeSpeech operation.
        /// 
        ///  
        /// <para>
        /// Overwriting a lexicon keeps its existing tags. You can specify tags only when you
        /// create a lexicon. If you specify tags for a lexicon that already exists, the request
        /// fails with a <c>ValidationException</c>. To change the tags of an existing lexicon,
        /// use <c>TagResource</c> and <c>UntagResource</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
        /// Lexicons</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLexicon service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutLexicon service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidLexiconException">
        /// Amazon Polly can't find the specified lexicon. Verify that the lexicon's name is spelled
        /// correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidTagParameterException">
        /// The resource ARN or a tag in the request isn't valid. Specify the ARN of a supported
        /// resource in the Amazon Web Services account and Region of the request. Tag keys can
        /// have a maximum length of 128 characters, and tag values can have a maximum length
        /// of 256 characters. Correct the ARN or the tags, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.LexiconSizeExceededException">
        /// The maximum size of the specified lexicon would be exceeded by this operation.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.MaxLexemeLengthExceededException">
        /// The maximum size of the lexeme would be exceeded by this operation.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.MaxLexiconsNumberExceededException">
        /// The maximum number of lexicons would be exceeded by this operation.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.TooManyTagsException">
        /// The list of tags on the resource is over the limit. The maximum number of tags that
        /// can be applied to a resource is 50. Remove unused tags or reduce the number of tags
        /// in the request, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.UnsupportedPlsAlphabetException">
        /// The alphabet specified by the lexicon is not a supported alphabet. Valid values are
        /// <c>ipa</c>, <c>x-sampa</c>, <c>x-amazon-pinyin</c>, <c>x-amazon-jyutping</c>, <c>x-amazon-pron-kana</c>,
        /// and <c>x-amazon-yomigana</c>. Replace the unsupported alphabet with one of the valid
        /// values and resubmit your request.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.UnsupportedPlsLanguageException">
        /// The language specified in the lexicon is unsupported. For a list of supported languages,
        /// see <a href="https://docs.aws.amazon.com/polly/latest/dg/API_LexiconAttributes.html">Lexicon
        /// Attributes</a>.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/PutLexicon">REST API Reference for PutLexicon Operation</seealso>
        Task<PutLexiconResponse> PutLexiconAsync(PutLexiconRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NET8_0_OR_GREATER
#if NETFRAMEWORK
        /// <summary>
        /// Synthesizes UTF-8 input, plain text, or SSML over a bidirectional streaming connection.
        /// Specify synthesis parameters in HTTP/2 headers, send text incrementally as events
        /// on the input stream, and receive synthesized audio as it becomes available.
        /// 
        ///  
        /// <para>
        /// This operation serves as a bidirectional counterpart to <c>SynthesizeSpeech</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/polly/latest/dg/API_SynthesizeSpeech.html">SynthesizeSpeech</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To use a custom voice, specify its ID in <c>VoiceId</c>. The voice must be in <c>active</c>
        /// status. If the voice is in <c>pending</c> or <c>failed</c> status, the request fails
        /// with <c>ConflictException</c>. If no custom voice with the specified ID exists in
        /// your account and Region, the request fails with <c>ResourceNotFoundException</c>.
        /// If the custom voice uses a customer managed key, you need <c>kms:Decrypt</c> permission
        /// on the key. If you disabled the key or scheduled it for deletion, the request fails
        /// with <c>ValidationException</c>. If you don't have permission to use the key, the
        /// request fails with <c>AccessDeniedException</c>. If Amazon Web Services KMS throttles
        /// Amazon Polly's request to use the key, the request fails with <c>ThrottlingException</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSpeechSynthesisStream service method.</param>
        /// <returns>The response from the StartSpeechSynthesisStream service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For a custom voice,
        /// the voice isn't in the status that the operation requires. Check the status with <c>GetVoice</c>,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ResourceNotFoundException">
        /// Amazon Polly can't find the specified resource. Verify that the resource exists in
        /// the Amazon Web Services account and Region of the request and that its ARN or ID is
        /// spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/StartSpeechSynthesisStream">REST API Reference for StartSpeechSynthesisStream Operation</seealso>
        StartSpeechSynthesisStreamResponse StartSpeechSynthesisStream(StartSpeechSynthesisStreamRequest request);
#endif

        /// <summary>
        /// Synthesizes UTF-8 input, plain text, or SSML over a bidirectional streaming connection.
        /// Specify synthesis parameters in HTTP/2 headers, send text incrementally as events
        /// on the input stream, and receive synthesized audio as it becomes available.
        /// 
        ///  
        /// <para>
        /// This operation serves as a bidirectional counterpart to <c>SynthesizeSpeech</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/polly/latest/dg/API_SynthesizeSpeech.html">SynthesizeSpeech</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To use a custom voice, specify its ID in <c>VoiceId</c>. The voice must be in <c>active</c>
        /// status. If the voice is in <c>pending</c> or <c>failed</c> status, the request fails
        /// with <c>ConflictException</c>. If no custom voice with the specified ID exists in
        /// your account and Region, the request fails with <c>ResourceNotFoundException</c>.
        /// If the custom voice uses a customer managed key, you need <c>kms:Decrypt</c> permission
        /// on the key. If you disabled the key or scheduled it for deletion, the request fails
        /// with <c>ValidationException</c>. If you don't have permission to use the key, the
        /// request fails with <c>AccessDeniedException</c>. If Amazon Web Services KMS throttles
        /// Amazon Polly's request to use the key, the request fails with <c>ThrottlingException</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSpeechSynthesisStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartSpeechSynthesisStream service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For a custom voice,
        /// the voice isn't in the status that the operation requires. Check the status with <c>GetVoice</c>,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ResourceNotFoundException">
        /// Amazon Polly can't find the specified resource. Verify that the resource exists in
        /// the Amazon Web Services account and Region of the request and that its ARN or ID is
        /// spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/StartSpeechSynthesisStream">REST API Reference for StartSpeechSynthesisStream Operation</seealso>
        Task<StartSpeechSynthesisStreamResponse> StartSpeechSynthesisStreamAsync(StartSpeechSynthesisStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));
#endif

#if NETFRAMEWORK
        /// <summary>
        /// Starts an asynchronous synthesis task by creating a new <c>SpeechSynthesisTask</c>.
        /// This operation requires all the standard information needed for speech synthesis,
        /// plus the name of an Amazon S3 bucket for the service to store the output of the synthesis
        /// task and two optional parameters (<c>OutputS3KeyPrefix</c> and <c>SnsTopicArn</c>).
        /// After Amazon Polly creates the synthesis task, the operation returns a <c>SpeechSynthesisTask</c>
        /// object that includes an identifier for the task and its current status. The <c>SpeechSynthesisTask</c>
        /// object is available for 72 hours after you start the asynchronous synthesis task.
        /// 
        ///  
        /// <para>
        /// To use a custom voice, specify its ID in <c>VoiceId</c>. The voice must be in <c>active</c>
        /// status. If the voice is in <c>pending</c> or <c>failed</c> status, the request fails
        /// with <c>ConflictException</c>. If no custom voice with the specified ID exists in
        /// your account and Region, the request fails with <c>ResourceNotFoundException</c>.
        /// If the custom voice uses a customer managed key, you need <c>kms:Decrypt</c> permission
        /// on the key. If you disable the key or schedule it for deletion before the task runs,
        /// the task fails and <c>TaskStatusReason</c> describes the cause.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSpeechSynthesisTask service method.</param>
        /// <returns>The response from the StartSpeechSynthesisTask service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For a custom voice,
        /// the voice isn't in the status that the operation requires. Check the status with <c>GetVoice</c>,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.EngineNotSupportedException">
        /// This engine is not compatible with the voice that you have designated. Choose a new
        /// voice that is compatible with the engine or change the engine and restart the operation.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidS3BucketException">
        /// The provided Amazon S3 bucket name is invalid. Please check your input with S3 bucket
        /// naming requirements and try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidS3KeyException">
        /// The provided Amazon S3 key prefix is invalid. Please provide a valid S3 object key
        /// name.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidSampleRateException">
        /// The specified sample rate is not valid.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidSnsTopicArnException">
        /// The provided SNS topic ARN is invalid. Please provide a valid SNS topic ARN and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidSsmlException">
        /// The SSML you provided is invalid. Verify the SSML syntax, spelling of tags and values,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.LanguageNotSupportedException">
        /// The language specified is not currently supported by Amazon Polly in this capacity.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.LexiconNotFoundException">
        /// Amazon Polly can't find the specified lexicon. This could be caused by a lexicon that
        /// is missing, its name is misspelled or specifying a lexicon that is in a different
        /// region.
        /// 
        ///  
        /// <para>
        /// Verify that the lexicon exists, is in the region (see <a>ListLexicons</a>) and that
        /// you spelled its name is spelled correctly. Then try again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.MarksNotSupportedForFormatException">
        /// Speech marks are not supported for the <c>OutputFormat</c> selected. Speech marks
        /// are only available for content in <c>json</c> format.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ResourceNotFoundException">
        /// Amazon Polly can't find the specified resource. Verify that the resource exists in
        /// the Amazon Web Services account and Region of the request and that its ARN or ID is
        /// spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.SsmlMarksNotSupportedForTextTypeException">
        /// SSML speech marks are not supported for plain text-type input.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.TextLengthExceededException">
        /// The value of the "Text" parameter is longer than the accepted limits. For the <c>SynthesizeSpeech</c>
        /// API, the limit for input text is a maximum of 6000 characters total, of which no more
        /// than 3000 can be billed characters. For the <c>StartSpeechSynthesisTask</c> API, the
        /// maximum is 200,000 characters, of which no more than 100,000 can be billed characters.
        /// SSML tags are not counted as billed characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/StartSpeechSynthesisTask">REST API Reference for StartSpeechSynthesisTask Operation</seealso>
        StartSpeechSynthesisTaskResponse StartSpeechSynthesisTask(StartSpeechSynthesisTaskRequest request);
#endif

        /// <summary>
        /// Starts an asynchronous synthesis task by creating a new <c>SpeechSynthesisTask</c>.
        /// This operation requires all the standard information needed for speech synthesis,
        /// plus the name of an Amazon S3 bucket for the service to store the output of the synthesis
        /// task and two optional parameters (<c>OutputS3KeyPrefix</c> and <c>SnsTopicArn</c>).
        /// After Amazon Polly creates the synthesis task, the operation returns a <c>SpeechSynthesisTask</c>
        /// object that includes an identifier for the task and its current status. The <c>SpeechSynthesisTask</c>
        /// object is available for 72 hours after you start the asynchronous synthesis task.
        /// 
        ///  
        /// <para>
        /// To use a custom voice, specify its ID in <c>VoiceId</c>. The voice must be in <c>active</c>
        /// status. If the voice is in <c>pending</c> or <c>failed</c> status, the request fails
        /// with <c>ConflictException</c>. If no custom voice with the specified ID exists in
        /// your account and Region, the request fails with <c>ResourceNotFoundException</c>.
        /// If the custom voice uses a customer managed key, you need <c>kms:Decrypt</c> permission
        /// on the key. If you disable the key or schedule it for deletion before the task runs,
        /// the task fails and <c>TaskStatusReason</c> describes the cause.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSpeechSynthesisTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartSpeechSynthesisTask service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For a custom voice,
        /// the voice isn't in the status that the operation requires. Check the status with <c>GetVoice</c>,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.EngineNotSupportedException">
        /// This engine is not compatible with the voice that you have designated. Choose a new
        /// voice that is compatible with the engine or change the engine and restart the operation.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidS3BucketException">
        /// The provided Amazon S3 bucket name is invalid. Please check your input with S3 bucket
        /// naming requirements and try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidS3KeyException">
        /// The provided Amazon S3 key prefix is invalid. Please provide a valid S3 object key
        /// name.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidSampleRateException">
        /// The specified sample rate is not valid.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidSnsTopicArnException">
        /// The provided SNS topic ARN is invalid. Please provide a valid SNS topic ARN and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidSsmlException">
        /// The SSML you provided is invalid. Verify the SSML syntax, spelling of tags and values,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.LanguageNotSupportedException">
        /// The language specified is not currently supported by Amazon Polly in this capacity.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.LexiconNotFoundException">
        /// Amazon Polly can't find the specified lexicon. This could be caused by a lexicon that
        /// is missing, its name is misspelled or specifying a lexicon that is in a different
        /// region.
        /// 
        ///  
        /// <para>
        /// Verify that the lexicon exists, is in the region (see <a>ListLexicons</a>) and that
        /// you spelled its name is spelled correctly. Then try again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.MarksNotSupportedForFormatException">
        /// Speech marks are not supported for the <c>OutputFormat</c> selected. Speech marks
        /// are only available for content in <c>json</c> format.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ResourceNotFoundException">
        /// Amazon Polly can't find the specified resource. Verify that the resource exists in
        /// the Amazon Web Services account and Region of the request and that its ARN or ID is
        /// spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.SsmlMarksNotSupportedForTextTypeException">
        /// SSML speech marks are not supported for plain text-type input.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.TextLengthExceededException">
        /// The value of the "Text" parameter is longer than the accepted limits. For the <c>SynthesizeSpeech</c>
        /// API, the limit for input text is a maximum of 6000 characters total, of which no more
        /// than 3000 can be billed characters. For the <c>StartSpeechSynthesisTask</c> API, the
        /// maximum is 200,000 characters, of which no more than 100,000 can be billed characters.
        /// SSML tags are not counted as billed characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/StartSpeechSynthesisTask">REST API Reference for StartSpeechSynthesisTask Operation</seealso>
        Task<StartSpeechSynthesisTaskResponse> StartSpeechSynthesisTaskAsync(StartSpeechSynthesisTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Synthesizes UTF-8 input, plain text or SSML, to a stream of bytes. SSML input must
        /// be valid, well-formed SSML. Some alphabets might not be available with all the voices
        /// (for example, Cyrillic might not be read at all by English voices) unless phoneme
        /// mapping is used. For more information, see <a href="https://docs.aws.amazon.com/polly/latest/dg/how-text-to-speech-works.html">How
        /// it Works</a>.
        /// 
        ///  
        /// <para>
        /// To use a custom voice, specify its ID in <c>VoiceId</c>. The voice must be in <c>active</c>
        /// status. If the voice is in <c>pending</c> or <c>failed</c> status, the request fails
        /// with <c>ConflictException</c>. If no custom voice with the specified ID exists in
        /// your account and Region, the request fails with <c>ResourceNotFoundException</c>.
        /// </para>
        ///  
        /// <para>
        /// If the custom voice uses a customer managed key, you need <c>kms:Decrypt</c> permission
        /// on the key. If you disabled the key or scheduled it for deletion, the request fails
        /// with <c>ValidationException</c>. If you don't have permission to use the key, the
        /// request fails with <c>AccessDeniedException</c>. If Amazon Web Services KMS throttles
        /// Amazon Polly's request to use the key, the request fails with <c>ThrottlingException</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SynthesizeSpeech service method.</param>
        /// <returns>The response from the SynthesizeSpeech service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For a custom voice,
        /// the voice isn't in the status that the operation requires. Check the status with <c>GetVoice</c>,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.EngineNotSupportedException">
        /// This engine is not compatible with the voice that you have designated. Choose a new
        /// voice that is compatible with the engine or change the engine and restart the operation.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidSampleRateException">
        /// The specified sample rate is not valid.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidSsmlException">
        /// The SSML you provided is invalid. Verify the SSML syntax, spelling of tags and values,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.LanguageNotSupportedException">
        /// The language specified is not currently supported by Amazon Polly in this capacity.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.LexiconNotFoundException">
        /// Amazon Polly can't find the specified lexicon. This could be caused by a lexicon that
        /// is missing, its name is misspelled or specifying a lexicon that is in a different
        /// region.
        /// 
        ///  
        /// <para>
        /// Verify that the lexicon exists, is in the region (see <a>ListLexicons</a>) and that
        /// you spelled its name is spelled correctly. Then try again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.MarksNotSupportedForFormatException">
        /// Speech marks are not supported for the <c>OutputFormat</c> selected. Speech marks
        /// are only available for content in <c>json</c> format.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ResourceNotFoundException">
        /// Amazon Polly can't find the specified resource. Verify that the resource exists in
        /// the Amazon Web Services account and Region of the request and that its ARN or ID is
        /// spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.SsmlMarksNotSupportedForTextTypeException">
        /// SSML speech marks are not supported for plain text-type input.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.TextLengthExceededException">
        /// The value of the "Text" parameter is longer than the accepted limits. For the <c>SynthesizeSpeech</c>
        /// API, the limit for input text is a maximum of 6000 characters total, of which no more
        /// than 3000 can be billed characters. For the <c>StartSpeechSynthesisTask</c> API, the
        /// maximum is 200,000 characters, of which no more than 100,000 can be billed characters.
        /// SSML tags are not counted as billed characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/SynthesizeSpeech">REST API Reference for SynthesizeSpeech Operation</seealso>
        SynthesizeSpeechResponse SynthesizeSpeech(SynthesizeSpeechRequest request);
#endif

        /// <summary>
        /// Synthesizes UTF-8 input, plain text or SSML, to a stream of bytes. SSML input must
        /// be valid, well-formed SSML. Some alphabets might not be available with all the voices
        /// (for example, Cyrillic might not be read at all by English voices) unless phoneme
        /// mapping is used. For more information, see <a href="https://docs.aws.amazon.com/polly/latest/dg/how-text-to-speech-works.html">How
        /// it Works</a>.
        /// 
        ///  
        /// <para>
        /// To use a custom voice, specify its ID in <c>VoiceId</c>. The voice must be in <c>active</c>
        /// status. If the voice is in <c>pending</c> or <c>failed</c> status, the request fails
        /// with <c>ConflictException</c>. If no custom voice with the specified ID exists in
        /// your account and Region, the request fails with <c>ResourceNotFoundException</c>.
        /// </para>
        ///  
        /// <para>
        /// If the custom voice uses a customer managed key, you need <c>kms:Decrypt</c> permission
        /// on the key. If you disabled the key or scheduled it for deletion, the request fails
        /// with <c>ValidationException</c>. If you don't have permission to use the key, the
        /// request fails with <c>AccessDeniedException</c>. If Amazon Web Services KMS throttles
        /// Amazon Polly's request to use the key, the request fails with <c>ThrottlingException</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SynthesizeSpeech service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SynthesizeSpeech service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.ConflictException">
        /// The request conflicts with the current state of the resource. For a custom voice,
        /// the voice isn't in the status that the operation requires. Check the status with <c>GetVoice</c>,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.EngineNotSupportedException">
        /// This engine is not compatible with the voice that you have designated. Choose a new
        /// voice that is compatible with the engine or change the engine and restart the operation.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidSampleRateException">
        /// The specified sample rate is not valid.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidSsmlException">
        /// The SSML you provided is invalid. Verify the SSML syntax, spelling of tags and values,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.LanguageNotSupportedException">
        /// The language specified is not currently supported by Amazon Polly in this capacity.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.LexiconNotFoundException">
        /// Amazon Polly can't find the specified lexicon. This could be caused by a lexicon that
        /// is missing, its name is misspelled or specifying a lexicon that is in a different
        /// region.
        /// 
        ///  
        /// <para>
        /// Verify that the lexicon exists, is in the region (see <a>ListLexicons</a>) and that
        /// you spelled its name is spelled correctly. Then try again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.MarksNotSupportedForFormatException">
        /// Speech marks are not supported for the <c>OutputFormat</c> selected. Speech marks
        /// are only available for content in <c>json</c> format.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ResourceNotFoundException">
        /// Amazon Polly can't find the specified resource. Verify that the resource exists in
        /// the Amazon Web Services account and Region of the request and that its ARN or ID is
        /// spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.SsmlMarksNotSupportedForTextTypeException">
        /// SSML speech marks are not supported for plain text-type input.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.TextLengthExceededException">
        /// The value of the "Text" parameter is longer than the accepted limits. For the <c>SynthesizeSpeech</c>
        /// API, the limit for input text is a maximum of 6000 characters total, of which no more
        /// than 3000 can be billed characters. For the <c>StartSpeechSynthesisTask</c> API, the
        /// maximum is 200,000 characters, of which no more than 100,000 can be billed characters.
        /// SSML tags are not counted as billed characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/SynthesizeSpeech">REST API Reference for SynthesizeSpeech Operation</seealso>
        Task<SynthesizeSpeechResponse> SynthesizeSpeechAsync(SynthesizeSpeechRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Adds specified tags to a resource with the specified ARN. Existing tags on a resource
        /// are not changed if they are not specified in the request parameters. If you specify
        /// a tag key that already exists on the resource, the value in the request replaces the
        /// existing value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidTagParameterException">
        /// The resource ARN or a tag in the request isn't valid. Specify the ARN of a supported
        /// resource in the Amazon Web Services account and Region of the request. Tag keys can
        /// have a maximum length of 128 characters, and tag values can have a maximum length
        /// of 256 characters. Correct the ARN or the tags, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ResourceNotFoundException">
        /// Amazon Polly can't find the specified resource. Verify that the resource exists in
        /// the Amazon Web Services account and Region of the request and that its ARN or ID is
        /// spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.TooManyTagsException">
        /// The list of tags on the resource is over the limit. The maximum number of tags that
        /// can be applied to a resource is 50. Remove unused tags or reduce the number of tags
        /// in the request, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);
#endif

        /// <summary>
        /// Adds specified tags to a resource with the specified ARN. Existing tags on a resource
        /// are not changed if they are not specified in the request parameters. If you specify
        /// a tag key that already exists on the resource, the value in the request replaces the
        /// existing value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidTagParameterException">
        /// The resource ARN or a tag in the request isn't valid. Specify the ARN of a supported
        /// resource in the Amazon Web Services account and Region of the request. Tag keys can
        /// have a maximum length of 128 characters, and tag values can have a maximum length
        /// of 256 characters. Correct the ARN or the tags, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ResourceNotFoundException">
        /// Amazon Polly can't find the specified resource. Verify that the resource exists in
        /// the Amazon Web Services account and Region of the request and that its ARN or ID is
        /// spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.TooManyTagsException">
        /// The list of tags on the resource is over the limit. The maximum number of tags that
        /// can be applied to a resource is 50. Remove unused tags or reduce the number of tags
        /// in the request, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidTagParameterException">
        /// The resource ARN or a tag in the request isn't valid. Specify the ARN of a supported
        /// resource in the Amazon Web Services account and Region of the request. Tag keys can
        /// have a maximum length of 128 characters, and tag values can have a maximum length
        /// of 256 characters. Correct the ARN or the tags, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ResourceNotFoundException">
        /// Amazon Polly can't find the specified resource. Verify that the resource exists in
        /// the Amazon Web Services account and Region of the request and that its ARN or ID is
        /// spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);
#endif

        /// <summary>
        /// Deletes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidTagParameterException">
        /// The resource ARN or a tag in the request isn't valid. Specify the ARN of a supported
        /// resource in the Amazon Web Services account and Region of the request. Tag keys can
        /// have a maximum length of 128 characters, and tag values can have a maximum length
        /// of 256 characters. Correct the ARN or the tags, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ResourceNotFoundException">
        /// Amazon Polly can't find the specified resource. Verify that the resource exists in
        /// the Amazon Web Services account and Region of the request and that its ARN or ID is
        /// spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ThrottlingException">
        /// The request was denied because of request throttling.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);

#if NET8_0_OR_GREATER
        // Warning CA1033 is issued when the child types can not call the method defined in parent types.
        // In this use case the intended caller is only meant to be the interface as a factory
        // method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonPollyConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonPollyConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonPollyConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonPollyConfig to create AmazonPollyClient");
            }

            return awsCredentials == null ?
                    new AmazonPollyClient(serviceClientConfig) :
                    new AmazonPollyClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
