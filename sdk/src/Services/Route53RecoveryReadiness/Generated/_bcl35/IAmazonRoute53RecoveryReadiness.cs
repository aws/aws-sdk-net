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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Route53RecoveryReadiness.Model;

namespace Amazon.Route53RecoveryReadiness
{
    /// <summary>
    /// Interface for accessing Route53RecoveryReadiness
    ///
    /// AWS Route53 Recovery Readiness
    /// </summary>
    public partial interface IAmazonRoute53RecoveryReadiness : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRoute53RecoveryReadinessPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateCell


        /// <summary>
        /// Creates a new Cell.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCell service method.</param>
        /// 
        /// <returns>The response from the CreateCell service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateCell">REST API Reference for CreateCell Operation</seealso>
        CreateCellResponse CreateCell(CreateCellRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCell operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCell operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCell
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateCell">REST API Reference for CreateCell Operation</seealso>
        IAsyncResult BeginCreateCell(CreateCellRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCell operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCell.</param>
        /// 
        /// <returns>Returns a  CreateCellResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateCell">REST API Reference for CreateCell Operation</seealso>
        CreateCellResponse EndCreateCell(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCrossAccountAuthorization


        /// <summary>
        /// Create a new cross account readiness authorization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCrossAccountAuthorization service method.</param>
        /// 
        /// <returns>The response from the CreateCrossAccountAuthorization service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateCrossAccountAuthorization">REST API Reference for CreateCrossAccountAuthorization Operation</seealso>
        CreateCrossAccountAuthorizationResponse CreateCrossAccountAuthorization(CreateCrossAccountAuthorizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCrossAccountAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCrossAccountAuthorization operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCrossAccountAuthorization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateCrossAccountAuthorization">REST API Reference for CreateCrossAccountAuthorization Operation</seealso>
        IAsyncResult BeginCreateCrossAccountAuthorization(CreateCrossAccountAuthorizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCrossAccountAuthorization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCrossAccountAuthorization.</param>
        /// 
        /// <returns>Returns a  CreateCrossAccountAuthorizationResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateCrossAccountAuthorization">REST API Reference for CreateCrossAccountAuthorization Operation</seealso>
        CreateCrossAccountAuthorizationResponse EndCreateCrossAccountAuthorization(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateReadinessCheck


        /// <summary>
        /// Creates a new Readiness Check.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReadinessCheck service method.</param>
        /// 
        /// <returns>The response from the CreateReadinessCheck service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateReadinessCheck">REST API Reference for CreateReadinessCheck Operation</seealso>
        CreateReadinessCheckResponse CreateReadinessCheck(CreateReadinessCheckRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReadinessCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReadinessCheck operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReadinessCheck
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateReadinessCheck">REST API Reference for CreateReadinessCheck Operation</seealso>
        IAsyncResult BeginCreateReadinessCheck(CreateReadinessCheckRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReadinessCheck operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReadinessCheck.</param>
        /// 
        /// <returns>Returns a  CreateReadinessCheckResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateReadinessCheck">REST API Reference for CreateReadinessCheck Operation</seealso>
        CreateReadinessCheckResponse EndCreateReadinessCheck(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRecoveryGroup


        /// <summary>
        /// Creates a new Recovery Group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecoveryGroup service method.</param>
        /// 
        /// <returns>The response from the CreateRecoveryGroup service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateRecoveryGroup">REST API Reference for CreateRecoveryGroup Operation</seealso>
        CreateRecoveryGroupResponse CreateRecoveryGroup(CreateRecoveryGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRecoveryGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRecoveryGroup operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRecoveryGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateRecoveryGroup">REST API Reference for CreateRecoveryGroup Operation</seealso>
        IAsyncResult BeginCreateRecoveryGroup(CreateRecoveryGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRecoveryGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRecoveryGroup.</param>
        /// 
        /// <returns>Returns a  CreateRecoveryGroupResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateRecoveryGroup">REST API Reference for CreateRecoveryGroup Operation</seealso>
        CreateRecoveryGroupResponse EndCreateRecoveryGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateResourceSet


        /// <summary>
        /// Creates a new Resource Set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceSet service method.</param>
        /// 
        /// <returns>The response from the CreateResourceSet service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateResourceSet">REST API Reference for CreateResourceSet Operation</seealso>
        CreateResourceSetResponse CreateResourceSet(CreateResourceSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResourceSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceSet operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResourceSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateResourceSet">REST API Reference for CreateResourceSet Operation</seealso>
        IAsyncResult BeginCreateResourceSet(CreateResourceSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResourceSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResourceSet.</param>
        /// 
        /// <returns>Returns a  CreateResourceSetResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/CreateResourceSet">REST API Reference for CreateResourceSet Operation</seealso>
        CreateResourceSetResponse EndCreateResourceSet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCell


        /// <summary>
        /// Deletes an existing Cell.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCell service method.</param>
        /// 
        /// <returns>The response from the DeleteCell service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteCell">REST API Reference for DeleteCell Operation</seealso>
        DeleteCellResponse DeleteCell(DeleteCellRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCell operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCell operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCell
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteCell">REST API Reference for DeleteCell Operation</seealso>
        IAsyncResult BeginDeleteCell(DeleteCellRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCell operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCell.</param>
        /// 
        /// <returns>Returns a  DeleteCellResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteCell">REST API Reference for DeleteCell Operation</seealso>
        DeleteCellResponse EndDeleteCell(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCrossAccountAuthorization


        /// <summary>
        /// Delete cross account readiness authorization
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCrossAccountAuthorization service method.</param>
        /// 
        /// <returns>The response from the DeleteCrossAccountAuthorization service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteCrossAccountAuthorization">REST API Reference for DeleteCrossAccountAuthorization Operation</seealso>
        DeleteCrossAccountAuthorizationResponse DeleteCrossAccountAuthorization(DeleteCrossAccountAuthorizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCrossAccountAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCrossAccountAuthorization operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCrossAccountAuthorization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteCrossAccountAuthorization">REST API Reference for DeleteCrossAccountAuthorization Operation</seealso>
        IAsyncResult BeginDeleteCrossAccountAuthorization(DeleteCrossAccountAuthorizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCrossAccountAuthorization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCrossAccountAuthorization.</param>
        /// 
        /// <returns>Returns a  DeleteCrossAccountAuthorizationResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteCrossAccountAuthorization">REST API Reference for DeleteCrossAccountAuthorization Operation</seealso>
        DeleteCrossAccountAuthorizationResponse EndDeleteCrossAccountAuthorization(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteReadinessCheck


        /// <summary>
        /// Deletes an existing Readiness Check.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReadinessCheck service method.</param>
        /// 
        /// <returns>The response from the DeleteReadinessCheck service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteReadinessCheck">REST API Reference for DeleteReadinessCheck Operation</seealso>
        DeleteReadinessCheckResponse DeleteReadinessCheck(DeleteReadinessCheckRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReadinessCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReadinessCheck operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReadinessCheck
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteReadinessCheck">REST API Reference for DeleteReadinessCheck Operation</seealso>
        IAsyncResult BeginDeleteReadinessCheck(DeleteReadinessCheckRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReadinessCheck operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReadinessCheck.</param>
        /// 
        /// <returns>Returns a  DeleteReadinessCheckResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteReadinessCheck">REST API Reference for DeleteReadinessCheck Operation</seealso>
        DeleteReadinessCheckResponse EndDeleteReadinessCheck(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRecoveryGroup


        /// <summary>
        /// Deletes an existing Recovery Group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecoveryGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteRecoveryGroup service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteRecoveryGroup">REST API Reference for DeleteRecoveryGroup Operation</seealso>
        DeleteRecoveryGroupResponse DeleteRecoveryGroup(DeleteRecoveryGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRecoveryGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecoveryGroup operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRecoveryGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteRecoveryGroup">REST API Reference for DeleteRecoveryGroup Operation</seealso>
        IAsyncResult BeginDeleteRecoveryGroup(DeleteRecoveryGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRecoveryGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRecoveryGroup.</param>
        /// 
        /// <returns>Returns a  DeleteRecoveryGroupResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteRecoveryGroup">REST API Reference for DeleteRecoveryGroup Operation</seealso>
        DeleteRecoveryGroupResponse EndDeleteRecoveryGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResourceSet


        /// <summary>
        /// Deletes an existing Resource Set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceSet service method.</param>
        /// 
        /// <returns>The response from the DeleteResourceSet service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteResourceSet">REST API Reference for DeleteResourceSet Operation</seealso>
        DeleteResourceSetResponse DeleteResourceSet(DeleteResourceSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourceSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceSet operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourceSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteResourceSet">REST API Reference for DeleteResourceSet Operation</seealso>
        IAsyncResult BeginDeleteResourceSet(DeleteResourceSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourceSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourceSet.</param>
        /// 
        /// <returns>Returns a  DeleteResourceSetResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/DeleteResourceSet">REST API Reference for DeleteResourceSet Operation</seealso>
        DeleteResourceSetResponse EndDeleteResourceSet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetArchitectureRecommendations


        /// <summary>
        /// Returns a collection of recommendations to improve resilliance and readiness check
        /// quality for a Recovery Group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArchitectureRecommendations service method.</param>
        /// 
        /// <returns>The response from the GetArchitectureRecommendations service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetArchitectureRecommendations">REST API Reference for GetArchitectureRecommendations Operation</seealso>
        GetArchitectureRecommendationsResponse GetArchitectureRecommendations(GetArchitectureRecommendationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetArchitectureRecommendations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetArchitectureRecommendations operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetArchitectureRecommendations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetArchitectureRecommendations">REST API Reference for GetArchitectureRecommendations Operation</seealso>
        IAsyncResult BeginGetArchitectureRecommendations(GetArchitectureRecommendationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetArchitectureRecommendations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetArchitectureRecommendations.</param>
        /// 
        /// <returns>Returns a  GetArchitectureRecommendationsResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetArchitectureRecommendations">REST API Reference for GetArchitectureRecommendations Operation</seealso>
        GetArchitectureRecommendationsResponse EndGetArchitectureRecommendations(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCell


        /// <summary>
        /// Returns information about a Cell.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCell service method.</param>
        /// 
        /// <returns>The response from the GetCell service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetCell">REST API Reference for GetCell Operation</seealso>
        GetCellResponse GetCell(GetCellRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCell operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCell operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCell
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetCell">REST API Reference for GetCell Operation</seealso>
        IAsyncResult BeginGetCell(GetCellRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCell operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCell.</param>
        /// 
        /// <returns>Returns a  GetCellResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetCell">REST API Reference for GetCell Operation</seealso>
        GetCellResponse EndGetCell(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCellReadinessSummary


        /// <summary>
        /// Returns information about readiness of a Cell.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCellReadinessSummary service method.</param>
        /// 
        /// <returns>The response from the GetCellReadinessSummary service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetCellReadinessSummary">REST API Reference for GetCellReadinessSummary Operation</seealso>
        GetCellReadinessSummaryResponse GetCellReadinessSummary(GetCellReadinessSummaryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCellReadinessSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCellReadinessSummary operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCellReadinessSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetCellReadinessSummary">REST API Reference for GetCellReadinessSummary Operation</seealso>
        IAsyncResult BeginGetCellReadinessSummary(GetCellReadinessSummaryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCellReadinessSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCellReadinessSummary.</param>
        /// 
        /// <returns>Returns a  GetCellReadinessSummaryResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetCellReadinessSummary">REST API Reference for GetCellReadinessSummary Operation</seealso>
        GetCellReadinessSummaryResponse EndGetCellReadinessSummary(IAsyncResult asyncResult);

        #endregion
        
        #region  GetReadinessCheck


        /// <summary>
        /// Returns information about a ReadinessCheck.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadinessCheck service method.</param>
        /// 
        /// <returns>The response from the GetReadinessCheck service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetReadinessCheck">REST API Reference for GetReadinessCheck Operation</seealso>
        GetReadinessCheckResponse GetReadinessCheck(GetReadinessCheckRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetReadinessCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReadinessCheck operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReadinessCheck
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetReadinessCheck">REST API Reference for GetReadinessCheck Operation</seealso>
        IAsyncResult BeginGetReadinessCheck(GetReadinessCheckRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReadinessCheck operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReadinessCheck.</param>
        /// 
        /// <returns>Returns a  GetReadinessCheckResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetReadinessCheck">REST API Reference for GetReadinessCheck Operation</seealso>
        GetReadinessCheckResponse EndGetReadinessCheck(IAsyncResult asyncResult);

        #endregion
        
        #region  GetReadinessCheckResourceStatus


        /// <summary>
        /// Returns detailed information about the status of an individual resource within a Readiness
        /// Check's Resource Set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadinessCheckResourceStatus service method.</param>
        /// 
        /// <returns>The response from the GetReadinessCheckResourceStatus service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetReadinessCheckResourceStatus">REST API Reference for GetReadinessCheckResourceStatus Operation</seealso>
        GetReadinessCheckResourceStatusResponse GetReadinessCheckResourceStatus(GetReadinessCheckResourceStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetReadinessCheckResourceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReadinessCheckResourceStatus operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReadinessCheckResourceStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetReadinessCheckResourceStatus">REST API Reference for GetReadinessCheckResourceStatus Operation</seealso>
        IAsyncResult BeginGetReadinessCheckResourceStatus(GetReadinessCheckResourceStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReadinessCheckResourceStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReadinessCheckResourceStatus.</param>
        /// 
        /// <returns>Returns a  GetReadinessCheckResourceStatusResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetReadinessCheckResourceStatus">REST API Reference for GetReadinessCheckResourceStatus Operation</seealso>
        GetReadinessCheckResourceStatusResponse EndGetReadinessCheckResourceStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetReadinessCheckStatus


        /// <summary>
        /// Returns information about the status of a Readiness Check.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReadinessCheckStatus service method.</param>
        /// 
        /// <returns>The response from the GetReadinessCheckStatus service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetReadinessCheckStatus">REST API Reference for GetReadinessCheckStatus Operation</seealso>
        GetReadinessCheckStatusResponse GetReadinessCheckStatus(GetReadinessCheckStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetReadinessCheckStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReadinessCheckStatus operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReadinessCheckStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetReadinessCheckStatus">REST API Reference for GetReadinessCheckStatus Operation</seealso>
        IAsyncResult BeginGetReadinessCheckStatus(GetReadinessCheckStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReadinessCheckStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReadinessCheckStatus.</param>
        /// 
        /// <returns>Returns a  GetReadinessCheckStatusResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetReadinessCheckStatus">REST API Reference for GetReadinessCheckStatus Operation</seealso>
        GetReadinessCheckStatusResponse EndGetReadinessCheckStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRecoveryGroup


        /// <summary>
        /// Returns information about a Recovery Group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryGroup service method.</param>
        /// 
        /// <returns>The response from the GetRecoveryGroup service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetRecoveryGroup">REST API Reference for GetRecoveryGroup Operation</seealso>
        GetRecoveryGroupResponse GetRecoveryGroup(GetRecoveryGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecoveryGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryGroup operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecoveryGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetRecoveryGroup">REST API Reference for GetRecoveryGroup Operation</seealso>
        IAsyncResult BeginGetRecoveryGroup(GetRecoveryGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecoveryGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecoveryGroup.</param>
        /// 
        /// <returns>Returns a  GetRecoveryGroupResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetRecoveryGroup">REST API Reference for GetRecoveryGroup Operation</seealso>
        GetRecoveryGroupResponse EndGetRecoveryGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRecoveryGroupReadinessSummary


        /// <summary>
        /// Returns information about a Recovery Group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryGroupReadinessSummary service method.</param>
        /// 
        /// <returns>The response from the GetRecoveryGroupReadinessSummary service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetRecoveryGroupReadinessSummary">REST API Reference for GetRecoveryGroupReadinessSummary Operation</seealso>
        GetRecoveryGroupReadinessSummaryResponse GetRecoveryGroupReadinessSummary(GetRecoveryGroupReadinessSummaryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecoveryGroupReadinessSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryGroupReadinessSummary operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecoveryGroupReadinessSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetRecoveryGroupReadinessSummary">REST API Reference for GetRecoveryGroupReadinessSummary Operation</seealso>
        IAsyncResult BeginGetRecoveryGroupReadinessSummary(GetRecoveryGroupReadinessSummaryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecoveryGroupReadinessSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecoveryGroupReadinessSummary.</param>
        /// 
        /// <returns>Returns a  GetRecoveryGroupReadinessSummaryResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetRecoveryGroupReadinessSummary">REST API Reference for GetRecoveryGroupReadinessSummary Operation</seealso>
        GetRecoveryGroupReadinessSummaryResponse EndGetRecoveryGroupReadinessSummary(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourceSet


        /// <summary>
        /// Returns information about a Resource Set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceSet service method.</param>
        /// 
        /// <returns>The response from the GetResourceSet service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetResourceSet">REST API Reference for GetResourceSet Operation</seealso>
        GetResourceSetResponse GetResourceSet(GetResourceSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceSet operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetResourceSet">REST API Reference for GetResourceSet Operation</seealso>
        IAsyncResult BeginGetResourceSet(GetResourceSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceSet.</param>
        /// 
        /// <returns>Returns a  GetResourceSetResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/GetResourceSet">REST API Reference for GetResourceSet Operation</seealso>
        GetResourceSetResponse EndGetResourceSet(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCells


        /// <summary>
        /// Returns a collection of Cells.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCells service method.</param>
        /// 
        /// <returns>The response from the ListCells service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListCells">REST API Reference for ListCells Operation</seealso>
        ListCellsResponse ListCells(ListCellsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCells operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCells operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCells
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListCells">REST API Reference for ListCells Operation</seealso>
        IAsyncResult BeginListCells(ListCellsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCells operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCells.</param>
        /// 
        /// <returns>Returns a  ListCellsResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListCells">REST API Reference for ListCells Operation</seealso>
        ListCellsResponse EndListCells(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCrossAccountAuthorizations


        /// <summary>
        /// Returns a collection of cross account readiness authorizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCrossAccountAuthorizations service method.</param>
        /// 
        /// <returns>The response from the ListCrossAccountAuthorizations service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListCrossAccountAuthorizations">REST API Reference for ListCrossAccountAuthorizations Operation</seealso>
        ListCrossAccountAuthorizationsResponse ListCrossAccountAuthorizations(ListCrossAccountAuthorizationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCrossAccountAuthorizations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCrossAccountAuthorizations operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCrossAccountAuthorizations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListCrossAccountAuthorizations">REST API Reference for ListCrossAccountAuthorizations Operation</seealso>
        IAsyncResult BeginListCrossAccountAuthorizations(ListCrossAccountAuthorizationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCrossAccountAuthorizations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCrossAccountAuthorizations.</param>
        /// 
        /// <returns>Returns a  ListCrossAccountAuthorizationsResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListCrossAccountAuthorizations">REST API Reference for ListCrossAccountAuthorizations Operation</seealso>
        ListCrossAccountAuthorizationsResponse EndListCrossAccountAuthorizations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReadinessChecks


        /// <summary>
        /// Returns a collection of Readiness Checks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReadinessChecks service method.</param>
        /// 
        /// <returns>The response from the ListReadinessChecks service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListReadinessChecks">REST API Reference for ListReadinessChecks Operation</seealso>
        ListReadinessChecksResponse ListReadinessChecks(ListReadinessChecksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReadinessChecks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReadinessChecks operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReadinessChecks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListReadinessChecks">REST API Reference for ListReadinessChecks Operation</seealso>
        IAsyncResult BeginListReadinessChecks(ListReadinessChecksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReadinessChecks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReadinessChecks.</param>
        /// 
        /// <returns>Returns a  ListReadinessChecksResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListReadinessChecks">REST API Reference for ListReadinessChecks Operation</seealso>
        ListReadinessChecksResponse EndListReadinessChecks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRecoveryGroups


        /// <summary>
        /// Returns a collection of Recovery Groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryGroups service method.</param>
        /// 
        /// <returns>The response from the ListRecoveryGroups service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListRecoveryGroups">REST API Reference for ListRecoveryGroups Operation</seealso>
        ListRecoveryGroupsResponse ListRecoveryGroups(ListRecoveryGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRecoveryGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryGroups operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRecoveryGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListRecoveryGroups">REST API Reference for ListRecoveryGroups Operation</seealso>
        IAsyncResult BeginListRecoveryGroups(ListRecoveryGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRecoveryGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRecoveryGroups.</param>
        /// 
        /// <returns>Returns a  ListRecoveryGroupsResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListRecoveryGroups">REST API Reference for ListRecoveryGroups Operation</seealso>
        ListRecoveryGroupsResponse EndListRecoveryGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResourceSets


        /// <summary>
        /// Returns a collection of Resource Sets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSets service method.</param>
        /// 
        /// <returns>The response from the ListResourceSets service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListResourceSets">REST API Reference for ListResourceSets Operation</seealso>
        ListResourceSetsResponse ListResourceSets(ListResourceSetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSets operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceSets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListResourceSets">REST API Reference for ListResourceSets Operation</seealso>
        IAsyncResult BeginListResourceSets(ListResourceSetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceSets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceSets.</param>
        /// 
        /// <returns>Returns a  ListResourceSetsResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListResourceSets">REST API Reference for ListResourceSets Operation</seealso>
        ListResourceSetsResponse EndListResourceSets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRules


        /// <summary>
        /// Returns a collection of rules that are applied as part of Readiness Checks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListRules">REST API Reference for ListRules Operation</seealso>
        ListRulesResponse ListRules(ListRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRules operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListRules">REST API Reference for ListRules Operation</seealso>
        IAsyncResult BeginListRules(ListRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRules.</param>
        /// 
        /// <returns>Returns a  ListRulesResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListRules">REST API Reference for ListRules Operation</seealso>
        ListRulesResponse EndListRules(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResources


        /// <summary>
        /// Returns a list of the tags assigned to the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResources service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResources service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListTagsForResources">REST API Reference for ListTagsForResources Operation</seealso>
        ListTagsForResourcesResponse ListTagsForResources(ListTagsForResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResources operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListTagsForResources">REST API Reference for ListTagsForResources Operation</seealso>
        IAsyncResult BeginListTagsForResources(ListTagsForResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResources.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourcesResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/ListTagsForResources">REST API Reference for ListTagsForResources Operation</seealso>
        ListTagsForResourcesResponse EndListTagsForResources(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to the specified resource. You can specify one or more tags to add.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from the specified resource. You can specify one or more tags to remove.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCell


        /// <summary>
        /// Updates an existing Cell.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCell service method.</param>
        /// 
        /// <returns>The response from the UpdateCell service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateCell">REST API Reference for UpdateCell Operation</seealso>
        UpdateCellResponse UpdateCell(UpdateCellRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCell operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCell operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCell
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateCell">REST API Reference for UpdateCell Operation</seealso>
        IAsyncResult BeginUpdateCell(UpdateCellRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCell operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCell.</param>
        /// 
        /// <returns>Returns a  UpdateCellResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateCell">REST API Reference for UpdateCell Operation</seealso>
        UpdateCellResponse EndUpdateCell(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateReadinessCheck


        /// <summary>
        /// Updates an exisiting Readiness Check.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReadinessCheck service method.</param>
        /// 
        /// <returns>The response from the UpdateReadinessCheck service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateReadinessCheck">REST API Reference for UpdateReadinessCheck Operation</seealso>
        UpdateReadinessCheckResponse UpdateReadinessCheck(UpdateReadinessCheckRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReadinessCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReadinessCheck operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReadinessCheck
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateReadinessCheck">REST API Reference for UpdateReadinessCheck Operation</seealso>
        IAsyncResult BeginUpdateReadinessCheck(UpdateReadinessCheckRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReadinessCheck operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReadinessCheck.</param>
        /// 
        /// <returns>Returns a  UpdateReadinessCheckResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateReadinessCheck">REST API Reference for UpdateReadinessCheck Operation</seealso>
        UpdateReadinessCheckResponse EndUpdateReadinessCheck(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRecoveryGroup


        /// <summary>
        /// Updates an existing Recovery Group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecoveryGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateRecoveryGroup service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateRecoveryGroup">REST API Reference for UpdateRecoveryGroup Operation</seealso>
        UpdateRecoveryGroupResponse UpdateRecoveryGroup(UpdateRecoveryGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRecoveryGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecoveryGroup operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRecoveryGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateRecoveryGroup">REST API Reference for UpdateRecoveryGroup Operation</seealso>
        IAsyncResult BeginUpdateRecoveryGroup(UpdateRecoveryGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRecoveryGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRecoveryGroup.</param>
        /// 
        /// <returns>Returns a  UpdateRecoveryGroupResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateRecoveryGroup">REST API Reference for UpdateRecoveryGroup Operation</seealso>
        UpdateRecoveryGroupResponse EndUpdateRecoveryGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateResourceSet


        /// <summary>
        /// Updates an existing Resource Set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceSet service method.</param>
        /// 
        /// <returns>The response from the UpdateResourceSet service method, as returned by Route53RecoveryReadiness.</returns>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.InternalServerException">
        /// An unexpected error occurred.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ResourceNotFoundException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryReadiness.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateResourceSet">REST API Reference for UpdateResourceSet Operation</seealso>
        UpdateResourceSetResponse UpdateResourceSet(UpdateResourceSetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResourceSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceSet operation on AmazonRoute53RecoveryReadinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResourceSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateResourceSet">REST API Reference for UpdateResourceSet Operation</seealso>
        IAsyncResult BeginUpdateResourceSet(UpdateResourceSetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResourceSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResourceSet.</param>
        /// 
        /// <returns>Returns a  UpdateResourceSetResult from Route53RecoveryReadiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-readiness-2019-12-02/UpdateResourceSet">REST API Reference for UpdateResourceSet Operation</seealso>
        UpdateResourceSetResponse EndUpdateResourceSet(IAsyncResult asyncResult);

        #endregion
        
    }
}