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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PcaConnectorAd.Model;

#pragma warning disable CS1570
namespace Amazon.PcaConnectorAd
{
    /// <summary>
    /// <para>Interface for accessing PcaConnectorAd</para>
    ///
    /// Amazon Web Services Private CA Connector for Active Directory creates a connector
    /// between Amazon Web Services Private CA and Active Directory (AD) that enables you
    /// to provision security certificates for AD signed by a private CA that you own. For
    /// more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/ad-connector.html">Amazon
    /// Web Services Private CA Connector for Active Directory</a>.
    /// </summary>
    public partial interface IAmazonPcaConnectorAd : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPcaConnectorAdPaginatorFactory Paginators { get; }

        
        #region  CreateConnector


        /// <summary>
        /// Creates a connector between Amazon Web Services Private CA and an Active Directory.
        /// You must specify the private CA, directory ID, and security groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector service method.</param>
        /// 
        /// <returns>The response from the CreateConnector service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        CreateConnectorResponse CreateConnector(CreateConnectorRequest request);



        /// <summary>
        /// Creates a connector between Amazon Web Services Private CA and an Active Directory.
        /// You must specify the private CA, directory ID, and security groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnector service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        Task<CreateConnectorResponse> CreateConnectorAsync(CreateConnectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateDirectoryRegistration


        /// <summary>
        /// Creates a directory registration that authorizes communication between Amazon Web
        /// Services Private CA and an Active Directory
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectoryRegistration service method.</param>
        /// 
        /// <returns>The response from the CreateDirectoryRegistration service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateDirectoryRegistration">REST API Reference for CreateDirectoryRegistration Operation</seealso>
        CreateDirectoryRegistrationResponse CreateDirectoryRegistration(CreateDirectoryRegistrationRequest request);



        /// <summary>
        /// Creates a directory registration that authorizes communication between Amazon Web
        /// Services Private CA and an Active Directory
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectoryRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDirectoryRegistration service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateDirectoryRegistration">REST API Reference for CreateDirectoryRegistration Operation</seealso>
        Task<CreateDirectoryRegistrationResponse> CreateDirectoryRegistrationAsync(CreateDirectoryRegistrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateServicePrincipalName


        /// <summary>
        /// Creates a service principal name (SPN) for the service account in Active Directory.
        /// Kerberos authentication uses SPNs to associate a service instance with a service sign-in
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServicePrincipalName service method.</param>
        /// 
        /// <returns>The response from the CreateServicePrincipalName service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateServicePrincipalName">REST API Reference for CreateServicePrincipalName Operation</seealso>
        CreateServicePrincipalNameResponse CreateServicePrincipalName(CreateServicePrincipalNameRequest request);



        /// <summary>
        /// Creates a service principal name (SPN) for the service account in Active Directory.
        /// Kerberos authentication uses SPNs to associate a service instance with a service sign-in
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServicePrincipalName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateServicePrincipalName service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateServicePrincipalName">REST API Reference for CreateServicePrincipalName Operation</seealso>
        Task<CreateServicePrincipalNameResponse> CreateServicePrincipalNameAsync(CreateServicePrincipalNameRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTemplate


        /// <summary>
        /// Creates an Active Directory compatible certificate template. The connectors issues
        /// certificates using these templates based on the requester’s Active Directory group
        /// membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        CreateTemplateResponse CreateTemplate(CreateTemplateRequest request);



        /// <summary>
        /// Creates an Active Directory compatible certificate template. The connectors issues
        /// certificates using these templates based on the requester’s Active Directory group
        /// membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTemplateGroupAccessControlEntry


        /// <summary>
        /// Create a group access control entry. Allow or deny Active Directory groups from enrolling
        /// and/or autoenrolling with the template based on the group security identifiers (SIDs).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateGroupAccessControlEntry service method.</param>
        /// 
        /// <returns>The response from the CreateTemplateGroupAccessControlEntry service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateTemplateGroupAccessControlEntry">REST API Reference for CreateTemplateGroupAccessControlEntry Operation</seealso>
        CreateTemplateGroupAccessControlEntryResponse CreateTemplateGroupAccessControlEntry(CreateTemplateGroupAccessControlEntryRequest request);



        /// <summary>
        /// Create a group access control entry. Allow or deny Active Directory groups from enrolling
        /// and/or autoenrolling with the template based on the group security identifiers (SIDs).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateGroupAccessControlEntry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTemplateGroupAccessControlEntry service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateTemplateGroupAccessControlEntry">REST API Reference for CreateTemplateGroupAccessControlEntry Operation</seealso>
        Task<CreateTemplateGroupAccessControlEntryResponse> CreateTemplateGroupAccessControlEntryAsync(CreateTemplateGroupAccessControlEntryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteConnector


        /// <summary>
        /// Deletes a connector for Active Directory. You must provide the Amazon Resource Name
        /// (ARN) of the connector that you want to delete. You can find the ARN by calling the
        /// <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_ListConnectors">https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_ListConnectors</a>
        /// action. Deleting a connector does not deregister your directory with Amazon Web Services
        /// Private CA. You can deregister your directory by calling the <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_DeleteDirectoryRegistration">https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_DeleteDirectoryRegistration</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector service method.</param>
        /// 
        /// <returns>The response from the DeleteConnector service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        DeleteConnectorResponse DeleteConnector(DeleteConnectorRequest request);



        /// <summary>
        /// Deletes a connector for Active Directory. You must provide the Amazon Resource Name
        /// (ARN) of the connector that you want to delete. You can find the ARN by calling the
        /// <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_ListConnectors">https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_ListConnectors</a>
        /// action. Deleting a connector does not deregister your directory with Amazon Web Services
        /// Private CA. You can deregister your directory by calling the <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_DeleteDirectoryRegistration">https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_DeleteDirectoryRegistration</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnector service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        Task<DeleteConnectorResponse> DeleteConnectorAsync(DeleteConnectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDirectoryRegistration


        /// <summary>
        /// Deletes a directory registration. Deleting a directory registration deauthorizes Amazon
        /// Web Services Private CA with the directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectoryRegistration service method.</param>
        /// 
        /// <returns>The response from the DeleteDirectoryRegistration service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteDirectoryRegistration">REST API Reference for DeleteDirectoryRegistration Operation</seealso>
        DeleteDirectoryRegistrationResponse DeleteDirectoryRegistration(DeleteDirectoryRegistrationRequest request);



        /// <summary>
        /// Deletes a directory registration. Deleting a directory registration deauthorizes Amazon
        /// Web Services Private CA with the directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectoryRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDirectoryRegistration service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteDirectoryRegistration">REST API Reference for DeleteDirectoryRegistration Operation</seealso>
        Task<DeleteDirectoryRegistrationResponse> DeleteDirectoryRegistrationAsync(DeleteDirectoryRegistrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteServicePrincipalName


        /// <summary>
        /// Deletes the service principal name (SPN) used by a connector to authenticate with
        /// your Active Directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServicePrincipalName service method.</param>
        /// 
        /// <returns>The response from the DeleteServicePrincipalName service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteServicePrincipalName">REST API Reference for DeleteServicePrincipalName Operation</seealso>
        DeleteServicePrincipalNameResponse DeleteServicePrincipalName(DeleteServicePrincipalNameRequest request);



        /// <summary>
        /// Deletes the service principal name (SPN) used by a connector to authenticate with
        /// your Active Directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServicePrincipalName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServicePrincipalName service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteServicePrincipalName">REST API Reference for DeleteServicePrincipalName Operation</seealso>
        Task<DeleteServicePrincipalNameResponse> DeleteServicePrincipalNameAsync(DeleteServicePrincipalNameRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTemplate


        /// <summary>
        /// Deletes a template. Certificates issued using the template are still valid until they
        /// are revoked or expired.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteTemplate service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request);



        /// <summary>
        /// Deletes a template. Certificates issued using the template are still valid until they
        /// are revoked or expired.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTemplate service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTemplateGroupAccessControlEntry


        /// <summary>
        /// Deletes a group access control entry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplateGroupAccessControlEntry service method.</param>
        /// 
        /// <returns>The response from the DeleteTemplateGroupAccessControlEntry service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteTemplateGroupAccessControlEntry">REST API Reference for DeleteTemplateGroupAccessControlEntry Operation</seealso>
        DeleteTemplateGroupAccessControlEntryResponse DeleteTemplateGroupAccessControlEntry(DeleteTemplateGroupAccessControlEntryRequest request);



        /// <summary>
        /// Deletes a group access control entry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplateGroupAccessControlEntry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTemplateGroupAccessControlEntry service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteTemplateGroupAccessControlEntry">REST API Reference for DeleteTemplateGroupAccessControlEntry Operation</seealso>
        Task<DeleteTemplateGroupAccessControlEntryResponse> DeleteTemplateGroupAccessControlEntryAsync(DeleteTemplateGroupAccessControlEntryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetConnector


        /// <summary>
        /// Lists information about your connector. You specify the connector on input by its
        /// ARN (Amazon Resource Name).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnector service method.</param>
        /// 
        /// <returns>The response from the GetConnector service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetConnector">REST API Reference for GetConnector Operation</seealso>
        GetConnectorResponse GetConnector(GetConnectorRequest request);



        /// <summary>
        /// Lists information about your connector. You specify the connector on input by its
        /// ARN (Amazon Resource Name).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnector service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetConnector">REST API Reference for GetConnector Operation</seealso>
        Task<GetConnectorResponse> GetConnectorAsync(GetConnectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDirectoryRegistration


        /// <summary>
        /// A structure that contains information about your directory registration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDirectoryRegistration service method.</param>
        /// 
        /// <returns>The response from the GetDirectoryRegistration service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetDirectoryRegistration">REST API Reference for GetDirectoryRegistration Operation</seealso>
        GetDirectoryRegistrationResponse GetDirectoryRegistration(GetDirectoryRegistrationRequest request);



        /// <summary>
        /// A structure that contains information about your directory registration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDirectoryRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDirectoryRegistration service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetDirectoryRegistration">REST API Reference for GetDirectoryRegistration Operation</seealso>
        Task<GetDirectoryRegistrationResponse> GetDirectoryRegistrationAsync(GetDirectoryRegistrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetServicePrincipalName


        /// <summary>
        /// Lists the service principal name that the connector uses to authenticate with Active
        /// Directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServicePrincipalName service method.</param>
        /// 
        /// <returns>The response from the GetServicePrincipalName service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetServicePrincipalName">REST API Reference for GetServicePrincipalName Operation</seealso>
        GetServicePrincipalNameResponse GetServicePrincipalName(GetServicePrincipalNameRequest request);



        /// <summary>
        /// Lists the service principal name that the connector uses to authenticate with Active
        /// Directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServicePrincipalName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServicePrincipalName service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetServicePrincipalName">REST API Reference for GetServicePrincipalName Operation</seealso>
        Task<GetServicePrincipalNameResponse> GetServicePrincipalNameAsync(GetServicePrincipalNameRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTemplate


        /// <summary>
        /// Retrieves a certificate template that the connector uses to issue certificates from
        /// a private CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        GetTemplateResponse GetTemplate(GetTemplateRequest request);



        /// <summary>
        /// Retrieves a certificate template that the connector uses to issue certificates from
        /// a private CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTemplateGroupAccessControlEntry


        /// <summary>
        /// Retrieves the group access control entries for a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateGroupAccessControlEntry service method.</param>
        /// 
        /// <returns>The response from the GetTemplateGroupAccessControlEntry service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetTemplateGroupAccessControlEntry">REST API Reference for GetTemplateGroupAccessControlEntry Operation</seealso>
        GetTemplateGroupAccessControlEntryResponse GetTemplateGroupAccessControlEntry(GetTemplateGroupAccessControlEntryRequest request);



        /// <summary>
        /// Retrieves the group access control entries for a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateGroupAccessControlEntry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemplateGroupAccessControlEntry service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetTemplateGroupAccessControlEntry">REST API Reference for GetTemplateGroupAccessControlEntry Operation</seealso>
        Task<GetTemplateGroupAccessControlEntryResponse> GetTemplateGroupAccessControlEntryAsync(GetTemplateGroupAccessControlEntryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListConnectors


        /// <summary>
        /// Lists the connectors that you created by using the <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateConnector">https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateConnector</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors service method.</param>
        /// 
        /// <returns>The response from the ListConnectors service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        ListConnectorsResponse ListConnectors(ListConnectorsRequest request);



        /// <summary>
        /// Lists the connectors that you created by using the <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateConnector">https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateConnector</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnectors service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        Task<ListConnectorsResponse> ListConnectorsAsync(ListConnectorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDirectoryRegistrations


        /// <summary>
        /// Lists the directory registrations that you created by using the <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateDirectoryRegistration">https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateDirectoryRegistration</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDirectoryRegistrations service method.</param>
        /// 
        /// <returns>The response from the ListDirectoryRegistrations service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListDirectoryRegistrations">REST API Reference for ListDirectoryRegistrations Operation</seealso>
        ListDirectoryRegistrationsResponse ListDirectoryRegistrations(ListDirectoryRegistrationsRequest request);



        /// <summary>
        /// Lists the directory registrations that you created by using the <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateDirectoryRegistration">https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateDirectoryRegistration</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDirectoryRegistrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDirectoryRegistrations service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListDirectoryRegistrations">REST API Reference for ListDirectoryRegistrations Operation</seealso>
        Task<ListDirectoryRegistrationsResponse> ListDirectoryRegistrationsAsync(ListDirectoryRegistrationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListServicePrincipalNames


        /// <summary>
        /// Lists the service principal names that the connector uses to authenticate with Active
        /// Directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServicePrincipalNames service method.</param>
        /// 
        /// <returns>The response from the ListServicePrincipalNames service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListServicePrincipalNames">REST API Reference for ListServicePrincipalNames Operation</seealso>
        ListServicePrincipalNamesResponse ListServicePrincipalNames(ListServicePrincipalNamesRequest request);



        /// <summary>
        /// Lists the service principal names that the connector uses to authenticate with Active
        /// Directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServicePrincipalNames service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServicePrincipalNames service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListServicePrincipalNames">REST API Reference for ListServicePrincipalNames Operation</seealso>
        Task<ListServicePrincipalNamesResponse> ListServicePrincipalNamesAsync(ListServicePrincipalNamesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags, if any, that are associated with your resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the tags, if any, that are associated with your resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTemplateGroupAccessControlEntries


        /// <summary>
        /// Lists group access control entries you created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateGroupAccessControlEntries service method.</param>
        /// 
        /// <returns>The response from the ListTemplateGroupAccessControlEntries service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTemplateGroupAccessControlEntries">REST API Reference for ListTemplateGroupAccessControlEntries Operation</seealso>
        ListTemplateGroupAccessControlEntriesResponse ListTemplateGroupAccessControlEntries(ListTemplateGroupAccessControlEntriesRequest request);



        /// <summary>
        /// Lists group access control entries you created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateGroupAccessControlEntries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplateGroupAccessControlEntries service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTemplateGroupAccessControlEntries">REST API Reference for ListTemplateGroupAccessControlEntries Operation</seealso>
        Task<ListTemplateGroupAccessControlEntriesResponse> ListTemplateGroupAccessControlEntriesAsync(ListTemplateGroupAccessControlEntriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTemplates


        /// <summary>
        /// Lists the templates, if any, that are associated with a connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        ListTemplatesResponse ListTemplates(ListTemplatesRequest request);



        /// <summary>
        /// Lists the templates, if any, that are associated with a connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds one or more tags to your resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds one or more tags to your resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from your resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes one or more tags from your resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTemplate


        /// <summary>
        /// Update template configuration to define the information included in certificates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request);



        /// <summary>
        /// Update template configuration to define the information included in certificates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTemplateGroupAccessControlEntry


        /// <summary>
        /// Update a group access control entry you created using <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateTemplateGroupAccessControlEntry.html">CreateTemplateGroupAccessControlEntry</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateGroupAccessControlEntry service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplateGroupAccessControlEntry service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UpdateTemplateGroupAccessControlEntry">REST API Reference for UpdateTemplateGroupAccessControlEntry Operation</seealso>
        UpdateTemplateGroupAccessControlEntryResponse UpdateTemplateGroupAccessControlEntry(UpdateTemplateGroupAccessControlEntryRequest request);



        /// <summary>
        /// Update a group access control entry you created using <a href="https://docs.aws.amazon.com/pca-connector-ad/latest/APIReference/API_CreateTemplateGroupAccessControlEntry.html">CreateTemplateGroupAccessControlEntry</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateGroupAccessControlEntry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTemplateGroupAccessControlEntry service method, as returned by PcaConnectorAd.</returns>
        /// <exception cref="Amazon.PcaConnectorAd.Model.AccessDeniedException">
        /// You can receive this error if you attempt to create a resource share when you don't
        /// have the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ConflictException">
        /// This request cannot be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorAd.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a template
        /// name, or if a pagination token is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UpdateTemplateGroupAccessControlEntry">REST API Reference for UpdateTemplateGroupAccessControlEntry Operation</seealso>
        Task<UpdateTemplateGroupAccessControlEntryResponse> UpdateTemplateGroupAccessControlEntryAsync(UpdateTemplateGroupAccessControlEntryRequest request, CancellationToken cancellationToken = default(CancellationToken));

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