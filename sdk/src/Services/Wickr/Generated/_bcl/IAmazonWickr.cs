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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Wickr.Model;

#pragma warning disable CS1570
namespace Amazon.Wickr
{
    /// <summary>
    /// <para>Interface for accessing Wickr</para>
    ///
    /// Welcome to the <i>Amazon Web Services Wickr API Reference</i>.
    /// 
    ///  
    /// <para>
    /// The Amazon Web Services Wickr application programming interface (API) is designed
    /// for administrators to perform key tasks, such as creating and managing Amazon Web
    /// Services Wickr, networks, users, security groups, bots and more. This guide provides
    /// detailed information about the Amazon Web Services Wickr API, including operations,
    /// types, inputs and outputs, and error codes. You can use an Amazon Web Services SDK,
    /// the Amazon Web Services Command Line Interface (Amazon Web Services CLI, or the REST
    /// API to make API calls for Amazon Web Services Wickr. 
    /// </para>
    ///  
    /// <para>
    ///  <i>Using Amazon Web Services SDK</i> 
    /// </para>
    ///  
    /// <para>
    /// The SDK clients authenticate your requests by using access keys that you provide.
    /// For more information, see <a href="https://docs.aws.amazon.com/sdkref/latest/guide/access.html">Authentication
    /// and access using Amazon Web Services SDKs and tools</a> in the <i>Amazon Web Services
    /// SDKs and Tools Reference Guide</i>. 
    /// </para>
    ///  
    /// <para>
    ///  <i>Using Amazon Web Services CLI</i> 
    /// </para>
    ///  
    /// <para>
    /// Use your access keys with the Amazon Web Services CLI to make API calls. For more
    /// information about setting up the Amazon Web Services CLI, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-chap-getting-started.html">Getting
    /// started with the Amazon Web Services CLI</a> in the <i>Amazon Web Services Command
    /// Line Interface User Guide for Version 2</i>. 
    /// </para>
    ///  
    /// <para>
    ///  <i>Using REST APIs</i> 
    /// </para>
    ///  
    /// <para>
    /// If you use REST to make API calls, you must authenticate your request by providing
    /// a signature. Amazon Web Services Wickr supports Signature Version 4. For more information,
    /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_sigv.html">Amazon
    /// Web Services Signature Version 4 for API requests</a> in the <i>Amazon Web Services
    /// Identity and Access Management User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// Access and permissions to the APIs can be controlled by Amazon Web Services Identity
    /// and Access Management. The managed policy <a href="https://docs.aws.amazon.com/wickr/latest/adminguide/security-iam-awsmanpol.html#security-iam-awsmanpol-AWSWickrFullAccess">Amazon
    /// Web ServicesWickrFullAccess</a> grants full administrative permission to the Amazon
    /// Web Services Wickr service APIs. For more information on restricting access to specific
    /// operations, see <a href="https://docs.aws.amazon.com/wickr/latest/adminguide/security-iam.html">Identity
    /// and access management for Amazon Web Services Wickr </a> in the <i>Amazon Web Services
    /// Wickr Administration Guide</i>. 
    /// </para>
    ///  
    /// <para>
    ///  <i>Types of Errors</i>:
    /// </para>
    ///  
    /// <para>
    /// The Amazon Web Services Wickr APIs provide an HTTP interface. HTTP defines ranges
    /// of HTTP Status Codes for different types of error responses.
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Client errors are indicated by HTTP Status Code class of 4xx
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Service errors are indicated by HTTP Status Code class of 5xx
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// In this reference guide, the documentation for each API has an Errors section that
    /// includes a brief discussion about HTTP status codes. We recommend looking there as
    /// part of your investigation when you get an error.
    /// </para>
    /// </summary>
    public partial interface IAmazonWickr : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IWickrPaginatorFactory Paginators { get; }

        
        #region  BatchCreateUser


        /// <summary>
        /// Creates multiple users in a specified Wickr network. This operation allows you to
        /// provision multiple user accounts simultaneously, optionally specifying security groups,
        /// and validation requirements for each user.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>codeValidation</c>, <c>inviteCode</c>, and <c>inviteCodeTtl</c> are restricted
        /// to networks under preview only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateUser service method.</param>
        /// 
        /// <returns>The response from the BatchCreateUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchCreateUser">REST API Reference for BatchCreateUser Operation</seealso>
        BatchCreateUserResponse BatchCreateUser(BatchCreateUserRequest request);



        /// <summary>
        /// Creates multiple users in a specified Wickr network. This operation allows you to
        /// provision multiple user accounts simultaneously, optionally specifying security groups,
        /// and validation requirements for each user.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>codeValidation</c>, <c>inviteCode</c>, and <c>inviteCodeTtl</c> are restricted
        /// to networks under preview only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreateUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchCreateUser">REST API Reference for BatchCreateUser Operation</seealso>
        Task<BatchCreateUserResponse> BatchCreateUserAsync(BatchCreateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDeleteUser


        /// <summary>
        /// Deletes multiple users from a specified Wickr network. This operation permanently
        /// removes user accounts and their associated data from the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteUser service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchDeleteUser">REST API Reference for BatchDeleteUser Operation</seealso>
        BatchDeleteUserResponse BatchDeleteUser(BatchDeleteUserRequest request);



        /// <summary>
        /// Deletes multiple users from a specified Wickr network. This operation permanently
        /// removes user accounts and their associated data from the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchDeleteUser">REST API Reference for BatchDeleteUser Operation</seealso>
        Task<BatchDeleteUserResponse> BatchDeleteUserAsync(BatchDeleteUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchLookupUserUname


        /// <summary>
        /// Looks up multiple user usernames from their unique username hashes (unames). This
        /// operation allows you to retrieve the email addresses associated with a list of username
        /// hashes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchLookupUserUname service method.</param>
        /// 
        /// <returns>The response from the BatchLookupUserUname service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchLookupUserUname">REST API Reference for BatchLookupUserUname Operation</seealso>
        BatchLookupUserUnameResponse BatchLookupUserUname(BatchLookupUserUnameRequest request);



        /// <summary>
        /// Looks up multiple user usernames from their unique username hashes (unames). This
        /// operation allows you to retrieve the email addresses associated with a list of username
        /// hashes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchLookupUserUname service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchLookupUserUname service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchLookupUserUname">REST API Reference for BatchLookupUserUname Operation</seealso>
        Task<BatchLookupUserUnameResponse> BatchLookupUserUnameAsync(BatchLookupUserUnameRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchReinviteUser


        /// <summary>
        /// Resends invitation codes to multiple users who have pending invitations in a Wickr
        /// network. This operation is useful when users haven't accepted their initial invitations
        /// or when invitations have expired.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchReinviteUser service method.</param>
        /// 
        /// <returns>The response from the BatchReinviteUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchReinviteUser">REST API Reference for BatchReinviteUser Operation</seealso>
        BatchReinviteUserResponse BatchReinviteUser(BatchReinviteUserRequest request);



        /// <summary>
        /// Resends invitation codes to multiple users who have pending invitations in a Wickr
        /// network. This operation is useful when users haven't accepted their initial invitations
        /// or when invitations have expired.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchReinviteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchReinviteUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchReinviteUser">REST API Reference for BatchReinviteUser Operation</seealso>
        Task<BatchReinviteUserResponse> BatchReinviteUserAsync(BatchReinviteUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchResetDevicesForUser


        /// <summary>
        /// Resets multiple devices for a specific user in a Wickr network. This operation forces
        /// the selected devices to log out and requires users to re-authenticate, which is useful
        /// for security purposes or when devices need to be revoked.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchResetDevicesForUser service method.</param>
        /// 
        /// <returns>The response from the BatchResetDevicesForUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchResetDevicesForUser">REST API Reference for BatchResetDevicesForUser Operation</seealso>
        BatchResetDevicesForUserResponse BatchResetDevicesForUser(BatchResetDevicesForUserRequest request);



        /// <summary>
        /// Resets multiple devices for a specific user in a Wickr network. This operation forces
        /// the selected devices to log out and requires users to re-authenticate, which is useful
        /// for security purposes or when devices need to be revoked.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchResetDevicesForUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchResetDevicesForUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchResetDevicesForUser">REST API Reference for BatchResetDevicesForUser Operation</seealso>
        Task<BatchResetDevicesForUserResponse> BatchResetDevicesForUserAsync(BatchResetDevicesForUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchToggleUserSuspendStatus


        /// <summary>
        /// Suspends or unsuspends multiple users in a Wickr network. Suspended users cannot access
        /// the network until they are unsuspended. This operation is useful for temporarily restricting
        /// access without deleting user accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchToggleUserSuspendStatus service method.</param>
        /// 
        /// <returns>The response from the BatchToggleUserSuspendStatus service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchToggleUserSuspendStatus">REST API Reference for BatchToggleUserSuspendStatus Operation</seealso>
        BatchToggleUserSuspendStatusResponse BatchToggleUserSuspendStatus(BatchToggleUserSuspendStatusRequest request);



        /// <summary>
        /// Suspends or unsuspends multiple users in a Wickr network. Suspended users cannot access
        /// the network until they are unsuspended. This operation is useful for temporarily restricting
        /// access without deleting user accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchToggleUserSuspendStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchToggleUserSuspendStatus service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/BatchToggleUserSuspendStatus">REST API Reference for BatchToggleUserSuspendStatus Operation</seealso>
        Task<BatchToggleUserSuspendStatusResponse> BatchToggleUserSuspendStatusAsync(BatchToggleUserSuspendStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateBot


        /// <summary>
        /// Creates a new bot in a specified Wickr network. Bots are automated accounts that can
        /// send and receive messages, enabling integration with external systems and automation
        /// of tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBot service method.</param>
        /// 
        /// <returns>The response from the CreateBot service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateBot">REST API Reference for CreateBot Operation</seealso>
        CreateBotResponse CreateBot(CreateBotRequest request);



        /// <summary>
        /// Creates a new bot in a specified Wickr network. Bots are automated accounts that can
        /// send and receive messages, enabling integration with external systems and automation
        /// of tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBot service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateBot">REST API Reference for CreateBot Operation</seealso>
        Task<CreateBotResponse> CreateBotAsync(CreateBotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDataRetentionBot


        /// <summary>
        /// Creates a data retention bot in a Wickr network. Data retention bots are specialized
        /// bots that handle message archiving and compliance by capturing and storing messages
        /// for regulatory or organizational requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataRetentionBot service method.</param>
        /// 
        /// <returns>The response from the CreateDataRetentionBot service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateDataRetentionBot">REST API Reference for CreateDataRetentionBot Operation</seealso>
        CreateDataRetentionBotResponse CreateDataRetentionBot(CreateDataRetentionBotRequest request);



        /// <summary>
        /// Creates a data retention bot in a Wickr network. Data retention bots are specialized
        /// bots that handle message archiving and compliance by capturing and storing messages
        /// for regulatory or organizational requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataRetentionBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataRetentionBot service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateDataRetentionBot">REST API Reference for CreateDataRetentionBot Operation</seealso>
        Task<CreateDataRetentionBotResponse> CreateDataRetentionBotAsync(CreateDataRetentionBotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDataRetentionBotChallenge


        /// <summary>
        /// Creates a new challenge password for the data retention bot. This password is used
        /// for authentication when the bot connects to the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataRetentionBotChallenge service method.</param>
        /// 
        /// <returns>The response from the CreateDataRetentionBotChallenge service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateDataRetentionBotChallenge">REST API Reference for CreateDataRetentionBotChallenge Operation</seealso>
        CreateDataRetentionBotChallengeResponse CreateDataRetentionBotChallenge(CreateDataRetentionBotChallengeRequest request);



        /// <summary>
        /// Creates a new challenge password for the data retention bot. This password is used
        /// for authentication when the bot connects to the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataRetentionBotChallenge service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataRetentionBotChallenge service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateDataRetentionBotChallenge">REST API Reference for CreateDataRetentionBotChallenge Operation</seealso>
        Task<CreateDataRetentionBotChallengeResponse> CreateDataRetentionBotChallengeAsync(CreateDataRetentionBotChallengeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateNetwork


        /// <summary>
        /// Creates a new Wickr network with specified access level and configuration. This operation
        /// provisions a new communication network for your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetwork service method.</param>
        /// 
        /// <returns>The response from the CreateNetwork service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateNetwork">REST API Reference for CreateNetwork Operation</seealso>
        CreateNetworkResponse CreateNetwork(CreateNetworkRequest request);



        /// <summary>
        /// Creates a new Wickr network with specified access level and configuration. This operation
        /// provisions a new communication network for your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNetwork service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateNetwork">REST API Reference for CreateNetwork Operation</seealso>
        Task<CreateNetworkResponse> CreateNetworkAsync(CreateNetworkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSecurityGroup


        /// <summary>
        /// Creates a new security group in a Wickr network. Security groups allow you to organize
        /// users and control their permissions, features, and security settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the CreateSecurityGroup service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateSecurityGroup">REST API Reference for CreateSecurityGroup Operation</seealso>
        CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request);



        /// <summary>
        /// Creates a new security group in a Wickr network. Security groups allow you to organize
        /// users and control their permissions, features, and security settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSecurityGroup service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/CreateSecurityGroup">REST API Reference for CreateSecurityGroup Operation</seealso>
        Task<CreateSecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBot


        /// <summary>
        /// Deletes a bot from a specified Wickr network. This operation permanently removes the
        /// bot account and its associated data from the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBot service method.</param>
        /// 
        /// <returns>The response from the DeleteBot service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/DeleteBot">REST API Reference for DeleteBot Operation</seealso>
        DeleteBotResponse DeleteBot(DeleteBotRequest request);



        /// <summary>
        /// Deletes a bot from a specified Wickr network. This operation permanently removes the
        /// bot account and its associated data from the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBot service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/DeleteBot">REST API Reference for DeleteBot Operation</seealso>
        Task<DeleteBotResponse> DeleteBotAsync(DeleteBotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDataRetentionBot


        /// <summary>
        /// Deletes the data retention bot from a Wickr network. This operation permanently removes
        /// the bot and all its associated data from the database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataRetentionBot service method.</param>
        /// 
        /// <returns>The response from the DeleteDataRetentionBot service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/DeleteDataRetentionBot">REST API Reference for DeleteDataRetentionBot Operation</seealso>
        DeleteDataRetentionBotResponse DeleteDataRetentionBot(DeleteDataRetentionBotRequest request);



        /// <summary>
        /// Deletes the data retention bot from a Wickr network. This operation permanently removes
        /// the bot and all its associated data from the database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataRetentionBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataRetentionBot service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/DeleteDataRetentionBot">REST API Reference for DeleteDataRetentionBot Operation</seealso>
        Task<DeleteDataRetentionBotResponse> DeleteDataRetentionBotAsync(DeleteDataRetentionBotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteNetwork


        /// <summary>
        /// Deletes a Wickr network and all its associated resources, including users, bots, security
        /// groups, and settings. This operation is permanent and cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetwork service method.</param>
        /// 
        /// <returns>The response from the DeleteNetwork service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/DeleteNetwork">REST API Reference for DeleteNetwork Operation</seealso>
        DeleteNetworkResponse DeleteNetwork(DeleteNetworkRequest request);



        /// <summary>
        /// Deletes a Wickr network and all its associated resources, including users, bots, security
        /// groups, and settings. This operation is permanent and cannot be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNetwork service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/DeleteNetwork">REST API Reference for DeleteNetwork Operation</seealso>
        Task<DeleteNetworkResponse> DeleteNetworkAsync(DeleteNetworkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSecurityGroup


        /// <summary>
        /// Deletes a security group from a Wickr network. This operation cannot be performed
        /// on the default security group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteSecurityGroup service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/DeleteSecurityGroup">REST API Reference for DeleteSecurityGroup Operation</seealso>
        DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request);



        /// <summary>
        /// Deletes a security group from a Wickr network. This operation cannot be performed
        /// on the default security group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSecurityGroup service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/DeleteSecurityGroup">REST API Reference for DeleteSecurityGroup Operation</seealso>
        Task<DeleteSecurityGroupResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBot


        /// <summary>
        /// Retrieves detailed information about a specific bot in a Wickr network, including
        /// its status, group membership, and authentication details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBot service method.</param>
        /// 
        /// <returns>The response from the GetBot service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetBot">REST API Reference for GetBot Operation</seealso>
        GetBotResponse GetBot(GetBotRequest request);



        /// <summary>
        /// Retrieves detailed information about a specific bot in a Wickr network, including
        /// its status, group membership, and authentication details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBot service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetBot">REST API Reference for GetBot Operation</seealso>
        Task<GetBotResponse> GetBotAsync(GetBotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBotsCount


        /// <summary>
        /// Retrieves the count of bots in a Wickr network, categorized by their status (pending,
        /// active, and total).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBotsCount service method.</param>
        /// 
        /// <returns>The response from the GetBotsCount service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetBotsCount">REST API Reference for GetBotsCount Operation</seealso>
        GetBotsCountResponse GetBotsCount(GetBotsCountRequest request);



        /// <summary>
        /// Retrieves the count of bots in a Wickr network, categorized by their status (pending,
        /// active, and total).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBotsCount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBotsCount service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetBotsCount">REST API Reference for GetBotsCount Operation</seealso>
        Task<GetBotsCountResponse> GetBotsCountAsync(GetBotsCountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDataRetentionBot


        /// <summary>
        /// Retrieves information about the data retention bot in a Wickr network, including its
        /// status and whether the data retention service is enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataRetentionBot service method.</param>
        /// 
        /// <returns>The response from the GetDataRetentionBot service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetDataRetentionBot">REST API Reference for GetDataRetentionBot Operation</seealso>
        GetDataRetentionBotResponse GetDataRetentionBot(GetDataRetentionBotRequest request);



        /// <summary>
        /// Retrieves information about the data retention bot in a Wickr network, including its
        /// status and whether the data retention service is enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataRetentionBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataRetentionBot service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetDataRetentionBot">REST API Reference for GetDataRetentionBot Operation</seealso>
        Task<GetDataRetentionBotResponse> GetDataRetentionBotAsync(GetDataRetentionBotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetGuestUserHistoryCount


        /// <summary>
        /// Retrieves historical guest user count data for a Wickr network, showing the number
        /// of guest users per billing period over the past 90 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGuestUserHistoryCount service method.</param>
        /// 
        /// <returns>The response from the GetGuestUserHistoryCount service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetGuestUserHistoryCount">REST API Reference for GetGuestUserHistoryCount Operation</seealso>
        GetGuestUserHistoryCountResponse GetGuestUserHistoryCount(GetGuestUserHistoryCountRequest request);



        /// <summary>
        /// Retrieves historical guest user count data for a Wickr network, showing the number
        /// of guest users per billing period over the past 90 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGuestUserHistoryCount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGuestUserHistoryCount service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetGuestUserHistoryCount">REST API Reference for GetGuestUserHistoryCount Operation</seealso>
        Task<GetGuestUserHistoryCountResponse> GetGuestUserHistoryCountAsync(GetGuestUserHistoryCountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetNetwork


        /// <summary>
        /// Retrieves detailed information about a specific Wickr network, including its configuration,
        /// access level, and status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetwork service method.</param>
        /// 
        /// <returns>The response from the GetNetwork service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetNetwork">REST API Reference for GetNetwork Operation</seealso>
        GetNetworkResponse GetNetwork(GetNetworkRequest request);



        /// <summary>
        /// Retrieves detailed information about a specific Wickr network, including its configuration,
        /// access level, and status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetwork service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetNetwork">REST API Reference for GetNetwork Operation</seealso>
        Task<GetNetworkResponse> GetNetworkAsync(GetNetworkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetNetworkSettings


        /// <summary>
        /// Retrieves all network-level settings for a Wickr network, including client metrics,
        /// data retention, and other configuration options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the GetNetworkSettings service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetNetworkSettings">REST API Reference for GetNetworkSettings Operation</seealso>
        GetNetworkSettingsResponse GetNetworkSettings(GetNetworkSettingsRequest request);



        /// <summary>
        /// Retrieves all network-level settings for a Wickr network, including client metrics,
        /// data retention, and other configuration options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetworkSettings service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetNetworkSettings">REST API Reference for GetNetworkSettings Operation</seealso>
        Task<GetNetworkSettingsResponse> GetNetworkSettingsAsync(GetNetworkSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOidcInfo


        /// <summary>
        /// Retrieves the OpenID Connect (OIDC) configuration for a Wickr network, including SSO
        /// settings and optional token information if access token parameters are provided.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOidcInfo service method.</param>
        /// 
        /// <returns>The response from the GetOidcInfo service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetOidcInfo">REST API Reference for GetOidcInfo Operation</seealso>
        GetOidcInfoResponse GetOidcInfo(GetOidcInfoRequest request);



        /// <summary>
        /// Retrieves the OpenID Connect (OIDC) configuration for a Wickr network, including SSO
        /// settings and optional token information if access token parameters are provided.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOidcInfo service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOidcInfo service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetOidcInfo">REST API Reference for GetOidcInfo Operation</seealso>
        Task<GetOidcInfoResponse> GetOidcInfoAsync(GetOidcInfoRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSecurityGroup


        /// <summary>
        /// Retrieves detailed information about a specific security group in a Wickr network,
        /// including its settings, member counts, and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the GetSecurityGroup service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetSecurityGroup">REST API Reference for GetSecurityGroup Operation</seealso>
        GetSecurityGroupResponse GetSecurityGroup(GetSecurityGroupRequest request);



        /// <summary>
        /// Retrieves detailed information about a specific security group in a Wickr network,
        /// including its settings, member counts, and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSecurityGroup service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetSecurityGroup">REST API Reference for GetSecurityGroup Operation</seealso>
        Task<GetSecurityGroupResponse> GetSecurityGroupAsync(GetSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetUser


        /// <summary>
        /// Retrieves detailed information about a specific user in a Wickr network, including
        /// their profile, status, and activity history.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUser service method.</param>
        /// 
        /// <returns>The response from the GetUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetUser">REST API Reference for GetUser Operation</seealso>
        GetUserResponse GetUser(GetUserRequest request);



        /// <summary>
        /// Retrieves detailed information about a specific user in a Wickr network, including
        /// their profile, status, and activity history.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetUser">REST API Reference for GetUser Operation</seealso>
        Task<GetUserResponse> GetUserAsync(GetUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetUsersCount


        /// <summary>
        /// Retrieves the count of users in a Wickr network, categorized by their status (pending,
        /// active, rejected) and showing how many users can still be added.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsersCount service method.</param>
        /// 
        /// <returns>The response from the GetUsersCount service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetUsersCount">REST API Reference for GetUsersCount Operation</seealso>
        GetUsersCountResponse GetUsersCount(GetUsersCountRequest request);



        /// <summary>
        /// Retrieves the count of users in a Wickr network, categorized by their status (pending,
        /// active, rejected) and showing how many users can still be added.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsersCount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUsersCount service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/GetUsersCount">REST API Reference for GetUsersCount Operation</seealso>
        Task<GetUsersCountResponse> GetUsersCountAsync(GetUsersCountRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListBlockedGuestUsers


        /// <summary>
        /// Retrieves a paginated list of guest users who have been blocked from a Wickr network.
        /// You can filter and sort the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBlockedGuestUsers service method.</param>
        /// 
        /// <returns>The response from the ListBlockedGuestUsers service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListBlockedGuestUsers">REST API Reference for ListBlockedGuestUsers Operation</seealso>
        ListBlockedGuestUsersResponse ListBlockedGuestUsers(ListBlockedGuestUsersRequest request);



        /// <summary>
        /// Retrieves a paginated list of guest users who have been blocked from a Wickr network.
        /// You can filter and sort the results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBlockedGuestUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBlockedGuestUsers service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListBlockedGuestUsers">REST API Reference for ListBlockedGuestUsers Operation</seealso>
        Task<ListBlockedGuestUsersResponse> ListBlockedGuestUsersAsync(ListBlockedGuestUsersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListBots


        /// <summary>
        /// Retrieves a paginated list of bots in a specified Wickr network. You can filter and
        /// sort the results based on various criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBots service method.</param>
        /// 
        /// <returns>The response from the ListBots service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListBots">REST API Reference for ListBots Operation</seealso>
        ListBotsResponse ListBots(ListBotsRequest request);



        /// <summary>
        /// Retrieves a paginated list of bots in a specified Wickr network. You can filter and
        /// sort the results based on various criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBots service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListBots">REST API Reference for ListBots Operation</seealso>
        Task<ListBotsResponse> ListBotsAsync(ListBotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDevicesForUser


        /// <summary>
        /// Retrieves a paginated list of devices associated with a specific user in a Wickr network.
        /// This operation returns information about all devices where the user has logged into
        /// Wickr.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevicesForUser service method.</param>
        /// 
        /// <returns>The response from the ListDevicesForUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListDevicesForUser">REST API Reference for ListDevicesForUser Operation</seealso>
        ListDevicesForUserResponse ListDevicesForUser(ListDevicesForUserRequest request);



        /// <summary>
        /// Retrieves a paginated list of devices associated with a specific user in a Wickr network.
        /// This operation returns information about all devices where the user has logged into
        /// Wickr.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevicesForUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDevicesForUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListDevicesForUser">REST API Reference for ListDevicesForUser Operation</seealso>
        Task<ListDevicesForUserResponse> ListDevicesForUserAsync(ListDevicesForUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGuestUsers


        /// <summary>
        /// Retrieves a paginated list of guest users who have communicated with your Wickr network.
        /// Guest users are external users from federated networks who can communicate with network
        /// members.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGuestUsers service method.</param>
        /// 
        /// <returns>The response from the ListGuestUsers service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListGuestUsers">REST API Reference for ListGuestUsers Operation</seealso>
        ListGuestUsersResponse ListGuestUsers(ListGuestUsersRequest request);



        /// <summary>
        /// Retrieves a paginated list of guest users who have communicated with your Wickr network.
        /// Guest users are external users from federated networks who can communicate with network
        /// members.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGuestUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGuestUsers service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListGuestUsers">REST API Reference for ListGuestUsers Operation</seealso>
        Task<ListGuestUsersResponse> ListGuestUsersAsync(ListGuestUsersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListNetworks


        /// <summary>
        /// Retrieves a paginated list of all Wickr networks associated with your Amazon Web Services
        /// account. You can sort the results by network ID or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworks service method.</param>
        /// 
        /// <returns>The response from the ListNetworks service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListNetworks">REST API Reference for ListNetworks Operation</seealso>
        ListNetworksResponse ListNetworks(ListNetworksRequest request);



        /// <summary>
        /// Retrieves a paginated list of all Wickr networks associated with your Amazon Web Services
        /// account. You can sort the results by network ID or name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNetworks service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListNetworks">REST API Reference for ListNetworks Operation</seealso>
        Task<ListNetworksResponse> ListNetworksAsync(ListNetworksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSecurityGroups


        /// <summary>
        /// Retrieves a paginated list of security groups in a specified Wickr network. You can
        /// sort the results by various criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the ListSecurityGroups service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListSecurityGroups">REST API Reference for ListSecurityGroups Operation</seealso>
        ListSecurityGroupsResponse ListSecurityGroups(ListSecurityGroupsRequest request);



        /// <summary>
        /// Retrieves a paginated list of security groups in a specified Wickr network. You can
        /// sort the results by various criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecurityGroups service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListSecurityGroups">REST API Reference for ListSecurityGroups Operation</seealso>
        Task<ListSecurityGroupsResponse> ListSecurityGroupsAsync(ListSecurityGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSecurityGroupUsers


        /// <summary>
        /// Retrieves a paginated list of users who belong to a specific security group in a Wickr
        /// network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityGroupUsers service method.</param>
        /// 
        /// <returns>The response from the ListSecurityGroupUsers service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListSecurityGroupUsers">REST API Reference for ListSecurityGroupUsers Operation</seealso>
        ListSecurityGroupUsersResponse ListSecurityGroupUsers(ListSecurityGroupUsersRequest request);



        /// <summary>
        /// Retrieves a paginated list of users who belong to a specific security group in a Wickr
        /// network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityGroupUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecurityGroupUsers service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListSecurityGroupUsers">REST API Reference for ListSecurityGroupUsers Operation</seealso>
        Task<ListSecurityGroupUsersResponse> ListSecurityGroupUsersAsync(ListSecurityGroupUsersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUsers


        /// <summary>
        /// Retrieves a paginated list of users in a specified Wickr network. You can filter and
        /// sort the results based on various criteria such as name, status, or security group
        /// membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        ListUsersResponse ListUsers(ListUsersRequest request);



        /// <summary>
        /// Retrieves a paginated list of users in a specified Wickr network. You can filter and
        /// sort the results based on various criteria such as name, status, or security group
        /// membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterOidcConfig


        /// <summary>
        /// Registers and saves an OpenID Connect (OIDC) configuration for a Wickr network, enabling
        /// Single Sign-On (SSO) authentication through an identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterOidcConfig service method.</param>
        /// 
        /// <returns>The response from the RegisterOidcConfig service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/RegisterOidcConfig">REST API Reference for RegisterOidcConfig Operation</seealso>
        RegisterOidcConfigResponse RegisterOidcConfig(RegisterOidcConfigRequest request);



        /// <summary>
        /// Registers and saves an OpenID Connect (OIDC) configuration for a Wickr network, enabling
        /// Single Sign-On (SSO) authentication through an identity provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterOidcConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterOidcConfig service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/RegisterOidcConfig">REST API Reference for RegisterOidcConfig Operation</seealso>
        Task<RegisterOidcConfigResponse> RegisterOidcConfigAsync(RegisterOidcConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterOidcConfigTest


        /// <summary>
        /// Tests an OpenID Connect (OIDC) configuration for a Wickr network by validating the
        /// connection to the identity provider and retrieving its supported capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterOidcConfigTest service method.</param>
        /// 
        /// <returns>The response from the RegisterOidcConfigTest service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/RegisterOidcConfigTest">REST API Reference for RegisterOidcConfigTest Operation</seealso>
        RegisterOidcConfigTestResponse RegisterOidcConfigTest(RegisterOidcConfigTestRequest request);



        /// <summary>
        /// Tests an OpenID Connect (OIDC) configuration for a Wickr network by validating the
        /// connection to the identity provider and retrieving its supported capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterOidcConfigTest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterOidcConfigTest service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/RegisterOidcConfigTest">REST API Reference for RegisterOidcConfigTest Operation</seealso>
        Task<RegisterOidcConfigTestResponse> RegisterOidcConfigTestAsync(RegisterOidcConfigTestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateBot


        /// <summary>
        /// Updates the properties of an existing bot in a Wickr network. This operation allows
        /// you to modify the bot's display name, security group, password, or suspension status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBot service method.</param>
        /// 
        /// <returns>The response from the UpdateBot service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateBot">REST API Reference for UpdateBot Operation</seealso>
        UpdateBotResponse UpdateBot(UpdateBotRequest request);



        /// <summary>
        /// Updates the properties of an existing bot in a Wickr network. This operation allows
        /// you to modify the bot's display name, security group, password, or suspension status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBot service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateBot">REST API Reference for UpdateBot Operation</seealso>
        Task<UpdateBotResponse> UpdateBotAsync(UpdateBotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDataRetention


        /// <summary>
        /// Updates the data retention bot settings, allowing you to enable or disable the data
        /// retention service, or acknowledge the public key message.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataRetention service method.</param>
        /// 
        /// <returns>The response from the UpdateDataRetention service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateDataRetention">REST API Reference for UpdateDataRetention Operation</seealso>
        UpdateDataRetentionResponse UpdateDataRetention(UpdateDataRetentionRequest request);



        /// <summary>
        /// Updates the data retention bot settings, allowing you to enable or disable the data
        /// retention service, or acknowledge the public key message.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataRetention service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataRetention service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateDataRetention">REST API Reference for UpdateDataRetention Operation</seealso>
        Task<UpdateDataRetentionResponse> UpdateDataRetentionAsync(UpdateDataRetentionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateGuestUser


        /// <summary>
        /// Updates the block status of a guest user in a Wickr network. This operation allows
        /// you to block or unblock a guest user from accessing the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGuestUser service method.</param>
        /// 
        /// <returns>The response from the UpdateGuestUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateGuestUser">REST API Reference for UpdateGuestUser Operation</seealso>
        UpdateGuestUserResponse UpdateGuestUser(UpdateGuestUserRequest request);



        /// <summary>
        /// Updates the block status of a guest user in a Wickr network. This operation allows
        /// you to block or unblock a guest user from accessing the network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGuestUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGuestUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateGuestUser">REST API Reference for UpdateGuestUser Operation</seealso>
        Task<UpdateGuestUserResponse> UpdateGuestUserAsync(UpdateGuestUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateNetwork


        /// <summary>
        /// Updates the properties of an existing Wickr network, such as its name or encryption
        /// key configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetwork service method.</param>
        /// 
        /// <returns>The response from the UpdateNetwork service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateNetwork">REST API Reference for UpdateNetwork Operation</seealso>
        UpdateNetworkResponse UpdateNetwork(UpdateNetworkRequest request);



        /// <summary>
        /// Updates the properties of an existing Wickr network, such as its name or encryption
        /// key configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNetwork service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateNetwork">REST API Reference for UpdateNetwork Operation</seealso>
        Task<UpdateNetworkResponse> UpdateNetworkAsync(UpdateNetworkRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateNetworkSettings


        /// <summary>
        /// Updates network-level settings for a Wickr network. You can modify settings such as
        /// client metrics, data retention, and other network-wide options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateNetworkSettings service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateNetworkSettings">REST API Reference for UpdateNetworkSettings Operation</seealso>
        UpdateNetworkSettingsResponse UpdateNetworkSettings(UpdateNetworkSettingsRequest request);



        /// <summary>
        /// Updates network-level settings for a Wickr network. You can modify settings such as
        /// client metrics, data retention, and other network-wide options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNetworkSettings service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateNetworkSettings">REST API Reference for UpdateNetworkSettings Operation</seealso>
        Task<UpdateNetworkSettingsResponse> UpdateNetworkSettingsAsync(UpdateNetworkSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSecurityGroup


        /// <summary>
        /// Updates the properties of an existing security group in a Wickr network, such as its
        /// name or settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateSecurityGroup service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateSecurityGroup">REST API Reference for UpdateSecurityGroup Operation</seealso>
        UpdateSecurityGroupResponse UpdateSecurityGroup(UpdateSecurityGroupRequest request);



        /// <summary>
        /// Updates the properties of an existing security group in a Wickr network, such as its
        /// name or settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSecurityGroup service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateSecurityGroup">REST API Reference for UpdateSecurityGroup Operation</seealso>
        Task<UpdateSecurityGroupResponse> UpdateSecurityGroupAsync(UpdateSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUser


        /// <summary>
        /// Updates the properties of an existing user in a Wickr network. This operation allows
        /// you to modify the user's name, password, security group membership, and invite code
        /// settings.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>codeValidation</c>, <c>inviteCode</c>, and <c>inviteCodeTtl</c> are restricted
        /// to networks under preview only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse UpdateUser(UpdateUserRequest request);



        /// <summary>
        /// Updates the properties of an existing user in a Wickr network. This operation allows
        /// you to modify the user's name, password, security group membership, and invite code
        /// settings.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>codeValidation</c>, <c>inviteCode</c>, and <c>inviteCodeTtl</c> are restricted
        /// to networks under preview only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by Wickr.</returns>
        /// <exception cref="Amazon.Wickr.Model.BadRequestErrorException">
        /// The request was invalid or malformed. This error occurs when the request parameters
        /// do not meet the API requirements, such as invalid field values, missing required parameters,
        /// or improperly formatted data.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ForbiddenErrorException">
        /// Access to the requested resource is forbidden. This error occurs when the authenticated
        /// user does not have the necessary permissions to perform the requested operation, even
        /// though they are authenticated.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.InternalServerErrorException">
        /// An unexpected error occurred on the server while processing the request. This indicates
        /// a problem with the Wickr service itself rather than with the request. If this error
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.RateLimitErrorException">
        /// The request was throttled because too many requests were sent in a short period of
        /// time. Wait a moment and retry the request. Consider implementing exponential backoff
        /// in your application.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ResourceNotFoundErrorException">
        /// The requested resource could not be found. This error occurs when you try to access
        /// or modify a network, user, bot, security group, or other resource that doesn't exist
        /// or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.UnauthorizedErrorException">
        /// The request was not authenticated or the authentication credentials were invalid.
        /// This error occurs when the request lacks valid authentication credentials or the credentials
        /// have expired.
        /// </exception>
        /// <exception cref="Amazon.Wickr.Model.ValidationErrorException">
        /// One or more fields in the request failed validation. This error provides detailed
        /// information about which fields were invalid and why, allowing you to correct the request
        /// and retry.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wickr-2024-02-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

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