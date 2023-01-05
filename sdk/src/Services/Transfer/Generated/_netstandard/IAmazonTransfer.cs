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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Transfer.Model;

namespace Amazon.Transfer
{
    /// <summary>
    /// Interface for accessing Transfer
    ///
    /// Transfer Family is a fully managed service that enables the transfer of files over
    /// the File Transfer Protocol (FTP), File Transfer Protocol over SSL (FTPS), or Secure
    /// Shell (SSH) File Transfer Protocol (SFTP) directly into and out of Amazon Simple Storage
    /// Service (Amazon S3) or Amazon EFS. Additionally, you can use Applicability Statement
    /// 2 (AS2) to transfer files into and out of Amazon S3. Amazon Web Services helps you
    /// seamlessly migrate your file transfer workflows to Transfer Family by integrating
    /// with existing authentication systems, and providing DNS routing with Amazon Route
    /// 53 so nothing changes for your customers and partners, or their applications. With
    /// your data in Amazon S3, you can use it with Amazon Web Services for processing, analytics,
    /// machine learning, and archiving. Getting started with Transfer Family is easy since
    /// there is no infrastructure to buy and set up.
    /// </summary>
    public partial interface IAmazonTransfer : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ITransferPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateAccess



        /// <summary>
        /// Used by administrators to choose which groups in the directory should have access
        /// to upload and download files over the enabled protocols using Transfer Family. For
        /// example, a Microsoft Active Directory might contain 50,000 users, but only a small
        /// fraction might need the ability to transfer files to the server. An administrator
        /// can use <code>CreateAccess</code> to limit the access to the correct set of users
        /// who need this ability.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccess service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateAccess">REST API Reference for CreateAccess Operation</seealso>
        Task<CreateAccessResponse> CreateAccessAsync(CreateAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAgreement



        /// <summary>
        /// Creates an agreement. An agreement is a bilateral trading partner agreement, or partnership,
        /// between an Transfer Family server and an AS2 process. The agreement defines the file
        /// and message transfer relationship between the server and the AS2 process. To define
        /// an agreement, Transfer Family combines a server, local profile, partner profile, certificate,
        /// and other attributes.
        /// 
        ///  
        /// <para>
        /// The partner is identified with the <code>PartnerProfileId</code>, and the AS2 process
        /// is identified with the <code>LocalProfileId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgreement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAgreement service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateAgreement">REST API Reference for CreateAgreement Operation</seealso>
        Task<CreateAgreementResponse> CreateAgreementAsync(CreateAgreementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateConnector



        /// <summary>
        /// Creates the connector, which captures the parameters for an outbound connection for
        /// the AS2 protocol. The connector is required for sending files to an externally hosted
        /// AS2 server. For more details about connectors, see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/create-b2b-server.html#configure-as2-connector">Create
        /// AS2 connectors</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnector service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        Task<CreateConnectorResponse> CreateConnectorAsync(CreateConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProfile



        /// <summary>
        /// Creates the local or partner profile to use for AS2 transfers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProfile service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        Task<CreateProfileResponse> CreateProfileAsync(CreateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateServer



        /// <summary>
        /// Instantiates an auto-scaling virtual server based on the selected file transfer protocol
        /// in Amazon Web Services. When you make updates to your file transfer protocol-enabled
        /// server or when you work with users, use the service-generated <code>ServerId</code>
        /// property that is assigned to the newly created server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateServer">REST API Reference for CreateServer Operation</seealso>
        Task<CreateServerResponse> CreateServerAsync(CreateServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUser



        /// <summary>
        /// Creates a user and associates them with an existing file transfer protocol-enabled
        /// server. You can only create and associate users with servers that have the <code>IdentityProviderType</code>
        /// set to <code>SERVICE_MANAGED</code>. Using parameters for <code>CreateUser</code>,
        /// you can specify the user name, set the home directory, store the user's public key,
        /// and assign the user's Identity and Access Management (IAM) role. You can also optionally
        /// add a session policy, and assign metadata with tags that can be used to group and
        /// search for users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateUser">REST API Reference for CreateUser Operation</seealso>
        Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWorkflow



        /// <summary>
        /// Allows you to create a workflow with specified steps and step details the workflow
        /// invokes after file transfer completes. After creating a workflow, you can associate
        /// the workflow created with any transfer servers by specifying the <code>workflow-details</code>
        /// field in <code>CreateServer</code> and <code>UpdateServer</code> operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkflow service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        Task<CreateWorkflowResponse> CreateWorkflowAsync(CreateWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAccess



        /// <summary>
        /// Allows you to delete the access specified in the <code>ServerID</code> and <code>ExternalID</code>
        /// parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccess service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteAccess">REST API Reference for DeleteAccess Operation</seealso>
        Task<DeleteAccessResponse> DeleteAccessAsync(DeleteAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAgreement



        /// <summary>
        /// Delete the agreement that's specified in the provided <code>AgreementId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgreement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAgreement service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteAgreement">REST API Reference for DeleteAgreement Operation</seealso>
        Task<DeleteAgreementResponse> DeleteAgreementAsync(DeleteAgreementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCertificate



        /// <summary>
        /// Deletes the certificate that's specified in the <code>CertificateId</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteConnector



        /// <summary>
        /// Deletes the agreement that's specified in the provided <code>ConnectorId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnector service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        Task<DeleteConnectorResponse> DeleteConnectorAsync(DeleteConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteHostKey



        /// <summary>
        /// Deletes the host key that's specified in the <code>HoskKeyId</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHostKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteHostKey">REST API Reference for DeleteHostKey Operation</seealso>
        Task<DeleteHostKeyResponse> DeleteHostKeyAsync(DeleteHostKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProfile



        /// <summary>
        /// Deletes the profile that's specified in the <code>ProfileId</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProfile service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        Task<DeleteProfileResponse> DeleteProfileAsync(DeleteProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteServer



        /// <summary>
        /// Deletes the file transfer protocol-enabled server that you specify.
        /// 
        ///  
        /// <para>
        /// No response returns from this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteServer">REST API Reference for DeleteServer Operation</seealso>
        Task<DeleteServerResponse> DeleteServerAsync(DeleteServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSshPublicKey



        /// <summary>
        /// Deletes a user's Secure Shell (SSH) public key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSshPublicKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSshPublicKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteSshPublicKey">REST API Reference for DeleteSshPublicKey Operation</seealso>
        Task<DeleteSshPublicKeyResponse> DeleteSshPublicKeyAsync(DeleteSshPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUser



        /// <summary>
        /// Deletes the user belonging to a file transfer protocol-enabled server you specify.
        /// 
        ///  
        /// <para>
        /// No response returns from this operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you delete a user from a server, the user's information is lost.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWorkflow



        /// <summary>
        /// Deletes the specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkflow service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        Task<DeleteWorkflowResponse> DeleteWorkflowAsync(DeleteWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAccess



        /// <summary>
        /// Describes the access that is assigned to the specific file transfer protocol-enabled
        /// server, as identified by its <code>ServerId</code> property and its <code>ExternalId</code>.
        /// 
        ///  
        /// <para>
        /// The response from this call returns the properties of the access that is associated
        /// with the <code>ServerId</code> value that was specified.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccess service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeAccess">REST API Reference for DescribeAccess Operation</seealso>
        Task<DescribeAccessResponse> DescribeAccessAsync(DescribeAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAgreement



        /// <summary>
        /// Describes the agreement that's identified by the <code>AgreementId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgreement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAgreement service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeAgreement">REST API Reference for DescribeAgreement Operation</seealso>
        Task<DescribeAgreementResponse> DescribeAgreementAsync(DescribeAgreementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCertificate



        /// <summary>
        /// Describes the certificate that's identified by the <code>CertificateId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        Task<DescribeCertificateResponse> DescribeCertificateAsync(DescribeCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeConnector



        /// <summary>
        /// Describes the connector that's identified by the <code>ConnectorId.</code>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnector service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeConnector">REST API Reference for DescribeConnector Operation</seealso>
        Task<DescribeConnectorResponse> DescribeConnectorAsync(DescribeConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeExecution



        /// <summary>
        /// You can use <code>DescribeExecution</code> to check the details of the execution of
        /// the specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExecution service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        Task<DescribeExecutionResponse> DescribeExecutionAsync(DescribeExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeHostKey



        /// <summary>
        /// Returns the details of the host key that's specified by the <code>HostKeyId</code>
        /// and <code>ServerId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHostKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeHostKey">REST API Reference for DescribeHostKey Operation</seealso>
        Task<DescribeHostKeyResponse> DescribeHostKeyAsync(DescribeHostKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeProfile



        /// <summary>
        /// Returns the details of the profile that's specified by the <code>ProfileId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProfile service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeProfile">REST API Reference for DescribeProfile Operation</seealso>
        Task<DescribeProfileResponse> DescribeProfileAsync(DescribeProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSecurityPolicy



        /// <summary>
        /// Describes the security policy that is attached to your file transfer protocol-enabled
        /// server. The response contains a description of the security policy's properties. For
        /// more information about security policies, see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/security-policies.html">Working
        /// with security policies</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSecurityPolicy service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeSecurityPolicy">REST API Reference for DescribeSecurityPolicy Operation</seealso>
        Task<DescribeSecurityPolicyResponse> DescribeSecurityPolicyAsync(DescribeSecurityPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeServer



        /// <summary>
        /// Describes a file transfer protocol-enabled server that you specify by passing the
        /// <code>ServerId</code> parameter.
        /// 
        ///  
        /// <para>
        /// The response contains a description of a server's properties. When you set <code>EndpointType</code>
        /// to VPC, the response will contain the <code>EndpointDetails</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeServer">REST API Reference for DescribeServer Operation</seealso>
        Task<DescribeServerResponse> DescribeServerAsync(DescribeServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeUser



        /// <summary>
        /// Describes the user assigned to the specific file transfer protocol-enabled server,
        /// as identified by its <code>ServerId</code> property.
        /// 
        ///  
        /// <para>
        /// The response from this call returns the properties of the user associated with the
        /// <code>ServerId</code> value that was specified.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        Task<DescribeUserResponse> DescribeUserAsync(DescribeUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkflow



        /// <summary>
        /// Describes the specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkflow service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeWorkflow">REST API Reference for DescribeWorkflow Operation</seealso>
        Task<DescribeWorkflowResponse> DescribeWorkflowAsync(DescribeWorkflowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportCertificate



        /// <summary>
        /// Imports the signing and encryption certificates that you need to create local (AS2)
        /// profiles and partner profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportCertificate service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ImportCertificate">REST API Reference for ImportCertificate Operation</seealso>
        Task<ImportCertificateResponse> ImportCertificateAsync(ImportCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportHostKey



        /// <summary>
        /// Adds a host key to the server that's specified by the <code>ServerId</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportHostKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportHostKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ImportHostKey">REST API Reference for ImportHostKey Operation</seealso>
        Task<ImportHostKeyResponse> ImportHostKeyAsync(ImportHostKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportSshPublicKey



        /// <summary>
        /// Adds a Secure Shell (SSH) public key to a user account identified by a <code>UserName</code>
        /// value assigned to the specific file transfer protocol-enabled server, identified by
        /// <code>ServerId</code>.
        /// 
        ///  
        /// <para>
        /// The response returns the <code>UserName</code> value, the <code>ServerId</code> value,
        /// and the name of the <code>SshPublicKeyId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportSshPublicKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportSshPublicKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ImportSshPublicKey">REST API Reference for ImportSshPublicKey Operation</seealso>
        Task<ImportSshPublicKeyResponse> ImportSshPublicKeyAsync(ImportSshPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccesses



        /// <summary>
        /// Lists the details for all the accesses you have on your server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccesses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccesses service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListAccesses">REST API Reference for ListAccesses Operation</seealso>
        Task<ListAccessesResponse> ListAccessesAsync(ListAccessesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAgreements



        /// <summary>
        /// Returns a list of the agreements for the server that's identified by the <code>ServerId</code>
        /// that you supply. If you want to limit the results to a certain number, supply a value
        /// for the <code>MaxResults</code> parameter. If you ran the command previously and received
        /// a value for <code>NextToken</code>, you can supply that value to continue listing
        /// agreements from where you left off.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgreements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgreements service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListAgreements">REST API Reference for ListAgreements Operation</seealso>
        Task<ListAgreementsResponse> ListAgreementsAsync(ListAgreementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCertificates



        /// <summary>
        /// Returns a list of the current certificates that have been imported into Transfer Family.
        /// If you want to limit the results to a certain number, supply a value for the <code>MaxResults</code>
        /// parameter. If you ran the command previously and received a value for the <code>NextToken</code>
        /// parameter, you can supply that value to continue listing certificates from where you
        /// left off.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        Task<ListCertificatesResponse> ListCertificatesAsync(ListCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListConnectors



        /// <summary>
        /// Lists the connectors for the specified Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnectors service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        Task<ListConnectorsResponse> ListConnectorsAsync(ListConnectorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListExecutions



        /// <summary>
        /// Lists all executions for the specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExecutions service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        Task<ListExecutionsResponse> ListExecutionsAsync(ListExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHostKeys



        /// <summary>
        /// Returns a list of host keys for the server that's specified by the <code>ServerId</code>
        /// parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHostKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHostKeys service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListHostKeys">REST API Reference for ListHostKeys Operation</seealso>
        Task<ListHostKeysResponse> ListHostKeysAsync(ListHostKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProfiles



        /// <summary>
        /// Returns a list of the profiles for your system. If you want to limit the results to
        /// a certain number, supply a value for the <code>MaxResults</code> parameter. If you
        /// ran the command previously and received a value for <code>NextToken</code>, you can
        /// supply that value to continue listing profiles from where you left off.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProfiles service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        Task<ListProfilesResponse> ListProfilesAsync(ListProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSecurityPolicies



        /// <summary>
        /// Lists the security policies that are attached to your file transfer protocol-enabled
        /// servers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecurityPolicies service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListSecurityPolicies">REST API Reference for ListSecurityPolicies Operation</seealso>
        Task<ListSecurityPoliciesResponse> ListSecurityPoliciesAsync(ListSecurityPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListServers



        /// <summary>
        /// Lists the file transfer protocol-enabled servers that are associated with your Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServers service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListServers">REST API Reference for ListServers Operation</seealso>
        Task<ListServersResponse> ListServersAsync(ListServersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <returns>The response from the ListTagsForResource service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUsers



        /// <summary>
        /// Lists the users for a file transfer protocol-enabled server that you specify by passing
        /// the <code>ServerId</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListUsers">REST API Reference for ListUsers Operation</seealso>
        Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWorkflows



        /// <summary>
        /// Lists all of your workflows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkflows service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        Task<ListWorkflowsResponse> ListWorkflowsAsync(ListWorkflowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendWorkflowStepState



        /// <summary>
        /// Sends a callback for asynchronous custom steps.
        /// 
        ///  
        /// <para>
        ///  The <code>ExecutionId</code>, <code>WorkflowId</code>, and <code>Token</code> are
        /// passed to the target resource during execution of a custom step of a workflow. You
        /// must include those with their callback as well as providing a status. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendWorkflowStepState service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendWorkflowStepState service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/SendWorkflowStepState">REST API Reference for SendWorkflowStepState Operation</seealso>
        Task<SendWorkflowStepStateResponse> SendWorkflowStepStateAsync(SendWorkflowStepStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartFileTransfer



        /// <summary>
        /// Begins an outbound file transfer to a remote AS2 server. You specify the <code>ConnectorId</code>
        /// and the file paths for where to send the files.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFileTransfer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartFileTransfer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/StartFileTransfer">REST API Reference for StartFileTransfer Operation</seealso>
        Task<StartFileTransferResponse> StartFileTransferAsync(StartFileTransferRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartServer



        /// <summary>
        /// Changes the state of a file transfer protocol-enabled server from <code>OFFLINE</code>
        /// to <code>ONLINE</code>. It has no impact on a server that is already <code>ONLINE</code>.
        /// An <code>ONLINE</code> server can accept and process file transfer jobs.
        /// 
        ///  
        /// <para>
        /// The state of <code>STARTING</code> indicates that the server is in an intermediate
        /// state, either not fully able to respond, or not fully online. The values of <code>START_FAILED</code>
        /// can indicate an error condition.
        /// </para>
        ///  
        /// <para>
        /// No response is returned from this call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/StartServer">REST API Reference for StartServer Operation</seealso>
        Task<StartServerResponse> StartServerAsync(StartServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopServer



        /// <summary>
        /// Changes the state of a file transfer protocol-enabled server from <code>ONLINE</code>
        /// to <code>OFFLINE</code>. An <code>OFFLINE</code> server cannot accept and process
        /// file transfer jobs. Information tied to your server, such as server and user properties,
        /// are not affected by stopping your server.
        /// 
        ///  <note> 
        /// <para>
        /// Stopping the server does not reduce or impact your file transfer protocol endpoint
        /// billing; you must delete the server to stop being billed.
        /// </para>
        ///  </note> 
        /// <para>
        /// The state of <code>STOPPING</code> indicates that the server is in an intermediate
        /// state, either not fully able to respond, or not fully offline. The values of <code>STOP_FAILED</code>
        /// can indicate an error condition.
        /// </para>
        ///  
        /// <para>
        /// No response is returned from this call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/StopServer">REST API Reference for StopServer Operation</seealso>
        Task<StopServerResponse> StopServerAsync(StopServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Attaches a key-value pair to a resource, as identified by its Amazon Resource Name
        /// (ARN). Resources are users, servers, roles, and other entities.
        /// 
        ///  
        /// <para>
        /// There is no response returned from this call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TestIdentityProvider



        /// <summary>
        /// If the <code>IdentityProviderType</code> of a file transfer protocol-enabled server
        /// is <code>AWS_DIRECTORY_SERVICE</code> or <code>API_Gateway</code>, tests whether your
        /// identity provider is set up successfully. We highly recommend that you call this operation
        /// to test your authentication method as soon as you create your server. By doing so,
        /// you can troubleshoot issues with the identity provider integration to ensure that
        /// your users can successfully use the service.
        /// 
        ///  
        /// <para>
        ///  The <code>ServerId</code> and <code>UserName</code> parameters are required. The
        /// <code>ServerProtocol</code>, <code>SourceIp</code>, and <code>UserPassword</code>
        /// are all optional. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  You cannot use <code>TestIdentityProvider</code> if the <code>IdentityProviderType</code>
        /// of your server is <code>SERVICE_MANAGED</code>. 
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  If you provide any incorrect values for any parameters, the <code>Response</code>
        /// field is empty. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you provide a server ID for a server that uses service-managed users, you get
        /// an error: 
        /// </para>
        ///  
        /// <para>
        ///  <code> An error occurred (InvalidRequestException) when calling the TestIdentityProvider
        /// operation: s-<i>server-ID</i> not configured for external auth </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you enter a Server ID for the <code>--server-id</code> parameter that does not
        /// identify an actual Transfer server, you receive the following error: 
        /// </para>
        ///  
        /// <para>
        ///  <code>An error occurred (ResourceNotFoundException) when calling the TestIdentityProvider
        /// operation: Unknown server</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestIdentityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestIdentityProvider service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/TestIdentityProvider">REST API Reference for TestIdentityProvider Operation</seealso>
        Task<TestIdentityProviderResponse> TestIdentityProviderAsync(TestIdentityProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Detaches a key-value pair from a resource, as identified by its Amazon Resource Name
        /// (ARN). Resources are users, servers, roles, and other entities.
        /// 
        ///  
        /// <para>
        /// No response is returned from this call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAccess



        /// <summary>
        /// Allows you to update parameters for the access specified in the <code>ServerID</code>
        /// and <code>ExternalID</code> parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccess service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateAccess">REST API Reference for UpdateAccess Operation</seealso>
        Task<UpdateAccessResponse> UpdateAccessAsync(UpdateAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAgreement



        /// <summary>
        /// Updates some of the parameters for an existing agreement. Provide the <code>AgreementId</code>
        /// and the <code>ServerId</code> for the agreement that you want to update, along with
        /// the new values for the parameters to update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgreement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgreement service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateAgreement">REST API Reference for UpdateAgreement Operation</seealso>
        Task<UpdateAgreementResponse> UpdateAgreementAsync(UpdateAgreementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCertificate



        /// <summary>
        /// Updates the active and inactive dates for a certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCertificate service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateCertificate">REST API Reference for UpdateCertificate Operation</seealso>
        Task<UpdateCertificateResponse> UpdateCertificateAsync(UpdateCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateConnector



        /// <summary>
        /// Updates some of the parameters for an existing connector. Provide the <code>ConnectorId</code>
        /// for the connector that you want to update, along with the new values for the parameters
        /// to update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConnector service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateConnector">REST API Reference for UpdateConnector Operation</seealso>
        Task<UpdateConnectorResponse> UpdateConnectorAsync(UpdateConnectorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateHostKey



        /// <summary>
        /// Updates the description for the host key that's specified by the <code>ServerId</code>
        /// and <code>HostKeyId</code> parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateHostKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateHostKey">REST API Reference for UpdateHostKey Operation</seealso>
        Task<UpdateHostKeyResponse> UpdateHostKeyAsync(UpdateHostKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateProfile



        /// <summary>
        /// Updates some of the parameters for an existing profile. Provide the <code>ProfileId</code>
        /// for the profile that you want to update, along with the new values for the parameters
        /// to update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProfile service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        Task<UpdateProfileResponse> UpdateProfileAsync(UpdateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateServer



        /// <summary>
        /// Updates the file transfer protocol-enabled server's properties after that server has
        /// been created.
        /// 
        ///  
        /// <para>
        /// The <code>UpdateServer</code> call returns the <code>ServerId</code> of the server
        /// you updated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ConflictException">
        /// This exception is thrown when the <code>UpdateServer</code> is called for a file transfer
        /// protocol-enabled server that has VPC as the endpoint type and the server's <code>VpcEndpointID</code>
        /// is not in the available state.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateServer">REST API Reference for UpdateServer Operation</seealso>
        Task<UpdateServerResponse> UpdateServerAsync(UpdateServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUser



        /// <summary>
        /// Assigns new properties to a user. Parameters you pass modify any or all of the following:
        /// the home directory, role, and policy for the <code>UserName</code> and <code>ServerId</code>
        /// you specify.
        /// 
        ///  
        /// <para>
        /// The response returns the <code>ServerId</code> and the <code>UserName</code> for the
        /// updated user.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Amazon Web ServicesTransfer Family
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}