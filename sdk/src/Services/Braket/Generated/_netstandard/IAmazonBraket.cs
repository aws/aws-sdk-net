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

#pragma warning disable CS1570
namespace Amazon.Braket
{
    /// <summary>
    /// <para>Interface for accessing Braket</para>
    ///
    /// The Amazon Braket API Reference provides information about the operations and structures
    /// supported by Amazon Braket.
    /// 
    ///  
    /// <para>
    /// To learn about the permissions required to call an Amazon Braket API action, see <a
    /// href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_amazonbraket.html">Actions,
    /// resources, and condition keys for Amazon Braket</a>. <a href="https://amazon-braket-sdk-python.readthedocs.io/en/latest/#">Amazon
    /// Braket Python SDK</a> and the <a href="https://docs.aws.amazon.com/cli/latest/reference/braket/">AWS
    /// Command Line Interface</a> can be used to make discovery and creation of API calls
    /// easier. For more information about Amazon Braket features, see <a href="https://docs.aws.amazon.com/braket/latest/developerguide/what-is-braket.html">What
    /// is Amazon Braket?</a> and important <a href="https://docs.aws.amazon.com/braket/latest/developerguide/braket-terms.html">terms
    /// and concepts</a> in the <i>Amazon Braket Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>In this guide:</b> 
    /// </para>
    ///  <ul> <li>  </li> <li>  </li> <li> 
    /// <para>
    ///  <a>CommonParameters</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CommonErrors</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Available languages for AWS SDK:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sdkfornet/v3/apidocs/items/Braket/NBraket.html">.NET</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://sdk.amazonaws.com/cpp/api/LATEST/root/html/index.html">C++</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sdk-for-go/api/service/braket/">Go API reference</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AWSJavaSDK/latest/javadoc/com/amazonaws/services/braket/package-summary.html">Java</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AWSJavaScriptSDK/latest/AWS/Braket.html">JavaScript</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/aws-sdk-php/v3/api/class-Aws.Braket.BraketClient.html">PHP</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://boto3.amazonaws.com/v1/documentation/api/latest/reference/services/braket.html">Python
    /// (Boto)</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sdk-for-ruby/v3/api/Aws/Braket.html">Ruby</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Code examples from the Amazon Braket Tutorials GitHub repository:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://github.com/amazon-braket/amazon-braket-examples">Amazon Braket Examples</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonBraket : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBraketPaginatorFactory Paginators { get; }
#endif
                
        #region  CancelJob



        /// <summary>
        /// Cancels an Amazon Braket hybrid job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ConflictException">
        /// An error occurred due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request failed because of an unknown error.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The API throttling rate limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input request failed to satisfy constraints expected by Amazon Braket.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/CancelJob">REST API Reference for CancelJob Operation</seealso>
        Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelQuantumTask



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
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ConflictException">
        /// An error occurred due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request failed because of an unknown error.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The API throttling rate limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input request failed to satisfy constraints expected by Amazon Braket.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/CancelQuantumTask">REST API Reference for CancelQuantumTask Operation</seealso>
        Task<CancelQuantumTaskResponse> CancelQuantumTaskAsync(CancelQuantumTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateJob



        /// <summary>
        /// Creates an Amazon Braket hybrid job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ConflictException">
        /// An error occurred due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.DeviceOfflineException">
        /// The specified device is currently offline.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.DeviceRetiredException">
        /// The specified device has been retired.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request failed because of an unknown error.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The API throttling rate limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input request failed to satisfy constraints expected by Amazon Braket.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/CreateJob">REST API Reference for CreateJob Operation</seealso>
        Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateQuantumTask



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
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.DeviceOfflineException">
        /// The specified device is currently offline.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.DeviceRetiredException">
        /// The specified device has been retired.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request failed because of an unknown error.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ServiceQuotaExceededException">
        /// The request failed because a service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The API throttling rate limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input request failed to satisfy constraints expected by Amazon Braket.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/CreateQuantumTask">REST API Reference for CreateQuantumTask Operation</seealso>
        Task<CreateQuantumTaskResponse> CreateQuantumTaskAsync(CreateQuantumTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDevice



        /// <summary>
        /// Retrieves the devices available in Amazon Braket.
        /// 
        ///  <note> 
        /// <para>
        /// For backwards compatibility with older versions of BraketSchemas, OpenQASM information
        /// is omitted from GetDevice API calls. To get this information the user-agent needs
        /// to present a recent version of the BraketSchemas (1.8.0 or later). The Braket SDK
        /// automatically reports this for you. If you do not see OpenQASM results in the GetDevice
        /// response when using a Braket SDK, you may need to set AWS_EXECUTION_ENV environment
        /// variable to configure user-agent. See the code examples provided below for how to
        /// do this for the AWS CLI, Boto3, and the Go, Java, and JavaScript/TypeScript SDKs.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDevice service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request failed because of an unknown error.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The API throttling rate limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input request failed to satisfy constraints expected by Amazon Braket.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/GetDevice">REST API Reference for GetDevice Operation</seealso>
        Task<GetDeviceResponse> GetDeviceAsync(GetDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetJob



        /// <summary>
        /// Retrieves the specified Amazon Braket hybrid job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request failed because of an unknown error.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The API throttling rate limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input request failed to satisfy constraints expected by Amazon Braket.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/GetJob">REST API Reference for GetJob Operation</seealso>
        Task<GetJobResponse> GetJobAsync(GetJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetQuantumTask



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
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request failed because of an unknown error.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The API throttling rate limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input request failed to satisfy constraints expected by Amazon Braket.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/GetQuantumTask">REST API Reference for GetQuantumTask Operation</seealso>
        Task<GetQuantumTaskResponse> GetQuantumTaskAsync(GetQuantumTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



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
        /// The request failed because of an unknown error.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input request failed to satisfy constraints expected by Amazon Braket.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchDevices



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
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request failed because of an unknown error.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The API throttling rate limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input request failed to satisfy constraints expected by Amazon Braket.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/SearchDevices">REST API Reference for SearchDevices Operation</seealso>
        Task<SearchDevicesResponse> SearchDevicesAsync(SearchDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchJobs



        /// <summary>
        /// Searches for Amazon Braket hybrid jobs that match the specified filter values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchJobs service method, as returned by Braket.</returns>
        /// <exception cref="Amazon.Braket.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request failed because of an unknown error.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The API throttling rate limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input request failed to satisfy constraints expected by Amazon Braket.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/SearchJobs">REST API Reference for SearchJobs Operation</seealso>
        Task<SearchJobsResponse> SearchJobsAsync(SearchJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchQuantumTasks



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
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.InternalServiceException">
        /// The request failed because of an unknown error.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ThrottlingException">
        /// The API throttling rate limit is exceeded.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input request failed to satisfy constraints expected by Amazon Braket.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/SearchQuantumTasks">REST API Reference for SearchQuantumTasks Operation</seealso>
        Task<SearchQuantumTasksResponse> SearchQuantumTasksAsync(SearchQuantumTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



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
        /// The request failed because of an unknown error.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input request failed to satisfy constraints expected by Amazon Braket.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



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
        /// The request failed because of an unknown error.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.Braket.Model.ValidationException">
        /// The input request failed to satisfy constraints expected by Amazon Braket.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/braket-2019-09-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonBraketConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonBraketConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonBraketConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonBraketConfig to create AmazonBraketClient");
            }

            return awsCredentials == null ? 
                    new AmazonBraketClient(serviceClientConfig) :
                    new AmazonBraketClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}