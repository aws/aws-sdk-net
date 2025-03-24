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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Amplify.Model;

#pragma warning disable CS1570
namespace Amazon.Amplify
{
    /// <summary>
    /// <para>Interface for accessing Amplify</para>
    ///
    /// Amplify enables developers to develop and deploy cloud-powered mobile and web apps.
    /// Amplify Hosting provides a continuous delivery and hosting service for web applications.
    /// For more information, see the <a href="https://docs.aws.amazon.com/amplify/latest/userguide/welcome.html">Amplify
    /// Hosting User Guide</a>. The Amplify Framework is a comprehensive set of SDKs, libraries,
    /// tools, and documentation for client app development. For more information, see the
    /// <a href="https://docs.amplify.aws/">Amplify Framework.</a>
    /// </summary>
    public partial interface IAmazonAmplify : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAmplifyPaginatorFactory Paginators { get; }

        
        #region  CreateApp


        /// <summary>
        /// Creates a new Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateApp">REST API Reference for CreateApp Operation</seealso>
        CreateAppResponse CreateApp(CreateAppRequest request);



        /// <summary>
        /// Creates a new Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateApp">REST API Reference for CreateApp Operation</seealso>
        Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateBackendEnvironment


        /// <summary>
        /// Creates a new backend environment for an Amplify app. 
        /// 
        ///  
        /// <para>
        /// This API is available only to Amplify Gen 1 applications where the backend is created
        /// using Amplify Studio or the Amplify command line interface (CLI). This API isn’t available
        /// to Amplify Gen 2 applications. When you deploy an application with Amplify Gen 2,
        /// you provision the app's backend infrastructure using Typescript code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateBackendEnvironment service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateBackendEnvironment">REST API Reference for CreateBackendEnvironment Operation</seealso>
        CreateBackendEnvironmentResponse CreateBackendEnvironment(CreateBackendEnvironmentRequest request);



        /// <summary>
        /// Creates a new backend environment for an Amplify app. 
        /// 
        ///  
        /// <para>
        /// This API is available only to Amplify Gen 1 applications where the backend is created
        /// using Amplify Studio or the Amplify command line interface (CLI). This API isn’t available
        /// to Amplify Gen 2 applications. When you deploy an application with Amplify Gen 2,
        /// you provision the app's backend infrastructure using Typescript code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBackendEnvironment service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateBackendEnvironment">REST API Reference for CreateBackendEnvironment Operation</seealso>
        Task<CreateBackendEnvironmentResponse> CreateBackendEnvironmentAsync(CreateBackendEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateBranch


        /// <summary>
        /// Creates a new branch for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBranch service method.</param>
        /// 
        /// <returns>The response from the CreateBranch service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateBranch">REST API Reference for CreateBranch Operation</seealso>
        CreateBranchResponse CreateBranch(CreateBranchRequest request);



        /// <summary>
        /// Creates a new branch for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBranch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBranch service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateBranch">REST API Reference for CreateBranch Operation</seealso>
        Task<CreateBranchResponse> CreateBranchAsync(CreateBranchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDeployment


        /// <summary>
        /// Creates a deployment for a manually deployed Amplify app. Manually deployed apps are
        /// not connected to a Git repository. 
        /// 
        ///  
        /// <para>
        /// The maximum duration between the <c>CreateDeployment</c> call and the <c>StartDeployment</c>
        /// call cannot exceed 8 hours. If the duration exceeds 8 hours, the <c>StartDeployment</c>
        /// call and the associated <c>Job</c> will fail.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request);



        /// <summary>
        /// Creates a deployment for a manually deployed Amplify app. Manually deployed apps are
        /// not connected to a Git repository. 
        /// 
        ///  
        /// <para>
        /// The maximum duration between the <c>CreateDeployment</c> call and the <c>StartDeployment</c>
        /// call cannot exceed 8 hours. If the duration exceeds 8 hours, the <c>StartDeployment</c>
        /// call and the associated <c>Job</c> will fail.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDeployment service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateDeployment">REST API Reference for CreateDeployment Operation</seealso>
        Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDomainAssociation


        /// <summary>
        /// Creates a new domain association for an Amplify app. This action associates a custom
        /// domain with the Amplify app
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateDomainAssociation service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateDomainAssociation">REST API Reference for CreateDomainAssociation Operation</seealso>
        CreateDomainAssociationResponse CreateDomainAssociation(CreateDomainAssociationRequest request);



        /// <summary>
        /// Creates a new domain association for an Amplify app. This action associates a custom
        /// domain with the Amplify app
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomainAssociation service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateDomainAssociation">REST API Reference for CreateDomainAssociation Operation</seealso>
        Task<CreateDomainAssociationResponse> CreateDomainAssociationAsync(CreateDomainAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWebhook


        /// <summary>
        /// Creates a new webhook on an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebhook service method.</param>
        /// 
        /// <returns>The response from the CreateWebhook service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateWebhook">REST API Reference for CreateWebhook Operation</seealso>
        CreateWebhookResponse CreateWebhook(CreateWebhookRequest request);



        /// <summary>
        /// Creates a new webhook on an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebhook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWebhook service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/CreateWebhook">REST API Reference for CreateWebhook Operation</seealso>
        Task<CreateWebhookResponse> CreateWebhookAsync(CreateWebhookRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteApp


        /// <summary>
        /// Deletes an existing Amplify app specified by an app ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        DeleteAppResponse DeleteApp(DeleteAppRequest request);



        /// <summary>
        /// Deletes an existing Amplify app specified by an app ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBackendEnvironment


        /// <summary>
        /// Deletes a backend environment for an Amplify app. 
        /// 
        ///  
        /// <para>
        /// This API is available only to Amplify Gen 1 applications where the backend is created
        /// using Amplify Studio or the Amplify command line interface (CLI). This API isn’t available
        /// to Amplify Gen 2 applications. When you deploy an application with Amplify Gen 2,
        /// you provision the app's backend infrastructure using Typescript code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteBackendEnvironment service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteBackendEnvironment">REST API Reference for DeleteBackendEnvironment Operation</seealso>
        DeleteBackendEnvironmentResponse DeleteBackendEnvironment(DeleteBackendEnvironmentRequest request);



        /// <summary>
        /// Deletes a backend environment for an Amplify app. 
        /// 
        ///  
        /// <para>
        /// This API is available only to Amplify Gen 1 applications where the backend is created
        /// using Amplify Studio or the Amplify command line interface (CLI). This API isn’t available
        /// to Amplify Gen 2 applications. When you deploy an application with Amplify Gen 2,
        /// you provision the app's backend infrastructure using Typescript code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBackendEnvironment service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteBackendEnvironment">REST API Reference for DeleteBackendEnvironment Operation</seealso>
        Task<DeleteBackendEnvironmentResponse> DeleteBackendEnvironmentAsync(DeleteBackendEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBranch


        /// <summary>
        /// Deletes a branch for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBranch service method.</param>
        /// 
        /// <returns>The response from the DeleteBranch service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteBranch">REST API Reference for DeleteBranch Operation</seealso>
        DeleteBranchResponse DeleteBranch(DeleteBranchRequest request);



        /// <summary>
        /// Deletes a branch for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBranch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBranch service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteBranch">REST API Reference for DeleteBranch Operation</seealso>
        Task<DeleteBranchResponse> DeleteBranchAsync(DeleteBranchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDomainAssociation


        /// <summary>
        /// Deletes a domain association for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteDomainAssociation service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteDomainAssociation">REST API Reference for DeleteDomainAssociation Operation</seealso>
        DeleteDomainAssociationResponse DeleteDomainAssociation(DeleteDomainAssociationRequest request);



        /// <summary>
        /// Deletes a domain association for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomainAssociation service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteDomainAssociation">REST API Reference for DeleteDomainAssociation Operation</seealso>
        Task<DeleteDomainAssociationResponse> DeleteDomainAssociationAsync(DeleteDomainAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteJob


        /// <summary>
        /// Deletes a job for a branch of an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// 
        /// <returns>The response from the DeleteJob service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        DeleteJobResponse DeleteJob(DeleteJobRequest request);



        /// <summary>
        /// Deletes a job for a branch of an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteJob service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteWebhook


        /// <summary>
        /// Deletes a webhook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebhook service method.</param>
        /// 
        /// <returns>The response from the DeleteWebhook service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteWebhook">REST API Reference for DeleteWebhook Operation</seealso>
        DeleteWebhookResponse DeleteWebhook(DeleteWebhookRequest request);



        /// <summary>
        /// Deletes a webhook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebhook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWebhook service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/DeleteWebhook">REST API Reference for DeleteWebhook Operation</seealso>
        Task<DeleteWebhookResponse> DeleteWebhookAsync(DeleteWebhookRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GenerateAccessLogs


        /// <summary>
        /// Returns the website access logs for a specific time range using a presigned URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateAccessLogs service method.</param>
        /// 
        /// <returns>The response from the GenerateAccessLogs service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GenerateAccessLogs">REST API Reference for GenerateAccessLogs Operation</seealso>
        GenerateAccessLogsResponse GenerateAccessLogs(GenerateAccessLogsRequest request);



        /// <summary>
        /// Returns the website access logs for a specific time range using a presigned URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateAccessLogs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateAccessLogs service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GenerateAccessLogs">REST API Reference for GenerateAccessLogs Operation</seealso>
        Task<GenerateAccessLogsResponse> GenerateAccessLogsAsync(GenerateAccessLogsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetApp


        /// <summary>
        /// Returns an existing Amplify app specified by an app ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApp service method.</param>
        /// 
        /// <returns>The response from the GetApp service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetApp">REST API Reference for GetApp Operation</seealso>
        GetAppResponse GetApp(GetAppRequest request);



        /// <summary>
        /// Returns an existing Amplify app specified by an app ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApp service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetApp">REST API Reference for GetApp Operation</seealso>
        Task<GetAppResponse> GetAppAsync(GetAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetArtifactUrl


        /// <summary>
        /// Returns the artifact info that corresponds to an artifact id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArtifactUrl service method.</param>
        /// 
        /// <returns>The response from the GetArtifactUrl service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetArtifactUrl">REST API Reference for GetArtifactUrl Operation</seealso>
        GetArtifactUrlResponse GetArtifactUrl(GetArtifactUrlRequest request);



        /// <summary>
        /// Returns the artifact info that corresponds to an artifact id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArtifactUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetArtifactUrl service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetArtifactUrl">REST API Reference for GetArtifactUrl Operation</seealso>
        Task<GetArtifactUrlResponse> GetArtifactUrlAsync(GetArtifactUrlRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBackendEnvironment


        /// <summary>
        /// Returns a backend environment for an Amplify app. 
        /// 
        ///  
        /// <para>
        /// This API is available only to Amplify Gen 1 applications where the backend is created
        /// using Amplify Studio or the Amplify command line interface (CLI). This API isn’t available
        /// to Amplify Gen 2 applications. When you deploy an application with Amplify Gen 2,
        /// you provision the app's backend infrastructure using Typescript code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendEnvironment service method.</param>
        /// 
        /// <returns>The response from the GetBackendEnvironment service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetBackendEnvironment">REST API Reference for GetBackendEnvironment Operation</seealso>
        GetBackendEnvironmentResponse GetBackendEnvironment(GetBackendEnvironmentRequest request);



        /// <summary>
        /// Returns a backend environment for an Amplify app. 
        /// 
        ///  
        /// <para>
        /// This API is available only to Amplify Gen 1 applications where the backend is created
        /// using Amplify Studio or the Amplify command line interface (CLI). This API isn’t available
        /// to Amplify Gen 2 applications. When you deploy an application with Amplify Gen 2,
        /// you provision the app's backend infrastructure using Typescript code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBackendEnvironment service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetBackendEnvironment">REST API Reference for GetBackendEnvironment Operation</seealso>
        Task<GetBackendEnvironmentResponse> GetBackendEnvironmentAsync(GetBackendEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBranch


        /// <summary>
        /// Returns a branch for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBranch service method.</param>
        /// 
        /// <returns>The response from the GetBranch service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetBranch">REST API Reference for GetBranch Operation</seealso>
        GetBranchResponse GetBranch(GetBranchRequest request);



        /// <summary>
        /// Returns a branch for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBranch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBranch service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetBranch">REST API Reference for GetBranch Operation</seealso>
        Task<GetBranchResponse> GetBranchAsync(GetBranchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDomainAssociation


        /// <summary>
        /// Returns the domain information for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainAssociation service method.</param>
        /// 
        /// <returns>The response from the GetDomainAssociation service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetDomainAssociation">REST API Reference for GetDomainAssociation Operation</seealso>
        GetDomainAssociationResponse GetDomainAssociation(GetDomainAssociationRequest request);



        /// <summary>
        /// Returns the domain information for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainAssociation service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetDomainAssociation">REST API Reference for GetDomainAssociation Operation</seealso>
        Task<GetDomainAssociationResponse> GetDomainAssociationAsync(GetDomainAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetJob


        /// <summary>
        /// Returns a job for a branch of an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetJob">REST API Reference for GetJob Operation</seealso>
        GetJobResponse GetJob(GetJobRequest request);



        /// <summary>
        /// Returns a job for a branch of an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetJob">REST API Reference for GetJob Operation</seealso>
        Task<GetJobResponse> GetJobAsync(GetJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWebhook


        /// <summary>
        /// Returns the webhook information that corresponds to a specified webhook ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebhook service method.</param>
        /// 
        /// <returns>The response from the GetWebhook service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetWebhook">REST API Reference for GetWebhook Operation</seealso>
        GetWebhookResponse GetWebhook(GetWebhookRequest request);



        /// <summary>
        /// Returns the webhook information that corresponds to a specified webhook ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebhook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWebhook service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/GetWebhook">REST API Reference for GetWebhook Operation</seealso>
        Task<GetWebhookResponse> GetWebhookAsync(GetWebhookRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListApps


        /// <summary>
        /// Returns a list of the existing Amplify apps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListApps">REST API Reference for ListApps Operation</seealso>
        ListAppsResponse ListApps(ListAppsRequest request);



        /// <summary>
        /// Returns a list of the existing Amplify apps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListApps">REST API Reference for ListApps Operation</seealso>
        Task<ListAppsResponse> ListAppsAsync(ListAppsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListArtifacts


        /// <summary>
        /// Returns a list of end-to-end testing artifacts for a specified app, branch, and job.
        /// 
        ///  
        /// <para>
        /// To return the build artifacts, use the <a href="https://docs.aws.amazon.com/amplify/latest/APIReference/API_GetJob.html">GetJob</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// For more information about Amplify testing support, see <a href="https://docs.aws.amazon.com/amplify/latest/userguide/running-tests.html">Setting
        /// up end-to-end Cypress tests for your Amplify application</a> in the <i>Amplify Hosting
        /// User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArtifacts service method.</param>
        /// 
        /// <returns>The response from the ListArtifacts service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListArtifacts">REST API Reference for ListArtifacts Operation</seealso>
        ListArtifactsResponse ListArtifacts(ListArtifactsRequest request);



        /// <summary>
        /// Returns a list of end-to-end testing artifacts for a specified app, branch, and job.
        /// 
        ///  
        /// <para>
        /// To return the build artifacts, use the <a href="https://docs.aws.amazon.com/amplify/latest/APIReference/API_GetJob.html">GetJob</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// For more information about Amplify testing support, see <a href="https://docs.aws.amazon.com/amplify/latest/userguide/running-tests.html">Setting
        /// up end-to-end Cypress tests for your Amplify application</a> in the <i>Amplify Hosting
        /// User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArtifacts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListArtifacts service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListArtifacts">REST API Reference for ListArtifacts Operation</seealso>
        Task<ListArtifactsResponse> ListArtifactsAsync(ListArtifactsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListBackendEnvironments


        /// <summary>
        /// Lists the backend environments for an Amplify app. 
        /// 
        ///  
        /// <para>
        /// This API is available only to Amplify Gen 1 applications where the backend is created
        /// using Amplify Studio or the Amplify command line interface (CLI). This API isn’t available
        /// to Amplify Gen 2 applications. When you deploy an application with Amplify Gen 2,
        /// you provision the app's backend infrastructure using Typescript code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackendEnvironments service method.</param>
        /// 
        /// <returns>The response from the ListBackendEnvironments service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListBackendEnvironments">REST API Reference for ListBackendEnvironments Operation</seealso>
        ListBackendEnvironmentsResponse ListBackendEnvironments(ListBackendEnvironmentsRequest request);



        /// <summary>
        /// Lists the backend environments for an Amplify app. 
        /// 
        ///  
        /// <para>
        /// This API is available only to Amplify Gen 1 applications where the backend is created
        /// using Amplify Studio or the Amplify command line interface (CLI). This API isn’t available
        /// to Amplify Gen 2 applications. When you deploy an application with Amplify Gen 2,
        /// you provision the app's backend infrastructure using Typescript code.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackendEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBackendEnvironments service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListBackendEnvironments">REST API Reference for ListBackendEnvironments Operation</seealso>
        Task<ListBackendEnvironmentsResponse> ListBackendEnvironmentsAsync(ListBackendEnvironmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListBranches


        /// <summary>
        /// Lists the branches of an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBranches service method.</param>
        /// 
        /// <returns>The response from the ListBranches service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListBranches">REST API Reference for ListBranches Operation</seealso>
        ListBranchesResponse ListBranches(ListBranchesRequest request);



        /// <summary>
        /// Lists the branches of an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBranches service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBranches service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListBranches">REST API Reference for ListBranches Operation</seealso>
        Task<ListBranchesResponse> ListBranchesAsync(ListBranchesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDomainAssociations


        /// <summary>
        /// Returns the domain associations for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainAssociations service method.</param>
        /// 
        /// <returns>The response from the ListDomainAssociations service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListDomainAssociations">REST API Reference for ListDomainAssociations Operation</seealso>
        ListDomainAssociationsResponse ListDomainAssociations(ListDomainAssociationsRequest request);



        /// <summary>
        /// Returns the domain associations for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomainAssociations service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListDomainAssociations">REST API Reference for ListDomainAssociations Operation</seealso>
        Task<ListDomainAssociationsResponse> ListDomainAssociationsAsync(ListDomainAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListJobs


        /// <summary>
        /// Lists the jobs for a branch of an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        ListJobsResponse ListJobs(ListJobsRequest request);



        /// <summary>
        /// Lists the jobs for a branch of an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListJobs">REST API Reference for ListJobs Operation</seealso>
        Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of tags for a specified Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.ResourceNotFoundException">
        /// An operation failed due to a non-existent resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Returns a list of tags for a specified Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.ResourceNotFoundException">
        /// An operation failed due to a non-existent resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWebhooks


        /// <summary>
        /// Returns a list of webhooks for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebhooks service method.</param>
        /// 
        /// <returns>The response from the ListWebhooks service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListWebhooks">REST API Reference for ListWebhooks Operation</seealso>
        ListWebhooksResponse ListWebhooks(ListWebhooksRequest request);



        /// <summary>
        /// Returns a list of webhooks for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebhooks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWebhooks service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/ListWebhooks">REST API Reference for ListWebhooks Operation</seealso>
        Task<ListWebhooksResponse> ListWebhooksAsync(ListWebhooksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartDeployment


        /// <summary>
        /// Starts a deployment for a manually deployed app. Manually deployed apps are not connected
        /// to a Git repository. 
        /// 
        ///  
        /// <para>
        /// The maximum duration between the <c>CreateDeployment</c> call and the <c>StartDeployment</c>
        /// call cannot exceed 8 hours. If the duration exceeds 8 hours, the <c>StartDeployment</c>
        /// call and the associated <c>Job</c> will fail.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDeployment service method.</param>
        /// 
        /// <returns>The response from the StartDeployment service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/StartDeployment">REST API Reference for StartDeployment Operation</seealso>
        StartDeploymentResponse StartDeployment(StartDeploymentRequest request);



        /// <summary>
        /// Starts a deployment for a manually deployed app. Manually deployed apps are not connected
        /// to a Git repository. 
        /// 
        ///  
        /// <para>
        /// The maximum duration between the <c>CreateDeployment</c> call and the <c>StartDeployment</c>
        /// call cannot exceed 8 hours. If the duration exceeds 8 hours, the <c>StartDeployment</c>
        /// call and the associated <c>Job</c> will fail.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDeployment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDeployment service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/StartDeployment">REST API Reference for StartDeployment Operation</seealso>
        Task<StartDeploymentResponse> StartDeploymentAsync(StartDeploymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartJob


        /// <summary>
        /// Starts a new job for a branch of an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJob service method.</param>
        /// 
        /// <returns>The response from the StartJob service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/StartJob">REST API Reference for StartJob Operation</seealso>
        StartJobResponse StartJob(StartJobRequest request);



        /// <summary>
        /// Starts a new job for a branch of an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartJob service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/StartJob">REST API Reference for StartJob Operation</seealso>
        Task<StartJobResponse> StartJobAsync(StartJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopJob


        /// <summary>
        /// Stops a job that is in progress for a branch of an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopJob service method.</param>
        /// 
        /// <returns>The response from the StopJob service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/StopJob">REST API Reference for StopJob Operation</seealso>
        StopJobResponse StopJob(StopJobRequest request);



        /// <summary>
        /// Stops a job that is in progress for a branch of an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopJob service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.LimitExceededException">
        /// A resource could not be created because service quotas were exceeded.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/StopJob">REST API Reference for StopJob Operation</seealso>
        Task<StopJobResponse> StopJobAsync(StopJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags the resource with a tag key and value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.ResourceNotFoundException">
        /// An operation failed due to a non-existent resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Tags the resource with a tag key and value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.ResourceNotFoundException">
        /// An operation failed due to a non-existent resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Untags a resource with a specified Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.ResourceNotFoundException">
        /// An operation failed due to a non-existent resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Untags a resource with a specified Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.ResourceNotFoundException">
        /// An operation failed due to a non-existent resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateApp


        /// <summary>
        /// Updates an existing Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp service method.</param>
        /// 
        /// <returns>The response from the UpdateApp service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        UpdateAppResponse UpdateApp(UpdateAppRequest request);



        /// <summary>
        /// Updates an existing Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApp service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateBranch


        /// <summary>
        /// Updates a branch for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBranch service method.</param>
        /// 
        /// <returns>The response from the UpdateBranch service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateBranch">REST API Reference for UpdateBranch Operation</seealso>
        UpdateBranchResponse UpdateBranch(UpdateBranchRequest request);



        /// <summary>
        /// Updates a branch for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBranch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBranch service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateBranch">REST API Reference for UpdateBranch Operation</seealso>
        Task<UpdateBranchResponse> UpdateBranchAsync(UpdateBranchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDomainAssociation


        /// <summary>
        /// Creates a new domain association for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainAssociation service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateDomainAssociation">REST API Reference for UpdateDomainAssociation Operation</seealso>
        UpdateDomainAssociationResponse UpdateDomainAssociation(UpdateDomainAssociationRequest request);



        /// <summary>
        /// Creates a new domain association for an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomainAssociation service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateDomainAssociation">REST API Reference for UpdateDomainAssociation Operation</seealso>
        Task<UpdateDomainAssociationResponse> UpdateDomainAssociationAsync(UpdateDomainAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateWebhook


        /// <summary>
        /// Updates a webhook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebhook service method.</param>
        /// 
        /// <returns>The response from the UpdateWebhook service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateWebhook">REST API Reference for UpdateWebhook Operation</seealso>
        UpdateWebhookResponse UpdateWebhook(UpdateWebhookRequest request);



        /// <summary>
        /// Updates a webhook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebhook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWebhook service method, as returned by Amplify.</returns>
        /// <exception cref="Amazon.Amplify.Model.BadRequestException">
        /// A request contains unexpected data.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.DependentServiceFailureException">
        /// An operation failed because a dependent service threw an exception.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.InternalFailureException">
        /// The service failed to perform an operation due to an internal issue.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.NotFoundException">
        /// An entity was not found during an operation.
        /// </exception>
        /// <exception cref="Amazon.Amplify.Model.UnauthorizedException">
        /// An operation failed due to a lack of access.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplify-2017-07-25/UpdateWebhook">REST API Reference for UpdateWebhook Operation</seealso>
        Task<UpdateWebhookResponse> UpdateWebhookAsync(UpdateWebhookRequest request, CancellationToken cancellationToken = default(CancellationToken));

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