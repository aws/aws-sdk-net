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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SocialMessaging.Model;

#pragma warning disable CS1570
namespace Amazon.SocialMessaging
{
    /// <summary>
    /// <para>Interface for accessing SocialMessaging</para>
    ///
    /// <i>Amazon Web Services End User Messaging Social</i>, also referred to as Social
    /// messaging, is a messaging service that enables application developers to incorporate
    /// WhatsApp into their existing workflows. The <i>Amazon Web Services End User Messaging
    /// Social API</i> provides information about the <i>Amazon Web Services End User Messaging
    /// Social API</i> resources, including supported HTTP methods, parameters, and schemas.
    /// 
    ///  
    /// <para>
    /// The <i>Amazon Web Services End User Messaging Social API</i> provides programmatic
    /// access to options that are unique to the WhatsApp Business Platform.
    /// </para>
    ///  
    /// <para>
    /// If you're new to the <i>Amazon Web Services End User Messaging Social API</i>, it's
    /// also helpful to review <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/what-is-service.html">What
    /// is Amazon Web Services End User Messaging Social</a> in the <i>Amazon Web Services
    /// End User Messaging Social User Guide</i>. The <i>Amazon Web Services End User Messaging
    /// Social User Guide</i> provides tutorials, code samples, and procedures that demonstrate
    /// how to use <i>Amazon Web Services End User Messaging Social API</i> features programmatically
    /// and how to integrate functionality into applications. The guide also provides key
    /// information, such as integration with other Amazon Web Services services, and the
    /// quotas that apply to use of the service.
    /// </para>
    ///  
    /// <para>
    ///  <b>Regional availability</b> 
    /// </para>
    ///  
    /// <para>
    /// The <i>Amazon Web Services End User Messaging Social API</i> is available across several
    /// Amazon Web Services Regions and it provides a dedicated endpoint for each of these
    /// Regions. For a list of all the Regions and endpoints where the API is currently available,
    /// see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#pinpoint_region">Amazon
    /// Web Services Service Endpoints</a> and <a href="https://docs.aws.amazon.com/general/latest/gr/end-user-messaging.html">Amazon
    /// Web Services End User Messaging endpoints and quotas</a> in the Amazon Web Services
    /// General Reference. To learn more about Amazon Web Services Regions, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande-manage.html">Managing
    /// Amazon Web Services Regions</a> in the Amazon Web Services General Reference.
    /// </para>
    ///  
    /// <para>
    /// In each Region, Amazon Web Services maintains multiple Availability Zones. These Availability
    /// Zones are physically isolated from each other, but are united by private, low-latency,
    /// high-throughput, and highly redundant network connections. These Availability Zones
    /// enable us to provide very high levels of availability and redundancy, while also minimizing
    /// latency. To learn more about the number of Availability Zones that are available in
    /// each Region, see <a href="https://aws.amazon.com/about-aws/global-infrastructure/">Amazon
    /// Web Services Global Infrastructure.</a> 
    /// </para>
    /// </summary>
    public partial interface IAmazonSocialMessaging : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISocialMessagingPaginatorFactory Paginators { get; }
#endif
                
        #region  AssociateWhatsAppBusinessAccount



        /// <summary>
        /// This is only used through the Amazon Web Services console during sign-up to associate
        /// your WhatsApp Business Account to your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWhatsAppBusinessAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateWhatsAppBusinessAccount service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.LimitExceededException">
        /// The request was denied because it would exceed one or more service quotas or limits.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/AssociateWhatsAppBusinessAccount">REST API Reference for AssociateWhatsAppBusinessAccount Operation</seealso>
        Task<AssociateWhatsAppBusinessAccountResponse> AssociateWhatsAppBusinessAccountAsync(AssociateWhatsAppBusinessAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWhatsAppMessageTemplate



        /// <summary>
        /// Creates a new WhatsApp message template from a custom definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatsAppMessageTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWhatsAppMessageTemplate service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/CreateWhatsAppMessageTemplate">REST API Reference for CreateWhatsAppMessageTemplate Operation</seealso>
        Task<CreateWhatsAppMessageTemplateResponse> CreateWhatsAppMessageTemplateAsync(CreateWhatsAppMessageTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWhatsAppMessageTemplateFromLibrary



        /// <summary>
        /// Creates a new WhatsApp message template using a template from Meta's template library.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatsAppMessageTemplateFromLibrary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWhatsAppMessageTemplateFromLibrary service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/CreateWhatsAppMessageTemplateFromLibrary">REST API Reference for CreateWhatsAppMessageTemplateFromLibrary Operation</seealso>
        Task<CreateWhatsAppMessageTemplateFromLibraryResponse> CreateWhatsAppMessageTemplateFromLibraryAsync(CreateWhatsAppMessageTemplateFromLibraryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWhatsAppMessageTemplateMedia



        /// <summary>
        /// Uploads media for use in a WhatsApp message template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatsAppMessageTemplateMedia service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWhatsAppMessageTemplateMedia service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/CreateWhatsAppMessageTemplateMedia">REST API Reference for CreateWhatsAppMessageTemplateMedia Operation</seealso>
        Task<CreateWhatsAppMessageTemplateMediaResponse> CreateWhatsAppMessageTemplateMediaAsync(CreateWhatsAppMessageTemplateMediaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWhatsAppMessageMedia



        /// <summary>
        /// Delete a media object from the WhatsApp service. If the object is still in an Amazon
        /// S3 bucket you should delete it from there too.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatsAppMessageMedia service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWhatsAppMessageMedia service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/DeleteWhatsAppMessageMedia">REST API Reference for DeleteWhatsAppMessageMedia Operation</seealso>
        Task<DeleteWhatsAppMessageMediaResponse> DeleteWhatsAppMessageMediaAsync(DeleteWhatsAppMessageMediaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWhatsAppMessageTemplate



        /// <summary>
        /// Deletes a WhatsApp message template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatsAppMessageTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWhatsAppMessageTemplate service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/DeleteWhatsAppMessageTemplate">REST API Reference for DeleteWhatsAppMessageTemplate Operation</seealso>
        Task<DeleteWhatsAppMessageTemplateResponse> DeleteWhatsAppMessageTemplateAsync(DeleteWhatsAppMessageTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateWhatsAppBusinessAccount



        /// <summary>
        /// Disassociate a WhatsApp Business Account (WABA) from your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWhatsAppBusinessAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateWhatsAppBusinessAccount service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/DisassociateWhatsAppBusinessAccount">REST API Reference for DisassociateWhatsAppBusinessAccount Operation</seealso>
        Task<DisassociateWhatsAppBusinessAccountResponse> DisassociateWhatsAppBusinessAccountAsync(DisassociateWhatsAppBusinessAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetLinkedWhatsAppBusinessAccount



        /// <summary>
        /// Get the details of your linked WhatsApp Business Account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLinkedWhatsAppBusinessAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLinkedWhatsAppBusinessAccount service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/GetLinkedWhatsAppBusinessAccount">REST API Reference for GetLinkedWhatsAppBusinessAccount Operation</seealso>
        Task<GetLinkedWhatsAppBusinessAccountResponse> GetLinkedWhatsAppBusinessAccountAsync(GetLinkedWhatsAppBusinessAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetLinkedWhatsAppBusinessAccountPhoneNumber



        /// <summary>
        /// Use your WhatsApp phone number id to get the WABA account id and phone number details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLinkedWhatsAppBusinessAccountPhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLinkedWhatsAppBusinessAccountPhoneNumber service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/GetLinkedWhatsAppBusinessAccountPhoneNumber">REST API Reference for GetLinkedWhatsAppBusinessAccountPhoneNumber Operation</seealso>
        Task<GetLinkedWhatsAppBusinessAccountPhoneNumberResponse> GetLinkedWhatsAppBusinessAccountPhoneNumberAsync(GetLinkedWhatsAppBusinessAccountPhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetWhatsAppMessageMedia



        /// <summary>
        /// Get a media file from the WhatsApp service. On successful completion the media file
        /// is retrieved from Meta and stored in the specified Amazon S3 bucket. Use either <c>destinationS3File</c>
        /// or <c>destinationS3PresignedUrl</c> for the destination. If both are used then an
        /// <c>InvalidParameterException</c> is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWhatsAppMessageMedia service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWhatsAppMessageMedia service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/GetWhatsAppMessageMedia">REST API Reference for GetWhatsAppMessageMedia Operation</seealso>
        Task<GetWhatsAppMessageMediaResponse> GetWhatsAppMessageMediaAsync(GetWhatsAppMessageMediaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetWhatsAppMessageTemplate



        /// <summary>
        /// Retrieves a specific WhatsApp message template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWhatsAppMessageTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWhatsAppMessageTemplate service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/GetWhatsAppMessageTemplate">REST API Reference for GetWhatsAppMessageTemplate Operation</seealso>
        Task<GetWhatsAppMessageTemplateResponse> GetWhatsAppMessageTemplateAsync(GetWhatsAppMessageTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLinkedWhatsAppBusinessAccounts



        /// <summary>
        /// List all WhatsApp Business Accounts linked to your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinkedWhatsAppBusinessAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLinkedWhatsAppBusinessAccounts service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/ListLinkedWhatsAppBusinessAccounts">REST API Reference for ListLinkedWhatsAppBusinessAccounts Operation</seealso>
        Task<ListLinkedWhatsAppBusinessAccountsResponse> ListLinkedWhatsAppBusinessAccountsAsync(ListLinkedWhatsAppBusinessAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// List all tags associated with a resource, such as a phone number or WABA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWhatsAppMessageTemplates



        /// <summary>
        /// Lists WhatsApp message templates for a specific WhatsApp Business Account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWhatsAppMessageTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWhatsAppMessageTemplates service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/ListWhatsAppMessageTemplates">REST API Reference for ListWhatsAppMessageTemplates Operation</seealso>
        Task<ListWhatsAppMessageTemplatesResponse> ListWhatsAppMessageTemplatesAsync(ListWhatsAppMessageTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWhatsAppTemplateLibrary



        /// <summary>
        /// Lists templates available in Meta's template library for WhatsApp messaging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWhatsAppTemplateLibrary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWhatsAppTemplateLibrary service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/ListWhatsAppTemplateLibrary">REST API Reference for ListWhatsAppTemplateLibrary Operation</seealso>
        Task<ListWhatsAppTemplateLibraryResponse> ListWhatsAppTemplateLibraryAsync(ListWhatsAppTemplateLibraryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PostWhatsAppMessageMedia



        /// <summary>
        /// Upload a media file to the WhatsApp service. Only the specified <c>originationPhoneNumberId</c>
        /// has the permissions to send the media file when using <a href="https://docs.aws.amazon.com/social-messaging/latest/APIReference/API_SendWhatsAppMessage.html">SendWhatsAppMessage</a>.
        /// You must use either <c>sourceS3File</c> or <c>sourceS3PresignedUrl</c> for the source.
        /// If both or neither are specified then an <c>InvalidParameterException</c> is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostWhatsAppMessageMedia service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PostWhatsAppMessageMedia service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/PostWhatsAppMessageMedia">REST API Reference for PostWhatsAppMessageMedia Operation</seealso>
        Task<PostWhatsAppMessageMediaResponse> PostWhatsAppMessageMediaAsync(PostWhatsAppMessageMediaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutWhatsAppBusinessAccountEventDestinations



        /// <summary>
        /// Add an event destination to log event data from WhatsApp for a WhatsApp Business Account
        /// (WABA). A WABA can only have one event destination at a time. All resources associated
        /// with the WABA use the same event destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWhatsAppBusinessAccountEventDestinations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutWhatsAppBusinessAccountEventDestinations service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/PutWhatsAppBusinessAccountEventDestinations">REST API Reference for PutWhatsAppBusinessAccountEventDestinations Operation</seealso>
        Task<PutWhatsAppBusinessAccountEventDestinationsResponse> PutWhatsAppBusinessAccountEventDestinationsAsync(PutWhatsAppBusinessAccountEventDestinationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendWhatsAppMessage



        /// <summary>
        /// Send a WhatsApp message. For examples of sending a message using the Amazon Web Services
        /// CLI, see <a href="https://docs.aws.amazon.com/social-messaging/latest/userguide/send-message.html">Sending
        /// messages</a> in the <i> <i>Amazon Web Services End User Messaging Social User Guide</i>
        /// </i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendWhatsAppMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendWhatsAppMessage service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/SendWhatsAppMessage">REST API Reference for SendWhatsAppMessage Operation</seealso>
        Task<SendWhatsAppMessageResponse> SendWhatsAppMessageAsync(SendWhatsAppMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds or overwrites only the specified tags for the specified resource. When you specify
        /// an existing tag key, the value is overwritten with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes the specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateWhatsAppMessageTemplate



        /// <summary>
        /// Updates an existing WhatsApp message template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWhatsAppMessageTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWhatsAppMessageTemplate service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/UpdateWhatsAppMessageTemplate">REST API Reference for UpdateWhatsAppMessageTemplate Operation</seealso>
        Task<UpdateWhatsAppMessageTemplateResponse> UpdateWhatsAppMessageTemplateAsync(UpdateWhatsAppMessageTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonSocialMessagingConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonSocialMessagingConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonSocialMessagingConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonSocialMessagingConfig to create AmazonSocialMessagingClient");
            }

            return awsCredentials == null ? 
                    new AmazonSocialMessagingClient(serviceClientConfig) :
                    new AmazonSocialMessagingClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}