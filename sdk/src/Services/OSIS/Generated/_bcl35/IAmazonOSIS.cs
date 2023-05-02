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
 * Do not modify this file. This file is generated from the osis-2022-01-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.OSIS.Model;

namespace Amazon.OSIS
{
    /// <summary>
    /// Interface for accessing OSIS
    ///
    /// Use the Amazon OpenSearch Ingestion API to create and manage ingestion pipelines.
    /// OpenSearch Ingestion is a fully managed data collector that delivers real-time log
    /// and trace data to OpenSearch Service domains. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/ingestion.html">Getting
    /// data into your cluster using OpenSearch Ingestion</a>.
    /// </summary>
    public partial interface IAmazonOSIS : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IOSISPaginatorFactory Paginators { get; }
#endif


        
        #region  CreatePipeline


        /// <summary>
        /// Creates an OpenSearch Ingestion pipeline. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/creating-pipeline.html">Creating
        /// Amazon OpenSearch Ingestion pipelines</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline service method.</param>
        /// 
        /// <returns>The response from the CreatePipeline service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.LimitExceededException">
        /// You attempted to create more than the allowed number of tags.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceAlreadyExistsException">
        /// You attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        CreatePipelineResponse CreatePipeline(CreatePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipeline operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        IAsyncResult BeginCreatePipeline(CreatePipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePipeline.</param>
        /// 
        /// <returns>Returns a  CreatePipelineResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/CreatePipeline">REST API Reference for CreatePipeline Operation</seealso>
        CreatePipelineResponse EndCreatePipeline(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePipeline


        /// <summary>
        /// Deletes an OpenSearch Ingestion pipeline. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/delete-pipeline.html">Deleting
        /// Amazon OpenSearch Ingestion pipelines</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline service method.</param>
        /// 
        /// <returns>The response from the DeletePipeline service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ConflictException">
        /// The client attempted to remove a resource that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceNotFoundException">
        /// You attempted to access or delete a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        DeletePipelineResponse DeletePipeline(DeletePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipeline operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        IAsyncResult BeginDeletePipeline(DeletePipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePipeline.</param>
        /// 
        /// <returns>Returns a  DeletePipelineResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/DeletePipeline">REST API Reference for DeletePipeline Operation</seealso>
        DeletePipelineResponse EndDeletePipeline(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPipeline


        /// <summary>
        /// Retrieves information about an OpenSearch Ingestion pipeline.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPipeline service method.</param>
        /// 
        /// <returns>The response from the GetPipeline service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceNotFoundException">
        /// You attempted to access or delete a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        GetPipelineResponse GetPipeline(GetPipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipeline operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        IAsyncResult BeginGetPipeline(GetPipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPipeline.</param>
        /// 
        /// <returns>Returns a  GetPipelineResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/GetPipeline">REST API Reference for GetPipeline Operation</seealso>
        GetPipelineResponse EndGetPipeline(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPipelineBlueprint


        /// <summary>
        /// Retrieves information about a specific blueprint for OpenSearch Ingestion. Blueprints
        /// are templates for the configuration needed for a <code>CreatePipeline</code> request.
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/creating-pipeline.html#pipeline-blueprint">Using
        /// blueprints to create a pipeline</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineBlueprint service method.</param>
        /// 
        /// <returns>The response from the GetPipelineBlueprint service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceNotFoundException">
        /// You attempted to access or delete a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/GetPipelineBlueprint">REST API Reference for GetPipelineBlueprint Operation</seealso>
        GetPipelineBlueprintResponse GetPipelineBlueprint(GetPipelineBlueprintRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPipelineBlueprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineBlueprint operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPipelineBlueprint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/GetPipelineBlueprint">REST API Reference for GetPipelineBlueprint Operation</seealso>
        IAsyncResult BeginGetPipelineBlueprint(GetPipelineBlueprintRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPipelineBlueprint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPipelineBlueprint.</param>
        /// 
        /// <returns>Returns a  GetPipelineBlueprintResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/GetPipelineBlueprint">REST API Reference for GetPipelineBlueprint Operation</seealso>
        GetPipelineBlueprintResponse EndGetPipelineBlueprint(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPipelineChangeProgress


        /// <summary>
        /// Returns progress information for the current change happening on an OpenSearch Ingestion
        /// pipeline. Currently, this operation only returns information when a pipeline is being
        /// created.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/creating-pipeline.html#get-pipeline-progress">Tracking
        /// the status of pipeline creation</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineChangeProgress service method.</param>
        /// 
        /// <returns>The response from the GetPipelineChangeProgress service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceNotFoundException">
        /// You attempted to access or delete a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/GetPipelineChangeProgress">REST API Reference for GetPipelineChangeProgress Operation</seealso>
        GetPipelineChangeProgressResponse GetPipelineChangeProgress(GetPipelineChangeProgressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPipelineChangeProgress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPipelineChangeProgress operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPipelineChangeProgress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/GetPipelineChangeProgress">REST API Reference for GetPipelineChangeProgress Operation</seealso>
        IAsyncResult BeginGetPipelineChangeProgress(GetPipelineChangeProgressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPipelineChangeProgress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPipelineChangeProgress.</param>
        /// 
        /// <returns>Returns a  GetPipelineChangeProgressResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/GetPipelineChangeProgress">REST API Reference for GetPipelineChangeProgress Operation</seealso>
        GetPipelineChangeProgressResponse EndGetPipelineChangeProgress(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPipelineBlueprints


        /// <summary>
        /// Retrieves a list of all available blueprints for Data Prepper. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/creating-pipeline.html#pipeline-blueprint">Using
        /// blueprints to create a pipeline</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineBlueprints service method.</param>
        /// 
        /// <returns>The response from the ListPipelineBlueprints service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InvalidPaginationTokenException">
        /// An invalid pagination token provided in the request.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ListPipelineBlueprints">REST API Reference for ListPipelineBlueprints Operation</seealso>
        ListPipelineBlueprintsResponse ListPipelineBlueprints(ListPipelineBlueprintsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelineBlueprints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelineBlueprints operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPipelineBlueprints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ListPipelineBlueprints">REST API Reference for ListPipelineBlueprints Operation</seealso>
        IAsyncResult BeginListPipelineBlueprints(ListPipelineBlueprintsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPipelineBlueprints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPipelineBlueprints.</param>
        /// 
        /// <returns>Returns a  ListPipelineBlueprintsResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ListPipelineBlueprints">REST API Reference for ListPipelineBlueprints Operation</seealso>
        ListPipelineBlueprintsResponse EndListPipelineBlueprints(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPipelines


        /// <summary>
        /// Lists all OpenSearch Ingestion pipelines in the current Amazon Web Services account
        /// and Region. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/list-pipeline.html">Viewing
        /// Amazon OpenSearch Ingestion pipelines</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines service method.</param>
        /// 
        /// <returns>The response from the ListPipelines service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InvalidPaginationTokenException">
        /// An invalid pagination token provided in the request.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        ListPipelinesResponse ListPipelines(ListPipelinesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipelines operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPipelines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        IAsyncResult BeginListPipelines(ListPipelinesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPipelines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPipelines.</param>
        /// 
        /// <returns>Returns a  ListPipelinesResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ListPipelines">REST API Reference for ListPipelines Operation</seealso>
        ListPipelinesResponse EndListPipelines(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all resource tags associated with an OpenSearch Ingestion pipeline. For more
        /// information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/tag-pipeline.html">Tagging
        /// Amazon OpenSearch Ingestion pipelines</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceNotFoundException">
        /// You attempted to access or delete a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  StartPipeline


        /// <summary>
        /// Starts an OpenSearch Ingestion pipeline. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/pipeline--stop-start.html#pipeline--start">Starting
        /// an OpenSearch Ingestion pipeline</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPipeline service method.</param>
        /// 
        /// <returns>The response from the StartPipeline service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ConflictException">
        /// The client attempted to remove a resource that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceNotFoundException">
        /// You attempted to access or delete a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/StartPipeline">REST API Reference for StartPipeline Operation</seealso>
        StartPipelineResponse StartPipeline(StartPipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPipeline operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartPipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/StartPipeline">REST API Reference for StartPipeline Operation</seealso>
        IAsyncResult BeginStartPipeline(StartPipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartPipeline.</param>
        /// 
        /// <returns>Returns a  StartPipelineResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/StartPipeline">REST API Reference for StartPipeline Operation</seealso>
        StartPipelineResponse EndStartPipeline(IAsyncResult asyncResult);

        #endregion
        
        #region  StopPipeline


        /// <summary>
        /// Stops an OpenSearch Ingestion pipeline. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/pipeline--stop-start.html#pipeline--stop">Stopping
        /// an OpenSearch Ingestion pipeline</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopPipeline service method.</param>
        /// 
        /// <returns>The response from the StopPipeline service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ConflictException">
        /// The client attempted to remove a resource that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceNotFoundException">
        /// You attempted to access or delete a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/StopPipeline">REST API Reference for StopPipeline Operation</seealso>
        StopPipelineResponse StopPipeline(StopPipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopPipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopPipeline operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopPipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/StopPipeline">REST API Reference for StopPipeline Operation</seealso>
        IAsyncResult BeginStopPipeline(StopPipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopPipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopPipeline.</param>
        /// 
        /// <returns>Returns a  StopPipelineResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/StopPipeline">REST API Reference for StopPipeline Operation</seealso>
        StopPipelineResponse EndStopPipeline(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags an OpenSearch Ingestion pipeline. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/tag-pipeline.html">Tagging
        /// Amazon OpenSearch Ingestion pipelines</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.LimitExceededException">
        /// You attempted to create more than the allowed number of tags.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceNotFoundException">
        /// You attempted to access or delete a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from an OpenSearch Ingestion pipeline. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/tag-pipeline.html">Tagging
        /// Amazon OpenSearch Ingestion pipelines</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceNotFoundException">
        /// You attempted to access or delete a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePipeline


        /// <summary>
        /// Updates an OpenSearch Ingestion pipeline. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/update-pipeline.html">Updating
        /// Amazon OpenSearch Ingestion pipelines</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline service method.</param>
        /// 
        /// <returns>The response from the UpdatePipeline service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ConflictException">
        /// The client attempted to remove a resource that is currently in use.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ResourceNotFoundException">
        /// You attempted to access or delete a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        UpdatePipelineResponse UpdatePipeline(UpdatePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipeline operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        IAsyncResult BeginUpdatePipeline(UpdatePipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipeline.</param>
        /// 
        /// <returns>Returns a  UpdatePipelineResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/UpdatePipeline">REST API Reference for UpdatePipeline Operation</seealso>
        UpdatePipelineResponse EndUpdatePipeline(IAsyncResult asyncResult);

        #endregion
        
        #region  ValidatePipeline


        /// <summary>
        /// Checks whether an OpenSearch Ingestion pipeline configuration is valid prior to creation.
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/creating-pipeline.html">Creating
        /// Amazon OpenSearch Ingestion pipelines</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidatePipeline service method.</param>
        /// 
        /// <returns>The response from the ValidatePipeline service method, as returned by OSIS.</returns>
        /// <exception cref="Amazon.OSIS.Model.AccessDeniedException">
        /// You don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.InternalException">
        /// The request failed because of an unknown error, exception, or failure (the failure
        /// is internal to the service).
        /// </exception>
        /// <exception cref="Amazon.OSIS.Model.ValidationException">
        /// An exception for missing or invalid input fields.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ValidatePipeline">REST API Reference for ValidatePipeline Operation</seealso>
        ValidatePipelineResponse ValidatePipeline(ValidatePipelineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ValidatePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidatePipeline operation on AmazonOSISClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidatePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ValidatePipeline">REST API Reference for ValidatePipeline Operation</seealso>
        IAsyncResult BeginValidatePipeline(ValidatePipelineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ValidatePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidatePipeline.</param>
        /// 
        /// <returns>Returns a  ValidatePipelineResult from OSIS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/osis-2022-01-01/ValidatePipeline">REST API Reference for ValidatePipeline Operation</seealso>
        ValidatePipelineResponse EndValidatePipeline(IAsyncResult asyncResult);

        #endregion
        
    }
}