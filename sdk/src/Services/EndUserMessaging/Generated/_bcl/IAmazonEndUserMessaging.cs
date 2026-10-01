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
 * Do not modify this file. This file is generated from the endusermessaging-2026-09-21.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.EndUserMessaging.Model;

#pragma warning disable CS1570
namespace Amazon.EndUserMessaging
{
    /// <summary>
    /// <para>Interface for accessing EndUserMessaging</para>
    ///
    /// AWS End User Messaging provides a set of APIs to manage brand profiles, synchronize
    /// brand profile data with SMS and Rich Communication Services (RCS) registrations, and
    /// send and validate one-time passcodes across the SMS, voice, and WhatsApp channels.
    /// </summary>
    public partial interface IAmazonEndUserMessaging : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IEndUserMessagingPaginatorFactory Paginators { get; }

        
        #region  CreateBrandProfile


        /// <summary>
        /// Creates a brand profile. A brand profile is a lightweight container that holds your
        /// brand identity information as flexible attributes. After you create a brand profile,
        /// use the CreateBrandProfileAttributes operation to add company information, addresses,
        /// compliance documents, and logos.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBrandProfile service method.</param>
        /// 
        /// <returns>The response from the CreateBrandProfile service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/CreateBrandProfile">REST API Reference for CreateBrandProfile Operation</seealso>
        CreateBrandProfileResponse CreateBrandProfile(CreateBrandProfileRequest request);



        /// <summary>
        /// Creates a brand profile. A brand profile is a lightweight container that holds your
        /// brand identity information as flexible attributes. After you create a brand profile,
        /// use the CreateBrandProfileAttributes operation to add company information, addresses,
        /// compliance documents, and logos.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBrandProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBrandProfile service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/CreateBrandProfile">REST API Reference for CreateBrandProfile Operation</seealso>
        Task<CreateBrandProfileResponse> CreateBrandProfileAsync(CreateBrandProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateBrandProfileAttributes


        /// <summary>
        /// Creates up to 10 attributes for a brand profile in a single request. For attributes
        /// of type IMAGE or DOCUMENT, the response includes a presigned Amazon S3 URL that you
        /// use to upload the media. This operation is atomic: either all of the attributes are
        /// created, or none of them are.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBrandProfileAttributes service method.</param>
        /// 
        /// <returns>The response from the CreateBrandProfileAttributes service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/CreateBrandProfileAttributes">REST API Reference for CreateBrandProfileAttributes Operation</seealso>
        CreateBrandProfileAttributesResponse CreateBrandProfileAttributes(CreateBrandProfileAttributesRequest request);



        /// <summary>
        /// Creates up to 10 attributes for a brand profile in a single request. For attributes
        /// of type IMAGE or DOCUMENT, the response includes a presigned Amazon S3 URL that you
        /// use to upload the media. This operation is atomic: either all of the attributes are
        /// created, or none of them are.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBrandProfileAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBrandProfileAttributes service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/CreateBrandProfileAttributes">REST API Reference for CreateBrandProfileAttributes Operation</seealso>
        Task<CreateBrandProfileAttributesResponse> CreateBrandProfileAttributesAsync(CreateBrandProfileAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateBrandProfileFromRegistration


        /// <summary>
        /// Creates a brand profile and populates its attributes from an existing registration.
        /// This operation runs asynchronously. Use the GetJob operation to track its progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBrandProfileFromRegistration service method.</param>
        /// 
        /// <returns>The response from the CreateBrandProfileFromRegistration service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/CreateBrandProfileFromRegistration">REST API Reference for CreateBrandProfileFromRegistration Operation</seealso>
        CreateBrandProfileFromRegistrationResponse CreateBrandProfileFromRegistration(CreateBrandProfileFromRegistrationRequest request);



        /// <summary>
        /// Creates a brand profile and populates its attributes from an existing registration.
        /// This operation runs asynchronously. Use the GetJob operation to track its progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBrandProfileFromRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBrandProfileFromRegistration service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/CreateBrandProfileFromRegistration">REST API Reference for CreateBrandProfileFromRegistration Operation</seealso>
        Task<CreateBrandProfileFromRegistrationResponse> CreateBrandProfileFromRegistrationAsync(CreateBrandProfileFromRegistrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateNotifyCodeConfiguration


        /// <summary>
        /// Creates a notify code configuration. A notify code configuration is a reusable policy
        /// that defines how one-time passcodes are generated and rendered, including the code
        /// type, length, validity period, maximum number of attempts, and channel templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotifyCodeConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateNotifyCodeConfiguration service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/CreateNotifyCodeConfiguration">REST API Reference for CreateNotifyCodeConfiguration Operation</seealso>
        CreateNotifyCodeConfigurationResponse CreateNotifyCodeConfiguration(CreateNotifyCodeConfigurationRequest request);



        /// <summary>
        /// Creates a notify code configuration. A notify code configuration is a reusable policy
        /// that defines how one-time passcodes are generated and rendered, including the code
        /// type, length, validity period, maximum number of attempts, and channel templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotifyCodeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNotifyCodeConfiguration service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/CreateNotifyCodeConfiguration">REST API Reference for CreateNotifyCodeConfiguration Operation</seealso>
        Task<CreateNotifyCodeConfigurationResponse> CreateNotifyCodeConfigurationAsync(CreateNotifyCodeConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRegistrationsFromBrandProfile


        /// <summary>
        /// Creates one or more registrations in the DRAFT state and prefills their fields from
        /// the attributes of a brand profile. This operation runs asynchronously. Use the GetJob
        /// operation to track its progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistrationsFromBrandProfile service method.</param>
        /// 
        /// <returns>The response from the CreateRegistrationsFromBrandProfile service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/CreateRegistrationsFromBrandProfile">REST API Reference for CreateRegistrationsFromBrandProfile Operation</seealso>
        CreateRegistrationsFromBrandProfileResponse CreateRegistrationsFromBrandProfile(CreateRegistrationsFromBrandProfileRequest request);



        /// <summary>
        /// Creates one or more registrations in the DRAFT state and prefills their fields from
        /// the attributes of a brand profile. This operation runs asynchronously. Use the GetJob
        /// operation to track its progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistrationsFromBrandProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegistrationsFromBrandProfile service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/CreateRegistrationsFromBrandProfile">REST API Reference for CreateRegistrationsFromBrandProfile Operation</seealso>
        Task<CreateRegistrationsFromBrandProfileResponse> CreateRegistrationsFromBrandProfileAsync(CreateRegistrationsFromBrandProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBrandProfile


        /// <summary>
        /// Deletes a brand profile. This operation also deletes the attributes of the profile
        /// and any associated media. The request fails if deletion protection is enabled for
        /// the profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrandProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteBrandProfile service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/DeleteBrandProfile">REST API Reference for DeleteBrandProfile Operation</seealso>
        DeleteBrandProfileResponse DeleteBrandProfile(DeleteBrandProfileRequest request);



        /// <summary>
        /// Deletes a brand profile. This operation also deletes the attributes of the profile
        /// and any associated media. The request fails if deletion protection is enabled for
        /// the profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrandProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBrandProfile service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/DeleteBrandProfile">REST API Reference for DeleteBrandProfile Operation</seealso>
        Task<DeleteBrandProfileResponse> DeleteBrandProfileAsync(DeleteBrandProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBrandProfileAttribute


        /// <summary>
        /// Deletes a brand profile attribute. If the attribute stores media, this operation also
        /// deletes the associated media.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrandProfileAttribute service method.</param>
        /// 
        /// <returns>The response from the DeleteBrandProfileAttribute service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/DeleteBrandProfileAttribute">REST API Reference for DeleteBrandProfileAttribute Operation</seealso>
        DeleteBrandProfileAttributeResponse DeleteBrandProfileAttribute(DeleteBrandProfileAttributeRequest request);



        /// <summary>
        /// Deletes a brand profile attribute. If the attribute stores media, this operation also
        /// deletes the associated media.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrandProfileAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBrandProfileAttribute service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/DeleteBrandProfileAttribute">REST API Reference for DeleteBrandProfileAttribute Operation</seealso>
        Task<DeleteBrandProfileAttributeResponse> DeleteBrandProfileAttributeAsync(DeleteBrandProfileAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteNotifyCodeConfiguration


        /// <summary>
        /// Deletes a notify code configuration. Verifications that are already in progress are
        /// not affected, because they capture the policy at the time that the passcode was sent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotifyCodeConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteNotifyCodeConfiguration service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/DeleteNotifyCodeConfiguration">REST API Reference for DeleteNotifyCodeConfiguration Operation</seealso>
        DeleteNotifyCodeConfigurationResponse DeleteNotifyCodeConfiguration(DeleteNotifyCodeConfigurationRequest request);



        /// <summary>
        /// Deletes a notify code configuration. Verifications that are already in progress are
        /// not affected, because they capture the policy at the time that the passcode was sent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotifyCodeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNotifyCodeConfiguration service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/DeleteNotifyCodeConfiguration">REST API Reference for DeleteNotifyCodeConfiguration Operation</seealso>
        Task<DeleteNotifyCodeConfigurationResponse> DeleteNotifyCodeConfigurationAsync(DeleteNotifyCodeConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBrandProfile


        /// <summary>
        /// Retrieves the metadata for a brand profile, including its name, status, deletion protection
        /// setting, and timestamps. To retrieve the attributes of the profile, use the ListBrandProfileAttributes
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBrandProfile service method.</param>
        /// 
        /// <returns>The response from the GetBrandProfile service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/GetBrandProfile">REST API Reference for GetBrandProfile Operation</seealso>
        GetBrandProfileResponse GetBrandProfile(GetBrandProfileRequest request);



        /// <summary>
        /// Retrieves the metadata for a brand profile, including its name, status, deletion protection
        /// setting, and timestamps. To retrieve the attributes of the profile, use the ListBrandProfileAttributes
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBrandProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBrandProfile service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/GetBrandProfile">REST API Reference for GetBrandProfile Operation</seealso>
        Task<GetBrandProfileResponse> GetBrandProfileAsync(GetBrandProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBrandProfileAttribute


        /// <summary>
        /// Retrieves a single brand profile attribute.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBrandProfileAttribute service method.</param>
        /// 
        /// <returns>The response from the GetBrandProfileAttribute service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/GetBrandProfileAttribute">REST API Reference for GetBrandProfileAttribute Operation</seealso>
        GetBrandProfileAttributeResponse GetBrandProfileAttribute(GetBrandProfileAttributeRequest request);



        /// <summary>
        /// Retrieves a single brand profile attribute.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBrandProfileAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBrandProfileAttribute service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/GetBrandProfileAttribute">REST API Reference for GetBrandProfileAttribute Operation</seealso>
        Task<GetBrandProfileAttributeResponse> GetBrandProfileAttributeAsync(GetBrandProfileAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetJob


        /// <summary>
        /// Retrieves the current state of an asynchronous job, including its status and any resources
        /// that it created or updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/GetJob">REST API Reference for GetJob Operation</seealso>
        GetJobResponse GetJob(GetJobRequest request);



        /// <summary>
        /// Retrieves the current state of an asynchronous job, including its status and any resources
        /// that it created or updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/GetJob">REST API Reference for GetJob Operation</seealso>
        Task<GetJobResponse> GetJobAsync(GetJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetNotifyCodeConfiguration


        /// <summary>
        /// Retrieves a notify code configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotifyCodeConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetNotifyCodeConfiguration service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/GetNotifyCodeConfiguration">REST API Reference for GetNotifyCodeConfiguration Operation</seealso>
        GetNotifyCodeConfigurationResponse GetNotifyCodeConfiguration(GetNotifyCodeConfigurationRequest request);



        /// <summary>
        /// Retrieves a notify code configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotifyCodeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNotifyCodeConfiguration service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/GetNotifyCodeConfiguration">REST API Reference for GetNotifyCodeConfiguration Operation</seealso>
        Task<GetNotifyCodeConfigurationResponse> GetNotifyCodeConfigurationAsync(GetNotifyCodeConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListBrandProfileAttributes


        /// <summary>
        /// Retrieves a paginated list of the attributes for a brand profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrandProfileAttributes service method.</param>
        /// 
        /// <returns>The response from the ListBrandProfileAttributes service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/ListBrandProfileAttributes">REST API Reference for ListBrandProfileAttributes Operation</seealso>
        ListBrandProfileAttributesResponse ListBrandProfileAttributes(ListBrandProfileAttributesRequest request);



        /// <summary>
        /// Retrieves a paginated list of the attributes for a brand profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrandProfileAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBrandProfileAttributes service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/ListBrandProfileAttributes">REST API Reference for ListBrandProfileAttributes Operation</seealso>
        Task<ListBrandProfileAttributesResponse> ListBrandProfileAttributesAsync(ListBrandProfileAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListBrandProfiles


        /// <summary>
        /// Retrieves a paginated list of the brand profiles in your account. Use the nextToken
        /// parameter to retrieve additional results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrandProfiles service method.</param>
        /// 
        /// <returns>The response from the ListBrandProfiles service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/ListBrandProfiles">REST API Reference for ListBrandProfiles Operation</seealso>
        ListBrandProfilesResponse ListBrandProfiles(ListBrandProfilesRequest request);



        /// <summary>
        /// Retrieves a paginated list of the brand profiles in your account. Use the nextToken
        /// parameter to retrieve additional results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrandProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBrandProfiles service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/ListBrandProfiles">REST API Reference for ListBrandProfiles Operation</seealso>
        Task<ListBrandProfilesResponse> ListBrandProfilesAsync(ListBrandProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListJobs


        /// <summary>
        /// Retrieves a paginated list of the asynchronous jobs in your account. You can filter
        /// the results by status, brand profile, or operation type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/ListJobs">REST API Reference for ListJobs Operation</seealso>
        ListJobsResponse ListJobs(ListJobsRequest request);



        /// <summary>
        /// Retrieves a paginated list of the asynchronous jobs in your account. You can filter
        /// the results by status, brand profile, or operation type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/ListJobs">REST API Reference for ListJobs Operation</seealso>
        Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListNotifyCodeConfigurations


        /// <summary>
        /// Retrieves a paginated list of the notify code configurations in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotifyCodeConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListNotifyCodeConfigurations service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/ListNotifyCodeConfigurations">REST API Reference for ListNotifyCodeConfigurations Operation</seealso>
        ListNotifyCodeConfigurationsResponse ListNotifyCodeConfigurations(ListNotifyCodeConfigurationsRequest request);



        /// <summary>
        /// Retrieves a paginated list of the notify code configurations in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotifyCodeConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotifyCodeConfigurations service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/ListNotifyCodeConfigurations">REST API Reference for ListNotifyCodeConfigurations Operation</seealso>
        Task<ListNotifyCodeConfigurationsResponse> ListNotifyCodeConfigurationsAsync(ListNotifyCodeConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRegistrationsFromBrandProfile


        /// <summary>
        /// Retrieves a paginated list of the registrations that were created from a brand profile
        /// through the synchronization operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistrationsFromBrandProfile service method.</param>
        /// 
        /// <returns>The response from the ListRegistrationsFromBrandProfile service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/ListRegistrationsFromBrandProfile">REST API Reference for ListRegistrationsFromBrandProfile Operation</seealso>
        ListRegistrationsFromBrandProfileResponse ListRegistrationsFromBrandProfile(ListRegistrationsFromBrandProfileRequest request);



        /// <summary>
        /// Retrieves a paginated list of the registrations that were created from a brand profile
        /// through the synchronization operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistrationsFromBrandProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegistrationsFromBrandProfile service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/ListRegistrationsFromBrandProfile">REST API Reference for ListRegistrationsFromBrandProfile Operation</seealso>
        Task<ListRegistrationsFromBrandProfileResponse> ListRegistrationsFromBrandProfileAsync(ListRegistrationsFromBrandProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves the tags that are associated with a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Retrieves the tags that are associated with a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendNotifyCodeVerification


        /// <summary>
        /// Generates a one-time passcode and delivers it to a recipient over the requested channel.
        /// The passcode policy is captured from the referenced notify code configuration at the
        /// time of the request, so later updates to the configuration do not affect verifications
        /// that are already in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendNotifyCodeVerification service method.</param>
        /// 
        /// <returns>The response from the SendNotifyCodeVerification service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/SendNotifyCodeVerification">REST API Reference for SendNotifyCodeVerification Operation</seealso>
        SendNotifyCodeVerificationResponse SendNotifyCodeVerification(SendNotifyCodeVerificationRequest request);



        /// <summary>
        /// Generates a one-time passcode and delivers it to a recipient over the requested channel.
        /// The passcode policy is captured from the referenced notify code configuration at the
        /// time of the request, so later updates to the configuration do not affect verifications
        /// that are already in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendNotifyCodeVerification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendNotifyCodeVerification service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/SendNotifyCodeVerification">REST API Reference for SendNotifyCodeVerification Operation</seealso>
        Task<SendNotifyCodeVerificationResponse> SendNotifyCodeVerificationAsync(SendNotifyCodeVerificationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or overwrites the tags on a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds or overwrites the tags on a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes the specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateBrandProfile


        /// <summary>
        /// Updates the name or the deletion protection setting of a brand profile. To change
        /// the information that is stored in the profile, use the brand profile attribute operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrandProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateBrandProfile service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/UpdateBrandProfile">REST API Reference for UpdateBrandProfile Operation</seealso>
        UpdateBrandProfileResponse UpdateBrandProfile(UpdateBrandProfileRequest request);



        /// <summary>
        /// Updates the name or the deletion protection setting of a brand profile. To change
        /// the information that is stored in the profile, use the brand profile attribute operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrandProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBrandProfile service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/UpdateBrandProfile">REST API Reference for UpdateBrandProfile Operation</seealso>
        Task<UpdateBrandProfileResponse> UpdateBrandProfileAsync(UpdateBrandProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateBrandProfileAttribute


        /// <summary>
        /// Updates the value, description, or category of an existing brand profile attribute.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrandProfileAttribute service method.</param>
        /// 
        /// <returns>The response from the UpdateBrandProfileAttribute service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/UpdateBrandProfileAttribute">REST API Reference for UpdateBrandProfileAttribute Operation</seealso>
        UpdateBrandProfileAttributeResponse UpdateBrandProfileAttribute(UpdateBrandProfileAttributeRequest request);



        /// <summary>
        /// Updates the value, description, or category of an existing brand profile attribute.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrandProfileAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBrandProfileAttribute service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/UpdateBrandProfileAttribute">REST API Reference for UpdateBrandProfileAttribute Operation</seealso>
        Task<UpdateBrandProfileAttributeResponse> UpdateBrandProfileAttributeAsync(UpdateBrandProfileAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateBrandProfileFromRegistration


        /// <summary>
        /// Imports or refreshes the attributes of an existing brand profile from an existing
        /// registration. This operation runs asynchronously. Use the GetJob operation to track
        /// its progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrandProfileFromRegistration service method.</param>
        /// 
        /// <returns>The response from the UpdateBrandProfileFromRegistration service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/UpdateBrandProfileFromRegistration">REST API Reference for UpdateBrandProfileFromRegistration Operation</seealso>
        UpdateBrandProfileFromRegistrationResponse UpdateBrandProfileFromRegistration(UpdateBrandProfileFromRegistrationRequest request);



        /// <summary>
        /// Imports or refreshes the attributes of an existing brand profile from an existing
        /// registration. This operation runs asynchronously. Use the GetJob operation to track
        /// its progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrandProfileFromRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBrandProfileFromRegistration service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/UpdateBrandProfileFromRegistration">REST API Reference for UpdateBrandProfileFromRegistration Operation</seealso>
        Task<UpdateBrandProfileFromRegistrationResponse> UpdateBrandProfileFromRegistrationAsync(UpdateBrandProfileFromRegistrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateNotifyCodeConfiguration


        /// <summary>
        /// Updates the mutable fields of a notify code configuration. Only the fields that you
        /// supply are changed. For the template and language fields, supplying an empty value
        /// clears the currently stored value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotifyCodeConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateNotifyCodeConfiguration service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/UpdateNotifyCodeConfiguration">REST API Reference for UpdateNotifyCodeConfiguration Operation</seealso>
        UpdateNotifyCodeConfigurationResponse UpdateNotifyCodeConfiguration(UpdateNotifyCodeConfigurationRequest request);



        /// <summary>
        /// Updates the mutable fields of a notify code configuration. Only the fields that you
        /// supply are changed. For the template and language fields, supplying an empty value
        /// clears the currently stored value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotifyCodeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNotifyCodeConfiguration service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/UpdateNotifyCodeConfiguration">REST API Reference for UpdateNotifyCodeConfiguration Operation</seealso>
        Task<UpdateNotifyCodeConfigurationResponse> UpdateNotifyCodeConfigurationAsync(UpdateNotifyCodeConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRegistrationsFromBrandProfile


        /// <summary>
        /// Repushes the attributes of a brand profile into existing DRAFT registrations. This
        /// operation runs asynchronously. Use the GetJob operation to track its progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistrationsFromBrandProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateRegistrationsFromBrandProfile service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/UpdateRegistrationsFromBrandProfile">REST API Reference for UpdateRegistrationsFromBrandProfile Operation</seealso>
        UpdateRegistrationsFromBrandProfileResponse UpdateRegistrationsFromBrandProfile(UpdateRegistrationsFromBrandProfileRequest request);



        /// <summary>
        /// Repushes the attributes of a brand profile into existing DRAFT registrations. This
        /// operation runs asynchronously. Use the GetJob operation to track its progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistrationsFromBrandProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRegistrationsFromBrandProfile service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/UpdateRegistrationsFromBrandProfile">REST API Reference for UpdateRegistrationsFromBrandProfile Operation</seealso>
        Task<UpdateRegistrationsFromBrandProfileResponse> UpdateRegistrationsFromBrandProfileAsync(UpdateRegistrationsFromBrandProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ValidateNotifyCodeVerification


        /// <summary>
        /// Validates a one-time passcode that a recipient submitted. Validation succeeds when
        /// the passcode matches, the validity period has not elapsed, and the maximum number
        /// of attempts has not been exceeded.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateNotifyCodeVerification service method.</param>
        /// 
        /// <returns>The response from the ValidateNotifyCodeVerification service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/ValidateNotifyCodeVerification">REST API Reference for ValidateNotifyCodeVerification Operation</seealso>
        ValidateNotifyCodeVerificationResponse ValidateNotifyCodeVerification(ValidateNotifyCodeVerificationRequest request);



        /// <summary>
        /// Validates a one-time passcode that a recipient submitted. Validation succeeds when
        /// the passcode matches, the validity period has not elapsed, and the maximum number
        /// of attempts has not been exceeded.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateNotifyCodeVerification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateNotifyCodeVerification service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/ValidateNotifyCodeVerification">REST API Reference for ValidateNotifyCodeVerification Operation</seealso>
        Task<ValidateNotifyCodeVerificationResponse> ValidateNotifyCodeVerificationAsync(ValidateNotifyCodeVerificationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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