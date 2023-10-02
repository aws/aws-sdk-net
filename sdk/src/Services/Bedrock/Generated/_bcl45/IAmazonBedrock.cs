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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Bedrock.Model;

namespace Amazon.Bedrock
{
    /// <summary>
    /// Interface for accessing Bedrock
    ///
    /// Describes the API operations for creating and managing Bedrock models.
    /// </summary>
    public partial interface IAmazonBedrock : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBedrockPaginatorFactory Paginators { get; }

        
        #region  CreateModelCustomizationJob


        /// <summary>
        /// Creates a fine-tuning job to customize a base model.
        /// 
        ///  
        /// <para>
        /// You specify the base foundation model and the location of the training data. After
        /// the model-customization job completes successfully, your custom model resource will
        /// be ready to use. Training data contains input and output text for each record in a
        /// JSONL format. Optionally, you can specify validation data in the same format as the
        /// training data. Bedrock returns validation loss metrics and output generations after
        /// the job completes. 
        /// </para>
        ///  
        /// <para>
        ///  Model-customization jobs are asynchronous and the completion time depends on the
        /// base model and the training/validation data size. To monitor a job, use the <code>GetModelCustomizationJob</code>
        /// operation to retrieve the job status.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the Bedrock User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelCustomizationJob service method.</param>
        /// 
        /// <returns>The response from the CreateModelCustomizationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelCustomizationJob">REST API Reference for CreateModelCustomizationJob Operation</seealso>
        CreateModelCustomizationJobResponse CreateModelCustomizationJob(CreateModelCustomizationJobRequest request);



        /// <summary>
        /// Creates a fine-tuning job to customize a base model.
        /// 
        ///  
        /// <para>
        /// You specify the base foundation model and the location of the training data. After
        /// the model-customization job completes successfully, your custom model resource will
        /// be ready to use. Training data contains input and output text for each record in a
        /// JSONL format. Optionally, you can specify validation data in the same format as the
        /// training data. Bedrock returns validation loss metrics and output generations after
        /// the job completes. 
        /// </para>
        ///  
        /// <para>
        ///  Model-customization jobs are asynchronous and the completion time depends on the
        /// base model and the training/validation data size. To monitor a job, use the <code>GetModelCustomizationJob</code>
        /// operation to retrieve the job status.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the Bedrock User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelCustomizationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModelCustomizationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateModelCustomizationJob">REST API Reference for CreateModelCustomizationJob Operation</seealso>
        Task<CreateModelCustomizationJobResponse> CreateModelCustomizationJobAsync(CreateModelCustomizationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateProvisionedModelThroughput


        /// <summary>
        /// Creates a provisioned throughput with dedicated capacity for a foundation model or
        /// a fine-tuned model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Provisioned
        /// throughput</a> in the Bedrock User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisionedModelThroughput service method.</param>
        /// 
        /// <returns>The response from the CreateProvisionedModelThroughput service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateProvisionedModelThroughput">REST API Reference for CreateProvisionedModelThroughput Operation</seealso>
        CreateProvisionedModelThroughputResponse CreateProvisionedModelThroughput(CreateProvisionedModelThroughputRequest request);



        /// <summary>
        /// Creates a provisioned throughput with dedicated capacity for a foundation model or
        /// a fine-tuned model.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Provisioned
        /// throughput</a> in the Bedrock User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisionedModelThroughput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProvisionedModelThroughput service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ServiceQuotaExceededException">
        /// The number of requests exceeds the service quota. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/CreateProvisionedModelThroughput">REST API Reference for CreateProvisionedModelThroughput Operation</seealso>
        Task<CreateProvisionedModelThroughputResponse> CreateProvisionedModelThroughputAsync(CreateProvisionedModelThroughputRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCustomModel


        /// <summary>
        /// Deletes a custom model that you created earlier. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomModel service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteCustomModel">REST API Reference for DeleteCustomModel Operation</seealso>
        DeleteCustomModelResponse DeleteCustomModel(DeleteCustomModelRequest request);



        /// <summary>
        /// Deletes a custom model that you created earlier. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteCustomModel">REST API Reference for DeleteCustomModel Operation</seealso>
        Task<DeleteCustomModelResponse> DeleteCustomModelAsync(DeleteCustomModelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteModelInvocationLoggingConfiguration


        /// <summary>
        /// Delete the invocation logging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelInvocationLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteModelInvocationLoggingConfiguration service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteModelInvocationLoggingConfiguration">REST API Reference for DeleteModelInvocationLoggingConfiguration Operation</seealso>
        DeleteModelInvocationLoggingConfigurationResponse DeleteModelInvocationLoggingConfiguration(DeleteModelInvocationLoggingConfigurationRequest request);



        /// <summary>
        /// Delete the invocation logging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelInvocationLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModelInvocationLoggingConfiguration service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteModelInvocationLoggingConfiguration">REST API Reference for DeleteModelInvocationLoggingConfiguration Operation</seealso>
        Task<DeleteModelInvocationLoggingConfigurationResponse> DeleteModelInvocationLoggingConfigurationAsync(DeleteModelInvocationLoggingConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteProvisionedModelThroughput


        /// <summary>
        /// Deletes a provisioned throughput. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Provisioned
        /// throughput</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisionedModelThroughput service method.</param>
        /// 
        /// <returns>The response from the DeleteProvisionedModelThroughput service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteProvisionedModelThroughput">REST API Reference for DeleteProvisionedModelThroughput Operation</seealso>
        DeleteProvisionedModelThroughputResponse DeleteProvisionedModelThroughput(DeleteProvisionedModelThroughputRequest request);



        /// <summary>
        /// Deletes a provisioned throughput. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Provisioned
        /// throughput</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisionedModelThroughput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProvisionedModelThroughput service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/DeleteProvisionedModelThroughput">REST API Reference for DeleteProvisionedModelThroughput Operation</seealso>
        Task<DeleteProvisionedModelThroughputResponse> DeleteProvisionedModelThroughputAsync(DeleteProvisionedModelThroughputRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCustomModel


        /// <summary>
        /// Get the properties associated with a Bedrock custom model that you have created.For
        /// more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomModel service method.</param>
        /// 
        /// <returns>The response from the GetCustomModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetCustomModel">REST API Reference for GetCustomModel Operation</seealso>
        GetCustomModelResponse GetCustomModel(GetCustomModelRequest request);



        /// <summary>
        /// Get the properties associated with a Bedrock custom model that you have created.For
        /// more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCustomModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetCustomModel">REST API Reference for GetCustomModel Operation</seealso>
        Task<GetCustomModelResponse> GetCustomModelAsync(GetCustomModelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFoundationModel


        /// <summary>
        /// Get details about a Bedrock foundation model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFoundationModel service method.</param>
        /// 
        /// <returns>The response from the GetFoundationModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetFoundationModel">REST API Reference for GetFoundationModel Operation</seealso>
        GetFoundationModelResponse GetFoundationModel(GetFoundationModelRequest request);



        /// <summary>
        /// Get details about a Bedrock foundation model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFoundationModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFoundationModel service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetFoundationModel">REST API Reference for GetFoundationModel Operation</seealso>
        Task<GetFoundationModelResponse> GetFoundationModelAsync(GetFoundationModelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetModelCustomizationJob


        /// <summary>
        /// Retrieves the properties associated with a model-customization job, including the
        /// status of the job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelCustomizationJob service method.</param>
        /// 
        /// <returns>The response from the GetModelCustomizationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelCustomizationJob">REST API Reference for GetModelCustomizationJob Operation</seealso>
        GetModelCustomizationJobResponse GetModelCustomizationJob(GetModelCustomizationJobRequest request);



        /// <summary>
        /// Retrieves the properties associated with a model-customization job, including the
        /// status of the job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelCustomizationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetModelCustomizationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelCustomizationJob">REST API Reference for GetModelCustomizationJob Operation</seealso>
        Task<GetModelCustomizationJobResponse> GetModelCustomizationJobAsync(GetModelCustomizationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetModelInvocationLoggingConfiguration


        /// <summary>
        /// Get the current configuration values for model invocation logging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelInvocationLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetModelInvocationLoggingConfiguration service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelInvocationLoggingConfiguration">REST API Reference for GetModelInvocationLoggingConfiguration Operation</seealso>
        GetModelInvocationLoggingConfigurationResponse GetModelInvocationLoggingConfiguration(GetModelInvocationLoggingConfigurationRequest request);



        /// <summary>
        /// Get the current configuration values for model invocation logging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelInvocationLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetModelInvocationLoggingConfiguration service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetModelInvocationLoggingConfiguration">REST API Reference for GetModelInvocationLoggingConfiguration Operation</seealso>
        Task<GetModelInvocationLoggingConfigurationResponse> GetModelInvocationLoggingConfigurationAsync(GetModelInvocationLoggingConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetProvisionedModelThroughput


        /// <summary>
        /// Get details for a provisioned throughput. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Provisioned
        /// throughput</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProvisionedModelThroughput service method.</param>
        /// 
        /// <returns>The response from the GetProvisionedModelThroughput service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetProvisionedModelThroughput">REST API Reference for GetProvisionedModelThroughput Operation</seealso>
        GetProvisionedModelThroughputResponse GetProvisionedModelThroughput(GetProvisionedModelThroughputRequest request);



        /// <summary>
        /// Get details for a provisioned throughput. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Provisioned
        /// throughput</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProvisionedModelThroughput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProvisionedModelThroughput service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/GetProvisionedModelThroughput">REST API Reference for GetProvisionedModelThroughput Operation</seealso>
        Task<GetProvisionedModelThroughputResponse> GetProvisionedModelThroughputAsync(GetProvisionedModelThroughputRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCustomModels


        /// <summary>
        /// Returns a list of the custom models that you have created with the <code>CreateModelCustomizationJob</code>
        /// operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the Bedrock User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomModels service method.</param>
        /// 
        /// <returns>The response from the ListCustomModels service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListCustomModels">REST API Reference for ListCustomModels Operation</seealso>
        ListCustomModelsResponse ListCustomModels(ListCustomModelsRequest request);



        /// <summary>
        /// Returns a list of the custom models that you have created with the <code>CreateModelCustomizationJob</code>
        /// operation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the Bedrock User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomModels service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListCustomModels">REST API Reference for ListCustomModels Operation</seealso>
        Task<ListCustomModelsResponse> ListCustomModelsAsync(ListCustomModelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFoundationModels


        /// <summary>
        /// List of Bedrock foundation models that you can use. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/foundation-models.html">Foundation
        /// models</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFoundationModels service method.</param>
        /// 
        /// <returns>The response from the ListFoundationModels service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListFoundationModels">REST API Reference for ListFoundationModels Operation</seealso>
        ListFoundationModelsResponse ListFoundationModels(ListFoundationModelsRequest request);



        /// <summary>
        /// List of Bedrock foundation models that you can use. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/foundation-models.html">Foundation
        /// models</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFoundationModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFoundationModels service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListFoundationModels">REST API Reference for ListFoundationModels Operation</seealso>
        Task<ListFoundationModelsResponse> ListFoundationModelsAsync(ListFoundationModelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListModelCustomizationJobs


        /// <summary>
        /// Returns a list of model customization jobs that you have submitted. You can filter
        /// the jobs to return based on one or more criteria.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the Bedrock User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelCustomizationJobs service method.</param>
        /// 
        /// <returns>The response from the ListModelCustomizationJobs service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelCustomizationJobs">REST API Reference for ListModelCustomizationJobs Operation</seealso>
        ListModelCustomizationJobsResponse ListModelCustomizationJobs(ListModelCustomizationJobsRequest request);



        /// <summary>
        /// Returns a list of model customization jobs that you have submitted. You can filter
        /// the jobs to return based on one or more criteria.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the Bedrock User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelCustomizationJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListModelCustomizationJobs service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListModelCustomizationJobs">REST API Reference for ListModelCustomizationJobs Operation</seealso>
        Task<ListModelCustomizationJobsResponse> ListModelCustomizationJobsAsync(ListModelCustomizationJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListProvisionedModelThroughputs


        /// <summary>
        /// List the provisioned capacities. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Provisioned
        /// throughput</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedModelThroughputs service method.</param>
        /// 
        /// <returns>The response from the ListProvisionedModelThroughputs service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListProvisionedModelThroughputs">REST API Reference for ListProvisionedModelThroughputs Operation</seealso>
        ListProvisionedModelThroughputsResponse ListProvisionedModelThroughputs(ListProvisionedModelThroughputsRequest request);



        /// <summary>
        /// List the provisioned capacities. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Provisioned
        /// throughput</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisionedModelThroughputs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProvisionedModelThroughputs service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListProvisionedModelThroughputs">REST API Reference for ListProvisionedModelThroughputs Operation</seealso>
        Task<ListProvisionedModelThroughputsResponse> ListProvisionedModelThroughputsAsync(ListProvisionedModelThroughputsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List the tags associated with the specified resource.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Tagging
        /// resources</a> in the Bedrock User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// List the tags associated with the specified resource.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Tagging
        /// resources</a> in the Bedrock User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutModelInvocationLoggingConfiguration


        /// <summary>
        /// Set the configuration values for model invocation logging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutModelInvocationLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutModelInvocationLoggingConfiguration service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/PutModelInvocationLoggingConfiguration">REST API Reference for PutModelInvocationLoggingConfiguration Operation</seealso>
        PutModelInvocationLoggingConfigurationResponse PutModelInvocationLoggingConfiguration(PutModelInvocationLoggingConfigurationRequest request);



        /// <summary>
        /// Set the configuration values for model invocation logging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutModelInvocationLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutModelInvocationLoggingConfiguration service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/PutModelInvocationLoggingConfiguration">REST API Reference for PutModelInvocationLoggingConfiguration Operation</seealso>
        Task<PutModelInvocationLoggingConfigurationResponse> PutModelInvocationLoggingConfigurationAsync(PutModelInvocationLoggingConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopModelCustomizationJob


        /// <summary>
        /// Stops an active model customization job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopModelCustomizationJob service method.</param>
        /// 
        /// <returns>The response from the StopModelCustomizationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StopModelCustomizationJob">REST API Reference for StopModelCustomizationJob Operation</seealso>
        StopModelCustomizationJobResponse StopModelCustomizationJob(StopModelCustomizationJobRequest request);



        /// <summary>
        /// Stops an active model customization job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopModelCustomizationJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopModelCustomizationJob service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ConflictException">
        /// Error occurred because of a conflict while performing an operation.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/StopModelCustomizationJob">REST API Reference for StopModelCustomizationJob Operation</seealso>
        Task<StopModelCustomizationJobResponse> StopModelCustomizationJobAsync(StopModelCustomizationJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associate tags with a resource. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Tagging
        /// resources</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Associate tags with a resource. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Tagging
        /// resources</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.TooManyTagsException">
        /// The request contains more tags than can be associated with a resource (50 tags per
        /// resource). The maximum number of tags includes both existing tags and those included
        /// in your current request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Remove one or more tags from a resource. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Tagging
        /// resources</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Remove one or more tags from a resource. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Tagging
        /// resources</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateProvisionedModelThroughput


        /// <summary>
        /// Update a provisioned throughput. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Provisioned
        /// throughput</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisionedModelThroughput service method.</param>
        /// 
        /// <returns>The response from the UpdateProvisionedModelThroughput service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateProvisionedModelThroughput">REST API Reference for UpdateProvisionedModelThroughput Operation</seealso>
        UpdateProvisionedModelThroughputResponse UpdateProvisionedModelThroughput(UpdateProvisionedModelThroughputRequest request);



        /// <summary>
        /// Update a provisioned throughput. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Provisioned
        /// throughput</a> in the Bedrock User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisionedModelThroughput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProvisionedModelThroughput service method, as returned by Bedrock.</returns>
        /// <exception cref="Amazon.Bedrock.Model.AccessDeniedException">
        /// The request is denied because of missing access permissions.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ResourceNotFoundException">
        /// The specified resource ARN was not found. Check the ARN and try your request again.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ThrottlingException">
        /// The number of requests exceeds the limit. Resubmit your request later.
        /// </exception>
        /// <exception cref="Amazon.Bedrock.Model.ValidationException">
        /// Input validation failed. Check your request parameters and retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-2023-04-20/UpdateProvisionedModelThroughput">REST API Reference for UpdateProvisionedModelThroughput Operation</seealso>
        Task<UpdateProvisionedModelThroughputResponse> UpdateProvisionedModelThroughputAsync(UpdateProvisionedModelThroughputRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}