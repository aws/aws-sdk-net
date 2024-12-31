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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.APIGateway.Model;

#pragma warning disable CS1570
namespace Amazon.APIGateway
{
    /// <summary>
    /// <para>Interface for accessing APIGateway</para>
    ///
    /// Amazon API Gateway 
    /// <para>
    /// Amazon API Gateway helps developers deliver robust, secure, and scalable mobile and
    /// web application back ends. API Gateway allows developers to securely connect mobile
    /// and web applications to APIs that run on Lambda, Amazon EC2, or other publicly addressable
    /// web services that are hosted outside of AWS.
    /// </para>
    /// </summary>
    public partial interface IAmazonAPIGateway : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAPIGatewayPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateApiKey



        /// <summary>
        /// Create an ApiKey resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApiKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateApiKey">REST API Reference for CreateApiKey Operation</seealso>
        Task<CreateApiKeyResponse> CreateApiKeyAsync(CreateApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAuthorizer



        /// <summary>
        /// Adds a new Authorizer resource to an existing RestApi resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateAuthorizer">REST API Reference for CreateAuthorizer Operation</seealso>
        Task<CreateAuthorizerResponse> CreateAuthorizerAsync(CreateAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateBasePathMapping



        /// <summary>
        /// Creates a new BasePathMapping resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBasePathMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBasePathMapping service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateBasePathMapping">REST API Reference for CreateBasePathMapping Operation</seealso>
        Task<CreateBasePathMappingResponse> CreateBasePathMappingAsync(CreateBasePathMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDeployment



        /// <summary>
        /// Creates a Deployment resource, which makes a specified RestApi callable over the internet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// The requested service is not available. For details see the accompanying error message.
        /// Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDocumentationPart



        /// <summary>
        /// Creates a documentation part.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDocumentationPart service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDocumentationPart service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDocumentationPart">REST API Reference for CreateDocumentationPart Operation</seealso>
        Task<CreateDocumentationPartResponse> CreateDocumentationPartAsync(CreateDocumentationPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDocumentationVersion



        /// <summary>
        /// Creates a documentation version
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDocumentationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDocumentationVersion service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDocumentationVersion">REST API Reference for CreateDocumentationVersion Operation</seealso>
        Task<CreateDocumentationVersionResponse> CreateDocumentationVersionAsync(CreateDocumentationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDomainName



        /// <summary>
        /// Creates a new domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomainName service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDomainName">REST API Reference for CreateDomainName Operation</seealso>
        Task<CreateDomainNameResponse> CreateDomainNameAsync(CreateDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDomainNameAccessAssociation



        /// <summary>
        /// Creates a domain name access association resource between an access association source
        /// and a private custom domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainNameAccessAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomainNameAccessAssociation service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateDomainNameAccessAssociation">REST API Reference for CreateDomainNameAccessAssociation Operation</seealso>
        Task<CreateDomainNameAccessAssociationResponse> CreateDomainNameAccessAssociationAsync(CreateDomainNameAccessAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateModel



        /// <summary>
        /// Adds a new Model resource to an existing RestApi resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateModel service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateModel">REST API Reference for CreateModel Operation</seealso>
        Task<CreateModelResponse> CreateModelAsync(CreateModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRequestValidator



        /// <summary>
        /// Creates a RequestValidator of a given RestApi.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRequestValidator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRequestValidator service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateRequestValidator">REST API Reference for CreateRequestValidator Operation</seealso>
        Task<CreateRequestValidatorResponse> CreateRequestValidatorAsync(CreateRequestValidatorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateResource



        /// <summary>
        /// Creates a Resource resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateResource">REST API Reference for CreateResource Operation</seealso>
        Task<CreateResourceResponse> CreateResourceAsync(CreateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRestApi



        /// <summary>
        /// Creates a new RestApi resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRestApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateRestApi">REST API Reference for CreateRestApi Operation</seealso>
        Task<CreateRestApiResponse> CreateRestApiAsync(CreateRestApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateStage



        /// <summary>
        /// Creates a new Stage resource that references a pre-existing Deployment for the API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateStage">REST API Reference for CreateStage Operation</seealso>
        Task<CreateStageResponse> CreateStageAsync(CreateStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUsagePlan



        /// <summary>
        /// Creates a usage plan with the throttle and quota limits, as well as the associated
        /// API stages, specified in the payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUsagePlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUsagePlan service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateUsagePlan">REST API Reference for CreateUsagePlan Operation</seealso>
        Task<CreateUsagePlanResponse> CreateUsagePlanAsync(CreateUsagePlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUsagePlanKey



        /// <summary>
        /// Creates a usage plan key for adding an existing API key to a usage plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUsagePlanKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUsagePlanKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateUsagePlanKey">REST API Reference for CreateUsagePlanKey Operation</seealso>
        Task<CreateUsagePlanKeyResponse> CreateUsagePlanKeyAsync(CreateUsagePlanKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVpcLink



        /// <summary>
        /// Creates a VPC link, under the caller's account in a selected region, in an asynchronous
        /// operation that typically takes 2-4 minutes to complete and become operational. The
        /// caller must have permissions to create and update VPC Endpoint services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpcLink service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/CreateVpcLink">REST API Reference for CreateVpcLink Operation</seealso>
        Task<CreateVpcLinkResponse> CreateVpcLinkAsync(CreateVpcLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApiKey



        /// <summary>
        /// Deletes the ApiKey resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApiKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteApiKey">REST API Reference for DeleteApiKey Operation</seealso>
        Task<DeleteApiKeyResponse> DeleteApiKeyAsync(DeleteApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAuthorizer



        /// <summary>
        /// Deletes an existing Authorizer resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteAuthorizer">REST API Reference for DeleteAuthorizer Operation</seealso>
        Task<DeleteAuthorizerResponse> DeleteAuthorizerAsync(DeleteAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBasePathMapping



        /// <summary>
        /// Deletes the BasePathMapping resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBasePathMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBasePathMapping service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteBasePathMapping">REST API Reference for DeleteBasePathMapping Operation</seealso>
        Task<DeleteBasePathMappingResponse> DeleteBasePathMappingAsync(DeleteBasePathMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteClientCertificate



        /// <summary>
        /// Deletes the ClientCertificate resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClientCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteClientCertificate">REST API Reference for DeleteClientCertificate Operation</seealso>
        Task<DeleteClientCertificateResponse> DeleteClientCertificateAsync(DeleteClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDeployment



        /// <summary>
        /// Deletes a Deployment resource. Deleting a deployment will only succeed if there are
        /// no Stage resources associated with it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDeployment service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDeployment">REST API Reference for DeleteDeployment Operation</seealso>
        Task<DeleteDeploymentResponse> DeleteDeploymentAsync(DeleteDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDocumentationPart



        /// <summary>
        /// Deletes a documentation part
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocumentationPart service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDocumentationPart service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDocumentationPart">REST API Reference for DeleteDocumentationPart Operation</seealso>
        Task<DeleteDocumentationPartResponse> DeleteDocumentationPartAsync(DeleteDocumentationPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDocumentationVersion



        /// <summary>
        /// Deletes a documentation version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocumentationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDocumentationVersion service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDocumentationVersion">REST API Reference for DeleteDocumentationVersion Operation</seealso>
        Task<DeleteDocumentationVersionResponse> DeleteDocumentationVersionAsync(DeleteDocumentationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDomainName



        /// <summary>
        /// Deletes the DomainName resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomainName service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDomainName">REST API Reference for DeleteDomainName Operation</seealso>
        Task<DeleteDomainNameResponse> DeleteDomainNameAsync(DeleteDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDomainNameAccessAssociation



        /// <summary>
        /// Deletes the DomainNameAccessAssociation resource.
        /// 
        ///  
        /// <para>
        /// Only the AWS account that created the DomainNameAccessAssociation resource can delete
        /// it. To stop an access association source in another AWS account from accessing your
        /// private custom domain name, use the RejectDomainNameAccessAssociation operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainNameAccessAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomainNameAccessAssociation service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteDomainNameAccessAssociation">REST API Reference for DeleteDomainNameAccessAssociation Operation</seealso>
        Task<DeleteDomainNameAccessAssociationResponse> DeleteDomainNameAccessAssociationAsync(DeleteDomainNameAccessAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGatewayResponse



        /// <summary>
        /// Clears any customization of a GatewayResponse of a specified response type on the
        /// given RestApi and resets it with the default settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGatewayResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGatewayResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteGatewayResponse">REST API Reference for DeleteGatewayResponse Operation</seealso>
        Task<DeleteGatewayResponseResponse> DeleteGatewayResponseAsync(DeleteGatewayResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteIntegration



        /// <summary>
        /// Represents a delete integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        Task<DeleteIntegrationResponse> DeleteIntegrationAsync(DeleteIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteIntegrationResponse



        /// <summary>
        /// Represents a delete integration response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegrationResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIntegrationResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteIntegrationResponse">REST API Reference for DeleteIntegrationResponse Operation</seealso>
        Task<DeleteIntegrationResponseResponse> DeleteIntegrationResponseAsync(DeleteIntegrationResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMethod



        /// <summary>
        /// Deletes an existing Method resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMethod service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMethod service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteMethod">REST API Reference for DeleteMethod Operation</seealso>
        Task<DeleteMethodResponse> DeleteMethodAsync(DeleteMethodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMethodResponse



        /// <summary>
        /// Deletes an existing MethodResponse resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMethodResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMethodResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteMethodResponse">REST API Reference for DeleteMethodResponse Operation</seealso>
        Task<DeleteMethodResponseResponse> DeleteMethodResponseAsync(DeleteMethodResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteModel



        /// <summary>
        /// Deletes a model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteModel service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRequestValidator



        /// <summary>
        /// Deletes a RequestValidator of a given RestApi.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRequestValidator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRequestValidator service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteRequestValidator">REST API Reference for DeleteRequestValidator Operation</seealso>
        Task<DeleteRequestValidatorResponse> DeleteRequestValidatorAsync(DeleteRequestValidatorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteResource



        /// <summary>
        /// Deletes a Resource resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        Task<DeleteResourceResponse> DeleteResourceAsync(DeleteResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRestApi



        /// <summary>
        /// Deletes the specified API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRestApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteRestApi">REST API Reference for DeleteRestApi Operation</seealso>
        Task<DeleteRestApiResponse> DeleteRestApiAsync(DeleteRestApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteStage



        /// <summary>
        /// Deletes a Stage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteStage">REST API Reference for DeleteStage Operation</seealso>
        Task<DeleteStageResponse> DeleteStageAsync(DeleteStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUsagePlan



        /// <summary>
        /// Deletes a usage plan of a given plan Id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsagePlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUsagePlan service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteUsagePlan">REST API Reference for DeleteUsagePlan Operation</seealso>
        Task<DeleteUsagePlanResponse> DeleteUsagePlanAsync(DeleteUsagePlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUsagePlanKey



        /// <summary>
        /// Deletes a usage plan key and remove the underlying API key from the associated usage
        /// plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsagePlanKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUsagePlanKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteUsagePlanKey">REST API Reference for DeleteUsagePlanKey Operation</seealso>
        Task<DeleteUsagePlanKeyResponse> DeleteUsagePlanKeyAsync(DeleteUsagePlanKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVpcLink



        /// <summary>
        /// Deletes an existing VpcLink of a specified identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpcLink service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/DeleteVpcLink">REST API Reference for DeleteVpcLink Operation</seealso>
        Task<DeleteVpcLinkResponse> DeleteVpcLinkAsync(DeleteVpcLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  FlushStageAuthorizersCache



        /// <summary>
        /// Flushes all authorizer cache entries on a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlushStageAuthorizersCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FlushStageAuthorizersCache service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/FlushStageAuthorizersCache">REST API Reference for FlushStageAuthorizersCache Operation</seealso>
        Task<FlushStageAuthorizersCacheResponse> FlushStageAuthorizersCacheAsync(FlushStageAuthorizersCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  FlushStageCache



        /// <summary>
        /// Flushes a stage's cache.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlushStageCache service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FlushStageCache service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/FlushStageCache">REST API Reference for FlushStageCache Operation</seealso>
        Task<FlushStageCacheResponse> FlushStageCacheAsync(FlushStageCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GenerateClientCertificate



        /// <summary>
        /// Generates a ClientCertificate resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateClientCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GenerateClientCertificate">REST API Reference for GenerateClientCertificate Operation</seealso>
        Task<GenerateClientCertificateResponse> GenerateClientCertificateAsync(GenerateClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAccount



        /// <summary>
        /// Gets information about the current Account resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccount service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetAccount">REST API Reference for GetAccount Operation</seealso>
        Task<GetAccountResponse> GetAccountAsync(GetAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApiKey



        /// <summary>
        /// Gets information about the current ApiKey resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApiKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetApiKey">REST API Reference for GetApiKey Operation</seealso>
        Task<GetApiKeyResponse> GetApiKeyAsync(GetApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApiKeys



        /// <summary>
        /// Gets information about the current ApiKeys resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApiKeys service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetApiKeys">REST API Reference for GetApiKeys Operation</seealso>
        Task<GetApiKeysResponse> GetApiKeysAsync(GetApiKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAuthorizer



        /// <summary>
        /// Describe an existing Authorizer resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetAuthorizer">REST API Reference for GetAuthorizer Operation</seealso>
        Task<GetAuthorizerResponse> GetAuthorizerAsync(GetAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAuthorizers



        /// <summary>
        /// Describe an existing Authorizers resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAuthorizers service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetAuthorizers">REST API Reference for GetAuthorizers Operation</seealso>
        Task<GetAuthorizersResponse> GetAuthorizersAsync(GetAuthorizersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBasePathMapping



        /// <summary>
        /// Describe a BasePathMapping resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBasePathMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBasePathMapping service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetBasePathMapping">REST API Reference for GetBasePathMapping Operation</seealso>
        Task<GetBasePathMappingResponse> GetBasePathMappingAsync(GetBasePathMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBasePathMappings



        /// <summary>
        /// Represents a collection of BasePathMapping resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBasePathMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBasePathMappings service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetBasePathMappings">REST API Reference for GetBasePathMappings Operation</seealso>
        Task<GetBasePathMappingsResponse> GetBasePathMappingsAsync(GetBasePathMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetClientCertificate



        /// <summary>
        /// Gets information about the current ClientCertificate resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetClientCertificate">REST API Reference for GetClientCertificate Operation</seealso>
        Task<GetClientCertificateResponse> GetClientCertificateAsync(GetClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetClientCertificates



        /// <summary>
        /// Gets a collection of ClientCertificate resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetClientCertificates service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetClientCertificates">REST API Reference for GetClientCertificates Operation</seealso>
        Task<GetClientCertificatesResponse> GetClientCertificatesAsync(GetClientCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDeployment



        /// <summary>
        /// Gets information about a Deployment resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// The requested service is not available. For details see the accompanying error message.
        /// Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDeployment">REST API Reference for GetDeployment Operation</seealso>
        Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDeployments



        /// <summary>
        /// Gets information about a Deployments collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeployments service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// The requested service is not available. For details see the accompanying error message.
        /// Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDeployments">REST API Reference for GetDeployments Operation</seealso>
        Task<GetDeploymentsResponse> GetDeploymentsAsync(GetDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDocumentationPart



        /// <summary>
        /// Gets a documentation part.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationPart service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDocumentationPart service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationPart">REST API Reference for GetDocumentationPart Operation</seealso>
        Task<GetDocumentationPartResponse> GetDocumentationPartAsync(GetDocumentationPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDocumentationParts



        /// <summary>
        /// Gets documentation parts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationParts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDocumentationParts service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationParts">REST API Reference for GetDocumentationParts Operation</seealso>
        Task<GetDocumentationPartsResponse> GetDocumentationPartsAsync(GetDocumentationPartsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDocumentationVersion



        /// <summary>
        /// Gets a documentation version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDocumentationVersion service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationVersion">REST API Reference for GetDocumentationVersion Operation</seealso>
        Task<GetDocumentationVersionResponse> GetDocumentationVersionAsync(GetDocumentationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDocumentationVersions



        /// <summary>
        /// Gets documentation versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDocumentationVersions service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDocumentationVersions">REST API Reference for GetDocumentationVersions Operation</seealso>
        Task<GetDocumentationVersionsResponse> GetDocumentationVersionsAsync(GetDocumentationVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDomainName



        /// <summary>
        /// Represents a domain name that is contained in a simpler, more intuitive URL that can
        /// be called.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainName service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDomainName">REST API Reference for GetDomainName Operation</seealso>
        Task<GetDomainNameResponse> GetDomainNameAsync(GetDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDomainNameAccessAssociations



        /// <summary>
        /// Represents a collection on DomainNameAccessAssociations resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainNameAccessAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainNameAccessAssociations service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDomainNameAccessAssociations">REST API Reference for GetDomainNameAccessAssociations Operation</seealso>
        Task<GetDomainNameAccessAssociationsResponse> GetDomainNameAccessAssociationsAsync(GetDomainNameAccessAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDomainNames



        /// <summary>
        /// Represents a collection of DomainName resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainNames service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainNames service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetDomainNames">REST API Reference for GetDomainNames Operation</seealso>
        Task<GetDomainNamesResponse> GetDomainNamesAsync(GetDomainNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetExport



        /// <summary>
        /// Exports a deployed version of a RestApi in a specified format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExport service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetExport">REST API Reference for GetExport Operation</seealso>
        Task<GetExportResponse> GetExportAsync(GetExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGatewayResponse



        /// <summary>
        /// Gets a GatewayResponse of a specified response type on the given RestApi.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGatewayResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGatewayResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetGatewayResponse">REST API Reference for GetGatewayResponse Operation</seealso>
        Task<GetGatewayResponseResponse> GetGatewayResponseAsync(GetGatewayResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGatewayResponses



        /// <summary>
        /// Gets the GatewayResponses collection on the given RestApi. If an API developer has
        /// not added any definitions for gateway responses, the result will be the API Gateway-generated
        /// default GatewayResponses collection for the supported response types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGatewayResponses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGatewayResponses service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetGatewayResponses">REST API Reference for GetGatewayResponses Operation</seealso>
        Task<GetGatewayResponsesResponse> GetGatewayResponsesAsync(GetGatewayResponsesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetIntegration



        /// <summary>
        /// Get the integration settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        Task<GetIntegrationResponse> GetIntegrationAsync(GetIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetIntegrationResponse



        /// <summary>
        /// Represents a get integration response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIntegrationResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetIntegrationResponse">REST API Reference for GetIntegrationResponse Operation</seealso>
        Task<GetIntegrationResponseResponse> GetIntegrationResponseAsync(GetIntegrationResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMethod



        /// <summary>
        /// Describe an existing Method resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMethod service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMethod service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetMethod">REST API Reference for GetMethod Operation</seealso>
        Task<GetMethodResponse> GetMethodAsync(GetMethodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMethodResponse



        /// <summary>
        /// Describes a MethodResponse resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMethodResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMethodResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetMethodResponse">REST API Reference for GetMethodResponse Operation</seealso>
        Task<GetMethodResponseResponse> GetMethodResponseAsync(GetMethodResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetModel



        /// <summary>
        /// Describes an existing model defined for a RestApi resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetModel service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetModel">REST API Reference for GetModel Operation</seealso>
        Task<GetModelResponse> GetModelAsync(GetModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetModels



        /// <summary>
        /// Describes existing Models defined for a RestApi resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetModels service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetModels">REST API Reference for GetModels Operation</seealso>
        Task<GetModelsResponse> GetModelsAsync(GetModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetModelTemplate



        /// <summary>
        /// Generates a sample mapping template that can be used to transform a payload into the
        /// structure of a model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetModelTemplate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetModelTemplate">REST API Reference for GetModelTemplate Operation</seealso>
        Task<GetModelTemplateResponse> GetModelTemplateAsync(GetModelTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRequestValidator



        /// <summary>
        /// Gets a RequestValidator of a given RestApi.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequestValidator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRequestValidator service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRequestValidator">REST API Reference for GetRequestValidator Operation</seealso>
        Task<GetRequestValidatorResponse> GetRequestValidatorAsync(GetRequestValidatorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRequestValidators



        /// <summary>
        /// Gets the RequestValidators collection of a given RestApi.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRequestValidators service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRequestValidators service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRequestValidators">REST API Reference for GetRequestValidators Operation</seealso>
        Task<GetRequestValidatorsResponse> GetRequestValidatorsAsync(GetRequestValidatorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetResource



        /// <summary>
        /// Lists information about a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetResource">REST API Reference for GetResource Operation</seealso>
        Task<GetResourceResponse> GetResourceAsync(GetResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetResources



        /// <summary>
        /// Lists information about a collection of Resource resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResources service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetResources">REST API Reference for GetResources Operation</seealso>
        Task<GetResourcesResponse> GetResourcesAsync(GetResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRestApi



        /// <summary>
        /// Lists the RestApi resource in the collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRestApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRestApi">REST API Reference for GetRestApi Operation</seealso>
        Task<GetRestApiResponse> GetRestApiAsync(GetRestApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRestApis



        /// <summary>
        /// Lists the RestApis resources for your collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRestApis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRestApis service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetRestApis">REST API Reference for GetRestApis Operation</seealso>
        Task<GetRestApisResponse> GetRestApisAsync(GetRestApisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSdk



        /// <summary>
        /// Generates a client SDK for a RestApi and Stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSdk service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSdk service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetSdk">REST API Reference for GetSdk Operation</seealso>
        Task<GetSdkResponse> GetSdkAsync(GetSdkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSdkType



        /// <summary>
        /// Gets an SDK type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSdkType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSdkType service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetSdkType">REST API Reference for GetSdkType Operation</seealso>
        Task<GetSdkTypeResponse> GetSdkTypeAsync(GetSdkTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSdkTypes



        /// <summary>
        /// Gets SDK types
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSdkTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSdkTypes service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetSdkTypes">REST API Reference for GetSdkTypes Operation</seealso>
        Task<GetSdkTypesResponse> GetSdkTypesAsync(GetSdkTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetStage



        /// <summary>
        /// Gets information about a Stage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetStage">REST API Reference for GetStage Operation</seealso>
        Task<GetStageResponse> GetStageAsync(GetStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetStages



        /// <summary>
        /// Gets information about one or more Stage resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStages service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetStages">REST API Reference for GetStages Operation</seealso>
        Task<GetStagesResponse> GetStagesAsync(GetStagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTags



        /// <summary>
        /// Gets the Tags collection for a given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTags service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetTags">REST API Reference for GetTags Operation</seealso>
        Task<GetTagsResponse> GetTagsAsync(GetTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUsage



        /// <summary>
        /// Gets the usage data of a usage plan in a specified time interval.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUsage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsage">REST API Reference for GetUsage Operation</seealso>
        Task<GetUsageResponse> GetUsageAsync(GetUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUsagePlan



        /// <summary>
        /// Gets a usage plan of a given plan identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUsagePlan service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlan">REST API Reference for GetUsagePlan Operation</seealso>
        Task<GetUsagePlanResponse> GetUsagePlanAsync(GetUsagePlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUsagePlanKey



        /// <summary>
        /// Gets a usage plan key of a given key identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlanKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUsagePlanKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlanKey">REST API Reference for GetUsagePlanKey Operation</seealso>
        Task<GetUsagePlanKeyResponse> GetUsagePlanKeyAsync(GetUsagePlanKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUsagePlanKeys



        /// <summary>
        /// Gets all the usage plan keys representing the API keys added to a specified usage
        /// plan.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlanKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUsagePlanKeys service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlanKeys">REST API Reference for GetUsagePlanKeys Operation</seealso>
        Task<GetUsagePlanKeysResponse> GetUsagePlanKeysAsync(GetUsagePlanKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUsagePlans



        /// <summary>
        /// Gets all the usage plans of the caller's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUsagePlans service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetUsagePlans">REST API Reference for GetUsagePlans Operation</seealso>
        Task<GetUsagePlansResponse> GetUsagePlansAsync(GetUsagePlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVpcLink



        /// <summary>
        /// Gets a specified VPC link under the caller's account in a region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVpcLink service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetVpcLink">REST API Reference for GetVpcLink Operation</seealso>
        Task<GetVpcLinkResponse> GetVpcLinkAsync(GetVpcLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetVpcLinks



        /// <summary>
        /// Gets the VpcLinks collection under the caller's account in a selected region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLinks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVpcLinks service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/GetVpcLinks">REST API Reference for GetVpcLinks Operation</seealso>
        Task<GetVpcLinksResponse> GetVpcLinksAsync(GetVpcLinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportApiKeys



        /// <summary>
        /// Import API keys from an external source, such as a CSV-formatted file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportApiKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportApiKeys service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/ImportApiKeys">REST API Reference for ImportApiKeys Operation</seealso>
        Task<ImportApiKeysResponse> ImportApiKeysAsync(ImportApiKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportDocumentationParts



        /// <summary>
        /// Imports documentation parts
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportDocumentationParts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportDocumentationParts service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/ImportDocumentationParts">REST API Reference for ImportDocumentationParts Operation</seealso>
        Task<ImportDocumentationPartsResponse> ImportDocumentationPartsAsync(ImportDocumentationPartsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportRestApi



        /// <summary>
        /// A feature of the API Gateway control service for creating a new API from an external
        /// API definition file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportRestApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/ImportRestApi">REST API Reference for ImportRestApi Operation</seealso>
        Task<ImportRestApiResponse> ImportRestApiAsync(ImportRestApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutGatewayResponse



        /// <summary>
        /// Creates a customization of a GatewayResponse of a specified response type and status
        /// code on the given RestApi.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGatewayResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutGatewayResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutGatewayResponse">REST API Reference for PutGatewayResponse Operation</seealso>
        Task<PutGatewayResponseResponse> PutGatewayResponseAsync(PutGatewayResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutIntegration



        /// <summary>
        /// Sets up a method's integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutIntegration">REST API Reference for PutIntegration Operation</seealso>
        Task<PutIntegrationResponse> PutIntegrationAsync(PutIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutIntegrationResponse



        /// <summary>
        /// Represents a put integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIntegrationResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutIntegrationResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutIntegrationResponse">REST API Reference for PutIntegrationResponse Operation</seealso>
        Task<PutIntegrationResponseResponse> PutIntegrationResponseAsync(PutIntegrationResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutMethod



        /// <summary>
        /// Add a method to an existing Resource resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMethod service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutMethod service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutMethod">REST API Reference for PutMethod Operation</seealso>
        Task<PutMethodResponse> PutMethodAsync(PutMethodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutMethodResponse



        /// <summary>
        /// Adds a MethodResponse to an existing Method resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMethodResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutMethodResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutMethodResponse">REST API Reference for PutMethodResponse Operation</seealso>
        Task<PutMethodResponseResponse> PutMethodResponseAsync(PutMethodResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutRestApi



        /// <summary>
        /// A feature of the API Gateway control service for updating an existing API with an
        /// input of external API definitions. The update can take the form of merging the supplied
        /// definition into the existing API or overwriting the existing API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRestApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/PutRestApi">REST API Reference for PutRestApi Operation</seealso>
        Task<PutRestApiResponse> PutRestApiAsync(PutRestApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RejectDomainNameAccessAssociation



        /// <summary>
        /// Rejects a domain name access association with a private custom domain name.
        /// 
        ///  
        /// <para>
        /// To reject a domain name access association with an access association source in another
        /// AWS account, use this operation. To remove a domain name access association with an
        /// access association source in your own account, use the DeleteDomainNameAccessAssociation
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectDomainNameAccessAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectDomainNameAccessAssociation service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/RejectDomainNameAccessAssociation">REST API Reference for RejectDomainNameAccessAssociation Operation</seealso>
        Task<RejectDomainNameAccessAssociationResponse> RejectDomainNameAccessAssociationAsync(RejectDomainNameAccessAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds or updates a tag on a given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TestInvokeAuthorizer



        /// <summary>
        /// Simulate the execution of an Authorizer in your RestApi with headers, parameters,
        /// and an incoming request body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeAuthorizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestInvokeAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/TestInvokeAuthorizer">REST API Reference for TestInvokeAuthorizer Operation</seealso>
        Task<TestInvokeAuthorizerResponse> TestInvokeAuthorizerAsync(TestInvokeAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TestInvokeMethod



        /// <summary>
        /// Simulate the invocation of a Method in your RestApi with headers, parameters, and
        /// an incoming request body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeMethod service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestInvokeMethod service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/TestInvokeMethod">REST API Reference for TestInvokeMethod Operation</seealso>
        Task<TestInvokeMethodResponse> TestInvokeMethodAsync(TestInvokeMethodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes a tag from a given resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAccount



        /// <summary>
        /// Changes information about the current Account resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccount service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateAccount">REST API Reference for UpdateAccount Operation</seealso>
        Task<UpdateAccountResponse> UpdateAccountAsync(UpdateAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateApiKey



        /// <summary>
        /// Changes information about an ApiKey resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApiKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateApiKey">REST API Reference for UpdateApiKey Operation</seealso>
        Task<UpdateApiKeyResponse> UpdateApiKeyAsync(UpdateApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAuthorizer



        /// <summary>
        /// Updates an existing Authorizer resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateAuthorizer">REST API Reference for UpdateAuthorizer Operation</seealso>
        Task<UpdateAuthorizerResponse> UpdateAuthorizerAsync(UpdateAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateBasePathMapping



        /// <summary>
        /// Changes information about the BasePathMapping resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBasePathMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBasePathMapping service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateBasePathMapping">REST API Reference for UpdateBasePathMapping Operation</seealso>
        Task<UpdateBasePathMappingResponse> UpdateBasePathMappingAsync(UpdateBasePathMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateClientCertificate



        /// <summary>
        /// Changes information about an ClientCertificate resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClientCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateClientCertificate">REST API Reference for UpdateClientCertificate Operation</seealso>
        Task<UpdateClientCertificateResponse> UpdateClientCertificateAsync(UpdateClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDeployment



        /// <summary>
        /// Changes information about a Deployment resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDeployment service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// The requested service is not available. For details see the accompanying error message.
        /// Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDeployment">REST API Reference for UpdateDeployment Operation</seealso>
        Task<UpdateDeploymentResponse> UpdateDeploymentAsync(UpdateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDocumentationPart



        /// <summary>
        /// Updates a documentation part.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentationPart service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDocumentationPart service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDocumentationPart">REST API Reference for UpdateDocumentationPart Operation</seealso>
        Task<UpdateDocumentationPartResponse> UpdateDocumentationPartAsync(UpdateDocumentationPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDocumentationVersion



        /// <summary>
        /// Updates a documentation version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDocumentationVersion service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDocumentationVersion">REST API Reference for UpdateDocumentationVersion Operation</seealso>
        Task<UpdateDocumentationVersionResponse> UpdateDocumentationVersionAsync(UpdateDocumentationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDomainName



        /// <summary>
        /// Changes information about the DomainName resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomainName service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateDomainName">REST API Reference for UpdateDomainName Operation</seealso>
        Task<UpdateDomainNameResponse> UpdateDomainNameAsync(UpdateDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGatewayResponse



        /// <summary>
        /// Updates a GatewayResponse of a specified response type on the given RestApi.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGatewayResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateGatewayResponse">REST API Reference for UpdateGatewayResponse Operation</seealso>
        Task<UpdateGatewayResponseResponse> UpdateGatewayResponseAsync(UpdateGatewayResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateIntegration



        /// <summary>
        /// Represents an update integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        Task<UpdateIntegrationResponse> UpdateIntegrationAsync(UpdateIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateIntegrationResponse



        /// <summary>
        /// Represents an update integration response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegrationResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIntegrationResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateIntegrationResponse">REST API Reference for UpdateIntegrationResponse Operation</seealso>
        Task<UpdateIntegrationResponseResponse> UpdateIntegrationResponseAsync(UpdateIntegrationResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMethod



        /// <summary>
        /// Updates an existing Method resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMethod service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMethod service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateMethod">REST API Reference for UpdateMethod Operation</seealso>
        Task<UpdateMethodResponse> UpdateMethodAsync(UpdateMethodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMethodResponse



        /// <summary>
        /// Updates an existing MethodResponse resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMethodResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMethodResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateMethodResponse">REST API Reference for UpdateMethodResponse Operation</seealso>
        Task<UpdateMethodResponseResponse> UpdateMethodResponseAsync(UpdateMethodResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateModel



        /// <summary>
        /// Changes information about a model. The maximum size of the model is 400 KB.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateModel service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateModel">REST API Reference for UpdateModel Operation</seealso>
        Task<UpdateModelResponse> UpdateModelAsync(UpdateModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRequestValidator



        /// <summary>
        /// Updates a RequestValidator of a given RestApi.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRequestValidator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRequestValidator service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateRequestValidator">REST API Reference for UpdateRequestValidator Operation</seealso>
        Task<UpdateRequestValidatorResponse> UpdateRequestValidatorAsync(UpdateRequestValidatorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateResource



        /// <summary>
        /// Changes information about a Resource resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        Task<UpdateResourceResponse> UpdateResourceAsync(UpdateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRestApi



        /// <summary>
        /// Changes information about the specified API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRestApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateRestApi">REST API Reference for UpdateRestApi Operation</seealso>
        Task<UpdateRestApiResponse> UpdateRestApiAsync(UpdateRestApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateStage



        /// <summary>
        /// Changes information about a Stage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateStage">REST API Reference for UpdateStage Operation</seealso>
        Task<UpdateStageResponse> UpdateStageAsync(UpdateStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUsage



        /// <summary>
        /// Grants a temporary extension to the remaining quota of a usage plan associated with
        /// a specified API key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUsage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateUsage">REST API Reference for UpdateUsage Operation</seealso>
        Task<UpdateUsageResponse> UpdateUsageAsync(UpdateUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUsagePlan



        /// <summary>
        /// Updates a usage plan of a given plan Id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUsagePlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUsagePlan service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateUsagePlan">REST API Reference for UpdateUsagePlan Operation</seealso>
        Task<UpdateUsagePlanResponse> UpdateUsagePlanAsync(UpdateUsagePlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVpcLink



        /// <summary>
        /// Updates an existing VpcLink of a specified identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVpcLink service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// The submitted request is not valid, for example, the input is incomplete or incorrect.
        /// See the accompanying error message for details.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// The request configuration has conflicts. For details, see the accompanying error message.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// The request exceeded the rate limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// The requested resource is not found. Make sure that the request URI is correct.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// The request has reached its throttling limit. Retry after the specified time period.
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// The request is denied because the caller has insufficient permissions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigateway-2015-07-09/UpdateVpcLink">REST API Reference for UpdateVpcLink Operation</seealso>
        Task<UpdateVpcLinkResponse> UpdateVpcLinkAsync(UpdateVpcLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonAPIGatewayConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonAPIGatewayConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonAPIGatewayConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonAPIGatewayConfig to create AmazonAPIGatewayClient");
            }

            return awsCredentials == null ? 
                    new AmazonAPIGatewayClient(serviceClientConfig) :
                    new AmazonAPIGatewayClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}