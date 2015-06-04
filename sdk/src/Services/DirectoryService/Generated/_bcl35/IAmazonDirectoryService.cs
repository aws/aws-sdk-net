/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.DirectoryService.Model;

namespace Amazon.DirectoryService
{
    /// <summary>
    /// Interface for accessing DirectoryService
    ///
    /// AWS Directory Service 
    /// <para>
    /// This is the <i>AWS Directory Service API Reference</i>. This guide provides detailed
    /// information about AWS Directory Service operations, data types, parameters, and errors.
    /// </para>
    /// </summary>
    public partial interface IAmazonDirectoryService : IDisposable
    {

        
        #region  ConnectDirectory

        /// <summary>
        /// Creates an AD Connector to connect an on-premises directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConnectDirectory service method.</param>
        /// 
        /// <returns>The response from the ConnectDirectory service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryLimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// 
        /// </exception>
        ConnectDirectoryResponse ConnectDirectory(ConnectDirectoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConnectDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConnectDirectory operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConnectDirectory
        ///         operation.</returns>
        IAsyncResult BeginConnectDirectory(ConnectDirectoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConnectDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConnectDirectory.</param>
        /// 
        /// <returns>Returns a  ConnectDirectoryResult from DirectoryService.</returns>
        ConnectDirectoryResponse EndConnectDirectory(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAlias

        /// <summary>
        /// Creates an alias for a directory and assigns the alias to the directory. The alias
        /// is used to construct the access URL for the directory, such as <code>http://&#x3C;alias&#x3E;.awsapps.com</code>.
        /// 
        ///  <important> 
        /// <para>
        /// After an alias has been created, it cannot be deleted or reused, so this operation
        /// should only be used when absolutely necessary.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// 
        /// </exception>
        CreateAliasResponse CreateAlias(CreateAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAlias
        ///         operation.</returns>
        IAsyncResult BeginCreateAlias(CreateAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAlias.</param>
        /// 
        /// <returns>Returns a  CreateAliasResult from DirectoryService.</returns>
        CreateAliasResponse EndCreateAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateComputer

        /// <summary>
        /// Creates a computer account in the specified directory, and joins the computer to the
        /// directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComputer service method.</param>
        /// 
        /// <returns>The response from the CreateComputer service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AuthenticationFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryUnavailableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.UnsupportedOperationException">
        /// 
        /// </exception>
        CreateComputerResponse CreateComputer(CreateComputerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateComputer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateComputer operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateComputer
        ///         operation.</returns>
        IAsyncResult BeginCreateComputer(CreateComputerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateComputer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateComputer.</param>
        /// 
        /// <returns>Returns a  CreateComputerResult from DirectoryService.</returns>
        CreateComputerResponse EndCreateComputer(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDirectory

        /// <summary>
        /// Creates a Simple AD directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectory service method.</param>
        /// 
        /// <returns>The response from the CreateDirectory service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.DirectoryLimitExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// 
        /// </exception>
        CreateDirectoryResponse CreateDirectory(CreateDirectoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectory operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDirectory
        ///         operation.</returns>
        IAsyncResult BeginCreateDirectory(CreateDirectoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDirectory.</param>
        /// 
        /// <returns>Returns a  CreateDirectoryResult from DirectoryService.</returns>
        CreateDirectoryResponse EndCreateDirectory(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSnapshot

        /// <summary>
        /// Creates a snapshot of an existing directory.
        /// 
        ///  
        /// <para>
        /// You cannot take snapshots of extended or connected directories.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.SnapshotLimitExceededException">
        /// 
        /// </exception>
        CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshot
        ///         operation.</returns>
        IAsyncResult BeginCreateSnapshot(CreateSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateSnapshotResult from DirectoryService.</returns>
        CreateSnapshotResponse EndCreateSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDirectory

        /// <summary>
        /// Deletes an AWS Directory Service directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectory service method.</param>
        /// 
        /// <returns>The response from the DeleteDirectory service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// 
        /// </exception>
        DeleteDirectoryResponse DeleteDirectory(DeleteDirectoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDirectory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectory operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDirectory
        ///         operation.</returns>
        IAsyncResult BeginDeleteDirectory(DeleteDirectoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDirectory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDirectory.</param>
        /// 
        /// <returns>Returns a  DeleteDirectoryResult from DirectoryService.</returns>
        DeleteDirectoryResponse EndDeleteDirectory(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSnapshot

        /// <summary>
        /// Deletes a directory snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteSnapshot service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// 
        /// </exception>
        DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSnapshot
        ///         operation.</returns>
        IAsyncResult BeginDeleteSnapshot(DeleteSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteSnapshotResult from DirectoryService.</returns>
        DeleteSnapshotResponse EndDeleteSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDirectories

        /// <summary>
        /// Obtains information about the directories that belong to this account.
        /// 
        ///  
        /// <para>
        /// You can retrieve information about specific directories by passing the directory identifiers
        /// in the <i>DirectoryIds</i> parameter. Otherwise, all directories that belong to the
        /// current account are returned.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> request and
        /// response parameters. If more results are available, the <i>DescribeDirectoriesResult.NextToken</i>
        /// member contains a token that you pass in the next call to <a>DescribeDirectories</a>
        /// to retrieve the next set of items.
        /// </para>
        ///  
        /// <para>
        /// You can also specify a maximum number of return results with the <i>Limit</i> parameter.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDirectories service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// 
        /// </exception>
        DescribeDirectoriesResponse DescribeDirectories();

        /// <summary>
        /// Obtains information about the directories that belong to this account.
        /// 
        ///  
        /// <para>
        /// You can retrieve information about specific directories by passing the directory identifiers
        /// in the <i>DirectoryIds</i> parameter. Otherwise, all directories that belong to the
        /// current account are returned.
        /// </para>
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> request and
        /// response parameters. If more results are available, the <i>DescribeDirectoriesResult.NextToken</i>
        /// member contains a token that you pass in the next call to <a>DescribeDirectories</a>
        /// to retrieve the next set of items.
        /// </para>
        ///  
        /// <para>
        /// You can also specify a maximum number of return results with the <i>Limit</i> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectories service method.</param>
        /// 
        /// <returns>The response from the DescribeDirectories service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// 
        /// </exception>
        DescribeDirectoriesResponse DescribeDirectories(DescribeDirectoriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDirectories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectories operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDirectories
        ///         operation.</returns>
        IAsyncResult BeginDescribeDirectories(DescribeDirectoriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDirectories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDirectories.</param>
        /// 
        /// <returns>Returns a  DescribeDirectoriesResult from DirectoryService.</returns>
        DescribeDirectoriesResponse EndDescribeDirectories(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSnapshots

        /// <summary>
        /// Obtains information about the directory snapshots that belong to this account.
        /// 
        ///  
        /// <para>
        /// This operation supports pagination with the use of the <i>NextToken</i> request and
        /// response parameters. If more results are available, the <i>DescribeSnapshots.NextToken</i>
        /// member contains a token that you pass in the next call to <a>DescribeSnapshots</a>
        /// to retrieve the next set of items.
        /// </para>
        ///  
        /// <para>
        /// You can also specify a maximum number of return results with the <i>Limit</i> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidNextTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// 
        /// </exception>
        DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSnapshots
        ///         operation.</returns>
        IAsyncResult BeginDescribeSnapshots(DescribeSnapshotsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSnapshots.</param>
        /// 
        /// <returns>Returns a  DescribeSnapshotsResult from DirectoryService.</returns>
        DescribeSnapshotsResponse EndDescribeSnapshots(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableRadius

        /// <summary>
        /// Disables multi-factor authentication (MFA) with Remote Authentication Dial In User
        /// Service (RADIUS) for an AD Connector directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableRadius service method.</param>
        /// 
        /// <returns>The response from the DisableRadius service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// 
        /// </exception>
        DisableRadiusResponse DisableRadius(DisableRadiusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableRadius operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableRadius operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableRadius
        ///         operation.</returns>
        IAsyncResult BeginDisableRadius(DisableRadiusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableRadius operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableRadius.</param>
        /// 
        /// <returns>Returns a  DisableRadiusResult from DirectoryService.</returns>
        DisableRadiusResponse EndDisableRadius(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableSso

        /// <summary>
        /// Disables single-sign on for a directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableSso service method.</param>
        /// 
        /// <returns>The response from the DisableSso service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AuthenticationFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InsufficientPermissionsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// 
        /// </exception>
        DisableSsoResponse DisableSso(DisableSsoRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableSso operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableSso operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableSso
        ///         operation.</returns>
        IAsyncResult BeginDisableSso(DisableSsoRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableSso operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableSso.</param>
        /// 
        /// <returns>Returns a  DisableSsoResult from DirectoryService.</returns>
        DisableSsoResponse EndDisableSso(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableRadius

        /// <summary>
        /// Enables multi-factor authentication (MFA) with Remote Authentication Dial In User
        /// Service (RADIUS) for an AD Connector directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableRadius service method.</param>
        /// 
        /// <returns>The response from the EnableRadius service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityAlreadyExistsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// 
        /// </exception>
        EnableRadiusResponse EnableRadius(EnableRadiusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableRadius operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableRadius operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableRadius
        ///         operation.</returns>
        IAsyncResult BeginEnableRadius(EnableRadiusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableRadius operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableRadius.</param>
        /// 
        /// <returns>Returns a  EnableRadiusResult from DirectoryService.</returns>
        EnableRadiusResponse EndEnableRadius(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableSso

        /// <summary>
        /// Enables single-sign on for a directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableSso service method.</param>
        /// 
        /// <returns>The response from the EnableSso service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.AuthenticationFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InsufficientPermissionsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// 
        /// </exception>
        EnableSsoResponse EnableSso(EnableSsoRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableSso operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableSso operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableSso
        ///         operation.</returns>
        IAsyncResult BeginEnableSso(EnableSsoRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableSso operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableSso.</param>
        /// 
        /// <returns>Returns a  EnableSsoResult from DirectoryService.</returns>
        EnableSsoResponse EndEnableSso(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDirectoryLimits

        /// <summary>
        /// Obtains directory limit information for the current region.
        /// </summary>
        /// 
        /// <returns>The response from the GetDirectoryLimits service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// 
        /// </exception>
        GetDirectoryLimitsResponse GetDirectoryLimits();

        /// <summary>
        /// Obtains directory limit information for the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDirectoryLimits service method.</param>
        /// 
        /// <returns>The response from the GetDirectoryLimits service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// 
        /// </exception>
        GetDirectoryLimitsResponse GetDirectoryLimits(GetDirectoryLimitsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDirectoryLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDirectoryLimits operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDirectoryLimits
        ///         operation.</returns>
        IAsyncResult BeginGetDirectoryLimits(GetDirectoryLimitsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDirectoryLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDirectoryLimits.</param>
        /// 
        /// <returns>Returns a  GetDirectoryLimitsResult from DirectoryService.</returns>
        GetDirectoryLimitsResponse EndGetDirectoryLimits(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSnapshotLimits

        /// <summary>
        /// Obtains the manual snapshot limits for a directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshotLimits service method.</param>
        /// 
        /// <returns>The response from the GetSnapshotLimits service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// 
        /// </exception>
        GetSnapshotLimitsResponse GetSnapshotLimits(GetSnapshotLimitsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSnapshotLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshotLimits operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSnapshotLimits
        ///         operation.</returns>
        IAsyncResult BeginGetSnapshotLimits(GetSnapshotLimitsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSnapshotLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSnapshotLimits.</param>
        /// 
        /// <returns>Returns a  GetSnapshotLimitsResult from DirectoryService.</returns>
        GetSnapshotLimitsResponse EndGetSnapshotLimits(IAsyncResult asyncResult);

        #endregion
        
        #region  RestoreFromSnapshot

        /// <summary>
        /// Restores a directory using an existing directory snapshot.
        /// 
        ///  
        /// <para>
        /// When you restore a directory from a snapshot, any changes made to the directory after
        /// the snapshot date are overwritten.
        /// </para>
        ///  
        /// <para>
        /// This action returns as soon as the restore operation is initiated. You can monitor
        /// the progress of the restore operation by calling the <a>DescribeDirectories</a> operation
        /// with the directory identifier. When the <b>DirectoryDescription.Stage</b> value changes
        /// to <code>Active</code>, the restore operation is complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreFromSnapshot service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// 
        /// </exception>
        RestoreFromSnapshotResponse RestoreFromSnapshot(RestoreFromSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromSnapshot operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreFromSnapshot
        ///         operation.</returns>
        IAsyncResult BeginRestoreFromSnapshot(RestoreFromSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreFromSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreFromSnapshot.</param>
        /// 
        /// <returns>Returns a  RestoreFromSnapshotResult from DirectoryService.</returns>
        RestoreFromSnapshotResponse EndRestoreFromSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRadius

        /// <summary>
        /// Updates the Remote Authentication Dial In User Service (RADIUS) server information
        /// for an AD Connector directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRadius service method.</param>
        /// 
        /// <returns>The response from the UpdateRadius service method, as returned by DirectoryService.</returns>
        /// <exception cref="Amazon.DirectoryService.Model.ClientException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.EntityDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.InvalidParameterException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.DirectoryService.Model.ServiceException">
        /// 
        /// </exception>
        UpdateRadiusResponse UpdateRadius(UpdateRadiusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRadius operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRadius operation on AmazonDirectoryServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRadius
        ///         operation.</returns>
        IAsyncResult BeginUpdateRadius(UpdateRadiusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRadius operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRadius.</param>
        /// 
        /// <returns>Returns a  UpdateRadiusResult from DirectoryService.</returns>
        UpdateRadiusResponse EndUpdateRadius(IAsyncResult asyncResult);

        #endregion
        
    }
}