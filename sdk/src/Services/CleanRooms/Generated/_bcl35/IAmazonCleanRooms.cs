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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CleanRooms.Model;

namespace Amazon.CleanRooms
{
    /// <summary>
    /// Interface for accessing CleanRooms
    ///
    /// Welcome to the <i>AWS Clean Rooms API Reference</i>.
    /// 
    ///  
    /// <para>
    /// AWS Clean Rooms is an AWS service that helps multiple parties to join their data together
    /// in a secure collaboration workspace. In the collaboration, members who can query and
    /// receive results can get insights into the collective datasets without either party
    /// getting access to the other party's raw data.
    /// </para>
    ///  
    /// <para>
    /// To learn more about AWS Clean Rooms concepts, procedures, and best practices, see
    /// the <a href="https://docs.aws.amazon.com/clean-rooms/latest/userguide/what-is.html">AWS
    /// Clean Rooms User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCleanRooms : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICleanRoomsPaginatorFactory Paginators { get; }
#endif


        
        #region  BatchGetSchema


        /// <summary>
        /// Retrieves multiple schemas by their identifiers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetSchema service method.</param>
        /// 
        /// <returns>The response from the BatchGetSchema service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/BatchGetSchema">REST API Reference for BatchGetSchema Operation</seealso>
        BatchGetSchemaResponse BatchGetSchema(BatchGetSchemaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetSchema operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/BatchGetSchema">REST API Reference for BatchGetSchema Operation</seealso>
        IAsyncResult BeginBatchGetSchema(BatchGetSchemaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetSchema.</param>
        /// 
        /// <returns>Returns a  BatchGetSchemaResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/BatchGetSchema">REST API Reference for BatchGetSchema Operation</seealso>
        BatchGetSchemaResponse EndBatchGetSchema(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCollaboration


        /// <summary>
        /// Creates a new collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCollaboration service method.</param>
        /// 
        /// <returns>The response from the CreateCollaboration service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateCollaboration">REST API Reference for CreateCollaboration Operation</seealso>
        CreateCollaborationResponse CreateCollaboration(CreateCollaborationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCollaboration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCollaboration operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCollaboration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateCollaboration">REST API Reference for CreateCollaboration Operation</seealso>
        IAsyncResult BeginCreateCollaboration(CreateCollaborationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCollaboration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCollaboration.</param>
        /// 
        /// <returns>Returns a  CreateCollaborationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateCollaboration">REST API Reference for CreateCollaboration Operation</seealso>
        CreateCollaborationResponse EndCreateCollaboration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConfiguredTable


        /// <summary>
        /// Creates a new configured table resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTable service method.</param>
        /// 
        /// <returns>The response from the CreateConfiguredTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTable">REST API Reference for CreateConfiguredTable Operation</seealso>
        CreateConfiguredTableResponse CreateConfiguredTable(CreateConfiguredTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfiguredTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTable operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfiguredTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTable">REST API Reference for CreateConfiguredTable Operation</seealso>
        IAsyncResult BeginCreateConfiguredTable(CreateConfiguredTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfiguredTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfiguredTable.</param>
        /// 
        /// <returns>Returns a  CreateConfiguredTableResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTable">REST API Reference for CreateConfiguredTable Operation</seealso>
        CreateConfiguredTableResponse EndCreateConfiguredTable(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConfiguredTableAnalysisRule


        /// <summary>
        /// Creates a new analysis rule for a configured table. Currently, only one analysis rule
        /// can be created for a given configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTableAnalysisRule service method.</param>
        /// 
        /// <returns>The response from the CreateConfiguredTableAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAnalysisRule">REST API Reference for CreateConfiguredTableAnalysisRule Operation</seealso>
        CreateConfiguredTableAnalysisRuleResponse CreateConfiguredTableAnalysisRule(CreateConfiguredTableAnalysisRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfiguredTableAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTableAnalysisRule operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfiguredTableAnalysisRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAnalysisRule">REST API Reference for CreateConfiguredTableAnalysisRule Operation</seealso>
        IAsyncResult BeginCreateConfiguredTableAnalysisRule(CreateConfiguredTableAnalysisRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfiguredTableAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfiguredTableAnalysisRule.</param>
        /// 
        /// <returns>Returns a  CreateConfiguredTableAnalysisRuleResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAnalysisRule">REST API Reference for CreateConfiguredTableAnalysisRule Operation</seealso>
        CreateConfiguredTableAnalysisRuleResponse EndCreateConfiguredTableAnalysisRule(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateConfiguredTableAssociation


        /// <summary>
        /// Creates a configured table association. A configured table association links a configured
        /// table with a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTableAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateConfiguredTableAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAssociation">REST API Reference for CreateConfiguredTableAssociation Operation</seealso>
        CreateConfiguredTableAssociationResponse CreateConfiguredTableAssociation(CreateConfiguredTableAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfiguredTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfiguredTableAssociation operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConfiguredTableAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAssociation">REST API Reference for CreateConfiguredTableAssociation Operation</seealso>
        IAsyncResult BeginCreateConfiguredTableAssociation(CreateConfiguredTableAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConfiguredTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConfiguredTableAssociation.</param>
        /// 
        /// <returns>Returns a  CreateConfiguredTableAssociationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateConfiguredTableAssociation">REST API Reference for CreateConfiguredTableAssociation Operation</seealso>
        CreateConfiguredTableAssociationResponse EndCreateConfiguredTableAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMembership


        /// <summary>
        /// Creates a membership for a specific collaboration identifier and joins the collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembership service method.</param>
        /// 
        /// <returns>The response from the CreateMembership service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        CreateMembershipResponse CreateMembership(CreateMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMembership operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        IAsyncResult BeginCreateMembership(CreateMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMembership.</param>
        /// 
        /// <returns>Returns a  CreateMembershipResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        CreateMembershipResponse EndCreateMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCollaboration


        /// <summary>
        /// Deletes a collaboration. It can only be called by the collaboration owner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollaboration service method.</param>
        /// 
        /// <returns>The response from the DeleteCollaboration service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteCollaboration">REST API Reference for DeleteCollaboration Operation</seealso>
        DeleteCollaborationResponse DeleteCollaboration(DeleteCollaborationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCollaboration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollaboration operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCollaboration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteCollaboration">REST API Reference for DeleteCollaboration Operation</seealso>
        IAsyncResult BeginDeleteCollaboration(DeleteCollaborationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCollaboration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCollaboration.</param>
        /// 
        /// <returns>Returns a  DeleteCollaborationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteCollaboration">REST API Reference for DeleteCollaboration Operation</seealso>
        DeleteCollaborationResponse EndDeleteCollaboration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConfiguredTable


        /// <summary>
        /// Deletes a configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTable service method.</param>
        /// 
        /// <returns>The response from the DeleteConfiguredTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTable">REST API Reference for DeleteConfiguredTable Operation</seealso>
        DeleteConfiguredTableResponse DeleteConfiguredTable(DeleteConfiguredTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfiguredTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTable operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfiguredTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTable">REST API Reference for DeleteConfiguredTable Operation</seealso>
        IAsyncResult BeginDeleteConfiguredTable(DeleteConfiguredTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfiguredTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfiguredTable.</param>
        /// 
        /// <returns>Returns a  DeleteConfiguredTableResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTable">REST API Reference for DeleteConfiguredTable Operation</seealso>
        DeleteConfiguredTableResponse EndDeleteConfiguredTable(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConfiguredTableAnalysisRule


        /// <summary>
        /// Deletes a configured table analysis rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTableAnalysisRule service method.</param>
        /// 
        /// <returns>The response from the DeleteConfiguredTableAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAnalysisRule">REST API Reference for DeleteConfiguredTableAnalysisRule Operation</seealso>
        DeleteConfiguredTableAnalysisRuleResponse DeleteConfiguredTableAnalysisRule(DeleteConfiguredTableAnalysisRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfiguredTableAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTableAnalysisRule operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfiguredTableAnalysisRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAnalysisRule">REST API Reference for DeleteConfiguredTableAnalysisRule Operation</seealso>
        IAsyncResult BeginDeleteConfiguredTableAnalysisRule(DeleteConfiguredTableAnalysisRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfiguredTableAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfiguredTableAnalysisRule.</param>
        /// 
        /// <returns>Returns a  DeleteConfiguredTableAnalysisRuleResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAnalysisRule">REST API Reference for DeleteConfiguredTableAnalysisRule Operation</seealso>
        DeleteConfiguredTableAnalysisRuleResponse EndDeleteConfiguredTableAnalysisRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConfiguredTableAssociation


        /// <summary>
        /// Deletes a configured table association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTableAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteConfiguredTableAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAssociation">REST API Reference for DeleteConfiguredTableAssociation Operation</seealso>
        DeleteConfiguredTableAssociationResponse DeleteConfiguredTableAssociation(DeleteConfiguredTableAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfiguredTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfiguredTableAssociation operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfiguredTableAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAssociation">REST API Reference for DeleteConfiguredTableAssociation Operation</seealso>
        IAsyncResult BeginDeleteConfiguredTableAssociation(DeleteConfiguredTableAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfiguredTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfiguredTableAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteConfiguredTableAssociationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteConfiguredTableAssociation">REST API Reference for DeleteConfiguredTableAssociation Operation</seealso>
        DeleteConfiguredTableAssociationResponse EndDeleteConfiguredTableAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMember


        /// <summary>
        /// Removes the specified member from a collaboration. The removed member is placed in
        /// the Removed status and can't interact with the collaboration. The removed member's
        /// data is inaccessible to active members of the collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMember service method.</param>
        /// 
        /// <returns>The response from the DeleteMember service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteMember">REST API Reference for DeleteMember Operation</seealso>
        DeleteMemberResponse DeleteMember(DeleteMemberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMember operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMember operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMember
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteMember">REST API Reference for DeleteMember Operation</seealso>
        IAsyncResult BeginDeleteMember(DeleteMemberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMember operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMember.</param>
        /// 
        /// <returns>Returns a  DeleteMemberResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteMember">REST API Reference for DeleteMember Operation</seealso>
        DeleteMemberResponse EndDeleteMember(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMembership


        /// <summary>
        /// Deletes a specified membership. All resources under a membership must be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembership service method.</param>
        /// 
        /// <returns>The response from the DeleteMembership service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteMembership">REST API Reference for DeleteMembership Operation</seealso>
        DeleteMembershipResponse DeleteMembership(DeleteMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembership operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteMembership">REST API Reference for DeleteMembership Operation</seealso>
        IAsyncResult BeginDeleteMembership(DeleteMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMembership.</param>
        /// 
        /// <returns>Returns a  DeleteMembershipResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/DeleteMembership">REST API Reference for DeleteMembership Operation</seealso>
        DeleteMembershipResponse EndDeleteMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCollaboration


        /// <summary>
        /// Returns metadata about a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCollaboration service method.</param>
        /// 
        /// <returns>The response from the GetCollaboration service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaboration">REST API Reference for GetCollaboration Operation</seealso>
        GetCollaborationResponse GetCollaboration(GetCollaborationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCollaboration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCollaboration operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCollaboration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaboration">REST API Reference for GetCollaboration Operation</seealso>
        IAsyncResult BeginGetCollaboration(GetCollaborationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCollaboration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCollaboration.</param>
        /// 
        /// <returns>Returns a  GetCollaborationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetCollaboration">REST API Reference for GetCollaboration Operation</seealso>
        GetCollaborationResponse EndGetCollaboration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConfiguredTable


        /// <summary>
        /// Retrieves a configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTable service method.</param>
        /// 
        /// <returns>The response from the GetConfiguredTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTable">REST API Reference for GetConfiguredTable Operation</seealso>
        GetConfiguredTableResponse GetConfiguredTable(GetConfiguredTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfiguredTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTable operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfiguredTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTable">REST API Reference for GetConfiguredTable Operation</seealso>
        IAsyncResult BeginGetConfiguredTable(GetConfiguredTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfiguredTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfiguredTable.</param>
        /// 
        /// <returns>Returns a  GetConfiguredTableResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTable">REST API Reference for GetConfiguredTable Operation</seealso>
        GetConfiguredTableResponse EndGetConfiguredTable(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConfiguredTableAnalysisRule


        /// <summary>
        /// Retrieves a configured table analysis rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTableAnalysisRule service method.</param>
        /// 
        /// <returns>The response from the GetConfiguredTableAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAnalysisRule">REST API Reference for GetConfiguredTableAnalysisRule Operation</seealso>
        GetConfiguredTableAnalysisRuleResponse GetConfiguredTableAnalysisRule(GetConfiguredTableAnalysisRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfiguredTableAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTableAnalysisRule operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfiguredTableAnalysisRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAnalysisRule">REST API Reference for GetConfiguredTableAnalysisRule Operation</seealso>
        IAsyncResult BeginGetConfiguredTableAnalysisRule(GetConfiguredTableAnalysisRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfiguredTableAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfiguredTableAnalysisRule.</param>
        /// 
        /// <returns>Returns a  GetConfiguredTableAnalysisRuleResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAnalysisRule">REST API Reference for GetConfiguredTableAnalysisRule Operation</seealso>
        GetConfiguredTableAnalysisRuleResponse EndGetConfiguredTableAnalysisRule(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConfiguredTableAssociation


        /// <summary>
        /// Retrieves a configured table association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTableAssociation service method.</param>
        /// 
        /// <returns>The response from the GetConfiguredTableAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAssociation">REST API Reference for GetConfiguredTableAssociation Operation</seealso>
        GetConfiguredTableAssociationResponse GetConfiguredTableAssociation(GetConfiguredTableAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConfiguredTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConfiguredTableAssociation operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConfiguredTableAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAssociation">REST API Reference for GetConfiguredTableAssociation Operation</seealso>
        IAsyncResult BeginGetConfiguredTableAssociation(GetConfiguredTableAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConfiguredTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConfiguredTableAssociation.</param>
        /// 
        /// <returns>Returns a  GetConfiguredTableAssociationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetConfiguredTableAssociation">REST API Reference for GetConfiguredTableAssociation Operation</seealso>
        GetConfiguredTableAssociationResponse EndGetConfiguredTableAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMembership


        /// <summary>
        /// Retrieves a specified membership for an identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMembership service method.</param>
        /// 
        /// <returns>The response from the GetMembership service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetMembership">REST API Reference for GetMembership Operation</seealso>
        GetMembershipResponse GetMembership(GetMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMembership operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetMembership">REST API Reference for GetMembership Operation</seealso>
        IAsyncResult BeginGetMembership(GetMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMembership.</param>
        /// 
        /// <returns>Returns a  GetMembershipResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetMembership">REST API Reference for GetMembership Operation</seealso>
        GetMembershipResponse EndGetMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  GetProtectedQuery


        /// <summary>
        /// Returns query processing metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProtectedQuery service method.</param>
        /// 
        /// <returns>The response from the GetProtectedQuery service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetProtectedQuery">REST API Reference for GetProtectedQuery Operation</seealso>
        GetProtectedQueryResponse GetProtectedQuery(GetProtectedQueryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetProtectedQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProtectedQuery operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProtectedQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetProtectedQuery">REST API Reference for GetProtectedQuery Operation</seealso>
        IAsyncResult BeginGetProtectedQuery(GetProtectedQueryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetProtectedQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProtectedQuery.</param>
        /// 
        /// <returns>Returns a  GetProtectedQueryResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetProtectedQuery">REST API Reference for GetProtectedQuery Operation</seealso>
        GetProtectedQueryResponse EndGetProtectedQuery(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSchema


        /// <summary>
        /// Retrieves the schema for a relation within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchema service method.</param>
        /// 
        /// <returns>The response from the GetSchema service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetSchema">REST API Reference for GetSchema Operation</seealso>
        GetSchemaResponse GetSchema(GetSchemaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSchema operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSchema operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSchema
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetSchema">REST API Reference for GetSchema Operation</seealso>
        IAsyncResult BeginGetSchema(GetSchemaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSchema operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSchema.</param>
        /// 
        /// <returns>Returns a  GetSchemaResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetSchema">REST API Reference for GetSchema Operation</seealso>
        GetSchemaResponse EndGetSchema(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSchemaAnalysisRule


        /// <summary>
        /// Retrieves a schema analysis rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaAnalysisRule service method.</param>
        /// 
        /// <returns>The response from the GetSchemaAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetSchemaAnalysisRule">REST API Reference for GetSchemaAnalysisRule Operation</seealso>
        GetSchemaAnalysisRuleResponse GetSchemaAnalysisRule(GetSchemaAnalysisRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSchemaAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaAnalysisRule operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSchemaAnalysisRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetSchemaAnalysisRule">REST API Reference for GetSchemaAnalysisRule Operation</seealso>
        IAsyncResult BeginGetSchemaAnalysisRule(GetSchemaAnalysisRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSchemaAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSchemaAnalysisRule.</param>
        /// 
        /// <returns>Returns a  GetSchemaAnalysisRuleResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/GetSchemaAnalysisRule">REST API Reference for GetSchemaAnalysisRule Operation</seealso>
        GetSchemaAnalysisRuleResponse EndGetSchemaAnalysisRule(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCollaborations


        /// <summary>
        /// Lists collaborations the caller owns, is active in, or has been invited to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborations service method.</param>
        /// 
        /// <returns>The response from the ListCollaborations service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborations">REST API Reference for ListCollaborations Operation</seealso>
        ListCollaborationsResponse ListCollaborations(ListCollaborationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCollaborations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCollaborations operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCollaborations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborations">REST API Reference for ListCollaborations Operation</seealso>
        IAsyncResult BeginListCollaborations(ListCollaborationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCollaborations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCollaborations.</param>
        /// 
        /// <returns>Returns a  ListCollaborationsResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListCollaborations">REST API Reference for ListCollaborations Operation</seealso>
        ListCollaborationsResponse EndListCollaborations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConfiguredTableAssociations


        /// <summary>
        /// Lists configured table associations for a membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredTableAssociations service method.</param>
        /// 
        /// <returns>The response from the ListConfiguredTableAssociations service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredTableAssociations">REST API Reference for ListConfiguredTableAssociations Operation</seealso>
        ListConfiguredTableAssociationsResponse ListConfiguredTableAssociations(ListConfiguredTableAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfiguredTableAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredTableAssociations operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfiguredTableAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredTableAssociations">REST API Reference for ListConfiguredTableAssociations Operation</seealso>
        IAsyncResult BeginListConfiguredTableAssociations(ListConfiguredTableAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfiguredTableAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfiguredTableAssociations.</param>
        /// 
        /// <returns>Returns a  ListConfiguredTableAssociationsResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredTableAssociations">REST API Reference for ListConfiguredTableAssociations Operation</seealso>
        ListConfiguredTableAssociationsResponse EndListConfiguredTableAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConfiguredTables


        /// <summary>
        /// Lists configured tables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredTables service method.</param>
        /// 
        /// <returns>The response from the ListConfiguredTables service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredTables">REST API Reference for ListConfiguredTables Operation</seealso>
        ListConfiguredTablesResponse ListConfiguredTables(ListConfiguredTablesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConfiguredTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConfiguredTables operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConfiguredTables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredTables">REST API Reference for ListConfiguredTables Operation</seealso>
        IAsyncResult BeginListConfiguredTables(ListConfiguredTablesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConfiguredTables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConfiguredTables.</param>
        /// 
        /// <returns>Returns a  ListConfiguredTablesResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListConfiguredTables">REST API Reference for ListConfiguredTables Operation</seealso>
        ListConfiguredTablesResponse EndListConfiguredTables(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMembers


        /// <summary>
        /// Lists all members within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListMembers">REST API Reference for ListMembers Operation</seealso>
        ListMembersResponse ListMembers(ListMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMembers operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListMembers">REST API Reference for ListMembers Operation</seealso>
        IAsyncResult BeginListMembers(ListMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMembers.</param>
        /// 
        /// <returns>Returns a  ListMembersResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListMembers">REST API Reference for ListMembers Operation</seealso>
        ListMembersResponse EndListMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMemberships


        /// <summary>
        /// Lists all memberships resources within the caller's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberships service method.</param>
        /// 
        /// <returns>The response from the ListMemberships service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        ListMembershipsResponse ListMemberships(ListMembershipsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMemberships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMemberships operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMemberships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        IAsyncResult BeginListMemberships(ListMembershipsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMemberships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMemberships.</param>
        /// 
        /// <returns>Returns a  ListMembershipsResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        ListMembershipsResponse EndListMemberships(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProtectedQueries


        /// <summary>
        /// Lists protected queries, sorted by the most recent query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtectedQueries service method.</param>
        /// 
        /// <returns>The response from the ListProtectedQueries service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListProtectedQueries">REST API Reference for ListProtectedQueries Operation</seealso>
        ListProtectedQueriesResponse ListProtectedQueries(ListProtectedQueriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProtectedQueries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProtectedQueries operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProtectedQueries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListProtectedQueries">REST API Reference for ListProtectedQueries Operation</seealso>
        IAsyncResult BeginListProtectedQueries(ListProtectedQueriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProtectedQueries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProtectedQueries.</param>
        /// 
        /// <returns>Returns a  ListProtectedQueriesResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListProtectedQueries">REST API Reference for ListProtectedQueries Operation</seealso>
        ListProtectedQueriesResponse EndListProtectedQueries(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSchemas


        /// <summary>
        /// Lists the schemas for relations within a collaboration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas service method.</param>
        /// 
        /// <returns>The response from the ListSchemas service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        ListSchemasResponse ListSchemas(ListSchemasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSchemas operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSchemas
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        IAsyncResult BeginListSchemas(ListSchemasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSchemas operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSchemas.</param>
        /// 
        /// <returns>Returns a  ListSchemasResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListSchemas">REST API Reference for ListSchemas Operation</seealso>
        ListSchemasResponse EndListSchemas(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all of the tags that have been added to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  StartProtectedQuery


        /// <summary>
        /// Creates a protected query that is started by AWS Clean Rooms.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartProtectedQuery service method.</param>
        /// 
        /// <returns>The response from the StartProtectedQuery service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ServiceQuotaExceededException">
        /// Request denied because service quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/StartProtectedQuery">REST API Reference for StartProtectedQuery Operation</seealso>
        StartProtectedQueryResponse StartProtectedQuery(StartProtectedQueryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartProtectedQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartProtectedQuery operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartProtectedQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/StartProtectedQuery">REST API Reference for StartProtectedQuery Operation</seealso>
        IAsyncResult BeginStartProtectedQuery(StartProtectedQueryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartProtectedQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartProtectedQuery.</param>
        /// 
        /// <returns>Returns a  StartProtectedQueryResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/StartProtectedQuery">REST API Reference for StartProtectedQuery Operation</seealso>
        StartProtectedQueryResponse EndStartProtectedQuery(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag or list of tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCollaboration


        /// <summary>
        /// Updates collaboration metadata and can only be called by the collaboration owner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCollaboration service method.</param>
        /// 
        /// <returns>The response from the UpdateCollaboration service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateCollaboration">REST API Reference for UpdateCollaboration Operation</seealso>
        UpdateCollaborationResponse UpdateCollaboration(UpdateCollaborationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCollaboration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCollaboration operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCollaboration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateCollaboration">REST API Reference for UpdateCollaboration Operation</seealso>
        IAsyncResult BeginUpdateCollaboration(UpdateCollaborationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCollaboration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCollaboration.</param>
        /// 
        /// <returns>Returns a  UpdateCollaborationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateCollaboration">REST API Reference for UpdateCollaboration Operation</seealso>
        UpdateCollaborationResponse EndUpdateCollaboration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConfiguredTable


        /// <summary>
        /// Updates a configured table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTable service method.</param>
        /// 
        /// <returns>The response from the UpdateConfiguredTable service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTable">REST API Reference for UpdateConfiguredTable Operation</seealso>
        UpdateConfiguredTableResponse UpdateConfiguredTable(UpdateConfiguredTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfiguredTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTable operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfiguredTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTable">REST API Reference for UpdateConfiguredTable Operation</seealso>
        IAsyncResult BeginUpdateConfiguredTable(UpdateConfiguredTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfiguredTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfiguredTable.</param>
        /// 
        /// <returns>Returns a  UpdateConfiguredTableResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTable">REST API Reference for UpdateConfiguredTable Operation</seealso>
        UpdateConfiguredTableResponse EndUpdateConfiguredTable(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConfiguredTableAnalysisRule


        /// <summary>
        /// Updates a configured table analysis rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTableAnalysisRule service method.</param>
        /// 
        /// <returns>The response from the UpdateConfiguredTableAnalysisRule service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAnalysisRule">REST API Reference for UpdateConfiguredTableAnalysisRule Operation</seealso>
        UpdateConfiguredTableAnalysisRuleResponse UpdateConfiguredTableAnalysisRule(UpdateConfiguredTableAnalysisRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfiguredTableAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTableAnalysisRule operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfiguredTableAnalysisRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAnalysisRule">REST API Reference for UpdateConfiguredTableAnalysisRule Operation</seealso>
        IAsyncResult BeginUpdateConfiguredTableAnalysisRule(UpdateConfiguredTableAnalysisRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfiguredTableAnalysisRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfiguredTableAnalysisRule.</param>
        /// 
        /// <returns>Returns a  UpdateConfiguredTableAnalysisRuleResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAnalysisRule">REST API Reference for UpdateConfiguredTableAnalysisRule Operation</seealso>
        UpdateConfiguredTableAnalysisRuleResponse EndUpdateConfiguredTableAnalysisRule(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateConfiguredTableAssociation


        /// <summary>
        /// Updates a configured table association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTableAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateConfiguredTableAssociation service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAssociation">REST API Reference for UpdateConfiguredTableAssociation Operation</seealso>
        UpdateConfiguredTableAssociationResponse UpdateConfiguredTableAssociation(UpdateConfiguredTableAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfiguredTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfiguredTableAssociation operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConfiguredTableAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAssociation">REST API Reference for UpdateConfiguredTableAssociation Operation</seealso>
        IAsyncResult BeginUpdateConfiguredTableAssociation(UpdateConfiguredTableAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConfiguredTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConfiguredTableAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateConfiguredTableAssociationResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateConfiguredTableAssociation">REST API Reference for UpdateConfiguredTableAssociation Operation</seealso>
        UpdateConfiguredTableAssociationResponse EndUpdateConfiguredTableAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMembership


        /// <summary>
        /// Updates a membership.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMembership service method.</param>
        /// 
        /// <returns>The response from the UpdateMembership service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateMembership">REST API Reference for UpdateMembership Operation</seealso>
        UpdateMembershipResponse UpdateMembership(UpdateMembershipRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMembership operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMembership operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMembership
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateMembership">REST API Reference for UpdateMembership Operation</seealso>
        IAsyncResult BeginUpdateMembership(UpdateMembershipRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMembership operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMembership.</param>
        /// 
        /// <returns>Returns a  UpdateMembershipResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateMembership">REST API Reference for UpdateMembership Operation</seealso>
        UpdateMembershipResponse EndUpdateMembership(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProtectedQuery


        /// <summary>
        /// Updates the processing of a currently running query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProtectedQuery service method.</param>
        /// 
        /// <returns>The response from the UpdateProtectedQuery service method, as returned by CleanRooms.</returns>
        /// <exception cref="Amazon.CleanRooms.Model.AccessDeniedException">
        /// Caller does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CleanRooms.Model.ValidationException">
        /// The input fails to satisfy the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateProtectedQuery">REST API Reference for UpdateProtectedQuery Operation</seealso>
        UpdateProtectedQueryResponse UpdateProtectedQuery(UpdateProtectedQueryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProtectedQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProtectedQuery operation on AmazonCleanRoomsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProtectedQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateProtectedQuery">REST API Reference for UpdateProtectedQuery Operation</seealso>
        IAsyncResult BeginUpdateProtectedQuery(UpdateProtectedQueryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProtectedQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProtectedQuery.</param>
        /// 
        /// <returns>Returns a  UpdateProtectedQueryResult from CleanRooms.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/cleanrooms-2022-02-17/UpdateProtectedQuery">REST API Reference for UpdateProtectedQuery Operation</seealso>
        UpdateProtectedQueryResponse EndUpdateProtectedQuery(IAsyncResult asyncResult);

        #endregion
        
    }
}