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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.KafkaConnect.Model;

#pragma warning disable CS1570
namespace Amazon.KafkaConnect
{
    /// <summary>
    /// <para>Interface for accessing KafkaConnect</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonKafkaConnect : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IKafkaConnectPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateConnector



        /// <summary>
        /// Creates a connector using the specified properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnector service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ConflictException">
        /// HTTP Status Code 409: Conflict. A resource with this name already exists. Retry your
        /// request with another name.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        Task<CreateConnectorResponse> CreateConnectorAsync(CreateConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCustomPlugin



        /// <summary>
        /// Creates a custom plugin using the specified properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomPlugin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomPlugin service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ConflictException">
        /// HTTP Status Code 409: Conflict. A resource with this name already exists. Retry your
        /// request with another name.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/CreateCustomPlugin">REST API Reference for CreateCustomPlugin Operation</seealso>
        Task<CreateCustomPluginResponse> CreateCustomPluginAsync(CreateCustomPluginRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWorkerConfiguration



        /// <summary>
        /// Creates a worker configuration using the specified properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkerConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkerConfiguration service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ConflictException">
        /// HTTP Status Code 409: Conflict. A resource with this name already exists. Retry your
        /// request with another name.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/CreateWorkerConfiguration">REST API Reference for CreateWorkerConfiguration Operation</seealso>
        Task<CreateWorkerConfigurationResponse> CreateWorkerConfigurationAsync(CreateWorkerConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteConnector



        /// <summary>
        /// Deletes the specified connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnector service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        Task<DeleteConnectorResponse> DeleteConnectorAsync(DeleteConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCustomPlugin



        /// <summary>
        /// Deletes a custom plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomPlugin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomPlugin service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DeleteCustomPlugin">REST API Reference for DeleteCustomPlugin Operation</seealso>
        Task<DeleteCustomPluginResponse> DeleteCustomPluginAsync(DeleteCustomPluginRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWorkerConfiguration



        /// <summary>
        /// Deletes the specified worker configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkerConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkerConfiguration service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DeleteWorkerConfiguration">REST API Reference for DeleteWorkerConfiguration Operation</seealso>
        Task<DeleteWorkerConfigurationResponse> DeleteWorkerConfigurationAsync(DeleteWorkerConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeConnector



        /// <summary>
        /// Returns summary information about the connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnector service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DescribeConnector">REST API Reference for DescribeConnector Operation</seealso>
        Task<DescribeConnectorResponse> DescribeConnectorAsync(DescribeConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeConnectorOperation



        /// <summary>
        /// Returns information about the specified connector's operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectorOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnectorOperation service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DescribeConnectorOperation">REST API Reference for DescribeConnectorOperation Operation</seealso>
        Task<DescribeConnectorOperationResponse> DescribeConnectorOperationAsync(DescribeConnectorOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCustomPlugin



        /// <summary>
        /// A summary description of the custom plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomPlugin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomPlugin service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DescribeCustomPlugin">REST API Reference for DescribeCustomPlugin Operation</seealso>
        Task<DescribeCustomPluginResponse> DescribeCustomPluginAsync(DescribeCustomPluginRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkerConfiguration



        /// <summary>
        /// Returns information about a worker configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkerConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkerConfiguration service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/DescribeWorkerConfiguration">REST API Reference for DescribeWorkerConfiguration Operation</seealso>
        Task<DescribeWorkerConfigurationResponse> DescribeWorkerConfigurationAsync(DescribeWorkerConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListConnectorOperations



        /// <summary>
        /// Lists information about a connector's operation(s).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectorOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnectorOperations service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListConnectorOperations">REST API Reference for ListConnectorOperations Operation</seealso>
        Task<ListConnectorOperationsResponse> ListConnectorOperationsAsync(ListConnectorOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListConnectors



        /// <summary>
        /// Returns a list of all the connectors in this account and Region. The list is limited
        /// to connectors whose name starts with the specified prefix. The response also includes
        /// a description of each of the listed connectors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnectors service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        Task<ListConnectorsResponse> ListConnectorsAsync(ListConnectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCustomPlugins



        /// <summary>
        /// Returns a list of all of the custom plugins in this account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomPlugins service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomPlugins service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListCustomPlugins">REST API Reference for ListCustomPlugins Operation</seealso>
        Task<ListCustomPluginsResponse> ListCustomPluginsAsync(ListCustomPluginsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists all the tags attached to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWorkerConfigurations



        /// <summary>
        /// Returns a list of all of the worker configurations in this account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkerConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkerConfigurations service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/ListWorkerConfigurations">REST API Reference for ListWorkerConfigurations Operation</seealso>
        Task<ListWorkerConfigurationsResponse> ListWorkerConfigurationsAsync(ListWorkerConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Attaches tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ConflictException">
        /// HTTP Status Code 409: Conflict. A resource with this name already exists. Retry your
        /// request with another name.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateConnector



        /// <summary>
        /// Updates the specified connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConnector service method, as returned by KafkaConnect.</returns>
        /// <exception cref="Amazon.KafkaConnect.Model.BadRequestException">
        /// HTTP Status Code 400: Bad request due to incorrect input. Correct your request and
        /// then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ForbiddenException">
        /// HTTP Status Code 403: Access forbidden. Correct your credentials and then retry your
        /// request.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.InternalServerErrorException">
        /// HTTP Status Code 500: Unexpected internal server error. Retrying your request might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.NotFoundException">
        /// HTTP Status Code 404: Resource not found due to incorrect input. Correct your request
        /// and then retry it.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.ServiceUnavailableException">
        /// HTTP Status Code 503: Service Unavailable. Retrying your request in some time might
        /// resolve the issue.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.TooManyRequestsException">
        /// HTTP Status Code 429: Limit exceeded. Resource limit reached.
        /// </exception>
        /// <exception cref="Amazon.KafkaConnect.Model.UnauthorizedException">
        /// HTTP Status Code 401: Unauthorized request. The provided credentials couldn't be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kafkaconnect-2021-09-14/UpdateConnector">REST API Reference for UpdateConnector Operation</seealso>
        Task<UpdateConnectorResponse> UpdateConnectorAsync(UpdateConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonKafkaConnectConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonKafkaConnectConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonKafkaConnectConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonKafkaConnectConfig to create AmazonKafkaConnectClient");
            }

            return awsCredentials == null ? 
                    new AmazonKafkaConnectClient(serviceClientConfig) :
                    new AmazonKafkaConnectClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}