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
 * Do not modify this file. This file is generated from the polly-2016-06-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Polly.Model;

namespace Amazon.Polly
{
    /// <summary>
    /// Interface for accessing Polly
    ///
    /// Amazon Polly is a web service that makes it easy to synthesize speech from text.
    /// 
    ///  
    /// <para>
    /// The Amazon Polly service provides API operations for synthesizing high-quality speech
    /// from plain text and Speech Synthesis Markup Language (SSML), along with managing pronunciations
    /// lexicons that enable you to get the best results for your application domain.
    /// </para>
    /// </summary>
    public partial interface IAmazonPolly : IAmazonService, IDisposable
    {

        
        #region  DeleteLexicon


        /// <summary>
        /// Deletes the specified pronunciation lexicon stored in an AWS Region. A lexicon which
        /// has been deleted is not available for speech synthesis, nor is it possible to retrieve
        /// it using either the <code>GetLexicon</code> or <code>ListLexicon</code> APIs.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
        /// Lexicons</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLexicon service method.</param>
        /// 
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


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLexicon operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLexicon operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/DeleteLexicon">REST API Reference for DeleteLexicon Operation</seealso>
        Task<DeleteLexiconResponse> DeleteLexiconAsync(DeleteLexiconRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeVoices


        /// <summary>
        /// Returns the list of voices that are available for use when requesting speech synthesis.
        /// Each voice speaks a specified language, is either male or female, and is identified
        /// by an ID, which is the ASCII version of the voice name. 
        /// 
        ///  
        /// <para>
        /// When synthesizing speech ( <code>SynthesizeSpeech</code> ), you provide the voice
        /// ID for the voice you want from the list of voices returned by <code>DescribeVoices</code>.
        /// </para>
        ///  
        /// <para>
        /// For example, you want your news reader application to read news in a specific language,
        /// but giving a user the option to choose the voice. Using the <code>DescribeVoices</code>
        /// operation you can provide the user with a list of available voices to select from.
        /// </para>
        ///  
        /// <para>
        ///  You can optionally specify a language code to filter the available voices. For example,
        /// if you specify <code>en-US</code>, the operation returns a list of all available US
        /// English voices. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>polly:DescribeVoices</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVoices service method.</param>
        /// 
        /// <returns>The response from the DescribeVoices service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidNextTokenException">
        /// The NextToken is invalid. Verify that it's spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/DescribeVoices">REST API Reference for DescribeVoices Operation</seealso>
        DescribeVoicesResponse DescribeVoices(DescribeVoicesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVoices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVoices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/DescribeVoices">REST API Reference for DescribeVoices Operation</seealso>
        Task<DescribeVoicesResponse> DescribeVoicesAsync(DescribeVoicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLexicon


        /// <summary>
        /// Returns the content of the specified pronunciation lexicon stored in an AWS Region.
        /// For more information, see <a href="http://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
        /// Lexicons</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLexicon service method.</param>
        /// 
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


        /// <summary>
        /// Initiates the asynchronous execution of the GetLexicon operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLexicon operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/GetLexicon">REST API Reference for GetLexicon Operation</seealso>
        Task<GetLexiconResponse> GetLexiconAsync(GetLexiconRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLexicons


        /// <summary>
        /// Returns a list of pronunciation lexicons stored in an AWS Region. For more information,
        /// see <a href="http://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
        /// Lexicons</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLexicons service method.</param>
        /// 
        /// <returns>The response from the ListLexicons service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidNextTokenException">
        /// The NextToken is invalid. Verify that it's spelled correctly, and then try again.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/ListLexicons">REST API Reference for ListLexicons Operation</seealso>
        ListLexiconsResponse ListLexicons(ListLexiconsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListLexicons operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLexicons operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/ListLexicons">REST API Reference for ListLexicons Operation</seealso>
        Task<ListLexiconsResponse> ListLexiconsAsync(ListLexiconsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutLexicon


        /// <summary>
        /// Stores a pronunciation lexicon in an AWS Region. If a lexicon with the same name already
        /// exists in the region, it is overwritten by the new lexicon. Lexicon operations have
        /// eventual consistency, therefore, it might take some time before the lexicon is available
        /// to the SynthesizeSpeech operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/polly/latest/dg/managing-lexicons.html">Managing
        /// Lexicons</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLexicon service method.</param>
        /// 
        /// <returns>The response from the PutLexicon service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidLexiconException">
        /// Amazon Polly can't find the specified lexicon. Verify that the lexicon's name is spelled
        /// correctly, and then try again.
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
        /// <exception cref="Amazon.Polly.Model.UnsupportedPlsAlphabetException">
        /// The alphabet specified by the lexicon is not a supported alphabet. Valid values are
        /// <code>x-sampa</code> and <code>ipa</code>.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.UnsupportedPlsLanguageException">
        /// The language specified in the lexicon is unsupported. For a list of supported languages,
        /// see <a href="http://docs.aws.amazon.com/polly/latest/dg/API_LexiconAttributes.html">Lexicon
        /// Attributes</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/PutLexicon">REST API Reference for PutLexicon Operation</seealso>
        PutLexiconResponse PutLexicon(PutLexiconRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutLexicon operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLexicon operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/PutLexicon">REST API Reference for PutLexicon Operation</seealso>
        Task<PutLexiconResponse> PutLexiconAsync(PutLexiconRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SynthesizeSpeech


        /// <summary>
        /// Synthesizes UTF-8 input, plain text or SSML, to a stream of bytes. SSML input must
        /// be valid, well-formed SSML. Some alphabets might not be available with all the voices
        /// (for example, Cyrillic might not be read at all by English voices) unless phoneme
        /// mapping is used. For more information, see <a href="http://docs.aws.amazon.com/polly/latest/dg/how-text-to-speech-works.html">How
        /// it Works</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SynthesizeSpeech service method.</param>
        /// 
        /// <returns>The response from the SynthesizeSpeech service method, as returned by Polly.</returns>
        /// <exception cref="Amazon.Polly.Model.InvalidSampleRateException">
        /// The specified sample rate is not valid.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.InvalidSsmlException">
        /// The SSML you provided is invalid. Verify the SSML syntax, spelling of tags and values,
        /// and then try again.
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
        /// Speech marks are not supported for the <code>OutputFormat</code> selected. Speech
        /// marks are only available for content in <code>json</code> format.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.ServiceFailureException">
        /// An unknown condition has caused a service failure.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.SsmlMarksNotSupportedForTextTypeException">
        /// SSML speech marks are not supported for plain text-type input.
        /// </exception>
        /// <exception cref="Amazon.Polly.Model.TextLengthExceededException">
        /// The value of the "Text" parameter is longer than the accepted limits. The limit for
        /// input text is a maximum of 6000 characters total, of which no more than 3000 can be
        /// billed characters. SSML tags are not counted as billed characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/SynthesizeSpeech">REST API Reference for SynthesizeSpeech Operation</seealso>
        SynthesizeSpeechResponse SynthesizeSpeech(SynthesizeSpeechRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SynthesizeSpeech operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SynthesizeSpeech operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/polly-2016-06-10/SynthesizeSpeech">REST API Reference for SynthesizeSpeech Operation</seealso>
        Task<SynthesizeSpeechResponse> SynthesizeSpeechAsync(SynthesizeSpeechRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}