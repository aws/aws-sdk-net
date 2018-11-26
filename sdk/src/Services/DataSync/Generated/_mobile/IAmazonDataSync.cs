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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DataSync.Model;

namespace Amazon.DataSync
{
    /// <summary>
    /// Interface for accessing DataSync
    ///
    /// AWS DataSync 
    /// <para>
    /// AWS DataSync is a managed data transfer service that makes it simpler for you to automate
    /// moving data between on-premises storage and Amazon Simple Storage Service (Amazon
    /// S3) or Amazon Elastic File System (Amazon EFS). 
    /// </para>
    ///  
    /// <para>
    /// This API interface reference for AWS DataSync contains documentation for a programming
    /// interface that you can use to manage AWS DataSync.
    /// </para>
    /// </summary>
    public partial interface IAmazonDataSync : IAmazonService, IDisposable
    {
                
        #region  CancelTaskExecution


        /// <summary>
        /// Initiates the asynchronous execution of the CancelTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelTaskExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CancelTaskExecution">REST API Reference for CancelTaskExecution Operation</seealso>
        Task<CancelTaskExecutionResponse> CancelTaskExecutionAsync(CancelTaskExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAgent


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAgent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateAgent">REST API Reference for CreateAgent Operation</seealso>
        Task<CreateAgentResponse> CreateAgentAsync(CreateAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLocationEfs


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLocationEfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationEfs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationEfs">REST API Reference for CreateLocationEfs Operation</seealso>
        Task<CreateLocationEfsResponse> CreateLocationEfsAsync(CreateLocationEfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLocationNfs


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLocationNfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationNfs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationNfs">REST API Reference for CreateLocationNfs Operation</seealso>
        Task<CreateLocationNfsResponse> CreateLocationNfsAsync(CreateLocationNfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLocationS3


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLocationS3 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLocationS3 operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateLocationS3">REST API Reference for CreateLocationS3 Operation</seealso>
        Task<CreateLocationS3Response> CreateLocationS3Async(CreateLocationS3Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTask


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/CreateTask">REST API Reference for CreateTask Operation</seealso>
        Task<CreateTaskResponse> CreateTaskAsync(CreateTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAgent


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteAgent">REST API Reference for DeleteAgent Operation</seealso>
        Task<DeleteAgentResponse> DeleteAgentAsync(DeleteAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLocation


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLocation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteLocation">REST API Reference for DeleteLocation Operation</seealso>
        Task<DeleteLocationResponse> DeleteLocationAsync(DeleteLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTask


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DeleteTask">REST API Reference for DeleteTask Operation</seealso>
        Task<DeleteTaskResponse> DeleteTaskAsync(DeleteTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAgent


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAgent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeAgent">REST API Reference for DescribeAgent Operation</seealso>
        Task<DescribeAgentResponse> DescribeAgentAsync(DescribeAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLocationEfs


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocationEfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationEfs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationEfs">REST API Reference for DescribeLocationEfs Operation</seealso>
        Task<DescribeLocationEfsResponse> DescribeLocationEfsAsync(DescribeLocationEfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLocationNfs


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocationNfs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationNfs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationNfs">REST API Reference for DescribeLocationNfs Operation</seealso>
        Task<DescribeLocationNfsResponse> DescribeLocationNfsAsync(DescribeLocationNfsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLocationS3


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocationS3 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocationS3 operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeLocationS3">REST API Reference for DescribeLocationS3 Operation</seealso>
        Task<DescribeLocationS3Response> DescribeLocationS3Async(DescribeLocationS3Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTask


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTask">REST API Reference for DescribeTask Operation</seealso>
        Task<DescribeTaskResponse> DescribeTaskAsync(DescribeTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTaskExecution


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTaskExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/DescribeTaskExecution">REST API Reference for DescribeTaskExecution Operation</seealso>
        Task<DescribeTaskExecutionResponse> DescribeTaskExecutionAsync(DescribeTaskExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAgents


        /// <summary>
        /// Initiates the asynchronous execution of the ListAgents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAgents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListAgents">REST API Reference for ListAgents Operation</seealso>
        Task<ListAgentsResponse> ListAgentsAsync(ListAgentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListLocations


        /// <summary>
        /// Initiates the asynchronous execution of the ListLocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLocations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListLocations">REST API Reference for ListLocations Operation</seealso>
        Task<ListLocationsResponse> ListLocationsAsync(ListLocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTaskExecutions


        /// <summary>
        /// Initiates the asynchronous execution of the ListTaskExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTaskExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTaskExecutions">REST API Reference for ListTaskExecutions Operation</seealso>
        Task<ListTaskExecutionsResponse> ListTaskExecutionsAsync(ListTaskExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTasks


        /// <summary>
        /// Initiates the asynchronous execution of the ListTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/ListTasks">REST API Reference for ListTasks Operation</seealso>
        Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartTaskExecution


        /// <summary>
        /// Initiates the asynchronous execution of the StartTaskExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTaskExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/StartTaskExecution">REST API Reference for StartTaskExecution Operation</seealso>
        Task<StartTaskExecutionResponse> StartTaskExecutionAsync(StartTaskExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource


        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource


        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAgent


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAgent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateAgent">REST API Reference for UpdateAgent Operation</seealso>
        Task<UpdateAgentResponse> UpdateAgentAsync(UpdateAgentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTask


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/datasync-2018-11-09/UpdateTask">REST API Reference for UpdateTask Operation</seealso>
        Task<UpdateTaskResponse> UpdateTaskAsync(UpdateTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}