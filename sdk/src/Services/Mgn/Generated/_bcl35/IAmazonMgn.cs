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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Mgn.Model;

namespace Amazon.Mgn
{
    /// <summary>
    /// Interface for accessing Mgn
    ///
    /// The Application Migration Service service.
    /// </summary>
    public partial interface IAmazonMgn : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMgnPaginatorFactory Paginators { get; }
#endif


        
        #region  ArchiveApplication


        /// <summary>
        /// Archive application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ArchiveApplication service method.</param>
        /// 
        /// <returns>The response from the ArchiveApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ArchiveApplication">REST API Reference for ArchiveApplication Operation</seealso>
        ArchiveApplicationResponse ArchiveApplication(ArchiveApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ArchiveApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ArchiveApplication operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndArchiveApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ArchiveApplication">REST API Reference for ArchiveApplication Operation</seealso>
        IAsyncResult BeginArchiveApplication(ArchiveApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ArchiveApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginArchiveApplication.</param>
        /// 
        /// <returns>Returns a  ArchiveApplicationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ArchiveApplication">REST API Reference for ArchiveApplication Operation</seealso>
        ArchiveApplicationResponse EndArchiveApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  ArchiveWave


        /// <summary>
        /// Archive wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ArchiveWave service method.</param>
        /// 
        /// <returns>The response from the ArchiveWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ArchiveWave">REST API Reference for ArchiveWave Operation</seealso>
        ArchiveWaveResponse ArchiveWave(ArchiveWaveRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ArchiveWave operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ArchiveWave operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndArchiveWave
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ArchiveWave">REST API Reference for ArchiveWave Operation</seealso>
        IAsyncResult BeginArchiveWave(ArchiveWaveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ArchiveWave operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginArchiveWave.</param>
        /// 
        /// <returns>Returns a  ArchiveWaveResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ArchiveWave">REST API Reference for ArchiveWave Operation</seealso>
        ArchiveWaveResponse EndArchiveWave(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateApplications


        /// <summary>
        /// Associate applications to wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateApplications service method.</param>
        /// 
        /// <returns>The response from the AssociateApplications service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/AssociateApplications">REST API Reference for AssociateApplications Operation</seealso>
        AssociateApplicationsResponse AssociateApplications(AssociateApplicationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateApplications operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/AssociateApplications">REST API Reference for AssociateApplications Operation</seealso>
        IAsyncResult BeginAssociateApplications(AssociateApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateApplications.</param>
        /// 
        /// <returns>Returns a  AssociateApplicationsResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/AssociateApplications">REST API Reference for AssociateApplications Operation</seealso>
        AssociateApplicationsResponse EndAssociateApplications(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateSourceServers


        /// <summary>
        /// Associate source servers to application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSourceServers service method.</param>
        /// 
        /// <returns>The response from the AssociateSourceServers service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/AssociateSourceServers">REST API Reference for AssociateSourceServers Operation</seealso>
        AssociateSourceServersResponse AssociateSourceServers(AssociateSourceServersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSourceServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSourceServers operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateSourceServers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/AssociateSourceServers">REST API Reference for AssociateSourceServers Operation</seealso>
        IAsyncResult BeginAssociateSourceServers(AssociateSourceServersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateSourceServers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateSourceServers.</param>
        /// 
        /// <returns>Returns a  AssociateSourceServersResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/AssociateSourceServers">REST API Reference for AssociateSourceServers Operation</seealso>
        AssociateSourceServersResponse EndAssociateSourceServers(IAsyncResult asyncResult);

        #endregion
        
        #region  ChangeServerLifeCycleState


        /// <summary>
        /// Allows the user to set the SourceServer.LifeCycle.state property for specific Source
        /// Server IDs to one of the following: READY_FOR_TEST or READY_FOR_CUTOVER. This command
        /// only works if the Source Server is already launchable (dataReplicationInfo.lagDuration
        /// is not null.)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeServerLifeCycleState service method.</param>
        /// 
        /// <returns>The response from the ChangeServerLifeCycleState service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ChangeServerLifeCycleState">REST API Reference for ChangeServerLifeCycleState Operation</seealso>
        ChangeServerLifeCycleStateResponse ChangeServerLifeCycleState(ChangeServerLifeCycleStateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeServerLifeCycleState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeServerLifeCycleState operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndChangeServerLifeCycleState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ChangeServerLifeCycleState">REST API Reference for ChangeServerLifeCycleState Operation</seealso>
        IAsyncResult BeginChangeServerLifeCycleState(ChangeServerLifeCycleStateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ChangeServerLifeCycleState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChangeServerLifeCycleState.</param>
        /// 
        /// <returns>Returns a  ChangeServerLifeCycleStateResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ChangeServerLifeCycleState">REST API Reference for ChangeServerLifeCycleState Operation</seealso>
        ChangeServerLifeCycleStateResponse EndChangeServerLifeCycleState(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateApplication


        /// <summary>
        /// Create application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse CreateApplication(CreateApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        IAsyncResult BeginCreateApplication(CreateApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a  CreateApplicationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLaunchConfigurationTemplate


        /// <summary>
        /// Creates a new Launch Configuration Template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateLaunchConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateLaunchConfigurationTemplate">REST API Reference for CreateLaunchConfigurationTemplate Operation</seealso>
        CreateLaunchConfigurationTemplateResponse CreateLaunchConfigurationTemplate(CreateLaunchConfigurationTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLaunchConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchConfigurationTemplate operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLaunchConfigurationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateLaunchConfigurationTemplate">REST API Reference for CreateLaunchConfigurationTemplate Operation</seealso>
        IAsyncResult BeginCreateLaunchConfigurationTemplate(CreateLaunchConfigurationTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLaunchConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLaunchConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  CreateLaunchConfigurationTemplateResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateLaunchConfigurationTemplate">REST API Reference for CreateLaunchConfigurationTemplate Operation</seealso>
        CreateLaunchConfigurationTemplateResponse EndCreateLaunchConfigurationTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateReplicationConfigurationTemplate


        /// <summary>
        /// Creates a new ReplicationConfigurationTemplate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateReplicationConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateReplicationConfigurationTemplate">REST API Reference for CreateReplicationConfigurationTemplate Operation</seealso>
        CreateReplicationConfigurationTemplateResponse CreateReplicationConfigurationTemplate(CreateReplicationConfigurationTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationConfigurationTemplate operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReplicationConfigurationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateReplicationConfigurationTemplate">REST API Reference for CreateReplicationConfigurationTemplate Operation</seealso>
        IAsyncResult BeginCreateReplicationConfigurationTemplate(CreateReplicationConfigurationTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReplicationConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReplicationConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  CreateReplicationConfigurationTemplateResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateReplicationConfigurationTemplate">REST API Reference for CreateReplicationConfigurationTemplate Operation</seealso>
        CreateReplicationConfigurationTemplateResponse EndCreateReplicationConfigurationTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWave


        /// <summary>
        /// Create wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWave service method.</param>
        /// 
        /// <returns>The response from the CreateWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateWave">REST API Reference for CreateWave Operation</seealso>
        CreateWaveResponse CreateWave(CreateWaveRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWave operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWave operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWave
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateWave">REST API Reference for CreateWave Operation</seealso>
        IAsyncResult BeginCreateWave(CreateWaveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWave operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWave.</param>
        /// 
        /// <returns>Returns a  CreateWaveResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/CreateWave">REST API Reference for CreateWave Operation</seealso>
        CreateWaveResponse EndCreateWave(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApplication


        /// <summary>
        /// Delete application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        IAsyncResult BeginDeleteApplication(DeleteApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplication.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteJob


        /// <summary>
        /// Deletes a single Job by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// 
        /// <returns>The response from the DeleteJob service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        DeleteJobResponse DeleteJob(DeleteJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        IAsyncResult BeginDeleteJob(DeleteJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteJob.</param>
        /// 
        /// <returns>Returns a  DeleteJobResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        DeleteJobResponse EndDeleteJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLaunchConfigurationTemplate


        /// <summary>
        /// Deletes a single Launch Configuration Template by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteLaunchConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteLaunchConfigurationTemplate">REST API Reference for DeleteLaunchConfigurationTemplate Operation</seealso>
        DeleteLaunchConfigurationTemplateResponse DeleteLaunchConfigurationTemplate(DeleteLaunchConfigurationTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLaunchConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchConfigurationTemplate operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLaunchConfigurationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteLaunchConfigurationTemplate">REST API Reference for DeleteLaunchConfigurationTemplate Operation</seealso>
        IAsyncResult BeginDeleteLaunchConfigurationTemplate(DeleteLaunchConfigurationTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLaunchConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLaunchConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteLaunchConfigurationTemplateResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteLaunchConfigurationTemplate">REST API Reference for DeleteLaunchConfigurationTemplate Operation</seealso>
        DeleteLaunchConfigurationTemplateResponse EndDeleteLaunchConfigurationTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteReplicationConfigurationTemplate


        /// <summary>
        /// Deletes a single Replication Configuration Template by ID
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteReplicationConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteReplicationConfigurationTemplate">REST API Reference for DeleteReplicationConfigurationTemplate Operation</seealso>
        DeleteReplicationConfigurationTemplateResponse DeleteReplicationConfigurationTemplate(DeleteReplicationConfigurationTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationConfigurationTemplate operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReplicationConfigurationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteReplicationConfigurationTemplate">REST API Reference for DeleteReplicationConfigurationTemplate Operation</seealso>
        IAsyncResult BeginDeleteReplicationConfigurationTemplate(DeleteReplicationConfigurationTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReplicationConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReplicationConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteReplicationConfigurationTemplateResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteReplicationConfigurationTemplate">REST API Reference for DeleteReplicationConfigurationTemplate Operation</seealso>
        DeleteReplicationConfigurationTemplateResponse EndDeleteReplicationConfigurationTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSourceServer


        /// <summary>
        /// Deletes a single source server by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceServer service method.</param>
        /// 
        /// <returns>The response from the DeleteSourceServer service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteSourceServer">REST API Reference for DeleteSourceServer Operation</seealso>
        DeleteSourceServerResponse DeleteSourceServer(DeleteSourceServerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSourceServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSourceServer operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSourceServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteSourceServer">REST API Reference for DeleteSourceServer Operation</seealso>
        IAsyncResult BeginDeleteSourceServer(DeleteSourceServerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSourceServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSourceServer.</param>
        /// 
        /// <returns>Returns a  DeleteSourceServerResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteSourceServer">REST API Reference for DeleteSourceServer Operation</seealso>
        DeleteSourceServerResponse EndDeleteSourceServer(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVcenterClient


        /// <summary>
        /// Deletes a given vCenter client by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVcenterClient service method.</param>
        /// 
        /// <returns>The response from the DeleteVcenterClient service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteVcenterClient">REST API Reference for DeleteVcenterClient Operation</seealso>
        DeleteVcenterClientResponse DeleteVcenterClient(DeleteVcenterClientRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVcenterClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVcenterClient operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVcenterClient
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteVcenterClient">REST API Reference for DeleteVcenterClient Operation</seealso>
        IAsyncResult BeginDeleteVcenterClient(DeleteVcenterClientRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVcenterClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVcenterClient.</param>
        /// 
        /// <returns>Returns a  DeleteVcenterClientResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteVcenterClient">REST API Reference for DeleteVcenterClient Operation</seealso>
        DeleteVcenterClientResponse EndDeleteVcenterClient(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWave


        /// <summary>
        /// Delete wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWave service method.</param>
        /// 
        /// <returns>The response from the DeleteWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteWave">REST API Reference for DeleteWave Operation</seealso>
        DeleteWaveResponse DeleteWave(DeleteWaveRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWave operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWave operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWave
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteWave">REST API Reference for DeleteWave Operation</seealso>
        IAsyncResult BeginDeleteWave(DeleteWaveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWave operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWave.</param>
        /// 
        /// <returns>Returns a  DeleteWaveResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DeleteWave">REST API Reference for DeleteWave Operation</seealso>
        DeleteWaveResponse EndDeleteWave(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeJobLogItems


        /// <summary>
        /// Retrieves detailed job log items with paging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobLogItems service method.</param>
        /// 
        /// <returns>The response from the DescribeJobLogItems service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeJobLogItems">REST API Reference for DescribeJobLogItems Operation</seealso>
        DescribeJobLogItemsResponse DescribeJobLogItems(DescribeJobLogItemsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobLogItems operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobLogItems operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJobLogItems
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeJobLogItems">REST API Reference for DescribeJobLogItems Operation</seealso>
        IAsyncResult BeginDescribeJobLogItems(DescribeJobLogItemsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJobLogItems operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobLogItems.</param>
        /// 
        /// <returns>Returns a  DescribeJobLogItemsResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeJobLogItems">REST API Reference for DescribeJobLogItems Operation</seealso>
        DescribeJobLogItemsResponse EndDescribeJobLogItems(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeJobs


        /// <summary>
        /// Returns a list of Jobs. Use the JobsID and fromDate and toData filters to limit which
        /// jobs are returned. The response is sorted by creationDataTime - latest date first.
        /// Jobs are normally created by the StartTest, StartCutover, and TerminateTargetInstances
        /// APIs. Jobs are also created by DiagnosticLaunch and TerminateDiagnosticInstances,
        /// which are APIs available only to *Support* and only used in response to relevant support
        /// tickets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobs service method.</param>
        /// 
        /// <returns>The response from the DescribeJobs service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeJobs">REST API Reference for DescribeJobs Operation</seealso>
        DescribeJobsResponse DescribeJobs(DescribeJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobs operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeJobs">REST API Reference for DescribeJobs Operation</seealso>
        IAsyncResult BeginDescribeJobs(DescribeJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobs.</param>
        /// 
        /// <returns>Returns a  DescribeJobsResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeJobs">REST API Reference for DescribeJobs Operation</seealso>
        DescribeJobsResponse EndDescribeJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLaunchConfigurationTemplates


        /// <summary>
        /// Lists all Launch Configuration Templates, filtered by Launch Configuration Template
        /// IDs
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurationTemplates service method.</param>
        /// 
        /// <returns>The response from the DescribeLaunchConfigurationTemplates service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeLaunchConfigurationTemplates">REST API Reference for DescribeLaunchConfigurationTemplates Operation</seealso>
        DescribeLaunchConfigurationTemplatesResponse DescribeLaunchConfigurationTemplates(DescribeLaunchConfigurationTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLaunchConfigurationTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchConfigurationTemplates operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLaunchConfigurationTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeLaunchConfigurationTemplates">REST API Reference for DescribeLaunchConfigurationTemplates Operation</seealso>
        IAsyncResult BeginDescribeLaunchConfigurationTemplates(DescribeLaunchConfigurationTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLaunchConfigurationTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLaunchConfigurationTemplates.</param>
        /// 
        /// <returns>Returns a  DescribeLaunchConfigurationTemplatesResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeLaunchConfigurationTemplates">REST API Reference for DescribeLaunchConfigurationTemplates Operation</seealso>
        DescribeLaunchConfigurationTemplatesResponse EndDescribeLaunchConfigurationTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReplicationConfigurationTemplates


        /// <summary>
        /// Lists all ReplicationConfigurationTemplates, filtered by Source Server IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationConfigurationTemplates service method.</param>
        /// 
        /// <returns>The response from the DescribeReplicationConfigurationTemplates service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeReplicationConfigurationTemplates">REST API Reference for DescribeReplicationConfigurationTemplates Operation</seealso>
        DescribeReplicationConfigurationTemplatesResponse DescribeReplicationConfigurationTemplates(DescribeReplicationConfigurationTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationConfigurationTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationConfigurationTemplates operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReplicationConfigurationTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeReplicationConfigurationTemplates">REST API Reference for DescribeReplicationConfigurationTemplates Operation</seealso>
        IAsyncResult BeginDescribeReplicationConfigurationTemplates(DescribeReplicationConfigurationTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReplicationConfigurationTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReplicationConfigurationTemplates.</param>
        /// 
        /// <returns>Returns a  DescribeReplicationConfigurationTemplatesResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeReplicationConfigurationTemplates">REST API Reference for DescribeReplicationConfigurationTemplates Operation</seealso>
        DescribeReplicationConfigurationTemplatesResponse EndDescribeReplicationConfigurationTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSourceServers


        /// <summary>
        /// Retrieves all SourceServers or multiple SourceServers by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceServers service method.</param>
        /// 
        /// <returns>The response from the DescribeSourceServers service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeSourceServers">REST API Reference for DescribeSourceServers Operation</seealso>
        DescribeSourceServersResponse DescribeSourceServers(DescribeSourceServersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSourceServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSourceServers operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSourceServers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeSourceServers">REST API Reference for DescribeSourceServers Operation</seealso>
        IAsyncResult BeginDescribeSourceServers(DescribeSourceServersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSourceServers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSourceServers.</param>
        /// 
        /// <returns>Returns a  DescribeSourceServersResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeSourceServers">REST API Reference for DescribeSourceServers Operation</seealso>
        DescribeSourceServersResponse EndDescribeSourceServers(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVcenterClients


        /// <summary>
        /// Returns a list of the installed vCenter clients.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVcenterClients service method.</param>
        /// 
        /// <returns>The response from the DescribeVcenterClients service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeVcenterClients">REST API Reference for DescribeVcenterClients Operation</seealso>
        DescribeVcenterClientsResponse DescribeVcenterClients(DescribeVcenterClientsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVcenterClients operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVcenterClients operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVcenterClients
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeVcenterClients">REST API Reference for DescribeVcenterClients Operation</seealso>
        IAsyncResult BeginDescribeVcenterClients(DescribeVcenterClientsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVcenterClients operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVcenterClients.</param>
        /// 
        /// <returns>Returns a  DescribeVcenterClientsResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DescribeVcenterClients">REST API Reference for DescribeVcenterClients Operation</seealso>
        DescribeVcenterClientsResponse EndDescribeVcenterClients(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateApplications


        /// <summary>
        /// Disassociate applications from wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateApplications service method.</param>
        /// 
        /// <returns>The response from the DisassociateApplications service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisassociateApplications">REST API Reference for DisassociateApplications Operation</seealso>
        DisassociateApplicationsResponse DisassociateApplications(DisassociateApplicationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateApplications operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisassociateApplications">REST API Reference for DisassociateApplications Operation</seealso>
        IAsyncResult BeginDisassociateApplications(DisassociateApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateApplications.</param>
        /// 
        /// <returns>Returns a  DisassociateApplicationsResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisassociateApplications">REST API Reference for DisassociateApplications Operation</seealso>
        DisassociateApplicationsResponse EndDisassociateApplications(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateSourceServers


        /// <summary>
        /// Disassociate source servers from application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSourceServers service method.</param>
        /// 
        /// <returns>The response from the DisassociateSourceServers service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisassociateSourceServers">REST API Reference for DisassociateSourceServers Operation</seealso>
        DisassociateSourceServersResponse DisassociateSourceServers(DisassociateSourceServersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateSourceServers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSourceServers operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateSourceServers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisassociateSourceServers">REST API Reference for DisassociateSourceServers Operation</seealso>
        IAsyncResult BeginDisassociateSourceServers(DisassociateSourceServersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateSourceServers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateSourceServers.</param>
        /// 
        /// <returns>Returns a  DisassociateSourceServersResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisassociateSourceServers">REST API Reference for DisassociateSourceServers Operation</seealso>
        DisassociateSourceServersResponse EndDisassociateSourceServers(IAsyncResult asyncResult);

        #endregion
        
        #region  DisconnectFromService


        /// <summary>
        /// Disconnects specific Source Servers from Application Migration Service. Data replication
        /// is stopped immediately. All AWS resources created by Application Migration Service
        /// for enabling the replication of these source servers will be terminated / deleted
        /// within 90 minutes. Launched Test or Cutover instances will NOT be terminated. If the
        /// agent on the source server has not been prevented from communicating with the Application
        /// Migration Service service, then it will receive a command to uninstall itself (within
        /// approximately 10 minutes). The following properties of the SourceServer will be changed
        /// immediately: dataReplicationInfo.dataReplicationState will be set to DISCONNECTED;
        /// The totalStorageBytes property for each of dataReplicationInfo.replicatedDisks will
        /// be set to zero; dataReplicationInfo.lagDuration and dataReplicationInfo.lagDuration
        /// will be nullified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectFromService service method.</param>
        /// 
        /// <returns>The response from the DisconnectFromService service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisconnectFromService">REST API Reference for DisconnectFromService Operation</seealso>
        DisconnectFromServiceResponse DisconnectFromService(DisconnectFromServiceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisconnectFromService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisconnectFromService operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisconnectFromService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisconnectFromService">REST API Reference for DisconnectFromService Operation</seealso>
        IAsyncResult BeginDisconnectFromService(DisconnectFromServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisconnectFromService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisconnectFromService.</param>
        /// 
        /// <returns>Returns a  DisconnectFromServiceResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/DisconnectFromService">REST API Reference for DisconnectFromService Operation</seealso>
        DisconnectFromServiceResponse EndDisconnectFromService(IAsyncResult asyncResult);

        #endregion
        
        #region  FinalizeCutover


        /// <summary>
        /// Finalizes the cutover immediately for specific Source Servers. All AWS resources created
        /// by Application Migration Service for enabling the replication of these source servers
        /// will be terminated / deleted within 90 minutes. Launched Test or Cutover instances
        /// will NOT be terminated. The AWS Replication Agent will receive a command to uninstall
        /// itself (within 10 minutes). The following properties of the SourceServer will be changed
        /// immediately: dataReplicationInfo.dataReplicationState will be changed to DISCONNECTED;
        /// The SourceServer.lifeCycle.state will be changed to CUTOVER; The totalStorageBytes
        /// property fo each of dataReplicationInfo.replicatedDisks will be set to zero; dataReplicationInfo.lagDuration
        /// and dataReplicationInfo.lagDuration will be nullified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FinalizeCutover service method.</param>
        /// 
        /// <returns>The response from the FinalizeCutover service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/FinalizeCutover">REST API Reference for FinalizeCutover Operation</seealso>
        FinalizeCutoverResponse FinalizeCutover(FinalizeCutoverRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the FinalizeCutover operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FinalizeCutover operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFinalizeCutover
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/FinalizeCutover">REST API Reference for FinalizeCutover Operation</seealso>
        IAsyncResult BeginFinalizeCutover(FinalizeCutoverRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  FinalizeCutover operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFinalizeCutover.</param>
        /// 
        /// <returns>Returns a  FinalizeCutoverResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/FinalizeCutover">REST API Reference for FinalizeCutover Operation</seealso>
        FinalizeCutoverResponse EndFinalizeCutover(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLaunchConfiguration


        /// <summary>
        /// Lists all LaunchConfigurations available, filtered by Source Server IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLaunchConfiguration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetLaunchConfiguration">REST API Reference for GetLaunchConfiguration Operation</seealso>
        GetLaunchConfigurationResponse GetLaunchConfiguration(GetLaunchConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchConfiguration operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLaunchConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetLaunchConfiguration">REST API Reference for GetLaunchConfiguration Operation</seealso>
        IAsyncResult BeginGetLaunchConfiguration(GetLaunchConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLaunchConfiguration.</param>
        /// 
        /// <returns>Returns a  GetLaunchConfigurationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetLaunchConfiguration">REST API Reference for GetLaunchConfiguration Operation</seealso>
        GetLaunchConfigurationResponse EndGetLaunchConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetReplicationConfiguration


        /// <summary>
        /// Lists all ReplicationConfigurations, filtered by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetReplicationConfiguration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetReplicationConfiguration">REST API Reference for GetReplicationConfiguration Operation</seealso>
        GetReplicationConfigurationResponse GetReplicationConfiguration(GetReplicationConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReplicationConfiguration operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReplicationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetReplicationConfiguration">REST API Reference for GetReplicationConfiguration Operation</seealso>
        IAsyncResult BeginGetReplicationConfiguration(GetReplicationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReplicationConfiguration.</param>
        /// 
        /// <returns>Returns a  GetReplicationConfigurationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/GetReplicationConfiguration">REST API Reference for GetReplicationConfiguration Operation</seealso>
        GetReplicationConfigurationResponse EndGetReplicationConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  InitializeService


        /// <summary>
        /// Initialize Application Migration Service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitializeService service method.</param>
        /// 
        /// <returns>The response from the InitializeService service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/InitializeService">REST API Reference for InitializeService Operation</seealso>
        InitializeServiceResponse InitializeService(InitializeServiceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InitializeService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitializeService operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInitializeService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/InitializeService">REST API Reference for InitializeService Operation</seealso>
        IAsyncResult BeginInitializeService(InitializeServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InitializeService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInitializeService.</param>
        /// 
        /// <returns>Returns a  InitializeServiceResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/InitializeService">REST API Reference for InitializeService Operation</seealso>
        InitializeServiceResponse EndInitializeService(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApplications


        /// <summary>
        /// Retrieves all applications or multiple applications by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListApplications">REST API Reference for ListApplications Operation</seealso>
        IAsyncResult BeginListApplications(ListApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplications.</param>
        /// 
        /// <returns>Returns a  ListApplicationsResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse EndListApplications(IAsyncResult asyncResult);

        #endregion
        
        #region  ListExportErrors


        /// <summary>
        /// List export errors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExportErrors service method.</param>
        /// 
        /// <returns>The response from the ListExportErrors service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListExportErrors">REST API Reference for ListExportErrors Operation</seealso>
        ListExportErrorsResponse ListExportErrors(ListExportErrorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListExportErrors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExportErrors operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExportErrors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListExportErrors">REST API Reference for ListExportErrors Operation</seealso>
        IAsyncResult BeginListExportErrors(ListExportErrorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListExportErrors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExportErrors.</param>
        /// 
        /// <returns>Returns a  ListExportErrorsResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListExportErrors">REST API Reference for ListExportErrors Operation</seealso>
        ListExportErrorsResponse EndListExportErrors(IAsyncResult asyncResult);

        #endregion
        
        #region  ListExports


        /// <summary>
        /// List exports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExports service method.</param>
        /// 
        /// <returns>The response from the ListExports service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListExports">REST API Reference for ListExports Operation</seealso>
        ListExportsResponse ListExports(ListExportsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListExports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExports operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListExports">REST API Reference for ListExports Operation</seealso>
        IAsyncResult BeginListExports(ListExportsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListExports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExports.</param>
        /// 
        /// <returns>Returns a  ListExportsResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListExports">REST API Reference for ListExports Operation</seealso>
        ListExportsResponse EndListExports(IAsyncResult asyncResult);

        #endregion
        
        #region  ListImportErrors


        /// <summary>
        /// List import errors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImportErrors service method.</param>
        /// 
        /// <returns>The response from the ListImportErrors service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListImportErrors">REST API Reference for ListImportErrors Operation</seealso>
        ListImportErrorsResponse ListImportErrors(ListImportErrorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListImportErrors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImportErrors operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImportErrors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListImportErrors">REST API Reference for ListImportErrors Operation</seealso>
        IAsyncResult BeginListImportErrors(ListImportErrorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListImportErrors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImportErrors.</param>
        /// 
        /// <returns>Returns a  ListImportErrorsResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListImportErrors">REST API Reference for ListImportErrors Operation</seealso>
        ListImportErrorsResponse EndListImportErrors(IAsyncResult asyncResult);

        #endregion
        
        #region  ListImports


        /// <summary>
        /// List imports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImports service method.</param>
        /// 
        /// <returns>The response from the ListImports service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListImports">REST API Reference for ListImports Operation</seealso>
        ListImportsResponse ListImports(ListImportsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListImports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImports operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListImports">REST API Reference for ListImports Operation</seealso>
        IAsyncResult BeginListImports(ListImportsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListImports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImports.</param>
        /// 
        /// <returns>Returns a  ListImportsResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListImports">REST API Reference for ListImports Operation</seealso>
        ListImportsResponse EndListImports(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSourceServerActions


        /// <summary>
        /// List source server post migration custom actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSourceServerActions service method.</param>
        /// 
        /// <returns>The response from the ListSourceServerActions service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListSourceServerActions">REST API Reference for ListSourceServerActions Operation</seealso>
        ListSourceServerActionsResponse ListSourceServerActions(ListSourceServerActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSourceServerActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSourceServerActions operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSourceServerActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListSourceServerActions">REST API Reference for ListSourceServerActions Operation</seealso>
        IAsyncResult BeginListSourceServerActions(ListSourceServerActionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSourceServerActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSourceServerActions.</param>
        /// 
        /// <returns>Returns a  ListSourceServerActionsResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListSourceServerActions">REST API Reference for ListSourceServerActions Operation</seealso>
        ListSourceServerActionsResponse EndListSourceServerActions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List all tags for your Application Migration Service resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.InternalServerException">
        /// The server encountered an unexpected condition that prevented it from fulfilling the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTemplateActions


        /// <summary>
        /// List template post migration custom actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateActions service method.</param>
        /// 
        /// <returns>The response from the ListTemplateActions service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListTemplateActions">REST API Reference for ListTemplateActions Operation</seealso>
        ListTemplateActionsResponse ListTemplateActions(ListTemplateActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTemplateActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateActions operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplateActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListTemplateActions">REST API Reference for ListTemplateActions Operation</seealso>
        IAsyncResult BeginListTemplateActions(ListTemplateActionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplateActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplateActions.</param>
        /// 
        /// <returns>Returns a  ListTemplateActionsResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListTemplateActions">REST API Reference for ListTemplateActions Operation</seealso>
        ListTemplateActionsResponse EndListTemplateActions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWaves


        /// <summary>
        /// Retrieves all waves or multiple waves by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWaves service method.</param>
        /// 
        /// <returns>The response from the ListWaves service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListWaves">REST API Reference for ListWaves Operation</seealso>
        ListWavesResponse ListWaves(ListWavesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWaves operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWaves operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWaves
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListWaves">REST API Reference for ListWaves Operation</seealso>
        IAsyncResult BeginListWaves(ListWavesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWaves operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWaves.</param>
        /// 
        /// <returns>Returns a  ListWavesResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/ListWaves">REST API Reference for ListWaves Operation</seealso>
        ListWavesResponse EndListWaves(IAsyncResult asyncResult);

        #endregion
        
        #region  MarkAsArchived


        /// <summary>
        /// Archives specific Source Servers by setting the SourceServer.isArchived property to
        /// true for specified SourceServers by ID. This command only works for SourceServers
        /// with a lifecycle. state which equals DISCONNECTED or CUTOVER.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MarkAsArchived service method.</param>
        /// 
        /// <returns>The response from the MarkAsArchived service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/MarkAsArchived">REST API Reference for MarkAsArchived Operation</seealso>
        MarkAsArchivedResponse MarkAsArchived(MarkAsArchivedRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the MarkAsArchived operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MarkAsArchived operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMarkAsArchived
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/MarkAsArchived">REST API Reference for MarkAsArchived Operation</seealso>
        IAsyncResult BeginMarkAsArchived(MarkAsArchivedRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  MarkAsArchived operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMarkAsArchived.</param>
        /// 
        /// <returns>Returns a  MarkAsArchivedResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/MarkAsArchived">REST API Reference for MarkAsArchived Operation</seealso>
        MarkAsArchivedResponse EndMarkAsArchived(IAsyncResult asyncResult);

        #endregion
        
        #region  PutSourceServerAction


        /// <summary>
        /// Put source server post migration custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSourceServerAction service method.</param>
        /// 
        /// <returns>The response from the PutSourceServerAction service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/PutSourceServerAction">REST API Reference for PutSourceServerAction Operation</seealso>
        PutSourceServerActionResponse PutSourceServerAction(PutSourceServerActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutSourceServerAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSourceServerAction operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSourceServerAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/PutSourceServerAction">REST API Reference for PutSourceServerAction Operation</seealso>
        IAsyncResult BeginPutSourceServerAction(PutSourceServerActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutSourceServerAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSourceServerAction.</param>
        /// 
        /// <returns>Returns a  PutSourceServerActionResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/PutSourceServerAction">REST API Reference for PutSourceServerAction Operation</seealso>
        PutSourceServerActionResponse EndPutSourceServerAction(IAsyncResult asyncResult);

        #endregion
        
        #region  PutTemplateAction


        /// <summary>
        /// Put template post migration custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTemplateAction service method.</param>
        /// 
        /// <returns>The response from the PutTemplateAction service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/PutTemplateAction">REST API Reference for PutTemplateAction Operation</seealso>
        PutTemplateActionResponse PutTemplateAction(PutTemplateActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutTemplateAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTemplateAction operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutTemplateAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/PutTemplateAction">REST API Reference for PutTemplateAction Operation</seealso>
        IAsyncResult BeginPutTemplateAction(PutTemplateActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutTemplateAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTemplateAction.</param>
        /// 
        /// <returns>Returns a  PutTemplateActionResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/PutTemplateAction">REST API Reference for PutTemplateAction Operation</seealso>
        PutTemplateActionResponse EndPutTemplateAction(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveSourceServerAction


        /// <summary>
        /// Remove source server post migration custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceServerAction service method.</param>
        /// 
        /// <returns>The response from the RemoveSourceServerAction service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RemoveSourceServerAction">REST API Reference for RemoveSourceServerAction Operation</seealso>
        RemoveSourceServerActionResponse RemoveSourceServerAction(RemoveSourceServerActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveSourceServerAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveSourceServerAction operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveSourceServerAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RemoveSourceServerAction">REST API Reference for RemoveSourceServerAction Operation</seealso>
        IAsyncResult BeginRemoveSourceServerAction(RemoveSourceServerActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveSourceServerAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveSourceServerAction.</param>
        /// 
        /// <returns>Returns a  RemoveSourceServerActionResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RemoveSourceServerAction">REST API Reference for RemoveSourceServerAction Operation</seealso>
        RemoveSourceServerActionResponse EndRemoveSourceServerAction(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveTemplateAction


        /// <summary>
        /// Remove template post migration custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTemplateAction service method.</param>
        /// 
        /// <returns>The response from the RemoveTemplateAction service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RemoveTemplateAction">REST API Reference for RemoveTemplateAction Operation</seealso>
        RemoveTemplateActionResponse RemoveTemplateAction(RemoveTemplateActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTemplateAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTemplateAction operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTemplateAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RemoveTemplateAction">REST API Reference for RemoveTemplateAction Operation</seealso>
        IAsyncResult BeginRemoveTemplateAction(RemoveTemplateActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTemplateAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTemplateAction.</param>
        /// 
        /// <returns>Returns a  RemoveTemplateActionResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RemoveTemplateAction">REST API Reference for RemoveTemplateAction Operation</seealso>
        RemoveTemplateActionResponse EndRemoveTemplateAction(IAsyncResult asyncResult);

        #endregion
        
        #region  RetryDataReplication


        /// <summary>
        /// Causes the data replication initiation sequence to begin immediately upon next Handshake
        /// for specified SourceServer IDs, regardless of when the previous initiation started.
        /// This command will not work if the SourceServer is not stalled or is in a DISCONNECTED
        /// or STOPPED state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryDataReplication service method.</param>
        /// 
        /// <returns>The response from the RetryDataReplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RetryDataReplication">REST API Reference for RetryDataReplication Operation</seealso>
        RetryDataReplicationResponse RetryDataReplication(RetryDataReplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RetryDataReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetryDataReplication operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetryDataReplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RetryDataReplication">REST API Reference for RetryDataReplication Operation</seealso>
        IAsyncResult BeginRetryDataReplication(RetryDataReplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RetryDataReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetryDataReplication.</param>
        /// 
        /// <returns>Returns a  RetryDataReplicationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/RetryDataReplication">REST API Reference for RetryDataReplication Operation</seealso>
        RetryDataReplicationResponse EndRetryDataReplication(IAsyncResult asyncResult);

        #endregion
        
        #region  StartCutover


        /// <summary>
        /// Launches a Cutover Instance for specific Source Servers. This command starts a LAUNCH
        /// job whose initiatedBy property is StartCutover and changes the SourceServer.lifeCycle.state
        /// property to CUTTING_OVER.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCutover service method.</param>
        /// 
        /// <returns>The response from the StartCutover service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartCutover">REST API Reference for StartCutover Operation</seealso>
        StartCutoverResponse StartCutover(StartCutoverRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartCutover operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCutover operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartCutover
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartCutover">REST API Reference for StartCutover Operation</seealso>
        IAsyncResult BeginStartCutover(StartCutoverRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartCutover operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartCutover.</param>
        /// 
        /// <returns>Returns a  StartCutoverResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartCutover">REST API Reference for StartCutover Operation</seealso>
        StartCutoverResponse EndStartCutover(IAsyncResult asyncResult);

        #endregion
        
        #region  StartExport


        /// <summary>
        /// Start export.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExport service method.</param>
        /// 
        /// <returns>The response from the StartExport service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartExport">REST API Reference for StartExport Operation</seealso>
        StartExportResponse StartExport(StartExportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartExport operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartExport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartExport">REST API Reference for StartExport Operation</seealso>
        IAsyncResult BeginStartExport(StartExportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartExport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartExport.</param>
        /// 
        /// <returns>Returns a  StartExportResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartExport">REST API Reference for StartExport Operation</seealso>
        StartExportResponse EndStartExport(IAsyncResult asyncResult);

        #endregion
        
        #region  StartImport


        /// <summary>
        /// Start import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartImport service method.</param>
        /// 
        /// <returns>The response from the StartImport service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartImport">REST API Reference for StartImport Operation</seealso>
        StartImportResponse StartImport(StartImportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartImport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartImport operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartImport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartImport">REST API Reference for StartImport Operation</seealso>
        IAsyncResult BeginStartImport(StartImportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartImport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartImport.</param>
        /// 
        /// <returns>Returns a  StartImportResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartImport">REST API Reference for StartImport Operation</seealso>
        StartImportResponse EndStartImport(IAsyncResult asyncResult);

        #endregion
        
        #region  StartReplication


        /// <summary>
        /// Starts replication for SNAPSHOT_SHIPPING agents.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartReplication service method.</param>
        /// 
        /// <returns>The response from the StartReplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartReplication">REST API Reference for StartReplication Operation</seealso>
        StartReplicationResponse StartReplication(StartReplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReplication operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartReplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartReplication">REST API Reference for StartReplication Operation</seealso>
        IAsyncResult BeginStartReplication(StartReplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartReplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartReplication.</param>
        /// 
        /// <returns>Returns a  StartReplicationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartReplication">REST API Reference for StartReplication Operation</seealso>
        StartReplicationResponse EndStartReplication(IAsyncResult asyncResult);

        #endregion
        
        #region  StartTest


        /// <summary>
        /// Launches a Test Instance for specific Source Servers. This command starts a LAUNCH
        /// job whose initiatedBy property is StartTest and changes the SourceServer.lifeCycle.state
        /// property to TESTING.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTest service method.</param>
        /// 
        /// <returns>The response from the StartTest service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartTest">REST API Reference for StartTest Operation</seealso>
        StartTestResponse StartTest(StartTestRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartTest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTest operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartTest">REST API Reference for StartTest Operation</seealso>
        IAsyncResult BeginStartTest(StartTestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartTest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTest.</param>
        /// 
        /// <returns>Returns a  StartTestResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/StartTest">REST API Reference for StartTest Operation</seealso>
        StartTestResponse EndStartTest(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or overwrites only the specified tags for the specified Application Migration
        /// Service resource or resources. When you specify an existing tag key, the value is
        /// overwritten with the new value. Each resource can have a maximum of 50 tags. Each
        /// tag consists of a key and optional value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.InternalServerException">
        /// The server encountered an unexpected condition that prevented it from fulfilling the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TerminateTargetInstances


        /// <summary>
        /// Starts a job that terminates specific launched EC2 Test and Cutover instances. This
        /// command will not work for any Source Server with a lifecycle.state of TESTING, CUTTING_OVER,
        /// or CUTOVER.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateTargetInstances service method.</param>
        /// 
        /// <returns>The response from the TerminateTargetInstances service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/TerminateTargetInstances">REST API Reference for TerminateTargetInstances Operation</seealso>
        TerminateTargetInstancesResponse TerminateTargetInstances(TerminateTargetInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateTargetInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateTargetInstances operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateTargetInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/TerminateTargetInstances">REST API Reference for TerminateTargetInstances Operation</seealso>
        IAsyncResult BeginTerminateTargetInstances(TerminateTargetInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateTargetInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateTargetInstances.</param>
        /// 
        /// <returns>Returns a  TerminateTargetInstancesResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/TerminateTargetInstances">REST API Reference for TerminateTargetInstances Operation</seealso>
        TerminateTargetInstancesResponse EndTerminateTargetInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  UnarchiveApplication


        /// <summary>
        /// Unarchive application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveApplication service method.</param>
        /// 
        /// <returns>The response from the UnarchiveApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UnarchiveApplication">REST API Reference for UnarchiveApplication Operation</seealso>
        UnarchiveApplicationResponse UnarchiveApplication(UnarchiveApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UnarchiveApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveApplication operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnarchiveApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UnarchiveApplication">REST API Reference for UnarchiveApplication Operation</seealso>
        IAsyncResult BeginUnarchiveApplication(UnarchiveApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UnarchiveApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnarchiveApplication.</param>
        /// 
        /// <returns>Returns a  UnarchiveApplicationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UnarchiveApplication">REST API Reference for UnarchiveApplication Operation</seealso>
        UnarchiveApplicationResponse EndUnarchiveApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  UnarchiveWave


        /// <summary>
        /// Unarchive wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveWave service method.</param>
        /// 
        /// <returns>The response from the UnarchiveWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ServiceQuotaExceededException">
        /// The request could not be completed because its exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UnarchiveWave">REST API Reference for UnarchiveWave Operation</seealso>
        UnarchiveWaveResponse UnarchiveWave(UnarchiveWaveRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UnarchiveWave operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnarchiveWave operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnarchiveWave
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UnarchiveWave">REST API Reference for UnarchiveWave Operation</seealso>
        IAsyncResult BeginUnarchiveWave(UnarchiveWaveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UnarchiveWave operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnarchiveWave.</param>
        /// 
        /// <returns>Returns a  UnarchiveWaveResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UnarchiveWave">REST API Reference for UnarchiveWave Operation</seealso>
        UnarchiveWaveResponse EndUnarchiveWave(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes the specified set of tags from the specified set of Application Migration
        /// Service resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.InternalServerException">
        /// The server encountered an unexpected condition that prevented it from fulfilling the
        /// request.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ThrottlingException">
        /// Reached throttling quota exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApplication


        /// <summary>
        /// Update application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        IAsyncResult BeginUpdateApplication(UpdateApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplication.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLaunchConfiguration


        /// <summary>
        /// Updates multiple LaunchConfigurations by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateLaunchConfiguration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateLaunchConfiguration">REST API Reference for UpdateLaunchConfiguration Operation</seealso>
        UpdateLaunchConfigurationResponse UpdateLaunchConfiguration(UpdateLaunchConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchConfiguration operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLaunchConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateLaunchConfiguration">REST API Reference for UpdateLaunchConfiguration Operation</seealso>
        IAsyncResult BeginUpdateLaunchConfiguration(UpdateLaunchConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLaunchConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLaunchConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateLaunchConfigurationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateLaunchConfiguration">REST API Reference for UpdateLaunchConfiguration Operation</seealso>
        UpdateLaunchConfigurationResponse EndUpdateLaunchConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLaunchConfigurationTemplate


        /// <summary>
        /// Updates an existing Launch Configuration Template by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateLaunchConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateLaunchConfigurationTemplate">REST API Reference for UpdateLaunchConfigurationTemplate Operation</seealso>
        UpdateLaunchConfigurationTemplateResponse UpdateLaunchConfigurationTemplate(UpdateLaunchConfigurationTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLaunchConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLaunchConfigurationTemplate operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLaunchConfigurationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateLaunchConfigurationTemplate">REST API Reference for UpdateLaunchConfigurationTemplate Operation</seealso>
        IAsyncResult BeginUpdateLaunchConfigurationTemplate(UpdateLaunchConfigurationTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLaunchConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLaunchConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateLaunchConfigurationTemplateResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateLaunchConfigurationTemplate">REST API Reference for UpdateLaunchConfigurationTemplate Operation</seealso>
        UpdateLaunchConfigurationTemplateResponse EndUpdateLaunchConfigurationTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateReplicationConfiguration


        /// <summary>
        /// Allows you to update multiple ReplicationConfigurations by Source Server ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateReplicationConfiguration service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateReplicationConfiguration">REST API Reference for UpdateReplicationConfiguration Operation</seealso>
        UpdateReplicationConfigurationResponse UpdateReplicationConfiguration(UpdateReplicationConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfiguration operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReplicationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateReplicationConfiguration">REST API Reference for UpdateReplicationConfiguration Operation</seealso>
        IAsyncResult BeginUpdateReplicationConfiguration(UpdateReplicationConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReplicationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReplicationConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateReplicationConfigurationResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateReplicationConfiguration">REST API Reference for UpdateReplicationConfiguration Operation</seealso>
        UpdateReplicationConfigurationResponse EndUpdateReplicationConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateReplicationConfigurationTemplate


        /// <summary>
        /// Updates multiple ReplicationConfigurationTemplates by ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfigurationTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateReplicationConfigurationTemplate service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.AccessDeniedException">
        /// Operating denied due to a file permission or access check error.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateReplicationConfigurationTemplate">REST API Reference for UpdateReplicationConfigurationTemplate Operation</seealso>
        UpdateReplicationConfigurationTemplateResponse UpdateReplicationConfigurationTemplate(UpdateReplicationConfigurationTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReplicationConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReplicationConfigurationTemplate operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReplicationConfigurationTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateReplicationConfigurationTemplate">REST API Reference for UpdateReplicationConfigurationTemplate Operation</seealso>
        IAsyncResult BeginUpdateReplicationConfigurationTemplate(UpdateReplicationConfigurationTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReplicationConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReplicationConfigurationTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateReplicationConfigurationTemplateResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateReplicationConfigurationTemplate">REST API Reference for UpdateReplicationConfigurationTemplate Operation</seealso>
        UpdateReplicationConfigurationTemplateResponse EndUpdateReplicationConfigurationTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSourceServerReplicationType


        /// <summary>
        /// Allows you to change between the AGENT_BASED replication type and the SNAPSHOT_SHIPPING
        /// replication type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceServerReplicationType service method.</param>
        /// 
        /// <returns>The response from the UpdateSourceServerReplicationType service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ValidationException">
        /// Validate exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateSourceServerReplicationType">REST API Reference for UpdateSourceServerReplicationType Operation</seealso>
        UpdateSourceServerReplicationTypeResponse UpdateSourceServerReplicationType(UpdateSourceServerReplicationTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSourceServerReplicationType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSourceServerReplicationType operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSourceServerReplicationType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateSourceServerReplicationType">REST API Reference for UpdateSourceServerReplicationType Operation</seealso>
        IAsyncResult BeginUpdateSourceServerReplicationType(UpdateSourceServerReplicationTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSourceServerReplicationType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSourceServerReplicationType.</param>
        /// 
        /// <returns>Returns a  UpdateSourceServerReplicationTypeResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateSourceServerReplicationType">REST API Reference for UpdateSourceServerReplicationType Operation</seealso>
        UpdateSourceServerReplicationTypeResponse EndUpdateSourceServerReplicationType(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWave


        /// <summary>
        /// Update wave.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWave service method.</param>
        /// 
        /// <returns>The response from the UpdateWave service method, as returned by Mgn.</returns>
        /// <exception cref="Amazon.Mgn.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// target resource.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.ResourceNotFoundException">
        /// Resource not found exception.
        /// </exception>
        /// <exception cref="Amazon.Mgn.Model.UninitializedAccountException">
        /// Uninitialized account exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateWave">REST API Reference for UpdateWave Operation</seealso>
        UpdateWaveResponse UpdateWave(UpdateWaveRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWave operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWave operation on AmazonMgnClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWave
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateWave">REST API Reference for UpdateWave Operation</seealso>
        IAsyncResult BeginUpdateWave(UpdateWaveRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWave operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWave.</param>
        /// 
        /// <returns>Returns a  UpdateWaveResult from Mgn.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mgn-2020-02-26/UpdateWave">REST API Reference for UpdateWave Operation</seealso>
        UpdateWaveResponse EndUpdateWave(IAsyncResult asyncResult);

        #endregion
        
    }
}