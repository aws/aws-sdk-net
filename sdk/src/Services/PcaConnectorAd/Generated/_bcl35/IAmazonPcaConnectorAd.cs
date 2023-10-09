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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PcaConnectorAd.Model;

namespace Amazon.PcaConnectorAd
{
    /// <summary>
    /// Interface for accessing PcaConnectorAd
    ///
    /// Amazon Web Services Private CA Connector for Active Directory creates a connector
    /// between Amazon Web Services Private CA and Active Directory (AD) that enables you
    /// to provision security certificates for AD signed by a private CA that you own. For
    /// more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/ad-connector.html">Amazon
    /// Web Services Private CA Connector for Active Directory</a>.
    /// </summary>
    public partial interface IAmazonPcaConnectorAd : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPcaConnectorAdPaginatorFactory Paginators { get; }
#endif


        
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
        /// Initiates the asynchronous execution of the CreateConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        IAsyncResult BeginCreateConnector(CreateConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnector.</param>
        /// 
        /// <returns>Returns a  CreateConnectorResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        CreateConnectorResponse EndCreateConnector(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateDirectoryRegistration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectoryRegistration operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDirectoryRegistration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateDirectoryRegistration">REST API Reference for CreateDirectoryRegistration Operation</seealso>
        IAsyncResult BeginCreateDirectoryRegistration(CreateDirectoryRegistrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDirectoryRegistration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDirectoryRegistration.</param>
        /// 
        /// <returns>Returns a  CreateDirectoryRegistrationResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateDirectoryRegistration">REST API Reference for CreateDirectoryRegistration Operation</seealso>
        CreateDirectoryRegistrationResponse EndCreateDirectoryRegistration(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateServicePrincipalName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServicePrincipalName operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateServicePrincipalName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateServicePrincipalName">REST API Reference for CreateServicePrincipalName Operation</seealso>
        IAsyncResult BeginCreateServicePrincipalName(CreateServicePrincipalNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateServicePrincipalName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateServicePrincipalName.</param>
        /// 
        /// <returns>Returns a  CreateServicePrincipalNameResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateServicePrincipalName">REST API Reference for CreateServicePrincipalName Operation</seealso>
        CreateServicePrincipalNameResponse EndCreateServicePrincipalName(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        IAsyncResult BeginCreateTemplate(CreateTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTemplate.</param>
        /// 
        /// <returns>Returns a  CreateTemplateResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        CreateTemplateResponse EndCreateTemplate(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateTemplateGroupAccessControlEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateGroupAccessControlEntry operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTemplateGroupAccessControlEntry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateTemplateGroupAccessControlEntry">REST API Reference for CreateTemplateGroupAccessControlEntry Operation</seealso>
        IAsyncResult BeginCreateTemplateGroupAccessControlEntry(CreateTemplateGroupAccessControlEntryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTemplateGroupAccessControlEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTemplateGroupAccessControlEntry.</param>
        /// 
        /// <returns>Returns a  CreateTemplateGroupAccessControlEntryResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/CreateTemplateGroupAccessControlEntry">REST API Reference for CreateTemplateGroupAccessControlEntry Operation</seealso>
        CreateTemplateGroupAccessControlEntryResponse EndCreateTemplateGroupAccessControlEntry(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        IAsyncResult BeginDeleteConnector(DeleteConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnector.</param>
        /// 
        /// <returns>Returns a  DeleteConnectorResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        DeleteConnectorResponse EndDeleteConnector(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteDirectoryRegistration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectoryRegistration operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDirectoryRegistration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteDirectoryRegistration">REST API Reference for DeleteDirectoryRegistration Operation</seealso>
        IAsyncResult BeginDeleteDirectoryRegistration(DeleteDirectoryRegistrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDirectoryRegistration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDirectoryRegistration.</param>
        /// 
        /// <returns>Returns a  DeleteDirectoryRegistrationResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteDirectoryRegistration">REST API Reference for DeleteDirectoryRegistration Operation</seealso>
        DeleteDirectoryRegistrationResponse EndDeleteDirectoryRegistration(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteServicePrincipalName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServicePrincipalName operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServicePrincipalName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteServicePrincipalName">REST API Reference for DeleteServicePrincipalName Operation</seealso>
        IAsyncResult BeginDeleteServicePrincipalName(DeleteServicePrincipalNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServicePrincipalName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServicePrincipalName.</param>
        /// 
        /// <returns>Returns a  DeleteServicePrincipalNameResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteServicePrincipalName">REST API Reference for DeleteServicePrincipalName Operation</seealso>
        DeleteServicePrincipalNameResponse EndDeleteServicePrincipalName(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        IAsyncResult BeginDeleteTemplate(DeleteTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteTemplateResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        DeleteTemplateResponse EndDeleteTemplate(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteTemplateGroupAccessControlEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplateGroupAccessControlEntry operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTemplateGroupAccessControlEntry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteTemplateGroupAccessControlEntry">REST API Reference for DeleteTemplateGroupAccessControlEntry Operation</seealso>
        IAsyncResult BeginDeleteTemplateGroupAccessControlEntry(DeleteTemplateGroupAccessControlEntryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTemplateGroupAccessControlEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTemplateGroupAccessControlEntry.</param>
        /// 
        /// <returns>Returns a  DeleteTemplateGroupAccessControlEntryResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/DeleteTemplateGroupAccessControlEntry">REST API Reference for DeleteTemplateGroupAccessControlEntry Operation</seealso>
        DeleteTemplateGroupAccessControlEntryResponse EndDeleteTemplateGroupAccessControlEntry(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnector operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetConnector">REST API Reference for GetConnector Operation</seealso>
        IAsyncResult BeginGetConnector(GetConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnector.</param>
        /// 
        /// <returns>Returns a  GetConnectorResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetConnector">REST API Reference for GetConnector Operation</seealso>
        GetConnectorResponse EndGetConnector(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetDirectoryRegistration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDirectoryRegistration operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDirectoryRegistration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetDirectoryRegistration">REST API Reference for GetDirectoryRegistration Operation</seealso>
        IAsyncResult BeginGetDirectoryRegistration(GetDirectoryRegistrationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDirectoryRegistration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDirectoryRegistration.</param>
        /// 
        /// <returns>Returns a  GetDirectoryRegistrationResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetDirectoryRegistration">REST API Reference for GetDirectoryRegistration Operation</seealso>
        GetDirectoryRegistrationResponse EndGetDirectoryRegistration(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetServicePrincipalName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServicePrincipalName operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServicePrincipalName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetServicePrincipalName">REST API Reference for GetServicePrincipalName Operation</seealso>
        IAsyncResult BeginGetServicePrincipalName(GetServicePrincipalNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServicePrincipalName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServicePrincipalName.</param>
        /// 
        /// <returns>Returns a  GetServicePrincipalNameResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetServicePrincipalName">REST API Reference for GetServicePrincipalName Operation</seealso>
        GetServicePrincipalNameResponse EndGetServicePrincipalName(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        IAsyncResult BeginGetTemplate(GetTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTemplate.</param>
        /// 
        /// <returns>Returns a  GetTemplateResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        GetTemplateResponse EndGetTemplate(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetTemplateGroupAccessControlEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateGroupAccessControlEntry operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTemplateGroupAccessControlEntry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetTemplateGroupAccessControlEntry">REST API Reference for GetTemplateGroupAccessControlEntry Operation</seealso>
        IAsyncResult BeginGetTemplateGroupAccessControlEntry(GetTemplateGroupAccessControlEntryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTemplateGroupAccessControlEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTemplateGroupAccessControlEntry.</param>
        /// 
        /// <returns>Returns a  GetTemplateGroupAccessControlEntryResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/GetTemplateGroupAccessControlEntry">REST API Reference for GetTemplateGroupAccessControlEntry Operation</seealso>
        GetTemplateGroupAccessControlEntryResponse EndGetTemplateGroupAccessControlEntry(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListConnectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConnectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        IAsyncResult BeginListConnectors(ListConnectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConnectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConnectors.</param>
        /// 
        /// <returns>Returns a  ListConnectorsResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        ListConnectorsResponse EndListConnectors(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListDirectoryRegistrations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDirectoryRegistrations operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDirectoryRegistrations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListDirectoryRegistrations">REST API Reference for ListDirectoryRegistrations Operation</seealso>
        IAsyncResult BeginListDirectoryRegistrations(ListDirectoryRegistrationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDirectoryRegistrations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDirectoryRegistrations.</param>
        /// 
        /// <returns>Returns a  ListDirectoryRegistrationsResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListDirectoryRegistrations">REST API Reference for ListDirectoryRegistrations Operation</seealso>
        ListDirectoryRegistrationsResponse EndListDirectoryRegistrations(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListServicePrincipalNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServicePrincipalNames operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServicePrincipalNames
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListServicePrincipalNames">REST API Reference for ListServicePrincipalNames Operation</seealso>
        IAsyncResult BeginListServicePrincipalNames(ListServicePrincipalNamesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServicePrincipalNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServicePrincipalNames.</param>
        /// 
        /// <returns>Returns a  ListServicePrincipalNamesResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListServicePrincipalNames">REST API Reference for ListServicePrincipalNames Operation</seealso>
        ListServicePrincipalNamesResponse EndListServicePrincipalNames(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTemplateGroupAccessControlEntries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateGroupAccessControlEntries operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplateGroupAccessControlEntries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTemplateGroupAccessControlEntries">REST API Reference for ListTemplateGroupAccessControlEntries Operation</seealso>
        IAsyncResult BeginListTemplateGroupAccessControlEntries(ListTemplateGroupAccessControlEntriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplateGroupAccessControlEntries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplateGroupAccessControlEntries.</param>
        /// 
        /// <returns>Returns a  ListTemplateGroupAccessControlEntriesResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTemplateGroupAccessControlEntries">REST API Reference for ListTemplateGroupAccessControlEntries Operation</seealso>
        ListTemplateGroupAccessControlEntriesResponse EndListTemplateGroupAccessControlEntries(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        IAsyncResult BeginListTemplates(ListTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplates.</param>
        /// 
        /// <returns>Returns a  ListTemplatesResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        ListTemplatesResponse EndListTemplates(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        IAsyncResult BeginUpdateTemplate(UpdateTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateTemplateResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        UpdateTemplateResponse EndUpdateTemplate(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateTemplateGroupAccessControlEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateGroupAccessControlEntry operation on AmazonPcaConnectorAdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTemplateGroupAccessControlEntry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UpdateTemplateGroupAccessControlEntry">REST API Reference for UpdateTemplateGroupAccessControlEntry Operation</seealso>
        IAsyncResult BeginUpdateTemplateGroupAccessControlEntry(UpdateTemplateGroupAccessControlEntryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTemplateGroupAccessControlEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTemplateGroupAccessControlEntry.</param>
        /// 
        /// <returns>Returns a  UpdateTemplateGroupAccessControlEntryResult from PcaConnectorAd.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-ad-2018-05-10/UpdateTemplateGroupAccessControlEntry">REST API Reference for UpdateTemplateGroupAccessControlEntry Operation</seealso>
        UpdateTemplateGroupAccessControlEntryResponse EndUpdateTemplateGroupAccessControlEntry(IAsyncResult asyncResult);

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