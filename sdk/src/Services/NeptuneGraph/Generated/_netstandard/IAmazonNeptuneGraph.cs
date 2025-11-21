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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.NeptuneGraph.Model;

#pragma warning disable CS1570
namespace Amazon.NeptuneGraph
{
    /// <summary>
    /// <para>Interface for accessing NeptuneGraph</para>
    ///
    /// Neptune Analytics is a new analytics database engine for Amazon Neptune that helps
    /// customers get to insights faster by quickly processing large amounts of graph data,
    /// invoking popular graph analytic algorithms in low-latency queries, and getting analytics
    /// results in seconds.
    /// </summary>
    public partial interface IAmazonNeptuneGraph : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        INeptuneGraphPaginatorFactory Paginators { get; }
#endif
                
        #region  CancelExportTask



        /// <summary>
        /// Cancel the specified export task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelExportTask service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
        Task<CancelExportTaskResponse> CancelExportTaskAsync(CancelExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelImportTask



        /// <summary>
        /// Deletes the specified import task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelImportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelImportTask service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CancelImportTask">REST API Reference for CancelImportTask Operation</seealso>
        Task<CancelImportTaskResponse> CancelImportTaskAsync(CancelImportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelQuery



        /// <summary>
        /// Cancels a specified query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelQuery service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CancelQuery">REST API Reference for CancelQuery Operation</seealso>
        Task<CancelQueryResponse> CancelQueryAsync(CancelQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGraph



        /// <summary>
        /// Creates a new Neptune Analytics graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGraph service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CreateGraph">REST API Reference for CreateGraph Operation</seealso>
        Task<CreateGraphResponse> CreateGraphAsync(CreateGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGraphSnapshot



        /// <summary>
        /// Creates a snapshot of the specific graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGraphSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGraphSnapshot service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CreateGraphSnapshot">REST API Reference for CreateGraphSnapshot Operation</seealso>
        Task<CreateGraphSnapshotResponse> CreateGraphSnapshotAsync(CreateGraphSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGraphUsingImportTask



        /// <summary>
        /// Creates a new Neptune Analytics graph and imports data into it, either from Amazon
        /// Simple Storage Service (S3) or from a Neptune database or a Neptune database snapshot.
        /// 
        ///  
        /// <para>
        /// The data can be loaded from files in S3 that in either the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load-tutorial-format-gremlin.html">Gremlin
        /// CSV format</a> or the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/bulk-load-tutorial-format-opencypher.html">openCypher
        /// load format</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGraphUsingImportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGraphUsingImportTask service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CreateGraphUsingImportTask">REST API Reference for CreateGraphUsingImportTask Operation</seealso>
        Task<CreateGraphUsingImportTaskResponse> CreateGraphUsingImportTaskAsync(CreateGraphUsingImportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePrivateGraphEndpoint



        /// <summary>
        /// Create a private graph endpoint to allow private access from to the graph from within
        /// a VPC. You can attach security groups to the private graph endpoint.
        /// 
        ///  <note> 
        /// <para>
        /// VPC endpoint charges apply.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateGraphEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePrivateGraphEndpoint service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/CreatePrivateGraphEndpoint">REST API Reference for CreatePrivateGraphEndpoint Operation</seealso>
        Task<CreatePrivateGraphEndpointResponse> CreatePrivateGraphEndpointAsync(CreatePrivateGraphEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGraph



        /// <summary>
        /// Deletes the specified graph. Graphs cannot be deleted if delete-protection is enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGraph service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/DeleteGraph">REST API Reference for DeleteGraph Operation</seealso>
        Task<DeleteGraphResponse> DeleteGraphAsync(DeleteGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGraphSnapshot



        /// <summary>
        /// Deletes the specifed graph snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGraphSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGraphSnapshot service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/DeleteGraphSnapshot">REST API Reference for DeleteGraphSnapshot Operation</seealso>
        Task<DeleteGraphSnapshotResponse> DeleteGraphSnapshotAsync(DeleteGraphSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePrivateGraphEndpoint



        /// <summary>
        /// Deletes a private graph endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrivateGraphEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePrivateGraphEndpoint service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/DeletePrivateGraphEndpoint">REST API Reference for DeletePrivateGraphEndpoint Operation</seealso>
        Task<DeletePrivateGraphEndpointResponse> DeletePrivateGraphEndpointAsync(DeletePrivateGraphEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExecuteQuery



        /// <summary>
        /// Execute an openCypher query.
        /// 
        ///  
        /// <para>
        ///  When invoking this operation in a Neptune Analytics cluster, the IAM user or role
        /// making the request must have a policy attached that allows one of the following IAM
        /// actions in that cluster, depending on the query: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// neptune-graph:ReadDataViaQuery
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// neptune-graph:WriteDataViaQuery
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// neptune-graph:DeleteDataViaQuery
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteQuery service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.UnprocessableException">
        /// Request cannot be processed due to known reasons. Eg. partition full.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ExecuteQuery">REST API Reference for ExecuteQuery Operation</seealso>
        Task<ExecuteQueryResponse> ExecuteQueryAsync(ExecuteQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetExportTask



        /// <summary>
        /// Retrieves a specified export task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetExportTask service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetExportTask">REST API Reference for GetExportTask Operation</seealso>
        Task<GetExportTaskResponse> GetExportTaskAsync(GetExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGraph



        /// <summary>
        /// Gets information about a specified graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGraph service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetGraph">REST API Reference for GetGraph Operation</seealso>
        Task<GetGraphResponse> GetGraphAsync(GetGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGraphSnapshot



        /// <summary>
        /// Retrieves a specified graph snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGraphSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGraphSnapshot service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetGraphSnapshot">REST API Reference for GetGraphSnapshot Operation</seealso>
        Task<GetGraphSnapshotResponse> GetGraphSnapshotAsync(GetGraphSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGraphSummary



        /// <summary>
        /// Gets a graph summary for a property graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGraphSummary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGraphSummary service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetGraphSummary">REST API Reference for GetGraphSummary Operation</seealso>
        Task<GetGraphSummaryResponse> GetGraphSummaryAsync(GetGraphSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetImportTask



        /// <summary>
        /// Retrieves a specified import task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetImportTask service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetImportTask">REST API Reference for GetImportTask Operation</seealso>
        Task<GetImportTaskResponse> GetImportTaskAsync(GetImportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPrivateGraphEndpoint



        /// <summary>
        /// Retrieves information about a specified private endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPrivateGraphEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPrivateGraphEndpoint service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetPrivateGraphEndpoint">REST API Reference for GetPrivateGraphEndpoint Operation</seealso>
        Task<GetPrivateGraphEndpointResponse> GetPrivateGraphEndpointAsync(GetPrivateGraphEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetQuery



        /// <summary>
        /// Retrieves the status of a specified query.
        /// 
        ///  <note> 
        /// <para>
        ///  When invoking this operation in a Neptune Analytics cluster, the IAM user or role
        /// making the request must have the <c>neptune-graph:GetQueryStatus</c> IAM action attached.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQuery service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/GetQuery">REST API Reference for GetQuery Operation</seealso>
        Task<GetQueryResponse> GetQueryAsync(GetQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListExportTasks



        /// <summary>
        /// Retrieves a list of export tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExportTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExportTasks service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListExportTasks">REST API Reference for ListExportTasks Operation</seealso>
        Task<ListExportTasksResponse> ListExportTasksAsync(ListExportTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGraphs



        /// <summary>
        /// Lists available Neptune Analytics graphs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGraphs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGraphs service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListGraphs">REST API Reference for ListGraphs Operation</seealso>
        Task<ListGraphsResponse> ListGraphsAsync(ListGraphsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGraphSnapshots



        /// <summary>
        /// Lists available snapshots of a specified Neptune Analytics graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGraphSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGraphSnapshots service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListGraphSnapshots">REST API Reference for ListGraphSnapshots Operation</seealso>
        Task<ListGraphSnapshotsResponse> ListGraphSnapshotsAsync(ListGraphSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListImportTasks



        /// <summary>
        /// Lists import tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImportTasks service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListImportTasks">REST API Reference for ListImportTasks Operation</seealso>
        Task<ListImportTasksResponse> ListImportTasksAsync(ListImportTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPrivateGraphEndpoints



        /// <summary>
        /// Lists private endpoints for a specified Neptune Analytics graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrivateGraphEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPrivateGraphEndpoints service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListPrivateGraphEndpoints">REST API Reference for ListPrivateGraphEndpoints Operation</seealso>
        Task<ListPrivateGraphEndpointsResponse> ListPrivateGraphEndpointsAsync(ListPrivateGraphEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListQueries



        /// <summary>
        /// Lists active openCypher queries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueries service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.AccessDeniedException">
        /// Raised in case of an authentication or authorization failure.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListQueries">REST API Reference for ListQueries Operation</seealso>
        Task<ListQueriesResponse> ListQueriesAsync(ListQueriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists tags associated with a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ResetGraph



        /// <summary>
        /// Empties the data from a specified Neptune Analytics graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetGraph service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/ResetGraph">REST API Reference for ResetGraph Operation</seealso>
        Task<ResetGraphResponse> ResetGraphAsync(ResetGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestoreGraphFromSnapshot



        /// <summary>
        /// Restores a graph from a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreGraphFromSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreGraphFromSnapshot service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ServiceQuotaExceededException">
        /// A service quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/RestoreGraphFromSnapshot">REST API Reference for RestoreGraphFromSnapshot Operation</seealso>
        Task<RestoreGraphFromSnapshotResponse> RestoreGraphFromSnapshotAsync(RestoreGraphFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartExportTask



        /// <summary>
        /// Export data from an existing Neptune Analytics graph to Amazon S3. The graph state
        /// should be <c>AVAILABLE</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartExportTask service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/StartExportTask">REST API Reference for StartExportTask Operation</seealso>
        Task<StartExportTaskResponse> StartExportTaskAsync(StartExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartGraph



        /// <summary>
        /// Starts the specific graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartGraph service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/StartGraph">REST API Reference for StartGraph Operation</seealso>
        Task<StartGraphResponse> StartGraphAsync(StartGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartImportTask



        /// <summary>
        /// Import data into existing Neptune Analytics graph from Amazon Simple Storage Service
        /// (S3). The graph needs to be empty and in the AVAILABLE state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartImportTask service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/StartImportTask">REST API Reference for StartImportTask Operation</seealso>
        Task<StartImportTaskResponse> StartImportTaskAsync(StartImportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopGraph



        /// <summary>
        /// Stops the specific graph.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopGraph service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/StopGraph">REST API Reference for StopGraph Operation</seealso>
        Task<StopGraphResponse> StopGraphAsync(StopGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds tags to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGraph



        /// <summary>
        /// Updates the configuration of a specified Neptune Analytics graph
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGraph service method, as returned by NeptuneGraph.</returns>
        /// <exception cref="Amazon.NeptuneGraph.Model.ConflictException">
        /// Raised when a conflict is encountered.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.InternalServerException">
        /// A failure occurred on the server.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ResourceNotFoundException">
        /// A specified resource could not be located.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ThrottlingException">
        /// The exception was interrupted by throttling.
        /// </exception>
        /// <exception cref="Amazon.NeptuneGraph.Model.ValidationException">
        /// A resource could not be validated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/neptune-graph-2023-11-29/UpdateGraph">REST API Reference for UpdateGraph Operation</seealso>
        Task<UpdateGraphResponse> UpdateGraphAsync(UpdateGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonNeptuneGraphConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonNeptuneGraphConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonNeptuneGraphConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonNeptuneGraphConfig to create AmazonNeptuneGraphClient");
            }

            return awsCredentials == null ? 
                    new AmazonNeptuneGraphClient(serviceClientConfig) :
                    new AmazonNeptuneGraphClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}