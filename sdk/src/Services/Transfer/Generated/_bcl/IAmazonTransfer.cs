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

#pragma warning disable CS1570
namespace Amazon.Transfer
{
    /// <summary>
    /// <para>Interface for accessing Transfer</para>
    ///
    /// Transfer Family is a fully managed service that enables the transfer of files over
    /// the File Transfer Protocol (FTP), File Transfer Protocol over SSL (FTPS), or Secure
    /// Shell (SSH) File Transfer Protocol (SFTP) directly into and out of Amazon Simple Storage
    /// Service (Amazon S3) or Amazon EFS. Additionally, you can use Applicability Statement
    /// 2 (AS2) to transfer files into and out of Amazon S3. Amazon Web Services helps you
    /// seamlessly migrate your file transfer workflows to Transfer Family by integrating
    /// with existing authentication systems, and providing DNS routing with Amazon Route
    /// 53 so nothing changes for your customers and partners, or their applications. With
    /// your data in Amazon S3, you can use it with Amazon Web Services services for processing,
    /// analytics, machine learning, and archiving. Getting started with Transfer Family is
    /// easy since there is no infrastructure to buy and set up.
    /// </summary>
    public partial interface IAmazonTransfer : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ITransferPaginatorFactory Paginators { get; }

        
        #region  CreateAccess


        /// <summary>
        /// Used by administrators to choose which groups in the directory should have access
        /// to upload and download files over the enabled protocols using Transfer Family. For
        /// example, a Microsoft Active Directory might contain 50,000 users, but only a small
        /// fraction might need the ability to transfer files to the server. An administrator
        /// can use <c>CreateAccess</c> to limit the access to the correct set of users who need
        /// this ability.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccess service method.</param>
        /// 
        /// <returns>The response from the CreateAccess service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        CreateAccessResponse CreateAccess(CreateAccessRequest request);



        /// <summary>
        /// Used by administrators to choose which groups in the directory should have access
        /// to upload and download files over the enabled protocols using Transfer Family. For
        /// example, a Microsoft Active Directory might contain 50,000 users, but only a small
        /// fraction might need the ability to transfer files to the server. An administrator
        /// can use <c>CreateAccess</c> to limit the access to the correct set of users who need
        /// this ability.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccess service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        Task<CreateAccessResponse> CreateAccessAsync(CreateAccessRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The partner is identified with the <c>PartnerProfileId</c>, and the AS2 process is
        /// identified with the <c>LocalProfileId</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Specify <i>either</i> <c>BaseDirectory</c> or <c>CustomDirectories</c>, but not both.
        /// Specifying both causes the command to fail.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgreement service method.</param>
        /// 
        /// <returns>The response from the CreateAgreement service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        CreateAgreementResponse CreateAgreement(CreateAgreementRequest request);



        /// <summary>
        /// Creates an agreement. An agreement is a bilateral trading partner agreement, or partnership,
        /// between an Transfer Family server and an AS2 process. The agreement defines the file
        /// and message transfer relationship between the server and the AS2 process. To define
        /// an agreement, Transfer Family combines a server, local profile, partner profile, certificate,
        /// and other attributes.
        /// 
        ///  
        /// <para>
        /// The partner is identified with the <c>PartnerProfileId</c>, and the AS2 process is
        /// identified with the <c>LocalProfileId</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Specify <i>either</i> <c>BaseDirectory</c> or <c>CustomDirectories</c>, but not both.
        /// Specifying both causes the command to fail.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgreement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAgreement service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        Task<CreateAgreementResponse> CreateAgreementAsync(CreateAgreementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateConnector


        /// <summary>
        /// Creates the connector, which captures the parameters for a connection for the AS2
        /// or SFTP protocol. For AS2, the connector is required for sending files to an externally
        /// hosted AS2 server. For SFTP, the connector is required when sending files to an SFTP
        /// server or receiving files from an SFTP server. For more details about connectors,
        /// see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/configure-as2-connector.html">Configure
        /// AS2 connectors</a> and <a href="https://docs.aws.amazon.com/transfer/latest/userguide/configure-sftp-connector.html">Create
        /// SFTP connectors</a>.
        /// 
        ///  <note> 
        /// <para>
        /// You must specify exactly one configuration object: either for AS2 (<c>As2Config</c>)
        /// or SFTP (<c>SftpConfig</c>).
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector service method.</param>
        /// 
        /// <returns>The response from the CreateConnector service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        CreateConnectorResponse CreateConnector(CreateConnectorRequest request);



        /// <summary>
        /// Creates the connector, which captures the parameters for a connection for the AS2
        /// or SFTP protocol. For AS2, the connector is required for sending files to an externally
        /// hosted AS2 server. For SFTP, the connector is required when sending files to an SFTP
        /// server or receiving files from an SFTP server. For more details about connectors,
        /// see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/configure-as2-connector.html">Configure
        /// AS2 connectors</a> and <a href="https://docs.aws.amazon.com/transfer/latest/userguide/configure-sftp-connector.html">Create
        /// SFTP connectors</a>.
        /// 
        ///  <note> 
        /// <para>
        /// You must specify exactly one configuration object: either for AS2 (<c>As2Config</c>)
        /// or SFTP (<c>SftpConfig</c>).
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnector service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        Task<CreateConnectorResponse> CreateConnectorAsync(CreateConnectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateProfile


        /// <summary>
        /// Creates the local or partner profile to use for AS2 transfers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// 
        /// <returns>The response from the CreateProfile service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        CreateProfileResponse CreateProfile(CreateProfileRequest request);



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
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<CreateProfileResponse> CreateProfileAsync(CreateProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateServer


        /// <summary>
        /// Instantiates an auto-scaling virtual server based on the selected file transfer protocol
        /// in Amazon Web Services. When you make updates to your file transfer protocol-enabled
        /// server or when you work with users, use the service-generated <c>ServerId</c> property
        /// that is assigned to the newly created server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServer service method.</param>
        /// 
        /// <returns>The response from the CreateServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        CreateServerResponse CreateServer(CreateServerRequest request);



        /// <summary>
        /// Instantiates an auto-scaling virtual server based on the selected file transfer protocol
        /// in Amazon Web Services. When you make updates to your file transfer protocol-enabled
        /// server or when you work with users, use the service-generated <c>ServerId</c> property
        /// that is assigned to the newly created server.
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
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        Task<CreateServerResponse> CreateServerAsync(CreateServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateUser


        /// <summary>
        /// Creates a user and associates them with an existing file transfer protocol-enabled
        /// server. You can only create and associate users with servers that have the <c>IdentityProviderType</c>
        /// set to <c>SERVICE_MANAGED</c>. Using parameters for <c>CreateUser</c>, you can specify
        /// the user name, set the home directory, store the user's public key, and assign the
        /// user's Identity and Access Management (IAM) role. You can also optionally add a session
        /// policy, and assign metadata with tags that can be used to group and search for users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        CreateUserResponse CreateUser(CreateUserRequest request);



        /// <summary>
        /// Creates a user and associates them with an existing file transfer protocol-enabled
        /// server. You can only create and associate users with servers that have the <c>IdentityProviderType</c>
        /// set to <c>SERVICE_MANAGED</c>. Using parameters for <c>CreateUser</c>, you can specify
        /// the user name, set the home directory, store the user's public key, and assign the
        /// user's Identity and Access Management (IAM) role. You can also optionally add a session
        /// policy, and assign metadata with tags that can be used to group and search for users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWebApp


        /// <summary>
        /// Creates a web app based on specified parameters, and returns the ID for the new web
        /// app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebApp service method.</param>
        /// 
        /// <returns>The response from the CreateWebApp service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateWebApp">REST API Reference for CreateWebApp Operation</seealso>
        CreateWebAppResponse CreateWebApp(CreateWebAppRequest request);



        /// <summary>
        /// Creates a web app based on specified parameters, and returns the ID for the new web
        /// app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWebApp service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateWebApp">REST API Reference for CreateWebApp Operation</seealso>
        Task<CreateWebAppResponse> CreateWebAppAsync(CreateWebAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWorkflow


        /// <summary>
        /// Allows you to create a workflow with specified steps and step details the workflow
        /// invokes after file transfer completes. After creating a workflow, you can associate
        /// the workflow created with any transfer servers by specifying the <c>workflow-details</c>
        /// field in <c>CreateServer</c> and <c>UpdateServer</c> operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflow service method.</param>
        /// 
        /// <returns>The response from the CreateWorkflow service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        CreateWorkflowResponse CreateWorkflow(CreateWorkflowRequest request);



        /// <summary>
        /// Allows you to create a workflow with specified steps and step details the workflow
        /// invokes after file transfer completes. After creating a workflow, you can associate
        /// the workflow created with any transfer servers by specifying the <c>workflow-details</c>
        /// field in <c>CreateServer</c> and <c>UpdateServer</c> operations.
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
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        Task<CreateWorkflowResponse> CreateWorkflowAsync(CreateWorkflowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAccess


        /// <summary>
        /// Allows you to delete the access specified in the <c>ServerID</c> and <c>ExternalID</c>
        /// parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccess service method.</param>
        /// 
        /// <returns>The response from the DeleteAccess service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        DeleteAccessResponse DeleteAccess(DeleteAccessRequest request);



        /// <summary>
        /// Allows you to delete the access specified in the <c>ServerID</c> and <c>ExternalID</c>
        /// parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccess service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<DeleteAccessResponse> DeleteAccessAsync(DeleteAccessRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAgreement


        /// <summary>
        /// Delete the agreement that's specified in the provided <c>AgreementId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgreement service method.</param>
        /// 
        /// <returns>The response from the DeleteAgreement service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        DeleteAgreementResponse DeleteAgreement(DeleteAgreementRequest request);



        /// <summary>
        /// Delete the agreement that's specified in the provided <c>AgreementId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgreement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAgreement service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<DeleteAgreementResponse> DeleteAgreementAsync(DeleteAgreementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCertificate


        /// <summary>
        /// Deletes the certificate that's specified in the <c>CertificateId</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request);



        /// <summary>
        /// Deletes the certificate that's specified in the <c>CertificateId</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteConnector


        /// <summary>
        /// Deletes the connector that's specified in the provided <c>ConnectorId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector service method.</param>
        /// 
        /// <returns>The response from the DeleteConnector service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        DeleteConnectorResponse DeleteConnector(DeleteConnectorRequest request);



        /// <summary>
        /// Deletes the connector that's specified in the provided <c>ConnectorId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnector service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<DeleteConnectorResponse> DeleteConnectorAsync(DeleteConnectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteHostKey


        /// <summary>
        /// Deletes the host key that's specified in the <c>HostKeyId</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostKey service method.</param>
        /// 
        /// <returns>The response from the DeleteHostKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        DeleteHostKeyResponse DeleteHostKey(DeleteHostKeyRequest request);



        /// <summary>
        /// Deletes the host key that's specified in the <c>HostKeyId</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHostKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHostKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<DeleteHostKeyResponse> DeleteHostKeyAsync(DeleteHostKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteProfile


        /// <summary>
        /// Deletes the profile that's specified in the <c>ProfileId</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteProfile service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        DeleteProfileResponse DeleteProfile(DeleteProfileRequest request);



        /// <summary>
        /// Deletes the profile that's specified in the <c>ProfileId</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProfile service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<DeleteProfileResponse> DeleteProfileAsync(DeleteProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// <returns>The response from the DeleteServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        DeleteServerResponse DeleteServer(DeleteServerRequest request);



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
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<DeleteServerResponse> DeleteServerAsync(DeleteServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSshPublicKey


        /// <summary>
        /// Deletes a user's Secure Shell (SSH) public key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSshPublicKey service method.</param>
        /// 
        /// <returns>The response from the DeleteSshPublicKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        DeleteSshPublicKeyResponse DeleteSshPublicKey(DeleteSshPublicKeyRequest request);



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
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<DeleteSshPublicKeyResponse> DeleteSshPublicKeyAsync(DeleteSshPublicKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        DeleteUserResponse DeleteUser(DeleteUserRequest request);



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
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteWebApp


        /// <summary>
        /// Deletes the specified web app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebApp service method.</param>
        /// 
        /// <returns>The response from the DeleteWebApp service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteWebApp">REST API Reference for DeleteWebApp Operation</seealso>
        DeleteWebAppResponse DeleteWebApp(DeleteWebAppRequest request);



        /// <summary>
        /// Deletes the specified web app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWebApp service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteWebApp">REST API Reference for DeleteWebApp Operation</seealso>
        Task<DeleteWebAppResponse> DeleteWebAppAsync(DeleteWebAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteWebAppCustomization


        /// <summary>
        /// Deletes the <c>WebAppCustomization</c> object that corresponds to the web app ID specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebAppCustomization service method.</param>
        /// 
        /// <returns>The response from the DeleteWebAppCustomization service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ConflictException">
        /// This exception is thrown when the <c>UpdateServer</c> is called for a file transfer
        /// protocol-enabled server that has VPC as the endpoint type and the server's <c>VpcEndpointID</c>
        /// is not in the available state.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteWebAppCustomization">REST API Reference for DeleteWebAppCustomization Operation</seealso>
        DeleteWebAppCustomizationResponse DeleteWebAppCustomization(DeleteWebAppCustomizationRequest request);



        /// <summary>
        /// Deletes the <c>WebAppCustomization</c> object that corresponds to the web app ID specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebAppCustomization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWebAppCustomization service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ConflictException">
        /// This exception is thrown when the <c>UpdateServer</c> is called for a file transfer
        /// protocol-enabled server that has VPC as the endpoint type and the server's <c>VpcEndpointID</c>
        /// is not in the available state.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteWebAppCustomization">REST API Reference for DeleteWebAppCustomization Operation</seealso>
        Task<DeleteWebAppCustomizationResponse> DeleteWebAppCustomizationAsync(DeleteWebAppCustomizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteWorkflow


        /// <summary>
        /// Deletes the specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkflow service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        DeleteWorkflowResponse DeleteWorkflow(DeleteWorkflowRequest request);



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
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<DeleteWorkflowResponse> DeleteWorkflowAsync(DeleteWorkflowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAccess


        /// <summary>
        /// Describes the access that is assigned to the specific file transfer protocol-enabled
        /// server, as identified by its <c>ServerId</c> property and its <c>ExternalId</c>.
        /// 
        ///  
        /// <para>
        /// The response from this call returns the properties of the access that is associated
        /// with the <c>ServerId</c> value that was specified.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccess service method.</param>
        /// 
        /// <returns>The response from the DescribeAccess service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        DescribeAccessResponse DescribeAccess(DescribeAccessRequest request);



        /// <summary>
        /// Describes the access that is assigned to the specific file transfer protocol-enabled
        /// server, as identified by its <c>ServerId</c> property and its <c>ExternalId</c>.
        /// 
        ///  
        /// <para>
        /// The response from this call returns the properties of the access that is associated
        /// with the <c>ServerId</c> value that was specified.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccess service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<DescribeAccessResponse> DescribeAccessAsync(DescribeAccessRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAgreement


        /// <summary>
        /// Describes the agreement that's identified by the <c>AgreementId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgreement service method.</param>
        /// 
        /// <returns>The response from the DescribeAgreement service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        DescribeAgreementResponse DescribeAgreement(DescribeAgreementRequest request);



        /// <summary>
        /// Describes the agreement that's identified by the <c>AgreementId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgreement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAgreement service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<DescribeAgreementResponse> DescribeAgreementAsync(DescribeAgreementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCertificate


        /// <summary>
        /// Describes the certificate that's identified by the <c>CertificateId</c>.
        /// 
        ///  <note> 
        /// <para>
        /// Transfer Family automatically publishes a Amazon CloudWatch metric called <c>DaysUntilExpiry</c>
        /// for imported certificates. This metric tracks the number of days until the certificate
        /// expires based on the <c>InactiveDate</c>. The metric is available in the <c>AWS/Transfer</c>
        /// namespace and includes the <c>CertificateId</c> as a dimension.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate service method.</param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        DescribeCertificateResponse DescribeCertificate(DescribeCertificateRequest request);



        /// <summary>
        /// Describes the certificate that's identified by the <c>CertificateId</c>.
        /// 
        ///  <note> 
        /// <para>
        /// Transfer Family automatically publishes a Amazon CloudWatch metric called <c>DaysUntilExpiry</c>
        /// for imported certificates. This metric tracks the number of days until the certificate
        /// expires based on the <c>InactiveDate</c>. The metric is available in the <c>AWS/Transfer</c>
        /// namespace and includes the <c>CertificateId</c> as a dimension.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<DescribeCertificateResponse> DescribeCertificateAsync(DescribeCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConnector


        /// <summary>
        /// Describes the connector that's identified by the <c>ConnectorId.</c>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnector service method.</param>
        /// 
        /// <returns>The response from the DescribeConnector service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        DescribeConnectorResponse DescribeConnector(DescribeConnectorRequest request);



        /// <summary>
        /// Describes the connector that's identified by the <c>ConnectorId.</c>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnector service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<DescribeConnectorResponse> DescribeConnectorAsync(DescribeConnectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeExecution


        /// <summary>
        /// You can use <c>DescribeExecution</c> to check the details of the execution of the
        /// specified workflow.
        /// 
        ///  <note> 
        /// <para>
        /// This API call only returns details for in-progress workflows.
        /// </para>
        ///  
        /// <para>
        ///  If you provide an ID for an execution that is not in progress, or if the execution
        /// doesn't match the specified workflow ID, you receive a <c>ResourceNotFound</c> exception.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExecution service method.</param>
        /// 
        /// <returns>The response from the DescribeExecution service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        DescribeExecutionResponse DescribeExecution(DescribeExecutionRequest request);



        /// <summary>
        /// You can use <c>DescribeExecution</c> to check the details of the execution of the
        /// specified workflow.
        /// 
        ///  <note> 
        /// <para>
        /// This API call only returns details for in-progress workflows.
        /// </para>
        ///  
        /// <para>
        ///  If you provide an ID for an execution that is not in progress, or if the execution
        /// doesn't match the specified workflow ID, you receive a <c>ResourceNotFound</c> exception.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExecution service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<DescribeExecutionResponse> DescribeExecutionAsync(DescribeExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeHostKey


        /// <summary>
        /// Returns the details of the host key that's specified by the <c>HostKeyId</c> and <c>ServerId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostKey service method.</param>
        /// 
        /// <returns>The response from the DescribeHostKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        DescribeHostKeyResponse DescribeHostKey(DescribeHostKeyRequest request);



        /// <summary>
        /// Returns the details of the host key that's specified by the <c>HostKeyId</c> and <c>ServerId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHostKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<DescribeHostKeyResponse> DescribeHostKeyAsync(DescribeHostKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeProfile


        /// <summary>
        /// Returns the details of the profile that's specified by the <c>ProfileId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProfile service method.</param>
        /// 
        /// <returns>The response from the DescribeProfile service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        DescribeProfileResponse DescribeProfile(DescribeProfileRequest request);



        /// <summary>
        /// Returns the details of the profile that's specified by the <c>ProfileId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProfile service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<DescribeProfileResponse> DescribeProfileAsync(DescribeProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSecurityPolicy


        /// <summary>
        /// Describes the security policy that is attached to your server or SFTP connector. The
        /// response contains a description of the security policy's properties. For more information
        /// about security policies, see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/security-policies.html">Working
        /// with security policies for servers</a> or <a href="https://docs.aws.amazon.com/transfer/latest/userguide/security-policies-connectors.html">Working
        /// with security policies for SFTP connectors</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityPolicy service method.</param>
        /// 
        /// <returns>The response from the DescribeSecurityPolicy service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        DescribeSecurityPolicyResponse DescribeSecurityPolicy(DescribeSecurityPolicyRequest request);



        /// <summary>
        /// Describes the security policy that is attached to your server or SFTP connector. The
        /// response contains a description of the security policy's properties. For more information
        /// about security policies, see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/security-policies.html">Working
        /// with security policies for servers</a> or <a href="https://docs.aws.amazon.com/transfer/latest/userguide/security-policies-connectors.html">Working
        /// with security policies for SFTP connectors</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSecurityPolicy service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<DescribeSecurityPolicyResponse> DescribeSecurityPolicyAsync(DescribeSecurityPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeServer


        /// <summary>
        /// Describes a file transfer protocol-enabled server that you specify by passing the
        /// <c>ServerId</c> parameter.
        /// 
        ///  
        /// <para>
        /// The response contains a description of a server's properties. When you set <c>EndpointType</c>
        /// to VPC, the response will contain the <c>EndpointDetails</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServer service method.</param>
        /// 
        /// <returns>The response from the DescribeServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        DescribeServerResponse DescribeServer(DescribeServerRequest request);



        /// <summary>
        /// Describes a file transfer protocol-enabled server that you specify by passing the
        /// <c>ServerId</c> parameter.
        /// 
        ///  
        /// <para>
        /// The response contains a description of a server's properties. When you set <c>EndpointType</c>
        /// to VPC, the response will contain the <c>EndpointDetails</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<DescribeServerResponse> DescribeServerAsync(DescribeServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeUser


        /// <summary>
        /// Describes the user assigned to the specific file transfer protocol-enabled server,
        /// as identified by its <c>ServerId</c> property.
        /// 
        ///  
        /// <para>
        /// The response from this call returns the properties of the user associated with the
        /// <c>ServerId</c> value that was specified.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        DescribeUserResponse DescribeUser(DescribeUserRequest request);



        /// <summary>
        /// Describes the user assigned to the specific file transfer protocol-enabled server,
        /// as identified by its <c>ServerId</c> property.
        /// 
        ///  
        /// <para>
        /// The response from this call returns the properties of the user associated with the
        /// <c>ServerId</c> value that was specified.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<DescribeUserResponse> DescribeUserAsync(DescribeUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeWebApp


        /// <summary>
        /// Describes the web app that's identified by <c>WebAppId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWebApp service method.</param>
        /// 
        /// <returns>The response from the DescribeWebApp service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeWebApp">REST API Reference for DescribeWebApp Operation</seealso>
        DescribeWebAppResponse DescribeWebApp(DescribeWebAppRequest request);



        /// <summary>
        /// Describes the web app that's identified by <c>WebAppId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWebApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWebApp service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeWebApp">REST API Reference for DescribeWebApp Operation</seealso>
        Task<DescribeWebAppResponse> DescribeWebAppAsync(DescribeWebAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeWebAppCustomization


        /// <summary>
        /// Describes the web app customization object that's identified by <c>WebAppId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWebAppCustomization service method.</param>
        /// 
        /// <returns>The response from the DescribeWebAppCustomization service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeWebAppCustomization">REST API Reference for DescribeWebAppCustomization Operation</seealso>
        DescribeWebAppCustomizationResponse DescribeWebAppCustomization(DescribeWebAppCustomizationRequest request);



        /// <summary>
        /// Describes the web app customization object that's identified by <c>WebAppId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWebAppCustomization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWebAppCustomization service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeWebAppCustomization">REST API Reference for DescribeWebAppCustomization Operation</seealso>
        Task<DescribeWebAppCustomizationResponse> DescribeWebAppCustomizationAsync(DescribeWebAppCustomizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeWorkflow


        /// <summary>
        /// Describes the specified workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkflow service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkflow service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        DescribeWorkflowResponse DescribeWorkflow(DescribeWorkflowRequest request);



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
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<DescribeWorkflowResponse> DescribeWorkflowAsync(DescribeWorkflowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ImportCertificate


        /// <summary>
        /// Imports the signing and encryption certificates that you need to create local (AS2)
        /// profiles and partner profiles.
        /// 
        ///  
        /// <para>
        /// You can import both the certificate and its chain in the <c>Certificate</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// After importing a certificate, Transfer Family automatically creates a Amazon CloudWatch
        /// metric called <c>DaysUntilExpiry</c> that tracks the number of days until the certificate
        /// expires. The metric is based on the <c>InactiveDate</c> parameter and is published
        /// daily in the <c>AWS/Transfer</c> namespace.
        /// </para>
        ///  <important> 
        /// <para>
        /// It can take up to a full day after importing a certificate for Transfer Family to
        /// emit the <c>DaysUntilExpiry</c> metric to your account.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// If you use the <c>Certificate</c> parameter to upload both the certificate and its
        /// chain, don't use the <c>CertificateChain</c> parameter.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>CloudWatch monitoring</b> 
        /// </para>
        ///  
        /// <para>
        /// The <c>DaysUntilExpiry</c> metric includes the following specifications:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Units:</b> Count (days)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Dimensions:</b> <c>CertificateId</c> (always present), <c>Description</c> (if
        /// provided during certificate import)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Statistics:</b> Minimum, Maximum, Average
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Frequency:</b> Published daily
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate service method.</param>
        /// 
        /// <returns>The response from the ImportCertificate service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        ImportCertificateResponse ImportCertificate(ImportCertificateRequest request);



        /// <summary>
        /// Imports the signing and encryption certificates that you need to create local (AS2)
        /// profiles and partner profiles.
        /// 
        ///  
        /// <para>
        /// You can import both the certificate and its chain in the <c>Certificate</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// After importing a certificate, Transfer Family automatically creates a Amazon CloudWatch
        /// metric called <c>DaysUntilExpiry</c> that tracks the number of days until the certificate
        /// expires. The metric is based on the <c>InactiveDate</c> parameter and is published
        /// daily in the <c>AWS/Transfer</c> namespace.
        /// </para>
        ///  <important> 
        /// <para>
        /// It can take up to a full day after importing a certificate for Transfer Family to
        /// emit the <c>DaysUntilExpiry</c> metric to your account.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// If you use the <c>Certificate</c> parameter to upload both the certificate and its
        /// chain, don't use the <c>CertificateChain</c> parameter.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>CloudWatch monitoring</b> 
        /// </para>
        ///  
        /// <para>
        /// The <c>DaysUntilExpiry</c> metric includes the following specifications:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Units:</b> Count (days)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Dimensions:</b> <c>CertificateId</c> (always present), <c>Description</c> (if
        /// provided during certificate import)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Statistics:</b> Minimum, Maximum, Average
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Frequency:</b> Published daily
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportCertificate service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<ImportCertificateResponse> ImportCertificateAsync(ImportCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ImportHostKey


        /// <summary>
        /// Adds a host key to the server that's specified by the <c>ServerId</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportHostKey service method.</param>
        /// 
        /// <returns>The response from the ImportHostKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        ImportHostKeyResponse ImportHostKey(ImportHostKeyRequest request);



        /// <summary>
        /// Adds a host key to the server that's specified by the <c>ServerId</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportHostKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportHostKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        Task<ImportHostKeyResponse> ImportHostKeyAsync(ImportHostKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ImportSshPublicKey


        /// <summary>
        /// Adds a Secure Shell (SSH) public key to a Transfer Family user identified by a <c>UserName</c>
        /// value assigned to the specific file transfer protocol-enabled server, identified by
        /// <c>ServerId</c>.
        /// 
        ///  
        /// <para>
        /// The response returns the <c>UserName</c> value, the <c>ServerId</c> value, and the
        /// name of the <c>SshPublicKeyId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportSshPublicKey service method.</param>
        /// 
        /// <returns>The response from the ImportSshPublicKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        ImportSshPublicKeyResponse ImportSshPublicKey(ImportSshPublicKeyRequest request);



        /// <summary>
        /// Adds a Secure Shell (SSH) public key to a Transfer Family user identified by a <c>UserName</c>
        /// value assigned to the specific file transfer protocol-enabled server, identified by
        /// <c>ServerId</c>.
        /// 
        ///  
        /// <para>
        /// The response returns the <c>UserName</c> value, the <c>ServerId</c> value, and the
        /// name of the <c>SshPublicKeyId</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportSshPublicKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportSshPublicKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        Task<ImportSshPublicKeyResponse> ImportSshPublicKeyAsync(ImportSshPublicKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAccesses


        /// <summary>
        /// Lists the details for all the accesses you have on your server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccesses service method.</param>
        /// 
        /// <returns>The response from the ListAccesses service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
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
        ListAccessesResponse ListAccesses(ListAccessesRequest request);



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
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
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
        Task<ListAccessesResponse> ListAccessesAsync(ListAccessesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAgreements


        /// <summary>
        /// Returns a list of the agreements for the server that's identified by the <c>ServerId</c>
        /// that you supply. If you want to limit the results to a certain number, supply a value
        /// for the <c>MaxResults</c> parameter. If you ran the command previously and received
        /// a value for <c>NextToken</c>, you can supply that value to continue listing agreements
        /// from where you left off.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgreements service method.</param>
        /// 
        /// <returns>The response from the ListAgreements service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
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
        ListAgreementsResponse ListAgreements(ListAgreementsRequest request);



        /// <summary>
        /// Returns a list of the agreements for the server that's identified by the <c>ServerId</c>
        /// that you supply. If you want to limit the results to a certain number, supply a value
        /// for the <c>MaxResults</c> parameter. If you ran the command previously and received
        /// a value for <c>NextToken</c>, you can supply that value to continue listing agreements
        /// from where you left off.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgreements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgreements service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
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
        Task<ListAgreementsResponse> ListAgreementsAsync(ListAgreementsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCertificates


        /// <summary>
        /// Returns a list of the current certificates that have been imported into Transfer Family.
        /// If you want to limit the results to a certain number, supply a value for the <c>MaxResults</c>
        /// parameter. If you ran the command previously and received a value for the <c>NextToken</c>
        /// parameter, you can supply that value to continue listing certificates from where you
        /// left off.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates service method.</param>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
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
        ListCertificatesResponse ListCertificates(ListCertificatesRequest request);



        /// <summary>
        /// Returns a list of the current certificates that have been imported into Transfer Family.
        /// If you want to limit the results to a certain number, supply a value for the <c>MaxResults</c>
        /// parameter. If you ran the command previously and received a value for the <c>NextToken</c>
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
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
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
        Task<ListCertificatesResponse> ListCertificatesAsync(ListCertificatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListConnectors


        /// <summary>
        /// Lists the connectors for the specified Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors service method.</param>
        /// 
        /// <returns>The response from the ListConnectors service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
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
        ListConnectorsResponse ListConnectors(ListConnectorsRequest request);



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
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
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
        Task<ListConnectorsResponse> ListConnectorsAsync(ListConnectorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListExecutions


        /// <summary>
        /// Lists all in-progress executions for the specified workflow.
        /// 
        ///  <note> 
        /// <para>
        /// If the specified workflow ID cannot be found, <c>ListExecutions</c> returns a <c>ResourceNotFound</c>
        /// exception.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions service method.</param>
        /// 
        /// <returns>The response from the ListExecutions service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
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
        ListExecutionsResponse ListExecutions(ListExecutionsRequest request);



        /// <summary>
        /// Lists all in-progress executions for the specified workflow.
        /// 
        ///  <note> 
        /// <para>
        /// If the specified workflow ID cannot be found, <c>ListExecutions</c> returns a <c>ResourceNotFound</c>
        /// exception.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExecutions service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
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
        Task<ListExecutionsResponse> ListExecutionsAsync(ListExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFileTransferResults


        /// <summary>
        /// Returns real-time updates and detailed information on the status of each individual
        /// file being transferred in a specific file transfer operation. You specify the file
        /// transfer by providing its <c>ConnectorId</c> and its <c>TransferId</c>.
        /// 
        ///  <note> 
        /// <para>
        /// File transfer results are available up to 7 days after an operation has been requested.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFileTransferResults service method.</param>
        /// 
        /// <returns>The response from the ListFileTransferResults service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListFileTransferResults">REST API Reference for ListFileTransferResults Operation</seealso>
        ListFileTransferResultsResponse ListFileTransferResults(ListFileTransferResultsRequest request);



        /// <summary>
        /// Returns real-time updates and detailed information on the status of each individual
        /// file being transferred in a specific file transfer operation. You specify the file
        /// transfer by providing its <c>ConnectorId</c> and its <c>TransferId</c>.
        /// 
        ///  <note> 
        /// <para>
        /// File transfer results are available up to 7 days after an operation has been requested.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFileTransferResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFileTransferResults service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListFileTransferResults">REST API Reference for ListFileTransferResults Operation</seealso>
        Task<ListFileTransferResultsResponse> ListFileTransferResultsAsync(ListFileTransferResultsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListHostKeys


        /// <summary>
        /// Returns a list of host keys for the server that's specified by the <c>ServerId</c>
        /// parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHostKeys service method.</param>
        /// 
        /// <returns>The response from the ListHostKeys service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
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
        ListHostKeysResponse ListHostKeys(ListHostKeysRequest request);



        /// <summary>
        /// Returns a list of host keys for the server that's specified by the <c>ServerId</c>
        /// parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHostKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHostKeys service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
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
        Task<ListHostKeysResponse> ListHostKeysAsync(ListHostKeysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListProfiles


        /// <summary>
        /// Returns a list of the profiles for your system. If you want to limit the results to
        /// a certain number, supply a value for the <c>MaxResults</c> parameter. If you ran the
        /// command previously and received a value for <c>NextToken</c>, you can supply that
        /// value to continue listing profiles from where you left off.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles service method.</param>
        /// 
        /// <returns>The response from the ListProfiles service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
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
        ListProfilesResponse ListProfiles(ListProfilesRequest request);



        /// <summary>
        /// Returns a list of the profiles for your system. If you want to limit the results to
        /// a certain number, supply a value for the <c>MaxResults</c> parameter. If you ran the
        /// command previously and received a value for <c>NextToken</c>, you can supply that
        /// value to continue listing profiles from where you left off.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProfiles service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
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
        Task<ListProfilesResponse> ListProfilesAsync(ListProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSecurityPolicies


        /// <summary>
        /// Lists the security policies that are attached to your servers and SFTP connectors.
        /// For more information about security policies, see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/security-policies.html">Working
        /// with security policies for servers</a> or <a href="https://docs.aws.amazon.com/transfer/latest/userguide/security-policies-connectors.html">Working
        /// with security policies for SFTP connectors</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityPolicies service method.</param>
        /// 
        /// <returns>The response from the ListSecurityPolicies service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListSecurityPolicies">REST API Reference for ListSecurityPolicies Operation</seealso>
        ListSecurityPoliciesResponse ListSecurityPolicies(ListSecurityPoliciesRequest request);



        /// <summary>
        /// Lists the security policies that are attached to your servers and SFTP connectors.
        /// For more information about security policies, see <a href="https://docs.aws.amazon.com/transfer/latest/userguide/security-policies.html">Working
        /// with security policies for servers</a> or <a href="https://docs.aws.amazon.com/transfer/latest/userguide/security-policies-connectors.html">Working
        /// with security policies for SFTP connectors</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecurityPolicies service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListSecurityPolicies">REST API Reference for ListSecurityPolicies Operation</seealso>
        Task<ListSecurityPoliciesResponse> ListSecurityPoliciesAsync(ListSecurityPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListServers


        /// <summary>
        /// Lists the file transfer protocol-enabled servers that are associated with your Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServers service method.</param>
        /// 
        /// <returns>The response from the ListServers service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListServers">REST API Reference for ListServers Operation</seealso>
        ListServersResponse ListServers(ListServersRequest request);



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
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListServers">REST API Reference for ListServers Operation</seealso>
        Task<ListServersResponse> ListServersAsync(ListServersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all of the tags associated with the Amazon Resource Name (ARN) that you specify.
        /// The resource can be a user, server, or role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



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
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUsers


        /// <summary>
        /// Lists the users for a file transfer protocol-enabled server that you specify by passing
        /// the <c>ServerId</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
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
        ListUsersResponse ListUsers(ListUsersRequest request);



        /// <summary>
        /// Lists the users for a file transfer protocol-enabled server that you specify by passing
        /// the <c>ServerId</c> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
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
        Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWebApps


        /// <summary>
        /// Lists all web apps associated with your Amazon Web Services account for your current
        /// region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebApps service method.</param>
        /// 
        /// <returns>The response from the ListWebApps service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListWebApps">REST API Reference for ListWebApps Operation</seealso>
        ListWebAppsResponse ListWebApps(ListWebAppsRequest request);



        /// <summary>
        /// Lists all web apps associated with your Amazon Web Services account for your current
        /// region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebApps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWebApps service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListWebApps">REST API Reference for ListWebApps Operation</seealso>
        Task<ListWebAppsResponse> ListWebAppsAsync(ListWebAppsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWorkflows


        /// <summary>
        /// Lists all workflows associated with your Amazon Web Services account for your current
        /// region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// 
        /// <returns>The response from the ListWorkflows service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        ListWorkflowsResponse ListWorkflows(ListWorkflowsRequest request);



        /// <summary>
        /// Lists all workflows associated with your Amazon Web Services account for your current
        /// region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkflows service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the Amazon Web ServicesTransfer Family service is not
        /// available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        Task<ListWorkflowsResponse> ListWorkflowsAsync(ListWorkflowsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendWorkflowStepState


        /// <summary>
        /// Sends a callback for asynchronous custom steps.
        /// 
        ///  
        /// <para>
        ///  The <c>ExecutionId</c>, <c>WorkflowId</c>, and <c>Token</c> are passed to the target
        /// resource during execution of a custom step of a workflow. You must include those with
        /// their callback as well as providing a status. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendWorkflowStepState service method.</param>
        /// 
        /// <returns>The response from the SendWorkflowStepState service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        SendWorkflowStepStateResponse SendWorkflowStepState(SendWorkflowStepStateRequest request);



        /// <summary>
        /// Sends a callback for asynchronous custom steps.
        /// 
        ///  
        /// <para>
        ///  The <c>ExecutionId</c>, <c>WorkflowId</c>, and <c>Token</c> are passed to the target
        /// resource during execution of a custom step of a workflow. You must include those with
        /// their callback as well as providing a status. 
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
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<SendWorkflowStepStateResponse> SendWorkflowStepStateAsync(SendWorkflowStepStateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartDirectoryListing


        /// <summary>
        /// Retrieves a list of the contents of a directory from a remote SFTP server. You specify
        /// the connector ID, the output path, and the remote directory path. You can also specify
        /// the optional <c>MaxItems</c> value to control the maximum number of items that are
        /// listed from the remote directory. This API returns a list of all files and directories
        /// in the remote directory (up to the maximum value), but does not return files or folders
        /// in sub-directories. That is, it only returns a list of files and directories one-level
        /// deep.
        /// 
        ///  
        /// <para>
        /// After you receive the listing file, you can provide the files that you want to transfer
        /// to the <c>RetrieveFilePaths</c> parameter of the <c>StartFileTransfer</c> API call.
        /// </para>
        ///  
        /// <para>
        /// The naming convention for the output file is <c> <i>connector-ID</i>-<i>listing-ID</i>.json</c>.
        /// The output file contains the following information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>filePath</c>: the complete path of a remote file, relative to the directory of
        /// the listing request for your SFTP connector on the remote server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>modifiedTimestamp</c>: the last time the file was modified, in UTC time format.
        /// This field is optional. If the remote file attributes don't contain a timestamp, it
        /// is omitted from the file listing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>size</c>: the size of the file, in bytes. This field is optional. If the remote
        /// file attributes don't contain a file size, it is omitted from the file listing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>path</c>: the complete path of a remote directory, relative to the directory of
        /// the listing request for your SFTP connector on the remote server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>truncated</c>: a flag indicating whether the list output contains all of the items
        /// contained in the remote directory or not. If your <c>Truncated</c> output value is
        /// true, you can increase the value provided in the optional <c>max-items</c> input attribute
        /// to be able to list more items (up to the maximum allowed list size of 10,000 items).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDirectoryListing service method.</param>
        /// 
        /// <returns>The response from the StartDirectoryListing service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/StartDirectoryListing">REST API Reference for StartDirectoryListing Operation</seealso>
        StartDirectoryListingResponse StartDirectoryListing(StartDirectoryListingRequest request);



        /// <summary>
        /// Retrieves a list of the contents of a directory from a remote SFTP server. You specify
        /// the connector ID, the output path, and the remote directory path. You can also specify
        /// the optional <c>MaxItems</c> value to control the maximum number of items that are
        /// listed from the remote directory. This API returns a list of all files and directories
        /// in the remote directory (up to the maximum value), but does not return files or folders
        /// in sub-directories. That is, it only returns a list of files and directories one-level
        /// deep.
        /// 
        ///  
        /// <para>
        /// After you receive the listing file, you can provide the files that you want to transfer
        /// to the <c>RetrieveFilePaths</c> parameter of the <c>StartFileTransfer</c> API call.
        /// </para>
        ///  
        /// <para>
        /// The naming convention for the output file is <c> <i>connector-ID</i>-<i>listing-ID</i>.json</c>.
        /// The output file contains the following information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>filePath</c>: the complete path of a remote file, relative to the directory of
        /// the listing request for your SFTP connector on the remote server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>modifiedTimestamp</c>: the last time the file was modified, in UTC time format.
        /// This field is optional. If the remote file attributes don't contain a timestamp, it
        /// is omitted from the file listing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>size</c>: the size of the file, in bytes. This field is optional. If the remote
        /// file attributes don't contain a file size, it is omitted from the file listing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>path</c>: the complete path of a remote directory, relative to the directory of
        /// the listing request for your SFTP connector on the remote server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>truncated</c>: a flag indicating whether the list output contains all of the items
        /// contained in the remote directory or not. If your <c>Truncated</c> output value is
        /// true, you can increase the value provided in the optional <c>max-items</c> input attribute
        /// to be able to list more items (up to the maximum allowed list size of 10,000 items).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDirectoryListing service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDirectoryListing service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/StartDirectoryListing">REST API Reference for StartDirectoryListing Operation</seealso>
        Task<StartDirectoryListingResponse> StartDirectoryListingAsync(StartDirectoryListingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartFileTransfer


        /// <summary>
        /// Begins a file transfer between local Amazon Web Services storage and a remote AS2
        /// or SFTP server.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For an AS2 connector, you specify the <c>ConnectorId</c> and one or more <c>SendFilePaths</c>
        /// to identify the files you want to transfer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an SFTP connector, the file transfer can be either outbound or inbound. In both
        /// cases, you specify the <c>ConnectorId</c>. Depending on the direction of the transfer,
        /// you also specify the following items:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are transferring file from a partner's SFTP server to Amazon Web Services storage,
        /// you specify one or more <c>RetrieveFilePaths</c> to identify the files you want to
        /// transfer, and a <c>LocalDirectoryPath</c> to specify the destination folder.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are transferring file to a partner's SFTP server from Amazon Web Services storage,
        /// you specify one or more <c>SendFilePaths</c> to identify the files you want to transfer,
        /// and a <c>RemoteDirectoryPath</c> to specify the destination folder.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFileTransfer service method.</param>
        /// 
        /// <returns>The response from the StartFileTransfer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        StartFileTransferResponse StartFileTransfer(StartFileTransferRequest request);



        /// <summary>
        /// Begins a file transfer between local Amazon Web Services storage and a remote AS2
        /// or SFTP server.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// For an AS2 connector, you specify the <c>ConnectorId</c> and one or more <c>SendFilePaths</c>
        /// to identify the files you want to transfer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an SFTP connector, the file transfer can be either outbound or inbound. In both
        /// cases, you specify the <c>ConnectorId</c>. Depending on the direction of the transfer,
        /// you also specify the following items:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you are transferring file from a partner's SFTP server to Amazon Web Services storage,
        /// you specify one or more <c>RetrieveFilePaths</c> to identify the files you want to
        /// transfer, and a <c>LocalDirectoryPath</c> to specify the destination folder.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are transferring file to a partner's SFTP server from Amazon Web Services storage,
        /// you specify one or more <c>SendFilePaths</c> to identify the files you want to transfer,
        /// and a <c>RemoteDirectoryPath</c> to specify the destination folder.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFileTransfer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartFileTransfer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<StartFileTransferResponse> StartFileTransferAsync(StartFileTransferRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartRemoteDelete


        /// <summary>
        /// Deletes a file or directory on the remote SFTP server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRemoteDelete service method.</param>
        /// 
        /// <returns>The response from the StartRemoteDelete service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/StartRemoteDelete">REST API Reference for StartRemoteDelete Operation</seealso>
        StartRemoteDeleteResponse StartRemoteDelete(StartRemoteDeleteRequest request);



        /// <summary>
        /// Deletes a file or directory on the remote SFTP server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRemoteDelete service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartRemoteDelete service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/StartRemoteDelete">REST API Reference for StartRemoteDelete Operation</seealso>
        Task<StartRemoteDeleteResponse> StartRemoteDeleteAsync(StartRemoteDeleteRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartRemoteMove


        /// <summary>
        /// Moves or renames a file or directory on the remote SFTP server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRemoteMove service method.</param>
        /// 
        /// <returns>The response from the StartRemoteMove service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/StartRemoteMove">REST API Reference for StartRemoteMove Operation</seealso>
        StartRemoteMoveResponse StartRemoteMove(StartRemoteMoveRequest request);



        /// <summary>
        /// Moves or renames a file or directory on the remote SFTP server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRemoteMove service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartRemoteMove service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/StartRemoteMove">REST API Reference for StartRemoteMove Operation</seealso>
        Task<StartRemoteMoveResponse> StartRemoteMoveAsync(StartRemoteMoveRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartServer


        /// <summary>
        /// Changes the state of a file transfer protocol-enabled server from <c>OFFLINE</c> to
        /// <c>ONLINE</c>. It has no impact on a server that is already <c>ONLINE</c>. An <c>ONLINE</c>
        /// server can accept and process file transfer jobs.
        /// 
        ///  
        /// <para>
        /// The state of <c>STARTING</c> indicates that the server is in an intermediate state,
        /// either not fully able to respond, or not fully online. The values of <c>START_FAILED</c>
        /// can indicate an error condition.
        /// </para>
        ///  
        /// <para>
        /// No response is returned from this call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartServer service method.</param>
        /// 
        /// <returns>The response from the StartServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        StartServerResponse StartServer(StartServerRequest request);



        /// <summary>
        /// Changes the state of a file transfer protocol-enabled server from <c>OFFLINE</c> to
        /// <c>ONLINE</c>. It has no impact on a server that is already <c>ONLINE</c>. An <c>ONLINE</c>
        /// server can accept and process file transfer jobs.
        /// 
        ///  
        /// <para>
        /// The state of <c>STARTING</c> indicates that the server is in an intermediate state,
        /// either not fully able to respond, or not fully online. The values of <c>START_FAILED</c>
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
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<StartServerResponse> StartServerAsync(StartServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopServer


        /// <summary>
        /// Changes the state of a file transfer protocol-enabled server from <c>ONLINE</c> to
        /// <c>OFFLINE</c>. An <c>OFFLINE</c> server cannot accept and process file transfer jobs.
        /// Information tied to your server, such as server and user properties, are not affected
        /// by stopping your server.
        /// 
        ///  <note> 
        /// <para>
        /// Stopping the server does not reduce or impact your file transfer protocol endpoint
        /// billing; you must delete the server to stop being billed.
        /// </para>
        ///  </note> 
        /// <para>
        /// The state of <c>STOPPING</c> indicates that the server is in an intermediate state,
        /// either not fully able to respond, or not fully offline. The values of <c>STOP_FAILED</c>
        /// can indicate an error condition.
        /// </para>
        ///  
        /// <para>
        /// No response is returned from this call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopServer service method.</param>
        /// 
        /// <returns>The response from the StopServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        StopServerResponse StopServer(StopServerRequest request);



        /// <summary>
        /// Changes the state of a file transfer protocol-enabled server from <c>ONLINE</c> to
        /// <c>OFFLINE</c>. An <c>OFFLINE</c> server cannot accept and process file transfer jobs.
        /// Information tied to your server, such as server and user properties, are not affected
        /// by stopping your server.
        /// 
        ///  <note> 
        /// <para>
        /// Stopping the server does not reduce or impact your file transfer protocol endpoint
        /// billing; you must delete the server to stop being billed.
        /// </para>
        ///  </note> 
        /// <para>
        /// The state of <c>STOPPING</c> indicates that the server is in an intermediate state,
        /// either not fully able to respond, or not fully offline. The values of <c>STOP_FAILED</c>
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
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<StopServerResponse> StopServerAsync(StopServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// <returns>The response from the TagResource service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        TagResourceResponse TagResource(TagResourceRequest request);



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
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TestConnection


        /// <summary>
        /// Tests whether your SFTP connector is set up successfully. We highly recommend that
        /// you call this operation to test your ability to transfer files between local Amazon
        /// Web Services storage and a trading partner's SFTP server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestConnection service method.</param>
        /// 
        /// <returns>The response from the TestConnection service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/TestConnection">REST API Reference for TestConnection Operation</seealso>
        TestConnectionResponse TestConnection(TestConnectionRequest request);



        /// <summary>
        /// Tests whether your SFTP connector is set up successfully. We highly recommend that
        /// you call this operation to test your ability to transfer files between local Amazon
        /// Web Services storage and a trading partner's SFTP server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestConnection service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/TestConnection">REST API Reference for TestConnection Operation</seealso>
        Task<TestConnectionResponse> TestConnectionAsync(TestConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TestIdentityProvider


        /// <summary>
        /// If the <c>IdentityProviderType</c> of a file transfer protocol-enabled server is <c>AWS_DIRECTORY_SERVICE</c>
        /// or <c>API_Gateway</c>, tests whether your identity provider is set up successfully.
        /// We highly recommend that you call this operation to test your authentication method
        /// as soon as you create your server. By doing so, you can troubleshoot issues with the
        /// identity provider integration to ensure that your users can successfully use the service.
        /// 
        ///  
        /// <para>
        ///  The <c>ServerId</c> and <c>UserName</c> parameters are required. The <c>ServerProtocol</c>,
        /// <c>SourceIp</c>, and <c>UserPassword</c> are all optional. 
        /// </para>
        ///  
        /// <para>
        /// Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  You cannot use <c>TestIdentityProvider</c> if the <c>IdentityProviderType</c> of
        /// your server is <c>SERVICE_MANAGED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TestIdentityProvider</c> does not work with keys: it only accepts passwords.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TestIdentityProvider</c> can test the password operation for a custom Identity
        /// Provider that handles keys and passwords.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you provide any incorrect values for any parameters, the <c>Response</c> field
        /// is empty. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you provide a server ID for a server that uses service-managed users, you get
        /// an error: 
        /// </para>
        ///  
        /// <para>
        ///  <c> An error occurred (InvalidRequestException) when calling the TestIdentityProvider
        /// operation: s-<i>server-ID</i> not configured for external auth </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you enter a Server ID for the <c>--server-id</c> parameter that does not identify
        /// an actual Transfer server, you receive the following error: 
        /// </para>
        ///  
        /// <para>
        ///  <c>An error occurred (ResourceNotFoundException) when calling the TestIdentityProvider
        /// operation: Unknown server</c>. 
        /// </para>
        ///  
        /// <para>
        /// It is possible your sever is in a different region. You can specify a region by adding
        /// the following: <c>--region region-code</c>, such as <c>--region us-east-2</c> to specify
        /// a server in <b>US East (Ohio)</b>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestIdentityProvider service method.</param>
        /// 
        /// <returns>The response from the TestIdentityProvider service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        TestIdentityProviderResponse TestIdentityProvider(TestIdentityProviderRequest request);



        /// <summary>
        /// If the <c>IdentityProviderType</c> of a file transfer protocol-enabled server is <c>AWS_DIRECTORY_SERVICE</c>
        /// or <c>API_Gateway</c>, tests whether your identity provider is set up successfully.
        /// We highly recommend that you call this operation to test your authentication method
        /// as soon as you create your server. By doing so, you can troubleshoot issues with the
        /// identity provider integration to ensure that your users can successfully use the service.
        /// 
        ///  
        /// <para>
        ///  The <c>ServerId</c> and <c>UserName</c> parameters are required. The <c>ServerProtocol</c>,
        /// <c>SourceIp</c>, and <c>UserPassword</c> are all optional. 
        /// </para>
        ///  
        /// <para>
        /// Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  You cannot use <c>TestIdentityProvider</c> if the <c>IdentityProviderType</c> of
        /// your server is <c>SERVICE_MANAGED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TestIdentityProvider</c> does not work with keys: it only accepts passwords.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TestIdentityProvider</c> can test the password operation for a custom Identity
        /// Provider that handles keys and passwords.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you provide any incorrect values for any parameters, the <c>Response</c> field
        /// is empty. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you provide a server ID for a server that uses service-managed users, you get
        /// an error: 
        /// </para>
        ///  
        /// <para>
        ///  <c> An error occurred (InvalidRequestException) when calling the TestIdentityProvider
        /// operation: s-<i>server-ID</i> not configured for external auth </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you enter a Server ID for the <c>--server-id</c> parameter that does not identify
        /// an actual Transfer server, you receive the following error: 
        /// </para>
        ///  
        /// <para>
        ///  <c>An error occurred (ResourceNotFoundException) when calling the TestIdentityProvider
        /// operation: Unknown server</c>. 
        /// </para>
        ///  
        /// <para>
        /// It is possible your sever is in a different region. You can specify a region by adding
        /// the following: <c>--region region-code</c>, such as <c>--region us-east-2</c> to specify
        /// a server in <b>US East (Ohio)</b>.
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
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<TestIdentityProviderResponse> TestIdentityProviderAsync(TestIdentityProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        UntagResourceResponse UntagResource(UntagResourceRequest request);



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
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAccess


        /// <summary>
        /// Allows you to update parameters for the access specified in the <c>ServerID</c> and
        /// <c>ExternalID</c> parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccess service method.</param>
        /// 
        /// <returns>The response from the UpdateAccess service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        UpdateAccessResponse UpdateAccess(UpdateAccessRequest request);



        /// <summary>
        /// Allows you to update parameters for the access specified in the <c>ServerID</c> and
        /// <c>ExternalID</c> parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccess service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        Task<UpdateAccessResponse> UpdateAccessAsync(UpdateAccessRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAgreement


        /// <summary>
        /// Updates some of the parameters for an existing agreement. Provide the <c>AgreementId</c>
        /// and the <c>ServerId</c> for the agreement that you want to update, along with the
        /// new values for the parameters to update.
        /// 
        ///  <note> 
        /// <para>
        /// Specify <i>either</i> <c>BaseDirectory</c> or <c>CustomDirectories</c>, but not both.
        /// Specifying both causes the command to fail.
        /// </para>
        ///  
        /// <para>
        /// If you update an agreement from using base directory to custom directories, the base
        /// directory is no longer used. Similarly, if you change from custom directories to a
        /// base directory, the custom directories are no longer used.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgreement service method.</param>
        /// 
        /// <returns>The response from the UpdateAgreement service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        UpdateAgreementResponse UpdateAgreement(UpdateAgreementRequest request);



        /// <summary>
        /// Updates some of the parameters for an existing agreement. Provide the <c>AgreementId</c>
        /// and the <c>ServerId</c> for the agreement that you want to update, along with the
        /// new values for the parameters to update.
        /// 
        ///  <note> 
        /// <para>
        /// Specify <i>either</i> <c>BaseDirectory</c> or <c>CustomDirectories</c>, but not both.
        /// Specifying both causes the command to fail.
        /// </para>
        ///  
        /// <para>
        /// If you update an agreement from using base directory to custom directories, the base
        /// directory is no longer used. Similarly, if you change from custom directories to a
        /// base directory, the custom directories are no longer used.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgreement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgreement service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        Task<UpdateAgreementResponse> UpdateAgreementAsync(UpdateAgreementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCertificate


        /// <summary>
        /// Updates the active and inactive dates for a certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateCertificate service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        UpdateCertificateResponse UpdateCertificate(UpdateCertificateRequest request);



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
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<UpdateCertificateResponse> UpdateCertificateAsync(UpdateCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateConnector


        /// <summary>
        /// Updates some of the parameters for an existing connector. Provide the <c>ConnectorId</c>
        /// for the connector that you want to update, along with the new values for the parameters
        /// to update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnector service method.</param>
        /// 
        /// <returns>The response from the UpdateConnector service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        UpdateConnectorResponse UpdateConnector(UpdateConnectorRequest request);



        /// <summary>
        /// Updates some of the parameters for an existing connector. Provide the <c>ConnectorId</c>
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
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        Task<UpdateConnectorResponse> UpdateConnectorAsync(UpdateConnectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateHostKey


        /// <summary>
        /// Updates the description for the host key that's specified by the <c>ServerId</c> and
        /// <c>HostKeyId</c> parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostKey service method.</param>
        /// 
        /// <returns>The response from the UpdateHostKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        UpdateHostKeyResponse UpdateHostKey(UpdateHostKeyRequest request);



        /// <summary>
        /// Updates the description for the host key that's specified by the <c>ServerId</c> and
        /// <c>HostKeyId</c> parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHostKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateHostKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<UpdateHostKeyResponse> UpdateHostKeyAsync(UpdateHostKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateProfile


        /// <summary>
        /// Updates some of the parameters for an existing profile. Provide the <c>ProfileId</c>
        /// for the profile that you want to update, along with the new values for the parameters
        /// to update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateProfile service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        UpdateProfileResponse UpdateProfile(UpdateProfileRequest request);



        /// <summary>
        /// Updates some of the parameters for an existing profile. Provide the <c>ProfileId</c>
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
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<UpdateProfileResponse> UpdateProfileAsync(UpdateProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateServer


        /// <summary>
        /// Updates the file transfer protocol-enabled server's properties after that server has
        /// been created.
        /// 
        ///  
        /// <para>
        /// The <c>UpdateServer</c> call returns the <c>ServerId</c> of the server you updated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServer service method.</param>
        /// 
        /// <returns>The response from the UpdateServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ConflictException">
        /// This exception is thrown when the <c>UpdateServer</c> is called for a file transfer
        /// protocol-enabled server that has VPC as the endpoint type and the server's <c>VpcEndpointID</c>
        /// is not in the available state.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        UpdateServerResponse UpdateServer(UpdateServerRequest request);



        /// <summary>
        /// Updates the file transfer protocol-enabled server's properties after that server has
        /// been created.
        /// 
        ///  
        /// <para>
        /// The <c>UpdateServer</c> call returns the <c>ServerId</c> of the server you updated.
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
        /// This exception is thrown when the <c>UpdateServer</c> is called for a file transfer
        /// protocol-enabled server that has VPC as the endpoint type and the server's <c>VpcEndpointID</c>
        /// is not in the available state.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist, or exists in a region other than the one specified
        /// for the command.
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
        Task<UpdateServerResponse> UpdateServerAsync(UpdateServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateUser


        /// <summary>
        /// Assigns new properties to a user. Parameters you pass modify any or all of the following:
        /// the home directory, role, and policy for the <c>UserName</c> and <c>ServerId</c> you
        /// specify.
        /// 
        ///  
        /// <para>
        /// The response returns the <c>ServerId</c> and the <c>UserName</c> for the updated user.
        /// </para>
        ///  
        /// <para>
        /// In the console, you can select <i>Restricted</i> when you create or update a user.
        /// This ensures that the user can't access anything outside of their home directory.
        /// The programmatic way to configure this behavior is to update the user. Set their <c>HomeDirectoryType</c>
        /// to <c>LOGICAL</c>, and specify <c>HomeDirectoryMappings</c> with <c>Entry</c> as root
        /// (<c>/</c>) and <c>Target</c> as their home directory.
        /// </para>
        ///  
        /// <para>
        /// For example, if the user's home directory is <c>/test/admin-user</c>, the following
        /// command updates the user so that their configuration in the console shows the <i>Restricted</i>
        /// flag as selected.
        /// </para>
        ///  
        /// <para>
        ///  <c> aws transfer update-user --server-id &lt;server-id&gt; --user-name admin-user
        /// --home-directory-type LOGICAL --home-directory-mappings "[{\"Entry\":\"/\", \"Target\":\"/test/admin-user\"}]"</c>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        UpdateUserResponse UpdateUser(UpdateUserRequest request);



        /// <summary>
        /// Assigns new properties to a user. Parameters you pass modify any or all of the following:
        /// the home directory, role, and policy for the <c>UserName</c> and <c>ServerId</c> you
        /// specify.
        /// 
        ///  
        /// <para>
        /// The response returns the <c>ServerId</c> and the <c>UserName</c> for the updated user.
        /// </para>
        ///  
        /// <para>
        /// In the console, you can select <i>Restricted</i> when you create or update a user.
        /// This ensures that the user can't access anything outside of their home directory.
        /// The programmatic way to configure this behavior is to update the user. Set their <c>HomeDirectoryType</c>
        /// to <c>LOGICAL</c>, and specify <c>HomeDirectoryMappings</c> with <c>Entry</c> as root
        /// (<c>/</c>) and <c>Target</c> as their home directory.
        /// </para>
        ///  
        /// <para>
        /// For example, if the user's home directory is <c>/test/admin-user</c>, the following
        /// command updates the user so that their configuration in the console shows the <i>Restricted</i>
        /// flag as selected.
        /// </para>
        ///  
        /// <para>
        ///  <c> aws transfer update-user --server-id &lt;server-id&gt; --user-name admin-user
        /// --home-directory-type LOGICAL --home-directory-mappings "[{\"Entry\":\"/\", \"Target\":\"/test/admin-user\"}]"</c>
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
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
        Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateWebApp


        /// <summary>
        /// Assigns new properties to a web app. You can modify the access point, identity provider
        /// details, and the web app units.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebApp service method.</param>
        /// 
        /// <returns>The response from the UpdateWebApp service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ConflictException">
        /// This exception is thrown when the <c>UpdateServer</c> is called for a file transfer
        /// protocol-enabled server that has VPC as the endpoint type and the server's <c>VpcEndpointID</c>
        /// is not in the available state.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateWebApp">REST API Reference for UpdateWebApp Operation</seealso>
        UpdateWebAppResponse UpdateWebApp(UpdateWebAppRequest request);



        /// <summary>
        /// Assigns new properties to a web app. You can modify the access point, identity provider
        /// details, and the web app units.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWebApp service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ConflictException">
        /// This exception is thrown when the <c>UpdateServer</c> is called for a file transfer
        /// protocol-enabled server that has VPC as the endpoint type and the server's <c>VpcEndpointID</c>
        /// is not in the available state.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateWebApp">REST API Reference for UpdateWebApp Operation</seealso>
        Task<UpdateWebAppResponse> UpdateWebAppAsync(UpdateWebAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateWebAppCustomization


        /// <summary>
        /// Assigns new customization properties to a web app. You can modify the icon file, logo
        /// file, and title.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebAppCustomization service method.</param>
        /// 
        /// <returns>The response from the UpdateWebAppCustomization service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ConflictException">
        /// This exception is thrown when the <c>UpdateServer</c> is called for a file transfer
        /// protocol-enabled server that has VPC as the endpoint type and the server's <c>VpcEndpointID</c>
        /// is not in the available state.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateWebAppCustomization">REST API Reference for UpdateWebAppCustomization Operation</seealso>
        UpdateWebAppCustomizationResponse UpdateWebAppCustomization(UpdateWebAppCustomizationRequest request);



        /// <summary>
        /// Assigns new customization properties to a web app. You can modify the icon file, logo
        /// file, and title.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebAppCustomization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWebAppCustomization service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ConflictException">
        /// This exception is thrown when the <c>UpdateServer</c> is called for a file transfer
        /// protocol-enabled server that has VPC as the endpoint type and the server's <c>VpcEndpointID</c>
        /// is not in the available state.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the Transfer Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the Amazon Web ServicesTransfer
        /// Family service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateWebAppCustomization">REST API Reference for UpdateWebAppCustomization Operation</seealso>
        Task<UpdateWebAppCustomizationResponse> UpdateWebAppCustomizationAsync(UpdateWebAppCustomizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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