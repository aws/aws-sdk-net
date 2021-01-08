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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoTEvents.Model;

namespace Amazon.IoTEvents
{
    /// <summary>
    /// Interface for accessing IoTEvents
    ///
    /// AWS IoT Events monitors your equipment or device fleets for failures or changes in
    /// operation, and triggers actions when such events occur. You can use AWS IoT Events
    /// API operations to create, read, update, and delete inputs and detector models, and
    /// to list their versions.
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonIoTEvents : IAmazonService, IDisposable
    {
                
        #region  CreateDetectorModel



        /// <summary>
        /// Creates a detector model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDetectorModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDetectorModel service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/CreateDetectorModel">REST API Reference for CreateDetectorModel Operation</seealso>
        Task<CreateDetectorModelResponse> CreateDetectorModelAsync(CreateDetectorModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateInput



        /// <summary>
        /// Creates an input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInput service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/CreateInput">REST API Reference for CreateInput Operation</seealso>
        Task<CreateInputResponse> CreateInputAsync(CreateInputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDetectorModel



        /// <summary>
        /// Deletes a detector model. Any active instances of the detector model are also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDetectorModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDetectorModel service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DeleteDetectorModel">REST API Reference for DeleteDetectorModel Operation</seealso>
        Task<DeleteDetectorModelResponse> DeleteDetectorModelAsync(DeleteDetectorModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteInput



        /// <summary>
        /// Deletes an input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInput service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DeleteInput">REST API Reference for DeleteInput Operation</seealso>
        Task<DeleteInputResponse> DeleteInputAsync(DeleteInputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDetectorModel



        /// <summary>
        /// Describes a detector model. If the <code>version</code> parameter is not specified,
        /// information about the latest version is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetectorModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDetectorModel service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeDetectorModel">REST API Reference for DescribeDetectorModel Operation</seealso>
        Task<DescribeDetectorModelResponse> DescribeDetectorModelAsync(DescribeDetectorModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInput



        /// <summary>
        /// Describes an input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInput service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeInput">REST API Reference for DescribeInput Operation</seealso>
        Task<DescribeInputResponse> DescribeInputAsync(DescribeInputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLoggingOptions



        /// <summary>
        /// Retrieves the current settings of the AWS IoT Events logging options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoggingOptions service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.UnsupportedOperationException">
        /// The requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/DescribeLoggingOptions">REST API Reference for DescribeLoggingOptions Operation</seealso>
        Task<DescribeLoggingOptionsResponse> DescribeLoggingOptionsAsync(DescribeLoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDetectorModels



        /// <summary>
        /// Lists the detector models you have created. Only the metadata associated with each
        /// detector model is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDetectorModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDetectorModels service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListDetectorModels">REST API Reference for ListDetectorModels Operation</seealso>
        Task<ListDetectorModelsResponse> ListDetectorModelsAsync(ListDetectorModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDetectorModelVersions



        /// <summary>
        /// Lists all the versions of a detector model. Only the metadata associated with each
        /// detector model version is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDetectorModelVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDetectorModelVersions service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListDetectorModelVersions">REST API Reference for ListDetectorModelVersions Operation</seealso>
        Task<ListDetectorModelVersionsResponse> ListDetectorModelVersionsAsync(ListDetectorModelVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInputs



        /// <summary>
        /// Lists the inputs you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInputs service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListInputs">REST API Reference for ListInputs Operation</seealso>
        Task<ListInputsResponse> ListInputsAsync(ListInputsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags (metadata) you have assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutLoggingOptions



        /// <summary>
        /// Sets or updates the AWS IoT Events logging options.
        /// 
        ///  
        /// <para>
        /// If you update the value of any <code>loggingOptions</code> field, it takes up to one
        /// minute for the change to take effect. If you change the policy attached to the role
        /// you specified in the <code>roleArn</code> field (for example, to correct an invalid
        /// policy), it takes up to five minutes for that change to take effect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLoggingOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLoggingOptions service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.UnsupportedOperationException">
        /// The requested operation is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/PutLoggingOptions">REST API Reference for PutLoggingOptions Operation</seealso>
        Task<PutLoggingOptionsResponse> PutLoggingOptionsAsync(PutLoggingOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds to or modifies the tags of the given resource. Tags are metadata that can be
        /// used to manage a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.LimitExceededException">
        /// A limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes the given tags (metadata) from the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDetectorModel



        /// <summary>
        /// Updates a detector model. Detectors (instances) spawned by the previous version are
        /// deleted and then re-created as new inputs arrive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDetectorModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDetectorModel service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/UpdateDetectorModel">REST API Reference for UpdateDetectorModel Operation</seealso>
        Task<UpdateDetectorModelResponse> UpdateDetectorModelAsync(UpdateDetectorModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateInput



        /// <summary>
        /// Updates an input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateInput service method, as returned by IoTEvents.</returns>
        /// <exception cref="Amazon.IoTEvents.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.InvalidRequestException">
        /// The request was invalid.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceInUseException">
        /// The resource is in use.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ServiceUnavailableException">
        /// The service is currently unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoTEvents.Model.ThrottlingException">
        /// The request could not be completed due to throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotevents-2018-07-27/UpdateInput">REST API Reference for UpdateInput Operation</seealso>
        Task<UpdateInputResponse> UpdateInputAsync(UpdateInputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}