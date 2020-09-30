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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MediaConnect.Model;

namespace Amazon.MediaConnect
{
    /// <summary>
    /// Interface for accessing MediaConnect
    ///
    /// API for AWS Elemental MediaConnect
    /// </summary>
    public partial interface IAmazonMediaConnect : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMediaConnectPaginatorFactory Paginators { get; }

        
        #region  AddFlowOutputs


        /// <summary>
        /// Adds outputs to an existing flow. You can create up to 50 outputs per flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddFlowOutputs service method.</param>
        /// 
        /// <returns>The response from the AddFlowOutputs service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.AddFlowOutputs420Exception">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddFlowOutputs">REST API Reference for AddFlowOutputs Operation</seealso>
        AddFlowOutputsResponse AddFlowOutputs(AddFlowOutputsRequest request);



        /// <summary>
        /// Adds outputs to an existing flow. You can create up to 50 outputs per flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddFlowOutputs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddFlowOutputs service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.AddFlowOutputs420Exception">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddFlowOutputs">REST API Reference for AddFlowOutputs Operation</seealso>
        Task<AddFlowOutputsResponse> AddFlowOutputsAsync(AddFlowOutputsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AddFlowSources


        /// <summary>
        /// Adds Sources to flow
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddFlowSources service method.</param>
        /// 
        /// <returns>The response from the AddFlowSources service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddFlowSources">REST API Reference for AddFlowSources Operation</seealso>
        AddFlowSourcesResponse AddFlowSources(AddFlowSourcesRequest request);



        /// <summary>
        /// Adds Sources to flow
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddFlowSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddFlowSources service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddFlowSources">REST API Reference for AddFlowSources Operation</seealso>
        Task<AddFlowSourcesResponse> AddFlowSourcesAsync(AddFlowSourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AddFlowVpcInterfaces


        /// <summary>
        /// Adds VPC interfaces to flow
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddFlowVpcInterfaces service method.</param>
        /// 
        /// <returns>The response from the AddFlowVpcInterfaces service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddFlowVpcInterfaces">REST API Reference for AddFlowVpcInterfaces Operation</seealso>
        AddFlowVpcInterfacesResponse AddFlowVpcInterfaces(AddFlowVpcInterfacesRequest request);



        /// <summary>
        /// Adds VPC interfaces to flow
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddFlowVpcInterfaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddFlowVpcInterfaces service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/AddFlowVpcInterfaces">REST API Reference for AddFlowVpcInterfaces Operation</seealso>
        Task<AddFlowVpcInterfacesResponse> AddFlowVpcInterfacesAsync(AddFlowVpcInterfacesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFlow


        /// <summary>
        /// Creates a new flow. The request must include one source. The request optionally can
        /// include outputs (up to 50) and entitlements (up to 50).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlow service method.</param>
        /// 
        /// <returns>The response from the CreateFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.CreateFlow420Exception">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateFlow">REST API Reference for CreateFlow Operation</seealso>
        CreateFlowResponse CreateFlow(CreateFlowRequest request);



        /// <summary>
        /// Creates a new flow. The request must include one source. The request optionally can
        /// include outputs (up to 50) and entitlements (up to 50).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.CreateFlow420Exception">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/CreateFlow">REST API Reference for CreateFlow Operation</seealso>
        Task<CreateFlowResponse> CreateFlowAsync(CreateFlowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFlow


        /// <summary>
        /// Deletes a flow. Before you can delete a flow, you must stop the flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlow service method.</param>
        /// 
        /// <returns>The response from the DeleteFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteFlow">REST API Reference for DeleteFlow Operation</seealso>
        DeleteFlowResponse DeleteFlow(DeleteFlowRequest request);



        /// <summary>
        /// Deletes a flow. Before you can delete a flow, you must stop the flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DeleteFlow">REST API Reference for DeleteFlow Operation</seealso>
        Task<DeleteFlowResponse> DeleteFlowAsync(DeleteFlowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeFlow


        /// <summary>
        /// Displays the details of a flow. The response includes the flow ARN, name, and Availability
        /// Zone, as well as details about the source, outputs, and entitlements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlow service method.</param>
        /// 
        /// <returns>The response from the DescribeFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeFlow">REST API Reference for DescribeFlow Operation</seealso>
        DescribeFlowResponse DescribeFlow(DescribeFlowRequest request);



        /// <summary>
        /// Displays the details of a flow. The response includes the flow ARN, name, and Availability
        /// Zone, as well as details about the source, outputs, and entitlements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeFlow">REST API Reference for DescribeFlow Operation</seealso>
        Task<DescribeFlowResponse> DescribeFlowAsync(DescribeFlowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeOffering


        /// <summary>
        /// Displays the details of an offering. The response includes the offering description,
        /// duration, outbound bandwidth, price, and Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOffering service method.</param>
        /// 
        /// <returns>The response from the DescribeOffering service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeOffering">REST API Reference for DescribeOffering Operation</seealso>
        DescribeOfferingResponse DescribeOffering(DescribeOfferingRequest request);



        /// <summary>
        /// Displays the details of an offering. The response includes the offering description,
        /// duration, outbound bandwidth, price, and Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOffering service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOffering service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeOffering">REST API Reference for DescribeOffering Operation</seealso>
        Task<DescribeOfferingResponse> DescribeOfferingAsync(DescribeOfferingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeReservation


        /// <summary>
        /// Displays the details of a reservation. The response includes the reservation name,
        /// state, start date and time, and the details of the offering that make up the rest
        /// of the reservation (such as price, duration, and outbound bandwidth).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservation service method.</param>
        /// 
        /// <returns>The response from the DescribeReservation service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeReservation">REST API Reference for DescribeReservation Operation</seealso>
        DescribeReservationResponse DescribeReservation(DescribeReservationRequest request);



        /// <summary>
        /// Displays the details of a reservation. The response includes the reservation name,
        /// state, start date and time, and the details of the offering that make up the rest
        /// of the reservation (such as price, duration, and outbound bandwidth).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservation service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/DescribeReservation">REST API Reference for DescribeReservation Operation</seealso>
        Task<DescribeReservationResponse> DescribeReservationAsync(DescribeReservationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GrantFlowEntitlements


        /// <summary>
        /// Grants entitlements to an existing flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GrantFlowEntitlements service method.</param>
        /// 
        /// <returns>The response from the GrantFlowEntitlements service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.GrantFlowEntitlements420Exception">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GrantFlowEntitlements">REST API Reference for GrantFlowEntitlements Operation</seealso>
        GrantFlowEntitlementsResponse GrantFlowEntitlements(GrantFlowEntitlementsRequest request);



        /// <summary>
        /// Grants entitlements to an existing flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GrantFlowEntitlements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GrantFlowEntitlements service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.GrantFlowEntitlements420Exception">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/GrantFlowEntitlements">REST API Reference for GrantFlowEntitlements Operation</seealso>
        Task<GrantFlowEntitlementsResponse> GrantFlowEntitlementsAsync(GrantFlowEntitlementsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEntitlements


        /// <summary>
        /// Displays a list of all entitlements that have been granted to this account. This request
        /// returns 20 results per page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntitlements service method.</param>
        /// 
        /// <returns>The response from the ListEntitlements service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListEntitlements">REST API Reference for ListEntitlements Operation</seealso>
        ListEntitlementsResponse ListEntitlements(ListEntitlementsRequest request);



        /// <summary>
        /// Displays a list of all entitlements that have been granted to this account. This request
        /// returns 20 results per page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntitlements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEntitlements service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListEntitlements">REST API Reference for ListEntitlements Operation</seealso>
        Task<ListEntitlementsResponse> ListEntitlementsAsync(ListEntitlementsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFlows


        /// <summary>
        /// Displays a list of flows that are associated with this account. This request returns
        /// a paginated result.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlows service method.</param>
        /// 
        /// <returns>The response from the ListFlows service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListFlows">REST API Reference for ListFlows Operation</seealso>
        ListFlowsResponse ListFlows(ListFlowsRequest request);



        /// <summary>
        /// Displays a list of flows that are associated with this account. This request returns
        /// a paginated result.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFlows service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListFlows">REST API Reference for ListFlows Operation</seealso>
        Task<ListFlowsResponse> ListFlowsAsync(ListFlowsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListOfferings


        /// <summary>
        /// Displays a list of all offerings that are available to this account in the current
        /// AWS Region. If you have an active reservation (which means you've purchased an offering
        /// that has already started and hasn't expired yet), your account isn't eligible for
        /// other offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOfferings service method.</param>
        /// 
        /// <returns>The response from the ListOfferings service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListOfferings">REST API Reference for ListOfferings Operation</seealso>
        ListOfferingsResponse ListOfferings(ListOfferingsRequest request);



        /// <summary>
        /// Displays a list of all offerings that are available to this account in the current
        /// AWS Region. If you have an active reservation (which means you've purchased an offering
        /// that has already started and hasn't expired yet), your account isn't eligible for
        /// other offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOfferings service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListOfferings">REST API Reference for ListOfferings Operation</seealso>
        Task<ListOfferingsResponse> ListOfferingsAsync(ListOfferingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListReservations


        /// <summary>
        /// Displays a list of all reservations that have been purchased by this account in the
        /// current AWS Region. This list includes all reservations in all states (such as active
        /// and expired).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReservations service method.</param>
        /// 
        /// <returns>The response from the ListReservations service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListReservations">REST API Reference for ListReservations Operation</seealso>
        ListReservationsResponse ListReservations(ListReservationsRequest request);



        /// <summary>
        /// Displays a list of all reservations that have been purchased by this account in the
        /// current AWS Region. This list includes all reservations in all states (such as active
        /// and expired).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReservations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReservations service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListReservations">REST API Reference for ListReservations Operation</seealso>
        Task<ListReservationsResponse> ListReservationsAsync(ListReservationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List all tags on an AWS Elemental MediaConnect resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// List all tags on an AWS Elemental MediaConnect resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PurchaseOffering


        /// <summary>
        /// Submits a request to purchase an offering. If you already have an active reservation,
        /// you can't purchase another offering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseOffering service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/PurchaseOffering">REST API Reference for PurchaseOffering Operation</seealso>
        PurchaseOfferingResponse PurchaseOffering(PurchaseOfferingRequest request);



        /// <summary>
        /// Submits a request to purchase an offering. If you already have an active reservation,
        /// you can't purchase another offering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseOffering service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurchaseOffering service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/PurchaseOffering">REST API Reference for PurchaseOffering Operation</seealso>
        Task<PurchaseOfferingResponse> PurchaseOfferingAsync(PurchaseOfferingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveFlowOutput


        /// <summary>
        /// Removes an output from an existing flow. This request can be made only on an output
        /// that does not have an entitlement associated with it. If the output has an entitlement,
        /// you must revoke the entitlement instead. When an entitlement is revoked from a flow,
        /// the service automatically removes the associated output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFlowOutput service method.</param>
        /// 
        /// <returns>The response from the RemoveFlowOutput service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveFlowOutput">REST API Reference for RemoveFlowOutput Operation</seealso>
        RemoveFlowOutputResponse RemoveFlowOutput(RemoveFlowOutputRequest request);



        /// <summary>
        /// Removes an output from an existing flow. This request can be made only on an output
        /// that does not have an entitlement associated with it. If the output has an entitlement,
        /// you must revoke the entitlement instead. When an entitlement is revoked from a flow,
        /// the service automatically removes the associated output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFlowOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveFlowOutput service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveFlowOutput">REST API Reference for RemoveFlowOutput Operation</seealso>
        Task<RemoveFlowOutputResponse> RemoveFlowOutputAsync(RemoveFlowOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveFlowSource


        /// <summary>
        /// Removes a source from an existing flow. This request can be made only if there is
        /// more than one source on the flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFlowSource service method.</param>
        /// 
        /// <returns>The response from the RemoveFlowSource service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveFlowSource">REST API Reference for RemoveFlowSource Operation</seealso>
        RemoveFlowSourceResponse RemoveFlowSource(RemoveFlowSourceRequest request);



        /// <summary>
        /// Removes a source from an existing flow. This request can be made only if there is
        /// more than one source on the flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFlowSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveFlowSource service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveFlowSource">REST API Reference for RemoveFlowSource Operation</seealso>
        Task<RemoveFlowSourceResponse> RemoveFlowSourceAsync(RemoveFlowSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveFlowVpcInterface


        /// <summary>
        /// Removes a VPC Interface from an existing flow. This request can be made only on a
        /// VPC interface that does not have a Source or Output associated with it. If the VPC
        /// interface is referenced by a Source or Output, you must first delete or update the
        /// Source or Output to no longer reference the VPC interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFlowVpcInterface service method.</param>
        /// 
        /// <returns>The response from the RemoveFlowVpcInterface service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveFlowVpcInterface">REST API Reference for RemoveFlowVpcInterface Operation</seealso>
        RemoveFlowVpcInterfaceResponse RemoveFlowVpcInterface(RemoveFlowVpcInterfaceRequest request);



        /// <summary>
        /// Removes a VPC Interface from an existing flow. This request can be made only on a
        /// VPC interface that does not have a Source or Output associated with it. If the VPC
        /// interface is referenced by a Source or Output, you must first delete or update the
        /// Source or Output to no longer reference the VPC interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveFlowVpcInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveFlowVpcInterface service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RemoveFlowVpcInterface">REST API Reference for RemoveFlowVpcInterface Operation</seealso>
        Task<RemoveFlowVpcInterfaceResponse> RemoveFlowVpcInterfaceAsync(RemoveFlowVpcInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RevokeFlowEntitlement


        /// <summary>
        /// Revokes an entitlement from a flow. Once an entitlement is revoked, the content becomes
        /// unavailable to the subscriber and the associated output is removed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeFlowEntitlement service method.</param>
        /// 
        /// <returns>The response from the RevokeFlowEntitlement service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RevokeFlowEntitlement">REST API Reference for RevokeFlowEntitlement Operation</seealso>
        RevokeFlowEntitlementResponse RevokeFlowEntitlement(RevokeFlowEntitlementRequest request);



        /// <summary>
        /// Revokes an entitlement from a flow. Once an entitlement is revoked, the content becomes
        /// unavailable to the subscriber and the associated output is removed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeFlowEntitlement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeFlowEntitlement service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/RevokeFlowEntitlement">REST API Reference for RevokeFlowEntitlement Operation</seealso>
        Task<RevokeFlowEntitlementResponse> RevokeFlowEntitlementAsync(RevokeFlowEntitlementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartFlow


        /// <summary>
        /// Starts a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFlow service method.</param>
        /// 
        /// <returns>The response from the StartFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StartFlow">REST API Reference for StartFlow Operation</seealso>
        StartFlowResponse StartFlow(StartFlowRequest request);



        /// <summary>
        /// Starts a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StartFlow">REST API Reference for StartFlow Operation</seealso>
        Task<StartFlowResponse> StartFlowAsync(StartFlowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopFlow


        /// <summary>
        /// Stops a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopFlow service method.</param>
        /// 
        /// <returns>The response from the StopFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StopFlow">REST API Reference for StopFlow Operation</seealso>
        StopFlowResponse StopFlow(StopFlowRequest request);



        /// <summary>
        /// Stops a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/StopFlow">REST API Reference for StopFlow Operation</seealso>
        Task<StopFlowResponse> StopFlowAsync(StopFlowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates the specified tags to a resource with the specified resourceArn. If existing
        /// tags on a resource are not specified in the request parameters, they are not changed.
        /// When a resource is deleted, the tags associated with that resource are deleted as
        /// well.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Associates the specified tags to a resource with the specified resourceArn. If existing
        /// tags on a resource are not specified in the request parameters, they are not changed.
        /// When a resource is deleted, the tags associated with that resource are deleted as
        /// well.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Deletes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFlow


        /// <summary>
        /// Updates flow
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlow service method.</param>
        /// 
        /// <returns>The response from the UpdateFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlow">REST API Reference for UpdateFlow Operation</seealso>
        UpdateFlowResponse UpdateFlow(UpdateFlowRequest request);



        /// <summary>
        /// Updates flow
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFlow service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlow">REST API Reference for UpdateFlow Operation</seealso>
        Task<UpdateFlowResponse> UpdateFlowAsync(UpdateFlowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFlowEntitlement


        /// <summary>
        /// You can change an entitlement's description, subscribers, and encryption. If you change
        /// the subscribers, the service will remove the outputs that are are used by the subscribers
        /// that are removed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowEntitlement service method.</param>
        /// 
        /// <returns>The response from the UpdateFlowEntitlement service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowEntitlement">REST API Reference for UpdateFlowEntitlement Operation</seealso>
        UpdateFlowEntitlementResponse UpdateFlowEntitlement(UpdateFlowEntitlementRequest request);



        /// <summary>
        /// You can change an entitlement's description, subscribers, and encryption. If you change
        /// the subscribers, the service will remove the outputs that are are used by the subscribers
        /// that are removed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowEntitlement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFlowEntitlement service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowEntitlement">REST API Reference for UpdateFlowEntitlement Operation</seealso>
        Task<UpdateFlowEntitlementResponse> UpdateFlowEntitlementAsync(UpdateFlowEntitlementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFlowOutput


        /// <summary>
        /// Updates an existing flow output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowOutput service method.</param>
        /// 
        /// <returns>The response from the UpdateFlowOutput service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowOutput">REST API Reference for UpdateFlowOutput Operation</seealso>
        UpdateFlowOutputResponse UpdateFlowOutput(UpdateFlowOutputRequest request);



        /// <summary>
        /// Updates an existing flow output.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFlowOutput service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowOutput">REST API Reference for UpdateFlowOutput Operation</seealso>
        Task<UpdateFlowOutputResponse> UpdateFlowOutputAsync(UpdateFlowOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFlowSource


        /// <summary>
        /// Updates the source of a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowSource service method.</param>
        /// 
        /// <returns>The response from the UpdateFlowSource service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowSource">REST API Reference for UpdateFlowSource Operation</seealso>
        UpdateFlowSourceResponse UpdateFlowSource(UpdateFlowSourceRequest request);



        /// <summary>
        /// Updates the source of a flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFlowSource service method, as returned by MediaConnect.</returns>
        /// <exception cref="Amazon.MediaConnect.Model.BadRequestException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ForbiddenException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.InternalServerErrorException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.NotFoundException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.ServiceUnavailableException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <exception cref="Amazon.MediaConnect.Model.TooManyRequestsException">
        /// Exception raised by AWS Elemental MediaConnect. See the error message and documentation
        /// for the operation for more information on the cause of this exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mediaconnect-2018-11-14/UpdateFlowSource">REST API Reference for UpdateFlowSource Operation</seealso>
        Task<UpdateFlowSourceResponse> UpdateFlowSourceAsync(UpdateFlowSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}