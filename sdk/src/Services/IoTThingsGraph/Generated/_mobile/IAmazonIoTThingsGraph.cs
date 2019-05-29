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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoTThingsGraph.Model;

namespace Amazon.IoTThingsGraph
{
    /// <summary>
    /// Interface for accessing IoTThingsGraph
    ///
    /// AWS IoT Things Graph 
    /// <para>
    /// AWS IoT Things Graph provides an integrated set of tools that enable developers to
    /// connect devices and services that use different standards, such as units of measure
    /// and communication protocols. AWS IoT Things Graph makes it possible to build IoT applications
    /// with little to no code by connecting devices and services and defining how they interact
    /// at an abstract level.
    /// </para>
    ///  
    /// <para>
    /// For more information about how AWS IoT Things Graph works, see the <a href="https://docs.aws.amazon.com/thingsgraph/latest/ug/iot-tg-whatis.html">User
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonIoTThingsGraph : IAmazonService, IDisposable
    {
                
        #region  AssociateEntityToThing


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateEntityToThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateEntityToThing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/AssociateEntityToThing">REST API Reference for AssociateEntityToThing Operation</seealso>
        Task<AssociateEntityToThingResponse> AssociateEntityToThingAsync(AssociateEntityToThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFlowTemplate


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFlowTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/CreateFlowTemplate">REST API Reference for CreateFlowTemplate Operation</seealso>
        Task<CreateFlowTemplateResponse> CreateFlowTemplateAsync(CreateFlowTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSystemInstance


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSystemInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSystemInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/CreateSystemInstance">REST API Reference for CreateSystemInstance Operation</seealso>
        Task<CreateSystemInstanceResponse> CreateSystemInstanceAsync(CreateSystemInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSystemTemplate


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSystemTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSystemTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/CreateSystemTemplate">REST API Reference for CreateSystemTemplate Operation</seealso>
        Task<CreateSystemTemplateResponse> CreateSystemTemplateAsync(CreateSystemTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFlowTemplate


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFlowTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteFlowTemplate">REST API Reference for DeleteFlowTemplate Operation</seealso>
        Task<DeleteFlowTemplateResponse> DeleteFlowTemplateAsync(DeleteFlowTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNamespace


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        Task<DeleteNamespaceResponse> DeleteNamespaceAsync(DeleteNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSystemInstance


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSystemInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSystemInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteSystemInstance">REST API Reference for DeleteSystemInstance Operation</seealso>
        Task<DeleteSystemInstanceResponse> DeleteSystemInstanceAsync(DeleteSystemInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSystemTemplate


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSystemTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSystemTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeleteSystemTemplate">REST API Reference for DeleteSystemTemplate Operation</seealso>
        Task<DeleteSystemTemplateResponse> DeleteSystemTemplateAsync(DeleteSystemTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeploySystemInstance


        /// <summary>
        /// Initiates the asynchronous execution of the DeploySystemInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeploySystemInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeploySystemInstance">REST API Reference for DeploySystemInstance Operation</seealso>
        Task<DeploySystemInstanceResponse> DeploySystemInstanceAsync(DeploySystemInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeprecateFlowTemplate


        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateFlowTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateFlowTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeprecateFlowTemplate">REST API Reference for DeprecateFlowTemplate Operation</seealso>
        Task<DeprecateFlowTemplateResponse> DeprecateFlowTemplateAsync(DeprecateFlowTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeprecateSystemTemplate


        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateSystemTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateSystemTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DeprecateSystemTemplate">REST API Reference for DeprecateSystemTemplate Operation</seealso>
        Task<DeprecateSystemTemplateResponse> DeprecateSystemTemplateAsync(DeprecateSystemTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeNamespace


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNamespace operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DescribeNamespace">REST API Reference for DescribeNamespace Operation</seealso>
        Task<DescribeNamespaceResponse> DescribeNamespaceAsync(DescribeNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DissociateEntityFromThing


        /// <summary>
        /// Initiates the asynchronous execution of the DissociateEntityFromThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DissociateEntityFromThing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/DissociateEntityFromThing">REST API Reference for DissociateEntityFromThing Operation</seealso>
        Task<DissociateEntityFromThingResponse> DissociateEntityFromThingAsync(DissociateEntityFromThingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEntities


        /// <summary>
        /// Initiates the asynchronous execution of the GetEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEntities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetEntities">REST API Reference for GetEntities Operation</seealso>
        Task<GetEntitiesResponse> GetEntitiesAsync(GetEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFlowTemplate


        /// <summary>
        /// Initiates the asynchronous execution of the GetFlowTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFlowTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetFlowTemplate">REST API Reference for GetFlowTemplate Operation</seealso>
        Task<GetFlowTemplateResponse> GetFlowTemplateAsync(GetFlowTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFlowTemplateRevisions


        /// <summary>
        /// Initiates the asynchronous execution of the GetFlowTemplateRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFlowTemplateRevisions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetFlowTemplateRevisions">REST API Reference for GetFlowTemplateRevisions Operation</seealso>
        Task<GetFlowTemplateRevisionsResponse> GetFlowTemplateRevisionsAsync(GetFlowTemplateRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetNamespaceDeletionStatus


        /// <summary>
        /// Initiates the asynchronous execution of the GetNamespaceDeletionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNamespaceDeletionStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetNamespaceDeletionStatus">REST API Reference for GetNamespaceDeletionStatus Operation</seealso>
        Task<GetNamespaceDeletionStatusResponse> GetNamespaceDeletionStatusAsync(GetNamespaceDeletionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSystemInstance


        /// <summary>
        /// Initiates the asynchronous execution of the GetSystemInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSystemInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetSystemInstance">REST API Reference for GetSystemInstance Operation</seealso>
        Task<GetSystemInstanceResponse> GetSystemInstanceAsync(GetSystemInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSystemTemplate


        /// <summary>
        /// Initiates the asynchronous execution of the GetSystemTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSystemTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetSystemTemplate">REST API Reference for GetSystemTemplate Operation</seealso>
        Task<GetSystemTemplateResponse> GetSystemTemplateAsync(GetSystemTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSystemTemplateRevisions


        /// <summary>
        /// Initiates the asynchronous execution of the GetSystemTemplateRevisions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSystemTemplateRevisions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetSystemTemplateRevisions">REST API Reference for GetSystemTemplateRevisions Operation</seealso>
        Task<GetSystemTemplateRevisionsResponse> GetSystemTemplateRevisionsAsync(GetSystemTemplateRevisionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUploadStatus


        /// <summary>
        /// Initiates the asynchronous execution of the GetUploadStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUploadStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/GetUploadStatus">REST API Reference for GetUploadStatus Operation</seealso>
        Task<GetUploadStatusResponse> GetUploadStatusAsync(GetUploadStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFlowExecutionMessages


        /// <summary>
        /// Initiates the asynchronous execution of the ListFlowExecutionMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFlowExecutionMessages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/ListFlowExecutionMessages">REST API Reference for ListFlowExecutionMessages Operation</seealso>
        Task<ListFlowExecutionMessagesResponse> ListFlowExecutionMessagesAsync(ListFlowExecutionMessagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchEntities


        /// <summary>
        /// Initiates the asynchronous execution of the SearchEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchEntities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchEntities">REST API Reference for SearchEntities Operation</seealso>
        Task<SearchEntitiesResponse> SearchEntitiesAsync(SearchEntitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchFlowExecutions


        /// <summary>
        /// Initiates the asynchronous execution of the SearchFlowExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchFlowExecutions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchFlowExecutions">REST API Reference for SearchFlowExecutions Operation</seealso>
        Task<SearchFlowExecutionsResponse> SearchFlowExecutionsAsync(SearchFlowExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchFlowTemplates


        /// <summary>
        /// Initiates the asynchronous execution of the SearchFlowTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchFlowTemplates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchFlowTemplates">REST API Reference for SearchFlowTemplates Operation</seealso>
        Task<SearchFlowTemplatesResponse> SearchFlowTemplatesAsync(SearchFlowTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchSystemInstances


        /// <summary>
        /// Initiates the asynchronous execution of the SearchSystemInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchSystemInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchSystemInstances">REST API Reference for SearchSystemInstances Operation</seealso>
        Task<SearchSystemInstancesResponse> SearchSystemInstancesAsync(SearchSystemInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchSystemTemplates


        /// <summary>
        /// Initiates the asynchronous execution of the SearchSystemTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchSystemTemplates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchSystemTemplates">REST API Reference for SearchSystemTemplates Operation</seealso>
        Task<SearchSystemTemplatesResponse> SearchSystemTemplatesAsync(SearchSystemTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SearchThings


        /// <summary>
        /// Initiates the asynchronous execution of the SearchThings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchThings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/SearchThings">REST API Reference for SearchThings Operation</seealso>
        Task<SearchThingsResponse> SearchThingsAsync(SearchThingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UndeploySystemInstance


        /// <summary>
        /// Initiates the asynchronous execution of the UndeploySystemInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UndeploySystemInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UndeploySystemInstance">REST API Reference for UndeploySystemInstance Operation</seealso>
        Task<UndeploySystemInstanceResponse> UndeploySystemInstanceAsync(UndeploySystemInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateFlowTemplate


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFlowTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFlowTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UpdateFlowTemplate">REST API Reference for UpdateFlowTemplate Operation</seealso>
        Task<UpdateFlowTemplateResponse> UpdateFlowTemplateAsync(UpdateFlowTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSystemTemplate


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSystemTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSystemTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UpdateSystemTemplate">REST API Reference for UpdateSystemTemplate Operation</seealso>
        Task<UpdateSystemTemplateResponse> UpdateSystemTemplateAsync(UpdateSystemTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UploadEntityDefinitions


        /// <summary>
        /// Initiates the asynchronous execution of the UploadEntityDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadEntityDefinitions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotthingsgraph-2018-09-06/UploadEntityDefinitions">REST API Reference for UploadEntityDefinitions Operation</seealso>
        Task<UploadEntityDefinitionsResponse> UploadEntityDefinitionsAsync(UploadEntityDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}