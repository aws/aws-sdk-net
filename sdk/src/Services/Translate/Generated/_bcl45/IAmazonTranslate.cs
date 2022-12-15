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
using System.Threading;
using System.Threading.Tasks;
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

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ITranslatePaginatorFactory Paginators { get; }

        
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
        /// Creates a parallel data resource in Amazon Translate by importing an input file from
        /// Amazon S3. Parallel data files contain examples that show how you want segments of
        /// text to be translated. By adding parallel data, you can influence the style, tone,
        /// and word choice in your translation output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateParallelData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateParallelDataResponse> CreateParallelDataAsync(CreateParallelDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a parallel data resource in Amazon Translate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteParallelData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteParallelDataResponse> DeleteParallelDataAsync(DeleteParallelDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// A synchronous action that deletes a custom terminology.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTerminology service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteTerminologyResponse> DeleteTerminologyAsync(DeleteTerminologyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets the properties associated with an asynchronous batch translation job including
        /// name, ID, status, source and target languages, input/output S3 buckets, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTextTranslationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeTextTranslationJobResponse> DescribeTextTranslationJobAsync(DescribeTextTranslationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Provides information about a parallel data resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParallelData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetParallelDataResponse> GetParallelDataAsync(GetParallelDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a custom terminology.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTerminology service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetTerminologyResponse> GetTerminologyAsync(GetTerminologyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ImportTerminologyResponse> ImportTerminologyAsync(ImportTerminologyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Provides a list of languages (RFC-5646 codes and names) that Amazon Translate supports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLanguages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListLanguagesResponse> ListLanguagesAsync(ListLanguagesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Provides a list of your parallel data resources in Amazon Translate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListParallelData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListParallelDataResponse> ListParallelDataAsync(ListParallelDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists all tags associated with a given Amazon Translate resource. For more information,
        /// see <a href="https://docs.aws.amazon.com/translate/latest/dg/tagging.html"> Tagging
        /// your resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Provides a list of custom terminologies associated with your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTerminologies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTerminologiesResponse> ListTerminologiesAsync(ListTerminologiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a list of the batch translation jobs that you have submitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTextTranslationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTextTranslationJobsResponse> ListTextTranslationJobsAsync(ListTextTranslationJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartTextTranslationJobResponse> StartTextTranslationJobAsync(StartTextTranslationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StopTextTranslationJobResponse> StopTextTranslationJobAsync(StopTextTranslationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Associates a specific tag with a resource. A tag is a key-value pair that adds as
        /// a metadata to a resource. For more information, see <a href="https://docs.aws.amazon.com/translate/latest/dg/tagging.html">
        /// Tagging your resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Translates input text from the source language to the target language. For a list
        /// of available languages and language codes, see <a href="https://docs.aws.amazon.com/translate/latest/dg/what-is-languages.html">Supported
        /// languages</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TranslateText service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TranslateTextResponse> TranslateTextAsync(TranslateTextRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes a specific tag associated with an Amazon Translate resource. For more information,
        /// see <a href="https://docs.aws.amazon.com/translate/latest/dg/tagging.html"> Tagging
        /// your resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a previously created parallel data resource by importing a new input file
        /// from Amazon S3.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateParallelData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateParallelDataResponse> UpdateParallelDataAsync(UpdateParallelDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}