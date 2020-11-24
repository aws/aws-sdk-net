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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.FSx.Model;

namespace Amazon.FSx
{
    /// <summary>
    /// Interface for accessing FSx
    ///
    /// Amazon FSx is a fully managed service that makes it easy for storage and application
    /// administrators to launch and use shared file storage.
    /// </summary>
    public partial interface IAmazonFSx : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IFSxPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateFileSystemAliases


        /// <summary>
        /// Use this action to associate one or more Domain Name Server (DNS) aliases with an
        /// existing Amazon FSx for Windows File Server file system. A file systen can have a
        /// maximum of 50 DNS aliases associated with it at any one time. If you try to associate
        /// a DNS alias that is already associated with the file system, FSx takes no action on
        /// that alias in the request. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/managing-dns-aliases.html">Working
        /// with DNS Aliases</a> and <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/walkthrough05-file-system-custom-CNAME.html">Walkthrough
        /// 5: Using DNS aliases to access your file system</a>, including additional steps you
        /// must take to be able to access your file system using a DNS alias.
        /// 
        ///  
        /// <para>
        /// The system response shows the DNS aliases that Amazon FSx is attempting to associate
        /// with the file system. Use the API operation to monitor the status of the aliases Amazon
        /// FSx is associating with the file system.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateFileSystemAliases service method.</param>
        /// 
        /// <returns>The response from the AssociateFileSystemAliases service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/AssociateFileSystemAliases">REST API Reference for AssociateFileSystemAliases Operation</seealso>
        AssociateFileSystemAliasesResponse AssociateFileSystemAliases(AssociateFileSystemAliasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateFileSystemAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateFileSystemAliases operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateFileSystemAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/AssociateFileSystemAliases">REST API Reference for AssociateFileSystemAliases Operation</seealso>
        IAsyncResult BeginAssociateFileSystemAliases(AssociateFileSystemAliasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateFileSystemAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateFileSystemAliases.</param>
        /// 
        /// <returns>Returns a  AssociateFileSystemAliasesResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/AssociateFileSystemAliases">REST API Reference for AssociateFileSystemAliases Operation</seealso>
        AssociateFileSystemAliasesResponse EndAssociateFileSystemAliases(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelDataRepositoryTask


        /// <summary>
        /// Cancels an existing Amazon FSx for Lustre data repository task if that task is in
        /// either the <code>PENDING</code> or <code>EXECUTING</code> state. When you cancel a
        /// task, Amazon FSx does the following.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Any files that FSx has already exported are not reverted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FSx continues to export any files that are "in-flight" when the cancel operation is
        /// received.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FSx does not export any files that have not yet been exported.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelDataRepositoryTask service method.</param>
        /// 
        /// <returns>The response from the CancelDataRepositoryTask service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.DataRepositoryTaskEndedException">
        /// The data repository task could not be canceled because the task has already ended.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.DataRepositoryTaskNotFoundException">
        /// The data repository task or tasks you specified could not be found.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CancelDataRepositoryTask">REST API Reference for CancelDataRepositoryTask Operation</seealso>
        CancelDataRepositoryTaskResponse CancelDataRepositoryTask(CancelDataRepositoryTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelDataRepositoryTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelDataRepositoryTask operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelDataRepositoryTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CancelDataRepositoryTask">REST API Reference for CancelDataRepositoryTask Operation</seealso>
        IAsyncResult BeginCancelDataRepositoryTask(CancelDataRepositoryTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelDataRepositoryTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelDataRepositoryTask.</param>
        /// 
        /// <returns>Returns a  CancelDataRepositoryTaskResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CancelDataRepositoryTask">REST API Reference for CancelDataRepositoryTask Operation</seealso>
        CancelDataRepositoryTaskResponse EndCancelDataRepositoryTask(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBackup


        /// <summary>
        /// Creates a backup of an existing Amazon FSx file system. Creating regular backups for
        /// your file system is a best practice, enabling you to restore a file system from a
        /// backup if an issue arises with the original file system.
        /// 
        ///  
        /// <para>
        /// For Amazon FSx for Lustre file systems, you can create a backup only for file systems
        /// with the following configuration:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// a Persistent deployment type
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// is <i>not</i> linked to a data respository.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about backing up Amazon FSx for Lustre file systems, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/using-backups-fsx.html">Working
        /// with FSx for Lustre backups</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about backing up Amazon FSx for Windows file systems, see <a
        /// href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/using-backups.html">Working
        /// with FSx for Windows backups</a>.
        /// </para>
        ///  
        /// <para>
        /// If a backup with the specified client request token exists, and the parameters match,
        /// this operation returns the description of the existing backup. If a backup specified
        /// client request token exists, and the parameters don't match, this operation returns
        /// <code>IncompatibleParameterError</code>. If a backup with the specified client request
        /// token doesn't exist, <code>CreateBackup</code> does the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a new Amazon FSx backup with an assigned ID, and an initial lifecycle state
        /// of <code>CREATING</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returns the description of the backup.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// By using the idempotent operation, you can retry a <code>CreateBackup</code> operation
        /// without the risk of creating an extra backup. This approach can be useful when an
        /// initial call fails in a way that makes it unclear whether a backup was created. If
        /// you use the same client request token and the initial call created a backup, the operation
        /// returns a successful result because all the parameters are the same.
        /// </para>
        ///  
        /// <para>
        /// The <code>CreateBackup</code> operation returns while the backup's lifecycle state
        /// is still <code>CREATING</code>. You can check the backup creation status by calling
        /// the <a>DescribeBackups</a> operation, which returns the backup state along with other
        /// information.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackup service method.</param>
        /// 
        /// <returns>The response from the CreateBackup service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BackupInProgressException">
        /// Another backup is already under way. Wait for completion before initiating additional
        /// backups of this file system.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting AWS Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateBackup">REST API Reference for CreateBackup Operation</seealso>
        CreateBackupResponse CreateBackup(CreateBackupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBackup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBackup operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBackup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateBackup">REST API Reference for CreateBackup Operation</seealso>
        IAsyncResult BeginCreateBackup(CreateBackupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBackup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBackup.</param>
        /// 
        /// <returns>Returns a  CreateBackupResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateBackup">REST API Reference for CreateBackup Operation</seealso>
        CreateBackupResponse EndCreateBackup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataRepositoryTask


        /// <summary>
        /// Creates an Amazon FSx for Lustre data repository task. You use data repository tasks
        /// to perform bulk operations between your Amazon FSx file system and its linked data
        /// repository. An example of a data repository task is exporting any data and metadata
        /// changes, including POSIX metadata, to files, directories, and symbolic links (symlinks)
        /// from your FSx file system to its linked data repository. A <code>CreateDataRepositoryTask</code>
        /// operation will fail if a data repository is not linked to the FSx file system. To
        /// learn more about data repository tasks, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/data-repository-tasks.html">Data
        /// Repository Tasks</a>. To learn more about linking a data repository to your file system,
        /// see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/create-fs-linked-data-repo.html">Linking
        /// your file system to an S3 bucket</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataRepositoryTask service method.</param>
        /// 
        /// <returns>The response from the CreateDataRepositoryTask service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.DataRepositoryTaskExecutingException">
        /// An existing data repository task is currently executing on the file system. Wait until
        /// the existing task has completed, then create the new task.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting AWS Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateDataRepositoryTask">REST API Reference for CreateDataRepositoryTask Operation</seealso>
        CreateDataRepositoryTaskResponse CreateDataRepositoryTask(CreateDataRepositoryTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataRepositoryTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataRepositoryTask operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataRepositoryTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateDataRepositoryTask">REST API Reference for CreateDataRepositoryTask Operation</seealso>
        IAsyncResult BeginCreateDataRepositoryTask(CreateDataRepositoryTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataRepositoryTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataRepositoryTask.</param>
        /// 
        /// <returns>Returns a  CreateDataRepositoryTaskResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateDataRepositoryTask">REST API Reference for CreateDataRepositoryTask Operation</seealso>
        CreateDataRepositoryTaskResponse EndCreateDataRepositoryTask(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFileSystem


        /// <summary>
        /// Creates a new, empty Amazon FSx file system.
        /// 
        ///  
        /// <para>
        /// If a file system with the specified client request token exists and the parameters
        /// match, <code>CreateFileSystem</code> returns the description of the existing file
        /// system. If a file system specified client request token exists and the parameters
        /// don't match, this call returns <code>IncompatibleParameterError</code>. If a file
        /// system with the specified client request token doesn't exist, <code>CreateFileSystem</code>
        /// does the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a new, empty Amazon FSx file system with an assigned ID, and an initial lifecycle
        /// state of <code>CREATING</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returns the description of the file system.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation requires a client request token in the request that Amazon FSx uses
        /// to ensure idempotent creation. This means that calling the operation multiple times
        /// with the same client request token has no effect. By using the idempotent operation,
        /// you can retry a <code>CreateFileSystem</code> operation without the risk of creating
        /// an extra file system. This approach can be useful when an initial call fails in a
        /// way that makes it unclear whether a file system was created. Examples are if a transport
        /// level timeout occurred, or your connection was reset. If you use the same client request
        /// token and the initial call created a file system, the client receives success as long
        /// as the parameters are the same.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>CreateFileSystem</code> call returns while the file system's lifecycle state
        /// is still <code>CREATING</code>. You can check the file-system creation status by calling
        /// the <a>DescribeFileSystems</a> operation, which returns the file system state along
        /// with other information.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFileSystem service method.</param>
        /// 
        /// <returns>The response from the CreateFileSystem service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.ActiveDirectoryErrorException">
        /// An Active Directory error.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidExportPathException">
        /// The path provided for data repository export isn't valid.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidImportPathException">
        /// The path provided for data repository import isn't valid.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidNetworkSettingsException">
        /// One or more network settings specified in the request are invalid. <code>InvalidVpcId</code>
        /// means that the ID passed for the virtual private cloud (VPC) is invalid. <code>InvalidSubnetIds</code>
        /// returns the list of IDs for subnets that are either invalid or not part of the VPC
        /// specified. <code>InvalidSecurityGroupIds</code> returns the list of IDs for security
        /// groups that are either invalid or not part of the VPC specified.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidPerUnitStorageThroughputException">
        /// An invalid value for <code>PerUnitStorageThroughput</code> was provided. Please create
        /// your file system again, using a valid value.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.MissingFileSystemConfigurationException">
        /// A file system configuration is required for this operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting AWS Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateFileSystem">REST API Reference for CreateFileSystem Operation</seealso>
        CreateFileSystemResponse CreateFileSystem(CreateFileSystemRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFileSystem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFileSystem operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFileSystem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateFileSystem">REST API Reference for CreateFileSystem Operation</seealso>
        IAsyncResult BeginCreateFileSystem(CreateFileSystemRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFileSystem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFileSystem.</param>
        /// 
        /// <returns>Returns a  CreateFileSystemResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateFileSystem">REST API Reference for CreateFileSystem Operation</seealso>
        CreateFileSystemResponse EndCreateFileSystem(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFileSystemFromBackup


        /// <summary>
        /// Creates a new Amazon FSx file system from an existing Amazon FSx backup.
        /// 
        ///  
        /// <para>
        /// If a file system with the specified client request token exists and the parameters
        /// match, this operation returns the description of the file system. If a client request
        /// token specified by the file system exists and the parameters don't match, this call
        /// returns <code>IncompatibleParameterError</code>. If a file system with the specified
        /// client request token doesn't exist, this operation does the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a new Amazon FSx file system from backup with an assigned ID, and an initial
        /// lifecycle state of <code>CREATING</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returns the description of the file system.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Parameters like Active Directory, default share name, automatic backup, and backup
        /// settings default to the parameters of the file system that was backed up, unless overridden.
        /// You can explicitly supply other settings.
        /// </para>
        ///  
        /// <para>
        /// By using the idempotent operation, you can retry a <code>CreateFileSystemFromBackup</code>
        /// call without the risk of creating an extra file system. This approach can be useful
        /// when an initial call fails in a way that makes it unclear whether a file system was
        /// created. Examples are if a transport level timeout occurred, or your connection was
        /// reset. If you use the same client request token and the initial call created a file
        /// system, the client receives success as long as the parameters are the same.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>CreateFileSystemFromBackup</code> call returns while the file system's lifecycle
        /// state is still <code>CREATING</code>. You can check the file-system creation status
        /// by calling the <a>DescribeFileSystems</a> operation, which returns the file system
        /// state along with other information.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFileSystemFromBackup service method.</param>
        /// 
        /// <returns>The response from the CreateFileSystemFromBackup service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.ActiveDirectoryErrorException">
        /// An Active Directory error.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BackupNotFoundException">
        /// No Amazon FSx backups were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidNetworkSettingsException">
        /// One or more network settings specified in the request are invalid. <code>InvalidVpcId</code>
        /// means that the ID passed for the virtual private cloud (VPC) is invalid. <code>InvalidSubnetIds</code>
        /// returns the list of IDs for subnets that are either invalid or not part of the VPC
        /// specified. <code>InvalidSecurityGroupIds</code> returns the list of IDs for security
        /// groups that are either invalid or not part of the VPC specified.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidPerUnitStorageThroughputException">
        /// An invalid value for <code>PerUnitStorageThroughput</code> was provided. Please create
        /// your file system again, using a valid value.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.MissingFileSystemConfigurationException">
        /// A file system configuration is required for this operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting AWS Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateFileSystemFromBackup">REST API Reference for CreateFileSystemFromBackup Operation</seealso>
        CreateFileSystemFromBackupResponse CreateFileSystemFromBackup(CreateFileSystemFromBackupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFileSystemFromBackup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFileSystemFromBackup operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFileSystemFromBackup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateFileSystemFromBackup">REST API Reference for CreateFileSystemFromBackup Operation</seealso>
        IAsyncResult BeginCreateFileSystemFromBackup(CreateFileSystemFromBackupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFileSystemFromBackup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFileSystemFromBackup.</param>
        /// 
        /// <returns>Returns a  CreateFileSystemFromBackupResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateFileSystemFromBackup">REST API Reference for CreateFileSystemFromBackup Operation</seealso>
        CreateFileSystemFromBackupResponse EndCreateFileSystemFromBackup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBackup


        /// <summary>
        /// Deletes an Amazon FSx backup, deleting its contents. After deletion, the backup no
        /// longer exists, and its data is gone.
        /// 
        ///  
        /// <para>
        /// The <code>DeleteBackup</code> call returns instantly. The backup will not show up
        /// in later <code>DescribeBackups</code> calls.
        /// </para>
        ///  <important> 
        /// <para>
        /// The data in a deleted backup is also deleted and can't be recovered by any means.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackup service method.</param>
        /// 
        /// <returns>The response from the DeleteBackup service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BackupInProgressException">
        /// Another backup is already under way. Wait for completion before initiating additional
        /// backups of this file system.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BackupNotFoundException">
        /// No Amazon FSx backups were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BackupRestoringException">
        /// You can't delete a backup while it's being used to restore a file system.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteBackup">REST API Reference for DeleteBackup Operation</seealso>
        DeleteBackupResponse DeleteBackup(DeleteBackupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBackup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackup operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBackup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteBackup">REST API Reference for DeleteBackup Operation</seealso>
        IAsyncResult BeginDeleteBackup(DeleteBackupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBackup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBackup.</param>
        /// 
        /// <returns>Returns a  DeleteBackupResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteBackup">REST API Reference for DeleteBackup Operation</seealso>
        DeleteBackupResponse EndDeleteBackup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFileSystem


        /// <summary>
        /// Deletes a file system, deleting its contents. After deletion, the file system no longer
        /// exists, and its data is gone. Any existing automatic backups will also be deleted.
        /// 
        ///  
        /// <para>
        /// By default, when you delete an Amazon FSx for Windows File Server file system, a final
        /// backup is created upon deletion. This final backup is not subject to the file system's
        /// retention policy, and must be manually deleted.
        /// </para>
        ///  
        /// <para>
        /// The <code>DeleteFileSystem</code> action returns while the file system has the <code>DELETING</code>
        /// status. You can check the file system deletion status by calling the <a>DescribeFileSystems</a>
        /// action, which returns a list of file systems in your account. If you pass the file
        /// system ID for a deleted file system, the <a>DescribeFileSystems</a> returns a <code>FileSystemNotFound</code>
        /// error.
        /// </para>
        ///  <note> 
        /// <para>
        /// Deleting an Amazon FSx for Lustre file system will fail with a 400 BadRequest if a
        /// data repository task is in a <code>PENDING</code> or <code>EXECUTING</code> state.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// The data in a deleted file system is also deleted and can't be recovered by any means.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileSystem service method.</param>
        /// 
        /// <returns>The response from the DeleteFileSystem service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting AWS Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteFileSystem">REST API Reference for DeleteFileSystem Operation</seealso>
        DeleteFileSystemResponse DeleteFileSystem(DeleteFileSystemRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFileSystem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileSystem operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFileSystem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteFileSystem">REST API Reference for DeleteFileSystem Operation</seealso>
        IAsyncResult BeginDeleteFileSystem(DeleteFileSystemRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFileSystem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFileSystem.</param>
        /// 
        /// <returns>Returns a  DeleteFileSystemResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteFileSystem">REST API Reference for DeleteFileSystem Operation</seealso>
        DeleteFileSystemResponse EndDeleteFileSystem(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBackups


        /// <summary>
        /// Returns the description of specific Amazon FSx backups, if a <code>BackupIds</code>
        /// value is provided for that backup. Otherwise, it returns all backups owned by your
        /// AWS account in the AWS Region of the endpoint that you're calling.
        /// 
        ///  
        /// <para>
        /// When retrieving all backups, you can optionally specify the <code>MaxResults</code>
        /// parameter to limit the number of backups in a response. If more backups remain, Amazon
        /// FSx returns a <code>NextToken</code> value in the response. In this case, send a later
        /// request with the <code>NextToken</code> request parameter set to the value of <code>NextToken</code>
        /// from the last response.
        /// </para>
        ///  
        /// <para>
        /// This action is used in an iterative process to retrieve a list of your backups. <code>DescribeBackups</code>
        /// is called first without a <code>NextToken</code>value. Then the action continues to
        /// be called with the <code>NextToken</code> parameter set to the value of the last <code>NextToken</code>
        /// value until a response has no <code>NextToken</code>.
        /// </para>
        ///  
        /// <para>
        /// When using this action, keep the following in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The implementation might return fewer than <code>MaxResults</code> file system descriptions
        /// while still including a <code>NextToken</code> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The order of backups returned in the response of one <code>DescribeBackups</code>
        /// call and the order of backups returned across the responses of a multi-call iteration
        /// is unspecified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackups service method.</param>
        /// 
        /// <returns>The response from the DescribeBackups service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BackupNotFoundException">
        /// No Amazon FSx backups were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeBackups">REST API Reference for DescribeBackups Operation</seealso>
        DescribeBackupsResponse DescribeBackups(DescribeBackupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBackups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackups operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBackups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeBackups">REST API Reference for DescribeBackups Operation</seealso>
        IAsyncResult BeginDescribeBackups(DescribeBackupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBackups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBackups.</param>
        /// 
        /// <returns>Returns a  DescribeBackupsResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeBackups">REST API Reference for DescribeBackups Operation</seealso>
        DescribeBackupsResponse EndDescribeBackups(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDataRepositoryTasks


        /// <summary>
        /// Returns the description of specific Amazon FSx for Lustre data repository tasks, if
        /// one or more <code>TaskIds</code> values are provided in the request, or if filters
        /// are used in the request. You can use filters to narrow the response to include just
        /// tasks for specific file systems, or tasks in a specific lifecycle state. Otherwise,
        /// it returns all data repository tasks owned by your AWS account in the AWS Region of
        /// the endpoint that you're calling.
        /// 
        ///  
        /// <para>
        /// When retrieving all tasks, you can paginate the response by using the optional <code>MaxResults</code>
        /// parameter to limit the number of tasks returned in a response. If more tasks remain,
        /// Amazon FSx returns a <code>NextToken</code> value in the response. In this case, send
        /// a later request with the <code>NextToken</code> request parameter set to the value
        /// of <code>NextToken</code> from the last response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataRepositoryTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeDataRepositoryTasks service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.DataRepositoryTaskNotFoundException">
        /// The data repository task or tasks you specified could not be found.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeDataRepositoryTasks">REST API Reference for DescribeDataRepositoryTasks Operation</seealso>
        DescribeDataRepositoryTasksResponse DescribeDataRepositoryTasks(DescribeDataRepositoryTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataRepositoryTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataRepositoryTasks operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDataRepositoryTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeDataRepositoryTasks">REST API Reference for DescribeDataRepositoryTasks Operation</seealso>
        IAsyncResult BeginDescribeDataRepositoryTasks(DescribeDataRepositoryTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDataRepositoryTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDataRepositoryTasks.</param>
        /// 
        /// <returns>Returns a  DescribeDataRepositoryTasksResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeDataRepositoryTasks">REST API Reference for DescribeDataRepositoryTasks Operation</seealso>
        DescribeDataRepositoryTasksResponse EndDescribeDataRepositoryTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFileSystemAliases


        /// <summary>
        /// Returns the DNS aliases that are associated with the specified Amazon FSx for Windows
        /// File Server file system. A history of all DNS aliases that have been associated with
        /// and disassociated from the file system is available in the list of <a>AdministrativeAction</a>
        /// provided in the <a>DescribeFileSystems</a> operation response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFileSystemAliases service method.</param>
        /// 
        /// <returns>The response from the DescribeFileSystemAliases service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeFileSystemAliases">REST API Reference for DescribeFileSystemAliases Operation</seealso>
        DescribeFileSystemAliasesResponse DescribeFileSystemAliases(DescribeFileSystemAliasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFileSystemAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFileSystemAliases operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFileSystemAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeFileSystemAliases">REST API Reference for DescribeFileSystemAliases Operation</seealso>
        IAsyncResult BeginDescribeFileSystemAliases(DescribeFileSystemAliasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFileSystemAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFileSystemAliases.</param>
        /// 
        /// <returns>Returns a  DescribeFileSystemAliasesResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeFileSystemAliases">REST API Reference for DescribeFileSystemAliases Operation</seealso>
        DescribeFileSystemAliasesResponse EndDescribeFileSystemAliases(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFileSystems


        /// <summary>
        /// Returns the description of specific Amazon FSx file systems, if a <code>FileSystemIds</code>
        /// value is provided for that file system. Otherwise, it returns descriptions of all
        /// file systems owned by your AWS account in the AWS Region of the endpoint that you're
        /// calling.
        /// 
        ///  
        /// <para>
        /// When retrieving all file system descriptions, you can optionally specify the <code>MaxResults</code>
        /// parameter to limit the number of descriptions in a response. If more file system descriptions
        /// remain, Amazon FSx returns a <code>NextToken</code> value in the response. In this
        /// case, send a later request with the <code>NextToken</code> request parameter set to
        /// the value of <code>NextToken</code> from the last response.
        /// </para>
        ///  
        /// <para>
        /// This action is used in an iterative process to retrieve a list of your file system
        /// descriptions. <code>DescribeFileSystems</code> is called first without a <code>NextToken</code>value.
        /// Then the action continues to be called with the <code>NextToken</code> parameter set
        /// to the value of the last <code>NextToken</code> value until a response has no <code>NextToken</code>.
        /// </para>
        ///  
        /// <para>
        /// When using this action, keep the following in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The implementation might return fewer than <code>MaxResults</code> file system descriptions
        /// while still including a <code>NextToken</code> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The order of file systems returned in the response of one <code>DescribeFileSystems</code>
        /// call and the order of file systems returned across the responses of a multicall iteration
        /// is unspecified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFileSystems service method.</param>
        /// 
        /// <returns>The response from the DescribeFileSystems service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeFileSystems">REST API Reference for DescribeFileSystems Operation</seealso>
        DescribeFileSystemsResponse DescribeFileSystems(DescribeFileSystemsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFileSystems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFileSystems operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFileSystems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeFileSystems">REST API Reference for DescribeFileSystems Operation</seealso>
        IAsyncResult BeginDescribeFileSystems(DescribeFileSystemsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFileSystems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFileSystems.</param>
        /// 
        /// <returns>Returns a  DescribeFileSystemsResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeFileSystems">REST API Reference for DescribeFileSystems Operation</seealso>
        DescribeFileSystemsResponse EndDescribeFileSystems(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateFileSystemAliases


        /// <summary>
        /// Use this action to disassociate, or remove, one or more Domain Name Service (DNS)
        /// aliases from an Amazon FSx for Windows File Server file system. If you attempt to
        /// disassociate a DNS alias that is not associated with the file system, Amazon FSx responds
        /// with a 400 Bad Request. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/managing-dns-aliases.html">Working
        /// with DNS Aliases</a>.
        /// 
        ///  
        /// <para>
        /// The system generated response showing the DNS aliases that Amazon FSx is attempting
        /// to disassociate from the file system. Use the API operation to monitor the status
        /// of the aliases Amazon FSx is disassociating with the file system.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFileSystemAliases service method.</param>
        /// 
        /// <returns>The response from the DisassociateFileSystemAliases service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DisassociateFileSystemAliases">REST API Reference for DisassociateFileSystemAliases Operation</seealso>
        DisassociateFileSystemAliasesResponse DisassociateFileSystemAliases(DisassociateFileSystemAliasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateFileSystemAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFileSystemAliases operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateFileSystemAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DisassociateFileSystemAliases">REST API Reference for DisassociateFileSystemAliases Operation</seealso>
        IAsyncResult BeginDisassociateFileSystemAliases(DisassociateFileSystemAliasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateFileSystemAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateFileSystemAliases.</param>
        /// 
        /// <returns>Returns a  DisassociateFileSystemAliasesResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DisassociateFileSystemAliases">REST API Reference for DisassociateFileSystemAliases Operation</seealso>
        DisassociateFileSystemAliasesResponse EndDisassociateFileSystemAliases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists tags for an Amazon FSx file systems and backups in the case of Amazon FSx for
        /// Windows File Server.
        /// 
        ///  
        /// <para>
        /// When retrieving all tags, you can optionally specify the <code>MaxResults</code> parameter
        /// to limit the number of tags in a response. If more tags remain, Amazon FSx returns
        /// a <code>NextToken</code> value in the response. In this case, send a later request
        /// with the <code>NextToken</code> request parameter set to the value of <code>NextToken</code>
        /// from the last response.
        /// </para>
        ///  
        /// <para>
        /// This action is used in an iterative process to retrieve a list of your tags. <code>ListTagsForResource</code>
        /// is called first without a <code>NextToken</code>value. Then the action continues to
        /// be called with the <code>NextToken</code> parameter set to the value of the last <code>NextToken</code>
        /// value until a response has no <code>NextToken</code>.
        /// </para>
        ///  
        /// <para>
        /// When using this action, keep the following in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The implementation might return fewer than <code>MaxResults</code> file system descriptions
        /// while still including a <code>NextToken</code> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The order of tags returned in the response of one <code>ListTagsForResource</code>
        /// call and the order of tags returned across the responses of a multi-call iteration
        /// is unspecified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.NotServiceResourceErrorException">
        /// The resource specified for the tagging operation is not a resource type owned by Amazon
        /// FSx. Use the API of the relevant service to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceDoesNotSupportTaggingException">
        /// The resource specified does not support tagging.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceNotFoundException">
        /// The resource specified by the Amazon Resource Name (ARN) can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags an Amazon FSx resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.NotServiceResourceErrorException">
        /// The resource specified for the tagging operation is not a resource type owned by Amazon
        /// FSx. Use the API of the relevant service to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceDoesNotSupportTaggingException">
        /// The resource specified does not support tagging.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceNotFoundException">
        /// The resource specified by the Amazon Resource Name (ARN) can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// This action removes a tag from an Amazon FSx resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.NotServiceResourceErrorException">
        /// The resource specified for the tagging operation is not a resource type owned by Amazon
        /// FSx. Use the API of the relevant service to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceDoesNotSupportTaggingException">
        /// The resource specified does not support tagging.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceNotFoundException">
        /// The resource specified by the Amazon Resource Name (ARN) can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFileSystem


        /// <summary>
        /// Use this operation to update the configuration of an existing Amazon FSx file system.
        /// You can update multiple properties in a single request.
        /// 
        ///  
        /// <para>
        /// For Amazon FSx for Windows File Server file systems, you can update the following
        /// properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AutomaticBackupRetentionDays
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DailyAutomaticBackupStartTime
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SelfManagedActiveDirectoryConfiguration
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// StorageCapacity
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ThroughputCapacity
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WeeklyMaintenanceStartTime
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For Amazon FSx for Lustre file systems, you can update the following properties:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AutoImportPolicy
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AutomaticBackupRetentionDays
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DailyAutomaticBackupStartTime
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// StorageCapacity
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WeeklyMaintenanceStartTime
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFileSystem service method.</param>
        /// 
        /// <returns>The response from the UpdateFileSystem service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.MissingFileSystemConfigurationException">
        /// A file system configuration is required for this operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting AWS Support.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.UnsupportedOperationException">
        /// The requested operation is not supported for this resource or API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateFileSystem">REST API Reference for UpdateFileSystem Operation</seealso>
        UpdateFileSystemResponse UpdateFileSystem(UpdateFileSystemRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFileSystem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFileSystem operation on AmazonFSxClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFileSystem
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateFileSystem">REST API Reference for UpdateFileSystem Operation</seealso>
        IAsyncResult BeginUpdateFileSystem(UpdateFileSystemRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFileSystem operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFileSystem.</param>
        /// 
        /// <returns>Returns a  UpdateFileSystemResult from FSx.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateFileSystem">REST API Reference for UpdateFileSystem Operation</seealso>
        UpdateFileSystemResponse EndUpdateFileSystem(IAsyncResult asyncResult);

        #endregion
        
    }
}