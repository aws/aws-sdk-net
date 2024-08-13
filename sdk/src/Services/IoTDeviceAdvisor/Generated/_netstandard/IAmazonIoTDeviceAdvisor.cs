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
 * Do not modify this file. This file is generated from the iotdeviceadvisor-2020-09-18.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoTDeviceAdvisor.Model;

#pragma warning disable CS1570
namespace Amazon.IoTDeviceAdvisor
{
    /// <summary>
    /// <para>Interface for accessing IoTDeviceAdvisor</para>
    ///
    /// Amazon Web Services IoT Core Device Advisor is a cloud-based, fully managed test capability
    /// for validating IoT devices during device software development. Device Advisor provides
    /// pre-built tests that you can use to validate IoT devices for reliable and secure connectivity
    /// with Amazon Web Services IoT Core before deploying devices to production. By using
    /// Device Advisor, you can confirm that your devices can connect to Amazon Web Services
    /// IoT Core, follow security best practices and, if applicable, receive software updates
    /// from IoT Device Management. You can also download signed qualification reports to
    /// submit to the Amazon Web Services Partner Network to get your device qualified for
    /// the Amazon Web Services Partner Device Catalog without the need to send your device
    /// in and wait for it to be tested.
    /// </summary>
    public partial interface IAmazonIoTDeviceAdvisor : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIoTDeviceAdvisorPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateSuiteDefinition



        /// <summary>
        /// Creates a Device Advisor test suite.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateSuiteDefinition</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSuiteDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSuiteDefinition service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/CreateSuiteDefinition">REST API Reference for CreateSuiteDefinition Operation</seealso>
        Task<CreateSuiteDefinitionResponse> CreateSuiteDefinitionAsync(CreateSuiteDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSuiteDefinition



        /// <summary>
        /// Deletes a Device Advisor test suite.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteSuiteDefinition</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSuiteDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSuiteDefinition service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/DeleteSuiteDefinition">REST API Reference for DeleteSuiteDefinition Operation</seealso>
        Task<DeleteSuiteDefinitionResponse> DeleteSuiteDefinitionAsync(DeleteSuiteDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEndpoint



        /// <summary>
        /// Gets information about an Device Advisor endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEndpoint service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends a Resource Not Found exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetEndpoint">REST API Reference for GetEndpoint Operation</seealso>
        Task<GetEndpointResponse> GetEndpointAsync(GetEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSuiteDefinition



        /// <summary>
        /// Gets information about a Device Advisor test suite.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetSuiteDefinition</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSuiteDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSuiteDefinition service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends a Resource Not Found exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteDefinition">REST API Reference for GetSuiteDefinition Operation</seealso>
        Task<GetSuiteDefinitionResponse> GetSuiteDefinitionAsync(GetSuiteDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSuiteRun



        /// <summary>
        /// Gets information about a Device Advisor test suite run.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetSuiteRun</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSuiteRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSuiteRun service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends a Resource Not Found exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteRun">REST API Reference for GetSuiteRun Operation</seealso>
        Task<GetSuiteRunResponse> GetSuiteRunAsync(GetSuiteRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSuiteRunReport



        /// <summary>
        /// Gets a report download link for a successful Device Advisor qualifying test suite
        /// run.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetSuiteRunReport</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSuiteRunReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSuiteRunReport service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends a Resource Not Found exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/GetSuiteRunReport">REST API Reference for GetSuiteRunReport Operation</seealso>
        Task<GetSuiteRunReportResponse> GetSuiteRunReportAsync(GetSuiteRunReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSuiteDefinitions



        /// <summary>
        /// Lists the Device Advisor test suites you have created.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListSuiteDefinitions</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSuiteDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSuiteDefinitions service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListSuiteDefinitions">REST API Reference for ListSuiteDefinitions Operation</seealso>
        Task<ListSuiteDefinitionsResponse> ListSuiteDefinitionsAsync(ListSuiteDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSuiteRuns



        /// <summary>
        /// Lists runs of the specified Device Advisor test suite. You can list all runs of the
        /// test suite, or the runs of a specific version of the test suite.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListSuiteRuns</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSuiteRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSuiteRuns service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListSuiteRuns">REST API Reference for ListSuiteRuns Operation</seealso>
        Task<ListSuiteRunsResponse> ListSuiteRunsAsync(ListSuiteRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags attached to an IoT Device Advisor resource.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListTagsForResource</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends a Resource Not Found exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartSuiteRun



        /// <summary>
        /// Starts a Device Advisor test suite run.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">StartSuiteRun</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSuiteRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSuiteRun service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ConflictException">
        /// Sends a Conflict Exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/StartSuiteRun">REST API Reference for StartSuiteRun Operation</seealso>
        Task<StartSuiteRunResponse> StartSuiteRunAsync(StartSuiteRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopSuiteRun



        /// <summary>
        /// Stops a Device Advisor test suite run that is currently running.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">StopSuiteRun</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopSuiteRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopSuiteRun service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends a Resource Not Found exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/StopSuiteRun">REST API Reference for StopSuiteRun Operation</seealso>
        Task<StopSuiteRunResponse> StopSuiteRunAsync(StopSuiteRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds to and modifies existing tags of an IoT Device Advisor resource.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">TagResource</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends a Resource Not Found exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from an IoT Device Advisor resource.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UntagResource</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ResourceNotFoundException">
        /// Sends a Resource Not Found exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSuiteDefinition



        /// <summary>
        /// Updates a Device Advisor test suite.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateSuiteDefinition</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSuiteDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSuiteDefinition service method, as returned by IoTDeviceAdvisor.</returns>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.InternalServerException">
        /// Sends an Internal Failure exception.
        /// </exception>
        /// <exception cref="Amazon.IoTDeviceAdvisor.Model.ValidationException">
        /// Sends a validation exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotdeviceadvisor-2020-09-18/UpdateSuiteDefinition">REST API Reference for UpdateSuiteDefinition Operation</seealso>
        Task<UpdateSuiteDefinitionResponse> UpdateSuiteDefinitionAsync(UpdateSuiteDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonIoTDeviceAdvisorConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonIoTDeviceAdvisorConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonIoTDeviceAdvisorConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonIoTDeviceAdvisorConfig to create AmazonIoTDeviceAdvisorClient");
            }

            return awsCredentials == null ? 
                    new AmazonIoTDeviceAdvisorClient(serviceClientConfig) :
                    new AmazonIoTDeviceAdvisorClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}