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
 * Do not modify this file. This file is generated from the notificationscontacts-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.NotificationsContacts.Model;

#pragma warning disable CS1570
namespace Amazon.NotificationsContacts
{
    /// <summary>
    /// <para>Interface for accessing NotificationsContacts</para>
    ///
    /// AWS User Notifications Contacts is a service that allows you to create and manage
    /// email contacts for AWS User Notifications. The AWS User Notifications Contacts API
    /// Reference provides descriptions, API request parameters, and the JSON response for
    /// all email contact related API actions.
    /// </summary>
    public partial interface IAmazonNotificationsContacts : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        INotificationsContactsPaginatorFactory Paginators { get; }
#endif
                
        #region  ActivateEmailContact



        /// <summary>
        /// Activates an email contact using an activation code. This code is in the activation
        /// email sent to the email address associated with this email contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ActivateEmailContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ActivateEmailContact service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ResourceNotFoundException">
        /// Your request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/ActivateEmailContact">REST API Reference for ActivateEmailContact Operation</seealso>
        Task<ActivateEmailContactResponse> ActivateEmailContactAsync(ActivateEmailContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateEmailContact



        /// <summary>
        /// Creates an email contact for the provided email address.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEmailContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEmailContact service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/CreateEmailContact">REST API Reference for CreateEmailContact Operation</seealso>
        Task<CreateEmailContactResponse> CreateEmailContactAsync(CreateEmailContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteEmailContact



        /// <summary>
        /// Deletes an email contact.
        /// 
        ///  <note> 
        /// <para>
        /// Deleting an email contact removes it from all associated notification configurations.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEmailContact service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ResourceNotFoundException">
        /// Your request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/DeleteEmailContact">REST API Reference for DeleteEmailContact Operation</seealso>
        Task<DeleteEmailContactResponse> DeleteEmailContactAsync(DeleteEmailContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEmailContact



        /// <summary>
        /// Returns an email contact.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEmailContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEmailContact service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ResourceNotFoundException">
        /// Your request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/GetEmailContact">REST API Reference for GetEmailContact Operation</seealso>
        Task<GetEmailContactResponse> GetEmailContactAsync(GetEmailContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEmailContacts



        /// <summary>
        /// Lists all email contacts created under the Account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEmailContacts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEmailContacts service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/ListEmailContacts">REST API Reference for ListEmailContacts Operation</seealso>
        Task<ListEmailContactsResponse> ListEmailContactsAsync(ListEmailContactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists all of the tags associated with the Amazon Resource Name (ARN) that you specify.
        /// The resource can be a user, server, or role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ResourceNotFoundException">
        /// Your request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendActivationCode



        /// <summary>
        /// Sends an activation email to the email address associated with the specified email
        /// contact.
        /// 
        ///  <note> 
        /// <para>
        /// It might take a few minutes for the activation email to arrive. If it doesn't arrive,
        /// check in your spam folder or try sending another activation email.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendActivationCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendActivationCode service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ResourceNotFoundException">
        /// Your request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/SendActivationCode">REST API Reference for SendActivationCode Operation</seealso>
        Task<SendActivationCodeResponse> SendActivationCodeAsync(SendActivationCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Attaches a key-value pair to a resource, as identified by its Amazon Resource Name
        /// (ARN). Taggable resources in AWS User Notifications Contacts include email contacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ResourceNotFoundException">
        /// Your request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Detaches a key-value pair from a resource, as identified by its Amazon Resource Name
        /// (ARN). Taggable resources in AWS User Notifications Contacts include email contacts..
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by NotificationsContacts.</returns>
        /// <exception cref="Amazon.NotificationsContacts.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ResourceNotFoundException">
        /// Your request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NotificationsContacts.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/notificationscontacts-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonNotificationsContactsConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonNotificationsContactsConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonNotificationsContactsConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonNotificationsContactsConfig to create AmazonNotificationsContactsClient");
            }

            return awsCredentials == null ? 
                    new AmazonNotificationsContactsClient(serviceClientConfig) :
                    new AmazonNotificationsContactsClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}