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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MTurk.Model;

namespace Amazon.MTurk
{
    /// <summary>
    /// Interface for accessing MTurk
    ///
    /// Amazon Mechanical Turk API Reference
    /// </summary>
    public partial interface IAmazonMTurk : IAmazonService, IDisposable
    {

        
        #region  AcceptQualificationRequest


        /// <summary>
        /// The <code>AcceptQualificationRequest</code> operation approves a Worker's request
        /// for a Qualification. 
        /// 
        ///  
        /// <para>
        ///  Only the owner of the Qualification type can grant a Qualification request for that
        /// type. 
        /// </para>
        ///  
        /// <para>
        ///  A successful request for the <code>AcceptQualificationRequest</code> operation returns
        /// with no errors and an empty body. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptQualificationRequest service method.</param>
        /// 
        /// <returns>The response from the AcceptQualificationRequest service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/AcceptQualificationRequest">REST API Reference for AcceptQualificationRequest Operation</seealso>
        AcceptQualificationRequestResponse AcceptQualificationRequest(AcceptQualificationRequestRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptQualificationRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptQualificationRequest operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptQualificationRequest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/AcceptQualificationRequest">REST API Reference for AcceptQualificationRequest Operation</seealso>
        IAsyncResult BeginAcceptQualificationRequest(AcceptQualificationRequestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptQualificationRequest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptQualificationRequest.</param>
        /// 
        /// <returns>Returns a  AcceptQualificationRequestResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/AcceptQualificationRequest">REST API Reference for AcceptQualificationRequest Operation</seealso>
        AcceptQualificationRequestResponse EndAcceptQualificationRequest(IAsyncResult asyncResult);

        #endregion
        
        #region  ApproveAssignment


        /// <summary>
        /// The <code>ApproveAssignment</code> operation approves the results of a completed
        /// assignment. 
        /// 
        ///  
        /// <para>
        ///  Approving an assignment initiates two payments from the Requester's Amazon.com account
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  The Worker who submitted the results is paid the reward specified in the HIT. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Amazon Mechanical Turk fees are debited. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If the Requester's account does not have adequate funds for these payments, the call
        /// to ApproveAssignment returns an exception, and the approval is not processed. You
        /// can include an optional feedback message with the approval, which the Worker can see
        /// in the Status section of the web site. 
        /// </para>
        ///  
        /// <para>
        ///  You can also call this operation for assignments that were previous rejected and
        /// approve them by explicitly overriding the previous rejection. This only works on rejected
        /// assignments that were submitted within the previous 30 days and only if the assignment's
        /// related HIT has not been deleted. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApproveAssignment service method.</param>
        /// 
        /// <returns>The response from the ApproveAssignment service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ApproveAssignment">REST API Reference for ApproveAssignment Operation</seealso>
        ApproveAssignmentResponse ApproveAssignment(ApproveAssignmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ApproveAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApproveAssignment operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndApproveAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ApproveAssignment">REST API Reference for ApproveAssignment Operation</seealso>
        IAsyncResult BeginApproveAssignment(ApproveAssignmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ApproveAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginApproveAssignment.</param>
        /// 
        /// <returns>Returns a  ApproveAssignmentResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ApproveAssignment">REST API Reference for ApproveAssignment Operation</seealso>
        ApproveAssignmentResponse EndApproveAssignment(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateQualificationWithWorker


        /// <summary>
        /// The <code>AssociateQualificationWithWorker</code> operation gives a Worker a Qualification.
        /// <code>AssociateQualificationWithWorker</code> does not require that the Worker submit
        /// a Qualification request. It gives the Qualification directly to the Worker. 
        /// 
        ///  
        /// <para>
        ///  You can only assign a Qualification of a Qualification type that you created (using
        /// the <code>CreateQualificationType</code> operation). 
        /// </para>
        ///  <note> 
        /// <para>
        ///  Note: <code>AssociateQualificationWithWorker</code> does not affect any pending Qualification
        /// requests for the Qualification by the Worker. If you assign a Qualification to a Worker,
        /// then later grant a Qualification request made by the Worker, the granting of the request
        /// may modify the Qualification score. To resolve a pending Qualification request without
        /// affecting the Qualification the Worker already has, reject the request with the <code>RejectQualificationRequest</code>
        /// operation. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateQualificationWithWorker service method.</param>
        /// 
        /// <returns>The response from the AssociateQualificationWithWorker service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/AssociateQualificationWithWorker">REST API Reference for AssociateQualificationWithWorker Operation</seealso>
        AssociateQualificationWithWorkerResponse AssociateQualificationWithWorker(AssociateQualificationWithWorkerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateQualificationWithWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateQualificationWithWorker operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateQualificationWithWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/AssociateQualificationWithWorker">REST API Reference for AssociateQualificationWithWorker Operation</seealso>
        IAsyncResult BeginAssociateQualificationWithWorker(AssociateQualificationWithWorkerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateQualificationWithWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateQualificationWithWorker.</param>
        /// 
        /// <returns>Returns a  AssociateQualificationWithWorkerResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/AssociateQualificationWithWorker">REST API Reference for AssociateQualificationWithWorker Operation</seealso>
        AssociateQualificationWithWorkerResponse EndAssociateQualificationWithWorker(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAdditionalAssignmentsForHIT


        /// <summary>
        /// The <code>CreateAdditionalAssignmentsForHIT</code> operation increases the maximum
        /// number of assignments of an existing HIT. 
        /// 
        ///  
        /// <para>
        ///  To extend the maximum number of assignments, specify the number of additional assignments.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// HITs created with fewer than 10 assignments cannot be extended to have 10 or more
        /// assignments. Attempting to add assignments in a way that brings the total number of
        /// assignments for a HIT from fewer than 10 assignments to 10 or more assignments will
        /// result in an <code>AWS.MechanicalTurk.InvalidMaximumAssignmentsIncrease</code> exception.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HITs that were created before July 22, 2015 cannot be extended. Attempting to extend
        /// HITs that were created before July 22, 2015 will result in an <code>AWS.MechanicalTurk.HITTooOldForExtension</code>
        /// exception. 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAdditionalAssignmentsForHIT service method.</param>
        /// 
        /// <returns>The response from the CreateAdditionalAssignmentsForHIT service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateAdditionalAssignmentsForHIT">REST API Reference for CreateAdditionalAssignmentsForHIT Operation</seealso>
        CreateAdditionalAssignmentsForHITResponse CreateAdditionalAssignmentsForHIT(CreateAdditionalAssignmentsForHITRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAdditionalAssignmentsForHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAdditionalAssignmentsForHIT operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAdditionalAssignmentsForHIT
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateAdditionalAssignmentsForHIT">REST API Reference for CreateAdditionalAssignmentsForHIT Operation</seealso>
        IAsyncResult BeginCreateAdditionalAssignmentsForHIT(CreateAdditionalAssignmentsForHITRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAdditionalAssignmentsForHIT operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAdditionalAssignmentsForHIT.</param>
        /// 
        /// <returns>Returns a  CreateAdditionalAssignmentsForHITResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateAdditionalAssignmentsForHIT">REST API Reference for CreateAdditionalAssignmentsForHIT Operation</seealso>
        CreateAdditionalAssignmentsForHITResponse EndCreateAdditionalAssignmentsForHIT(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateHIT


        /// <summary>
        /// The <code>CreateHIT</code> operation creates a new Human Intelligence Task (HIT).
        /// The new HIT is made available for Workers to find and accept on the Amazon Mechanical
        /// Turk website. 
        /// 
        ///  
        /// <para>
        ///  This operation allows you to specify a new HIT by passing in values for the properties
        /// of the HIT, such as its title, reward amount and number of assignments. When you pass
        /// these values to <code>CreateHIT</code>, a new HIT is created for you, with a new <code>HITTypeID</code>.
        /// The HITTypeID can be used to create additional HITs in the future without needing
        /// to specify common parameters such as the title, description and reward amount each
        /// time.
        /// </para>
        ///  
        /// <para>
        ///  An alternative way to create HITs is to first generate a HITTypeID using the <code>CreateHITType</code>
        /// operation and then call the <code>CreateHITWithHITType</code> operation. This is the
        /// recommended best practice for Requesters who are creating large numbers of HITs. 
        /// </para>
        ///  
        /// <para>
        /// CreateHIT also supports several ways to provide question data: by providing a value
        /// for the <code>Question</code> parameter that fully specifies the contents of the HIT,
        /// or by providing a <code>HitLayoutId</code> and associated <code>HitLayoutParameters</code>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        ///  If a HIT is created with 10 or more maximum assignments, there is an additional fee.
        /// For more information, see <a href="https://requester.mturk.com/pricing">Amazon Mechanical
        /// Turk Pricing</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHIT service method.</param>
        /// 
        /// <returns>The response from the CreateHIT service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateHIT">REST API Reference for CreateHIT Operation</seealso>
        CreateHITResponse CreateHIT(CreateHITRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHIT operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHIT
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateHIT">REST API Reference for CreateHIT Operation</seealso>
        IAsyncResult BeginCreateHIT(CreateHITRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHIT operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHIT.</param>
        /// 
        /// <returns>Returns a  CreateHITResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateHIT">REST API Reference for CreateHIT Operation</seealso>
        CreateHITResponse EndCreateHIT(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateHITType


        /// <summary>
        /// The <code>CreateHITType</code> operation creates a new HIT type. This operation allows
        /// you to define a standard set of HIT properties to use when creating HITs. If you register
        /// a HIT type with values that match an existing HIT type, the HIT type ID of the existing
        /// type will be returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHITType service method.</param>
        /// 
        /// <returns>The response from the CreateHITType service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateHITType">REST API Reference for CreateHITType Operation</seealso>
        CreateHITTypeResponse CreateHITType(CreateHITTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHITType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHITType operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHITType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateHITType">REST API Reference for CreateHITType Operation</seealso>
        IAsyncResult BeginCreateHITType(CreateHITTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHITType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHITType.</param>
        /// 
        /// <returns>Returns a  CreateHITTypeResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateHITType">REST API Reference for CreateHITType Operation</seealso>
        CreateHITTypeResponse EndCreateHITType(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateHITWithHITType


        /// <summary>
        /// The <code>CreateHITWithHITType</code> operation creates a new Human Intelligence
        /// Task (HIT) using an existing HITTypeID generated by the <code>CreateHITType</code>
        /// operation. 
        /// 
        ///  
        /// <para>
        ///  This is an alternative way to create HITs from the <code>CreateHIT</code> operation.
        /// This is the recommended best practice for Requesters who are creating large numbers
        /// of HITs. 
        /// </para>
        ///  
        /// <para>
        /// CreateHITWithHITType also supports several ways to provide question data: by providing
        /// a value for the <code>Question</code> parameter that fully specifies the contents
        /// of the HIT, or by providing a <code>HitLayoutId</code> and associated <code>HitLayoutParameters</code>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        ///  If a HIT is created with 10 or more maximum assignments, there is an additional fee.
        /// For more information, see <a href="https://requester.mturk.com/pricing">Amazon Mechanical
        /// Turk Pricing</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHITWithHITType service method.</param>
        /// 
        /// <returns>The response from the CreateHITWithHITType service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateHITWithHITType">REST API Reference for CreateHITWithHITType Operation</seealso>
        CreateHITWithHITTypeResponse CreateHITWithHITType(CreateHITWithHITTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHITWithHITType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHITWithHITType operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHITWithHITType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateHITWithHITType">REST API Reference for CreateHITWithHITType Operation</seealso>
        IAsyncResult BeginCreateHITWithHITType(CreateHITWithHITTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHITWithHITType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHITWithHITType.</param>
        /// 
        /// <returns>Returns a  CreateHITWithHITTypeResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateHITWithHITType">REST API Reference for CreateHITWithHITType Operation</seealso>
        CreateHITWithHITTypeResponse EndCreateHITWithHITType(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateQualificationType


        /// <summary>
        /// The <code>CreateQualificationType</code> operation creates a new Qualification type,
        /// which is represented by a <code>QualificationType</code> data structure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQualificationType service method.</param>
        /// 
        /// <returns>The response from the CreateQualificationType service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateQualificationType">REST API Reference for CreateQualificationType Operation</seealso>
        CreateQualificationTypeResponse CreateQualificationType(CreateQualificationTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateQualificationType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQualificationType operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateQualificationType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateQualificationType">REST API Reference for CreateQualificationType Operation</seealso>
        IAsyncResult BeginCreateQualificationType(CreateQualificationTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateQualificationType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateQualificationType.</param>
        /// 
        /// <returns>Returns a  CreateQualificationTypeResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateQualificationType">REST API Reference for CreateQualificationType Operation</seealso>
        CreateQualificationTypeResponse EndCreateQualificationType(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWorkerBlock


        /// <summary>
        /// The <code>CreateWorkerBlock</code> operation allows you to prevent a Worker from working
        /// on your HITs. For example, you can block a Worker who is producing poor quality work.
        /// You can block up to 100,000 Workers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkerBlock service method.</param>
        /// 
        /// <returns>The response from the CreateWorkerBlock service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateWorkerBlock">REST API Reference for CreateWorkerBlock Operation</seealso>
        CreateWorkerBlockResponse CreateWorkerBlock(CreateWorkerBlockRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkerBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkerBlock operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkerBlock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateWorkerBlock">REST API Reference for CreateWorkerBlock Operation</seealso>
        IAsyncResult BeginCreateWorkerBlock(CreateWorkerBlockRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkerBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkerBlock.</param>
        /// 
        /// <returns>Returns a  CreateWorkerBlockResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/CreateWorkerBlock">REST API Reference for CreateWorkerBlock Operation</seealso>
        CreateWorkerBlockResponse EndCreateWorkerBlock(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteHIT


        /// <summary>
        /// The <code>DeleteHIT</code> operation is used to delete HIT that is no longer needed.
        /// Only the Requester who created the HIT can delete it. 
        /// 
        ///  
        /// <para>
        ///  You can only dispose of HITs that are in the <code>Reviewable</code> state, with
        /// all of their submitted assignments already either approved or rejected. If you call
        /// the DeleteHIT operation on a HIT that is not in the <code>Reviewable</code> state
        /// (for example, that has not expired, or still has active assignments), or on a HIT
        /// that is Reviewable but without all of its submitted assignments already approved or
        /// rejected, the service will return an error. 
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        ///  HITs are automatically disposed of after 120 days. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  After you dispose of a HIT, you can no longer approve the HIT's rejected assignments.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Disposed HITs are not returned in results for the ListHITs operation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Disposing HITs can improve the performance of operations such as ListReviewableHITs
        /// and ListHITs. 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHIT service method.</param>
        /// 
        /// <returns>The response from the DeleteHIT service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DeleteHIT">REST API Reference for DeleteHIT Operation</seealso>
        DeleteHITResponse DeleteHIT(DeleteHITRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteHIT operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteHIT
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DeleteHIT">REST API Reference for DeleteHIT Operation</seealso>
        IAsyncResult BeginDeleteHIT(DeleteHITRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteHIT operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteHIT.</param>
        /// 
        /// <returns>Returns a  DeleteHITResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DeleteHIT">REST API Reference for DeleteHIT Operation</seealso>
        DeleteHITResponse EndDeleteHIT(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteQualificationType


        /// <summary>
        /// The <code>DeleteQualificationType</code> deletes a Qualification type and deletes
        /// any HIT types that are associated with the Qualification type. 
        /// 
        ///  
        /// <para>
        /// This operation does not revoke Qualifications already assigned to Workers because
        /// the Qualifications might be needed for active HITs. If there are any pending requests
        /// for the Qualification type, Amazon Mechanical Turk rejects those requests. After you
        /// delete a Qualification type, you can no longer use it to create HITs or HIT types.
        /// </para>
        ///  <note> 
        /// <para>
        /// DeleteQualificationType must wait for all the HITs that use the deleted Qualification
        /// type to be deleted before completing. It may take up to 48 hours before DeleteQualificationType
        /// completes and the unique name of the Qualification type is available for reuse with
        /// CreateQualificationType.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQualificationType service method.</param>
        /// 
        /// <returns>The response from the DeleteQualificationType service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DeleteQualificationType">REST API Reference for DeleteQualificationType Operation</seealso>
        DeleteQualificationTypeResponse DeleteQualificationType(DeleteQualificationTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQualificationType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQualificationType operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteQualificationType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DeleteQualificationType">REST API Reference for DeleteQualificationType Operation</seealso>
        IAsyncResult BeginDeleteQualificationType(DeleteQualificationTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQualificationType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQualificationType.</param>
        /// 
        /// <returns>Returns a  DeleteQualificationTypeResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DeleteQualificationType">REST API Reference for DeleteQualificationType Operation</seealso>
        DeleteQualificationTypeResponse EndDeleteQualificationType(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkerBlock


        /// <summary>
        /// The <code>DeleteWorkerBlock</code> operation allows you to reinstate a blocked Worker
        /// to work on your HITs. This operation reverses the effects of the CreateWorkerBlock
        /// operation. You need the Worker ID to use this operation. If the Worker ID is missing
        /// or invalid, this operation fails and returns the message “WorkerId is invalid.” If
        /// the specified Worker is not blocked, this operation returns successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkerBlock service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkerBlock service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DeleteWorkerBlock">REST API Reference for DeleteWorkerBlock Operation</seealso>
        DeleteWorkerBlockResponse DeleteWorkerBlock(DeleteWorkerBlockRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkerBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkerBlock operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkerBlock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DeleteWorkerBlock">REST API Reference for DeleteWorkerBlock Operation</seealso>
        IAsyncResult BeginDeleteWorkerBlock(DeleteWorkerBlockRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkerBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkerBlock.</param>
        /// 
        /// <returns>Returns a  DeleteWorkerBlockResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DeleteWorkerBlock">REST API Reference for DeleteWorkerBlock Operation</seealso>
        DeleteWorkerBlockResponse EndDeleteWorkerBlock(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateQualificationFromWorker


        /// <summary>
        /// The <code>DisassociateQualificationFromWorker</code> revokes a previously granted
        /// Qualification from a user. 
        /// 
        ///  
        /// <para>
        ///  You can provide a text message explaining why the Qualification was revoked. The
        /// user who had the Qualification can see this message. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateQualificationFromWorker service method.</param>
        /// 
        /// <returns>The response from the DisassociateQualificationFromWorker service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DisassociateQualificationFromWorker">REST API Reference for DisassociateQualificationFromWorker Operation</seealso>
        DisassociateQualificationFromWorkerResponse DisassociateQualificationFromWorker(DisassociateQualificationFromWorkerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateQualificationFromWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateQualificationFromWorker operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateQualificationFromWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DisassociateQualificationFromWorker">REST API Reference for DisassociateQualificationFromWorker Operation</seealso>
        IAsyncResult BeginDisassociateQualificationFromWorker(DisassociateQualificationFromWorkerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateQualificationFromWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateQualificationFromWorker.</param>
        /// 
        /// <returns>Returns a  DisassociateQualificationFromWorkerResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/DisassociateQualificationFromWorker">REST API Reference for DisassociateQualificationFromWorker Operation</seealso>
        DisassociateQualificationFromWorkerResponse EndDisassociateQualificationFromWorker(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccountBalance


        /// <summary>
        /// The <code>GetAccountBalance</code> operation retrieves the amount of money in your
        /// Amazon Mechanical Turk account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountBalance service method.</param>
        /// 
        /// <returns>The response from the GetAccountBalance service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetAccountBalance">REST API Reference for GetAccountBalance Operation</seealso>
        GetAccountBalanceResponse GetAccountBalance(GetAccountBalanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountBalance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountBalance operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountBalance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetAccountBalance">REST API Reference for GetAccountBalance Operation</seealso>
        IAsyncResult BeginGetAccountBalance(GetAccountBalanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountBalance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountBalance.</param>
        /// 
        /// <returns>Returns a  GetAccountBalanceResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetAccountBalance">REST API Reference for GetAccountBalance Operation</seealso>
        GetAccountBalanceResponse EndGetAccountBalance(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAssignment


        /// <summary>
        /// The <code>GetAssignment</code> operation retrieves the details of the specified Assignment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssignment service method.</param>
        /// 
        /// <returns>The response from the GetAssignment service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetAssignment">REST API Reference for GetAssignment Operation</seealso>
        GetAssignmentResponse GetAssignment(GetAssignmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAssignment operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetAssignment">REST API Reference for GetAssignment Operation</seealso>
        IAsyncResult BeginGetAssignment(GetAssignmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAssignment.</param>
        /// 
        /// <returns>Returns a  GetAssignmentResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetAssignment">REST API Reference for GetAssignment Operation</seealso>
        GetAssignmentResponse EndGetAssignment(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFileUploadURL


        /// <summary>
        /// The <code>GetFileUploadURL</code> operation generates and returns a temporary URL.
        /// You use the temporary URL to retrieve a file uploaded by a Worker as an answer to
        /// a FileUploadAnswer question for a HIT. The temporary URL is generated the instant
        /// the GetFileUploadURL operation is called, and is valid for 60 seconds. You can get
        /// a temporary file upload URL any time until the HIT is disposed. After the HIT is disposed,
        /// any uploaded files are deleted, and cannot be retrieved. Pending Deprecation on December
        /// 12, 2017. The Answer Specification structure will no longer support the <code>FileUploadAnswer</code>
        /// element to be used for the QuestionForm data structure. Instead, we recommend that
        /// Requesters who want to create HITs asking Workers to upload files to use Amazon S3.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFileUploadURL service method.</param>
        /// 
        /// <returns>The response from the GetFileUploadURL service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetFileUploadURL">REST API Reference for GetFileUploadURL Operation</seealso>
        GetFileUploadURLResponse GetFileUploadURL(GetFileUploadURLRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFileUploadURL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFileUploadURL operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFileUploadURL
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetFileUploadURL">REST API Reference for GetFileUploadURL Operation</seealso>
        IAsyncResult BeginGetFileUploadURL(GetFileUploadURLRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFileUploadURL operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFileUploadURL.</param>
        /// 
        /// <returns>Returns a  GetFileUploadURLResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetFileUploadURL">REST API Reference for GetFileUploadURL Operation</seealso>
        GetFileUploadURLResponse EndGetFileUploadURL(IAsyncResult asyncResult);

        #endregion
        
        #region  GetHIT


        /// <summary>
        /// The <code>GetHIT</code> operation retrieves the details of the specified HIT.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHIT service method.</param>
        /// 
        /// <returns>The response from the GetHIT service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetHIT">REST API Reference for GetHIT Operation</seealso>
        GetHITResponse GetHIT(GetHITRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHIT operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHIT
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetHIT">REST API Reference for GetHIT Operation</seealso>
        IAsyncResult BeginGetHIT(GetHITRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetHIT operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHIT.</param>
        /// 
        /// <returns>Returns a  GetHITResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetHIT">REST API Reference for GetHIT Operation</seealso>
        GetHITResponse EndGetHIT(IAsyncResult asyncResult);

        #endregion
        
        #region  GetQualificationScore


        /// <summary>
        /// The <code>GetQualificationScore</code> operation returns the value of a Worker's
        /// Qualification for a given Qualification type. 
        /// 
        ///  
        /// <para>
        ///  To get a Worker's Qualification, you must know the Worker's ID. The Worker's ID is
        /// included in the assignment data returned by the <code>ListAssignmentsForHIT</code>
        /// operation. 
        /// </para>
        ///  
        /// <para>
        /// Only the owner of a Qualification type can query the value of a Worker's Qualification
        /// of that type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQualificationScore service method.</param>
        /// 
        /// <returns>The response from the GetQualificationScore service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetQualificationScore">REST API Reference for GetQualificationScore Operation</seealso>
        GetQualificationScoreResponse GetQualificationScore(GetQualificationScoreRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetQualificationScore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQualificationScore operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQualificationScore
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetQualificationScore">REST API Reference for GetQualificationScore Operation</seealso>
        IAsyncResult BeginGetQualificationScore(GetQualificationScoreRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetQualificationScore operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQualificationScore.</param>
        /// 
        /// <returns>Returns a  GetQualificationScoreResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetQualificationScore">REST API Reference for GetQualificationScore Operation</seealso>
        GetQualificationScoreResponse EndGetQualificationScore(IAsyncResult asyncResult);

        #endregion
        
        #region  GetQualificationType


        /// <summary>
        /// The <code>GetQualificationType</code>operation retrieves information about a Qualification
        /// type using its ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQualificationType service method.</param>
        /// 
        /// <returns>The response from the GetQualificationType service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetQualificationType">REST API Reference for GetQualificationType Operation</seealso>
        GetQualificationTypeResponse GetQualificationType(GetQualificationTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetQualificationType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQualificationType operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQualificationType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetQualificationType">REST API Reference for GetQualificationType Operation</seealso>
        IAsyncResult BeginGetQualificationType(GetQualificationTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetQualificationType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQualificationType.</param>
        /// 
        /// <returns>Returns a  GetQualificationTypeResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/GetQualificationType">REST API Reference for GetQualificationType Operation</seealso>
        GetQualificationTypeResponse EndGetQualificationType(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAssignmentsForHIT


        /// <summary>
        /// The <code>ListAssignmentsForHIT</code> operation retrieves completed assignments
        /// for a HIT. You can use this operation to retrieve the results for a HIT. 
        /// 
        ///  
        /// <para>
        ///  You can get assignments for a HIT at any time, even if the HIT is not yet Reviewable.
        /// If a HIT requested multiple assignments, and has received some results but has not
        /// yet become Reviewable, you can still retrieve the partial results with this operation.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Use the AssignmentStatus parameter to control which set of assignments for a HIT
        /// are returned. The ListAssignmentsForHIT operation can return submitted assignments
        /// awaiting approval, or it can return assignments that have already been approved or
        /// rejected. You can set AssignmentStatus=Approved,Rejected to get assignments that have
        /// already been approved and rejected together in one result set. 
        /// </para>
        ///  
        /// <para>
        ///  Only the Requester who created the HIT can retrieve the assignments for that HIT.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  Results are sorted and divided into numbered pages and the operation returns a single
        /// page of results. You can use the parameters of the operation to control sorting and
        /// pagination. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssignmentsForHIT service method.</param>
        /// 
        /// <returns>The response from the ListAssignmentsForHIT service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListAssignmentsForHIT">REST API Reference for ListAssignmentsForHIT Operation</seealso>
        ListAssignmentsForHITResponse ListAssignmentsForHIT(ListAssignmentsForHITRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssignmentsForHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssignmentsForHIT operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssignmentsForHIT
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListAssignmentsForHIT">REST API Reference for ListAssignmentsForHIT Operation</seealso>
        IAsyncResult BeginListAssignmentsForHIT(ListAssignmentsForHITRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssignmentsForHIT operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssignmentsForHIT.</param>
        /// 
        /// <returns>Returns a  ListAssignmentsForHITResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListAssignmentsForHIT">REST API Reference for ListAssignmentsForHIT Operation</seealso>
        ListAssignmentsForHITResponse EndListAssignmentsForHIT(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBonusPayments


        /// <summary>
        /// The <code>ListBonusPayments</code> operation retrieves the amounts of bonuses you
        /// have paid to Workers for a given HIT or assignment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBonusPayments service method.</param>
        /// 
        /// <returns>The response from the ListBonusPayments service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListBonusPayments">REST API Reference for ListBonusPayments Operation</seealso>
        ListBonusPaymentsResponse ListBonusPayments(ListBonusPaymentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBonusPayments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBonusPayments operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBonusPayments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListBonusPayments">REST API Reference for ListBonusPayments Operation</seealso>
        IAsyncResult BeginListBonusPayments(ListBonusPaymentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBonusPayments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBonusPayments.</param>
        /// 
        /// <returns>Returns a  ListBonusPaymentsResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListBonusPayments">REST API Reference for ListBonusPayments Operation</seealso>
        ListBonusPaymentsResponse EndListBonusPayments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListHITs


        /// <summary>
        /// The <code>ListHITs</code> operation returns all of a Requester's HITs. The operation
        /// returns HITs of any status, except for HITs that have been deleted of with the DeleteHIT
        /// operation or that have been auto-deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHITs service method.</param>
        /// 
        /// <returns>The response from the ListHITs service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListHITs">REST API Reference for ListHITs Operation</seealso>
        ListHITsResponse ListHITs(ListHITsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHITs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHITs operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHITs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListHITs">REST API Reference for ListHITs Operation</seealso>
        IAsyncResult BeginListHITs(ListHITsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListHITs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHITs.</param>
        /// 
        /// <returns>Returns a  ListHITsResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListHITs">REST API Reference for ListHITs Operation</seealso>
        ListHITsResponse EndListHITs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListHITsForQualificationType


        /// <summary>
        /// The <code>ListHITsForQualificationType</code> operation returns the HITs that use
        /// the given Qualification type for a Qualification requirement. The operation returns
        /// HITs of any status, except for HITs that have been deleted with the <code>DeleteHIT</code>
        /// operation or that have been auto-deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHITsForQualificationType service method.</param>
        /// 
        /// <returns>The response from the ListHITsForQualificationType service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListHITsForQualificationType">REST API Reference for ListHITsForQualificationType Operation</seealso>
        ListHITsForQualificationTypeResponse ListHITsForQualificationType(ListHITsForQualificationTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHITsForQualificationType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHITsForQualificationType operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHITsForQualificationType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListHITsForQualificationType">REST API Reference for ListHITsForQualificationType Operation</seealso>
        IAsyncResult BeginListHITsForQualificationType(ListHITsForQualificationTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListHITsForQualificationType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHITsForQualificationType.</param>
        /// 
        /// <returns>Returns a  ListHITsForQualificationTypeResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListHITsForQualificationType">REST API Reference for ListHITsForQualificationType Operation</seealso>
        ListHITsForQualificationTypeResponse EndListHITsForQualificationType(IAsyncResult asyncResult);

        #endregion
        
        #region  ListQualificationRequests


        /// <summary>
        /// The <code>ListQualificationRequests</code> operation retrieves requests for Qualifications
        /// of a particular Qualification type. The owner of the Qualification type calls this
        /// operation to poll for pending requests, and accepts them using the AcceptQualification
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQualificationRequests service method.</param>
        /// 
        /// <returns>The response from the ListQualificationRequests service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListQualificationRequests">REST API Reference for ListQualificationRequests Operation</seealso>
        ListQualificationRequestsResponse ListQualificationRequests(ListQualificationRequestsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListQualificationRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQualificationRequests operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQualificationRequests
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListQualificationRequests">REST API Reference for ListQualificationRequests Operation</seealso>
        IAsyncResult BeginListQualificationRequests(ListQualificationRequestsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListQualificationRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQualificationRequests.</param>
        /// 
        /// <returns>Returns a  ListQualificationRequestsResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListQualificationRequests">REST API Reference for ListQualificationRequests Operation</seealso>
        ListQualificationRequestsResponse EndListQualificationRequests(IAsyncResult asyncResult);

        #endregion
        
        #region  ListQualificationTypes


        /// <summary>
        /// The <code>ListQualificationTypes</code> operation returns a list of Qualification
        /// types, filtered by an optional search term.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQualificationTypes service method.</param>
        /// 
        /// <returns>The response from the ListQualificationTypes service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListQualificationTypes">REST API Reference for ListQualificationTypes Operation</seealso>
        ListQualificationTypesResponse ListQualificationTypes(ListQualificationTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListQualificationTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQualificationTypes operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQualificationTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListQualificationTypes">REST API Reference for ListQualificationTypes Operation</seealso>
        IAsyncResult BeginListQualificationTypes(ListQualificationTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListQualificationTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQualificationTypes.</param>
        /// 
        /// <returns>Returns a  ListQualificationTypesResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListQualificationTypes">REST API Reference for ListQualificationTypes Operation</seealso>
        ListQualificationTypesResponse EndListQualificationTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReviewableHITs


        /// <summary>
        /// The <code>ListReviewableHITs</code> operation retrieves the HITs with Status equal
        /// to Reviewable or Status equal to Reviewing that belong to the Requester calling the
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReviewableHITs service method.</param>
        /// 
        /// <returns>The response from the ListReviewableHITs service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListReviewableHITs">REST API Reference for ListReviewableHITs Operation</seealso>
        ListReviewableHITsResponse ListReviewableHITs(ListReviewableHITsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReviewableHITs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReviewableHITs operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReviewableHITs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListReviewableHITs">REST API Reference for ListReviewableHITs Operation</seealso>
        IAsyncResult BeginListReviewableHITs(ListReviewableHITsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReviewableHITs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReviewableHITs.</param>
        /// 
        /// <returns>Returns a  ListReviewableHITsResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListReviewableHITs">REST API Reference for ListReviewableHITs Operation</seealso>
        ListReviewableHITsResponse EndListReviewableHITs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReviewPolicyResultsForHIT


        /// <summary>
        /// The <code>ListReviewPolicyResultsForHIT</code> operation retrieves the computed results
        /// and the actions taken in the course of executing your Review Policies for a given
        /// HIT. For information about how to specify Review Policies when you call CreateHIT,
        /// see Review Policies. The ListReviewPolicyResultsForHIT operation can return results
        /// for both Assignment-level and HIT-level review results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReviewPolicyResultsForHIT service method.</param>
        /// 
        /// <returns>The response from the ListReviewPolicyResultsForHIT service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListReviewPolicyResultsForHIT">REST API Reference for ListReviewPolicyResultsForHIT Operation</seealso>
        ListReviewPolicyResultsForHITResponse ListReviewPolicyResultsForHIT(ListReviewPolicyResultsForHITRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReviewPolicyResultsForHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReviewPolicyResultsForHIT operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReviewPolicyResultsForHIT
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListReviewPolicyResultsForHIT">REST API Reference for ListReviewPolicyResultsForHIT Operation</seealso>
        IAsyncResult BeginListReviewPolicyResultsForHIT(ListReviewPolicyResultsForHITRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReviewPolicyResultsForHIT operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReviewPolicyResultsForHIT.</param>
        /// 
        /// <returns>Returns a  ListReviewPolicyResultsForHITResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListReviewPolicyResultsForHIT">REST API Reference for ListReviewPolicyResultsForHIT Operation</seealso>
        ListReviewPolicyResultsForHITResponse EndListReviewPolicyResultsForHIT(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkerBlocks


        /// <summary>
        /// The <code>ListWorkersBlocks</code> operation retrieves a list of Workers who are blocked
        /// from working on your HITs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkerBlocks service method.</param>
        /// 
        /// <returns>The response from the ListWorkerBlocks service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListWorkerBlocks">REST API Reference for ListWorkerBlocks Operation</seealso>
        ListWorkerBlocksResponse ListWorkerBlocks(ListWorkerBlocksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkerBlocks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkerBlocks operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkerBlocks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListWorkerBlocks">REST API Reference for ListWorkerBlocks Operation</seealso>
        IAsyncResult BeginListWorkerBlocks(ListWorkerBlocksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkerBlocks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkerBlocks.</param>
        /// 
        /// <returns>Returns a  ListWorkerBlocksResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListWorkerBlocks">REST API Reference for ListWorkerBlocks Operation</seealso>
        ListWorkerBlocksResponse EndListWorkerBlocks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkersWithQualificationType


        /// <summary>
        /// The <code>ListWorkersWithQualificationType</code> operation returns all of the Workers
        /// that have been associated with a given Qualification type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkersWithQualificationType service method.</param>
        /// 
        /// <returns>The response from the ListWorkersWithQualificationType service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListWorkersWithQualificationType">REST API Reference for ListWorkersWithQualificationType Operation</seealso>
        ListWorkersWithQualificationTypeResponse ListWorkersWithQualificationType(ListWorkersWithQualificationTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkersWithQualificationType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkersWithQualificationType operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkersWithQualificationType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListWorkersWithQualificationType">REST API Reference for ListWorkersWithQualificationType Operation</seealso>
        IAsyncResult BeginListWorkersWithQualificationType(ListWorkersWithQualificationTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkersWithQualificationType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkersWithQualificationType.</param>
        /// 
        /// <returns>Returns a  ListWorkersWithQualificationTypeResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/ListWorkersWithQualificationType">REST API Reference for ListWorkersWithQualificationType Operation</seealso>
        ListWorkersWithQualificationTypeResponse EndListWorkersWithQualificationType(IAsyncResult asyncResult);

        #endregion
        
        #region  NotifyWorkers


        /// <summary>
        /// The <code>NotifyWorkers</code> operation sends an email to one or more Workers that
        /// you specify with the Worker ID. You can specify up to 100 Worker IDs to send the same
        /// message with a single call to the NotifyWorkers operation. The NotifyWorkers operation
        /// will send a notification email to a Worker only if you have previously approved or
        /// rejected work from the Worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NotifyWorkers service method.</param>
        /// 
        /// <returns>The response from the NotifyWorkers service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/NotifyWorkers">REST API Reference for NotifyWorkers Operation</seealso>
        NotifyWorkersResponse NotifyWorkers(NotifyWorkersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the NotifyWorkers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NotifyWorkers operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNotifyWorkers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/NotifyWorkers">REST API Reference for NotifyWorkers Operation</seealso>
        IAsyncResult BeginNotifyWorkers(NotifyWorkersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  NotifyWorkers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNotifyWorkers.</param>
        /// 
        /// <returns>Returns a  NotifyWorkersResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/NotifyWorkers">REST API Reference for NotifyWorkers Operation</seealso>
        NotifyWorkersResponse EndNotifyWorkers(IAsyncResult asyncResult);

        #endregion
        
        #region  RejectAssignment


        /// <summary>
        /// The <code>RejectAssignment</code> operation rejects the results of a completed assignment.
        /// 
        /// 
        ///  
        /// <para>
        ///  You can include an optional feedback message with the rejection, which the Worker
        /// can see in the Status section of the web site. When you include a feedback message
        /// with the rejection, it helps the Worker understand why the assignment was rejected,
        /// and can improve the quality of the results the Worker submits in the future. 
        /// </para>
        ///  
        /// <para>
        ///  Only the Requester who created the HIT can reject an assignment for the HIT. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectAssignment service method.</param>
        /// 
        /// <returns>The response from the RejectAssignment service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/RejectAssignment">REST API Reference for RejectAssignment Operation</seealso>
        RejectAssignmentResponse RejectAssignment(RejectAssignmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RejectAssignment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectAssignment operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectAssignment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/RejectAssignment">REST API Reference for RejectAssignment Operation</seealso>
        IAsyncResult BeginRejectAssignment(RejectAssignmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RejectAssignment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectAssignment.</param>
        /// 
        /// <returns>Returns a  RejectAssignmentResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/RejectAssignment">REST API Reference for RejectAssignment Operation</seealso>
        RejectAssignmentResponse EndRejectAssignment(IAsyncResult asyncResult);

        #endregion
        
        #region  RejectQualificationRequest


        /// <summary>
        /// The <code>RejectQualificationRequest</code> operation rejects a user's request for
        /// a Qualification. 
        /// 
        ///  
        /// <para>
        ///  You can provide a text message explaining why the request was rejected. The Worker
        /// who made the request can see this message.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectQualificationRequest service method.</param>
        /// 
        /// <returns>The response from the RejectQualificationRequest service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/RejectQualificationRequest">REST API Reference for RejectQualificationRequest Operation</seealso>
        RejectQualificationRequestResponse RejectQualificationRequest(RejectQualificationRequestRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RejectQualificationRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectQualificationRequest operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectQualificationRequest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/RejectQualificationRequest">REST API Reference for RejectQualificationRequest Operation</seealso>
        IAsyncResult BeginRejectQualificationRequest(RejectQualificationRequestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RejectQualificationRequest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectQualificationRequest.</param>
        /// 
        /// <returns>Returns a  RejectQualificationRequestResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/RejectQualificationRequest">REST API Reference for RejectQualificationRequest Operation</seealso>
        RejectQualificationRequestResponse EndRejectQualificationRequest(IAsyncResult asyncResult);

        #endregion
        
        #region  SendBonus


        /// <summary>
        /// The <code>SendBonus</code> operation issues a payment of money from your account
        /// to a Worker. This payment happens separately from the reward you pay to the Worker
        /// when you approve the Worker's assignment. The SendBonus operation requires the Worker's
        /// ID and the assignment ID as parameters to initiate payment of the bonus. You must
        /// include a message that explains the reason for the bonus payment, as the Worker may
        /// not be expecting the payment. Amazon Mechanical Turk collects a fee for bonus payments,
        /// similar to the HIT listing fee. This operation fails if your account does not have
        /// enough funds to pay for both the bonus and the fees.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendBonus service method.</param>
        /// 
        /// <returns>The response from the SendBonus service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/SendBonus">REST API Reference for SendBonus Operation</seealso>
        SendBonusResponse SendBonus(SendBonusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendBonus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendBonus operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendBonus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/SendBonus">REST API Reference for SendBonus Operation</seealso>
        IAsyncResult BeginSendBonus(SendBonusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendBonus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendBonus.</param>
        /// 
        /// <returns>Returns a  SendBonusResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/SendBonus">REST API Reference for SendBonus Operation</seealso>
        SendBonusResponse EndSendBonus(IAsyncResult asyncResult);

        #endregion
        
        #region  SendTestEventNotification


        /// <summary>
        /// The <code>SendTestEventNotification</code> operation causes Amazon Mechanical Turk
        /// to send a notification message as if a HIT event occurred, according to the provided
        /// notification specification. This allows you to test notifications without setting
        /// up notifications for a real HIT type and trying to trigger them using the website.
        /// When you call this operation, the service attempts to send the test notification immediately.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendTestEventNotification service method.</param>
        /// 
        /// <returns>The response from the SendTestEventNotification service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/SendTestEventNotification">REST API Reference for SendTestEventNotification Operation</seealso>
        SendTestEventNotificationResponse SendTestEventNotification(SendTestEventNotificationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendTestEventNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendTestEventNotification operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendTestEventNotification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/SendTestEventNotification">REST API Reference for SendTestEventNotification Operation</seealso>
        IAsyncResult BeginSendTestEventNotification(SendTestEventNotificationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendTestEventNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendTestEventNotification.</param>
        /// 
        /// <returns>Returns a  SendTestEventNotificationResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/SendTestEventNotification">REST API Reference for SendTestEventNotification Operation</seealso>
        SendTestEventNotificationResponse EndSendTestEventNotification(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateExpirationForHIT


        /// <summary>
        /// The <code>UpdateExpirationForHIT</code> operation allows you update the expiration
        /// time of a HIT. If you update it to a time in the past, the HIT will be immediately
        /// expired.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateExpirationForHIT service method.</param>
        /// 
        /// <returns>The response from the UpdateExpirationForHIT service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateExpirationForHIT">REST API Reference for UpdateExpirationForHIT Operation</seealso>
        UpdateExpirationForHITResponse UpdateExpirationForHIT(UpdateExpirationForHITRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateExpirationForHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateExpirationForHIT operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateExpirationForHIT
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateExpirationForHIT">REST API Reference for UpdateExpirationForHIT Operation</seealso>
        IAsyncResult BeginUpdateExpirationForHIT(UpdateExpirationForHITRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateExpirationForHIT operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateExpirationForHIT.</param>
        /// 
        /// <returns>Returns a  UpdateExpirationForHITResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateExpirationForHIT">REST API Reference for UpdateExpirationForHIT Operation</seealso>
        UpdateExpirationForHITResponse EndUpdateExpirationForHIT(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateHITReviewStatus


        /// <summary>
        /// The <code>UpdateHITReviewStatus</code> operation updates the status of a HIT. If
        /// the status is Reviewable, this operation can update the status to Reviewing, or it
        /// can revert a Reviewing HIT back to the Reviewable status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHITReviewStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateHITReviewStatus service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateHITReviewStatus">REST API Reference for UpdateHITReviewStatus Operation</seealso>
        UpdateHITReviewStatusResponse UpdateHITReviewStatus(UpdateHITReviewStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHITReviewStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHITReviewStatus operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateHITReviewStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateHITReviewStatus">REST API Reference for UpdateHITReviewStatus Operation</seealso>
        IAsyncResult BeginUpdateHITReviewStatus(UpdateHITReviewStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateHITReviewStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateHITReviewStatus.</param>
        /// 
        /// <returns>Returns a  UpdateHITReviewStatusResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateHITReviewStatus">REST API Reference for UpdateHITReviewStatus Operation</seealso>
        UpdateHITReviewStatusResponse EndUpdateHITReviewStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateHITTypeOfHIT


        /// <summary>
        /// The <code>UpdateHITTypeOfHIT</code> operation allows you to change the HITType properties
        /// of a HIT. This operation disassociates the HIT from its old HITType properties and
        /// associates it with the new HITType properties. The HIT takes on the properties of
        /// the new HITType in place of the old ones.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateHITTypeOfHIT service method.</param>
        /// 
        /// <returns>The response from the UpdateHITTypeOfHIT service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateHITTypeOfHIT">REST API Reference for UpdateHITTypeOfHIT Operation</seealso>
        UpdateHITTypeOfHITResponse UpdateHITTypeOfHIT(UpdateHITTypeOfHITRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateHITTypeOfHIT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateHITTypeOfHIT operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateHITTypeOfHIT
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateHITTypeOfHIT">REST API Reference for UpdateHITTypeOfHIT Operation</seealso>
        IAsyncResult BeginUpdateHITTypeOfHIT(UpdateHITTypeOfHITRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateHITTypeOfHIT operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateHITTypeOfHIT.</param>
        /// 
        /// <returns>Returns a  UpdateHITTypeOfHITResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateHITTypeOfHIT">REST API Reference for UpdateHITTypeOfHIT Operation</seealso>
        UpdateHITTypeOfHITResponse EndUpdateHITTypeOfHIT(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateNotificationSettings


        /// <summary>
        /// The <code>UpdateNotificationSettings</code> operation creates, updates, disables
        /// or re-enables notifications for a HIT type. If you call the UpdateNotificationSettings
        /// operation for a HIT type that already has a notification specification, the operation
        /// replaces the old specification with a new one. You can call the UpdateNotificationSettings
        /// operation to enable or disable notifications for the HIT type, without having to modify
        /// the notification specification itself by providing updates to the Active status without
        /// specifying a new notification specification. To change the Active status of a HIT
        /// type's notifications, the HIT type must already have a notification specification,
        /// or one must be provided in the same call to <code>UpdateNotificationSettings</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateNotificationSettings service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateNotificationSettings">REST API Reference for UpdateNotificationSettings Operation</seealso>
        UpdateNotificationSettingsResponse UpdateNotificationSettings(UpdateNotificationSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotificationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotificationSettings operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNotificationSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateNotificationSettings">REST API Reference for UpdateNotificationSettings Operation</seealso>
        IAsyncResult BeginUpdateNotificationSettings(UpdateNotificationSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNotificationSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNotificationSettings.</param>
        /// 
        /// <returns>Returns a  UpdateNotificationSettingsResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateNotificationSettings">REST API Reference for UpdateNotificationSettings Operation</seealso>
        UpdateNotificationSettingsResponse EndUpdateNotificationSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateQualificationType


        /// <summary>
        /// The <code>UpdateQualificationType</code> operation modifies the attributes of an
        /// existing Qualification type, which is represented by a QualificationType data structure.
        /// Only the owner of a Qualification type can modify its attributes. 
        /// 
        ///  
        /// <para>
        ///  Most attributes of a Qualification type can be changed after the type has been created.
        /// However, the Name and Keywords fields cannot be modified. The RetryDelayInSeconds
        /// parameter can be modified or added to change the delay or to enable retries, but RetryDelayInSeconds
        /// cannot be used to disable retries. 
        /// </para>
        ///  
        /// <para>
        ///  You can use this operation to update the test for a Qualification type. The test
        /// is updated based on the values specified for the Test, TestDurationInSeconds and AnswerKey
        /// parameters. All three parameters specify the updated test. If you are updating the
        /// test for a type, you must specify the Test and TestDurationInSeconds parameters. The
        /// AnswerKey parameter is optional; omitting it specifies that the updated test does
        /// not have an answer key. 
        /// </para>
        ///  
        /// <para>
        ///  If you omit the Test parameter, the test for the Qualification type is unchanged.
        /// There is no way to remove a test from a Qualification type that has one. If the type
        /// already has a test, you cannot update it to be AutoGranted. If the Qualification type
        /// does not have a test and one is provided by an update, the type will henceforth have
        /// a test. 
        /// </para>
        ///  
        /// <para>
        ///  If you want to update the test duration or answer key for an existing test without
        /// changing the questions, you must specify a Test parameter with the original questions,
        /// along with the updated values. 
        /// </para>
        ///  
        /// <para>
        ///  If you provide an updated Test but no AnswerKey, the new test will not have an answer
        /// key. Requests for such Qualifications must be granted manually. 
        /// </para>
        ///  
        /// <para>
        ///  You can also update the AutoGranted and AutoGrantedValue attributes of the Qualification
        /// type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQualificationType service method.</param>
        /// 
        /// <returns>The response from the UpdateQualificationType service method, as returned by MTurk.</returns>
        /// <exception cref="Amazon.MTurk.Model.RequestErrorException">
        /// Your request is invalid.
        /// </exception>
        /// <exception cref="Amazon.MTurk.Model.ServiceException">
        /// Amazon Mechanical Turk is temporarily unable to process your request. Try your call
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateQualificationType">REST API Reference for UpdateQualificationType Operation</seealso>
        UpdateQualificationTypeResponse UpdateQualificationType(UpdateQualificationTypeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQualificationType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQualificationType operation on AmazonMTurkClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQualificationType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateQualificationType">REST API Reference for UpdateQualificationType Operation</seealso>
        IAsyncResult BeginUpdateQualificationType(UpdateQualificationTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQualificationType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQualificationType.</param>
        /// 
        /// <returns>Returns a  UpdateQualificationTypeResult from MTurk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mturk-requester-2017-01-17/UpdateQualificationType">REST API Reference for UpdateQualificationType Operation</seealso>
        UpdateQualificationTypeResponse EndUpdateQualificationType(IAsyncResult asyncResult);

        #endregion
        
    }
}