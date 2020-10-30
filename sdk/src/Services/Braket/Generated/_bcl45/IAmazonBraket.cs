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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Braket.Model;

namespace Amazon.Braket
{
    /// <summary>
    /// Interface for accessing Braket
    ///
    /// The Amazon Braket API Reference provides information about the operations and structures
    /// supported in Amazon Braket.
    /// </summary>
    public partial interface IAmazonBraket : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBraketPaginatorFactory Paginators { get; }

        
        #region  CancelQuantumTask


        /// <summary>
        /// Cancels the specified task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelQuantumTask service method.</param>
        /// 
        /// <returns>The response from the CancelQuantumTask service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ConflictException">
        /// An error occurred due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/CancelQuantumTask">REST API Reference for CancelQuantumTask Operation</seealso>
        CancelQuantumTaskResponse CancelQuantumTask(CancelQuantumTaskRequest request);



        /// <summary>
        /// Cancels the specified task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelQuantumTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelQuantumTask service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ConflictException">
        /// An error occurred due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/CancelQuantumTask">REST API Reference for CancelQuantumTask Operation</seealso>
        Task<CancelQuantumTaskResponse> CancelQuantumTaskAsync(CancelQuantumTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateQuantumTask


        /// <summary>
        /// Creates a quantum task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQuantumTask service method.</param>
        /// 
        /// <returns>The response from the CreateQuantumTask service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.DeviceOfflineException">
        /// The specified device is currently offline.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/CreateQuantumTask">REST API Reference for CreateQuantumTask Operation</seealso>
        CreateQuantumTaskResponse CreateQuantumTask(CreateQuantumTaskRequest request);



        /// <summary>
        /// Creates a quantum task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQuantumTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQuantumTask service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.DeviceOfflineException">
        /// The specified device is currently offline.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/CreateQuantumTask">REST API Reference for CreateQuantumTask Operation</seealso>
        Task<CreateQuantumTaskResponse> CreateQuantumTaskAsync(CreateQuantumTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDevice


        /// <summary>
        /// Retrieves the devices available in Amazon Braket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevice service method.</param>
        /// 
        /// <returns>The response from the GetDevice service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/GetDevice">REST API Reference for GetDevice Operation</seealso>
        GetDeviceResponse GetDevice(GetDeviceRequest request);



        /// <summary>
        /// Retrieves the devices available in Amazon Braket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDevice service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/GetDevice">REST API Reference for GetDevice Operation</seealso>
        Task<GetDeviceResponse> GetDeviceAsync(GetDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetQuantumTask


        /// <summary>
        /// Retrieves the specified quantum task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQuantumTask service method.</param>
        /// 
        /// <returns>The response from the GetQuantumTask service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/GetQuantumTask">REST API Reference for GetQuantumTask Operation</seealso>
        GetQuantumTaskResponse GetQuantumTask(GetQuantumTaskRequest request);



        /// <summary>
        /// Retrieves the specified quantum task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQuantumTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQuantumTask service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/GetQuantumTask">REST API Reference for GetQuantumTask Operation</seealso>
        Task<GetQuantumTaskResponse> GetQuantumTaskAsync(GetQuantumTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Shows the tags associated with this resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Shows the tags associated with this resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchDevices


        /// <summary>
        /// Searches for devices using the specified filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDevices service method.</param>
        /// 
        /// <returns>The response from the SearchDevices service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/SearchDevices">REST API Reference for SearchDevices Operation</seealso>
        SearchDevicesResponse SearchDevices(SearchDevicesRequest request);



        /// <summary>
        /// Searches for devices using the specified filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchDevices service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/SearchDevices">REST API Reference for SearchDevices Operation</seealso>
        Task<SearchDevicesResponse> SearchDevicesAsync(SearchDevicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchQuantumTasks


        /// <summary>
        /// Searches for tasks that match the specified filter values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchQuantumTasks service method.</param>
        /// 
        /// <returns>The response from the SearchQuantumTasks service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/SearchQuantumTasks">REST API Reference for SearchQuantumTasks Operation</seealso>
        SearchQuantumTasksResponse SearchQuantumTasks(SearchQuantumTasksRequest request);



        /// <summary>
        /// Searches for tasks that match the specified filter values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchQuantumTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchQuantumTasks service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The throttling rate limit is met.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/SearchQuantumTasks">REST API Reference for SearchQuantumTasks Operation</seealso>
        Task<SearchQuantumTasksResponse> SearchQuantumTasksAsync(SearchQuantumTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Add a tag to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Add a tag to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Remove tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Remove tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}