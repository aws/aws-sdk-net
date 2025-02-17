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
 * Do not modify this file. This file is generated from the pca-connector-scep-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PcaConnectorScep.Model;

#pragma warning disable CS1570
namespace Amazon.PcaConnectorScep
{
    /// <summary>
    /// <para>Interface for accessing PcaConnectorScep</para>
    ///
    /// Connector for SCEP creates a connector between Amazon Web Services Private CA and
    /// your SCEP-enabled clients and devices. For more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/scep-connector.htmlconnector-for-scep.html">Connector
    /// for SCEP</a> in the <i>Amazon Web Services Private CA User Guide</i>.
    /// </summary>
    public partial interface IAmazonPcaConnectorScep : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPcaConnectorScepPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateChallenge


        /// <summary>
        /// For general-purpose connectors. Creates a <i>challenge password</i> for the specified
        /// connector. The SCEP protocol uses a challenge password to authenticate a request before
        /// issuing a certificate from a certificate authority (CA). Your SCEP clients include
        /// the challenge password as part of their certificate request to Connector for SCEP.
        /// To retrieve the connector Amazon Resource Names (ARNs) for the connectors in your
        /// account, call <a href="https://docs.aws.amazon.com/C4SCEP_API/pca-connector-scep/latest/APIReference/API_ListConnectors.html">ListConnectors</a>.
        /// 
        ///  
        /// <para>
        /// To create additional challenge passwords for the connector, call <c>CreateChallenge</c>
        /// again. We recommend frequently rotating your challenge passwords.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChallenge service method.</param>
        /// 
        /// <returns>The response from the CreateChallenge service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.BadRequestException">
        /// The request is malformed or contains an error such as an invalid parameter value or
        /// a missing required parameter.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ConflictException">
        /// This request can't be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/CreateChallenge">REST API Reference for CreateChallenge Operation</seealso>
        CreateChallengeResponse CreateChallenge(CreateChallengeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChallenge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChallenge operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChallenge
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/CreateChallenge">REST API Reference for CreateChallenge Operation</seealso>
        IAsyncResult BeginCreateChallenge(CreateChallengeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChallenge operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChallenge.</param>
        /// 
        /// <returns>Returns a  CreateChallengeResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/CreateChallenge">REST API Reference for CreateChallenge Operation</seealso>
        CreateChallengeResponse EndCreateChallenge(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConnector


        /// <summary>
        /// Creates a SCEP connector. A SCEP connector links Amazon Web Services Private Certificate
        /// Authority to your SCEP-compatible devices and mobile device management (MDM) systems.
        /// Before you create a connector, you must complete a set of prerequisites, including
        /// creation of a private certificate authority (CA) to use with this connector. For more
        /// information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/scep-connector.htmlconnector-for-scep-prerequisites.html">Connector
        /// for SCEP prerequisites</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector service method.</param>
        /// 
        /// <returns>The response from the CreateConnector service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ConflictException">
        /// This request can't be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        CreateConnectorResponse CreateConnector(CreateConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnector operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        IAsyncResult BeginCreateConnector(CreateConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnector.</param>
        /// 
        /// <returns>Returns a  CreateConnectorResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/CreateConnector">REST API Reference for CreateConnector Operation</seealso>
        CreateConnectorResponse EndCreateConnector(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteChallenge


        /// <summary>
        /// Deletes the specified <a href="https://docs.aws.amazon.com/C4SCEP_API/pca-connector-scep/latest/APIReference/API_Challenge.html">Challenge</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChallenge service method.</param>
        /// 
        /// <returns>The response from the DeleteChallenge service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ConflictException">
        /// This request can't be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/DeleteChallenge">REST API Reference for DeleteChallenge Operation</seealso>
        DeleteChallengeResponse DeleteChallenge(DeleteChallengeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChallenge operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChallenge operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChallenge
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/DeleteChallenge">REST API Reference for DeleteChallenge Operation</seealso>
        IAsyncResult BeginDeleteChallenge(DeleteChallengeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChallenge operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChallenge.</param>
        /// 
        /// <returns>Returns a  DeleteChallengeResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/DeleteChallenge">REST API Reference for DeleteChallenge Operation</seealso>
        DeleteChallengeResponse EndDeleteChallenge(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConnector


        /// <summary>
        /// Deletes the specified <a href="https://docs.aws.amazon.com/C4SCEP_API/pca-connector-scep/latest/APIReference/API_Connector.html">Connector</a>.
        /// This operation also deletes any challenges associated with the connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector service method.</param>
        /// 
        /// <returns>The response from the DeleteConnector service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ConflictException">
        /// This request can't be completed for one of the following reasons because the requested
        /// resource was being concurrently modified by another request.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        DeleteConnectorResponse DeleteConnector(DeleteConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnector operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        IAsyncResult BeginDeleteConnector(DeleteConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnector.</param>
        /// 
        /// <returns>Returns a  DeleteConnectorResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/DeleteConnector">REST API Reference for DeleteConnector Operation</seealso>
        DeleteConnectorResponse EndDeleteConnector(IAsyncResult asyncResult);

        #endregion
        
        #region  GetChallengeMetadata


        /// <summary>
        /// Retrieves the metadata for the specified <a href="https://docs.aws.amazon.com/C4SCEP_API/pca-connector-scep/latest/APIReference/API_Challenge.html">Challenge</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChallengeMetadata service method.</param>
        /// 
        /// <returns>The response from the GetChallengeMetadata service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/GetChallengeMetadata">REST API Reference for GetChallengeMetadata Operation</seealso>
        GetChallengeMetadataResponse GetChallengeMetadata(GetChallengeMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetChallengeMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChallengeMetadata operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChallengeMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/GetChallengeMetadata">REST API Reference for GetChallengeMetadata Operation</seealso>
        IAsyncResult BeginGetChallengeMetadata(GetChallengeMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetChallengeMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChallengeMetadata.</param>
        /// 
        /// <returns>Returns a  GetChallengeMetadataResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/GetChallengeMetadata">REST API Reference for GetChallengeMetadata Operation</seealso>
        GetChallengeMetadataResponse EndGetChallengeMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  GetChallengePassword


        /// <summary>
        /// Retrieves the challenge password for the specified <a href="https://docs.aws.amazon.com/C4SCEP_API/pca-connector-scep/latest/APIReference/API_Challenge.html">Challenge</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChallengePassword service method.</param>
        /// 
        /// <returns>The response from the GetChallengePassword service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/GetChallengePassword">REST API Reference for GetChallengePassword Operation</seealso>
        GetChallengePasswordResponse GetChallengePassword(GetChallengePasswordRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetChallengePassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChallengePassword operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChallengePassword
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/GetChallengePassword">REST API Reference for GetChallengePassword Operation</seealso>
        IAsyncResult BeginGetChallengePassword(GetChallengePasswordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetChallengePassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChallengePassword.</param>
        /// 
        /// <returns>Returns a  GetChallengePasswordResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/GetChallengePassword">REST API Reference for GetChallengePassword Operation</seealso>
        GetChallengePasswordResponse EndGetChallengePassword(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConnector


        /// <summary>
        /// Retrieves details about the specified <a href="https://docs.aws.amazon.com/C4SCEP_API/pca-connector-scep/latest/APIReference/API_Connector.html">Connector</a>.
        /// Calling this action returns important details about the connector, such as the public
        /// SCEP URL where your clients can request certificates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnector service method.</param>
        /// 
        /// <returns>The response from the GetConnector service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/GetConnector">REST API Reference for GetConnector Operation</seealso>
        GetConnectorResponse GetConnector(GetConnectorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnector operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/GetConnector">REST API Reference for GetConnector Operation</seealso>
        IAsyncResult BeginGetConnector(GetConnectorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnector.</param>
        /// 
        /// <returns>Returns a  GetConnectorResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/GetConnector">REST API Reference for GetConnector Operation</seealso>
        GetConnectorResponse EndGetConnector(IAsyncResult asyncResult);

        #endregion
        
        #region  ListChallengeMetadata


        /// <summary>
        /// Retrieves the challenge metadata for the specified ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChallengeMetadata service method.</param>
        /// 
        /// <returns>The response from the ListChallengeMetadata service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/ListChallengeMetadata">REST API Reference for ListChallengeMetadata Operation</seealso>
        ListChallengeMetadataResponse ListChallengeMetadata(ListChallengeMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChallengeMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChallengeMetadata operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChallengeMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/ListChallengeMetadata">REST API Reference for ListChallengeMetadata Operation</seealso>
        IAsyncResult BeginListChallengeMetadata(ListChallengeMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChallengeMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChallengeMetadata.</param>
        /// 
        /// <returns>Returns a  ListChallengeMetadataResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/ListChallengeMetadata">REST API Reference for ListChallengeMetadata Operation</seealso>
        ListChallengeMetadataResponse EndListChallengeMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConnectors


        /// <summary>
        /// Lists the connectors belonging to your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors service method.</param>
        /// 
        /// <returns>The response from the ListConnectors service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        ListConnectorsResponse ListConnectors(ListConnectorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConnectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConnectors operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConnectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        IAsyncResult BeginListConnectors(ListConnectorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConnectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConnectors.</param>
        /// 
        /// <returns>Returns a  ListConnectorsResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/ListConnectors">REST API Reference for ListConnectors Operation</seealso>
        ListConnectorsResponse EndListConnectors(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves the tags associated with the specified resource. Tags are key-value pairs
        /// that you can use to categorize and manage your resources, for purposes like billing.
        /// For example, you might set the tag key to "customer" and the value to the customer
        /// name or ID. You can specify one or more tags to add to each Amazon Web Services resource,
        /// up to 50 tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds one or more tags to your resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from your resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PcaConnectorScep.</returns>
        /// <exception cref="Amazon.PcaConnectorScep.Model.AccessDeniedException">
        /// You can receive this error if you attempt to perform an operation and you don't have
        /// the required permissions. This can be caused by insufficient permissions in policies
        /// attached to your Amazon Web Services Identity and Access Management (IAM) principal.
        /// It can also happen because of restrictions in place from an Amazon Web Services Organizations
        /// service control policy (SCP) that affects your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// with an internal server.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might be incorrectly
        /// specified, or it might have a status other than <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.PcaConnectorScep.Model.ValidationException">
        /// An input validation error occurred. For example, invalid characters in a name tag,
        /// or an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonPcaConnectorScepClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from PcaConnectorScep.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pca-connector-scep-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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