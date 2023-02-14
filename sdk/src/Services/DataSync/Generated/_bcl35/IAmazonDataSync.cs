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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DataSync.Model;

namespace Amazon.DataSync
{
    /// <summary>
    /// Interface for accessing DataSync
    ///
    /// DataSync 
    /// <para>
    /// DataSync is a managed data transfer service that makes it simpler for you to automate
    /// moving data between on-premises storage and Amazon Web Services storage services.
    /// You also can use DataSync to transfer data between other cloud providers and Amazon
    /// Web Services storage services.
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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IDataSyncPaginatorFactory Paginators { get; }
#endif


        
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
        /// Initiates the asynchronous execution of the CancelTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelTaskExecution operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelTaskExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CancelTaskExecution">REST API Reference for CancelTaskExecution Operation</seealso>
        IAsyncResult BeginCancelTaskExecution(CancelTaskExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelTaskExecution.</param>
        /// 
        /// <returns>Returns a  CancelTaskExecutionResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CancelTaskExecution">REST API Reference for CancelTaskExecution Operation</seealso>
        CancelTaskExecutionResponse EndCancelTaskExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAgent


        /// <summary>
        /// Activates an DataSync agent that you have deployed in your storage environment. The
        /// activation process associates your agent with your account. In the activation process,
        /// you specify information such as the Amazon Web Services Region that you want to activate
        /// the agent in. You activate the agent in the Amazon Web Services Region where your
        /// target locations (in Amazon S3 or Amazon EFS) reside. Your tasks are created in this
        /// Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        /// You can activate the agent in a VPC (virtual private cloud) or provide the agent access
        /// to a VPC endpoint so you can run tasks without going over the public internet.
        /// </para>
        ///  
        /// <para>
        /// You can use an agent for more than one location. If a task uses multiple agents, all
        /// of them need to have status AVAILABLE for the task to run. If you use multiple agents
        /// for a source location, the status of all the agents must be AVAILABLE for the task
        /// to run. 
        /// </para>
        ///  
        /// <para>
        /// Agents are automatically updated by Amazon Web Services on a regular basis, using
        /// a mechanism that ensures minimal interruption to your tasks.
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
        /// Initiates the asynchronous execution of the CreateAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAgent operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateAgent">REST API Reference for CreateAgent Operation</seealso>
        IAsyncResult BeginCreateAgent(CreateAgentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAgent.</param>
        /// 
        /// <returns>Returns a  CreateAgentResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateAgent">REST API Reference for CreateAgent Operation</seealso>
        CreateAgentResponse EndCreateAgent(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLocationEfs


        /// <summary>
        /// Creates an endpoint for an Amazon EFS file system that DataSync can access for a transfer.
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-efs-location.html">Creating
        /// a location for Amazon EFS</a>.
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
        /// Initiates the asynchronous execution of the CreateLocationEfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationEfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLocationEfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationEfs">REST API Reference for CreateLocationEfs Operation</seealso>
        IAsyncResult BeginCreateLocationEfs(CreateLocationEfsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLocationEfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLocationEfs.</param>
        /// 
        /// <returns>Returns a  CreateLocationEfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationEfs">REST API Reference for CreateLocationEfs Operation</seealso>
        CreateLocationEfsResponse EndCreateLocationEfs(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLocationFsxLustre


        /// <summary>
        /// Creates an endpoint for an Amazon FSx for Lustre file system.
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
        /// Initiates the asynchronous execution of the CreateLocationFsxLustre operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxLustre operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLocationFsxLustre
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxLustre">REST API Reference for CreateLocationFsxLustre Operation</seealso>
        IAsyncResult BeginCreateLocationFsxLustre(CreateLocationFsxLustreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLocationFsxLustre operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLocationFsxLustre.</param>
        /// 
        /// <returns>Returns a  CreateLocationFsxLustreResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxLustre">REST API Reference for CreateLocationFsxLustre Operation</seealso>
        CreateLocationFsxLustreResponse EndCreateLocationFsxLustre(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLocationFsxOntap


        /// <summary>
        /// Creates an endpoint for an Amazon FSx for NetApp ONTAP file system that DataSync can
        /// access for a transfer. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-ontap-location.html">Creating
        /// a location for FSx for ONTAP</a>.
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
        /// Initiates the asynchronous execution of the CreateLocationFsxOntap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxOntap operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLocationFsxOntap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxOntap">REST API Reference for CreateLocationFsxOntap Operation</seealso>
        IAsyncResult BeginCreateLocationFsxOntap(CreateLocationFsxOntapRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLocationFsxOntap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLocationFsxOntap.</param>
        /// 
        /// <returns>Returns a  CreateLocationFsxOntapResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxOntap">REST API Reference for CreateLocationFsxOntap Operation</seealso>
        CreateLocationFsxOntapResponse EndCreateLocationFsxOntap(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLocationFsxOpenZfs


        /// <summary>
        /// Creates an endpoint for an Amazon FSx for OpenZFS file system that DataSync can access
        /// for a transfer. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-openzfs-location.html">Creating
        /// a location for FSx for OpenZFS</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Request parameters related to <code>SMB</code> aren't supported with the <code>CreateLocationFsxOpenZfs</code>
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
        /// Initiates the asynchronous execution of the CreateLocationFsxOpenZfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxOpenZfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLocationFsxOpenZfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxOpenZfs">REST API Reference for CreateLocationFsxOpenZfs Operation</seealso>
        IAsyncResult BeginCreateLocationFsxOpenZfs(CreateLocationFsxOpenZfsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLocationFsxOpenZfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLocationFsxOpenZfs.</param>
        /// 
        /// <returns>Returns a  CreateLocationFsxOpenZfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxOpenZfs">REST API Reference for CreateLocationFsxOpenZfs Operation</seealso>
        CreateLocationFsxOpenZfsResponse EndCreateLocationFsxOpenZfs(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLocationFsxWindows


        /// <summary>
        /// Creates an endpoint for an Amazon FSx for Windows File Server file system.
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
        /// Initiates the asynchronous execution of the CreateLocationFsxWindows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationFsxWindows operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLocationFsxWindows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxWindows">REST API Reference for CreateLocationFsxWindows Operation</seealso>
        IAsyncResult BeginCreateLocationFsxWindows(CreateLocationFsxWindowsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLocationFsxWindows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLocationFsxWindows.</param>
        /// 
        /// <returns>Returns a  CreateLocationFsxWindowsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationFsxWindows">REST API Reference for CreateLocationFsxWindows Operation</seealso>
        CreateLocationFsxWindowsResponse EndCreateLocationFsxWindows(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLocationHdfs


        /// <summary>
        /// Creates an endpoint for a Hadoop Distributed File System (HDFS).
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
        /// Initiates the asynchronous execution of the CreateLocationHdfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationHdfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLocationHdfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationHdfs">REST API Reference for CreateLocationHdfs Operation</seealso>
        IAsyncResult BeginCreateLocationHdfs(CreateLocationHdfsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLocationHdfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLocationHdfs.</param>
        /// 
        /// <returns>Returns a  CreateLocationHdfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationHdfs">REST API Reference for CreateLocationHdfs Operation</seealso>
        CreateLocationHdfsResponse EndCreateLocationHdfs(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLocationNfs


        /// <summary>
        /// Defines a file system on a Network File System (NFS) server that can be read from
        /// or written to.
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
        /// Initiates the asynchronous execution of the CreateLocationNfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationNfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLocationNfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationNfs">REST API Reference for CreateLocationNfs Operation</seealso>
        IAsyncResult BeginCreateLocationNfs(CreateLocationNfsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLocationNfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLocationNfs.</param>
        /// 
        /// <returns>Returns a  CreateLocationNfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationNfs">REST API Reference for CreateLocationNfs Operation</seealso>
        CreateLocationNfsResponse EndCreateLocationNfs(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLocationObjectStorage


        /// <summary>
        /// Creates an endpoint for an object storage system that DataSync can access for a transfer.
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-object-location.html">Creating
        /// a location for object storage</a>.
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
        /// Initiates the asynchronous execution of the CreateLocationObjectStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationObjectStorage operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLocationObjectStorage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationObjectStorage">REST API Reference for CreateLocationObjectStorage Operation</seealso>
        IAsyncResult BeginCreateLocationObjectStorage(CreateLocationObjectStorageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLocationObjectStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLocationObjectStorage.</param>
        /// 
        /// <returns>Returns a  CreateLocationObjectStorageResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationObjectStorage">REST API Reference for CreateLocationObjectStorage Operation</seealso>
        CreateLocationObjectStorageResponse EndCreateLocationObjectStorage(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLocationS3


        /// <summary>
        /// Creates an endpoint for an Amazon S3 bucket that DataSync can access for a transfer.
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-locations-cli.html#create-location-s3-cli">Create
        /// an Amazon S3 location</a>.
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
        /// Initiates the asynchronous execution of the CreateLocationS3 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationS3 operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLocationS3
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationS3">REST API Reference for CreateLocationS3 Operation</seealso>
        IAsyncResult BeginCreateLocationS3(CreateLocationS3Request request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLocationS3 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLocationS3.</param>
        /// 
        /// <returns>Returns a  CreateLocationS3Result from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationS3">REST API Reference for CreateLocationS3 Operation</seealso>
        CreateLocationS3Response EndCreateLocationS3(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLocationSmb


        /// <summary>
        /// Creates an endpoint for a Server Message Block (SMB) file server that DataSync can
        /// access for a transfer. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-smb-location.html">Creating
        /// an SMB location</a>.
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
        /// Initiates the asynchronous execution of the CreateLocationSmb operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationSmb operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLocationSmb
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationSmb">REST API Reference for CreateLocationSmb Operation</seealso>
        IAsyncResult BeginCreateLocationSmb(CreateLocationSmbRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLocationSmb operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLocationSmb.</param>
        /// 
        /// <returns>Returns a  CreateLocationSmbResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationSmb">REST API Reference for CreateLocationSmb Operation</seealso>
        CreateLocationSmbResponse EndCreateLocationSmb(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTask


        /// <summary>
        /// Configures a task, which defines where and how DataSync transfers your data.
        /// 
        ///  
        /// <para>
        /// A task includes a source location, a destination location, and the preferences for
        /// how and when you want to transfer your data (such as bandwidth limits, scheduling,
        /// among other options).
        /// </para>
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
        /// Initiates the asynchronous execution of the CreateTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTask operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateTask">REST API Reference for CreateTask Operation</seealso>
        IAsyncResult BeginCreateTask(CreateTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTask.</param>
        /// 
        /// <returns>Returns a  CreateTaskResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateTask">REST API Reference for CreateTask Operation</seealso>
        CreateTaskResponse EndCreateTask(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAgent


        /// <summary>
        /// Deletes an agent. To specify which agent to delete, use the Amazon Resource Name (ARN)
        /// of the agent in your request. The operation disassociates the agent from your Amazon
        /// Web Services account. However, it doesn't delete the agent virtual machine (VM) from
        /// your on-premises environment.
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
        /// Initiates the asynchronous execution of the DeleteAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgent operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteAgent">REST API Reference for DeleteAgent Operation</seealso>
        IAsyncResult BeginDeleteAgent(DeleteAgentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAgent.</param>
        /// 
        /// <returns>Returns a  DeleteAgentResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteAgent">REST API Reference for DeleteAgent Operation</seealso>
        DeleteAgentResponse EndDeleteAgent(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLocation


        /// <summary>
        /// Deletes the configuration of a location used by DataSync.
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
        /// Initiates the asynchronous execution of the DeleteLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLocation operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLocation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteLocation">REST API Reference for DeleteLocation Operation</seealso>
        IAsyncResult BeginDeleteLocation(DeleteLocationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLocation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLocation.</param>
        /// 
        /// <returns>Returns a  DeleteLocationResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteLocation">REST API Reference for DeleteLocation Operation</seealso>
        DeleteLocationResponse EndDeleteLocation(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTask


        /// <summary>
        /// Deletes an DataSync task.
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
        /// Initiates the asynchronous execution of the DeleteTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTask operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteTask">REST API Reference for DeleteTask Operation</seealso>
        IAsyncResult BeginDeleteTask(DeleteTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTask.</param>
        /// 
        /// <returns>Returns a  DeleteTaskResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteTask">REST API Reference for DeleteTask Operation</seealso>
        DeleteTaskResponse EndDeleteTask(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAgent


        /// <summary>
        /// Returns metadata about an DataSync agent, such as its name, endpoint type, and status.
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
        /// Initiates the asynchronous execution of the DescribeAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgent operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeAgent">REST API Reference for DescribeAgent Operation</seealso>
        IAsyncResult BeginDescribeAgent(DescribeAgentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAgent.</param>
        /// 
        /// <returns>Returns a  DescribeAgentResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeAgent">REST API Reference for DescribeAgent Operation</seealso>
        DescribeAgentResponse EndDescribeAgent(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLocationEfs


        /// <summary>
        /// Returns metadata about your DataSync location for an Amazon EFS file system.
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
        /// Initiates the asynchronous execution of the DescribeLocationEfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationEfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocationEfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationEfs">REST API Reference for DescribeLocationEfs Operation</seealso>
        IAsyncResult BeginDescribeLocationEfs(DescribeLocationEfsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocationEfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocationEfs.</param>
        /// 
        /// <returns>Returns a  DescribeLocationEfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationEfs">REST API Reference for DescribeLocationEfs Operation</seealso>
        DescribeLocationEfsResponse EndDescribeLocationEfs(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLocationFsxLustre


        /// <summary>
        /// Provides details about how an DataSync location for an Amazon FSx for Lustre file
        /// system is configured.
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
        /// Initiates the asynchronous execution of the DescribeLocationFsxLustre operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxLustre operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocationFsxLustre
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxLustre">REST API Reference for DescribeLocationFsxLustre Operation</seealso>
        IAsyncResult BeginDescribeLocationFsxLustre(DescribeLocationFsxLustreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocationFsxLustre operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocationFsxLustre.</param>
        /// 
        /// <returns>Returns a  DescribeLocationFsxLustreResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxLustre">REST API Reference for DescribeLocationFsxLustre Operation</seealso>
        DescribeLocationFsxLustreResponse EndDescribeLocationFsxLustre(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLocationFsxOntap


        /// <summary>
        /// Provides details about how an DataSync location for an Amazon FSx for NetApp ONTAP
        /// file system is configured.
        /// 
        ///  <note> 
        /// <para>
        /// If your location uses SMB, the <code>DescribeLocationFsxOntap</code> operation doesn't
        /// actually return a <code>Password</code>.
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
        /// Initiates the asynchronous execution of the DescribeLocationFsxOntap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxOntap operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocationFsxOntap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxOntap">REST API Reference for DescribeLocationFsxOntap Operation</seealso>
        IAsyncResult BeginDescribeLocationFsxOntap(DescribeLocationFsxOntapRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocationFsxOntap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocationFsxOntap.</param>
        /// 
        /// <returns>Returns a  DescribeLocationFsxOntapResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxOntap">REST API Reference for DescribeLocationFsxOntap Operation</seealso>
        DescribeLocationFsxOntapResponse EndDescribeLocationFsxOntap(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLocationFsxOpenZfs


        /// <summary>
        /// Provides details about how an DataSync location for an Amazon FSx for OpenZFS file
        /// system is configured.
        /// 
        ///  <note> 
        /// <para>
        /// Response elements related to <code>SMB</code> aren't supported with the <code>DescribeLocationFsxOpenZfs</code>
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
        /// Initiates the asynchronous execution of the DescribeLocationFsxOpenZfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxOpenZfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocationFsxOpenZfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxOpenZfs">REST API Reference for DescribeLocationFsxOpenZfs Operation</seealso>
        IAsyncResult BeginDescribeLocationFsxOpenZfs(DescribeLocationFsxOpenZfsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocationFsxOpenZfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocationFsxOpenZfs.</param>
        /// 
        /// <returns>Returns a  DescribeLocationFsxOpenZfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxOpenZfs">REST API Reference for DescribeLocationFsxOpenZfs Operation</seealso>
        DescribeLocationFsxOpenZfsResponse EndDescribeLocationFsxOpenZfs(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLocationFsxWindows


        /// <summary>
        /// Returns metadata about an Amazon FSx for Windows File Server location, such as information
        /// about its path.
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
        /// Initiates the asynchronous execution of the DescribeLocationFsxWindows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationFsxWindows operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocationFsxWindows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxWindows">REST API Reference for DescribeLocationFsxWindows Operation</seealso>
        IAsyncResult BeginDescribeLocationFsxWindows(DescribeLocationFsxWindowsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocationFsxWindows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocationFsxWindows.</param>
        /// 
        /// <returns>Returns a  DescribeLocationFsxWindowsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationFsxWindows">REST API Reference for DescribeLocationFsxWindows Operation</seealso>
        DescribeLocationFsxWindowsResponse EndDescribeLocationFsxWindows(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLocationHdfs


        /// <summary>
        /// Returns metadata, such as the authentication information about the Hadoop Distributed
        /// File System (HDFS) location.
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
        /// Initiates the asynchronous execution of the DescribeLocationHdfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationHdfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocationHdfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationHdfs">REST API Reference for DescribeLocationHdfs Operation</seealso>
        IAsyncResult BeginDescribeLocationHdfs(DescribeLocationHdfsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocationHdfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocationHdfs.</param>
        /// 
        /// <returns>Returns a  DescribeLocationHdfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationHdfs">REST API Reference for DescribeLocationHdfs Operation</seealso>
        DescribeLocationHdfsResponse EndDescribeLocationHdfs(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLocationNfs


        /// <summary>
        /// Returns metadata, such as the path information, about an NFS location.
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
        /// Initiates the asynchronous execution of the DescribeLocationNfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationNfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocationNfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationNfs">REST API Reference for DescribeLocationNfs Operation</seealso>
        IAsyncResult BeginDescribeLocationNfs(DescribeLocationNfsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocationNfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocationNfs.</param>
        /// 
        /// <returns>Returns a  DescribeLocationNfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationNfs">REST API Reference for DescribeLocationNfs Operation</seealso>
        DescribeLocationNfsResponse EndDescribeLocationNfs(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLocationObjectStorage


        /// <summary>
        /// Returns metadata about your DataSync location for an object storage system.
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
        /// Initiates the asynchronous execution of the DescribeLocationObjectStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationObjectStorage operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocationObjectStorage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationObjectStorage">REST API Reference for DescribeLocationObjectStorage Operation</seealso>
        IAsyncResult BeginDescribeLocationObjectStorage(DescribeLocationObjectStorageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocationObjectStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocationObjectStorage.</param>
        /// 
        /// <returns>Returns a  DescribeLocationObjectStorageResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationObjectStorage">REST API Reference for DescribeLocationObjectStorage Operation</seealso>
        DescribeLocationObjectStorageResponse EndDescribeLocationObjectStorage(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLocationS3


        /// <summary>
        /// Returns metadata, such as bucket name, about an Amazon S3 bucket location.
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
        /// Initiates the asynchronous execution of the DescribeLocationS3 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationS3 operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocationS3
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationS3">REST API Reference for DescribeLocationS3 Operation</seealso>
        IAsyncResult BeginDescribeLocationS3(DescribeLocationS3Request request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocationS3 operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocationS3.</param>
        /// 
        /// <returns>Returns a  DescribeLocationS3Result from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationS3">REST API Reference for DescribeLocationS3 Operation</seealso>
        DescribeLocationS3Response EndDescribeLocationS3(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLocationSmb


        /// <summary>
        /// Returns metadata, such as the path and user information about an SMB location.
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
        /// Initiates the asynchronous execution of the DescribeLocationSmb operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationSmb operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocationSmb
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationSmb">REST API Reference for DescribeLocationSmb Operation</seealso>
        IAsyncResult BeginDescribeLocationSmb(DescribeLocationSmbRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLocationSmb operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocationSmb.</param>
        /// 
        /// <returns>Returns a  DescribeLocationSmbResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationSmb">REST API Reference for DescribeLocationSmb Operation</seealso>
        DescribeLocationSmbResponse EndDescribeLocationSmb(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTask


        /// <summary>
        /// Returns metadata about a task.
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
        /// Initiates the asynchronous execution of the DescribeTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTask operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTask">REST API Reference for DescribeTask Operation</seealso>
        IAsyncResult BeginDescribeTask(DescribeTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTask.</param>
        /// 
        /// <returns>Returns a  DescribeTaskResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTask">REST API Reference for DescribeTask Operation</seealso>
        DescribeTaskResponse EndDescribeTask(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTaskExecution


        /// <summary>
        /// Returns detailed metadata about a task that is being executed.
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
        /// Initiates the asynchronous execution of the DescribeTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskExecution operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTaskExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTaskExecution">REST API Reference for DescribeTaskExecution Operation</seealso>
        IAsyncResult BeginDescribeTaskExecution(DescribeTaskExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTaskExecution.</param>
        /// 
        /// <returns>Returns a  DescribeTaskExecutionResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTaskExecution">REST API Reference for DescribeTaskExecution Operation</seealso>
        DescribeTaskExecutionResponse EndDescribeTaskExecution(IAsyncResult asyncResult);

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
        ///  <code>ListAgents</code> is eventually consistent. This means the result of running
        /// the operation might not reflect that you just created or deleted an agent. For example,
        /// if you create an agent with <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_CreateAgent.html">CreateAgent</a>
        /// and then immediately run <code>ListAgents</code>, that agent might not show up in
        /// the list right away. In situations like this, you can always confirm whether an agent
        /// has been created (or deleted) by using <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_DescribeAgent.html">DescribeAgent</a>.
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
        /// Initiates the asynchronous execution of the ListAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgents operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAgents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListAgents">REST API Reference for ListAgents Operation</seealso>
        IAsyncResult BeginListAgents(ListAgentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAgents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAgents.</param>
        /// 
        /// <returns>Returns a  ListAgentsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListAgents">REST API Reference for ListAgents Operation</seealso>
        ListAgentsResponse EndListAgents(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListLocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLocations operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLocations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListLocations">REST API Reference for ListLocations Operation</seealso>
        IAsyncResult BeginListLocations(ListLocationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLocations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLocations.</param>
        /// 
        /// <returns>Returns a  ListLocationsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListLocations">REST API Reference for ListLocations Operation</seealso>
        ListLocationsResponse EndListLocations(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTaskExecutions


        /// <summary>
        /// Returns a list of executed tasks.
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
        /// Initiates the asynchronous execution of the ListTaskExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTaskExecutions operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTaskExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTaskExecutions">REST API Reference for ListTaskExecutions Operation</seealso>
        IAsyncResult BeginListTaskExecutions(ListTaskExecutionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTaskExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTaskExecutions.</param>
        /// 
        /// <returns>Returns a  ListTaskExecutionsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTaskExecutions">REST API Reference for ListTaskExecutions Operation</seealso>
        ListTaskExecutionsResponse EndListTaskExecutions(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTasks operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTasks">REST API Reference for ListTasks Operation</seealso>
        IAsyncResult BeginListTasks(ListTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTasks.</param>
        /// 
        /// <returns>Returns a  ListTasksResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTasks">REST API Reference for ListTasks Operation</seealso>
        ListTasksResponse EndListTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  StartTaskExecution


        /// <summary>
        /// Starts an DataSync task. For each task, you can only run one task execution at a time.
        /// 
        ///  
        /// <para>
        /// There are several phases to a task execution. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/working-with-task-executions.html#understand-task-execution-statuses">Task
        /// execution statuses</a>.
        /// </para>
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
        /// Initiates the asynchronous execution of the StartTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTaskExecution operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTaskExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/StartTaskExecution">REST API Reference for StartTaskExecution Operation</seealso>
        IAsyncResult BeginStartTaskExecution(StartTaskExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTaskExecution.</param>
        /// 
        /// <returns>Returns a  StartTaskExecutionResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/StartTaskExecution">REST API Reference for StartTaskExecution Operation</seealso>
        StartTaskExecutionResponse EndStartTaskExecution(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAgent


        /// <summary>
        /// Updates the name of an agent.
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
        /// Initiates the asynchronous execution of the UpdateAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgent operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAgent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateAgent">REST API Reference for UpdateAgent Operation</seealso>
        IAsyncResult BeginUpdateAgent(UpdateAgentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAgent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAgent.</param>
        /// 
        /// <returns>Returns a  UpdateAgentResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateAgent">REST API Reference for UpdateAgent Operation</seealso>
        UpdateAgentResponse EndUpdateAgent(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateLocationHdfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationHdfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLocationHdfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationHdfs">REST API Reference for UpdateLocationHdfs Operation</seealso>
        IAsyncResult BeginUpdateLocationHdfs(UpdateLocationHdfsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLocationHdfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLocationHdfs.</param>
        /// 
        /// <returns>Returns a  UpdateLocationHdfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationHdfs">REST API Reference for UpdateLocationHdfs Operation</seealso>
        UpdateLocationHdfsResponse EndUpdateLocationHdfs(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLocationNfs


        /// <summary>
        /// Updates some of the parameters of a previously created location for Network File System
        /// (NFS) access. For information about creating an NFS location, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-nfs-location.html">Creating
        /// a location for NFS</a>.
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
        /// Initiates the asynchronous execution of the UpdateLocationNfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationNfs operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLocationNfs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationNfs">REST API Reference for UpdateLocationNfs Operation</seealso>
        IAsyncResult BeginUpdateLocationNfs(UpdateLocationNfsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLocationNfs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLocationNfs.</param>
        /// 
        /// <returns>Returns a  UpdateLocationNfsResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationNfs">REST API Reference for UpdateLocationNfs Operation</seealso>
        UpdateLocationNfsResponse EndUpdateLocationNfs(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLocationObjectStorage


        /// <summary>
        /// Updates some parameters of an existing object storage location that DataSync accesses
        /// for a transfer. For information about creating a self-managed object storage location,
        /// see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-object-location.html">Creating
        /// a location for object storage</a>.
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
        /// Initiates the asynchronous execution of the UpdateLocationObjectStorage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationObjectStorage operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLocationObjectStorage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationObjectStorage">REST API Reference for UpdateLocationObjectStorage Operation</seealso>
        IAsyncResult BeginUpdateLocationObjectStorage(UpdateLocationObjectStorageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLocationObjectStorage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLocationObjectStorage.</param>
        /// 
        /// <returns>Returns a  UpdateLocationObjectStorageResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationObjectStorage">REST API Reference for UpdateLocationObjectStorage Operation</seealso>
        UpdateLocationObjectStorageResponse EndUpdateLocationObjectStorage(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLocationSmb


        /// <summary>
        /// Updates some of the parameters of a previously created location for Server Message
        /// Block (SMB) file system access. For information about creating an SMB location, see
        /// <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-smb-location.html">Creating
        /// a location for SMB</a>.
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
        /// Initiates the asynchronous execution of the UpdateLocationSmb operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLocationSmb operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLocationSmb
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationSmb">REST API Reference for UpdateLocationSmb Operation</seealso>
        IAsyncResult BeginUpdateLocationSmb(UpdateLocationSmbRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLocationSmb operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLocationSmb.</param>
        /// 
        /// <returns>Returns a  UpdateLocationSmbResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateLocationSmb">REST API Reference for UpdateLocationSmb Operation</seealso>
        UpdateLocationSmbResponse EndUpdateLocationSmb(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTask


        /// <summary>
        /// Updates the metadata associated with a task.
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
        /// Initiates the asynchronous execution of the UpdateTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTask operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateTask">REST API Reference for UpdateTask Operation</seealso>
        IAsyncResult BeginUpdateTask(UpdateTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTask.</param>
        /// 
        /// <returns>Returns a  UpdateTaskResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateTask">REST API Reference for UpdateTask Operation</seealso>
        UpdateTaskResponse EndUpdateTask(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTaskExecution


        /// <summary>
        /// Updates execution of a task.
        /// 
        ///  
        /// <para>
        /// You can modify bandwidth throttling for a task execution that is running or queued.
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/working-with-task-executions.html#adjust-bandwidth-throttling">Adjusting
        /// Bandwidth Throttling for a Task Execution</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The only <code>Option</code> that can be modified by <code>UpdateTaskExecution</code>
        /// is <code> <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_Options.html#DataSync-Type-Options-BytesPerSecond">BytesPerSecond</a>
        /// </code>.
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
        /// Initiates the asynchronous execution of the UpdateTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTaskExecution operation on AmazonDataSyncClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTaskExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateTaskExecution">REST API Reference for UpdateTaskExecution Operation</seealso>
        IAsyncResult BeginUpdateTaskExecution(UpdateTaskExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTaskExecution.</param>
        /// 
        /// <returns>Returns a  UpdateTaskExecutionResult from DataSync.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateTaskExecution">REST API Reference for UpdateTaskExecution Operation</seealso>
        UpdateTaskExecutionResponse EndUpdateTaskExecution(IAsyncResult asyncResult);

        #endregion
        
    }
}