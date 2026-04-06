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
 * Do not modify this file. This file is generated from the connecthealth-2025-01-29.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ConnectHealth.Model;

#pragma warning disable CS1570
namespace Amazon.ConnectHealth
{
    /// <summary>
    /// <para>Interface for accessing ConnectHealth</para>
    ///
    /// Health Agent for healthcare providers and patient engagement
    /// </summary>
    public partial interface IAmazonConnectHealth : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IConnectHealthPaginatorFactory Paginators { get; }

        
        #region  ActivateSubscription


        /// <summary>
        /// Activates a Subscription to enable billing for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateSubscription service method.</param>
        /// 
        /// <returns>The response from the ActivateSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ActivateSubscription">REST API Reference for ActivateSubscription Operation</seealso>
        ActivateSubscriptionResponse ActivateSubscription(ActivateSubscriptionRequest request);



        /// <summary>
        /// Activates a Subscription to enable billing for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivateSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ActivateSubscription">REST API Reference for ActivateSubscription Operation</seealso>
        Task<ActivateSubscriptionResponse> ActivateSubscriptionAsync(ActivateSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDomain


        /// <summary>
        /// Creates a new Domain for managing HealthAgent resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        CreateDomainResponse CreateDomain(CreateDomainRequest request);



        /// <summary>
        /// Creates a new Domain for managing HealthAgent resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSubscription


        /// <summary>
        /// Creates a new Subscription within a Domain for billing and user management.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        CreateSubscriptionResponse CreateSubscription(CreateSubscriptionRequest request);



        /// <summary>
        /// Creates a new Subscription within a Domain for billing and user management.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        Task<CreateSubscriptionResponse> CreateSubscriptionAsync(CreateSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeactivateSubscription


        /// <summary>
        /// Deactivates a Subscription to stop billing for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateSubscription service method.</param>
        /// 
        /// <returns>The response from the DeactivateSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/DeactivateSubscription">REST API Reference for DeactivateSubscription Operation</seealso>
        DeactivateSubscriptionResponse DeactivateSubscription(DeactivateSubscriptionRequest request);



        /// <summary>
        /// Deactivates a Subscription to stop billing for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeactivateSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/DeactivateSubscription">REST API Reference for DeactivateSubscription Operation</seealso>
        Task<DeactivateSubscriptionResponse> DeactivateSubscriptionAsync(DeactivateSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDomain


        /// <summary>
        /// Deletes a Domain and all associated resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        DeleteDomainResponse DeleteDomain(DeleteDomainRequest request);



        /// <summary>
        /// Deletes a Domain and all associated resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDomain


        /// <summary>
        /// Retrieves information about a Domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetDomain">REST API Reference for GetDomain Operation</seealso>
        GetDomainResponse GetDomain(GetDomainRequest request);



        /// <summary>
        /// Retrieves information about a Domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomain service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetDomain">REST API Reference for GetDomain Operation</seealso>
        Task<GetDomainResponse> GetDomainAsync(GetDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMedicalScribeListeningSession


        /// <summary>
        /// Retrieves details about an existing Medical Scribe listening session
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalScribeListeningSession service method.</param>
        /// 
        /// <returns>The response from the GetMedicalScribeListeningSession service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetMedicalScribeListeningSession">REST API Reference for GetMedicalScribeListeningSession Operation</seealso>
        GetMedicalScribeListeningSessionResponse GetMedicalScribeListeningSession(GetMedicalScribeListeningSessionRequest request);



        /// <summary>
        /// Retrieves details about an existing Medical Scribe listening session
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedicalScribeListeningSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMedicalScribeListeningSession service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetMedicalScribeListeningSession">REST API Reference for GetMedicalScribeListeningSession Operation</seealso>
        Task<GetMedicalScribeListeningSessionResponse> GetMedicalScribeListeningSessionAsync(GetMedicalScribeListeningSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPatientInsightsJob


        /// <summary>
        /// Get details of a started patient insights job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPatientInsightsJob service method.</param>
        /// 
        /// <returns>The response from the GetPatientInsightsJob service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetPatientInsightsJob">REST API Reference for GetPatientInsightsJob Operation</seealso>
        GetPatientInsightsJobResponse GetPatientInsightsJob(GetPatientInsightsJobRequest request);



        /// <summary>
        /// Get details of a started patient insights job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPatientInsightsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPatientInsightsJob service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetPatientInsightsJob">REST API Reference for GetPatientInsightsJob Operation</seealso>
        Task<GetPatientInsightsJobResponse> GetPatientInsightsJobAsync(GetPatientInsightsJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSubscription


        /// <summary>
        /// Retrieves information about a Subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscription service method.</param>
        /// 
        /// <returns>The response from the GetSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetSubscription">REST API Reference for GetSubscription Operation</seealso>
        GetSubscriptionResponse GetSubscription(GetSubscriptionRequest request);



        /// <summary>
        /// Retrieves information about a Subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubscription service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/GetSubscription">REST API Reference for GetSubscription Operation</seealso>
        Task<GetSubscriptionResponse> GetSubscriptionAsync(GetSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDomains


        /// <summary>
        /// Lists Domains for a given account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ListDomains">REST API Reference for ListDomains Operation</seealso>
        ListDomainsResponse ListDomains(ListDomainsRequest request);



        /// <summary>
        /// Lists Domains for a given account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomains service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ListDomains">REST API Reference for ListDomains Operation</seealso>
        Task<ListDomainsResponse> ListDomainsAsync(ListDomainsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSubscriptions


        /// <summary>
        /// Lists all Subscriptions within a Domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request);



        /// <summary>
        /// Lists all Subscriptions within a Domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags associated with the specified resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the tags associated with the specified resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartPatientInsightsJob


        /// <summary>
        /// Starts a new patient insights job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPatientInsightsJob service method.</param>
        /// 
        /// <returns>The response from the StartPatientInsightsJob service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ConflictException">
        /// This error is thrown when a resource update is no longer valid due to assumptions
        /// about initial state changing.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/StartPatientInsightsJob">REST API Reference for StartPatientInsightsJob Operation</seealso>
        StartPatientInsightsJobResponse StartPatientInsightsJob(StartPatientInsightsJobRequest request);



        /// <summary>
        /// Starts a new patient insights job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPatientInsightsJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartPatientInsightsJob service method, as returned by ConnectHealth.</returns>
        /// <exception cref="Amazon.ConnectHealth.Model.AccessDeniedException">
        /// This error is thrown when the client does not supply proper credentials to the API.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ConflictException">
        /// This error is thrown when a resource update is no longer valid due to assumptions
        /// about initial state changing.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.InternalServerException">
        /// This error is thrown when a transient error causes our API to fail.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ResourceNotFoundException">
        /// This error is thrown when the requested resource is not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ThrottlingException">
        /// This error is thrown when the client exceeds the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.ConnectHealth.Model.ValidationException">
        /// This error is thrown when the client supplies invalid input to the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/StartPatientInsightsJob">REST API Reference for StartPatientInsightsJob Operation</seealso>
        Task<StartPatientInsightsJobResponse> StartPatientInsightsJobAsync(StartPatientInsightsJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates the specified tags with the specified resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Associates the specified tags with the specified resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the specified resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes the specified tags from the specified resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ConnectHealth.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connecthealth-2025-01-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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