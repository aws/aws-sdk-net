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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DataSync.Model;

#pragma warning disable CS1570
namespace Amazon.DataSync
{
    /// <summary>
    /// <para>Interface for accessing DataSync</para>
    ///
    /// DataSync 
    /// <para>
    /// DataSync is an online data movement and discovery service that simplifies data migration
    /// and helps you quickly, easily, and securely transfer your file or object data to,
    /// from, and between Amazon Web Services storage services.
    /// </para>
    ///  
    /// <para>
    /// This API interface reference includes documentation for using DataSync programmatically.
    /// For complete information, see the <i> <a href="https://docs.aws.amazon.com/datasync/latest/userguide/what-is-datasync.html">DataSync
    /// User Guide</a> </i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonDataSync : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IDataSyncPaginatorFactory Paginators { get; }

        
        #region  AddStorageSystem


        /// <summary>
        /// Creates an Amazon Web Services resource for an on-premises storage system that you
        /// want DataSync Discovery to collect information about.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddStorageSystem service method.</param>
        /// 
        /// <returns>The response from the AddStorageSystem service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/AddStorageSystem">REST API Reference for AddStorageSystem Operation</seealso>
        AddStorageSystemResponse AddStorageSystem(AddStorageSystemRequest request);



        /// <summary>
        /// Creates an Amazon Web Services resource for an on-premises storage system that you
        /// want DataSync Discovery to collect information about.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddStorageSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddStorageSystem service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/AddStorageSystem">REST API Reference for AddStorageSystem Operation</seealso>
        Task<AddStorageSystemResponse> AddStorageSystemAsync(AddStorageSystemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelTaskExecution


        /// <summary>
        /// Stops an DataSync task execution that's in progress. The transfer of some files are
        /// abruptly interrupted. File contents that're transferred to the destination might be
        /// incomplete or inconsistent with the source files.
        /// 
        ///  
        /// <para>
        /// However, if you start a new task execution using the same task and allow it to finish,
        /// file content on the destination will be complete and consistent. This applies to other
        /// unexpected failures that interrupt a task execution. In all of these cases, DataSync
        /// successfully completes the transfer when you start the next task execution.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelTaskExecution service method.</param>
        /// 
        /// <returns>The response from the CancelTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CancelTaskExecution">REST API Reference for CancelTaskExecution Operation</seealso>
        CancelTaskExecutionResponse CancelTaskExecution(CancelTaskExecutionRequest request);



        /// <summary>
        /// Stops an DataSync task execution that's in progress. The transfer of some files are
        /// abruptly interrupted. File contents that're transferred to the destination might be
        /// incomplete or inconsistent with the source files.
        /// 
        ///  
        /// <para>
        /// However, if you start a new task execution using the same task and allow it to finish,
        /// file content on the destination will be complete and consistent. This applies to other
        /// unexpected failures that interrupt a task execution. In all of these cases, DataSync
        /// successfully completes the transfer when you start the next task execution.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelTaskExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CancelTaskExecution">REST API Reference for CancelTaskExecution Operation</seealso>
        Task<CancelTaskExecutionResponse> CancelTaskExecutionAsync(CancelTaskExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAgent


        /// <summary>
        /// Activates an DataSync agent that you deploy in your storage environment. The activation
        /// process associates the agent with your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// If you haven't deployed an agent yet, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/do-i-need-datasync-agent.html">Do
        /// I need a DataSync agent?</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgent service method.</param>
        /// 
        /// <returns>The response from the CreateAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateAgent">REST API Reference for CreateAgent Operation</seealso>
        CreateAgentResponse CreateAgent(CreateAgentRequest request);



        /// <summary>
        /// Activates an DataSync agent that you deploy in your storage environment. The activation
        /// process associates the agent with your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// If you haven't deployed an agent yet, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/do-i-need-datasync-agent.html">Do
        /// I need a DataSync agent?</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateAgent">REST API Reference for CreateAgent Operation</seealso>
        Task<CreateAgentResponse> CreateAgentAsync(CreateAgentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLocationAzureBlob


        /// <summary>
        /// Creates a transfer <i>location</i> for a Microsoft Azure Blob Storage container. DataSync
        /// can use this location as a transfer source or destination.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure you know <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#azure-blob-access">how
        /// DataSync accesses Azure Blob Storage</a> and works with <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#azure-blob-access-tiers">access
        /// tiers</a> and <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#blob-types">blob
        /// types</a>. You also need a <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#azure-blob-creating-agent">DataSync
        /// agent</a> that can connect to your container.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationAzureBlob service method.</param>
        /// 
        /// <returns>The response from the CreateLocationAzureBlob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationAzureBlob">REST API Reference for CreateLocationAzureBlob Operation</seealso>
        CreateLocationAzureBlobResponse CreateLocationAzureBlob(CreateLocationAzureBlobRequest request);



        /// <summary>
        /// Creates a transfer <i>location</i> for a Microsoft Azure Blob Storage container. DataSync
        /// can use this location as a transfer source or destination.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure you know <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#azure-blob-access">how
        /// DataSync accesses Azure Blob Storage</a> and works with <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#azure-blob-access-tiers">access
        /// tiers</a> and <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#blob-types">blob
        /// types</a>. You also need a <a href="https://docs.aws.amazon.com/datasync/latest/userguide/creating-azure-blob-location.html#azure-blob-creating-agent">DataSync
        /// agent</a> that can connect to your container.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationAzureBlob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationAzureBlob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationAzureBlob">REST API Reference for CreateLocationAzureBlob Operation</seealso>
        Task<CreateLocationAzureBlobResponse> CreateLocationAzureBlobAsync(CreateLocationAzureBlobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLocationEfs


        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon EFS file system. DataSync can use
        /// this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-efs-location.html#create-efs-location-access">accesses
        /// Amazon EFS file systems</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationEfs service method.</param>
        /// 
        /// <returns>The response from the CreateLocationEfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationEfs">REST API Reference for CreateLocationEfs Operation</seealso>
        CreateLocationEfsResponse CreateLocationEfs(CreateLocationEfsRequest request);



        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon EFS file system. DataSync can use
        /// this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-efs-location.html#create-efs-location-access">accesses
        /// Amazon EFS file systems</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationEfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationEfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationEfs">REST API Reference for CreateLocationEfs Operation</seealso>
        Task<CreateLocationEfsResponse> CreateLocationEfsAsync(CreateLocationEfsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLocationFsxLustre


        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon FSx for Lustre file system. DataSync
        /// can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-lustre-location.html#create-lustre-location-access">accesses
        /// FSx for Lustre file systems</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxLustre service method.</param>
        /// 
        /// <returns>The response from the CreateLocationFsxLustre service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxLustre">REST API Reference for CreateLocationFsxLustre Operation</seealso>
        CreateLocationFsxLustreResponse CreateLocationFsxLustre(CreateLocationFsxLustreRequest request);



        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon FSx for Lustre file system. DataSync
        /// can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-lustre-location.html#create-lustre-location-access">accesses
        /// FSx for Lustre file systems</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxLustre service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationFsxLustre service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxLustre">REST API Reference for CreateLocationFsxLustre Operation</seealso>
        Task<CreateLocationFsxLustreResponse> CreateLocationFsxLustreAsync(CreateLocationFsxLustreRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLocationFsxOntap


        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon FSx for NetApp ONTAP file system.
        /// DataSync can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-ontap-location.html#create-ontap-location-access">accesses
        /// FSx for ONTAP file systems</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxOntap service method.</param>
        /// 
        /// <returns>The response from the CreateLocationFsxOntap service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxOntap">REST API Reference for CreateLocationFsxOntap Operation</seealso>
        CreateLocationFsxOntapResponse CreateLocationFsxOntap(CreateLocationFsxOntapRequest request);



        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon FSx for NetApp ONTAP file system.
        /// DataSync can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-ontap-location.html#create-ontap-location-access">accesses
        /// FSx for ONTAP file systems</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxOntap service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationFsxOntap service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxOntap">REST API Reference for CreateLocationFsxOntap Operation</seealso>
        Task<CreateLocationFsxOntapResponse> CreateLocationFsxOntapAsync(CreateLocationFsxOntapRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLocationFsxOpenZfs


        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon FSx for OpenZFS file system. DataSync
        /// can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-openzfs-location.html#create-openzfs-access">accesses
        /// FSx for OpenZFS file systems</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Request parameters related to <c>SMB</c> aren't supported with the <c>CreateLocationFsxOpenZfs</c>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxOpenZfs service method.</param>
        /// 
        /// <returns>The response from the CreateLocationFsxOpenZfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxOpenZfs">REST API Reference for CreateLocationFsxOpenZfs Operation</seealso>
        CreateLocationFsxOpenZfsResponse CreateLocationFsxOpenZfs(CreateLocationFsxOpenZfsRequest request);



        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon FSx for OpenZFS file system. DataSync
        /// can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-openzfs-location.html#create-openzfs-access">accesses
        /// FSx for OpenZFS file systems</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Request parameters related to <c>SMB</c> aren't supported with the <c>CreateLocationFsxOpenZfs</c>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxOpenZfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationFsxOpenZfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxOpenZfs">REST API Reference for CreateLocationFsxOpenZfs Operation</seealso>
        Task<CreateLocationFsxOpenZfsResponse> CreateLocationFsxOpenZfsAsync(CreateLocationFsxOpenZfsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLocationFsxWindows


        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon FSx for Windows File Server file
        /// system. DataSync can use this location as a source or destination for transferring
        /// data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-fsx-location.html#create-fsx-location-access">accesses
        /// FSx for Windows File Server file systems</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxWindows service method.</param>
        /// 
        /// <returns>The response from the CreateLocationFsxWindows service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxWindows">REST API Reference for CreateLocationFsxWindows Operation</seealso>
        CreateLocationFsxWindowsResponse CreateLocationFsxWindows(CreateLocationFsxWindowsRequest request);



        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon FSx for Windows File Server file
        /// system. DataSync can use this location as a source or destination for transferring
        /// data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-fsx-location.html#create-fsx-location-access">accesses
        /// FSx for Windows File Server file systems</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxWindows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationFsxWindows service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxWindows">REST API Reference for CreateLocationFsxWindows Operation</seealso>
        Task<CreateLocationFsxWindowsResponse> CreateLocationFsxWindowsAsync(CreateLocationFsxWindowsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLocationHdfs


        /// <summary>
        /// Creates a transfer <i>location</i> for a Hadoop Distributed File System (HDFS). DataSync
        /// can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-hdfs-location.html#accessing-hdfs">accesses
        /// HDFS clusters</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationHdfs service method.</param>
        /// 
        /// <returns>The response from the CreateLocationHdfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationHdfs">REST API Reference for CreateLocationHdfs Operation</seealso>
        CreateLocationHdfsResponse CreateLocationHdfs(CreateLocationHdfsRequest request);



        /// <summary>
        /// Creates a transfer <i>location</i> for a Hadoop Distributed File System (HDFS). DataSync
        /// can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-hdfs-location.html#accessing-hdfs">accesses
        /// HDFS clusters</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationHdfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationHdfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationHdfs">REST API Reference for CreateLocationHdfs Operation</seealso>
        Task<CreateLocationHdfsResponse> CreateLocationHdfsAsync(CreateLocationHdfsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLocationNfs


        /// <summary>
        /// Creates a transfer <i>location</i> for a Network File System (NFS) file server. DataSync
        /// can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-nfs-location.html#accessing-nfs">accesses
        /// NFS file servers</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're copying data to or from an Snowcone device, you can also use <c>CreateLocationNfs</c>
        /// to create your transfer location. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/nfs-on-snowcone.html">Configuring
        /// transfers with Snowcone</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationNfs service method.</param>
        /// 
        /// <returns>The response from the CreateLocationNfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationNfs">REST API Reference for CreateLocationNfs Operation</seealso>
        CreateLocationNfsResponse CreateLocationNfs(CreateLocationNfsRequest request);



        /// <summary>
        /// Creates a transfer <i>location</i> for a Network File System (NFS) file server. DataSync
        /// can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-nfs-location.html#accessing-nfs">accesses
        /// NFS file servers</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're copying data to or from an Snowcone device, you can also use <c>CreateLocationNfs</c>
        /// to create your transfer location. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/nfs-on-snowcone.html">Configuring
        /// transfers with Snowcone</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationNfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationNfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationNfs">REST API Reference for CreateLocationNfs Operation</seealso>
        Task<CreateLocationNfsResponse> CreateLocationNfsAsync(CreateLocationNfsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLocationObjectStorage


        /// <summary>
        /// Creates a transfer <i>location</i> for an object storage system. DataSync can use
        /// this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-object-location.html#create-object-location-prerequisites">prerequisites</a>
        /// for DataSync to work with object storage systems.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationObjectStorage service method.</param>
        /// 
        /// <returns>The response from the CreateLocationObjectStorage service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationObjectStorage">REST API Reference for CreateLocationObjectStorage Operation</seealso>
        CreateLocationObjectStorageResponse CreateLocationObjectStorage(CreateLocationObjectStorageRequest request);



        /// <summary>
        /// Creates a transfer <i>location</i> for an object storage system. DataSync can use
        /// this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-object-location.html#create-object-location-prerequisites">prerequisites</a>
        /// for DataSync to work with object storage systems.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationObjectStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationObjectStorage service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationObjectStorage">REST API Reference for CreateLocationObjectStorage Operation</seealso>
        Task<CreateLocationObjectStorageResponse> CreateLocationObjectStorageAsync(CreateLocationObjectStorageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLocationS3


        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon S3 bucket. DataSync can use this
        /// location as a source or destination for transferring data.
        /// 
        ///  <important> 
        /// <para>
        /// Before you begin, make sure that you read the following topics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#using-storage-classes">Storage
        /// class considerations with Amazon S3 locations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#create-s3-location-s3-requests">Evaluating
        /// S3 request costs when using DataSync</a> 
        /// </para>
        ///  </li> </ul> </important> 
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html">Configuring
        /// transfers with Amazon S3</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationS3 service method.</param>
        /// 
        /// <returns>The response from the CreateLocationS3 service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationS3">REST API Reference for CreateLocationS3 Operation</seealso>
        CreateLocationS3Response CreateLocationS3(CreateLocationS3Request request);



        /// <summary>
        /// Creates a transfer <i>location</i> for an Amazon S3 bucket. DataSync can use this
        /// location as a source or destination for transferring data.
        /// 
        ///  <important> 
        /// <para>
        /// Before you begin, make sure that you read the following topics:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#using-storage-classes">Storage
        /// class considerations with Amazon S3 locations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#create-s3-location-s3-requests">Evaluating
        /// S3 request costs when using DataSync</a> 
        /// </para>
        ///  </li> </ul> </important> 
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html">Configuring
        /// transfers with Amazon S3</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationS3 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationS3 service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationS3">REST API Reference for CreateLocationS3 Operation</seealso>
        Task<CreateLocationS3Response> CreateLocationS3Async(CreateLocationS3Request request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLocationSmb


        /// <summary>
        /// Creates a transfer <i>location</i> for a Server Message Block (SMB) file server. DataSync
        /// can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-smb-location.html#configuring-smb">accesses
        /// SMB file servers</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationSmb service method.</param>
        /// 
        /// <returns>The response from the CreateLocationSmb service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationSmb">REST API Reference for CreateLocationSmb Operation</seealso>
        CreateLocationSmbResponse CreateLocationSmb(CreateLocationSmbRequest request);



        /// <summary>
        /// Creates a transfer <i>location</i> for a Server Message Block (SMB) file server. DataSync
        /// can use this location as a source or destination for transferring data.
        /// 
        ///  
        /// <para>
        /// Before you begin, make sure that you understand how DataSync <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-smb-location.html#configuring-smb">accesses
        /// SMB file servers</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationSmb service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLocationSmb service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationSmb">REST API Reference for CreateLocationSmb Operation</seealso>
        Task<CreateLocationSmbResponse> CreateLocationSmbAsync(CreateLocationSmbRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTask


        /// <summary>
        /// Configures a <i>task</i>, which defines where and how DataSync transfers your data.
        /// 
        ///  
        /// <para>
        /// A task includes a source location, destination location, and transfer options (such
        /// as bandwidth limits, scheduling, and more).
        /// </para>
        ///  <important> 
        /// <para>
        /// If you're planning to transfer data to or from an Amazon S3 location, review <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#create-s3-location-s3-requests">how
        /// DataSync can affect your S3 request charges</a> and the <a href="http://aws.amazon.com/datasync/pricing/">DataSync
        /// pricing page</a> before you begin.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTask service method.</param>
        /// 
        /// <returns>The response from the CreateTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateTask">REST API Reference for CreateTask Operation</seealso>
        CreateTaskResponse CreateTask(CreateTaskRequest request);



        /// <summary>
        /// Configures a <i>task</i>, which defines where and how DataSync transfers your data.
        /// 
        ///  
        /// <para>
        /// A task includes a source location, destination location, and transfer options (such
        /// as bandwidth limits, scheduling, and more).
        /// </para>
        ///  <important> 
        /// <para>
        /// If you're planning to transfer data to or from an Amazon S3 location, review <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#create-s3-location-s3-requests">how
        /// DataSync can affect your S3 request charges</a> and the <a href="http://aws.amazon.com/datasync/pricing/">DataSync
        /// pricing page</a> before you begin.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateTask">REST API Reference for CreateTask Operation</seealso>
        Task<CreateTaskResponse> CreateTaskAsync(CreateTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAgent


        /// <summary>
        /// Removes an DataSync agent resource from your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// Keep in mind that this operation (which can't be undone) doesn't remove the agent's
        /// virtual machine (VM) or Amazon EC2 instance from your storage environment. For next
        /// steps, you can delete the VM or instance from your storage environment or reuse it
        /// to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/activate-agent.html">activate
        /// a new agent</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgent service method.</param>
        /// 
        /// <returns>The response from the DeleteAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteAgent">REST API Reference for DeleteAgent Operation</seealso>
        DeleteAgentResponse DeleteAgent(DeleteAgentRequest request);



        /// <summary>
        /// Removes an DataSync agent resource from your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// Keep in mind that this operation (which can't be undone) doesn't remove the agent's
        /// virtual machine (VM) or Amazon EC2 instance from your storage environment. For next
        /// steps, you can delete the VM or instance from your storage environment or reuse it
        /// to <a href="https://docs.aws.amazon.com/datasync/latest/userguide/activate-agent.html">activate
        /// a new agent</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteAgent">REST API Reference for DeleteAgent Operation</seealso>
        Task<DeleteAgentResponse> DeleteAgentAsync(DeleteAgentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLocation


        /// <summary>
        /// Deletes a transfer location resource from DataSync.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLocation service method.</param>
        /// 
        /// <returns>The response from the DeleteLocation service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteLocation">REST API Reference for DeleteLocation Operation</seealso>
        DeleteLocationResponse DeleteLocation(DeleteLocationRequest request);



        /// <summary>
        /// Deletes a transfer location resource from DataSync.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLocation service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteLocation">REST API Reference for DeleteLocation Operation</seealso>
        Task<DeleteLocationResponse> DeleteLocationAsync(DeleteLocationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTask


        /// <summary>
        /// Deletes a transfer task resource from DataSync.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTask service method.</param>
        /// 
        /// <returns>The response from the DeleteTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteTask">REST API Reference for DeleteTask Operation</seealso>
        DeleteTaskResponse DeleteTask(DeleteTaskRequest request);



        /// <summary>
        /// Deletes a transfer task resource from DataSync.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteTask">REST API Reference for DeleteTask Operation</seealso>
        Task<DeleteTaskResponse> DeleteTaskAsync(DeleteTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAgent


        /// <summary>
        /// Returns information about an DataSync agent, such as its name, service endpoint type,
        /// and status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgent service method.</param>
        /// 
        /// <returns>The response from the DescribeAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeAgent">REST API Reference for DescribeAgent Operation</seealso>
        DescribeAgentResponse DescribeAgent(DescribeAgentRequest request);



        /// <summary>
        /// Returns information about an DataSync agent, such as its name, service endpoint type,
        /// and status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeAgent">REST API Reference for DescribeAgent Operation</seealso>
        Task<DescribeAgentResponse> DescribeAgentAsync(DescribeAgentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDiscoveryJob


        /// <summary>
        /// Returns information about a DataSync discovery job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDiscoveryJob service method.</param>
        /// 
        /// <returns>The response from the DescribeDiscoveryJob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeDiscoveryJob">REST API Reference for DescribeDiscoveryJob Operation</seealso>
        DescribeDiscoveryJobResponse DescribeDiscoveryJob(DescribeDiscoveryJobRequest request);



        /// <summary>
        /// Returns information about a DataSync discovery job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDiscoveryJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDiscoveryJob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeDiscoveryJob">REST API Reference for DescribeDiscoveryJob Operation</seealso>
        Task<DescribeDiscoveryJobResponse> DescribeDiscoveryJobAsync(DescribeDiscoveryJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLocationAzureBlob


        /// <summary>
        /// Provides details about how an DataSync transfer location for Microsoft Azure Blob
        /// Storage is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationAzureBlob service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationAzureBlob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationAzureBlob">REST API Reference for DescribeLocationAzureBlob Operation</seealso>
        DescribeLocationAzureBlobResponse DescribeLocationAzureBlob(DescribeLocationAzureBlobRequest request);



        /// <summary>
        /// Provides details about how an DataSync transfer location for Microsoft Azure Blob
        /// Storage is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationAzureBlob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationAzureBlob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationAzureBlob">REST API Reference for DescribeLocationAzureBlob Operation</seealso>
        Task<DescribeLocationAzureBlobResponse> DescribeLocationAzureBlobAsync(DescribeLocationAzureBlobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLocationEfs


        /// <summary>
        /// Provides details about how an DataSync transfer location for an Amazon EFS file system
        /// is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationEfs service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationEfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationEfs">REST API Reference for DescribeLocationEfs Operation</seealso>
        DescribeLocationEfsResponse DescribeLocationEfs(DescribeLocationEfsRequest request);



        /// <summary>
        /// Provides details about how an DataSync transfer location for an Amazon EFS file system
        /// is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationEfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationEfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationEfs">REST API Reference for DescribeLocationEfs Operation</seealso>
        Task<DescribeLocationEfsResponse> DescribeLocationEfsAsync(DescribeLocationEfsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLocationFsxLustre


        /// <summary>
        /// Provides details about how an DataSync transfer location for an Amazon FSx for Lustre
        /// file system is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxLustre service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationFsxLustre service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxLustre">REST API Reference for DescribeLocationFsxLustre Operation</seealso>
        DescribeLocationFsxLustreResponse DescribeLocationFsxLustre(DescribeLocationFsxLustreRequest request);



        /// <summary>
        /// Provides details about how an DataSync transfer location for an Amazon FSx for Lustre
        /// file system is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxLustre service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationFsxLustre service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxLustre">REST API Reference for DescribeLocationFsxLustre Operation</seealso>
        Task<DescribeLocationFsxLustreResponse> DescribeLocationFsxLustreAsync(DescribeLocationFsxLustreRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLocationFsxOntap


        /// <summary>
        /// Provides details about how an DataSync transfer location for an Amazon FSx for NetApp
        /// ONTAP file system is configured.
        /// 
        ///  <note> 
        /// <para>
        /// If your location uses SMB, the <c>DescribeLocationFsxOntap</c> operation doesn't actually
        /// return a <c>Password</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxOntap service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationFsxOntap service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxOntap">REST API Reference for DescribeLocationFsxOntap Operation</seealso>
        DescribeLocationFsxOntapResponse DescribeLocationFsxOntap(DescribeLocationFsxOntapRequest request);



        /// <summary>
        /// Provides details about how an DataSync transfer location for an Amazon FSx for NetApp
        /// ONTAP file system is configured.
        /// 
        ///  <note> 
        /// <para>
        /// If your location uses SMB, the <c>DescribeLocationFsxOntap</c> operation doesn't actually
        /// return a <c>Password</c>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxOntap service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationFsxOntap service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxOntap">REST API Reference for DescribeLocationFsxOntap Operation</seealso>
        Task<DescribeLocationFsxOntapResponse> DescribeLocationFsxOntapAsync(DescribeLocationFsxOntapRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLocationFsxOpenZfs


        /// <summary>
        /// Provides details about how an DataSync transfer location for an Amazon FSx for OpenZFS
        /// file system is configured.
        /// 
        ///  <note> 
        /// <para>
        /// Response elements related to <c>SMB</c> aren't supported with the <c>DescribeLocationFsxOpenZfs</c>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxOpenZfs service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationFsxOpenZfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxOpenZfs">REST API Reference for DescribeLocationFsxOpenZfs Operation</seealso>
        DescribeLocationFsxOpenZfsResponse DescribeLocationFsxOpenZfs(DescribeLocationFsxOpenZfsRequest request);



        /// <summary>
        /// Provides details about how an DataSync transfer location for an Amazon FSx for OpenZFS
        /// file system is configured.
        /// 
        ///  <note> 
        /// <para>
        /// Response elements related to <c>SMB</c> aren't supported with the <c>DescribeLocationFsxOpenZfs</c>
        /// operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxOpenZfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationFsxOpenZfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxOpenZfs">REST API Reference for DescribeLocationFsxOpenZfs Operation</seealso>
        Task<DescribeLocationFsxOpenZfsResponse> DescribeLocationFsxOpenZfsAsync(DescribeLocationFsxOpenZfsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLocationFsxWindows


        /// <summary>
        /// Provides details about how an DataSync transfer location for an Amazon FSx for Windows
        /// File Server file system is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxWindows service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationFsxWindows service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxWindows">REST API Reference for DescribeLocationFsxWindows Operation</seealso>
        DescribeLocationFsxWindowsResponse DescribeLocationFsxWindows(DescribeLocationFsxWindowsRequest request);



        /// <summary>
        /// Provides details about how an DataSync transfer location for an Amazon FSx for Windows
        /// File Server file system is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxWindows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationFsxWindows service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxWindows">REST API Reference for DescribeLocationFsxWindows Operation</seealso>
        Task<DescribeLocationFsxWindowsResponse> DescribeLocationFsxWindowsAsync(DescribeLocationFsxWindowsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLocationHdfs


        /// <summary>
        /// Provides details about how an DataSync transfer location for a Hadoop Distributed
        /// File System (HDFS) is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationHdfs service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationHdfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationHdfs">REST API Reference for DescribeLocationHdfs Operation</seealso>
        DescribeLocationHdfsResponse DescribeLocationHdfs(DescribeLocationHdfsRequest request);



        /// <summary>
        /// Provides details about how an DataSync transfer location for a Hadoop Distributed
        /// File System (HDFS) is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationHdfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationHdfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationHdfs">REST API Reference for DescribeLocationHdfs Operation</seealso>
        Task<DescribeLocationHdfsResponse> DescribeLocationHdfsAsync(DescribeLocationHdfsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLocationNfs


        /// <summary>
        /// Provides details about how an DataSync transfer location for a Network File System
        /// (NFS) file server is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationNfs service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationNfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationNfs">REST API Reference for DescribeLocationNfs Operation</seealso>
        DescribeLocationNfsResponse DescribeLocationNfs(DescribeLocationNfsRequest request);



        /// <summary>
        /// Provides details about how an DataSync transfer location for a Network File System
        /// (NFS) file server is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationNfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationNfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationNfs">REST API Reference for DescribeLocationNfs Operation</seealso>
        Task<DescribeLocationNfsResponse> DescribeLocationNfsAsync(DescribeLocationNfsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLocationObjectStorage


        /// <summary>
        /// Provides details about how an DataSync transfer location for an object storage system
        /// is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationObjectStorage service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationObjectStorage service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationObjectStorage">REST API Reference for DescribeLocationObjectStorage Operation</seealso>
        DescribeLocationObjectStorageResponse DescribeLocationObjectStorage(DescribeLocationObjectStorageRequest request);



        /// <summary>
        /// Provides details about how an DataSync transfer location for an object storage system
        /// is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationObjectStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationObjectStorage service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationObjectStorage">REST API Reference for DescribeLocationObjectStorage Operation</seealso>
        Task<DescribeLocationObjectStorageResponse> DescribeLocationObjectStorageAsync(DescribeLocationObjectStorageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLocationS3


        /// <summary>
        /// Provides details about how an DataSync transfer location for an S3 bucket is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationS3 service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationS3 service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationS3">REST API Reference for DescribeLocationS3 Operation</seealso>
        DescribeLocationS3Response DescribeLocationS3(DescribeLocationS3Request request);



        /// <summary>
        /// Provides details about how an DataSync transfer location for an S3 bucket is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationS3 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationS3 service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationS3">REST API Reference for DescribeLocationS3 Operation</seealso>
        Task<DescribeLocationS3Response> DescribeLocationS3Async(DescribeLocationS3Request request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLocationSmb


        /// <summary>
        /// Provides details about how an DataSync transfer location for a Server Message Block
        /// (SMB) file server is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationSmb service method.</param>
        /// 
        /// <returns>The response from the DescribeLocationSmb service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationSmb">REST API Reference for DescribeLocationSmb Operation</seealso>
        DescribeLocationSmbResponse DescribeLocationSmb(DescribeLocationSmbRequest request);



        /// <summary>
        /// Provides details about how an DataSync transfer location for a Server Message Block
        /// (SMB) file server is configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationSmb service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocationSmb service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationSmb">REST API Reference for DescribeLocationSmb Operation</seealso>
        Task<DescribeLocationSmbResponse> DescribeLocationSmbAsync(DescribeLocationSmbRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStorageSystem


        /// <summary>
        /// Returns information about an on-premises storage system that you're using with DataSync
        /// Discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorageSystem service method.</param>
        /// 
        /// <returns>The response from the DescribeStorageSystem service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeStorageSystem">REST API Reference for DescribeStorageSystem Operation</seealso>
        DescribeStorageSystemResponse DescribeStorageSystem(DescribeStorageSystemRequest request);



        /// <summary>
        /// Returns information about an on-premises storage system that you're using with DataSync
        /// Discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorageSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStorageSystem service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeStorageSystem">REST API Reference for DescribeStorageSystem Operation</seealso>
        Task<DescribeStorageSystemResponse> DescribeStorageSystemAsync(DescribeStorageSystemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStorageSystemResourceMetrics


        /// <summary>
        /// Returns information, including performance data and capacity usage, which DataSync
        /// Discovery collects about a specific resource in your-premises storage system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorageSystemResourceMetrics service method.</param>
        /// 
        /// <returns>The response from the DescribeStorageSystemResourceMetrics service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeStorageSystemResourceMetrics">REST API Reference for DescribeStorageSystemResourceMetrics Operation</seealso>
        DescribeStorageSystemResourceMetricsResponse DescribeStorageSystemResourceMetrics(DescribeStorageSystemResourceMetricsRequest request);



        /// <summary>
        /// Returns information, including performance data and capacity usage, which DataSync
        /// Discovery collects about a specific resource in your-premises storage system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorageSystemResourceMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStorageSystemResourceMetrics service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeStorageSystemResourceMetrics">REST API Reference for DescribeStorageSystemResourceMetrics Operation</seealso>
        Task<DescribeStorageSystemResourceMetricsResponse> DescribeStorageSystemResourceMetricsAsync(DescribeStorageSystemResourceMetricsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStorageSystemResources


        /// <summary>
        /// Returns information that DataSync Discovery collects about resources in your on-premises
        /// storage system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorageSystemResources service method.</param>
        /// 
        /// <returns>The response from the DescribeStorageSystemResources service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeStorageSystemResources">REST API Reference for DescribeStorageSystemResources Operation</seealso>
        DescribeStorageSystemResourcesResponse DescribeStorageSystemResources(DescribeStorageSystemResourcesRequest request);



        /// <summary>
        /// Returns information that DataSync Discovery collects about resources in your on-premises
        /// storage system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorageSystemResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStorageSystemResources service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeStorageSystemResources">REST API Reference for DescribeStorageSystemResources Operation</seealso>
        Task<DescribeStorageSystemResourcesResponse> DescribeStorageSystemResourcesAsync(DescribeStorageSystemResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTask


        /// <summary>
        /// Provides information about a <i>task</i>, which defines where and how DataSync transfers
        /// your data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTask service method.</param>
        /// 
        /// <returns>The response from the DescribeTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTask">REST API Reference for DescribeTask Operation</seealso>
        DescribeTaskResponse DescribeTask(DescribeTaskRequest request);



        /// <summary>
        /// Provides information about a <i>task</i>, which defines where and how DataSync transfers
        /// your data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTask">REST API Reference for DescribeTask Operation</seealso>
        Task<DescribeTaskResponse> DescribeTaskAsync(DescribeTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTaskExecution


        /// <summary>
        /// Provides information about an execution of your DataSync task. You can use this operation
        /// to help monitor the progress of an ongoing data transfer or check the results of the
        /// transfer.
        /// 
        ///  <note> 
        /// <para>
        /// Some <c>DescribeTaskExecution</c> response elements are only relevant to a specific
        /// task mode. For information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html#task-mode-differences">Understanding
        /// task mode differences</a> and <a href="https://docs.aws.amazon.com/datasync/latest/userguide/transfer-performance-counters.html">Understanding
        /// data transfer performance counters</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskExecution service method.</param>
        /// 
        /// <returns>The response from the DescribeTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTaskExecution">REST API Reference for DescribeTaskExecution Operation</seealso>
        DescribeTaskExecutionResponse DescribeTaskExecution(DescribeTaskExecutionRequest request);



        /// <summary>
        /// Provides information about an execution of your DataSync task. You can use this operation
        /// to help monitor the progress of an ongoing data transfer or check the results of the
        /// transfer.
        /// 
        ///  <note> 
        /// <para>
        /// Some <c>DescribeTaskExecution</c> response elements are only relevant to a specific
        /// task mode. For information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choosing-task-mode.html#task-mode-differences">Understanding
        /// task mode differences</a> and <a href="https://docs.aws.amazon.com/datasync/latest/userguide/transfer-performance-counters.html">Understanding
        /// data transfer performance counters</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTaskExecution">REST API Reference for DescribeTaskExecution Operation</seealso>
        Task<DescribeTaskExecutionResponse> DescribeTaskExecutionAsync(DescribeTaskExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GenerateRecommendations


        /// <summary>
        /// Creates recommendations about where to migrate your data to in Amazon Web Services.
        /// Recommendations are generated based on information that DataSync Discovery collects
        /// about your on-premises storage system's resources. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/discovery-understand-recommendations.html">Recommendations
        /// provided by DataSync Discovery</a>.
        /// 
        ///  
        /// <para>
        /// Once generated, you can view your recommendations by using the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_DescribeStorageSystemResources.html">DescribeStorageSystemResources</a>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateRecommendations service method.</param>
        /// 
        /// <returns>The response from the GenerateRecommendations service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/GenerateRecommendations">REST API Reference for GenerateRecommendations Operation</seealso>
        GenerateRecommendationsResponse GenerateRecommendations(GenerateRecommendationsRequest request);



        /// <summary>
        /// Creates recommendations about where to migrate your data to in Amazon Web Services.
        /// Recommendations are generated based on information that DataSync Discovery collects
        /// about your on-premises storage system's resources. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/discovery-understand-recommendations.html">Recommendations
        /// provided by DataSync Discovery</a>.
        /// 
        ///  
        /// <para>
        /// Once generated, you can view your recommendations by using the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_DescribeStorageSystemResources.html">DescribeStorageSystemResources</a>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateRecommendations service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/GenerateRecommendations">REST API Reference for GenerateRecommendations Operation</seealso>
        Task<GenerateRecommendationsResponse> GenerateRecommendationsAsync(GenerateRecommendationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAgents


        /// <summary>
        /// Returns a list of DataSync agents that belong to an Amazon Web Services account in
        /// the Amazon Web Services Region specified in the request.
        /// 
        ///  
        /// <para>
        /// With pagination, you can reduce the number of agents returned in a response. If you
        /// get a truncated list of agents in a response, the response contains a marker that
        /// you can specify in your next request to fetch the next page of agents.
        /// </para>
        ///  
        /// <para>
        ///  <c>ListAgents</c> is eventually consistent. This means the result of running the
        /// operation might not reflect that you just created or deleted an agent. For example,
        /// if you create an agent with <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_CreateAgent.html">CreateAgent</a>
        /// and then immediately run <c>ListAgents</c>, that agent might not show up in the list
        /// right away. In situations like this, you can always confirm whether an agent has been
        /// created (or deleted) by using <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_DescribeAgent.html">DescribeAgent</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgents service method.</param>
        /// 
        /// <returns>The response from the ListAgents service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListAgents">REST API Reference for ListAgents Operation</seealso>
        ListAgentsResponse ListAgents(ListAgentsRequest request);



        /// <summary>
        /// Returns a list of DataSync agents that belong to an Amazon Web Services account in
        /// the Amazon Web Services Region specified in the request.
        /// 
        ///  
        /// <para>
        /// With pagination, you can reduce the number of agents returned in a response. If you
        /// get a truncated list of agents in a response, the response contains a marker that
        /// you can specify in your next request to fetch the next page of agents.
        /// </para>
        ///  
        /// <para>
        ///  <c>ListAgents</c> is eventually consistent. This means the result of running the
        /// operation might not reflect that you just created or deleted an agent. For example,
        /// if you create an agent with <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_CreateAgent.html">CreateAgent</a>
        /// and then immediately run <c>ListAgents</c>, that agent might not show up in the list
        /// right away. In situations like this, you can always confirm whether an agent has been
        /// created (or deleted) by using <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_DescribeAgent.html">DescribeAgent</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgents service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListAgents">REST API Reference for ListAgents Operation</seealso>
        Task<ListAgentsResponse> ListAgentsAsync(ListAgentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDiscoveryJobs


        /// <summary>
        /// Provides a list of the existing discovery jobs in the Amazon Web Services Region and
        /// Amazon Web Services account where you're using DataSync Discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveryJobs service method.</param>
        /// 
        /// <returns>The response from the ListDiscoveryJobs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListDiscoveryJobs">REST API Reference for ListDiscoveryJobs Operation</seealso>
        ListDiscoveryJobsResponse ListDiscoveryJobs(ListDiscoveryJobsRequest request);



        /// <summary>
        /// Provides a list of the existing discovery jobs in the Amazon Web Services Region and
        /// Amazon Web Services account where you're using DataSync Discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveryJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDiscoveryJobs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListDiscoveryJobs">REST API Reference for ListDiscoveryJobs Operation</seealso>
        Task<ListDiscoveryJobsResponse> ListDiscoveryJobsAsync(ListDiscoveryJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLocations


        /// <summary>
        /// Returns a list of source and destination locations.
        /// 
        ///  
        /// <para>
        /// If you have more locations than are returned in a response (that is, the response
        /// returns only a truncated list of your agents), the response contains a token that
        /// you can specify in your next request to fetch the next page of locations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLocations service method.</param>
        /// 
        /// <returns>The response from the ListLocations service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListLocations">REST API Reference for ListLocations Operation</seealso>
        ListLocationsResponse ListLocations(ListLocationsRequest request);



        /// <summary>
        /// Returns a list of source and destination locations.
        /// 
        ///  
        /// <para>
        /// If you have more locations than are returned in a response (that is, the response
        /// returns only a truncated list of your agents), the response contains a token that
        /// you can specify in your next request to fetch the next page of locations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLocations service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListLocations">REST API Reference for ListLocations Operation</seealso>
        Task<ListLocationsResponse> ListLocationsAsync(ListLocationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListStorageSystems


        /// <summary>
        /// Lists the on-premises storage systems that you're using with DataSync Discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStorageSystems service method.</param>
        /// 
        /// <returns>The response from the ListStorageSystems service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListStorageSystems">REST API Reference for ListStorageSystems Operation</seealso>
        ListStorageSystemsResponse ListStorageSystems(ListStorageSystemsRequest request);



        /// <summary>
        /// Lists the on-premises storage systems that you're using with DataSync Discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStorageSystems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStorageSystems service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListStorageSystems">REST API Reference for ListStorageSystems Operation</seealso>
        Task<ListStorageSystemsResponse> ListStorageSystemsAsync(ListStorageSystemsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns all the tags associated with an Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Returns all the tags associated with an Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTaskExecutions


        /// <summary>
        /// Returns a list of executions for an DataSync transfer task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaskExecutions service method.</param>
        /// 
        /// <returns>The response from the ListTaskExecutions service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTaskExecutions">REST API Reference for ListTaskExecutions Operation</seealso>
        ListTaskExecutionsResponse ListTaskExecutions(ListTaskExecutionsRequest request);



        /// <summary>
        /// Returns a list of executions for an DataSync transfer task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTaskExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTaskExecutions service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTaskExecutions">REST API Reference for ListTaskExecutions Operation</seealso>
        Task<ListTaskExecutionsResponse> ListTaskExecutionsAsync(ListTaskExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTasks


        /// <summary>
        /// Returns a list of the DataSync tasks you created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTasks service method.</param>
        /// 
        /// <returns>The response from the ListTasks service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTasks">REST API Reference for ListTasks Operation</seealso>
        ListTasksResponse ListTasks(ListTasksRequest request);



        /// <summary>
        /// Returns a list of the DataSync tasks you created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTasks service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTasks">REST API Reference for ListTasks Operation</seealso>
        Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveStorageSystem


        /// <summary>
        /// Permanently removes a storage system resource from DataSync Discovery, including the
        /// associated discovery jobs, collected data, and recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveStorageSystem service method.</param>
        /// 
        /// <returns>The response from the RemoveStorageSystem service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/RemoveStorageSystem">REST API Reference for RemoveStorageSystem Operation</seealso>
        RemoveStorageSystemResponse RemoveStorageSystem(RemoveStorageSystemRequest request);



        /// <summary>
        /// Permanently removes a storage system resource from DataSync Discovery, including the
        /// associated discovery jobs, collected data, and recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveStorageSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveStorageSystem service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/RemoveStorageSystem">REST API Reference for RemoveStorageSystem Operation</seealso>
        Task<RemoveStorageSystemResponse> RemoveStorageSystemAsync(RemoveStorageSystemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartDiscoveryJob


        /// <summary>
        /// Runs a DataSync discovery job on your on-premises storage system. If you haven't added
        /// the storage system to DataSync Discovery yet, do this first by using the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_AddStorageSystem.html">AddStorageSystem</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDiscoveryJob service method.</param>
        /// 
        /// <returns>The response from the StartDiscoveryJob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/StartDiscoveryJob">REST API Reference for StartDiscoveryJob Operation</seealso>
        StartDiscoveryJobResponse StartDiscoveryJob(StartDiscoveryJobRequest request);



        /// <summary>
        /// Runs a DataSync discovery job on your on-premises storage system. If you haven't added
        /// the storage system to DataSync Discovery yet, do this first by using the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_AddStorageSystem.html">AddStorageSystem</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDiscoveryJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDiscoveryJob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/StartDiscoveryJob">REST API Reference for StartDiscoveryJob Operation</seealso>
        Task<StartDiscoveryJobResponse> StartDiscoveryJobAsync(StartDiscoveryJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartTaskExecution


        /// <summary>
        /// Starts an DataSync transfer task. For each task, you can only run one task execution
        /// at a time.
        /// 
        ///  
        /// <para>
        /// There are several steps to a task execution. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/working-with-task-executions.html#understand-task-execution-statuses">Task
        /// execution statuses</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you're planning to transfer data to or from an Amazon S3 location, review <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#create-s3-location-s3-requests">how
        /// DataSync can affect your S3 request charges</a> and the <a href="http://aws.amazon.com/datasync/pricing/">DataSync
        /// pricing page</a> before you begin.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTaskExecution service method.</param>
        /// 
        /// <returns>The response from the StartTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/StartTaskExecution">REST API Reference for StartTaskExecution Operation</seealso>
        StartTaskExecutionResponse StartTaskExecution(StartTaskExecutionRequest request);



        /// <summary>
        /// Starts an DataSync transfer task. For each task, you can only run one task execution
        /// at a time.
        /// 
        ///  
        /// <para>
        /// There are several steps to a task execution. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/working-with-task-executions.html#understand-task-execution-statuses">Task
        /// execution statuses</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you're planning to transfer data to or from an Amazon S3 location, review <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#create-s3-location-s3-requests">how
        /// DataSync can affect your S3 request charges</a> and the <a href="http://aws.amazon.com/datasync/pricing/">DataSync
        /// pricing page</a> before you begin.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTaskExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/StartTaskExecution">REST API Reference for StartTaskExecution Operation</seealso>
        Task<StartTaskExecutionResponse> StartTaskExecutionAsync(StartTaskExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopDiscoveryJob


        /// <summary>
        /// Stops a running DataSync discovery job.
        /// 
        ///  
        /// <para>
        /// You can stop a discovery job anytime. A job that's stopped before it's scheduled to
        /// end likely will provide you some information about your on-premises storage system
        /// resources. To get recommendations for a stopped job, you must use the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_GenerateRecommendations.html">GenerateRecommendations</a>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDiscoveryJob service method.</param>
        /// 
        /// <returns>The response from the StopDiscoveryJob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/StopDiscoveryJob">REST API Reference for StopDiscoveryJob Operation</seealso>
        StopDiscoveryJobResponse StopDiscoveryJob(StopDiscoveryJobRequest request);



        /// <summary>
        /// Stops a running DataSync discovery job.
        /// 
        ///  
        /// <para>
        /// You can stop a discovery job anytime. A job that's stopped before it's scheduled to
        /// end likely will provide you some information about your on-premises storage system
        /// resources. To get recommendations for a stopped job, you must use the <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_GenerateRecommendations.html">GenerateRecommendations</a>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDiscoveryJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopDiscoveryJob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/StopDiscoveryJob">REST API Reference for StopDiscoveryJob Operation</seealso>
        Task<StopDiscoveryJobResponse> StopDiscoveryJobAsync(StopDiscoveryJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Applies a <i>tag</i> to an Amazon Web Services resource. Tags are key-value pairs
        /// that can help you manage, filter, and search for your resources.
        /// 
        ///  
        /// <para>
        /// These include DataSync resources, such as locations, tasks, and task executions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Applies a <i>tag</i> to an Amazon Web Services resource. Tags are key-value pairs
        /// that can help you manage, filter, and search for your resources.
        /// 
        ///  
        /// <para>
        /// These include DataSync resources, such as locations, tasks, and task executions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from an Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes tags from an Amazon Web Services resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAgent


        /// <summary>
        /// Updates the name of an DataSync agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgent service method.</param>
        /// 
        /// <returns>The response from the UpdateAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateAgent">REST API Reference for UpdateAgent Operation</seealso>
        UpdateAgentResponse UpdateAgent(UpdateAgentRequest request);



        /// <summary>
        /// Updates the name of an DataSync agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgent service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateAgent">REST API Reference for UpdateAgent Operation</seealso>
        Task<UpdateAgentResponse> UpdateAgentAsync(UpdateAgentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDiscoveryJob


        /// <summary>
        /// Edits a DataSync discovery job configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDiscoveryJob service method.</param>
        /// 
        /// <returns>The response from the UpdateDiscoveryJob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateDiscoveryJob">REST API Reference for UpdateDiscoveryJob Operation</seealso>
        UpdateDiscoveryJobResponse UpdateDiscoveryJob(UpdateDiscoveryJobRequest request);



        /// <summary>
        /// Edits a DataSync discovery job configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDiscoveryJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDiscoveryJob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateDiscoveryJob">REST API Reference for UpdateDiscoveryJob Operation</seealso>
        Task<UpdateDiscoveryJobResponse> UpdateDiscoveryJobAsync(UpdateDiscoveryJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLocationAzureBlob


        /// <summary>
        /// Modifies some configurations of the Microsoft Azure Blob Storage transfer location
        /// that you're using with DataSync.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationAzureBlob service method.</param>
        /// 
        /// <returns>The response from the UpdateLocationAzureBlob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationAzureBlob">REST API Reference for UpdateLocationAzureBlob Operation</seealso>
        UpdateLocationAzureBlobResponse UpdateLocationAzureBlob(UpdateLocationAzureBlobRequest request);



        /// <summary>
        /// Modifies some configurations of the Microsoft Azure Blob Storage transfer location
        /// that you're using with DataSync.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationAzureBlob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLocationAzureBlob service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationAzureBlob">REST API Reference for UpdateLocationAzureBlob Operation</seealso>
        Task<UpdateLocationAzureBlobResponse> UpdateLocationAzureBlobAsync(UpdateLocationAzureBlobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLocationHdfs


        /// <summary>
        /// Updates some parameters of a previously created location for a Hadoop Distributed
        /// File System cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationHdfs service method.</param>
        /// 
        /// <returns>The response from the UpdateLocationHdfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationHdfs">REST API Reference for UpdateLocationHdfs Operation</seealso>
        UpdateLocationHdfsResponse UpdateLocationHdfs(UpdateLocationHdfsRequest request);



        /// <summary>
        /// Updates some parameters of a previously created location for a Hadoop Distributed
        /// File System cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationHdfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLocationHdfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationHdfs">REST API Reference for UpdateLocationHdfs Operation</seealso>
        Task<UpdateLocationHdfsResponse> UpdateLocationHdfsAsync(UpdateLocationHdfsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLocationNfs


        /// <summary>
        /// Modifies some configurations of the Network File System (NFS) transfer location that
        /// you're using with DataSync.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-nfs-location.html">Configuring
        /// transfers to or from an NFS file server</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationNfs service method.</param>
        /// 
        /// <returns>The response from the UpdateLocationNfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationNfs">REST API Reference for UpdateLocationNfs Operation</seealso>
        UpdateLocationNfsResponse UpdateLocationNfs(UpdateLocationNfsRequest request);



        /// <summary>
        /// Modifies some configurations of the Network File System (NFS) transfer location that
        /// you're using with DataSync.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-nfs-location.html">Configuring
        /// transfers to or from an NFS file server</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationNfs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLocationNfs service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationNfs">REST API Reference for UpdateLocationNfs Operation</seealso>
        Task<UpdateLocationNfsResponse> UpdateLocationNfsAsync(UpdateLocationNfsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLocationObjectStorage


        /// <summary>
        /// Updates some parameters of an existing DataSync location for an object storage system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationObjectStorage service method.</param>
        /// 
        /// <returns>The response from the UpdateLocationObjectStorage service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationObjectStorage">REST API Reference for UpdateLocationObjectStorage Operation</seealso>
        UpdateLocationObjectStorageResponse UpdateLocationObjectStorage(UpdateLocationObjectStorageRequest request);



        /// <summary>
        /// Updates some parameters of an existing DataSync location for an object storage system.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationObjectStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLocationObjectStorage service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationObjectStorage">REST API Reference for UpdateLocationObjectStorage Operation</seealso>
        Task<UpdateLocationObjectStorageResponse> UpdateLocationObjectStorageAsync(UpdateLocationObjectStorageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLocationSmb


        /// <summary>
        /// Updates some of the parameters of a Server Message Block (SMB) file server location
        /// that you can use for DataSync transfers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationSmb service method.</param>
        /// 
        /// <returns>The response from the UpdateLocationSmb service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationSmb">REST API Reference for UpdateLocationSmb Operation</seealso>
        UpdateLocationSmbResponse UpdateLocationSmb(UpdateLocationSmbRequest request);



        /// <summary>
        /// Updates some of the parameters of a Server Message Block (SMB) file server location
        /// that you can use for DataSync transfers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationSmb service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLocationSmb service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationSmb">REST API Reference for UpdateLocationSmb Operation</seealso>
        Task<UpdateLocationSmbResponse> UpdateLocationSmbAsync(UpdateLocationSmbRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateStorageSystem


        /// <summary>
        /// Modifies some configurations of an on-premises storage system resource that you're
        /// using with DataSync Discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStorageSystem service method.</param>
        /// 
        /// <returns>The response from the UpdateStorageSystem service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateStorageSystem">REST API Reference for UpdateStorageSystem Operation</seealso>
        UpdateStorageSystemResponse UpdateStorageSystem(UpdateStorageSystemRequest request);



        /// <summary>
        /// Modifies some configurations of an on-premises storage system resource that you're
        /// using with DataSync Discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStorageSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStorageSystem service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateStorageSystem">REST API Reference for UpdateStorageSystem Operation</seealso>
        Task<UpdateStorageSystemResponse> UpdateStorageSystemAsync(UpdateStorageSystemRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTask


        /// <summary>
        /// Updates the configuration of a <i>task</i>, which defines where and how DataSync transfers
        /// your data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTask service method.</param>
        /// 
        /// <returns>The response from the UpdateTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateTask">REST API Reference for UpdateTask Operation</seealso>
        UpdateTaskResponse UpdateTask(UpdateTaskRequest request);



        /// <summary>
        /// Updates the configuration of a <i>task</i>, which defines where and how DataSync transfers
        /// your data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTask service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateTask">REST API Reference for UpdateTask Operation</seealso>
        Task<UpdateTaskResponse> UpdateTaskAsync(UpdateTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTaskExecution


        /// <summary>
        /// Updates the configuration of a running DataSync task execution.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, the only <c>Option</c> that you can modify with <c>UpdateTaskExecution</c>
        /// is <c> <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_Options.html#DataSync-Type-Options-BytesPerSecond">BytesPerSecond</a>
        /// </c>, which throttles bandwidth for a running or queued task execution.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTaskExecution service method.</param>
        /// 
        /// <returns>The response from the UpdateTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateTaskExecution">REST API Reference for UpdateTaskExecution Operation</seealso>
        UpdateTaskExecutionResponse UpdateTaskExecution(UpdateTaskExecutionRequest request);



        /// <summary>
        /// Updates the configuration of a running DataSync task execution.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, the only <c>Option</c> that you can modify with <c>UpdateTaskExecution</c>
        /// is <c> <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_Options.html#DataSync-Type-Options-BytesPerSecond">BytesPerSecond</a>
        /// </c>, which throttles bandwidth for a running or queued task execution.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTaskExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTaskExecution service method, as returned by DataSync.</returns>
        /// <exception cref="Amazon.DataSync.Model.InternalException">
        /// This exception is thrown when an error occurs in the DataSync service.
        /// </exception>
        /// <exception cref="Amazon.DataSync.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateTaskExecution">REST API Reference for UpdateTaskExecution Operation</seealso>
        Task<UpdateTaskExecutionResponse> UpdateTaskExecutionAsync(UpdateTaskExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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