/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.APIGateway.Model;

namespace Amazon.APIGateway
{
    /// <summary>
    /// Interface for accessing APIGateway
    ///
    /// Amazon API Gateway 
    /// <para>
    /// Amazon API Gateway helps developers deliver robust, secure and scalable mobile and
    /// web application backends. Amazon API Gateway allows developers to securely connect
    /// mobile and web applications to APIs that run on AWS Lambda, Amazon EC2, or other publicly
    /// addressable web services that are hosted outside of AWS.
    /// </para>
    /// </summary>
    public partial interface IAmazonAPIGateway : IDisposable
    {

        
        #region  CreateApiKey


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApiKey service method.</param>
        /// 
        /// <returns>The response from the CreateApiKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        CreateApiKeyResponse CreateApiKey(CreateApiKeyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApiKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateApiKeyResponse> CreateApiKeyAsync(CreateApiKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAuthorizer


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer service method.</param>
        /// 
        /// <returns>The response from the CreateAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        CreateAuthorizerResponse CreateAuthorizer(CreateAuthorizerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateAuthorizerResponse> CreateAuthorizerAsync(CreateAuthorizerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateBasePathMapping


        /// <summary>
        /// Creates a new <a>BasePathMapping</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBasePathMapping service method.</param>
        /// 
        /// <returns>The response from the CreateBasePathMapping service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        CreateBasePathMappingResponse CreateBasePathMapping(CreateBasePathMappingRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBasePathMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateBasePathMappingResponse> CreateBasePathMappingAsync(CreateBasePathMappingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDeployment


        /// <summary>
        /// Creates a <a>Deployment</a> resource, which makes a specified <a>RestApi</a> callable
        /// over the internet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDomainName


        /// <summary>
        /// Creates a new domain name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainName service method.</param>
        /// 
        /// <returns>The response from the CreateDomainName service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        CreateDomainNameResponse CreateDomainName(CreateDomainNameRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainName operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDomainNameResponse> CreateDomainNameAsync(CreateDomainNameRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateModel


        /// <summary>
        /// Adds a new <a>Model</a> resource to an existing <a>RestApi</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// 
        /// <returns>The response from the CreateModel service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        CreateModelResponse CreateModel(CreateModelRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateModelResponse> CreateModelAsync(CreateModelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateResource


        /// <summary>
        /// Creates a <a>Resource</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResource service method.</param>
        /// 
        /// <returns>The response from the CreateResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        CreateResourceResponse CreateResource(CreateResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateResourceResponse> CreateResourceAsync(CreateResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRestApi


        /// <summary>
        /// Creates a new <a>RestApi</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRestApi service method.</param>
        /// 
        /// <returns>The response from the CreateRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        CreateRestApiResponse CreateRestApi(CreateRestApiRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRestApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateRestApiResponse> CreateRestApiAsync(CreateRestApiRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateStage


        /// <summary>
        /// Creates a new <a>Stage</a> resource that references a pre-existing <a>Deployment</a>
        /// for the API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStage service method.</param>
        /// 
        /// <returns>The response from the CreateStage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        CreateStageResponse CreateStage(CreateStageRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateStageResponse> CreateStageAsync(CreateStageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteApiKey


        /// <summary>
        /// Deletes the <a>ApiKey</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiKey service method.</param>
        /// 
        /// <returns>The response from the DeleteApiKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        DeleteApiKeyResponse DeleteApiKey(DeleteApiKeyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteApiKeyResponse> DeleteApiKeyAsync(DeleteApiKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAuthorizer


        /// <summary>
        /// Deletes an existing <a>Authorizer</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer service method.</param>
        /// 
        /// <returns>The response from the DeleteAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        DeleteAuthorizerResponse DeleteAuthorizer(DeleteAuthorizerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteAuthorizerResponse> DeleteAuthorizerAsync(DeleteAuthorizerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBasePathMapping


        /// <summary>
        /// Deletes the <a>BasePathMapping</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBasePathMapping service method.</param>
        /// 
        /// <returns>The response from the DeleteBasePathMapping service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        DeleteBasePathMappingResponse DeleteBasePathMapping(DeleteBasePathMappingRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBasePathMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteBasePathMappingResponse> DeleteBasePathMappingAsync(DeleteBasePathMappingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteClientCertificate


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClientCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        DeleteClientCertificateResponse DeleteClientCertificate(DeleteClientCertificateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteClientCertificateResponse> DeleteClientCertificateAsync(DeleteClientCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDeployment


        /// <summary>
        /// Deletes a <a>Deployment</a> resource. Deleting a deployment will only succeed if there
        /// are no <a>Stage</a> resources associated with it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment service method.</param>
        /// 
        /// <returns>The response from the DeleteDeployment service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        DeleteDeploymentResponse DeleteDeployment(DeleteDeploymentRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDeploymentResponse> DeleteDeploymentAsync(DeleteDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDomainName


        /// <summary>
        /// Deletes the <a>DomainName</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName service method.</param>
        /// 
        /// <returns>The response from the DeleteDomainName service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        DeleteDomainNameResponse DeleteDomainName(DeleteDomainNameRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDomainNameResponse> DeleteDomainNameAsync(DeleteDomainNameRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteIntegration


        /// <summary>
        /// Represents a delete integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteIntegrationResponse> DeleteIntegrationAsync(DeleteIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteIntegrationResponse


        /// <summary>
        /// Represents a delete integration response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegrationResponse service method.</param>
        /// 
        /// <returns>The response from the DeleteIntegrationResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        DeleteIntegrationResponseResponse DeleteIntegrationResponse(DeleteIntegrationResponseRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegrationResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteIntegrationResponseResponse> DeleteIntegrationResponseAsync(DeleteIntegrationResponseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMethod


        /// <summary>
        /// Deletes an existing <a>Method</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMethod service method.</param>
        /// 
        /// <returns>The response from the DeleteMethod service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        DeleteMethodResponse DeleteMethod(DeleteMethodRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMethod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteMethodResponse> DeleteMethodAsync(DeleteMethodRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMethodResponse


        /// <summary>
        /// Deletes an existing <a>MethodResponse</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMethodResponse service method.</param>
        /// 
        /// <returns>The response from the DeleteMethodResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        DeleteMethodResponseResponse DeleteMethodResponse(DeleteMethodResponseRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMethodResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteMethodResponseResponse> DeleteMethodResponseAsync(DeleteMethodResponseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteModel


        /// <summary>
        /// Deletes a model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// 
        /// <returns>The response from the DeleteModel service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        DeleteModelResponse DeleteModel(DeleteModelRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteResource


        /// <summary>
        /// Deletes a <a>Resource</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource service method.</param>
        /// 
        /// <returns>The response from the DeleteResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        DeleteResourceResponse DeleteResource(DeleteResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteResourceResponse> DeleteResourceAsync(DeleteResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRestApi


        /// <summary>
        /// Deletes the specified API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRestApi service method.</param>
        /// 
        /// <returns>The response from the DeleteRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        DeleteRestApiResponse DeleteRestApi(DeleteRestApiRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRestApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteRestApiResponse> DeleteRestApiAsync(DeleteRestApiRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteStage


        /// <summary>
        /// Deletes a <a>Stage</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage service method.</param>
        /// 
        /// <returns>The response from the DeleteStage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        DeleteStageResponse DeleteStage(DeleteStageRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteStageResponse> DeleteStageAsync(DeleteStageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  FlushStageAuthorizersCache


        /// <summary>
        /// Flushes all authorizer cache entries on a stage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlushStageAuthorizersCache service method.</param>
        /// 
        /// <returns>The response from the FlushStageAuthorizersCache service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        FlushStageAuthorizersCacheResponse FlushStageAuthorizersCache(FlushStageAuthorizersCacheRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the FlushStageAuthorizersCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlushStageAuthorizersCache operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<FlushStageAuthorizersCacheResponse> FlushStageAuthorizersCacheAsync(FlushStageAuthorizersCacheRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  FlushStageCache


        /// <summary>
        /// Flushes a stage's cache.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlushStageCache service method.</param>
        /// 
        /// <returns>The response from the FlushStageCache service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        FlushStageCacheResponse FlushStageCache(FlushStageCacheRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the FlushStageCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlushStageCache operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<FlushStageCacheResponse> FlushStageCacheAsync(FlushStageCacheRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GenerateClientCertificate


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateClientCertificate service method.</param>
        /// 
        /// <returns>The response from the GenerateClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GenerateClientCertificateResponse GenerateClientCertificate(GenerateClientCertificateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GenerateClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GenerateClientCertificateResponse> GenerateClientCertificateAsync(GenerateClientCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAccount


        /// <summary>
        /// Gets information about the current <a>Account</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccount service method.</param>
        /// 
        /// <returns>The response from the GetAccount service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetAccountResponse GetAccount(GetAccountRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetAccountResponse> GetAccountAsync(GetAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetApiKey


        /// <summary>
        /// Gets information about the current <a>ApiKey</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiKey service method.</param>
        /// 
        /// <returns>The response from the GetApiKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetApiKeyResponse GetApiKey(GetApiKeyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApiKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetApiKeyResponse> GetApiKeyAsync(GetApiKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetApiKeys


        /// <summary>
        /// Gets information about the current <a>ApiKeys</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiKeys service method.</param>
        /// 
        /// <returns>The response from the GetApiKeys service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetApiKeysResponse GetApiKeys(GetApiKeysRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetApiKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApiKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetApiKeysResponse> GetApiKeysAsync(GetApiKeysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAuthorizer


        /// <summary>
        /// Describe an existing <a>Authorizer</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizer service method.</param>
        /// 
        /// <returns>The response from the GetAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetAuthorizerResponse GetAuthorizer(GetAuthorizerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetAuthorizerResponse> GetAuthorizerAsync(GetAuthorizerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAuthorizers


        /// <summary>
        /// Describe an existing <a>Authorizers</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizers service method.</param>
        /// 
        /// <returns>The response from the GetAuthorizers service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetAuthorizersResponse GetAuthorizers(GetAuthorizersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetAuthorizers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetAuthorizersResponse> GetAuthorizersAsync(GetAuthorizersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBasePathMapping


        /// <summary>
        /// Describe a <a>BasePathMapping</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBasePathMapping service method.</param>
        /// 
        /// <returns>The response from the GetBasePathMapping service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetBasePathMappingResponse GetBasePathMapping(GetBasePathMappingRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBasePathMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetBasePathMappingResponse> GetBasePathMappingAsync(GetBasePathMappingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBasePathMappings


        /// <summary>
        /// Represents a collection of <a>BasePathMapping</a> resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBasePathMappings service method.</param>
        /// 
        /// <returns>The response from the GetBasePathMappings service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetBasePathMappingsResponse GetBasePathMappings(GetBasePathMappingsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetBasePathMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBasePathMappings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetBasePathMappingsResponse> GetBasePathMappingsAsync(GetBasePathMappingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetClientCertificate


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificate service method.</param>
        /// 
        /// <returns>The response from the GetClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetClientCertificateResponse GetClientCertificate(GetClientCertificateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetClientCertificateResponse> GetClientCertificateAsync(GetClientCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetClientCertificates


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificates service method.</param>
        /// 
        /// <returns>The response from the GetClientCertificates service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetClientCertificatesResponse GetClientCertificates(GetClientCertificatesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetClientCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetClientCertificatesResponse> GetClientCertificatesAsync(GetClientCertificatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDeployment


        /// <summary>
        /// Gets information about a <a>Deployment</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment service method.</param>
        /// 
        /// <returns>The response from the GetDeployment service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetDeploymentResponse GetDeployment(GetDeploymentRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDeployments


        /// <summary>
        /// Gets information about a <a>Deployments</a> collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeployments service method.</param>
        /// 
        /// <returns>The response from the GetDeployments service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetDeploymentsResponse GetDeployments(GetDeploymentsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDeploymentsResponse> GetDeploymentsAsync(GetDeploymentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDomainName


        /// <summary>
        /// Represents a domain name that is contained in a simpler, more intuitive URL that can
        /// be called.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainName service method.</param>
        /// 
        /// <returns>The response from the GetDomainName service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetDomainNameResponse GetDomainName(GetDomainNameRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainName operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDomainNameResponse> GetDomainNameAsync(GetDomainNameRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDomainNames


        /// <summary>
        /// Represents a collection of <a>DomainName</a> resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainNames service method.</param>
        /// 
        /// <returns>The response from the GetDomainNames service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetDomainNamesResponse GetDomainNames(GetDomainNamesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainNames operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDomainNamesResponse> GetDomainNamesAsync(GetDomainNamesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetExport


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExport service method.</param>
        /// 
        /// <returns>The response from the GetExport service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetExportResponse GetExport(GetExportRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetExportResponse> GetExportAsync(GetExportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIntegration


        /// <summary>
        /// Represents a get integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// 
        /// <returns>The response from the GetIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetIntegrationResponse GetIntegration(GetIntegrationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetIntegrationResponse> GetIntegrationAsync(GetIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIntegrationResponse


        /// <summary>
        /// Represents a get integration response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponse service method.</param>
        /// 
        /// <returns>The response from the GetIntegrationResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetIntegrationResponseResponse GetIntegrationResponse(GetIntegrationResponseRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetIntegrationResponseResponse> GetIntegrationResponseAsync(GetIntegrationResponseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMethod


        /// <summary>
        /// Describe an existing <a>Method</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMethod service method.</param>
        /// 
        /// <returns>The response from the GetMethod service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetMethodResponse GetMethod(GetMethodRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMethod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetMethodResponse> GetMethodAsync(GetMethodRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMethodResponse


        /// <summary>
        /// Describes a <a>MethodResponse</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMethodResponse service method.</param>
        /// 
        /// <returns>The response from the GetMethodResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetMethodResponseResponse GetMethodResponse(GetMethodResponseRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMethodResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetMethodResponseResponse> GetMethodResponseAsync(GetMethodResponseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetModel


        /// <summary>
        /// Describes an existing model defined for a <a>RestApi</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModel service method.</param>
        /// 
        /// <returns>The response from the GetModel service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetModelResponse GetModel(GetModelRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetModelResponse> GetModelAsync(GetModelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetModels


        /// <summary>
        /// Describes existing <a>Models</a> defined for a <a>RestApi</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModels service method.</param>
        /// 
        /// <returns>The response from the GetModels service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetModelsResponse GetModels(GetModelsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetModelsResponse> GetModelsAsync(GetModelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetModelTemplate


        /// <summary>
        /// Generates a sample mapping template that can be used to transform a payload into the
        /// structure of a model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetModelTemplate service method.</param>
        /// 
        /// <returns>The response from the GetModelTemplate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetModelTemplateResponse GetModelTemplate(GetModelTemplateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetModelTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModelTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetModelTemplateResponse> GetModelTemplateAsync(GetModelTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResource


        /// <summary>
        /// Lists information about a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResource service method.</param>
        /// 
        /// <returns>The response from the GetResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetResourceResponse GetResource(GetResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetResourceResponse> GetResourceAsync(GetResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResources


        /// <summary>
        /// Lists information about a collection of <a>Resource</a> resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResources service method.</param>
        /// 
        /// <returns>The response from the GetResources service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetResourcesResponse GetResources(GetResourcesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetResourcesResponse> GetResourcesAsync(GetResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRestApi


        /// <summary>
        /// Lists the <a>RestApi</a> resource in the collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRestApi service method.</param>
        /// 
        /// <returns>The response from the GetRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetRestApiResponse GetRestApi(GetRestApiRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRestApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetRestApiResponse> GetRestApiAsync(GetRestApiRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRestApis


        /// <summary>
        /// Lists the <a>RestApis</a> resources for your collection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRestApis service method.</param>
        /// 
        /// <returns>The response from the GetRestApis service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetRestApisResponse GetRestApis(GetRestApisRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetRestApis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRestApis operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetRestApisResponse> GetRestApisAsync(GetRestApisRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSdk


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSdk service method.</param>
        /// 
        /// <returns>The response from the GetSdk service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetSdkResponse GetSdk(GetSdkRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetSdk operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSdk operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetSdkResponse> GetSdkAsync(GetSdkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetStage


        /// <summary>
        /// Gets information about a <a>Stage</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStage service method.</param>
        /// 
        /// <returns>The response from the GetStage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetStageResponse GetStage(GetStageRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetStageResponse> GetStageAsync(GetStageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetStages


        /// <summary>
        /// Gets information about one or more <a>Stage</a> resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStages service method.</param>
        /// 
        /// <returns>The response from the GetStages service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        GetStagesResponse GetStages(GetStagesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetStages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetStagesResponse> GetStagesAsync(GetStagesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutIntegration


        /// <summary>
        /// Represents a put integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIntegration service method.</param>
        /// 
        /// <returns>The response from the PutIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        PutIntegrationResponse PutIntegration(PutIntegrationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutIntegration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutIntegrationResponse> PutIntegrationAsync(PutIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutIntegrationResponse


        /// <summary>
        /// Represents a put integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIntegrationResponse service method.</param>
        /// 
        /// <returns>The response from the PutIntegrationResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        PutIntegrationResponseResponse PutIntegrationResponse(PutIntegrationResponseRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutIntegrationResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutIntegrationResponseResponse> PutIntegrationResponseAsync(PutIntegrationResponseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutMethod


        /// <summary>
        /// Add a method to an existing <a>Resource</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMethod service method.</param>
        /// 
        /// <returns>The response from the PutMethod service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        PutMethodResponse PutMethod(PutMethodRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMethod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutMethodResponse> PutMethodAsync(PutMethodRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutMethodResponse


        /// <summary>
        /// Adds a <a>MethodResponse</a> to an existing <a>Method</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMethodResponse service method.</param>
        /// 
        /// <returns>The response from the PutMethodResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        PutMethodResponseResponse PutMethodResponse(PutMethodResponseRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMethodResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutMethodResponseResponse> PutMethodResponseAsync(PutMethodResponseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TestInvokeAuthorizer


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeAuthorizer service method.</param>
        /// 
        /// <returns>The response from the TestInvokeAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        TestInvokeAuthorizerResponse TestInvokeAuthorizer(TestInvokeAuthorizerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the TestInvokeAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<TestInvokeAuthorizerResponse> TestInvokeAuthorizerAsync(TestInvokeAuthorizerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TestInvokeMethod


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeMethod service method.</param>
        /// 
        /// <returns>The response from the TestInvokeMethod service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        TestInvokeMethodResponse TestInvokeMethod(TestInvokeMethodRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the TestInvokeMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeMethod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<TestInvokeMethodResponse> TestInvokeMethodAsync(TestInvokeMethodRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAccount


        /// <summary>
        /// Changes information about the current <a>Account</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccount service method.</param>
        /// 
        /// <returns>The response from the UpdateAccount service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        UpdateAccountResponse UpdateAccount(UpdateAccountRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateAccountResponse> UpdateAccountAsync(UpdateAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateApiKey


        /// <summary>
        /// Changes information about an <a>ApiKey</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiKey service method.</param>
        /// 
        /// <returns>The response from the UpdateApiKey service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        UpdateApiKeyResponse UpdateApiKey(UpdateApiKeyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateApiKeyResponse> UpdateApiKeyAsync(UpdateApiKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAuthorizer


        /// <summary>
        /// Updates an existing <a>Authorizer</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer service method.</param>
        /// 
        /// <returns>The response from the UpdateAuthorizer service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        UpdateAuthorizerResponse UpdateAuthorizer(UpdateAuthorizerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateAuthorizerResponse> UpdateAuthorizerAsync(UpdateAuthorizerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateBasePathMapping


        /// <summary>
        /// Changes information about the <a>BasePathMapping</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBasePathMapping service method.</param>
        /// 
        /// <returns>The response from the UpdateBasePathMapping service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        UpdateBasePathMappingResponse UpdateBasePathMapping(UpdateBasePathMappingRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBasePathMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateBasePathMappingResponse> UpdateBasePathMappingAsync(UpdateBasePathMappingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateClientCertificate


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateClientCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateClientCertificate service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        UpdateClientCertificateResponse UpdateClientCertificate(UpdateClientCertificateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateClientCertificateResponse> UpdateClientCertificateAsync(UpdateClientCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDeployment


        /// <summary>
        /// Changes information about a <a>Deployment</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeployment service method.</param>
        /// 
        /// <returns>The response from the UpdateDeployment service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ServiceUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        UpdateDeploymentResponse UpdateDeployment(UpdateDeploymentRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateDeploymentResponse> UpdateDeploymentAsync(UpdateDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDomainName


        /// <summary>
        /// Changes information about the <a>DomainName</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainName service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainName service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        UpdateDomainNameResponse UpdateDomainName(UpdateDomainNameRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainName operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateDomainNameResponse> UpdateDomainNameAsync(UpdateDomainNameRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateIntegration


        /// <summary>
        /// Represents an update integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration service method.</param>
        /// 
        /// <returns>The response from the UpdateIntegration service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        UpdateIntegrationResponse UpdateIntegration(UpdateIntegrationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateIntegrationResponse> UpdateIntegrationAsync(UpdateIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateIntegrationResponse


        /// <summary>
        /// Represents an update integration response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegrationResponse service method.</param>
        /// 
        /// <returns>The response from the UpdateIntegrationResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        UpdateIntegrationResponseResponse UpdateIntegrationResponse(UpdateIntegrationResponseRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegrationResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateIntegrationResponseResponse> UpdateIntegrationResponseAsync(UpdateIntegrationResponseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateMethod


        /// <summary>
        /// Updates an existing <a>Method</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMethod service method.</param>
        /// 
        /// <returns>The response from the UpdateMethod service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        UpdateMethodResponse UpdateMethod(UpdateMethodRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMethod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateMethodResponse> UpdateMethodAsync(UpdateMethodRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateMethodResponse


        /// <summary>
        /// Updates an existing <a>MethodResponse</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMethodResponse service method.</param>
        /// 
        /// <returns>The response from the UpdateMethodResponse service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.LimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        UpdateMethodResponseResponse UpdateMethodResponse(UpdateMethodResponseRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMethodResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateMethodResponseResponse> UpdateMethodResponseAsync(UpdateMethodResponseRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateModel


        /// <summary>
        /// Changes information about a model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel service method.</param>
        /// 
        /// <returns>The response from the UpdateModel service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        UpdateModelResponse UpdateModel(UpdateModelRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateModelResponse> UpdateModelAsync(UpdateModelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateResource


        /// <summary>
        /// Changes information about a <a>Resource</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource service method.</param>
        /// 
        /// <returns>The response from the UpdateResource service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        UpdateResourceResponse UpdateResource(UpdateResourceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateResourceResponse> UpdateResourceAsync(UpdateResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRestApi


        /// <summary>
        /// Changes information about the specified API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRestApi service method.</param>
        /// 
        /// <returns>The response from the UpdateRestApi service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        UpdateRestApiResponse UpdateRestApi(UpdateRestApiRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRestApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateRestApiResponse> UpdateRestApiAsync(UpdateRestApiRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateStage


        /// <summary>
        /// Changes information about a <a>Stage</a> resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage service method.</param>
        /// 
        /// <returns>The response from the UpdateStage service method, as returned by APIGateway.</returns>
        /// <exception cref="Amazon.APIGateway.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.APIGateway.Model.UnauthorizedException">
        /// 
        /// </exception>
        UpdateStageResponse UpdateStage(UpdateStageRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateStageResponse> UpdateStageAsync(UpdateStageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}