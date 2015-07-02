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
using System.Threading;
using System.Threading.Tasks;
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
        /// <param name="request">Container for the necessary parameters to execute the ConnectDirectory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ConnectDirectoryResponse> ConnectDirectoryAsync(ConnectDirectoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the CreateComputer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateComputerResponse> CreateComputerAsync(CreateComputerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateDirectoryResponse> CreateDirectoryAsync(CreateDirectoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDirectoryResponse> DeleteDirectoryAsync(DeleteDirectoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeDirectoriesResponse> DescribeDirectoriesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDirectories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDirectoriesResponse> DescribeDirectoriesAsync(DescribeDirectoriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the DisableRadius operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisableRadiusResponse> DisableRadiusAsync(DisableRadiusRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the DisableSso operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisableSsoResponse> DisableSsoAsync(DisableSsoRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the EnableRadius operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<EnableRadiusResponse> EnableRadiusAsync(EnableRadiusRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the EnableSso operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<EnableSsoResponse> EnableSsoAsync(EnableSsoRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Obtains directory limit information for the current region.
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDirectoryLimitsResponse> GetDirectoryLimitsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the GetDirectoryLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDirectoryLimits operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetDirectoryLimitsResponse> GetDirectoryLimitsAsync(GetDirectoryLimitsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshotLimits operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetSnapshotLimitsResponse> GetSnapshotLimitsAsync(GetSnapshotLimitsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RestoreFromSnapshotResponse> RestoreFromSnapshotAsync(RestoreFromSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateRadius operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateRadiusResponse> UpdateRadiusAsync(UpdateRadiusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}