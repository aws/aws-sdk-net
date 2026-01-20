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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.WorkspacesInstances.Model;

#pragma warning disable CS1570
namespace Amazon.WorkspacesInstances
{
    /// <summary>
    /// <para>Interface for accessing WorkspacesInstances</para>
    ///
    /// Amazon WorkSpaces Instances provides an API framework for managing virtual workspace
    /// environments across multiple AWS regions, enabling programmatic creation and configuration
    /// of desktop infrastructure.
    /// </summary>
    public partial interface IAmazonWorkspacesInstances : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IWorkspacesInstancesPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateVolume


        /// <summary>
        /// Attaches a volume to a WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVolume service method.</param>
        /// 
        /// <returns>The response from the AssociateVolume service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/AssociateVolume">REST API Reference for AssociateVolume Operation</seealso>
        AssociateVolumeResponse AssociateVolume(AssociateVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateVolume operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/AssociateVolume">REST API Reference for AssociateVolume Operation</seealso>
        IAsyncResult BeginAssociateVolume(AssociateVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateVolume.</param>
        /// 
        /// <returns>Returns a  AssociateVolumeResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/AssociateVolume">REST API Reference for AssociateVolume Operation</seealso>
        AssociateVolumeResponse EndAssociateVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVolume


        /// <summary>
        /// Creates a new volume for WorkSpace Instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume service method.</param>
        /// 
        /// <returns>The response from the CreateVolume service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ServiceQuotaExceededException">
        /// Indicates that a service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
        CreateVolumeResponse CreateVolume(CreateVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
        IAsyncResult BeginCreateVolume(CreateVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVolume.</param>
        /// 
        /// <returns>Returns a  CreateVolumeResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
        CreateVolumeResponse EndCreateVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWorkspaceInstance


        /// <summary>
        /// Launches a new WorkSpace Instance with specified configuration parameters, enabling
        /// programmatic workspace deployment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceInstance service method.</param>
        /// 
        /// <returns>The response from the CreateWorkspaceInstance service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ServiceQuotaExceededException">
        /// Indicates that a service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/CreateWorkspaceInstance">REST API Reference for CreateWorkspaceInstance Operation</seealso>
        CreateWorkspaceInstanceResponse CreateWorkspaceInstance(CreateWorkspaceInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkspaceInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceInstance operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkspaceInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/CreateWorkspaceInstance">REST API Reference for CreateWorkspaceInstance Operation</seealso>
        IAsyncResult BeginCreateWorkspaceInstance(CreateWorkspaceInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkspaceInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkspaceInstance.</param>
        /// 
        /// <returns>Returns a  CreateWorkspaceInstanceResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/CreateWorkspaceInstance">REST API Reference for CreateWorkspaceInstance Operation</seealso>
        CreateWorkspaceInstanceResponse EndCreateWorkspaceInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVolume


        /// <summary>
        /// Deletes a specified volume.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume service method.</param>
        /// 
        /// <returns>The response from the DeleteVolume service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        IAsyncResult BeginDeleteVolume(DeleteVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVolume.</param>
        /// 
        /// <returns>Returns a  DeleteVolumeResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        DeleteVolumeResponse EndDeleteVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkspaceInstance


        /// <summary>
        /// Deletes the specified WorkSpace
        /// 
        ///  <important> 
        /// <para>
        /// Usage of this API will result in deletion of the resource in question.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkspaceInstance service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DeleteWorkspaceInstance">REST API Reference for DeleteWorkspaceInstance Operation</seealso>
        DeleteWorkspaceInstanceResponse DeleteWorkspaceInstance(DeleteWorkspaceInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkspaceInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceInstance operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkspaceInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DeleteWorkspaceInstance">REST API Reference for DeleteWorkspaceInstance Operation</seealso>
        IAsyncResult BeginDeleteWorkspaceInstance(DeleteWorkspaceInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkspaceInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkspaceInstance.</param>
        /// 
        /// <returns>Returns a  DeleteWorkspaceInstanceResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DeleteWorkspaceInstance">REST API Reference for DeleteWorkspaceInstance Operation</seealso>
        DeleteWorkspaceInstanceResponse EndDeleteWorkspaceInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateVolume


        /// <summary>
        /// Detaches a volume from a WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVolume service method.</param>
        /// 
        /// <returns>The response from the DisassociateVolume service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ConflictException">
        /// Signals a conflict with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DisassociateVolume">REST API Reference for DisassociateVolume Operation</seealso>
        DisassociateVolumeResponse DisassociateVolume(DisassociateVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVolume operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DisassociateVolume">REST API Reference for DisassociateVolume Operation</seealso>
        IAsyncResult BeginDisassociateVolume(DisassociateVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateVolume.</param>
        /// 
        /// <returns>Returns a  DisassociateVolumeResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/DisassociateVolume">REST API Reference for DisassociateVolume Operation</seealso>
        DisassociateVolumeResponse EndDisassociateVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorkspaceInstance


        /// <summary>
        /// Retrieves detailed information about a specific WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkspaceInstance service method.</param>
        /// 
        /// <returns>The response from the GetWorkspaceInstance service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/GetWorkspaceInstance">REST API Reference for GetWorkspaceInstance Operation</seealso>
        GetWorkspaceInstanceResponse GetWorkspaceInstance(GetWorkspaceInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkspaceInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkspaceInstance operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkspaceInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/GetWorkspaceInstance">REST API Reference for GetWorkspaceInstance Operation</seealso>
        IAsyncResult BeginGetWorkspaceInstance(GetWorkspaceInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkspaceInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkspaceInstance.</param>
        /// 
        /// <returns>Returns a  GetWorkspaceInstanceResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/GetWorkspaceInstance">REST API Reference for GetWorkspaceInstance Operation</seealso>
        GetWorkspaceInstanceResponse EndGetWorkspaceInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInstanceTypes


        /// <summary>
        /// Retrieves a list of instance types supported by Amazon WorkSpaces Instances, enabling
        /// precise workspace infrastructure configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceTypes service method.</param>
        /// 
        /// <returns>The response from the ListInstanceTypes service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListInstanceTypes">REST API Reference for ListInstanceTypes Operation</seealso>
        ListInstanceTypesResponse ListInstanceTypes(ListInstanceTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceTypes operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstanceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListInstanceTypes">REST API Reference for ListInstanceTypes Operation</seealso>
        IAsyncResult BeginListInstanceTypes(ListInstanceTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstanceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceTypes.</param>
        /// 
        /// <returns>Returns a  ListInstanceTypesResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListInstanceTypes">REST API Reference for ListInstanceTypes Operation</seealso>
        ListInstanceTypesResponse EndListInstanceTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRegions


        /// <summary>
        /// Retrieves a list of AWS regions supported by Amazon WorkSpaces Instances, enabling
        /// region discovery for workspace deployments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegions service method.</param>
        /// 
        /// <returns>The response from the ListRegions service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListRegions">REST API Reference for ListRegions Operation</seealso>
        ListRegionsResponse ListRegions(ListRegionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRegions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRegions operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRegions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListRegions">REST API Reference for ListRegions Operation</seealso>
        IAsyncResult BeginListRegions(ListRegionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRegions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRegions.</param>
        /// 
        /// <returns>Returns a  ListRegionsResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListRegions">REST API Reference for ListRegions Operation</seealso>
        ListRegionsResponse EndListRegions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves tags for a WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkspaceInstances


        /// <summary>
        /// Retrieves a collection of WorkSpaces Instances based on specified filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaceInstances service method.</param>
        /// 
        /// <returns>The response from the ListWorkspaceInstances service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListWorkspaceInstances">REST API Reference for ListWorkspaceInstances Operation</seealso>
        ListWorkspaceInstancesResponse ListWorkspaceInstances(ListWorkspaceInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkspaceInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaceInstances operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkspaceInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListWorkspaceInstances">REST API Reference for ListWorkspaceInstances Operation</seealso>
        IAsyncResult BeginListWorkspaceInstances(ListWorkspaceInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkspaceInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkspaceInstances.</param>
        /// 
        /// <returns>Returns a  ListWorkspaceInstancesResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/ListWorkspaceInstances">REST API Reference for ListWorkspaceInstances Operation</seealso>
        ListWorkspaceInstancesResponse EndListWorkspaceInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a WorkSpace Instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WorkspacesInstances.</returns>
        /// <exception cref="Amazon.WorkspacesInstances.Model.AccessDeniedException">
        /// Indicates insufficient permissions to perform the requested action.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.InternalServerException">
        /// Indicates an unexpected server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ResourceNotFoundException">
        /// Indicates the requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ThrottlingException">
        /// Indicates the request rate has exceeded limits.
        /// </exception>
        /// <exception cref="Amazon.WorkspacesInstances.Model.ValidationException">
        /// Indicates invalid input parameters in the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonWorkspacesInstancesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from WorkspacesInstances.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-instances-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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