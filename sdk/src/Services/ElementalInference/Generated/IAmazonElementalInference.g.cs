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
using Amazon.ElementalInference.Model;

#pragma warning disable CS1570

namespace Amazon.ElementalInference
{
    /// <summary>
    /// <para>Interface for accessing ElementalInference</para>
    ///
    /// This is the AWS Elemental Inference REST API Reference. It provides information on
    /// the URL, request contents, and response contents of each AWS Elemental Inference REST
    /// operation. 
    /// 
    ///  
    /// <para>
    /// We assume that you have the IAM permissions that you need to use AWS Elemental Inference
    /// via the REST API. We also assume that you are familiar with the features and operations
    /// of AWS Elemental Inference as described in <i>AWS Elemental Inference User Guide</i>.
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonElementalInference : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IElementalInferencePaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Associates a resource with the feed. The resource provides the input that Elemental
        /// Inference needs in order to perform an Elemental Inference feature, such as cropping
        /// video. You always provide the resource by associating it with a feed. You can associate
        /// only one resource with each feed. With an association, a specific source media is
        /// claiming ownership of the feed. 
        /// 
        ///  
        /// <para>
        /// AssociateFeed is a PATCH operation, which means that you can include only parameters
        /// that you want to change. Parameters that you don't include will not be affected by
        /// the operation. 
        /// </para>
        ///  
        /// <para>
        /// Specifically:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can add more outputs to the existing outputs. New outputs will be appended.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't modify an existing output (for example to change its name). Instead, use
        /// UpdateFeed. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't delete an existing output. Instead, use UpdateFeed.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Also note that you can't change the feed name with AssociateFeed. Instead, use UpdateFeed.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateFeed service method.</param>
        /// <returns>The response from the AssociateFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/AssociateFeed">REST API Reference for AssociateFeed Operation</seealso>
        AssociateFeedResponse AssociateFeed(AssociateFeedRequest request);
#endif

        /// <summary>
        /// Associates a resource with the feed. The resource provides the input that Elemental
        /// Inference needs in order to perform an Elemental Inference feature, such as cropping
        /// video. You always provide the resource by associating it with a feed. You can associate
        /// only one resource with each feed. With an association, a specific source media is
        /// claiming ownership of the feed. 
        /// 
        ///  
        /// <para>
        /// AssociateFeed is a PATCH operation, which means that you can include only parameters
        /// that you want to change. Parameters that you don't include will not be affected by
        /// the operation. 
        /// </para>
        ///  
        /// <para>
        /// Specifically:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can add more outputs to the existing outputs. New outputs will be appended.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't modify an existing output (for example to change its name). Instead, use
        /// UpdateFeed. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't delete an existing output. Instead, use UpdateFeed.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Also note that you can't change the feed name with AssociateFeed. Instead, use UpdateFeed.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateFeed service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AssociateFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/AssociateFeed">REST API Reference for AssociateFeed Operation</seealso>
        Task<AssociateFeedResponse> AssociateFeedAsync(AssociateFeedRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a custom dictionary for improving transcription accuracy. A dictionary contains
        /// custom words and phrases that the ASR engine might not recognize, such as brand names,
        /// technical terms, or proper nouns. You can reference a dictionary when configuring
        /// a smart subtitles output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDictionary service method.</param>
        /// <returns>The response from the CreateDictionary service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/CreateDictionary">REST API Reference for CreateDictionary Operation</seealso>
        CreateDictionaryResponse CreateDictionary(CreateDictionaryRequest request);
#endif

        /// <summary>
        /// Creates a custom dictionary for improving transcription accuracy. A dictionary contains
        /// custom words and phrases that the ASR engine might not recognize, such as brand names,
        /// technical terms, or proper nouns. You can reference a dictionary when configuring
        /// a smart subtitles output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDictionary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateDictionary service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/CreateDictionary">REST API Reference for CreateDictionary Operation</seealso>
        Task<CreateDictionaryResponse> CreateDictionaryAsync(CreateDictionaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a feed. The feed is the target for the live media stream that is being sent
        /// by the calling application. An example of a calling application is AWS Elemental MediaLive.
        /// 
        /// 
        ///  
        /// <para>
        /// The key contents of the feed is an array of outputs. Each output represents an Elemental
        /// Inference feature. After you create the feed, you must associate a resource with the
        /// feed. At that point, you will have a useable feed: resource - feed - output or outputs.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFeed service method.</param>
        /// <returns>The response from the CreateFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/CreateFeed">REST API Reference for CreateFeed Operation</seealso>
        CreateFeedResponse CreateFeed(CreateFeedRequest request);
#endif

        /// <summary>
        /// Creates a feed. The feed is the target for the live media stream that is being sent
        /// by the calling application. An example of a calling application is AWS Elemental MediaLive.
        /// 
        /// 
        ///  
        /// <para>
        /// The key contents of the feed is an array of outputs. Each output represents an Elemental
        /// Inference feature. After you create the feed, you must associate a resource with the
        /// feed. At that point, you will have a useable feed: resource - feed - output or outputs.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFeed service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/CreateFeed">REST API Reference for CreateFeed Operation</seealso>
        Task<CreateFeedResponse> CreateFeedAsync(CreateFeedRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a function. A function analyzes a feed by building a request from the feed's
        /// media and metadata, optionally sending that request to an Amazon Bedrock model in
        /// your account, and publishing the result to the feed's metadata timeline. 
        /// 
        ///  
        /// <para>
        /// A function runs only after you attach it to a feed as a function output. For more
        /// information, see <a href="https://docs.aws.amazon.com/elemental-inference/latest/userguide/functions.html">Using
        /// functions</a> in the <i>AWS Elemental Inference User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFunction service method.</param>
        /// <returns>The response from the CreateFunction service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        CreateFunctionResponse CreateFunction(CreateFunctionRequest request);
#endif

        /// <summary>
        /// Creates a function. A function analyzes a feed by building a request from the feed's
        /// media and metadata, optionally sending that request to an Amazon Bedrock model in
        /// your account, and publishing the result to the feed's metadata timeline. 
        /// 
        ///  
        /// <para>
        /// A function runs only after you attach it to a feed as a function output. For more
        /// information, see <a href="https://docs.aws.amazon.com/elemental-inference/latest/userguide/functions.html">Using
        /// functions</a> in the <i>AWS Elemental Inference User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateFunction service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/CreateFunction">REST API Reference for CreateFunction Operation</seealso>
        Task<CreateFunctionResponse> CreateFunctionAsync(CreateFunctionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a question set. Use a question set to get answers about content that's specific
        /// to your business, in addition to the built-in contextual metadata classifications.
        /// A question set contains your own questions. You ask Elemental Inference these questions
        /// about each shot or scene of the media in a contextual metadata output, and Elemental
        /// Inference answers each question with scores. To use a question set, reference it in
        /// the customQuestions property of the contextual metadata configuration of a feed output.
        /// 
        /// 
        ///  
        /// <para>
        /// CreateQuestionSet creates the question set with a DRAFT version that contains the
        /// questions in the request. To change DRAFT, use UpdateQuestionSet. To publish DRAFT
        /// as a numbered version, use CreateQuestionSetVersion. You can't change a published
        /// version. 
        /// </para>
        ///  
        /// <para>
        /// A question set can contain the following types of questions. You must specify at least
        /// one question. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// yesNo – Elemental Inference answers yes or no.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// yesNoPerOption – Elemental Inference answers yes or no for each option.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// chooseOne – Elemental Inference chooses one of the options.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A version can contain up to 100 scored items, where each yesNo question, each option
        /// of a yesNoPerOption question, and each chooseOne question counts as one item. The
        /// name of each question must be unique across all three types. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQuestionSet service method.</param>
        /// <returns>The response from the CreateQuestionSet service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/CreateQuestionSet">REST API Reference for CreateQuestionSet Operation</seealso>
        CreateQuestionSetResponse CreateQuestionSet(CreateQuestionSetRequest request);
#endif

        /// <summary>
        /// Creates a question set. Use a question set to get answers about content that's specific
        /// to your business, in addition to the built-in contextual metadata classifications.
        /// A question set contains your own questions. You ask Elemental Inference these questions
        /// about each shot or scene of the media in a contextual metadata output, and Elemental
        /// Inference answers each question with scores. To use a question set, reference it in
        /// the customQuestions property of the contextual metadata configuration of a feed output.
        /// 
        /// 
        ///  
        /// <para>
        /// CreateQuestionSet creates the question set with a DRAFT version that contains the
        /// questions in the request. To change DRAFT, use UpdateQuestionSet. To publish DRAFT
        /// as a numbered version, use CreateQuestionSetVersion. You can't change a published
        /// version. 
        /// </para>
        ///  
        /// <para>
        /// A question set can contain the following types of questions. You must specify at least
        /// one question. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// yesNo – Elemental Inference answers yes or no.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// yesNoPerOption – Elemental Inference answers yes or no for each option.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// chooseOne – Elemental Inference chooses one of the options.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A version can contain up to 100 scored items, where each yesNo question, each option
        /// of a yesNoPerOption question, and each chooseOne question counts as one item. The
        /// name of each question must be unique across all three types. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQuestionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateQuestionSet service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/CreateQuestionSet">REST API Reference for CreateQuestionSet Operation</seealso>
        Task<CreateQuestionSetResponse> CreateQuestionSetAsync(CreateQuestionSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Publishes the DRAFT version of the specified question set as a new version. The new
        /// version has the same name and questions as DRAFT, and you can't change it. DRAFT doesn't
        /// change, so you can continue to update it. 
        /// 
        ///  
        /// <para>
        /// Version numbers start at 1, and each new version has the next number. Elemental Inference
        /// never reuses a version number, even after you delete that version. 
        /// </para>
        ///  
        /// <para>
        /// If DRAFT hasn't changed since the latest published version, Elemental Inference doesn't
        /// create a version. Instead, it returns the latest version. A change to the name of
        /// the question set counts as a change to DRAFT. 
        /// </para>
        ///  
        /// <para>
        /// A question set can have a limited number of versions. If the question set already
        /// has the maximum number of versions, Elemental Inference returns ServiceQuotaExceededException.
        /// To free space for a new version, delete a version that you no longer need, or create
        /// a new question set. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQuestionSetVersion service method.</param>
        /// <returns>The response from the CreateQuestionSetVersion service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/CreateQuestionSetVersion">REST API Reference for CreateQuestionSetVersion Operation</seealso>
        CreateQuestionSetVersionResponse CreateQuestionSetVersion(CreateQuestionSetVersionRequest request);
#endif

        /// <summary>
        /// Publishes the DRAFT version of the specified question set as a new version. The new
        /// version has the same name and questions as DRAFT, and you can't change it. DRAFT doesn't
        /// change, so you can continue to update it. 
        /// 
        ///  
        /// <para>
        /// Version numbers start at 1, and each new version has the next number. Elemental Inference
        /// never reuses a version number, even after you delete that version. 
        /// </para>
        ///  
        /// <para>
        /// If DRAFT hasn't changed since the latest published version, Elemental Inference doesn't
        /// create a version. Instead, it returns the latest version. A change to the name of
        /// the question set counts as a change to DRAFT. 
        /// </para>
        ///  
        /// <para>
        /// A question set can have a limited number of versions. If the question set already
        /// has the maximum number of versions, Elemental Inference returns ServiceQuotaExceededException.
        /// To free space for a new version, delete a version that you no longer need, or create
        /// a new question set. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQuestionSetVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateQuestionSetVersion service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/CreateQuestionSetVersion">REST API Reference for CreateQuestionSetVersion Operation</seealso>
        Task<CreateQuestionSetVersionResponse> CreateQuestionSetVersionAsync(CreateQuestionSetVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a schedule action on a feed. A schedule action applies configuration changes
        /// to the feed at a time that you specify, in the same way as an UpdateFeed request.
        /// 
        /// 
        ///  
        /// <para>
        /// Elemental Inference validates the targets of the action when you create it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduleAction service method.</param>
        /// <returns>The response from the CreateScheduleAction service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/CreateScheduleAction">REST API Reference for CreateScheduleAction Operation</seealso>
        CreateScheduleActionResponse CreateScheduleAction(CreateScheduleActionRequest request);
#endif

        /// <summary>
        /// Creates a schedule action on a feed. A schedule action applies configuration changes
        /// to the feed at a time that you specify, in the same way as an UpdateFeed request.
        /// 
        /// 
        ///  
        /// <para>
        /// Elemental Inference validates the targets of the action when you create it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduleAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateScheduleAction service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/CreateScheduleAction">REST API Reference for CreateScheduleAction Operation</seealso>
        Task<CreateScheduleActionResponse> CreateScheduleActionAsync(CreateScheduleActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the specified dictionary. You cannot delete a dictionary that is referenced
        /// by a feed. You must first remove the dictionary reference from the feed's subtitling
        /// configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDictionary service method.</param>
        /// <returns>The response from the DeleteDictionary service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DeleteDictionary">REST API Reference for DeleteDictionary Operation</seealso>
        DeleteDictionaryResponse DeleteDictionary(DeleteDictionaryRequest request);
#endif

        /// <summary>
        /// Deletes the specified dictionary. You cannot delete a dictionary that is referenced
        /// by a feed. You must first remove the dictionary reference from the feed's subtitling
        /// configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDictionary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteDictionary service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DeleteDictionary">REST API Reference for DeleteDictionary Operation</seealso>
        Task<DeleteDictionaryResponse> DeleteDictionaryAsync(DeleteDictionaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the specified feed. You can delete the feed at any time. Elemental Inference
        /// doesn't block you from deleting a feed when the calling application is calling PutMedia
        /// or GetMetadata on that feed, although both these calls will start to fail. For more
        /// information about managing inactive feeds, see the Elemental Inference User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFeed service method.</param>
        /// <returns>The response from the DeleteFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DeleteFeed">REST API Reference for DeleteFeed Operation</seealso>
        DeleteFeedResponse DeleteFeed(DeleteFeedRequest request);
#endif

        /// <summary>
        /// Deletes the specified feed. You can delete the feed at any time. Elemental Inference
        /// doesn't block you from deleting a feed when the calling application is calling PutMedia
        /// or GetMetadata on that feed, although both these calls will start to fail. For more
        /// information about managing inactive feeds, see the Elemental Inference User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFeed service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DeleteFeed">REST API Reference for DeleteFeed Operation</seealso>
        Task<DeleteFeedResponse> DeleteFeedAsync(DeleteFeedRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the resource-based policy attached to the specified feed. After you delete
        /// the policy, the operation revokes the cross-account access that the policy granted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFeedPolicy service method.</param>
        /// <returns>The response from the DeleteFeedPolicy service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DeleteFeedPolicy">REST API Reference for DeleteFeedPolicy Operation</seealso>
        DeleteFeedPolicyResponse DeleteFeedPolicy(DeleteFeedPolicyRequest request);
#endif

        /// <summary>
        /// Deletes the resource-based policy attached to the specified feed. After you delete
        /// the policy, the operation revokes the cross-account access that the policy granted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFeedPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteFeedPolicy service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DeleteFeedPolicy">REST API Reference for DeleteFeedPolicy Operation</seealso>
        Task<DeleteFeedPolicyResponse> DeleteFeedPolicyAsync(DeleteFeedPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a function. If any feed still references the function, the operation returns
        /// a ConflictException. A disabled function output still references the function. Use
        /// GetFunction to find those feeds, then remove the function output from each one with
        /// UpdateFeed, or delete the feed, before retrying. 
        /// 
        ///  
        /// <para>
        /// Deleting a function doesn't delete the metadata that it has already produced.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction service method.</param>
        /// <returns>The response from the DeleteFunction service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        DeleteFunctionResponse DeleteFunction(DeleteFunctionRequest request);
#endif

        /// <summary>
        /// Deletes a function. If any feed still references the function, the operation returns
        /// a ConflictException. A disabled function output still references the function. Use
        /// GetFunction to find those feeds, then remove the function output from each one with
        /// UpdateFeed, or delete the feed, before retrying. 
        /// 
        ///  
        /// <para>
        /// Deleting a function doesn't delete the metadata that it has already produced.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteFunction service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DeleteFunction">REST API Reference for DeleteFunction Operation</seealso>
        Task<DeleteFunctionResponse> DeleteFunctionAsync(DeleteFunctionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the specified question set, including its DRAFT version and all its published
        /// versions. You can't delete a question set while any feed references any of its versions,
        /// including an archived feed. You must first remove the question set from the customQuestions
        /// configuration of each feed output that references it, or delete those feeds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQuestionSet service method.</param>
        /// <returns>The response from the DeleteQuestionSet service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DeleteQuestionSet">REST API Reference for DeleteQuestionSet Operation</seealso>
        DeleteQuestionSetResponse DeleteQuestionSet(DeleteQuestionSetRequest request);
#endif

        /// <summary>
        /// Deletes the specified question set, including its DRAFT version and all its published
        /// versions. You can't delete a question set while any feed references any of its versions,
        /// including an archived feed. You must first remove the question set from the customQuestions
        /// configuration of each feed output that references it, or delete those feeds.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQuestionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteQuestionSet service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DeleteQuestionSet">REST API Reference for DeleteQuestionSet Operation</seealso>
        Task<DeleteQuestionSetResponse> DeleteQuestionSetAsync(DeleteQuestionSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a published version of the specified question set. You can't delete a version
        /// while a feed references it, including an archived feed. You can't restore a deleted
        /// version, and Elemental Inference doesn't reuse its number. 
        /// 
        ///  
        /// <para>
        /// You can't delete the DRAFT version on its own. To delete DRAFT, delete the question
        /// set by using DeleteQuestionSet. 
        /// </para>
        ///  
        /// <para>
        /// Deleting a version doesn't change the latestVersion of the question set, even if you
        /// delete the highest version. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQuestionSetVersion service method.</param>
        /// <returns>The response from the DeleteQuestionSetVersion service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DeleteQuestionSetVersion">REST API Reference for DeleteQuestionSetVersion Operation</seealso>
        DeleteQuestionSetVersionResponse DeleteQuestionSetVersion(DeleteQuestionSetVersionRequest request);
#endif

        /// <summary>
        /// Deletes a published version of the specified question set. You can't delete a version
        /// while a feed references it, including an archived feed. You can't restore a deleted
        /// version, and Elemental Inference doesn't reuse its number. 
        /// 
        ///  
        /// <para>
        /// You can't delete the DRAFT version on its own. To delete DRAFT, delete the question
        /// set by using DeleteQuestionSet. 
        /// </para>
        ///  
        /// <para>
        /// Deleting a version doesn't change the latestVersion of the question set, even if you
        /// delete the highest version. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQuestionSetVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteQuestionSetVersion service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DeleteQuestionSetVersion">REST API Reference for DeleteQuestionSetVersion Operation</seealso>
        Task<DeleteQuestionSetVersionResponse> DeleteQuestionSetVersionAsync(DeleteQuestionSetVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a schedule action from a feed. A deleted action never runs.
        /// 
        ///  
        /// <para>
        /// You can delete only an action whose status is PENDING. Deleting an action doesn't
        /// reverse changes that the action already made to the feed. When you delete or archive
        /// a feed, Elemental Inference deletes all the schedule actions on that feed. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduleAction service method.</param>
        /// <returns>The response from the DeleteScheduleAction service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DeleteScheduleAction">REST API Reference for DeleteScheduleAction Operation</seealso>
        DeleteScheduleActionResponse DeleteScheduleAction(DeleteScheduleActionRequest request);
#endif

        /// <summary>
        /// Deletes a schedule action from a feed. A deleted action never runs.
        /// 
        ///  
        /// <para>
        /// You can delete only an action whose status is PENDING. Deleting an action doesn't
        /// reverse changes that the action already made to the feed. When you delete or archive
        /// a feed, Elemental Inference deletes all the schedule actions on that feed. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduleAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteScheduleAction service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DeleteScheduleAction">REST API Reference for DeleteScheduleAction Operation</seealso>
        Task<DeleteScheduleActionResponse> DeleteScheduleActionAsync(DeleteScheduleActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Releases the resource (the source media) that is associated with this feed. The outputs
        /// in the feed become DISABLED.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFeed service method.</param>
        /// <returns>The response from the DisassociateFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DisassociateFeed">REST API Reference for DisassociateFeed Operation</seealso>
        DisassociateFeedResponse DisassociateFeed(DisassociateFeedRequest request);
#endif

        /// <summary>
        /// Releases the resource (the source media) that is associated with this feed. The outputs
        /// in the feed become DISABLED.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFeed service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisassociateFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DisassociateFeed">REST API Reference for DisassociateFeed Operation</seealso>
        Task<DisassociateFeedResponse> DisassociateFeedAsync(DisassociateFeedRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Exports the entries from the specified dictionary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportDictionaryEntries service method.</param>
        /// <returns>The response from the ExportDictionaryEntries service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ExportDictionaryEntries">REST API Reference for ExportDictionaryEntries Operation</seealso>
        ExportDictionaryEntriesResponse ExportDictionaryEntries(ExportDictionaryEntriesRequest request);
#endif

        /// <summary>
        /// Exports the entries from the specified dictionary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportDictionaryEntries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ExportDictionaryEntries service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ExportDictionaryEntries">REST API Reference for ExportDictionaryEntries Operation</seealso>
        Task<ExportDictionaryEntriesResponse> ExportDictionaryEntriesAsync(ExportDictionaryEntriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the specified dictionary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDictionary service method.</param>
        /// <returns>The response from the GetDictionary service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/GetDictionary">REST API Reference for GetDictionary Operation</seealso>
        GetDictionaryResponse GetDictionary(GetDictionaryRequest request);
#endif

        /// <summary>
        /// Retrieves information about the specified dictionary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDictionary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetDictionary service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/GetDictionary">REST API Reference for GetDictionary Operation</seealso>
        Task<GetDictionaryResponse> GetDictionaryAsync(GetDictionaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the specified feed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFeed service method.</param>
        /// <returns>The response from the GetFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/GetFeed">REST API Reference for GetFeed Operation</seealso>
        GetFeedResponse GetFeed(GetFeedRequest request);
#endif

        /// <summary>
        /// Retrieves information about the specified feed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFeed service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/GetFeed">REST API Reference for GetFeed Operation</seealso>
        Task<GetFeedResponse> GetFeedAsync(GetFeedRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the resource-based policy attached to the specified feed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFeedPolicy service method.</param>
        /// <returns>The response from the GetFeedPolicy service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/GetFeedPolicy">REST API Reference for GetFeedPolicy Operation</seealso>
        GetFeedPolicyResponse GetFeedPolicy(GetFeedPolicyRequest request);
#endif

        /// <summary>
        /// Retrieves the resource-based policy attached to the specified feed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFeedPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetFeedPolicy service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/GetFeedPolicy">REST API Reference for GetFeedPolicy Operation</seealso>
        Task<GetFeedPolicyResponse> GetFeedPolicyAsync(GetFeedPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the specified fixture (a sports event, such as a specific
        /// basketball game). You obtain a fixtureId from SearchFixtures, or from the clipping
        /// output of a feed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFixture service method.</param>
        /// <returns>The response from the GetFixture service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.GatewayTimedOutException">
        /// The request timed out before the service returned a response. This is a temporary
        /// condition. Retry the request. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceUnavailableException">
        /// The service is temporarily unable to handle the request. Retry the request. If the
        /// problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/GetFixture">REST API Reference for GetFixture Operation</seealso>
        GetFixtureResponse GetFixture(GetFixtureRequest request);
#endif

        /// <summary>
        /// Retrieves information about the specified fixture (a sports event, such as a specific
        /// basketball game). You obtain a fixtureId from SearchFixtures, or from the clipping
        /// output of a feed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFixture service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetFixture service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.GatewayTimedOutException">
        /// The request timed out before the service returned a response. This is a temporary
        /// condition. Retry the request. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceUnavailableException">
        /// The service is temporarily unable to handle the request. Retry the request. If the
        /// problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/GetFixture">REST API Reference for GetFixture Operation</seealso>
        Task<GetFixtureResponse> GetFixtureAsync(GetFixtureRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the details of a function, including its expressions, the media context
        /// that Elemental Inference derived from the request expression, and the feeds that currently
        /// reference it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunction service method.</param>
        /// <returns>The response from the GetFunction service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/GetFunction">REST API Reference for GetFunction Operation</seealso>
        GetFunctionResponse GetFunction(GetFunctionRequest request);
#endif

        /// <summary>
        /// Retrieves the details of a function, including its expressions, the media context
        /// that Elemental Inference derived from the request expression, and the feeds that currently
        /// reference it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetFunction service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/GetFunction">REST API Reference for GetFunction Operation</seealso>
        Task<GetFunctionResponse> GetFunctionAsync(GetFunctionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about the specified question set at one version. By default,
        /// GetQuestionSet returns the DRAFT version. To retrieve a published version, specify
        /// questionSetVersion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQuestionSet service method.</param>
        /// <returns>The response from the GetQuestionSet service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/GetQuestionSet">REST API Reference for GetQuestionSet Operation</seealso>
        GetQuestionSetResponse GetQuestionSet(GetQuestionSetRequest request);
#endif

        /// <summary>
        /// Retrieves information about the specified question set at one version. By default,
        /// GetQuestionSet returns the DRAFT version. To retrieve a published version, specify
        /// questionSetVersion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQuestionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetQuestionSet service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/GetQuestionSet">REST API Reference for GetQuestionSet Operation</seealso>
        Task<GetQuestionSetResponse> GetQuestionSetAsync(GetQuestionSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the dictionaries in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDictionaries service method.</param>
        /// <returns>The response from the ListDictionaries service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListDictionaries">REST API Reference for ListDictionaries Operation</seealso>
        ListDictionariesResponse ListDictionaries(ListDictionariesRequest request);
#endif

        /// <summary>
        /// Lists the dictionaries in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDictionaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListDictionaries service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListDictionaries">REST API Reference for ListDictionaries Operation</seealso>
        Task<ListDictionariesResponse> ListDictionariesAsync(ListDictionariesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Displays a list of feeds that belong to this AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFeeds service method.</param>
        /// <returns>The response from the ListFeeds service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListFeeds">REST API Reference for ListFeeds Operation</seealso>
        ListFeedsResponse ListFeeds(ListFeedsRequest request);
#endif

        /// <summary>
        /// Displays a list of feeds that belong to this AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFeeds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListFeeds service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListFeeds">REST API Reference for ListFeeds Operation</seealso>
        Task<ListFeedsResponse> ListFeedsAsync(ListFeedsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the functions in this account, in this Region. Each entry is a summary. To get
        /// the expressions of a function, use GetFunction.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions service method.</param>
        /// <returns>The response from the ListFunctions service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        ListFunctionsResponse ListFunctions(ListFunctionsRequest request);
#endif

        /// <summary>
        /// Lists the functions in this account, in this Region. Each entry is a summary. To get
        /// the expressions of a function, use GetFunction.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListFunctions service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListFunctions">REST API Reference for ListFunctions Operation</seealso>
        Task<ListFunctionsResponse> ListFunctionsAsync(ListFunctionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the versions of the specified question set. The list starts with the DRAFT version,
        /// followed by the published versions from the highest version number to the lowest.
        /// The list doesn't include deleted versions. 
        /// 
        ///  
        /// <para>
        /// The response doesn't include the questions in each version. To retrieve them, use
        /// GetQuestionSet and specify questionSetVersion. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQuestionSetVersions service method.</param>
        /// <returns>The response from the ListQuestionSetVersions service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListQuestionSetVersions">REST API Reference for ListQuestionSetVersions Operation</seealso>
        ListQuestionSetVersionsResponse ListQuestionSetVersions(ListQuestionSetVersionsRequest request);
#endif

        /// <summary>
        /// Lists the versions of the specified question set. The list starts with the DRAFT version,
        /// followed by the published versions from the highest version number to the lowest.
        /// The list doesn't include deleted versions. 
        /// 
        ///  
        /// <para>
        /// The response doesn't include the questions in each version. To retrieve them, use
        /// GetQuestionSet and specify questionSetVersion. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQuestionSetVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListQuestionSetVersions service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListQuestionSetVersions">REST API Reference for ListQuestionSetVersions Operation</seealso>
        Task<ListQuestionSetVersionsResponse> ListQuestionSetVersionsAsync(ListQuestionSetVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the question sets in your account. The response doesn't include the questions
        /// in each question set. To retrieve them, use GetQuestionSet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQuestionSets service method.</param>
        /// <returns>The response from the ListQuestionSets service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListQuestionSets">REST API Reference for ListQuestionSets Operation</seealso>
        ListQuestionSetsResponse ListQuestionSets(ListQuestionSetsRequest request);
#endif

        /// <summary>
        /// Lists the question sets in your account. The response doesn't include the questions
        /// in each question set. To retrieve them, use GetQuestionSet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQuestionSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListQuestionSets service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListQuestionSets">REST API Reference for ListQuestionSets Operation</seealso>
        Task<ListQuestionSetsResponse> ListQuestionSetsAsync(ListQuestionSetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Displays a list of the schedule actions on a feed, including the status of each action
        /// and, for a failed action, information about why it failed. 
        /// 
        ///  
        /// <para>
        /// Elemental Inference keeps an action whose status is COMPLETED or FAILED for about
        /// 48 hours after its scheduled time, and then deletes it automatically. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScheduleActions service method.</param>
        /// <returns>The response from the ListScheduleActions service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListScheduleActions">REST API Reference for ListScheduleActions Operation</seealso>
        ListScheduleActionsResponse ListScheduleActions(ListScheduleActionsRequest request);
#endif

        /// <summary>
        /// Displays a list of the schedule actions on a feed, including the status of each action
        /// and, for a failed action, information about why it failed. 
        /// 
        ///  
        /// <para>
        /// Elemental Inference keeps an action whose status is COMPLETED or FAILED for about
        /// 48 hours after its scheduled time, and then deletes it automatically. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScheduleActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListScheduleActions service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListScheduleActions">REST API Reference for ListScheduleActions Operation</seealso>
        Task<ListScheduleActionsResponse> ListScheduleActionsAsync(ListScheduleActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List all tags that are on an Elemental Inference resource in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);
#endif

        /// <summary>
        /// List all tags that are on an Elemental Inference resource in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Attaches or replaces a resource-based policy on the specified feed. A resource-based
        /// policy grants cross-account access to the feed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFeedPolicy service method.</param>
        /// <returns>The response from the PutFeedPolicy service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/PutFeedPolicy">REST API Reference for PutFeedPolicy Operation</seealso>
        PutFeedPolicyResponse PutFeedPolicy(PutFeedPolicyRequest request);
#endif

        /// <summary>
        /// Attaches or replaces a resource-based policy on the specified feed. A resource-based
        /// policy grants cross-account access to the feed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFeedPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutFeedPolicy service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/PutFeedPolicy">REST API Reference for PutFeedPolicy Operation</seealso>
        Task<PutFeedPolicyResponse> PutFeedPolicyAsync(PutFeedPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Searches for the fixtures (sports events, such as a specific basketball game) that
        /// are available for a sport in a date window. Each fixture in the response includes
        /// a fixtureId that you specify in the clipping output of a feed, so that Elemental Inference
        /// maps the event data for that fixture onto the clipping metadata. This operation is
        /// paginated: if there are more fixtures than fit in one page, the response includes
        /// a nextToken that you pass in a subsequent request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFixtures service method.</param>
        /// <returns>The response from the SearchFixtures service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.GatewayTimedOutException">
        /// The request timed out before the service returned a response. This is a temporary
        /// condition. Retry the request. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceUnavailableException">
        /// The service is temporarily unable to handle the request. Retry the request. If the
        /// problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/SearchFixtures">REST API Reference for SearchFixtures Operation</seealso>
        SearchFixturesResponse SearchFixtures(SearchFixturesRequest request);
#endif

        /// <summary>
        /// Searches for the fixtures (sports events, such as a specific basketball game) that
        /// are available for a sport in a date window. Each fixture in the response includes
        /// a fixtureId that you specify in the clipping output of a feed, so that Elemental Inference
        /// maps the event data for that fixture onto the clipping metadata. This operation is
        /// paginated: if there are more fixtures than fit in one page, the response includes
        /// a nextToken that you pass in a subsequent request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFixtures service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SearchFixtures service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.GatewayTimedOutException">
        /// The request timed out before the service returned a response. This is a temporary
        /// condition. Retry the request. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceUnavailableException">
        /// The service is temporarily unable to handle the request. Retry the request. If the
        /// problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/SearchFixtures">REST API Reference for SearchFixtures Operation</seealso>
        Task<SearchFixturesResponse> SearchFixturesAsync(SearchFixturesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Associates the specified tags to the resource identified by the specified resourceArn
        /// in the current region. If existing tags on a resource are not specified in the request
        /// parameters, they are not changed. When a resource is deleted, the tags associated
        /// with that resource are also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);
#endif

        /// <summary>
        /// Associates the specified tags to the resource identified by the specified resourceArn
        /// in the current region. If existing tags on a resource are not specified in the request
        /// parameters, they are not changed. When a resource is deleted, the tags associated
        /// with that resource are also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes specified tags from the specified resource in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);
#endif

        /// <summary>
        /// Deletes specified tags from the specified resource in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the specified dictionary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDictionary service method.</param>
        /// <returns>The response from the UpdateDictionary service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/UpdateDictionary">REST API Reference for UpdateDictionary Operation</seealso>
        UpdateDictionaryResponse UpdateDictionary(UpdateDictionaryRequest request);
#endif

        /// <summary>
        /// Updates the specified dictionary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDictionary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateDictionary service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/UpdateDictionary">REST API Reference for UpdateDictionary Operation</seealso>
        Task<UpdateDictionaryResponse> UpdateDictionaryAsync(UpdateDictionaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the name and/or outputs in a feed. 
        /// 
        ///  
        /// <para>
        /// UpdateFeed is a PUT operation, which means that the payload that you specify completely
        /// overwrites the existing payload. 
        /// </para>
        ///  
        /// <para>
        /// This means that if you want to touch the array of outputs, you must pass in the full
        /// new list. So you must omit outputs you want to delete, and include outputs you want
        /// to add or modify. 
        /// </para>
        ///  
        /// <para>
        /// If you want to patch the array of outputs to make selective additions, use AssociateFeed.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFeed service method.</param>
        /// <returns>The response from the UpdateFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/UpdateFeed">REST API Reference for UpdateFeed Operation</seealso>
        UpdateFeedResponse UpdateFeed(UpdateFeedRequest request);
#endif

        /// <summary>
        /// Updates the name and/or outputs in a feed. 
        /// 
        ///  
        /// <para>
        /// UpdateFeed is a PUT operation, which means that the payload that you specify completely
        /// overwrites the existing payload. 
        /// </para>
        ///  
        /// <para>
        /// This means that if you want to touch the array of outputs, you must pass in the full
        /// new list. So you must omit outputs you want to delete, and include outputs you want
        /// to add or modify. 
        /// </para>
        ///  
        /// <para>
        /// If you want to patch the array of outputs to make selective additions, use AssociateFeed.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFeed service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/UpdateFeed">REST API Reference for UpdateFeed Operation</seealso>
        Task<UpdateFeedResponse> UpdateFeedAsync(UpdateFeedRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a function. Include only the parameters that you want to change; parameters
        /// that you don't include aren't affected. Elemental Inference validates the updated
        /// expressions in the same way as CreateFunction. 
        /// 
        ///  
        /// <para>
        /// While a feed references the function, you can change only its expressions and its
        /// description, and you can set eventBridgeDelivery to DISABLED but not to ENABLED. The
        /// request expression must keep referencing the same media context, as reported in contextTypes.
        /// Changing an expression changes the behavior of every feed that references the function.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunction service method.</param>
        /// <returns>The response from the UpdateFunction service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/UpdateFunction">REST API Reference for UpdateFunction Operation</seealso>
        UpdateFunctionResponse UpdateFunction(UpdateFunctionRequest request);
#endif

        /// <summary>
        /// Updates a function. Include only the parameters that you want to change; parameters
        /// that you don't include aren't affected. Elemental Inference validates the updated
        /// expressions in the same way as CreateFunction. 
        /// 
        ///  
        /// <para>
        /// While a feed references the function, you can change only its expressions and its
        /// description, and you can set eventBridgeDelivery to DISABLED but not to ENABLED. The
        /// request expression must keep referencing the same media context, as reported in contextTypes.
        /// Changing an expression changes the behavior of every feed that references the function.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateFunction service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/UpdateFunction">REST API Reference for UpdateFunction Operation</seealso>
        Task<UpdateFunctionResponse> UpdateFunctionAsync(UpdateFunctionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the DRAFT version of the specified question set. UpdateQuestionSet doesn't
        /// create a version and doesn't change published versions. To publish the updated DRAFT
        /// as a new version, use CreateQuestionSetVersion. 
        /// 
        ///  
        /// <para>
        /// UpdateQuestionSet replaces questions one type at a time. For each of yesNo, yesNoPerOption,
        /// and chooseOne: if you omit the array, DRAFT keeps its questions of that type. If you
        /// include the array, it replaces all the questions of that type in DRAFT. If you include
        /// an empty array, DRAFT no longer has questions of that type. The updated DRAFT must
        /// follow the same rules as in CreateQuestionSet, and Elemental Inference applies those
        /// rules to the questions that DRAFT keeps as well as to the questions in the request.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Feeds that reference the DRAFT version use the updated questions. To make sure that
        /// the questions for a feed don't change, reference a published version instead. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuestionSet service method.</param>
        /// <returns>The response from the UpdateQuestionSet service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/UpdateQuestionSet">REST API Reference for UpdateQuestionSet Operation</seealso>
        UpdateQuestionSetResponse UpdateQuestionSet(UpdateQuestionSetRequest request);
#endif

        /// <summary>
        /// Updates the DRAFT version of the specified question set. UpdateQuestionSet doesn't
        /// create a version and doesn't change published versions. To publish the updated DRAFT
        /// as a new version, use CreateQuestionSetVersion. 
        /// 
        ///  
        /// <para>
        /// UpdateQuestionSet replaces questions one type at a time. For each of yesNo, yesNoPerOption,
        /// and chooseOne: if you omit the array, DRAFT keeps its questions of that type. If you
        /// include the array, it replaces all the questions of that type in DRAFT. If you include
        /// an empty array, DRAFT no longer has questions of that type. The updated DRAFT must
        /// follow the same rules as in CreateQuestionSet, and Elemental Inference applies those
        /// rules to the questions that DRAFT keeps as well as to the questions in the request.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Feeds that reference the DRAFT version use the updated questions. To make sure that
        /// the questions for a feed don't change, reference a published version instead. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQuestionSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateQuestionSet service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/UpdateQuestionSet">REST API Reference for UpdateQuestionSet Operation</seealso>
        Task<UpdateQuestionSetResponse> UpdateQuestionSetAsync(UpdateQuestionSetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonElementalInferenceConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonElementalInferenceConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonElementalInferenceConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonElementalInferenceConfig to create AmazonElementalInferenceClient");
            }

            return awsCredentials == null ?
                    new AmazonElementalInferenceClient(serviceClientConfig) :
                    new AmazonElementalInferenceClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
