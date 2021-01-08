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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PrometheusService.Model;

namespace Amazon.PrometheusService
{
    /// <summary>
    /// Interface for accessing PrometheusService
    ///
    /// Amazon Managed Service for Prometheus
    /// </summary>
    public partial interface IAmazonPrometheusService : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPrometheusServicePaginatorFactory Paginators { get; }
#endif


        
        #region  CreateWorkspace


        /// <summary>
        /// Creates a new AMP workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspace service method.</param>
        /// 
        /// <returns>The response from the CreateWorkspace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        CreateWorkspaceResponse CreateWorkspace(CreateWorkspaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspace operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        IAsyncResult BeginCreateWorkspace(CreateWorkspaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkspace.</param>
        /// 
        /// <returns>Returns a  CreateWorkspaceResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        CreateWorkspaceResponse EndCreateWorkspace(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkspace


        /// <summary>
        /// Deletes an AMP workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspace service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkspace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        DeleteWorkspaceResponse DeleteWorkspace(DeleteWorkspaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspace operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        IAsyncResult BeginDeleteWorkspace(DeleteWorkspaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkspace.</param>
        /// 
        /// <returns>Returns a  DeleteWorkspaceResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        DeleteWorkspaceResponse EndDeleteWorkspace(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeWorkspace


        /// <summary>
        /// Describes an existing AMP workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspace service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeWorkspace">REST API Reference for DescribeWorkspace Operation</seealso>
        DescribeWorkspaceResponse DescribeWorkspace(DescribeWorkspaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspace operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkspace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeWorkspace">REST API Reference for DescribeWorkspace Operation</seealso>
        IAsyncResult BeginDescribeWorkspace(DescribeWorkspaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkspace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkspace.</param>
        /// 
        /// <returns>Returns a  DescribeWorkspaceResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeWorkspace">REST API Reference for DescribeWorkspace Operation</seealso>
        DescribeWorkspaceResponse EndDescribeWorkspace(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkspaces


        /// <summary>
        /// Lists all AMP workspaces, including workspaces being created or deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaces service method.</param>
        /// 
        /// <returns>The response from the ListWorkspaces service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        ListWorkspacesResponse ListWorkspaces(ListWorkspacesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaces operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkspaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        IAsyncResult BeginListWorkspaces(ListWorkspacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkspaces.</param>
        /// 
        /// <returns>Returns a  ListWorkspacesResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        ListWorkspacesResponse EndListWorkspaces(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWorkspaceAlias


        /// <summary>
        /// Updates an AMP workspace alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkspaceAlias service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateWorkspaceAlias">REST API Reference for UpdateWorkspaceAlias Operation</seealso>
        UpdateWorkspaceAliasResponse UpdateWorkspaceAlias(UpdateWorkspaceAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkspaceAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceAlias operation on AmazonPrometheusServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkspaceAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateWorkspaceAlias">REST API Reference for UpdateWorkspaceAlias Operation</seealso>
        IAsyncResult BeginUpdateWorkspaceAlias(UpdateWorkspaceAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkspaceAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkspaceAlias.</param>
        /// 
        /// <returns>Returns a  UpdateWorkspaceAliasResult from PrometheusService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateWorkspaceAlias">REST API Reference for UpdateWorkspaceAlias Operation</seealso>
        UpdateWorkspaceAliasResponse EndUpdateWorkspaceAlias(IAsyncResult asyncResult);

        #endregion
        
    }
}