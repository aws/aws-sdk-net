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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DataZone.Model;

namespace Amazon.DataZone
{
    /// <summary>
    /// Interface for accessing DataZone
    ///
    /// Amazon DataZone is a data management service that enables you to catalog, discover,
    /// govern, share, and analyze your data. With Amazon DataZone, you can share and access
    /// your data across accounts and supported regions. Amazon DataZone simplifies your experience
    /// across Amazon Web Services services, including, but not limited to, Amazon Redshift,
    /// Amazon Athena, Amazon Web Services Glue, and Amazon Web Services Lake Formation.
    /// </summary>
    public partial interface IAmazonDataZone : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IDataZonePaginatorFactory Paginators { get; }
#endif
                
        #region  AcceptPredictions



        /// <summary>
        /// Accepts automatically generated business-friendly metadata for your Amazon DataZone
        /// assets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptPredictions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptPredictions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AcceptPredictions">REST API Reference for AcceptPredictions Operation</seealso>
        Task<AcceptPredictionsResponse> AcceptPredictionsAsync(AcceptPredictionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AcceptSubscriptionRequest



        /// <summary>
        /// Accepts a subscription request to a specific asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptSubscriptionRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/AcceptSubscriptionRequest">REST API Reference for AcceptSubscriptionRequest Operation</seealso>
        Task<AcceptSubscriptionRequestResponse> AcceptSubscriptionRequestAsync(AcceptSubscriptionRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelSubscription



        /// <summary>
        /// Cancels the subscription to the specified asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSubscription service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CancelSubscription">REST API Reference for CancelSubscription Operation</seealso>
        Task<CancelSubscriptionResponse> CancelSubscriptionAsync(CancelSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAsset



        /// <summary>
        /// Creates an asset in Amazon DataZone catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAsset service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAsset">REST API Reference for CreateAsset Operation</seealso>
        Task<CreateAssetResponse> CreateAssetAsync(CreateAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAssetRevision



        /// <summary>
        /// Creates a revision of the asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssetRevision service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAssetRevision">REST API Reference for CreateAssetRevision Operation</seealso>
        Task<CreateAssetRevisionResponse> CreateAssetRevisionAsync(CreateAssetRevisionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAssetType



        /// <summary>
        /// Creates a custom asset type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAssetType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAssetType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateAssetType">REST API Reference for CreateAssetType Operation</seealso>
        Task<CreateAssetTypeResponse> CreateAssetTypeAsync(CreateAssetTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDataSource



        /// <summary>
        /// Creates an Amazon DataZone data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDomain



        /// <summary>
        /// Creates an Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEnvironment



        /// <summary>
        /// Create an Amazon DataZone environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEnvironmentProfile



        /// <summary>
        /// Creates an Amazon DataZone environment profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEnvironmentProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateEnvironmentProfile">REST API Reference for CreateEnvironmentProfile Operation</seealso>
        Task<CreateEnvironmentProfileResponse> CreateEnvironmentProfileAsync(CreateEnvironmentProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFormType



        /// <summary>
        /// Creates a metadata form type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFormType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFormType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateFormType">REST API Reference for CreateFormType Operation</seealso>
        Task<CreateFormTypeResponse> CreateFormTypeAsync(CreateFormTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGlossary



        /// <summary>
        /// Creates an Amazon DataZone business glossary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlossary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGlossary service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateGlossary">REST API Reference for CreateGlossary Operation</seealso>
        Task<CreateGlossaryResponse> CreateGlossaryAsync(CreateGlossaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGlossaryTerm



        /// <summary>
        /// Creates a business glossary term.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlossaryTerm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGlossaryTerm service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateGlossaryTerm">REST API Reference for CreateGlossaryTerm Operation</seealso>
        Task<CreateGlossaryTermResponse> CreateGlossaryTermAsync(CreateGlossaryTermRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGroupProfile



        /// <summary>
        /// Creates a group profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroupProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroupProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateGroupProfile">REST API Reference for CreateGroupProfile Operation</seealso>
        Task<CreateGroupProfileResponse> CreateGroupProfileAsync(CreateGroupProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateListingChangeSet



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateListingChangeSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateListingChangeSet service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateListingChangeSet">REST API Reference for CreateListingChangeSet Operation</seealso>
        Task<CreateListingChangeSetResponse> CreateListingChangeSetAsync(CreateListingChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProject



        /// <summary>
        /// Creates an Amazon DataZone project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProject service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateProject">REST API Reference for CreateProject Operation</seealso>
        Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProjectMembership



        /// <summary>
        /// Creates a project membership in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProjectMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProjectMembership service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateProjectMembership">REST API Reference for CreateProjectMembership Operation</seealso>
        Task<CreateProjectMembershipResponse> CreateProjectMembershipAsync(CreateProjectMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSubscriptionGrant



        /// <summary>
        /// Creates a subsscription grant in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubscriptionGrant service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateSubscriptionGrant">REST API Reference for CreateSubscriptionGrant Operation</seealso>
        Task<CreateSubscriptionGrantResponse> CreateSubscriptionGrantAsync(CreateSubscriptionGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSubscriptionRequest



        /// <summary>
        /// Creates a subscription request in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateSubscriptionRequest">REST API Reference for CreateSubscriptionRequest Operation</seealso>
        Task<CreateSubscriptionRequestResponse> CreateSubscriptionRequestAsync(CreateSubscriptionRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSubscriptionTarget



        /// <summary>
        /// Creates a subscription target in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscriptionTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubscriptionTarget service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateSubscriptionTarget">REST API Reference for CreateSubscriptionTarget Operation</seealso>
        Task<CreateSubscriptionTargetResponse> CreateSubscriptionTargetAsync(CreateSubscriptionTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUserProfile



        /// <summary>
        /// Creates a user profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUserProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUserProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/CreateUserProfile">REST API Reference for CreateUserProfile Operation</seealso>
        Task<CreateUserProfileResponse> CreateUserProfileAsync(CreateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAsset



        /// <summary>
        /// Delets an asset in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAsset service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAsset">REST API Reference for DeleteAsset Operation</seealso>
        Task<DeleteAssetResponse> DeleteAssetAsync(DeleteAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAssetType



        /// <summary>
        /// Deletes an asset type in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAssetType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAssetType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteAssetType">REST API Reference for DeleteAssetType Operation</seealso>
        Task<DeleteAssetTypeResponse> DeleteAssetTypeAsync(DeleteAssetTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDataSource



        /// <summary>
        /// Deletes a data source in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDomain



        /// <summary>
        /// Deletes a Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEnvironment



        /// <summary>
        /// Deletes an environment in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEnvironmentBlueprintConfiguration



        /// <summary>
        /// Deletes the blueprint configuration in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentBlueprintConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironmentBlueprintConfiguration service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentBlueprintConfiguration">REST API Reference for DeleteEnvironmentBlueprintConfiguration Operation</seealso>
        Task<DeleteEnvironmentBlueprintConfigurationResponse> DeleteEnvironmentBlueprintConfigurationAsync(DeleteEnvironmentBlueprintConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEnvironmentProfile



        /// <summary>
        /// Deletes an environment profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEnvironmentProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteEnvironmentProfile">REST API Reference for DeleteEnvironmentProfile Operation</seealso>
        Task<DeleteEnvironmentProfileResponse> DeleteEnvironmentProfileAsync(DeleteEnvironmentProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFormType



        /// <summary>
        /// Delets and metadata form type in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFormType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFormType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteFormType">REST API Reference for DeleteFormType Operation</seealso>
        Task<DeleteFormTypeResponse> DeleteFormTypeAsync(DeleteFormTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGlossary



        /// <summary>
        /// Deletes a business glossary in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlossary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGlossary service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteGlossary">REST API Reference for DeleteGlossary Operation</seealso>
        Task<DeleteGlossaryResponse> DeleteGlossaryAsync(DeleteGlossaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGlossaryTerm



        /// <summary>
        /// Deletes a business glossary term in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlossaryTerm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGlossaryTerm service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteGlossaryTerm">REST API Reference for DeleteGlossaryTerm Operation</seealso>
        Task<DeleteGlossaryTermResponse> DeleteGlossaryTermAsync(DeleteGlossaryTermRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteListing



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteListing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteListing service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteListing">REST API Reference for DeleteListing Operation</seealso>
        Task<DeleteListingResponse> DeleteListingAsync(DeleteListingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProject



        /// <summary>
        /// Deletes a project in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProject service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteProject">REST API Reference for DeleteProject Operation</seealso>
        Task<DeleteProjectResponse> DeleteProjectAsync(DeleteProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProjectMembership



        /// <summary>
        /// Deletes project membership in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProjectMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProjectMembership service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteProjectMembership">REST API Reference for DeleteProjectMembership Operation</seealso>
        Task<DeleteProjectMembershipResponse> DeleteProjectMembershipAsync(DeleteProjectMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSubscriptionGrant



        /// <summary>
        /// Deletes and subscription grant in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubscriptionGrant service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteSubscriptionGrant">REST API Reference for DeleteSubscriptionGrant Operation</seealso>
        Task<DeleteSubscriptionGrantResponse> DeleteSubscriptionGrantAsync(DeleteSubscriptionGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSubscriptionRequest



        /// <summary>
        /// Deletes a subscription request in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteSubscriptionRequest">REST API Reference for DeleteSubscriptionRequest Operation</seealso>
        Task<DeleteSubscriptionRequestResponse> DeleteSubscriptionRequestAsync(DeleteSubscriptionRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSubscriptionTarget



        /// <summary>
        /// Deletes a subscription target in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubscriptionTarget service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/DeleteSubscriptionTarget">REST API Reference for DeleteSubscriptionTarget Operation</seealso>
        Task<DeleteSubscriptionTargetResponse> DeleteSubscriptionTargetAsync(DeleteSubscriptionTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAsset



        /// <summary>
        /// Gets an Amazon DataZone asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAsset service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAsset service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAsset">REST API Reference for GetAsset Operation</seealso>
        Task<GetAssetResponse> GetAssetAsync(GetAssetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAssetType



        /// <summary>
        /// Gets an Amazon DataZone asset type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssetType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssetType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetAssetType">REST API Reference for GetAssetType Operation</seealso>
        Task<GetAssetTypeResponse> GetAssetTypeAsync(GetAssetTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDataSource



        /// <summary>
        /// Gets an Amazon DataZone data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        Task<GetDataSourceResponse> GetDataSourceAsync(GetDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDataSourceRun



        /// <summary>
        /// Gets an Amazon DataZone data source run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSourceRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSourceRun service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDataSourceRun">REST API Reference for GetDataSourceRun Operation</seealso>
        Task<GetDataSourceRunResponse> GetDataSourceRunAsync(GetDataSourceRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDomain



        /// <summary>
        /// Gets an Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetDomain">REST API Reference for GetDomain Operation</seealso>
        Task<GetDomainResponse> GetDomainAsync(GetDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEnvironment



        /// <summary>
        /// Gets an Amazon DataZone environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        Task<GetEnvironmentResponse> GetEnvironmentAsync(GetEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEnvironmentBlueprint



        /// <summary>
        /// Gets an Amazon DataZone blueprint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentBlueprint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironmentBlueprint service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentBlueprint">REST API Reference for GetEnvironmentBlueprint Operation</seealso>
        Task<GetEnvironmentBlueprintResponse> GetEnvironmentBlueprintAsync(GetEnvironmentBlueprintRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEnvironmentBlueprintConfiguration



        /// <summary>
        /// Gets the blueprint configuration in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentBlueprintConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironmentBlueprintConfiguration service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentBlueprintConfiguration">REST API Reference for GetEnvironmentBlueprintConfiguration Operation</seealso>
        Task<GetEnvironmentBlueprintConfigurationResponse> GetEnvironmentBlueprintConfigurationAsync(GetEnvironmentBlueprintConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEnvironmentProfile



        /// <summary>
        /// Gets an evinronment profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnvironmentProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetEnvironmentProfile">REST API Reference for GetEnvironmentProfile Operation</seealso>
        Task<GetEnvironmentProfileResponse> GetEnvironmentProfileAsync(GetEnvironmentProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFormType



        /// <summary>
        /// Gets a metadata form type in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFormType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFormType service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetFormType">REST API Reference for GetFormType Operation</seealso>
        Task<GetFormTypeResponse> GetFormTypeAsync(GetFormTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGlossary



        /// <summary>
        /// Gets a business glossary in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlossary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGlossary service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetGlossary">REST API Reference for GetGlossary Operation</seealso>
        Task<GetGlossaryResponse> GetGlossaryAsync(GetGlossaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGlossaryTerm



        /// <summary>
        /// Gets a business glossary term in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlossaryTerm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGlossaryTerm service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetGlossaryTerm">REST API Reference for GetGlossaryTerm Operation</seealso>
        Task<GetGlossaryTermResponse> GetGlossaryTermAsync(GetGlossaryTermRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGroupProfile



        /// <summary>
        /// Gets a group profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroupProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetGroupProfile">REST API Reference for GetGroupProfile Operation</seealso>
        Task<GetGroupProfileResponse> GetGroupProfileAsync(GetGroupProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetIamPortalLoginUrl



        /// <summary>
        /// Gets the data portal URL for the specified Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIamPortalLoginUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIamPortalLoginUrl service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetIamPortalLoginUrl">REST API Reference for GetIamPortalLoginUrl Operation</seealso>
        Task<GetIamPortalLoginUrlResponse> GetIamPortalLoginUrlAsync(GetIamPortalLoginUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetListing



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetListing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetListing service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetListing">REST API Reference for GetListing Operation</seealso>
        Task<GetListingResponse> GetListingAsync(GetListingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetProject



        /// <summary>
        /// Gets a project in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProject service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetProject">REST API Reference for GetProject Operation</seealso>
        Task<GetProjectResponse> GetProjectAsync(GetProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSubscription



        /// <summary>
        /// Gets a subscription in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscription service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscription">REST API Reference for GetSubscription Operation</seealso>
        Task<GetSubscriptionResponse> GetSubscriptionAsync(GetSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSubscriptionGrant



        /// <summary>
        /// Gets the subscription grant in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscriptionGrant service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscriptionGrant">REST API Reference for GetSubscriptionGrant Operation</seealso>
        Task<GetSubscriptionGrantResponse> GetSubscriptionGrantAsync(GetSubscriptionGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSubscriptionRequestDetails



        /// <summary>
        /// Gets the details of the specified subscription request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionRequestDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscriptionRequestDetails service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscriptionRequestDetails">REST API Reference for GetSubscriptionRequestDetails Operation</seealso>
        Task<GetSubscriptionRequestDetailsResponse> GetSubscriptionRequestDetailsAsync(GetSubscriptionRequestDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSubscriptionTarget



        /// <summary>
        /// Gets the subscription target in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscriptionTarget service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetSubscriptionTarget">REST API Reference for GetSubscriptionTarget Operation</seealso>
        Task<GetSubscriptionTargetResponse> GetSubscriptionTargetAsync(GetSubscriptionTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUserProfile



        /// <summary>
        /// Gets a user profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUserProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/GetUserProfile">REST API Reference for GetUserProfile Operation</seealso>
        Task<GetUserProfileResponse> GetUserProfileAsync(GetUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAssetRevisions



        /// <summary>
        /// Lists the revisions for the asset.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssetRevisions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssetRevisions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListAssetRevisions">REST API Reference for ListAssetRevisions Operation</seealso>
        Task<ListAssetRevisionsResponse> ListAssetRevisionsAsync(ListAssetRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDataSourceRunActivities



        /// <summary>
        /// Lists data source run activities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceRunActivities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSourceRunActivities service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataSourceRunActivities">REST API Reference for ListDataSourceRunActivities Operation</seealso>
        Task<ListDataSourceRunActivitiesResponse> ListDataSourceRunActivitiesAsync(ListDataSourceRunActivitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDataSourceRuns



        /// <summary>
        /// Lists data source runs in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSourceRuns service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataSourceRuns">REST API Reference for ListDataSourceRuns Operation</seealso>
        Task<ListDataSourceRunsResponse> ListDataSourceRunsAsync(ListDataSourceRunsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDataSources



        /// <summary>
        /// Lists data sources in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDomains



        /// <summary>
        /// Lists Amazon DataZone domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListDomains">REST API Reference for ListDomains Operation</seealso>
        Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEnvironmentBlueprintConfigurations



        /// <summary>
        /// Lists blueprint configurations for a Amazon DataZone environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentBlueprintConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironmentBlueprintConfigurations service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentBlueprintConfigurations">REST API Reference for ListEnvironmentBlueprintConfigurations Operation</seealso>
        Task<ListEnvironmentBlueprintConfigurationsResponse> ListEnvironmentBlueprintConfigurationsAsync(ListEnvironmentBlueprintConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEnvironmentBlueprints



        /// <summary>
        /// Lists blueprints in an Amazon DataZone environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentBlueprints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironmentBlueprints service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentBlueprints">REST API Reference for ListEnvironmentBlueprints Operation</seealso>
        Task<ListEnvironmentBlueprintsResponse> ListEnvironmentBlueprintsAsync(ListEnvironmentBlueprintsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEnvironmentProfiles



        /// <summary>
        /// Lists Amazon DataZone environment profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironmentProfiles service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironmentProfiles">REST API Reference for ListEnvironmentProfiles Operation</seealso>
        Task<ListEnvironmentProfilesResponse> ListEnvironmentProfilesAsync(ListEnvironmentProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEnvironments



        /// <summary>
        /// Lists Amazon DataZone environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNotifications



        /// <summary>
        /// Lists all Amazon DataZone notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotifications service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListNotifications">REST API Reference for ListNotifications Operation</seealso>
        Task<ListNotificationsResponse> ListNotificationsAsync(ListNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProjectMemberships



        /// <summary>
        /// Lists all members of the specified project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjectMemberships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProjectMemberships service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListProjectMemberships">REST API Reference for ListProjectMemberships Operation</seealso>
        Task<ListProjectMembershipsResponse> ListProjectMembershipsAsync(ListProjectMembershipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProjects



        /// <summary>
        /// Lists Amazon DataZone projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProjects service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListProjects">REST API Reference for ListProjects Operation</seealso>
        Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSubscriptionGrants



        /// <summary>
        /// Lists subscription grants.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionGrants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptionGrants service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptionGrants">REST API Reference for ListSubscriptionGrants Operation</seealso>
        Task<ListSubscriptionGrantsResponse> ListSubscriptionGrantsAsync(ListSubscriptionGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSubscriptionRequests



        /// <summary>
        /// Lists Amazon DataZone subscription requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionRequests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptionRequests service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptionRequests">REST API Reference for ListSubscriptionRequests Operation</seealso>
        Task<ListSubscriptionRequestsResponse> ListSubscriptionRequestsAsync(ListSubscriptionRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSubscriptions



        /// <summary>
        /// Lists subscriptions in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSubscriptionTargets



        /// <summary>
        /// Lists subscription targets in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptionTargets service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListSubscriptionTargets">REST API Reference for ListSubscriptionTargets Operation</seealso>
        Task<ListSubscriptionTargetsResponse> ListSubscriptionTargetsAsync(ListSubscriptionTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists tags for the specified resource in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutEnvironmentBlueprintConfiguration



        /// <summary>
        /// Writes the configuration for the specified environment blueprint in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEnvironmentBlueprintConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEnvironmentBlueprintConfiguration service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/PutEnvironmentBlueprintConfiguration">REST API Reference for PutEnvironmentBlueprintConfiguration Operation</seealso>
        Task<PutEnvironmentBlueprintConfigurationResponse> PutEnvironmentBlueprintConfigurationAsync(PutEnvironmentBlueprintConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RejectPredictions



        /// <summary>
        /// Rejects automatically generated business-friendly metadata for your Amazon DataZone
        /// assets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectPredictions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectPredictions service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RejectPredictions">REST API Reference for RejectPredictions Operation</seealso>
        Task<RejectPredictionsResponse> RejectPredictionsAsync(RejectPredictionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RejectSubscriptionRequest



        /// <summary>
        /// Rejects the specified subscription request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectSubscriptionRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RejectSubscriptionRequest">REST API Reference for RejectSubscriptionRequest Operation</seealso>
        Task<RejectSubscriptionRequestResponse> RejectSubscriptionRequestAsync(RejectSubscriptionRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RevokeSubscription



        /// <summary>
        /// Revokes a specified subscription in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeSubscription service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/RevokeSubscription">REST API Reference for RevokeSubscription Operation</seealso>
        Task<RevokeSubscriptionResponse> RevokeSubscriptionAsync(RevokeSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Search



        /// <summary>
        /// Searches for assets in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Search service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Search service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/Search">REST API Reference for Search Operation</seealso>
        Task<SearchResponse> SearchAsync(SearchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchGroupProfiles



        /// <summary>
        /// Searches group profiles in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchGroupProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchGroupProfiles service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchGroupProfiles">REST API Reference for SearchGroupProfiles Operation</seealso>
        Task<SearchGroupProfilesResponse> SearchGroupProfilesAsync(SearchGroupProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchListings



        /// <summary>
        /// Searches listings in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchListings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchListings service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchListings">REST API Reference for SearchListings Operation</seealso>
        Task<SearchListingsResponse> SearchListingsAsync(SearchListingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchTypes



        /// <summary>
        /// Searches for types in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchTypes service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchTypes">REST API Reference for SearchTypes Operation</seealso>
        Task<SearchTypesResponse> SearchTypesAsync(SearchTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchUserProfiles



        /// <summary>
        /// Searches user profiles in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchUserProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SearchUserProfiles service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/SearchUserProfiles">REST API Reference for SearchUserProfiles Operation</seealso>
        Task<SearchUserProfilesResponse> SearchUserProfilesAsync(SearchUserProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartDataSourceRun



        /// <summary>
        /// Start the run of the specified data source in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataSourceRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDataSourceRun service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/StartDataSourceRun">REST API Reference for StartDataSourceRun Operation</seealso>
        Task<StartDataSourceRunResponse> StartDataSourceRunAsync(StartDataSourceRunRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Tags a resource in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Untags a resource in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDataSource



        /// <summary>
        /// Updates the specified data source in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDomain



        /// <summary>
        /// Updates a Amazon DataZone domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomain service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateDomain">REST API Reference for UpdateDomain Operation</seealso>
        Task<UpdateDomainResponse> UpdateDomainAsync(UpdateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEnvironment



        /// <summary>
        /// Updates the specified environment in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateEnvironmentProfile



        /// <summary>
        /// Updates the specified environment profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnvironmentProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateEnvironmentProfile">REST API Reference for UpdateEnvironmentProfile Operation</seealso>
        Task<UpdateEnvironmentProfileResponse> UpdateEnvironmentProfileAsync(UpdateEnvironmentProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGlossary



        /// <summary>
        /// Updates the business glossary in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlossary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGlossary service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateGlossary">REST API Reference for UpdateGlossary Operation</seealso>
        Task<UpdateGlossaryResponse> UpdateGlossaryAsync(UpdateGlossaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGlossaryTerm



        /// <summary>
        /// Updates a business glossary term in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlossaryTerm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGlossaryTerm service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateGlossaryTerm">REST API Reference for UpdateGlossaryTerm Operation</seealso>
        Task<UpdateGlossaryTermResponse> UpdateGlossaryTermAsync(UpdateGlossaryTermRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGroupProfile



        /// <summary>
        /// Updates the specified group profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroupProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGroupProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateGroupProfile">REST API Reference for UpdateGroupProfile Operation</seealso>
        Task<UpdateGroupProfileResponse> UpdateGroupProfileAsync(UpdateGroupProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateProject



        /// <summary>
        /// Updates the specified project in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProject service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ServiceQuotaExceededException">
        /// The request has exceeded the specified service quota.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateProject">REST API Reference for UpdateProject Operation</seealso>
        Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSubscriptionGrantStatus



        /// <summary>
        /// Updates the status of the specified subscription grant status in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionGrantStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSubscriptionGrantStatus service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateSubscriptionGrantStatus">REST API Reference for UpdateSubscriptionGrantStatus Operation</seealso>
        Task<UpdateSubscriptionGrantStatusResponse> UpdateSubscriptionGrantStatusAsync(UpdateSubscriptionGrantStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSubscriptionRequest



        /// <summary>
        /// Updates a specified subscription request in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSubscriptionRequest service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateSubscriptionRequest">REST API Reference for UpdateSubscriptionRequest Operation</seealso>
        Task<UpdateSubscriptionRequestResponse> UpdateSubscriptionRequestAsync(UpdateSubscriptionRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSubscriptionTarget



        /// <summary>
        /// Updates the specified subscription target in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscriptionTarget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSubscriptionTarget service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ConflictException">
        /// There is a conflict while performing this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateSubscriptionTarget">REST API Reference for UpdateSubscriptionTarget Operation</seealso>
        Task<UpdateSubscriptionTargetResponse> UpdateSubscriptionTargetAsync(UpdateSubscriptionTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUserProfile



        /// <summary>
        /// Updates the specified user profile in Amazon DataZone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUserProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUserProfile service method, as returned by DataZone.</returns>
        /// <exception cref="Amazon.DataZone.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.InternalServerException">
        /// The request has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ResourceNotFoundException">
        /// The specified resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.UnauthorizedException">
        /// You do not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.DataZone.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datazone-2018-05-10/UpdateUserProfile">REST API Reference for UpdateUserProfile Operation</seealso>
        Task<UpdateUserProfileResponse> UpdateUserProfileAsync(UpdateUserProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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