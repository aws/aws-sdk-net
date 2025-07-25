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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
        AssociateWhatsAppBusinessAccountResponse AssociateWhatsAppBusinessAccount(AssociateWhatsAppBusinessAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWhatsAppBusinessAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWhatsAppBusinessAccount operation on AmazonSocialMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateWhatsAppBusinessAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/AssociateWhatsAppBusinessAccount">REST API Reference for AssociateWhatsAppBusinessAccount Operation</seealso>
        IAsyncResult BeginAssociateWhatsAppBusinessAccount(AssociateWhatsAppBusinessAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWhatsAppBusinessAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWhatsAppBusinessAccount.</param>
        /// 
        /// <returns>Returns a  AssociateWhatsAppBusinessAccountResult from SocialMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/AssociateWhatsAppBusinessAccount">REST API Reference for AssociateWhatsAppBusinessAccount Operation</seealso>
        AssociateWhatsAppBusinessAccountResponse EndAssociateWhatsAppBusinessAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWhatsAppMessageTemplate


        /// <summary>
        /// Creates a new WhatsApp message template from a custom definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatsAppMessageTemplate service method.</param>
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
        CreateWhatsAppMessageTemplateResponse CreateWhatsAppMessageTemplate(CreateWhatsAppMessageTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWhatsAppMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatsAppMessageTemplate operation on AmazonSocialMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWhatsAppMessageTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/CreateWhatsAppMessageTemplate">REST API Reference for CreateWhatsAppMessageTemplate Operation</seealso>
        IAsyncResult BeginCreateWhatsAppMessageTemplate(CreateWhatsAppMessageTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWhatsAppMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWhatsAppMessageTemplate.</param>
        /// 
        /// <returns>Returns a  CreateWhatsAppMessageTemplateResult from SocialMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/CreateWhatsAppMessageTemplate">REST API Reference for CreateWhatsAppMessageTemplate Operation</seealso>
        CreateWhatsAppMessageTemplateResponse EndCreateWhatsAppMessageTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWhatsAppMessageTemplateFromLibrary


        /// <summary>
        /// Creates a new WhatsApp message template using a template from Meta's template library.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatsAppMessageTemplateFromLibrary service method.</param>
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
        CreateWhatsAppMessageTemplateFromLibraryResponse CreateWhatsAppMessageTemplateFromLibrary(CreateWhatsAppMessageTemplateFromLibraryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWhatsAppMessageTemplateFromLibrary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatsAppMessageTemplateFromLibrary operation on AmazonSocialMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWhatsAppMessageTemplateFromLibrary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/CreateWhatsAppMessageTemplateFromLibrary">REST API Reference for CreateWhatsAppMessageTemplateFromLibrary Operation</seealso>
        IAsyncResult BeginCreateWhatsAppMessageTemplateFromLibrary(CreateWhatsAppMessageTemplateFromLibraryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWhatsAppMessageTemplateFromLibrary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWhatsAppMessageTemplateFromLibrary.</param>
        /// 
        /// <returns>Returns a  CreateWhatsAppMessageTemplateFromLibraryResult from SocialMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/CreateWhatsAppMessageTemplateFromLibrary">REST API Reference for CreateWhatsAppMessageTemplateFromLibrary Operation</seealso>
        CreateWhatsAppMessageTemplateFromLibraryResponse EndCreateWhatsAppMessageTemplateFromLibrary(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWhatsAppMessageTemplateMedia


        /// <summary>
        /// Uploads media for use in a WhatsApp message template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatsAppMessageTemplateMedia service method.</param>
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
        CreateWhatsAppMessageTemplateMediaResponse CreateWhatsAppMessageTemplateMedia(CreateWhatsAppMessageTemplateMediaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWhatsAppMessageTemplateMedia operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatsAppMessageTemplateMedia operation on AmazonSocialMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWhatsAppMessageTemplateMedia
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/CreateWhatsAppMessageTemplateMedia">REST API Reference for CreateWhatsAppMessageTemplateMedia Operation</seealso>
        IAsyncResult BeginCreateWhatsAppMessageTemplateMedia(CreateWhatsAppMessageTemplateMediaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWhatsAppMessageTemplateMedia operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWhatsAppMessageTemplateMedia.</param>
        /// 
        /// <returns>Returns a  CreateWhatsAppMessageTemplateMediaResult from SocialMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/CreateWhatsAppMessageTemplateMedia">REST API Reference for CreateWhatsAppMessageTemplateMedia Operation</seealso>
        CreateWhatsAppMessageTemplateMediaResponse EndCreateWhatsAppMessageTemplateMedia(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWhatsAppMessageMedia


        /// <summary>
        /// Delete a media object from the WhatsApp service. If the object is still in an Amazon
        /// S3 bucket you should delete it from there too.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatsAppMessageMedia service method.</param>
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
        DeleteWhatsAppMessageMediaResponse DeleteWhatsAppMessageMedia(DeleteWhatsAppMessageMediaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWhatsAppMessageMedia operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatsAppMessageMedia operation on AmazonSocialMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWhatsAppMessageMedia
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/DeleteWhatsAppMessageMedia">REST API Reference for DeleteWhatsAppMessageMedia Operation</seealso>
        IAsyncResult BeginDeleteWhatsAppMessageMedia(DeleteWhatsAppMessageMediaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWhatsAppMessageMedia operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWhatsAppMessageMedia.</param>
        /// 
        /// <returns>Returns a  DeleteWhatsAppMessageMediaResult from SocialMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/DeleteWhatsAppMessageMedia">REST API Reference for DeleteWhatsAppMessageMedia Operation</seealso>
        DeleteWhatsAppMessageMediaResponse EndDeleteWhatsAppMessageMedia(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWhatsAppMessageTemplate


        /// <summary>
        /// Deletes a WhatsApp message template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatsAppMessageTemplate service method.</param>
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
        DeleteWhatsAppMessageTemplateResponse DeleteWhatsAppMessageTemplate(DeleteWhatsAppMessageTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWhatsAppMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatsAppMessageTemplate operation on AmazonSocialMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWhatsAppMessageTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/DeleteWhatsAppMessageTemplate">REST API Reference for DeleteWhatsAppMessageTemplate Operation</seealso>
        IAsyncResult BeginDeleteWhatsAppMessageTemplate(DeleteWhatsAppMessageTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWhatsAppMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWhatsAppMessageTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteWhatsAppMessageTemplateResult from SocialMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/DeleteWhatsAppMessageTemplate">REST API Reference for DeleteWhatsAppMessageTemplate Operation</seealso>
        DeleteWhatsAppMessageTemplateResponse EndDeleteWhatsAppMessageTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateWhatsAppBusinessAccount


        /// <summary>
        /// Disassociate a WhatsApp Business Account (WABA) from your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWhatsAppBusinessAccount service method.</param>
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
        DisassociateWhatsAppBusinessAccountResponse DisassociateWhatsAppBusinessAccount(DisassociateWhatsAppBusinessAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWhatsAppBusinessAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWhatsAppBusinessAccount operation on AmazonSocialMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateWhatsAppBusinessAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/DisassociateWhatsAppBusinessAccount">REST API Reference for DisassociateWhatsAppBusinessAccount Operation</seealso>
        IAsyncResult BeginDisassociateWhatsAppBusinessAccount(DisassociateWhatsAppBusinessAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWhatsAppBusinessAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWhatsAppBusinessAccount.</param>
        /// 
        /// <returns>Returns a  DisassociateWhatsAppBusinessAccountResult from SocialMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/DisassociateWhatsAppBusinessAccount">REST API Reference for DisassociateWhatsAppBusinessAccount Operation</seealso>
        DisassociateWhatsAppBusinessAccountResponse EndDisassociateWhatsAppBusinessAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLinkedWhatsAppBusinessAccount


        /// <summary>
        /// Get the details of your linked WhatsApp Business Account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLinkedWhatsAppBusinessAccount service method.</param>
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
        GetLinkedWhatsAppBusinessAccountResponse GetLinkedWhatsAppBusinessAccount(GetLinkedWhatsAppBusinessAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLinkedWhatsAppBusinessAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLinkedWhatsAppBusinessAccount operation on AmazonSocialMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLinkedWhatsAppBusinessAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/GetLinkedWhatsAppBusinessAccount">REST API Reference for GetLinkedWhatsAppBusinessAccount Operation</seealso>
        IAsyncResult BeginGetLinkedWhatsAppBusinessAccount(GetLinkedWhatsAppBusinessAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLinkedWhatsAppBusinessAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLinkedWhatsAppBusinessAccount.</param>
        /// 
        /// <returns>Returns a  GetLinkedWhatsAppBusinessAccountResult from SocialMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/GetLinkedWhatsAppBusinessAccount">REST API Reference for GetLinkedWhatsAppBusinessAccount Operation</seealso>
        GetLinkedWhatsAppBusinessAccountResponse EndGetLinkedWhatsAppBusinessAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLinkedWhatsAppBusinessAccountPhoneNumber


        /// <summary>
        /// Use your WhatsApp phone number id to get the WABA account id and phone number details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLinkedWhatsAppBusinessAccountPhoneNumber service method.</param>
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
        GetLinkedWhatsAppBusinessAccountPhoneNumberResponse GetLinkedWhatsAppBusinessAccountPhoneNumber(GetLinkedWhatsAppBusinessAccountPhoneNumberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLinkedWhatsAppBusinessAccountPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLinkedWhatsAppBusinessAccountPhoneNumber operation on AmazonSocialMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLinkedWhatsAppBusinessAccountPhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/GetLinkedWhatsAppBusinessAccountPhoneNumber">REST API Reference for GetLinkedWhatsAppBusinessAccountPhoneNumber Operation</seealso>
        IAsyncResult BeginGetLinkedWhatsAppBusinessAccountPhoneNumber(GetLinkedWhatsAppBusinessAccountPhoneNumberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLinkedWhatsAppBusinessAccountPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLinkedWhatsAppBusinessAccountPhoneNumber.</param>
        /// 
        /// <returns>Returns a  GetLinkedWhatsAppBusinessAccountPhoneNumberResult from SocialMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/GetLinkedWhatsAppBusinessAccountPhoneNumber">REST API Reference for GetLinkedWhatsAppBusinessAccountPhoneNumber Operation</seealso>
        GetLinkedWhatsAppBusinessAccountPhoneNumberResponse EndGetLinkedWhatsAppBusinessAccountPhoneNumber(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWhatsAppMessageMedia


        /// <summary>
        /// Get a media file from the WhatsApp service. On successful completion the media file
        /// is retrieved from Meta and stored in the specified Amazon S3 bucket. Use either <c>destinationS3File</c>
        /// or <c>destinationS3PresignedUrl</c> for the destination. If both are used then an
        /// <c>InvalidParameterException</c> is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWhatsAppMessageMedia service method.</param>
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
        GetWhatsAppMessageMediaResponse GetWhatsAppMessageMedia(GetWhatsAppMessageMediaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWhatsAppMessageMedia operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWhatsAppMessageMedia operation on AmazonSocialMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWhatsAppMessageMedia
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/GetWhatsAppMessageMedia">REST API Reference for GetWhatsAppMessageMedia Operation</seealso>
        IAsyncResult BeginGetWhatsAppMessageMedia(GetWhatsAppMessageMediaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWhatsAppMessageMedia operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWhatsAppMessageMedia.</param>
        /// 
        /// <returns>Returns a  GetWhatsAppMessageMediaResult from SocialMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/GetWhatsAppMessageMedia">REST API Reference for GetWhatsAppMessageMedia Operation</seealso>
        GetWhatsAppMessageMediaResponse EndGetWhatsAppMessageMedia(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWhatsAppMessageTemplate


        /// <summary>
        /// Retrieves a specific WhatsApp message template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWhatsAppMessageTemplate service method.</param>
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
        GetWhatsAppMessageTemplateResponse GetWhatsAppMessageTemplate(GetWhatsAppMessageTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWhatsAppMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWhatsAppMessageTemplate operation on AmazonSocialMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWhatsAppMessageTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/GetWhatsAppMessageTemplate">REST API Reference for GetWhatsAppMessageTemplate Operation</seealso>
        IAsyncResult BeginGetWhatsAppMessageTemplate(GetWhatsAppMessageTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWhatsAppMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWhatsAppMessageTemplate.</param>
        /// 
        /// <returns>Returns a  GetWhatsAppMessageTemplateResult from SocialMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/GetWhatsAppMessageTemplate">REST API Reference for GetWhatsAppMessageTemplate Operation</seealso>
        GetWhatsAppMessageTemplateResponse EndGetWhatsAppMessageTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLinkedWhatsAppBusinessAccounts


        /// <summary>
        /// List all WhatsApp Business Accounts linked to your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinkedWhatsAppBusinessAccounts service method.</param>
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
        ListLinkedWhatsAppBusinessAccountsResponse ListLinkedWhatsAppBusinessAccounts(ListLinkedWhatsAppBusinessAccountsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLinkedWhatsAppBusinessAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLinkedWhatsAppBusinessAccounts operation on AmazonSocialMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLinkedWhatsAppBusinessAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/ListLinkedWhatsAppBusinessAccounts">REST API Reference for ListLinkedWhatsAppBusinessAccounts Operation</seealso>
        IAsyncResult BeginListLinkedWhatsAppBusinessAccounts(ListLinkedWhatsAppBusinessAccountsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLinkedWhatsAppBusinessAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLinkedWhatsAppBusinessAccounts.</param>
        /// 
        /// <returns>Returns a  ListLinkedWhatsAppBusinessAccountsResult from SocialMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/ListLinkedWhatsAppBusinessAccounts">REST API Reference for ListLinkedWhatsAppBusinessAccounts Operation</seealso>
        ListLinkedWhatsAppBusinessAccountsResponse EndListLinkedWhatsAppBusinessAccounts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List all tags associated with a resource, such as a phone number or WABA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSocialMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from SocialMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWhatsAppMessageTemplates


        /// <summary>
        /// Lists WhatsApp message templates for a specific WhatsApp Business Account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWhatsAppMessageTemplates service method.</param>
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
        ListWhatsAppMessageTemplatesResponse ListWhatsAppMessageTemplates(ListWhatsAppMessageTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWhatsAppMessageTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWhatsAppMessageTemplates operation on AmazonSocialMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWhatsAppMessageTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/ListWhatsAppMessageTemplates">REST API Reference for ListWhatsAppMessageTemplates Operation</seealso>
        IAsyncResult BeginListWhatsAppMessageTemplates(ListWhatsAppMessageTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWhatsAppMessageTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWhatsAppMessageTemplates.</param>
        /// 
        /// <returns>Returns a  ListWhatsAppMessageTemplatesResult from SocialMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/ListWhatsAppMessageTemplates">REST API Reference for ListWhatsAppMessageTemplates Operation</seealso>
        ListWhatsAppMessageTemplatesResponse EndListWhatsAppMessageTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWhatsAppTemplateLibrary


        /// <summary>
        /// Lists templates available in Meta's template library for WhatsApp messaging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWhatsAppTemplateLibrary service method.</param>
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
        ListWhatsAppTemplateLibraryResponse ListWhatsAppTemplateLibrary(ListWhatsAppTemplateLibraryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWhatsAppTemplateLibrary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWhatsAppTemplateLibrary operation on AmazonSocialMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWhatsAppTemplateLibrary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/ListWhatsAppTemplateLibrary">REST API Reference for ListWhatsAppTemplateLibrary Operation</seealso>
        IAsyncResult BeginListWhatsAppTemplateLibrary(ListWhatsAppTemplateLibraryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWhatsAppTemplateLibrary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWhatsAppTemplateLibrary.</param>
        /// 
        /// <returns>Returns a  ListWhatsAppTemplateLibraryResult from SocialMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/ListWhatsAppTemplateLibrary">REST API Reference for ListWhatsAppTemplateLibrary Operation</seealso>
        ListWhatsAppTemplateLibraryResponse EndListWhatsAppTemplateLibrary(IAsyncResult asyncResult);

        #endregion
        
        #region  PostWhatsAppMessageMedia


        /// <summary>
        /// Upload a media file to the WhatsApp service. Only the specified <c>originationPhoneNumberId</c>
        /// has the permissions to send the media file when using <a href="https://docs.aws.amazon.com/social-messaging/latest/APIReference/API_SendWhatsAppMessage.html">SendWhatsAppMessage</a>.
        /// You must use either <c>sourceS3File</c> or <c>sourceS3PresignedUrl</c> for the source.
        /// If both or neither are specified then an <c>InvalidParameterException</c> is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostWhatsAppMessageMedia service method.</param>
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
        PostWhatsAppMessageMediaResponse PostWhatsAppMessageMedia(PostWhatsAppMessageMediaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PostWhatsAppMessageMedia operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostWhatsAppMessageMedia operation on AmazonSocialMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPostWhatsAppMessageMedia
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/PostWhatsAppMessageMedia">REST API Reference for PostWhatsAppMessageMedia Operation</seealso>
        IAsyncResult BeginPostWhatsAppMessageMedia(PostWhatsAppMessageMediaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PostWhatsAppMessageMedia operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPostWhatsAppMessageMedia.</param>
        /// 
        /// <returns>Returns a  PostWhatsAppMessageMediaResult from SocialMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/PostWhatsAppMessageMedia">REST API Reference for PostWhatsAppMessageMedia Operation</seealso>
        PostWhatsAppMessageMediaResponse EndPostWhatsAppMessageMedia(IAsyncResult asyncResult);

        #endregion
        
        #region  PutWhatsAppBusinessAccountEventDestinations


        /// <summary>
        /// Add an event destination to log event data from WhatsApp for a WhatsApp Business Account
        /// (WABA). A WABA can only have one event destination at a time. All resources associated
        /// with the WABA use the same event destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWhatsAppBusinessAccountEventDestinations service method.</param>
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
        PutWhatsAppBusinessAccountEventDestinationsResponse PutWhatsAppBusinessAccountEventDestinations(PutWhatsAppBusinessAccountEventDestinationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutWhatsAppBusinessAccountEventDestinations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutWhatsAppBusinessAccountEventDestinations operation on AmazonSocialMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutWhatsAppBusinessAccountEventDestinations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/PutWhatsAppBusinessAccountEventDestinations">REST API Reference for PutWhatsAppBusinessAccountEventDestinations Operation</seealso>
        IAsyncResult BeginPutWhatsAppBusinessAccountEventDestinations(PutWhatsAppBusinessAccountEventDestinationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutWhatsAppBusinessAccountEventDestinations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutWhatsAppBusinessAccountEventDestinations.</param>
        /// 
        /// <returns>Returns a  PutWhatsAppBusinessAccountEventDestinationsResult from SocialMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/PutWhatsAppBusinessAccountEventDestinations">REST API Reference for PutWhatsAppBusinessAccountEventDestinations Operation</seealso>
        PutWhatsAppBusinessAccountEventDestinationsResponse EndPutWhatsAppBusinessAccountEventDestinations(IAsyncResult asyncResult);

        #endregion
        
        #region  SendWhatsAppMessage


        /// <summary>
        /// Send a WhatsApp message. For examples of sending a message using the Amazon Web Services
        /// CLI, see <a href="https://docs.aws.amazon.com/social-messaging/latest/userguide/send-message.html">Sending
        /// messages</a> in the <i> <i>Amazon Web Services End User Messaging Social User Guide</i>
        /// </i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendWhatsAppMessage service method.</param>
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
        SendWhatsAppMessageResponse SendWhatsAppMessage(SendWhatsAppMessageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendWhatsAppMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendWhatsAppMessage operation on AmazonSocialMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendWhatsAppMessage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/SendWhatsAppMessage">REST API Reference for SendWhatsAppMessage Operation</seealso>
        IAsyncResult BeginSendWhatsAppMessage(SendWhatsAppMessageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendWhatsAppMessage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendWhatsAppMessage.</param>
        /// 
        /// <returns>Returns a  SendWhatsAppMessageResult from SocialMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/SendWhatsAppMessage">REST API Reference for SendWhatsAppMessage Operation</seealso>
        SendWhatsAppMessageResponse EndSendWhatsAppMessage(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or overwrites only the specified tags for the specified resource. When you specify
        /// an existing tag key, the value is overwritten with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSocialMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from SocialMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSocialMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from SocialMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWhatsAppMessageTemplate


        /// <summary>
        /// Updates an existing WhatsApp message template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWhatsAppMessageTemplate service method.</param>
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
        UpdateWhatsAppMessageTemplateResponse UpdateWhatsAppMessageTemplate(UpdateWhatsAppMessageTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWhatsAppMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWhatsAppMessageTemplate operation on AmazonSocialMessagingClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWhatsAppMessageTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/UpdateWhatsAppMessageTemplate">REST API Reference for UpdateWhatsAppMessageTemplate Operation</seealso>
        IAsyncResult BeginUpdateWhatsAppMessageTemplate(UpdateWhatsAppMessageTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWhatsAppMessageTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWhatsAppMessageTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateWhatsAppMessageTemplateResult from SocialMessaging.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/UpdateWhatsAppMessageTemplate">REST API Reference for UpdateWhatsAppMessageTemplate Operation</seealso>
        UpdateWhatsAppMessageTemplateResponse EndUpdateWhatsAppMessageTemplate(IAsyncResult asyncResult);

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